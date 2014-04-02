using Emash.GeoPat.Generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoPatGenerator.IO
{
    public  class CodeBuisnessEntityWriter
    {
         public Project Project { get; private set; }
        public DbTable Table { get; private set; }
        public DbSchema Schema { get; private set; }
        private StreamWriter Writer { get;  set; }
        private int IndentLevel { get; set; }
        public CodeBuisnessEntityWriter(Project project, DbSchema schema, DbTable table)
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
            String directoryLayerBuisness = Path.Combine(directoryLayer, "Buisness");
            String directoryLayerBuisnessViewModels = Path.Combine(directoryLayerBuisness, "ViewModels ");
          
            String schemaCamelCase = this.Schema.Name.ToCamelCase("_");
            String className = schemaCamelCase + Table.Name.ToCamelCase("_");
            if (className.EndsWith(schemaCamelCase))
            {className = className.Substring(0, className.Length - schemaCamelCase.Length);}
            string modelClassName = className;
            className = className + "ViewModel";
            String fileName = Path.Combine(directoryLayerBuisnessViewModels, className + ".cs");
            List<DbKeyForeign> fkChilds = (from fk in Schema.ForeignKeys where fk.TableIdChild.Equals(Table.Id) select fk).ToList();
            List<DbKeyForeign> fkParents = (from fk in Schema.ForeignKeys where fk.TableIdParent.Equals(Table.Id) select fk).ToList();

            List<DbColumn> nonMappedColumns = new List<DbColumn>();
            foreach (DbKeyForeign fkChild in fkChilds)
            {
                foreach (DbKeyForeignJoin j in fkChild.Joins)
                { 
                    DbColumn column = (from c in Table.Columns where c.Id.Equals (  j.ColumnIdChild )select c).FirstOrDefault ();
                    nonMappedColumns.Add(column);
                }
            }
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream,System.Text.Encoding.Unicode ))
                {
                    this.Writer = writer;
                    this.WriteLine("using System;");
                    this.WriteLine("using System.Collections.ObjectModel;");
                    this.WriteLine("using System.Collections.Generic;");
                    this.WriteLine("using System.ComponentModel;");
                    this.WriteLine("using Emash.GeoPat.Layers.Data.Models;");
                    this.WriteLine("namespace Emash.GeoPat.Layers.Buisness.ViewModels");
                    this.WriteBracketOpen();
                    this.WriteLine("public partial class " + className + " : ViewModelBase<" + modelClassName + ">");
                    this.WriteBracketOpen();

                   

                    
                    this.WriteLine("public " + className + "(" + modelClassName + " model) : base(model)");
                    this.WriteBracketOpen();
                    foreach (DbKeyForeign fkParent in fkParents)
                    {
                        DbTable childTable = (from t in Schema.Tables where t.Id.Equals(fkParent.TableIdChild) select t).FirstOrDefault();
                        String childClassName = schemaCamelCase + childTable.Name.ToCamelCase("_");
                        if (childClassName.EndsWith(schemaCamelCase))
                        { childClassName = childClassName.Substring(0, childClassName.Length - schemaCamelCase.Length); }
                        this.WriteLine("this." + childClassName + "s = new  ObservableCollection<" + childClassName + "ViewModel>();");
                        this.WriteLine("");
                    }

                   
                    this.WriteBracketClose();

                    this.WriteLine("public override void Read()");
                    this.WriteBracketOpen();
                    foreach (DbKeyForeign fkChild in fkChilds)
                    {
                        DbTable parentTable = (from t in Schema.Tables where t.Id.Equals(fkChild.TableIdParent) select t).FirstOrDefault();
                        String parentClassName = schemaCamelCase + parentTable.Name.ToCamelCase("_");
                        if (parentClassName.EndsWith(schemaCamelCase))
                        { parentClassName = parentClassName.Substring(0, parentClassName.Length - schemaCamelCase.Length); }
                        string parentVariableName = parentClassName;
                        this.WriteLine("this." + parentClassName + "=new " + parentClassName + "ViewModel( this.Model." + parentClassName + ");");
                        
                    }

                   
                    foreach (DbColumn column in Table.Columns)
                    {
                        if (!nonMappedColumns.Contains(column))
                        {
                            String columnName = column.Name;
                            if (columnName.StartsWith(Table.Name + "_"))
                            { columnName = columnName.Substring(Table.Name.Length + 1); }
                            if (columnName.StartsWith("_"))
                            { columnName = columnName.Substring(1); }
                            String propertyName = columnName;
                            propertyName = propertyName.ToCamelCase("_");
                            string variableName = "_" + propertyName.Substring(0, 1).ToLower() + propertyName.Substring(1);

                            this.WriteLine("this." + propertyName + "=this.Model." + propertyName + ";");
                        }
                    }
                    this.WriteBracketClose();


                    this.WriteLine("public override void Write()");
                    this.WriteBracketOpen();
                    foreach (DbKeyForeign fkChild in fkChilds)
                    {
                        DbTable parentTable = (from t in Schema.Tables where t.Id.Equals(fkChild.TableIdParent) select t).FirstOrDefault();
                        String parentClassName = schemaCamelCase + parentTable.Name.ToCamelCase("_");
                        if (parentClassName.EndsWith(schemaCamelCase))
                        { parentClassName = parentClassName.Substring(0, parentClassName.Length - schemaCamelCase.Length); }
                        string parentVariableName = parentClassName;
                        this.WriteLine("this.Model." + parentClassName + "=this. " + parentClassName + ".Model;");

                    }
                    foreach (DbColumn column in Table.Columns)
                    {
                        if (!nonMappedColumns.Contains(column))
                        {
                            String columnName = column.Name;
                            if (columnName.StartsWith(Table.Name + "_"))
                            { columnName = columnName.Substring(Table.Name.Length + 1); }
                            if (columnName.StartsWith("_"))
                            { columnName = columnName.Substring(1); }
                            String propertyName = columnName;
                            propertyName = propertyName.ToCamelCase("_");
                            string variableName = "_" + propertyName.Substring(0, 1).ToLower() + propertyName.Substring(1);

                            this.WriteLine("this.Model." + propertyName + "=this." + propertyName + ";");
                        }
                    }
                    this.WriteBracketClose();


                    foreach (DbKeyForeign fkChild in fkChilds)
                    {
                        DbTable parentTable = (from t in Schema.Tables where t.Id.Equals(fkChild.TableIdParent) select t).FirstOrDefault();
                        String parentClassName = schemaCamelCase + parentTable.Name.ToCamelCase("_");
                        if (parentClassName.EndsWith(schemaCamelCase))
                        { parentClassName = parentClassName.Substring(0, parentClassName.Length - schemaCamelCase.Length); }

                        string parentVariableName = parentClassName;
                        parentVariableName = "_"+parentVariableName.Substring(0, 1).ToLower() + parentVariableName.Substring(1);
                        this.WriteLine("private "+parentClassName+"ViewModel "+parentVariableName+";");
                        this.WriteLine("[DisplayName(\"" + parentTable.DisplayName + "\")]");
                        this.WriteLine("public virtual " + parentClassName + "ViewModel " + parentClassName + "");
                        this.WriteBracketOpen();
                        this.WriteLine("get");
                        this.WriteBracketOpen();
                        this.WriteLine("return this." + parentVariableName + ";");
                        this.WriteBracketClose();
                        this.WriteLine("set");
                        this.WriteBracketOpen();
                        this.WriteLine("this." + parentVariableName + " = value;");
                        this.WriteLine("RaisePropertyChange(\"" + parentClassName + "\");");
                        this.WriteBracketClose();
                        this.WriteBracketClose();
                       
                        this.WriteLine("");
                    }
                    foreach (DbKeyForeign fkParent in fkParents)
                    {
                        DbTable childTable = (from t in Schema.Tables where t.Id.Equals(fkParent.TableIdChild) select t).FirstOrDefault();
                        String childClassName = schemaCamelCase + childTable.Name.ToCamelCase("_");
                        if (childClassName.EndsWith(schemaCamelCase))
                        { childClassName = childClassName.Substring(0, childClassName.Length - schemaCamelCase.Length); }
                        this.WriteLine("public virtual ObservableCollection<" + childClassName + "ViewModel> " + childClassName + "s { get; set; }");
                        this.WriteLine("");
                    }


                    foreach (DbColumn column in Table.Columns)
                    {
                        if (!nonMappedColumns.Contains(column))
                        {
                            String columnName = column.Name;
                            if (columnName.StartsWith(Table.Name + "_"))
                            { columnName = columnName.Substring(Table.Name.Length + 1); }
                            if (columnName.StartsWith("_"))
                            { columnName = columnName.Substring(1); }
                            String propertyName = columnName;
                            propertyName = propertyName.ToCamelCase("_");
                            string variableName = "_" + propertyName.Substring(0, 1).ToLower() + propertyName.Substring(1);

                            if (column.DataType.StartsWith("VARCHAR2"))
                            {
                                this.WriteLine("private String " + variableName + ";");
                                this.WriteLine("[DisplayName(\""+column.DisplayName+"\")]");
                                this.WriteLine("public String " + propertyName + "");
                                this.WriteBracketOpen();
                                this.WriteLine("get");
                                this.WriteBracketOpen();
                                this.WriteLine("return this." + variableName + ";");
                                this.WriteBracketClose();
                                this.WriteLine("set");
                                this.WriteBracketOpen();
                                this.WriteLine("this." + variableName + " = value;");
                                this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                this.WriteBracketClose();
                                this.WriteBracketClose();

                            }
                            else if (column.DataType.StartsWith("DATE"))
                            {

                                if (!column.AllowNull)
                                {

                                    this.WriteLine("private DateTime " + variableName + ";");
                                    this.WriteLine("[DisplayName(\"" + column.DisplayName + "\")]");
                                    this.WriteLine("public DateTime " + propertyName + "");
                                    this.WriteBracketOpen();
                                    this.WriteLine("get");
                                    this.WriteBracketOpen();
                                    this.WriteLine("return this." + variableName + ";");
                                    this.WriteBracketClose();
                                    this.WriteLine("set");
                                    this.WriteBracketOpen();
                                    this.WriteLine("this." + variableName + " = value;");
                                    this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                    this.WriteBracketClose();
                                    this.WriteBracketClose();
                                }
                                else
                                {
                                    this.WriteLine("private Nullable<DateTime> " + variableName + ";");
                                    this.WriteLine("[DisplayName(\"" + column.DisplayName + "\")]");
                                    this.WriteLine("public Nullable<DateTime> " + propertyName + "");
                                    this.WriteBracketOpen();
                                    this.WriteLine("get");
                                    this.WriteBracketOpen();
                                    this.WriteLine("return this." + variableName + ";");
                                    this.WriteBracketClose();
                                    this.WriteLine("set");
                                    this.WriteBracketOpen();
                                    this.WriteLine("this." + variableName + " = value;");
                                    this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                    this.WriteBracketClose();
                                    this.WriteBracketClose();
                                }
                                this.WriteLine("");

                            }
                            else if (column.DataType.StartsWith("SMALLINT"))
                            {

                                if (!column.AllowNull)
                                {
                                    this.WriteLine("private Boolean " + variableName + ";");
                                    this.WriteLine("[DisplayName(\"" + column.DisplayName + "\")]");
                                    this.WriteLine("public Boolean " + propertyName + "");
                                    this.WriteBracketOpen();
                                    this.WriteLine("get");
                                    this.WriteBracketOpen();
                                    this.WriteLine("return this." + variableName + ";");
                                    this.WriteBracketClose();
                                    this.WriteLine("set");
                                    this.WriteBracketOpen();
                                    this.WriteLine("this." + variableName + " = value;");
                                    this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                    this.WriteBracketClose();
                                    this.WriteBracketClose();
                                }
                                else
                                {
                                    this.WriteLine("private Nullable<Boolean> " + variableName + ";");
                                    this.WriteLine("[DisplayName(\"" + column.DisplayName + "\")]");
                                    this.WriteLine("public Nullable<Boolean> " + propertyName + "");
                                    this.WriteBracketOpen();
                                    this.WriteLine("get");
                                    this.WriteBracketOpen();
                                    this.WriteLine("return this." + variableName + ";");
                                    this.WriteBracketClose();
                                    this.WriteLine("set");
                                    this.WriteBracketOpen();
                                    this.WriteLine("this." + variableName + " = value;");
                                    this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                    this.WriteBracketClose();
                                    this.WriteBracketClose();
                                }

                                this.WriteLine("");
                            }
                            else if ((column.DataType.StartsWith("NUMBER") && column.DataType.IndexOf(",") == -1) || column.DataType.StartsWith("INTEGER"))
                            {

                                if (!column.AllowNull)
                                {
                                    this.WriteLine("private Int64 " + variableName + ";");
                                    this.WriteLine("[DisplayName(\"" + column.DisplayName + "\")]");
                                    this.WriteLine("public Int64 " + propertyName + "");
                                    this.WriteBracketOpen();
                                    this.WriteLine("get");
                                    this.WriteBracketOpen();
                                    this.WriteLine("return this." + variableName + ";");
                                    this.WriteBracketClose();
                                    this.WriteLine("set");
                                    this.WriteBracketOpen();
                                    this.WriteLine("this." + variableName + " = value;");
                                    this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                    this.WriteBracketClose();
                                    this.WriteBracketClose();


                                }
                                else
                                {
                                    this.WriteLine("private Nullable<Int64> " + variableName + ";");
                                    this.WriteLine("[DisplayName(\"" + column.DisplayName + "\")]");
                                    this.WriteLine("public Nullable<Int64> " + propertyName + "");
                                    this.WriteBracketOpen();
                                    this.WriteLine("get");
                                    this.WriteBracketOpen();
                                    this.WriteLine("return this." + variableName + ";");
                                    this.WriteBracketClose();
                                    this.WriteLine("set");
                                    this.WriteBracketOpen();
                                    this.WriteLine("this." + variableName + " = value;");
                                    this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                    this.WriteBracketClose();
                                    this.WriteBracketClose();


                                }
                                this.WriteLine("");

                            }
                            else if ((column.DataType.StartsWith("NUMBER") && column.DataType.IndexOf(",") != -1) || column.DataType.StartsWith("FLOAT"))
                            {

                                if (!column.AllowNull)
                                {

                                    this.WriteLine("private Double " + variableName + ";");
                                    this.WriteLine("[DisplayName(\"" + column.DisplayName + "\")]");
                                    this.WriteLine("public Double " + propertyName + "");
                                    this.WriteBracketOpen();
                                    this.WriteLine("get");
                                    this.WriteBracketOpen();
                                    this.WriteLine("return this." + variableName + ";");
                                    this.WriteBracketClose();
                                    this.WriteLine("set");
                                    this.WriteBracketOpen();
                                    this.WriteLine("this." + variableName + " = value;");
                                    this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                    this.WriteBracketClose();
                                    this.WriteBracketClose();



                                }
                                else
                                {

                                    this.WriteLine("private Nullable<Double> " + variableName + ";");
                                    this.WriteLine("[DisplayName(\"" + column.DisplayName + "\")]");
                                    this.WriteLine("public Nullable<Double> " + propertyName + "");
                                    this.WriteBracketOpen();
                                    this.WriteLine("get");
                                    this.WriteBracketOpen();
                                    this.WriteLine("return this." + variableName + ";");
                                    this.WriteBracketClose();
                                    this.WriteLine("set");
                                    this.WriteBracketOpen();
                                    this.WriteLine("this." + variableName + " = value;");
                                    this.WriteLine("RaisePropertyChange(\"" + propertyName + "\");");
                                    this.WriteBracketClose();
                                    this.WriteBracketClose();

                                }
                                this.WriteLine("");

                            }
                            //
                            else
                            {

                                Console.WriteLine("Non implémenté : " + column.Name + " " + column.DataType);
                            }
                        }
                        

                    }


                    /*/
                     * public override string Error
        {
            get { throw new NotImplementedException(); }
        }

        public override string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }
                     * */
                    this.WriteLine("public override string Error");
                    this.WriteBracketOpen();
                    this.WriteLine("get");
                    this.WriteBracketOpen();
                    this.WriteLine("List<String> errors = new List<String>();");
                    foreach (DbColumn column in Table.Columns)
                    {
                        if (!nonMappedColumns.Contains(column))
                        {
                            String columnName = column.Name;
                            if (columnName.StartsWith(Table.Name + "_"))
                            { columnName = columnName.Substring(Table.Name.Length + 1); }
                            if (columnName.StartsWith("_"))
                            { columnName = columnName.Substring(1); }
                            String propertyName = columnName;
                            propertyName = propertyName.ToCamelCase("_");

                            this.WriteLine("if (this[\"" + propertyName + "\"] != null)");
                            this.WriteBracketOpen();
                            this.WriteLine("errors.Add(\"" + column.DisplayName + " : \"+this[\"" + propertyName + "\"]" + ");");
                            this.WriteBracketClose();
                        }
                    }
                    this.WriteLine("if (errors.Count > 0)");
                    this.WriteBracketOpen();
                    this.WriteLine("return String.Join(\"\\r\\n\",errors);");
                    this.WriteBracketClose();
                    this.WriteLine("else return null;");
                   

                    this.WriteBracketClose();
                    this.WriteBracketClose();



                    this.WriteLine("public override string this[string columnName]");
                    this.WriteBracketOpen();
                    this.WriteLine("get");
                    this.WriteBracketOpen();
                    foreach (DbColumn column in Table.Columns)
                    {
                        if (!nonMappedColumns.Contains(column))
                        {
                            String columnName = column.Name;
                            if (columnName.StartsWith(Table.Name + "_"))
                            { columnName = columnName.Substring(Table.Name.Length + 1); }
                            if (columnName.StartsWith("_"))
                            { columnName = columnName.Substring(1); }
                            String propertyName = columnName;
                            propertyName = propertyName.ToCamelCase("_");

                         
                            this.WriteLine("if (columnName.Equals(\""+propertyName+"\"))");
                            this.WriteBracketOpen();
                            if (!column.AllowNull && column.DataType.StartsWith("VARCHAR"))                            
                            {
                                this.WriteLine("if (String.IsNullOrEmpty(this." + propertyName + "))");
                                this.WriteBracketOpen();
                                this.WriteLine("return \"valeur vide non autorisée\";");
                                this.WriteBracketClose();
                            }
                            this.WriteBracketClose();
                        }
                    }
                        

                    this.WriteLine("return null;");
                    this.WriteBracketClose();
                    this.WriteBracketClose();



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
            this.Writer.WriteLine(new String(" ".ToCharArray()[0], IndentLevel * 4) + content);
        }
    }
}
