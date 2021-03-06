using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbMapViewModel : ViewModelBase<MapinfoTbMap>
    {
        public MapinfoTbMapViewModel(MapinfoTbMap model) : base(model)
        {
            this.MapinfoTbMapCfgs = new  ObservableCollection<MapinfoTbMapCfgViewModel>();
            
        }
        public override void Read()
        {
            this.MapinfoTbGroupe=new MapinfoTbGroupeViewModel( this.Model.MapinfoTbGroupe);
            this.Map=this.Model.Map;
            this.Titre=this.Model.Titre;
            this.Objtype=this.Model.Objtype;
            this.Rang=this.Model.Rang;
            this.MapOrder=this.Model.MapOrder;
            this.Owner=this.Model.Owner;
            this.Isgeocode=this.Model.Isgeocode;
            this.Chemin=this.Model.Chemin;
        }
        public override void Write()
        {
            this.Model.MapinfoTbGroupe=this. MapinfoTbGroupe.Model;
            this.Model.Map=this.Map;
            this.Model.Titre=this.Titre;
            this.Model.Objtype=this.Objtype;
            this.Model.Rang=this.Rang;
            this.Model.MapOrder=this.MapOrder;
            this.Model.Owner=this.Owner;
            this.Model.Isgeocode=this.Isgeocode;
            this.Model.Chemin=this.Chemin;
        }
        private MapinfoTbGroupeViewModel _mapinfoTbGroupe;
        [DisplayName("Groupe")]
        public virtual MapinfoTbGroupeViewModel MapinfoTbGroupe
        {
            get
            {
                return this._mapinfoTbGroupe;
            }
            set
            {
                this._mapinfoTbGroupe = value;
                RaisePropertyChange("MapinfoTbGroupe");
            }
        }
        
        public virtual ObservableCollection<MapinfoTbMapCfgViewModel> MapinfoTbMapCfgs { get; set; }
        
        private String _map;
        [DisplayName("Carte")]
        public String Map
        {
            get
            {
                return this._map;
            }
            set
            {
                this._map = value;
                RaisePropertyChange("Map");
            }
        }
        private String _titre;
        [DisplayName("Titre")]
        public String Titre
        {
            get
            {
                return this._titre;
            }
            set
            {
                this._titre = value;
                RaisePropertyChange("Titre");
            }
        }
        private Nullable<Int64> _objtype;
        [DisplayName("Type objet")]
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
        
        private Nullable<Int64> _rang;
        [DisplayName("Rang")]
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
        
        private Int64 _mapOrder;
        [DisplayName("Order")]
        public Int64 MapOrder
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
        
        private String _owner;
        [DisplayName("Schéma")]
        public String Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
                RaisePropertyChange("Owner");
            }
        }
        private Nullable<Int64> _isgeocode;
        [DisplayName("Est gécodé")]
        public Nullable<Int64> Isgeocode
        {
            get
            {
                return this._isgeocode;
            }
            set
            {
                this._isgeocode = value;
                RaisePropertyChange("Isgeocode");
            }
        }
        
        private String _chemin;
        [DisplayName("Chemin")]
        public String Chemin
        {
            get
            {
                return this._chemin;
            }
            set
            {
                this._chemin = value;
                RaisePropertyChange("Chemin");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Map"] != null)
                {
                    errors.Add("Carte : "+this["Map"]);
                }
                if (this["Titre"] != null)
                {
                    errors.Add("Titre : "+this["Titre"]);
                }
                if (this["Objtype"] != null)
                {
                    errors.Add("Type objet : "+this["Objtype"]);
                }
                if (this["Rang"] != null)
                {
                    errors.Add("Rang : "+this["Rang"]);
                }
                if (this["MapOrder"] != null)
                {
                    errors.Add("Order : "+this["MapOrder"]);
                }
                if (this["Owner"] != null)
                {
                    errors.Add("Schéma : "+this["Owner"]);
                }
                if (this["Isgeocode"] != null)
                {
                    errors.Add("Est gécodé : "+this["Isgeocode"]);
                }
                if (this["Chemin"] != null)
                {
                    errors.Add("Chemin : "+this["Chemin"]);
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
                if (columnName.Equals("Map"))
                {
                    if (String.IsNullOrEmpty(this.Map))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Titre"))
                {
                    if (String.IsNullOrEmpty(this.Titre))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Objtype"))
                {
                }
                if (columnName.Equals("Rang"))
                {
                }
                if (columnName.Equals("MapOrder"))
                {
                }
                if (columnName.Equals("Owner"))
                {
                    if (String.IsNullOrEmpty(this.Owner))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Isgeocode"))
                {
                }
                if (columnName.Equals("Chemin"))
                {
                    if (String.IsNullOrEmpty(this.Chemin))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
