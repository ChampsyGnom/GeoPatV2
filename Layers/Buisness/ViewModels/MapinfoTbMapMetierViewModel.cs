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
        
    }
}
