using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbMapMetierColumnsViewModel : ViewModelBase<MapinfoTbMapMetierColumns>
    {
        public MapinfoTbMapMetierColumnsViewModel(MapinfoTbMapMetierColumns model) : base(model)
        {
        }
        public override void Read()
        {
            this.MapinfoTbMapMetier=new MapinfoTbMapMetierViewModel( this.Model.MapinfoTbMapMetier);
            this.ColName=this.Model.ColName;
            this.ColLibelle=this.Model.ColLibelle;
            this.ColOrder=this.Model.ColOrder;
            this.ColVisible=this.Model.ColVisible;
        }
        public override void Write()
        {
            this.Model.MapinfoTbMapMetier=this. MapinfoTbMapMetier.Model;
            this.Model.ColName=this.ColName;
            this.Model.ColLibelle=this.ColLibelle;
            this.Model.ColOrder=this.ColOrder;
            this.Model.ColVisible=this.ColVisible;
        }
        private MapinfoTbMapMetierViewModel _mapinfoTbMapMetier;
        [DisplayName("Tb Map Metier")]
        public virtual MapinfoTbMapMetierViewModel MapinfoTbMapMetier
        {
            get
            {
                return this._mapinfoTbMapMetier;
            }
            set
            {
                this._mapinfoTbMapMetier = value;
                RaisePropertyChange("MapinfoTbMapMetier");
            }
        }
        
        private String _colName;
        [DisplayName("Tb Map Metier Columns  Col Name")]
        public String ColName
        {
            get
            {
                return this._colName;
            }
            set
            {
                this._colName = value;
                RaisePropertyChange("ColName");
            }
        }
        private String _colLibelle;
        [DisplayName("Tb Map Metier Columns  Col Libelle")]
        public String ColLibelle
        {
            get
            {
                return this._colLibelle;
            }
            set
            {
                this._colLibelle = value;
                RaisePropertyChange("ColLibelle");
            }
        }
        private Nullable<Int64> _colOrder;
        [DisplayName("Tb Map Metier Columns  Col Order")]
        public Nullable<Int64> ColOrder
        {
            get
            {
                return this._colOrder;
            }
            set
            {
                this._colOrder = value;
                RaisePropertyChange("ColOrder");
            }
        }
        
        private Nullable<Int64> _colVisible;
        [DisplayName("Tb Map Metier Columns  Col Visible")]
        public Nullable<Int64> ColVisible
        {
            get
            {
                return this._colVisible;
            }
            set
            {
                this._colVisible = value;
                RaisePropertyChange("ColVisible");
            }
        }
        
    }
}
