using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbModeleViewModel : ViewModelBase
    {
        public MapinfoTbModele Model {get; set;}
        public MapinfoTbModeleViewModel(MapinfoTbModele model)
        {
            this.MapinfoTbModeleCfgs = new  ObservableCollection<MapinfoTbModeleCfgViewModel>();
            
            this.MapinfoTbTemplates = new  ObservableCollection<MapinfoTbTemplateViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Modele=this.Model.Modele;
            this.Ordre=this.Model.Ordre;
            this.LayerName=this.Model.LayerName;
            this.Path=this.Model.Path;
            this.TypeModele=this.Model.TypeModele;
        }
        public override void Write()
        {
            this.Model.Modele=this.Modele;
            this.Model.Ordre=this.Ordre;
            this.Model.LayerName=this.LayerName;
            this.Model.Path=this.Path;
            this.Model.TypeModele=this.TypeModele;
        }
        public virtual ObservableCollection<MapinfoTbModeleCfgViewModel> MapinfoTbModeleCfgs { get; set; }
        
        public virtual ObservableCollection<MapinfoTbTemplateViewModel> MapinfoTbTemplates { get; set; }
        
        private String _modele;
        [DisplayName("Nom")]
        public String Modele
        {
            get
            {
                return this._modele;
            }
            set
            {
                this._modele = value;
                RaisePropertyChange("Modele");
            }
        }
        private Nullable<Int64> _ordre;
        [DisplayName("Ordre")]
        public Nullable<Int64> Ordre
        {
            get
            {
                return this._ordre;
            }
            set
            {
                this._ordre = value;
                RaisePropertyChange("Ordre");
            }
        }
        
        private String _layerName;
        [DisplayName("Couche MAPINFO")]
        public String LayerName
        {
            get
            {
                return this._layerName;
            }
            set
            {
                this._layerName = value;
                RaisePropertyChange("LayerName");
            }
        }
        private String _path;
        [DisplayName("Fichier REF")]
        public String Path
        {
            get
            {
                return this._path;
            }
            set
            {
                this._path = value;
                RaisePropertyChange("Path");
            }
        }
        private Int64 _typeModele;
        [DisplayName("Type de modèle")]
        public Int64 TypeModele
        {
            get
            {
                return this._typeModele;
            }
            set
            {
                this._typeModele = value;
                RaisePropertyChange("TypeModele");
            }
        }
        
    }
}
