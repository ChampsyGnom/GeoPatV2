using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpDscSvViewModel : ViewModelBase
    {
        public EqpDscSv Model {get; set;}
        public EqpDscSvViewModel(EqpDscSv model)
        {
            this.EqpPanneaus = new  ObservableCollection<EqpPanneauViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.EqpCdEntp=new EqpCdEntpViewModel( this.Model.EqpCdEntp);
            this.EqpCdPosit=new EqpCdPositViewModel( this.Model.EqpCdPosit);
            this.EqpCdProtect=new EqpCdProtectViewModel( this.Model.EqpCdProtect);
            this.EqpCdSupportSv=new EqpCdSupportSvViewModel( this.Model.EqpCdSupportSv);
            this.EqpCdFondation=new EqpCdFondationViewModel( this.Model.EqpCdFondation);
            this.EqpCdFamSv=new EqpCdFamSvViewModel( this.Model.EqpCdFamSv);
            this.NumExploit=this.Model.NumExploit;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.DateMs=this.Model.DateMs;
            this.Massif=this.Model.Massif;
            this.NbreSupport=this.Model.NbreSupport;
            this.Resist=this.Model.Resist;
            this.Eclairage=this.Model.Eclairage;
            this.Accessibilite=this.Model.Accessibilite;
            this.HauteurSp=this.Model.HauteurSp;
            this.Commentaire=this.Model.Commentaire;
            this.X1=this.Model.X1;
            this.Y1=this.Model.Y1;
            this.Z1=this.Model.Z1;
            this.DateReleve=this.Model.DateReleve;
            this.Terrain=this.Model.Terrain;
        }
        public override void Write()
        {
            this.Model.EqpCdEntp=this. EqpCdEntp.Model;
            this.Model.EqpCdPosit=this. EqpCdPosit.Model;
            this.Model.EqpCdProtect=this. EqpCdProtect.Model;
            this.Model.EqpCdSupportSv=this. EqpCdSupportSv.Model;
            this.Model.EqpCdFondation=this. EqpCdFondation.Model;
            this.Model.EqpCdFamSv=this. EqpCdFamSv.Model;
            this.Model.NumExploit=this.NumExploit;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.DateMs=this.DateMs;
            this.Model.Massif=this.Massif;
            this.Model.NbreSupport=this.NbreSupport;
            this.Model.Resist=this.Resist;
            this.Model.Eclairage=this.Eclairage;
            this.Model.Accessibilite=this.Accessibilite;
            this.Model.HauteurSp=this.HauteurSp;
            this.Model.Commentaire=this.Commentaire;
            this.Model.X1=this.X1;
            this.Model.Y1=this.Y1;
            this.Model.Z1=this.Z1;
            this.Model.DateReleve=this.DateReleve;
            this.Model.Terrain=this.Terrain;
        }
        private EqpCdEntpViewModel _eqpCdEntp;
        [DisplayName("Nom Entreprise")]
        public virtual EqpCdEntpViewModel EqpCdEntp
        {
            get
            {
                return this._eqpCdEntp;
            }
            set
            {
                this._eqpCdEntp = value;
                RaisePropertyChange("EqpCdEntp");
            }
        }
        
        private EqpCdPositViewModel _eqpCdPosit;
        [DisplayName("Position")]
        public virtual EqpCdPositViewModel EqpCdPosit
        {
            get
            {
                return this._eqpCdPosit;
            }
            set
            {
                this._eqpCdPosit = value;
                RaisePropertyChange("EqpCdPosit");
            }
        }
        
        private EqpCdProtectViewModel _eqpCdProtect;
        [DisplayName("Type de protection")]
        public virtual EqpCdProtectViewModel EqpCdProtect
        {
            get
            {
                return this._eqpCdProtect;
            }
            set
            {
                this._eqpCdProtect = value;
                RaisePropertyChange("EqpCdProtect");
            }
        }
        
        private EqpCdSupportSvViewModel _eqpCdSupportSv;
        [DisplayName("Type Support")]
        public virtual EqpCdSupportSvViewModel EqpCdSupportSv
        {
            get
            {
                return this._eqpCdSupportSv;
            }
            set
            {
                this._eqpCdSupportSv = value;
                RaisePropertyChange("EqpCdSupportSv");
            }
        }
        
        private EqpCdFondationViewModel _eqpCdFondation;
        [DisplayName("Type Fondation")]
        public virtual EqpCdFondationViewModel EqpCdFondation
        {
            get
            {
                return this._eqpCdFondation;
            }
            set
            {
                this._eqpCdFondation = value;
                RaisePropertyChange("EqpCdFondation");
            }
        }
        
        private EqpCdFamSvViewModel _eqpCdFamSv;
        [DisplayName("Famille Equipement")]
        public virtual EqpCdFamSvViewModel EqpCdFamSv
        {
            get
            {
                return this._eqpCdFamSv;
            }
            set
            {
                this._eqpCdFamSv = value;
                RaisePropertyChange("EqpCdFamSv");
            }
        }
        
        public virtual ObservableCollection<EqpPanneauViewModel> EqpPanneaus { get; set; }
        
        private String _numExploit;
        [DisplayName("N°  Exploitation")]
        public String NumExploit
        {
            get
            {
                return this._numExploit;
            }
            set
            {
                this._numExploit = value;
                RaisePropertyChange("NumExploit");
            }
        }
        private String _liaison;
        [DisplayName("Liaison")]
        public String Liaison
        {
            get
            {
                return this._liaison;
            }
            set
            {
                this._liaison = value;
                RaisePropertyChange("Liaison");
            }
        }
        private String _sens;
        [DisplayName("Sens")]
        public String Sens
        {
            get
            {
                return this._sens;
            }
            set
            {
                this._sens = value;
                RaisePropertyChange("Sens");
            }
        }
        private Int64 _absDeb;
        [DisplayName("PR Début")]
        public Int64 AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
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
        
        private String _massif;
        [DisplayName("Massif")]
        public String Massif
        {
            get
            {
                return this._massif;
            }
            set
            {
                this._massif = value;
                RaisePropertyChange("Massif");
            }
        }
        private Nullable<Int64> _nbreSupport;
        [DisplayName("Nbre de support")]
        public Nullable<Int64> NbreSupport
        {
            get
            {
                return this._nbreSupport;
            }
            set
            {
                this._nbreSupport = value;
                RaisePropertyChange("NbreSupport");
            }
        }
        
        private Nullable<Int64> _resist;
        [DisplayName("Classe de flexion")]
        public Nullable<Int64> Resist
        {
            get
            {
                return this._resist;
            }
            set
            {
                this._resist = value;
                RaisePropertyChange("Resist");
            }
        }
        
        private Nullable<Boolean> _eclairage;
        [DisplayName("Eclairage")]
        public Nullable<Boolean> Eclairage
        {
            get
            {
                return this._eclairage;
            }
            set
            {
                this._eclairage = value;
                RaisePropertyChange("Eclairage");
            }
        }
        
        private Nullable<Boolean> _accessibilite;
        [DisplayName("Accessibilité")]
        public Nullable<Boolean> Accessibilite
        {
            get
            {
                return this._accessibilite;
            }
            set
            {
                this._accessibilite = value;
                RaisePropertyChange("Accessibilite");
            }
        }
        
        private Nullable<Double> _hauteurSp;
        [DisplayName("Hauteur sous panneau (m)")]
        public Nullable<Double> HauteurSp
        {
            get
            {
                return this._hauteurSp;
            }
            set
            {
                this._hauteurSp = value;
                RaisePropertyChange("HauteurSp");
            }
        }
        
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
        private Nullable<Double> _x1;
        [DisplayName("X1")]
        public Nullable<Double> X1
        {
            get
            {
                return this._x1;
            }
            set
            {
                this._x1 = value;
                RaisePropertyChange("X1");
            }
        }
        
        private Nullable<Double> _y1;
        [DisplayName("Y1")]
        public Nullable<Double> Y1
        {
            get
            {
                return this._y1;
            }
            set
            {
                this._y1 = value;
                RaisePropertyChange("Y1");
            }
        }
        
        private Nullable<Double> _z1;
        [DisplayName("Z1")]
        public Nullable<Double> Z1
        {
            get
            {
                return this._z1;
            }
            set
            {
                this._z1 = value;
                RaisePropertyChange("Z1");
            }
        }
        
        private Nullable<DateTime> _dateReleve;
        [DisplayName("Date relevé")]
        public Nullable<DateTime> DateReleve
        {
            get
            {
                return this._dateReleve;
            }
            set
            {
                this._dateReleve = value;
                RaisePropertyChange("DateReleve");
            }
        }
        
        private Nullable<Boolean> _terrain;
        [DisplayName("Terrain")]
        public Nullable<Boolean> Terrain
        {
            get
            {
                return this._terrain;
            }
            set
            {
                this._terrain = value;
                RaisePropertyChange("Terrain");
            }
        }
        
    }
}
