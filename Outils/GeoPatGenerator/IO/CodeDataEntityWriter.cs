﻿using Emash.GeoPat.Generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Generator.IO
{
    public class CodeDataEntityWriter
    {
        public Project Project { get; private set; }
        public DbTable Table { get; private set; }
        public DbSchema Schema { get; private set; }
        private StreamWriter Writer { get;  set; }
        private int IndentLevel { get; set; }
        public CodeDataEntityWriter(Project project,DbSchema schema, DbTable table)
        {
            this.Project = project;
            this.Table = table;
            this.Schema = schema;
        }

        public void Write()
        {
            String appPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            DirectoryInfo directory = new DirectoryInfo(appPath);
            DirectoryInfo directoryCode = directory;
            while (!directoryCode.Name.Equals("GeoPatV2"))
            {directoryCode = directoryCode.Parent; }
            String directoryLayer = Path.Combine(directoryCode.FullName, "Layers");
            String directoryLayerData = Path.Combine(directoryLayer, "Data");
            String directoryLayerDataModel = Path.Combine(directoryLayerData, "Models");
            String schemaCamelCase = this.Schema.Name.ToCamelCase("_");
            String className = schemaCamelCase + Table.Name.ToCamelCase("_");
            if (className.EndsWith(schemaCamelCase))
            {className = className.Substring(0, className.Length - schemaCamelCase.Length);}
            String fileName = Path.Combine(directoryLayerDataModel, className + ".cs");
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream,System.Text.Encoding.Unicode ))
                {
                    this.Writer = writer;

                    DbKeyPrimary pk = (from k in Schema.PrimaryKeys where k.TableId.Equals (Table.Id ) select k).FirstOrDefault();
                    List<DbKeyUnique> uks = (from k in Schema.UniqueKeys where k.TableId.Equals(Table.Id) select k).ToList();
                    this.WriteLine("using System;");
                    this.WriteLine("using System.Collections.Generic;");
                    this.WriteLine("using System.ComponentModel;");                  
                    this.WriteLine("using System.ComponentModel.DataAnnotations;");
                    this.WriteLine("using System.ComponentModel.DataAnnotations.Schema;");
                    this.WriteLine("namespace Emash.GeoPat.Layers.Data.Models");
                    this.WriteBracketOpen();

                   
                    this.WriteLine("[Table(\""+this.Table.Name+"\",Schema=\""+this.Schema.Name+"\")]");
                    this.WriteLine("public partial class " + className + " : ModelBase");
                    this.WriteBracketOpen();

                    int columnOrder = 0;

                    List<DbKeyForeign> fkChilds = (from fk in Schema.ForeignKeys where fk.TableIdChild.Equals (Table.Id ) select fk).ToList();
                    List<DbKeyForeign> fkParents = (from fk in Schema.ForeignKeys where fk.TableIdParent.Equals(Table.Id) select fk).ToList();

                    foreach (DbKeyForeign fkChild in fkChilds)
                    {
                        DbTable parentTable = (from t in Schema.Tables where t.Id.Equals (fkChild.TableIdParent ) select t).FirstOrDefault();
                        DbTable childTable = (from t in Schema.Tables where t.Id.Equals(fkChild.TableIdChild) select t).FirstOrDefault();
                        Boolean allowNull = true;
                        foreach (DbKeyForeignJoin j in fkChild.Joins)
                        {
                            DbColumn childColumn = (from c in childTable.Columns where c.Id.Equals (j.ColumnIdChild ) select c).FirstOrDefault();
                            if (!childColumn.AllowNull)
                            { allowNull = false; }
                        }
                        String parentClassName = schemaCamelCase + parentTable.Name.ToCamelCase("_");
                        if (parentClassName.EndsWith(schemaCamelCase))
                        { parentClassName = parentClassName.Substring(0, parentClassName.Length - schemaCamelCase.Length); }


                        /*
                         * private PrfBmProfil _prfBmProfil;

        public virtual PrfBmProfil PrfBmProfil 
        {
            get
            {
                return this._prfBmProfil;
            }
            set
            {
                this._prfBmProfil = value;
                this.BmProfilProfil = this._prfBmProfil.Profil;
            }
        }
                         * */

                        string parentVariableName = "_" + parentClassName.Substring(0, 1).ToLower() + parentClassName.Substring(1);
                        this.WriteLine("private " + parentClassName + " " + parentVariableName + ";");
                        this.WriteLine("public virtual " + parentClassName + " " + parentClassName + " ");
                        this.WriteBracketOpen();
                        this.WriteLine("get");
                        this.WriteBracketOpen();
                        this.WriteLine("return this." + parentVariableName + ";");
                        this.WriteLine("");
                        this.WriteBracketClose();


                        this.WriteLine("set");
                        this.WriteBracketOpen();
                        this.WriteLine("this." + parentVariableName + " = value;");
                        foreach (DbKeyForeignJoin j in fkChild.Joins)
                        {
                            DbColumn colunmChild = (from c in childTable.Columns where c.Id.Equals (j.ColumnIdChild ) select c).FirstOrDefault();
                            DbColumn colunmParent = (from c in parentTable.Columns where c.Id.Equals(j.ColumnIdParent) select c).FirstOrDefault();
                            string propChildName = colunmChild.Name.ToCamelCase("_");
                            string propParentName = colunmParent.Name.ToCamelCase("_");
                            if (propParentName.StartsWith(parentClassName.Substring (Schema.Name.ToCamelCase ("_").Length)))
                            {
                                propParentName = propParentName.Substring(parentClassName.Substring(Schema.Name.Length).Length);
                            }
                            if (propParentName.StartsWith(Schema.Name.ToCamelCase("_")))
                            {
                                propParentName = propParentName.Substring(Schema.Name.Length);
                            }
                            this.WriteLine("this." + propChildName + " = this." + parentVariableName + "." + propParentName + ";");

                        }
                        this.WriteBracketClose();

                        this.WriteBracketClose();
                      
                       
                        this.WriteLine("");




                        if (allowNull)
                        {
                            this.WriteLine("[Column(\"" + parentTable.Name + "_ID_PK\",Order=" + columnOrder + ")]");
                            columnOrder++;
                            this.WriteLine("public Nullable<Int64> " + parentClassName + "IdPk {get;set;}");
                        }
                        else
                        {
                            this.WriteLine("[Required()]");
                            this.WriteLine("[Column(\"" + parentTable.Name + "_ID_PK\",Order=" + columnOrder + ")]");
                            columnOrder++;
                            this.WriteLine("public Int64 " + parentClassName + "IdPk {get;set;}");
                        }
                        this.WriteLine("");
                      
                    }
                    foreach (DbKeyForeign fkParent in fkParents)
                    {
                        DbTable childTable = (from t in Schema.Tables where t.Id.Equals(fkParent.TableIdChild) select t).FirstOrDefault();
                        String childClassName = schemaCamelCase + childTable.Name.ToCamelCase("_");
                        if (childClassName.EndsWith(schemaCamelCase))
                        { childClassName = childClassName.Substring(0, childClassName.Length - schemaCamelCase.Length); }
                       this.WriteLine("public virtual ICollection<" + childClassName + "> " + childClassName + "s { get; set; }");
                       this.WriteLine("");
                    }

                    this.WriteLine("[Key]");
                    this.WriteLine("[Column(\"ID_PK\",Order=" + columnOrder + ")]");
                    columnOrder++;
                    this.WriteLine("[Required()]");
                    this.WriteLine("public Int64 IdPk { get; set; }");
                    foreach (DbColumn column in Table.Columns)
                    {
                        
                        String columnName = column.Name;
                        if (columnName.StartsWith(Table.Name + "_"))
                        { columnName = columnName.Substring(Table.Name.Length + 1); }
                        if (columnName.StartsWith("_"))
                        {columnName = columnName.Substring(1);}
                        String propertyName = columnName;                   
                        propertyName = propertyName.ToCamelCase("_");
                        if (column.DataType.StartsWith("VARCHAR2"))
                        {
                            foreach (DbKeyUnique uk in uks)
                            {
                                if (uk.ColumnIds.Contains(column.Id))
                                { this.WriteLine("[Index(\"UQ_" + uk.Name + "\"," + uk.ColumnIds.IndexOf(column.Id) + " , IsUnique = true)]"); }
                            }
                           // if (pk != null && pk.ColumnIds.Contains(column.Id))
                          //  {this.WriteLine("[Key]");}
                            this.WriteLine("[Description(\"" + column.DisplayName.Replace ("\"","\\\"") + "\")]");
                            this.WriteLine("[Column(\"" + columnName + "\",Order=" + columnOrder + ")]");
                            if (!column.AllowNull)
                            {this.WriteLine("[Required()]");}
                            if (column.Length.HasValue)
                            {this.WriteLine("[MaxLength(" + column.Length.Value + ")] "); }
                            this.WriteLine("public String " + propertyName + " { get; set; }");
                            this.WriteLine("");
                         
                        }
                        else if (column.DataType.StartsWith("DATE"))
                        {
                            foreach (DbKeyUnique uk in uks)
                            {
                                if (uk.ColumnIds.Contains(column.Id))
                                { this.WriteLine("[Index(\"UQ_" + uk.Name + "\"," + uk.ColumnIds.IndexOf(column.Id) + ", IsUnique = true )]"); }
                            }
                           // if (pk != null && pk.ColumnIds.Contains(column.Id))
                           // { this.WriteLine("[Key]"); }
                            this.WriteLine("[Description(\"" + column.DisplayName.Replace("\"", "\\\"") + "\")]");
                            this.WriteLine("[Column(\"" + columnName + "\",Order=" + columnOrder + ")]");
                            if (!column.AllowNull)
                            {
                                this.WriteLine("[Required()]");
                                this.WriteLine("public DateTime " + propertyName + " { get; set; }");
                            }
                            else
                            {
                                this.WriteLine("public Nullable<DateTime> " + propertyName + " { get; set; }");
                            }
                            this.WriteLine("");
                           
                        }
                        else if (column.DataType.StartsWith("SMALLINT"))
                        {
                            foreach (DbKeyUnique uk in uks)
                            {
                                if (uk.ColumnIds.Contains(column.Id))
                                { this.WriteLine("[Index(\"UQ_" + uk.Name + "\"," + uk.ColumnIds.IndexOf(column.Id) + " , IsUnique = true)]"); }
                            }
                          //  if (pk != null && pk.ColumnIds.Contains(column.Id))
                           // { this.WriteLine("[Key]"); }
                            this.WriteLine("[Description(\"" + column.DisplayName.Replace("\"", "\\\"") + "\")]");
                            this.WriteLine("[Column(\"" + columnName + "\",Order=" + columnOrder + ")]");
                            if (!column.AllowNull)
                            {
                                
                                this.WriteLine("[Required()]");
                                this.WriteLine("public int " + propertyName + "ValueInt { get; set; }");
                                this.WriteLine("[NotMapped]");
                                this.WriteLine("public Boolean " + propertyName + " ");
                                this.WriteBracketOpen ();
                                this.WriteLine ("get");
                                this.WriteBracketOpen ();
                                this.WriteLine("return Convert.ToBoolean(" + propertyName + "ValueInt);");
                                this.WriteBracketClose ();

                                this.WriteLine ("set");
                                this.WriteBracketOpen ();
                                this.WriteLine("this." + propertyName + "ValueInt = Convert.ToInt32(value);");
                                this.WriteBracketClose ();

                                this.WriteBracketClose ();
                               
                                

                            }
                            else
                            {
                        
                                this.WriteLine("public Nullable<int> " + propertyName + "ValueInt { get; set; }");
                                this.WriteLine("[NotMapped]");
                                this.WriteLine("public Nullable<Boolean> " + propertyName + " ");
                                this.WriteBracketOpen();
                                this.WriteLine("get");
                                this.WriteBracketOpen();
                                this.WriteLine("if (" + propertyName + "ValueInt.HasValue) return Convert.ToBoolean(" + propertyName + "ValueInt.Value);");
                                this.WriteLine("else return null;");
                                this.WriteBracketClose();
                                this.WriteLine("set");
                                this.WriteBracketOpen();
                                this.WriteLine("if (value.HasValue) {this." + propertyName + "ValueInt = Convert.ToInt32(value.Value);}");
                                this.WriteLine("else {this." + propertyName + "ValueInt =null;}");
                                this.WriteBracketClose();

                                this.WriteBracketClose();
                            }

                            this.WriteLine("");
                        }
                        else if ((column.DataType.StartsWith("NUMBER") && column.DataType.IndexOf (",") == -1) || column.DataType.StartsWith ("INTEGER"))
                        {
                            foreach (DbKeyUnique uk in uks)
                            {
                                if (uk.ColumnIds.Contains(column.Id))
                                { this.WriteLine("[Index(\"UQ_" + uk.Name + "\"," + uk.ColumnIds.IndexOf(column.Id) + ", IsUnique = true )]"); }
                            }
                            //if (pk != null && pk.ColumnIds.Contains(column.Id))
                          //  { this.WriteLine("[Key]"); }
                            this.WriteLine("[Description(\"" + column.DisplayName.Replace("\"", "\\\"") + "\")]");
                            this.WriteLine("[Column(\"" + columnName + "\",Order=" + columnOrder + ")]");
                            if (!column.AllowNull)
                            {
                                this.WriteLine("[Required()]");
                                this.WriteLine("public Int64 " + propertyName + " { get; set; }");
                            }
                            else
                            {
                                this.WriteLine("public Nullable<Int64> " + propertyName + " { get; set; }");
                            }
                            this.WriteLine("");

                        }
                        else if ((column.DataType.StartsWith("NUMBER") && column.DataType.IndexOf(",") != -1) || column.DataType.StartsWith("FLOAT"))
                        {
                            foreach (DbKeyUnique uk in uks)
                            {
                                if (uk.ColumnIds.Contains(column.Id))
                                { this.WriteLine("[Index(\"UQ_" + uk.Name + "\"," + uk.ColumnIds.IndexOf(column.Id) + " , IsUnique = true)]"); }
                            }
                           // if (pk != null && pk.ColumnIds.Contains(column.Id))
                          //  { this.WriteLine("[Key]"); }
                            this.WriteLine("[Description(\"" + column.DisplayName.Replace("\"", "\\\"") + "\")]");
                            this.WriteLine("[Column(\"" + columnName + "\",Order=" + columnOrder + ")]");
                            if (!column.AllowNull)
                            {
                                this.WriteLine("[Required()]");
                                this.WriteLine("public Double " + propertyName + " { get; set; }");
                            }
                            else
                            {
                                this.WriteLine("public Nullable<Double> " + propertyName + " { get; set; }");
                            }
                            this.WriteLine("");

                        }
                        //
                        else
                        {

                            Console.WriteLine("Non implémenté : " + column.Name +" "+ column.DataType);
                        }
                        columnOrder++;
                    }

                    this.WriteBracketClose();
                    this.WriteBracketClose();
                }
            }
           
            
       
        }

        private void WriteBracketClose()
        {
            this.IndentLevel--;
            this.WriteLine("}");
  
        }

        private void WriteBracketOpen()
        {
            this.WriteLine("{");
            this.IndentLevel++;
        }

        private void WriteLine(string content)
        {
           this.Writer.WriteLine (new String(" ".ToCharArray ()[0],IndentLevel *4)+content );
        }
    }
}
