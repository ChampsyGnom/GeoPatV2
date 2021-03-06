using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbModeleViewModel : ViewModelBase<MapinfoTbModele>
    {
        public MapinfoTbModeleViewModel(MapinfoTbModele model) : base(model)
        {
            this.MapinfoTbModeleCfgs = new  ObservableCollection<MapinfoTbModeleCfgViewModel>();
            
            this.MapinfoTbTemplates = new  ObservableCollection<MapinfoTbTemplateViewModel>();
            
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Modele"] != null)
                {
                    errors.Add("Nom : "+this["Modele"]);
                }
                if (this["Ordre"] != null)
                {
                    errors.Add("Ordre : "+this["Ordre"]);
                }
                if (this["LayerName"] != null)
                {
                    errors.Add("Couche MAPINFO : "+this["LayerName"]);
                }
                if (this["Path"] != null)
                {
                    errors.Add("Fichier REF : "+this["Path"]);
                }
                if (this["TypeModele"] != null)
                {
                    errors.Add("Type de modèle : "+this["TypeModele"]);
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
                if (columnName.Equals("Modele"))
                {
                    if (String.IsNullOrEmpty(this.Modele))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Ordre"))
                {
                }
                if (columnName.Equals("LayerName"))
                {
                    if (String.IsNullOrEmpty(this.LayerName))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Path"))
                {
                    if (String.IsNullOrEmpty(this.Path))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("TypeModele"))
                {
                }
                return null;
            }
        }
    }
}
