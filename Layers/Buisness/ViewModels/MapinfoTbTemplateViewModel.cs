using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbTemplateViewModel : ViewModelBase<MapinfoTbTemplate>
    {
        public MapinfoTbTemplateViewModel(MapinfoTbTemplate model) : base(model)
        {
            this.MapinfoTbTemplateCfgs = new  ObservableCollection<MapinfoTbTemplateCfgViewModel>();
            
            this.MapinfoTbGroupes = new  ObservableCollection<MapinfoTbGroupeViewModel>();
            
        }
        public override void Read()
        {
            this.MapinfoTbModele=new MapinfoTbModeleViewModel( this.Model.MapinfoTbModele);
            this.Tpl=this.Model.Tpl;
            this.Titre=this.Model.Titre;
            this.Rang=this.Model.Rang;
            this.Chemin=this.Model.Chemin;
            this.Isgeocode=this.Model.Isgeocode;
        }
        public override void Write()
        {
            this.Model.MapinfoTbModele=this. MapinfoTbModele.Model;
            this.Model.Tpl=this.Tpl;
            this.Model.Titre=this.Titre;
            this.Model.Rang=this.Rang;
            this.Model.Chemin=this.Chemin;
            this.Model.Isgeocode=this.Isgeocode;
        }
        private MapinfoTbModeleViewModel _mapinfoTbModele;
        [DisplayName("Modèle")]
        public virtual MapinfoTbModeleViewModel MapinfoTbModele
        {
            get
            {
                return this._mapinfoTbModele;
            }
            set
            {
                this._mapinfoTbModele = value;
                RaisePropertyChange("MapinfoTbModele");
            }
        }
        
        public virtual ObservableCollection<MapinfoTbTemplateCfgViewModel> MapinfoTbTemplateCfgs { get; set; }
        
        public virtual ObservableCollection<MapinfoTbGroupeViewModel> MapinfoTbGroupes { get; set; }
        
        private String _tpl;
        [DisplayName("Template")]
        public String Tpl
        {
            get
            {
                return this._tpl;
            }
            set
            {
                this._tpl = value;
                RaisePropertyChange("Tpl");
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
        private Int64 _rang;
        [DisplayName("Rang")]
        public Int64 Rang
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
        private Nullable<Int64> _isgeocode;
        [DisplayName("Est géocodé")]
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Tpl"] != null)
                {
                    errors.Add("Template : "+this["Tpl"]);
                }
                if (this["Titre"] != null)
                {
                    errors.Add("Titre : "+this["Titre"]);
                }
                if (this["Rang"] != null)
                {
                    errors.Add("Rang : "+this["Rang"]);
                }
                if (this["Chemin"] != null)
                {
                    errors.Add("Chemin : "+this["Chemin"]);
                }
                if (this["Isgeocode"] != null)
                {
                    errors.Add("Est géocodé : "+this["Isgeocode"]);
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
                if (columnName.Equals("Tpl"))
                {
                    if (String.IsNullOrEmpty(this.Tpl))
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
                if (columnName.Equals("Rang"))
                {
                }
                if (columnName.Equals("Chemin"))
                {
                }
                if (columnName.Equals("Isgeocode"))
                {
                }
                return null;
            }
        }
    }
}
