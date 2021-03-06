using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbMapMetierViewModel : ViewModelBase<MapinfoTbMapMetier>
    {
        public MapinfoTbMapMetierViewModel(MapinfoTbMapMetier model) : base(model)
        {
            this.MapinfoTbMapMetierCfgs = new  ObservableCollection<MapinfoTbMapMetierCfgViewModel>();
            
            this.MapinfoTbMapMetierColumnss = new  ObservableCollection<MapinfoTbMapMetierColumnsViewModel>();
            
        }
        public override void Read()
        {
            this.SchemaName=this.Model.SchemaName;
            this.TableName=this.Model.TableName;
            this.Title=this.Model.Title;
            this.MapOrder=this.Model.MapOrder;
            this.Rang=this.Model.Rang;
            this.Objtype=this.Model.Objtype;
        }
        public override void Write()
        {
            this.Model.SchemaName=this.SchemaName;
            this.Model.TableName=this.TableName;
            this.Model.Title=this.Title;
            this.Model.MapOrder=this.MapOrder;
            this.Model.Rang=this.Rang;
            this.Model.Objtype=this.Objtype;
        }
        public virtual ObservableCollection<MapinfoTbMapMetierCfgViewModel> MapinfoTbMapMetierCfgs { get; set; }
        
        public virtual ObservableCollection<MapinfoTbMapMetierColumnsViewModel> MapinfoTbMapMetierColumnss { get; set; }
        
        private String _schemaName;
        [DisplayName("Tb Map Metier  Schema Name")]
        public String SchemaName
        {
            get
            {
                return this._schemaName;
            }
            set
            {
                this._schemaName = value;
                RaisePropertyChange("SchemaName");
            }
        }
        private String _tableName;
        [DisplayName("Tb Map Metier  Table Name")]
        public String TableName
        {
            get
            {
                return this._tableName;
            }
            set
            {
                this._tableName = value;
                RaisePropertyChange("TableName");
            }
        }
        private String _title;
        [DisplayName("Tb Map Metier  Title")]
        public String Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
                RaisePropertyChange("Title");
            }
        }
        private Nullable<Int64> _mapOrder;
        [DisplayName("Tb Map Metier  Map Order")]
        public Nullable<Int64> MapOrder
        {
            get
            {
                return this._mapOrder;
            }
            set
            {
                this._mapOrder = value;
                RaisePropertyChange("MapOrder");
            }
        }
        
        private Nullable<Int64> _rang;
        [DisplayName("Tb Map Metier  Rang")]
        public Nullable<Int64> Rang
        {
            get
            {
                return this._rang;
            }
            set
            {
                this._rang = value;
                RaisePropertyChange("Rang");
            }
        }
        
        private Nullable<Int64> _objtype;
        [DisplayName("Tb Map Metier  ObjType")]
        public Nullable<Int64> Objtype
        {
            get
            {
                return this._objtype;
            }
            set
            {
                this._objtype = value;
                RaisePropertyChange("Objtype");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["SchemaName"] != null)
                {
                    errors.Add("Tb Map Metier  Schema Name : "+this["SchemaName"]);
                }
                if (this["TableName"] != null)
                {
                    errors.Add("Tb Map Metier  Table Name : "+this["TableName"]);
                }
                if (this["Title"] != null)
                {
                    errors.Add("Tb Map Metier  Title : "+this["Title"]);
                }
                if (this["MapOrder"] != null)
                {
                    errors.Add("Tb Map Metier  Map Order : "+this["MapOrder"]);
                }
                if (this["Rang"] != null)
                {
                    errors.Add("Tb Map Metier  Rang : "+this["Rang"]);
                }
                if (this["Objtype"] != null)
                {
                    errors.Add("Tb Map Metier  ObjType : "+this["Objtype"]);
                }
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                if (columnName.Equals("SchemaName"))
                {
                    if (String.IsNullOrEmpty(this.SchemaName))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("TableName"))
                {
                    if (String.IsNullOrEmpty(this.TableName))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Title"))
                {
                }
                if (columnName.Equals("MapOrder"))
                {
                }
                if (columnName.Equals("Rang"))
                {
                }
                if (columnName.Equals("Objtype"))
                {
                }
                return null;
            }
        }
    }
}
