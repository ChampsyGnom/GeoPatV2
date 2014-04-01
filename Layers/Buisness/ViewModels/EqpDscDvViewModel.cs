using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpDscDvViewModel : ViewModelBase
    {
        public EqpDscDv Model {get; set;}
        public EqpDscDvViewModel(EqpDscDv model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.EqpCdPosit=new EqpCdPositViewModel( this.Model.EqpCdPosit);
            this.EqpCdFabricant=new EqpCdFabricantViewModel( this.Model.EqpCdFabricant);
            this.EqpCdEntp=new EqpCdEntpViewModel( this.Model.EqpCdEntp);
            this.EqpCdTypeDv=new EqpCdTypeDvViewModel( this.Model.EqpCdTypeDv);
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.NumExploit=this.Model.NumExploit;
            this.AbsFin=this.Model.AbsFin;
            this.DateMs=this.Model.DateMs;
            this.Alimentation=this.Model.Alimentation;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.EqpCdPosit=this. EqpCdPosit.Model;
            this.Model.EqpCdFabricant=this. EqpCdFabricant.Model;
            this.Model.EqpCdEntp=this. EqpCdEntp.Model;
            this.Model.EqpCdTypeDv=this. EqpCdTypeDv.Model;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.NumExploit=this.NumExploit;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateMs=this.DateMs;
            this.Model.Alimentation=this.Alimentation;
            this.Model.Commentaire=this.Commentaire;
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
        
        private EqpCdTypeDvViewModel _eqpCdTypeDv;
        [DisplayName("Type d'equipement divers")]
        public virtual EqpCdTypeDvViewModel EqpCdTypeDv
        {
            get
            {
                return this._eqpCdTypeDv;
            }
            set
            {
                this._eqpCdTypeDv = value;
                RaisePropertyChange("EqpCdTypeDv");
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
        [DisplayName("Pr début")]
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
        
        private String _numExploit;
        [DisplayName("N° d'exploitation")]
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
        private Int64 _absFin;
        [DisplayName("Pr fin")]
        public Int64 AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
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
        
        private String _alimentation;
        [DisplayName("Alimentation")]
        public String Alimentation
        {
            get
            {
                return this._alimentation;
            }
            set
            {
                this._alimentation = value;
                RaisePropertyChange("Alimentation");
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
    }
}
