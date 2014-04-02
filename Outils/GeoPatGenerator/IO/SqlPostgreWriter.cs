using Emash.GeoPat.Generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Generator.IO
{
    public class SqlPostgreWriter
    {
        private int IndentLevel { get; set; }
        public Project Project { get; private set; }

        private StreamWriter Writer { get; set; }
        public SqlPostgreWriter(Project project)
        {
            this.Project = project;
          
     
        }

        public void Write()
        {
            String appPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            DirectoryInfo directory = new DirectoryInfo(appPath);
            DirectoryInfo directoryCode = directory;
            while (!directoryCode.Name.Equals("GeoPatV2"))
            { directoryCode = directoryCode.Parent; }
            String directorySql = Path.Combine(directoryCode.FullName, "Sql");
            String fileName = Path.Combine(directorySql, "Postgre.sql");
         
             using (FileStream stream = new FileStream(fileName, FileMode.Create))
             {
                 using (StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.Unicode))
                 {
                     this.Writer = writer;
                     foreach (DbSchema schema in this.Project.Schemas)
                     {
                         this.WriteLine("DROP SCHEMA \"" + schema.Name + "\" CASCADE;");
                         this.WriteLine("DROP ROLE  \"" + schema.Name + "_ADMIN\";");
                         this.WriteLine("DROP ROLE  \"" + schema.Name + "_CONSULT\";");
                     }
                     this.WriteLine("");
                     foreach (DbSchema schema in this.Project.Schemas)
                     {
                         this.WriteLine("CREATE USER  \"" + schema.Name + "_ADMIN\" WITH PASSWORD '" + schema.Name + "_ADMIN';");
                         this.WriteLine("CREATE USER  \"" + schema.Name + "_CONSULT\" WITH PASSWORD '" + schema.Name + "_CONSULT';");
                         this.WriteLine("CREATE SCHEMA  \"" + schema.Name + "\" AUTHORIZATION postgres;");
                         this.WriteLine("COMMENT ON SCHEMA  \"" + schema.Name + "\" IS '" + schema.DisplayName.Replace("'", "''") + "';");
                     }
                     this.WriteLine("");

                     foreach (DbSchema schema in this.Project.Schemas)
                     {
                         String schemaCamelCase = schema.Name.ToCamelCase("_");
                         this.WriteLine("");
                         foreach (DbTable table in schema.Tables)
                         {

                             this.WriteLine("CREATE TABLE  \"" + schema.Name + "\". \"" + table.Name + "\"");
                             this.WriteLine("(");
                             List<String> columnDefinitions = new List<string> ();
                             columnDefinitions.Add("\"ID_PK\" SERIAL");
                             List<DbKeyForeign> fkChilds = (from fk in schema.ForeignKeys where fk.TableIdChild.Equals(table.Id) select fk).ToList();
                             foreach (DbKeyForeign fkChild in fkChilds)
                             {
                                 DbTable parentTable = (from t in schema.Tables where t.Id.Equals(fkChild.TableIdParent) select t).FirstOrDefault();
                                 DbTable childTable = (from t in schema.Tables where t.Id.Equals(fkChild.TableIdChild) select t).FirstOrDefault();
                                 Boolean allowNull = true;
                                 foreach (DbKeyForeignJoin j in fkChild.Joins)
                                 {
                                     DbColumn childColumn = (from c in childTable.Columns where c.Id.Equals(j.ColumnIdChild) select c).FirstOrDefault();
                                     if (!childColumn.AllowNull)
                                     { allowNull = false; }
                                 }
                                 String parentClassName = schemaCamelCase + parentTable.Name.ToCamelCase("_");
                                 if (parentClassName.EndsWith(schemaCamelCase))
                                 { parentClassName = parentClassName.Substring(0, parentClassName.Length - schemaCamelCase.Length); }
                               
                                 if (allowNull)
                                 {
                                     columnDefinitions.Add("\"" + parentTable .Name+ "_ID_PK\" INTEGER");
                                   
                                 }
                                 else
                                 {
                                     columnDefinitions.Add("\"" + parentTable.Name + "_ID_PK\" INTEGER NOT NULL");
                                 }
                         

                             }


                             foreach (DbColumn column in table.Columns)
                             {
                                 
                                 if (column.Name.StartsWith(table.Name+"__"))
                                 { columnDefinitions.Add("\"" + column.Name.Substring(table.Name.Length + 2) + "\"" + " " + column.ToPostgreSqlDefinition()); }
                                 else
                                 { columnDefinitions.Add("\"" +column.Name + "\"" + column.ToPostgreSqlDefinition()); }
                             }
                             //= (from c in table.Columns select c.Name+" "+ c.ToPostgreSqlDefinition()).ToList();
                             this.WriteLine(String.Join (",\r\n",columnDefinitions));
                             this.WriteLine(");");
                             this.WriteLine("COMMENT ON TABLE \"" + schema.Name + "\".\"" + table.Name + "\" IS '"+table.DisplayName .Replace ("'","''")+"';");
                             foreach (DbColumn column in table.Columns)
                             {
                                 String columnName = column.Name;
                                 if (columnName.StartsWith(table.Name + "__"))
                                 { columnName = columnName.Substring(table.Name.Length + 2); }
                                 this.WriteLine("COMMENT ON COLUMN \"" + schema.Name + "\".\"" + table.Name + "\".\"" + columnName + "\" IS '" + column.DisplayName.Replace("'", "''") + "';");
                             }
                             this.WriteLine("");
                             
                         }
                     }
                     foreach (DbSchema schema in this.Project.Schemas)
                     {
                         foreach (DbTable table in schema.Tables)
                         {
                             this.WriteLine("ALTER TABLE \"" + schema.Name + "\".\"" + table.Name + "\"  ADD CONSTRAINT \"" + table.Name + "_PK\" PRIMARY KEY   (\"ID_PK\");");
                         }
                         foreach (DbKeyPrimary pk in schema.PrimaryKeys)
                         {
                             DbTable table = (from t in schema.Tables where t.Id.Equals (pk.TableId ) select t).FirstOrDefault();
                             List<DbColumn> columns = (from c in table.Columns where pk.ColumnIds.Contains (c.Id ) select c).ToList();
                             List<String> columnNames = new List<string>();
                             foreach (DbColumn column in columns)
                             {
                                 if (column.Name.StartsWith(table.Name + "__"))
                                 { columnNames.Add("\""+column.Name.Substring(table.Name.Length + 2)+"\""); }
                                 else
                                 { columnNames.Add("\""+column.Name+"\""); }
                             }
                             this.WriteLine("ALTER TABLE \"" + schema.Name + "\".\"" + table.Name + "\"  ADD CONSTRAINT \"" + table.Name + "_UK"+pk.Id+"\" UNIQUE   (" + String.Join(",", columnNames) + ");");
                             //
                         }
                         foreach (DbKeyForeign  fk in schema.ForeignKeys)
                         {
                             DbTable tableParent = (from t in schema.Tables where t.Id.Equals(fk.TableIdParent) select t).FirstOrDefault();
                             DbTable tableChild = (from t in schema.Tables where t.Id.Equals(fk.TableIdChild) select t).FirstOrDefault();
                             List<String> columnNamesChild = new List<string> ();
                             List<String> columnNamesParent = new List<string> ();
                             foreach (DbKeyForeignJoin j in fk.Joins)
                             {
                                 DbColumn parentColumn = (from c in tableParent.Columns where c.Id.Equals (j.ColumnIdParent ) select c).FirstOrDefault();
                                 DbColumn childColumn = (from c in tableChild.Columns where c.Id.Equals(j.ColumnIdChild) select c).FirstOrDefault();

                                 String columnNameParent = parentColumn.Name;
                                 if (columnNameParent.StartsWith(tableParent.Name + "__"))
                                 { columnNameParent = columnNameParent.Substring(tableParent.Name.Length + 2); }


                                 String columnNameChild = childColumn.Name;
                                 if (columnNameChild.StartsWith(tableChild.Name + "__"))
                                 {columnNameChild = columnNameChild.Substring(tableChild.Name.Length + 2); }
                               
                                 columnNamesChild.Add ("\""+columnNameChild+"\"");
                                 columnNamesParent.Add ("\""+columnNameParent+"\"");
                             }
                             this.WriteLine("ALTER TABLE \"" + schema.Name + "\".\"" + tableChild.Name + "\" ADD CONSTRAINT \"" + tableChild.Name + "__"+tableParent.Name+"_FK\" FOREIGN KEY ("+String.Join (",",columnNamesChild)+") ");
                             if (fk.DeleteOnCascade)
                             { this.WriteLine(" REFERENCES \"" + schema.Name + "\".\"" + tableParent.Name + "\" (" + String.Join(",", columnNamesParent) + ") MATCH SIMPLE ON UPDATE CASCADE ON DELETE CASCADE;"); }
                             else
                             { this.WriteLine(" REFERENCES \"" + schema.Name + "\".\"" + tableParent.Name + "\" (" + String.Join(",", columnNamesParent) + ") MATCH SIMPLE;"); }
                         
                             //ALTER TABLE INF.INF_ACCIDENT ADD CONSTRAINT INF_CHAUSSEE__INF_ACCIDENT FOREIGN KEY (INF_CHAUSSEE__ID) 
//REFERENCES INF.INF_CHAUSSEE (INF_CHAUSSEE__ID) MATCH SIMPLE ON UPDATE CASCADE ON DELETE CASCADE;
                         }
                     }
                     foreach (DbSchema schema in this.Project.Schemas)
                     {
                         this.WriteLine("GRANT USAGE ON SCHEMA \"" + schema.Name + "\" TO \"" + schema.Name + "_ADMIN\";");
                         this.WriteLine("GRANT USAGE ON SCHEMA \"" + schema.Name + "\" TO \"" + schema.Name + "_CONSULT\";");
                         
                         foreach (DbTable table in schema.Tables)
                         {
                             this.WriteLine("GRANT INSERT,DELETE,UPDATE ON \"" + schema .Name+ "\".\""+table.Name+"\" TO \""+schema.Name+"_ADMIN\";");
                             this.WriteLine("GRANT SELECT ON \"" + schema.Name + "\".\"" + table.Name + "\" TO \"" + schema.Name + "_CONSULT\";");
                             this.WriteLine("GRANT USAGE, SELECT ON SEQUENCE  \"" + schema.Name + "\".\"" + table.Name + "_ID_PK_seq\" TO \"" + schema.Name + "_CONSULT\";");
                             this.WriteLine("GRANT USAGE, SELECT ON SEQUENCE  \"" + schema.Name + "\".\"" + table.Name + "_ID_PK_seq\" TO \"" + schema.Name + "_ADMIN\";");
                             this.WriteLine("GRANT \"" + schema.Name + "_CONSULT\" TO \"" + schema.Name + "_ADMIN\";");

                            
                         }
                     }
                 }
             }
        }

        private void WriteLine(string content)
        {
            this.Writer.WriteLine(new String(" ".ToCharArray()[0], IndentLevel * 4) + content);
        }
    }

}
