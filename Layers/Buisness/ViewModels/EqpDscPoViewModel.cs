using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpDscPoViewModel : ViewModelBase<EqpDscPo>
    {
        public EqpDscPoViewModel(EqpDscPo model) : base(model)
        {
        }
        public override void Read()
        {
            this.EqpCdPortail=new EqpCdPortailViewModel( this.Model.EqpCdPortail);
            this.EqpCdFabricant=new EqpCdFabricantViewModel( this.Model.EqpCdFabricant);
            this.EqpCdEntp=new EqpCdEntpViewModel( this.Model.EqpCdEntp);
            this.EqpCdPosit=new EqpCdPositViewModel( this.Model.EqpCdPosit);
            this.NumExploit=this.Model.NumExploit;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.DateMs=this.Model.DateMs;
            this.Largeur=this.Model.Largeur;
            this.Hauteur=this.Model.Hauteur;
            this.DispoAcces=this.Model.DispoAcces;
            this.Commentaire=this.Model.Commentaire;
            this.X1=this.Model.X1;
            this.Y1=this.Model.Y1;
            this.Z1=this.Model.Z1;
            this.DateReleve=this.Model.DateReleve;
            this.Terrain=this.Model.Terrain;
        }
        public override void Write()
        {
            this.Model.EqpCdPortail=this. EqpCdPortail.Model;
            this.Model.EqpCdFabricant=this. EqpCdFabricant.Model;
            this.Model.EqpCdEntp=this. EqpCdEntp.Model;
            this.Model.EqpCdPosit=this. EqpCdPosit.Model;
            this.Model.NumExploit=this.NumExploit;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.DateMs=this.DateMs;
            this.Model.Largeur=this.Largeur;
            this.Model.Hauteur=this.Hauteur;
            this.Model.DispoAcces=this.DispoAcces;
            this.Model.Commentaire=this.Commentaire;
            this.Model.X1=this.X1;
            this.Model.Y1=this.Y1;
            this.Model.Z1=this.Z1;
            this.Model.DateReleve=this.DateReleve;
            this.Model.Terrain=this.Terrain;
        }
        private EqpCdPortailViewModel _eqpCdPortail;
        [DisplayName("Type de portail")]
        public virtual EqpCdPortailViewModel EqpCdPortail
        {
            get
            {
                return this._eqpCdPortail;
            }
            set
            {
                this._eqpCdPortail = value;
                RaisePropertyChange("EqpCdPortail");
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
        
        private Nullable<Double> _largeur;
        [DisplayName("Largeur (m)")]
        public Nullable<Double> Largeur
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
        
        private Nullable<Boolean> _dispoAcces;
        [DisplayName("Dispositif accès")]
        public Nullable<Boolean> DispoAcces
        {
            get
            {
                return this._dispoAcces;
            }
            set
            {
                this._dispoAcces = value;
                RaisePropertyChange("DispoAcces");
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["NumExploit"] != null)
                {
                    errors.Add("N° d'exploitation : "+this["NumExploit"]);
                }
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
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["Largeur"] != null)
                {
                    errors.Add("Largeur (m) : "+this["Largeur"]);
                }
                if (this["Hauteur"] != null)
                {
                    errors.Add("Hauteur (m) : "+this["Hauteur"]);
                }
                if (this["DispoAcces"] != null)
                {
                    errors.Add("Dispositif accès : "+this["DispoAcces"]);
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
                if (columnName.Equals("NumExploit"))
                {
                    if (String.IsNullOrEmpty(this.NumExploit))
                    {
                        return "valeur vide non autorisée";
                    }
                }
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
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("Largeur"))
                {
                }
                if (columnName.Equals("Hauteur"))
                {
                }
                if (columnName.Equals("DispoAcces"))
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
