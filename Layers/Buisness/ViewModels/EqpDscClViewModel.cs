using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpDscClViewModel : ViewModelBase<EqpDscCl>
    {
        public EqpDscClViewModel(EqpDscCl model) : base(model)
        {
        }
        public override void Read()
        {
            this.EqpCdCloture=new EqpCdClotureViewModel( this.Model.EqpCdCloture);
            this.EqpCdMaille=new EqpCdMailleViewModel( this.Model.EqpCdMaille);
            this.EqpCdFranch=new EqpCdFranchViewModel( this.Model.EqpCdFranch);
            this.EqpCdPoteauCl=new EqpCdPoteauClViewModel( this.Model.EqpCdPoteauCl);
            this.EqpCdFondation=new EqpCdFondationViewModel( this.Model.EqpCdFondation);
            this.EqpCdEntp=new EqpCdEntpViewModel( this.Model.EqpCdEntp);
            this.EqpCdFabricant=new EqpCdFabricantViewModel( this.Model.EqpCdFabricant);
            this.EqpCdPosit=new EqpCdPositViewModel( this.Model.EqpCdPosit);
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.NumExploit=this.Model.NumExploit;
            this.AbsFin=this.Model.AbsFin;
            this.DateMs=this.Model.DateMs;
            this.Hauteur=this.Model.Hauteur;
            this.Distance=this.Model.Distance;
            this.Commentaire=this.Model.Commentaire;
            this.X1=this.Model.X1;
            this.Y1=this.Model.Y1;
            this.Z1=this.Model.Z1;
            this.X2=this.Model.X2;
            this.Y2=this.Model.Y2;
            this.Z2=this.Model.Z2;
            this.DateReleve=this.Model.DateReleve;
            this.Terrain=this.Model.Terrain;
        }
        public override void Write()
        {
            this.Model.EqpCdCloture=this. EqpCdCloture.Model;
            this.Model.EqpCdMaille=this. EqpCdMaille.Model;
            this.Model.EqpCdFranch=this. EqpCdFranch.Model;
            this.Model.EqpCdPoteauCl=this. EqpCdPoteauCl.Model;
            this.Model.EqpCdFondation=this. EqpCdFondation.Model;
            this.Model.EqpCdEntp=this. EqpCdEntp.Model;
            this.Model.EqpCdFabricant=this. EqpCdFabricant.Model;
            this.Model.EqpCdPosit=this. EqpCdPosit.Model;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.NumExploit=this.NumExploit;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateMs=this.DateMs;
            this.Model.Hauteur=this.Hauteur;
            this.Model.Distance=this.Distance;
            this.Model.Commentaire=this.Commentaire;
            this.Model.X1=this.X1;
            this.Model.Y1=this.Y1;
            this.Model.Z1=this.Z1;
            this.Model.X2=this.X2;
            this.Model.Y2=this.Y2;
            this.Model.Z2=this.Z2;
            this.Model.DateReleve=this.DateReleve;
            this.Model.Terrain=this.Terrain;
        }
        private EqpCdClotureViewModel _eqpCdCloture;
        [DisplayName("Type de clôture")]
        public virtual EqpCdClotureViewModel EqpCdCloture
        {
            get
            {
                return this._eqpCdCloture;
            }
            set
            {
                this._eqpCdCloture = value;
                RaisePropertyChange("EqpCdCloture");
            }
        }
        
        private EqpCdMailleViewModel _eqpCdMaille;
        [DisplayName("Type de maille")]
        public virtual EqpCdMailleViewModel EqpCdMaille
        {
            get
            {
                return this._eqpCdMaille;
            }
            set
            {
                this._eqpCdMaille = value;
                RaisePropertyChange("EqpCdMaille");
            }
        }
        
        private EqpCdFranchViewModel _eqpCdFranch;
        [DisplayName("Anti Franchissement")]
        public virtual EqpCdFranchViewModel EqpCdFranch
        {
            get
            {
                return this._eqpCdFranch;
            }
            set
            {
                this._eqpCdFranch = value;
                RaisePropertyChange("EqpCdFranch");
            }
        }
        
        private EqpCdPoteauClViewModel _eqpCdPoteauCl;
        [DisplayName("Type poteaux")]
        public virtual EqpCdPoteauClViewModel EqpCdPoteauCl
        {
            get
            {
                return this._eqpCdPoteauCl;
            }
            set
            {
                this._eqpCdPoteauCl = value;
                RaisePropertyChange("EqpCdPoteauCl");
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
        [DisplayName("PR début")]
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
        [DisplayName("N° Exploitation")]
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
        private Nullable<Int64> _absFin;
        [DisplayName("PR fin")]
        public Nullable<Int64> AbsFin
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
        
        private Nullable<Double> _hauteur;
        [DisplayName("Hauteur (m)")]
        public Nullable<Double> Hauteur
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
        
        private Nullable<Double> _distance;
        [DisplayName("Distance poteaux (m)")]
        public Nullable<Double> Distance
        {
            get
            {
                return this._distance;
            }
            set
            {
                this._distance = value;
                RaisePropertyChange("Distance");
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
        
        private Nullable<Double> _x2;
        [DisplayName("X2")]
        public Nullable<Double> X2
        {
            get
            {
                return this._x2;
            }
            set
            {
                this._x2 = value;
                RaisePropertyChange("X2");
            }
        }
        
        private Nullable<Double> _y2;
        [DisplayName("Y2")]
        public Nullable<Double> Y2
        {
            get
            {
                return this._y2;
            }
            set
            {
                this._y2 = value;
                RaisePropertyChange("Y2");
            }
        }
        
        private Nullable<Double> _z2;
        [DisplayName("Z2")]
        public Nullable<Double> Z2
        {
            get
            {
                return this._z2;
            }
            set
            {
                this._z2 = value;
                RaisePropertyChange("Z2");
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Liaison"] != null)
                {
                    errors.Add("Liaison : "+this["Liaison"]);
                }
                if (this["Sens"] != null)
                {
                    errors.Add("Sens : "+this["Sens"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("PR début : "+this["AbsDeb"]);
                }
                if (this["NumExploit"] != null)
                {
                    errors.Add("N° Exploitation : "+this["NumExploit"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("PR fin : "+this["AbsFin"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["Hauteur"] != null)
                {
                    errors.Add("Hauteur (m) : "+this["Hauteur"]);
                }
                if (this["Distance"] != null)
                {
                    errors.Add("Distance poteaux (m) : "+this["Distance"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
                }
                if (this["X1"] != null)
                {
                    errors.Add("X1 : "+this["X1"]);
                }
                if (this["Y1"] != null)
                {
                    errors.Add("Y1 : "+this["Y1"]);
                }
                if (this["Z1"] != null)
                {
                    errors.Add("Z1 : "+this["Z1"]);
                }
                if (this["X2"] != null)
                {
                    errors.Add("X2 : "+this["X2"]);
                }
                if (this["Y2"] != null)
                {
                    errors.Add("Y2 : "+this["Y2"]);
                }
                if (this["Z2"] != null)
                {
                    errors.Add("Z2 : "+this["Z2"]);
                }
                if (this["DateReleve"] != null)
                {
                    errors.Add("Date relevé : "+this["DateReleve"]);
                }
                if (this["Terrain"] != null)
                {
                    errors.Add("Terrain : "+this["Terrain"]);
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
                if (columnName.Equals("Liaison"))
                {
                    if (String.IsNullOrEmpty(this.Liaison))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Sens"))
                {
                    if (String.IsNullOrEmpty(this.Sens))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("NumExploit"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("Hauteur"))
                {
                }
                if (columnName.Equals("Distance"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                if (columnName.Equals("X1"))
                {
                }
                if (columnName.Equals("Y1"))
                {
                }
                if (columnName.Equals("Z1"))
                {
                }
                if (columnName.Equals("X2"))
                {
                }
                if (columnName.Equals("Y2"))
                {
                }
                if (columnName.Equals("Z2"))
                {
                }
                if (columnName.Equals("DateReleve"))
                {
                }
                if (columnName.Equals("Terrain"))
                {
                }
                return null;
            }
        }
    }
}
