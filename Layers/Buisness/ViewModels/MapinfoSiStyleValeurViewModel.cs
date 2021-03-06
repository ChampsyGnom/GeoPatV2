using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoSiStyleValeurViewModel : ViewModelBase<MapinfoSiStyleValeur>
    {
        public MapinfoSiStyleValeurViewModel(MapinfoSiStyleValeur model) : base(model)
        {
        }
        public override void Read()
        {
            this.MapinfoSiZone=new MapinfoSiZoneViewModel( this.Model.MapinfoSiZone);
            this.Valeur=this.Model.Valeur;
            this.Couleur=this.Model.Couleur;
            this.Border=this.Model.Border;
            this.Taille=this.Model.Taille;
            this.Representation=this.Model.Representation;
            this.Chemin=this.Model.Chemin;
            this.FontName=this.Model.FontName;
            this.FontChar=this.Model.FontChar;
            this.Opacity=this.Model.Opacity;
        }
        public override void Write()
        {
            this.Model.MapinfoSiZone=this. MapinfoSiZone.Model;
            this.Model.Valeur=this.Valeur;
            this.Model.Couleur=this.Couleur;
            this.Model.Border=this.Border;
            this.Model.Taille=this.Taille;
            this.Model.Representation=this.Representation;
            this.Model.Chemin=this.Chemin;
            this.Model.FontName=this.FontName;
            this.Model.FontChar=this.FontChar;
            this.Model.Opacity=this.Opacity;
        }
        private MapinfoSiZoneViewModel _mapinfoSiZone;
        [DisplayName("Si Zone")]
        public virtual MapinfoSiZoneViewModel MapinfoSiZone
        {
            get
            {
                return this._mapinfoSiZone;
            }
            set
            {
                this._mapinfoSiZone = value;
                RaisePropertyChange("MapinfoSiZone");
            }
        }
        
        private String _valeur;
        [DisplayName("Si Style Valeur  Valeur")]
        public String Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        private String _couleur;
        [DisplayName("Si Style Valeur  Couleur")]
        public String Couleur
        {
            get
            {
                return this._couleur;
            }
            set
            {
                this._couleur = value;
                RaisePropertyChange("Couleur");
            }
        }
        private Nullable<Int64> _border;
        [DisplayName("Si Style Valeur  Border")]
        public Nullable<Int64> Border
        {
            get
            {
                return this._border;
            }
            set
            {
                this._border = value;
                RaisePropertyChange("Border");
            }
        }
        
        private Nullable<Int64> _taille;
        [DisplayName("Si Style Valeur  Taille")]
        public Nullable<Int64> Taille
        {
            get
            {
                return this._taille;
            }
            set
            {
                this._taille = value;
                RaisePropertyChange("Taille");
            }
        }
        
        private String _representation;
        [DisplayName("Si Style Valeur  Representation")]
        public String Representation
        {
            get
            {
                return this._representation;
            }
            set
            {
                this._representation = value;
                RaisePropertyChange("Representation");
            }
        }
        private String _chemin;
        [DisplayName("Si Style Valeur  Chemin")]
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
        private String _fontName;
        [DisplayName("Si Style Valeur Font Name")]
        public String FontName
        {
            get
            {
                return this._fontName;
            }
            set
            {
                this._fontName = value;
                RaisePropertyChange("FontName");
            }
        }
        private Nullable<Int64> _fontChar;
        [DisplayName("Si Style Valeur Font Char")]
        public Nullable<Int64> FontChar
        {
            get
            {
                return this._fontChar;
            }
            set
            {
                this._fontChar = value;
                RaisePropertyChange("FontChar");
            }
        }
        
        private Nullable<Double> _opacity;
        [DisplayName("Si Style Valeur  Opacity")]
        public Nullable<Double> Opacity
        {
            get
            {
                return this._opacity;
            }
            set
            {
                this._opacity = value;
                RaisePropertyChange("Opacity");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Valeur"] != null)
                {
                    errors.Add("Si Style Valeur  Valeur : "+this["Valeur"]);
                }
                if (this["Couleur"] != null)
                {
                    errors.Add("Si Style Valeur  Couleur : "+this["Couleur"]);
                }
                if (this["Border"] != null)
                {
                    errors.Add("Si Style Valeur  Border : "+this["Border"]);
                }
                if (this["Taille"] != null)
                {
                    errors.Add("Si Style Valeur  Taille : "+this["Taille"]);
                }
                if (this["Representation"] != null)
                {
                    errors.Add("Si Style Valeur  Representation : "+this["Representation"]);
                }
                if (this["Chemin"] != null)
                {
                    errors.Add("Si Style Valeur  Chemin : "+this["Chemin"]);
                }
                if (this["FontName"] != null)
                {
                    errors.Add("Si Style Valeur Font Name : "+this["FontName"]);
                }
                if (this["FontChar"] != null)
                {
                    errors.Add("Si Style Valeur Font Char : "+this["FontChar"]);
                }
                if (this["Opacity"] != null)
                {
                    errors.Add("Si Style Valeur  Opacity : "+this["Opacity"]);
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
                if (columnName.Equals("Valeur"))
                {
                    if (String.IsNullOrEmpty(this.Valeur))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Couleur"))
                {
                }
                if (columnName.Equals("Border"))
                {
                }
                if (columnName.Equals("Taille"))
                {
                }
                if (columnName.Equals("Representation"))
                {
                }
                if (columnName.Equals("Chemin"))
                {
                }
                if (columnName.Equals("FontName"))
                {
                }
                if (columnName.Equals("FontChar"))
                {
                }
                if (columnName.Equals("Opacity"))
                {
                }
                return null;
            }
        }
    }
}
