using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpPanneauViewModel : ViewModelBase<EqpPanneau>
    {
        public EqpPanneauViewModel(EqpPanneau model) : base(model)
        {
        }
        public override void Read()
        {
            this.EqpCdFabricant=new EqpCdFabricantViewModel( this.Model.EqpCdFabricant);
            this.EqpCdClasseSv=new EqpCdClasseSvViewModel( this.Model.EqpCdClasseSv);
            this.EqpCdGammeSv=new EqpCdGammeSvViewModel( this.Model.EqpCdGammeSv);
            this.EqpDscSv=new EqpDscSvViewModel( this.Model.EqpDscSv);
            this.EqpCdStypeSv=new EqpCdStypeSvViewModel( this.Model.EqpCdStypeSv);
            this.EqpCdMatSv=new EqpCdMatSvViewModel( this.Model.EqpCdMatSv);
            this.Ordre=this.Model.Ordre;
            this.DateMs=this.Model.DateMs;
            this.Hauteur=this.Model.Hauteur;
            this.Largeur=this.Model.Largeur;
            this.Reserve=this.Model.Reserve;
            this.AntiGraffiti=this.Model.AntiGraffiti;
            this.Mention=this.Model.Mention;
        }
        public override void Write()
        {
            this.Model.EqpCdFabricant=this. EqpCdFabricant.Model;
            this.Model.EqpCdClasseSv=this. EqpCdClasseSv.Model;
            this.Model.EqpCdGammeSv=this. EqpCdGammeSv.Model;
            this.Model.EqpDscSv=this. EqpDscSv.Model;
            this.Model.EqpCdStypeSv=this. EqpCdStypeSv.Model;
            this.Model.EqpCdMatSv=this. EqpCdMatSv.Model;
            this.Model.Ordre=this.Ordre;
            this.Model.DateMs=this.DateMs;
            this.Model.Hauteur=this.Hauteur;
            this.Model.Largeur=this.Largeur;
            this.Model.Reserve=this.Reserve;
            this.Model.AntiGraffiti=this.AntiGraffiti;
            this.Model.Mention=this.Mention;
        }
        private EqpCdFabricantViewModel _eqpCdFabricant;
        [DisplayName("Nom Fabricant")]
        public virtual EqpCdFabricantViewModel EqpCdFabricant
        {
            get
            {
                return this._eqpCdFabricant;
            }
            set
            {
                this._eqpCdFabricant = value;
                RaisePropertyChange("EqpCdFabricant");
            }
        }
        
        private EqpCdClasseSvViewModel _eqpCdClasseSv;
        [DisplayName("Classe du film")]
        public virtual EqpCdClasseSvViewModel EqpCdClasseSv
        {
            get
            {
                return this._eqpCdClasseSv;
            }
            set
            {
                this._eqpCdClasseSv = value;
                RaisePropertyChange("EqpCdClasseSv");
            }
        }
        
        private EqpCdGammeSvViewModel _eqpCdGammeSv;
        [DisplayName("Gamme panneau")]
        public virtual EqpCdGammeSvViewModel EqpCdGammeSv
        {
            get
            {
                return this._eqpCdGammeSv;
            }
            set
            {
                this._eqpCdGammeSv = value;
                RaisePropertyChange("EqpCdGammeSv");
            }
        }
        
        private EqpDscSvViewModel _eqpDscSv;
        [DisplayName("Signalisation Verticale")]
        public virtual EqpDscSvViewModel EqpDscSv
        {
            get
            {
                return this._eqpDscSv;
            }
            set
            {
                this._eqpDscSv = value;
                RaisePropertyChange("EqpDscSv");
            }
        }
        
        private EqpCdStypeSvViewModel _eqpCdStypeSv;
        [DisplayName("Sous Type Ouvrage")]
        public virtual EqpCdStypeSvViewModel EqpCdStypeSv
        {
            get
            {
                return this._eqpCdStypeSv;
            }
            set
            {
                this._eqpCdStypeSv = value;
                RaisePropertyChange("EqpCdStypeSv");
            }
        }
        
        private EqpCdMatSvViewModel _eqpCdMatSv;
        [DisplayName("Matériaux")]
        public virtual EqpCdMatSvViewModel EqpCdMatSv
        {
            get
            {
                return this._eqpCdMatSv;
            }
            set
            {
                this._eqpCdMatSv = value;
                RaisePropertyChange("EqpCdMatSv");
            }
        }
        
        private Int64 _ordre;
        [DisplayName("N° ORDRE")]
        public Int64 Ordre
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
        
        private Nullable<DateTime> _dateMs;
        [DisplayName("Date MS")]
        public Nullable<DateTime> DateMs
        {
            get
            {
                return this._dateMs;
            }
            set
            {
                this._dateMs = value;
                RaisePropertyChange("DateMs");
            }
        }
        
        private Nullable<Int64> _hauteur;
        [DisplayName("Hauteur (mm)")]
        public Nullable<Int64> Hauteur
        {
            get
            {
                return this._hauteur;
            }
            set
            {
                this._hauteur = value;
                RaisePropertyChange("Hauteur");
            }
        }
        
        private Nullable<Int64> _largeur;
        [DisplayName("Largeur (mm)")]
        public Nullable<Int64> Largeur
        {
            get
            {
                return this._largeur;
            }
            set
            {
                this._largeur = value;
                RaisePropertyChange("Largeur");
            }
        }
        
        private Nullable<Int64> _reserve;
        [DisplayName("Réserve")]
        public Nullable<Int64> Reserve
        {
            get
            {
                return this._reserve;
            }
            set
            {
                this._reserve = value;
                RaisePropertyChange("Reserve");
            }
        }
        
        private Nullable<Boolean> _antiGraffiti;
        [DisplayName("Anti Graffiti")]
        public Nullable<Boolean> AntiGraffiti
        {
            get
            {
                return this._antiGraffiti;
            }
            set
            {
                this._antiGraffiti = value;
                RaisePropertyChange("AntiGraffiti");
            }
        }
        
        private String _mention;
        [DisplayName("Mention")]
        public String Mention
        {
            get
            {
                return this._mention;
            }
            set
            {
                this._mention = value;
                RaisePropertyChange("Mention");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Ordre"] != null)
                {
                    errors.Add("N° ORDRE : "+this["Ordre"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["Hauteur"] != null)
                {
                    errors.Add("Hauteur (mm) : "+this["Hauteur"]);
                }
                if (this["Largeur"] != null)
                {
                    errors.Add("Largeur (mm) : "+this["Largeur"]);
                }
                if (this["Reserve"] != null)
                {
                    errors.Add("Réserve : "+this["Reserve"]);
                }
                if (this["AntiGraffiti"] != null)
                {
                    errors.Add("Anti Graffiti : "+this["AntiGraffiti"]);
                }
                if (this["Mention"] != null)
                {
                    errors.Add("Mention : "+this["Mention"]);
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
                if (columnName.Equals("Ordre"))
                {
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("Hauteur"))
                {
                }
                if (columnName.Equals("Largeur"))
                {
                }
                if (columnName.Equals("Reserve"))
                {
                }
                if (columnName.Equals("AntiGraffiti"))
                {
                }
                if (columnName.Equals("Mention"))
                {
                }
                return null;
            }
        }
    }
}
