using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfGareViewModel : ViewModelBase<InfGare>
    {
        public InfGareViewModel(InfGare model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfCdGare=new InfCdGareViewModel( this.Model.InfCdGare);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.NumExploit=this.Model.NumExploit;
            this.Nom=this.Model.Nom;
            this.DateMs=this.Model.DateMs;
            this.VoiEntree=this.Model.VoiEntree;
            this.VoiSortie=this.Model.VoiSortie;
            this.VoiMixte=this.Model.VoiMixte;
            this.VoiTsa=this.Model.VoiTsa;
            this.Observ=this.Model.Observ;
            this.X1=this.Model.X1;
            this.Y1=this.Model.Y1;
            this.Z1=this.Model.Z1;
            this.DateReleve=this.Model.DateReleve;
            this.Terrain=this.Model.Terrain;
        }
        public override void Write()
        {
            this.Model.InfCdGare=this. InfCdGare.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.NumExploit=this.NumExploit;
            this.Model.Nom=this.Nom;
            this.Model.DateMs=this.DateMs;
            this.Model.VoiEntree=this.VoiEntree;
            this.Model.VoiSortie=this.VoiSortie;
            this.Model.VoiMixte=this.VoiMixte;
            this.Model.VoiTsa=this.VoiTsa;
            this.Model.Observ=this.Observ;
            this.Model.X1=this.X1;
            this.Model.Y1=this.Y1;
            this.Model.Z1=this.Z1;
            this.Model.DateReleve=this.DateReleve;
            this.Model.Terrain=this.Terrain;
        }
        private InfCdGareViewModel _infCdGare;
        [DisplayName("Type Gare")]
        public virtual InfCdGareViewModel InfCdGare
        {
            get
            {
                return this._infCdGare;
            }
            set
            {
                this._infCdGare = value;
                RaisePropertyChange("InfCdGare");
            }
        }
        
        private InfChausseeViewModel _infChaussee;
        [DisplayName("Chaussée")]
        public virtual InfChausseeViewModel InfChaussee
        {
            get
            {
                return this._infChaussee;
            }
            set
            {
                this._infChaussee = value;
                RaisePropertyChange("InfChaussee");
            }
        }
        
        private Int64 _absDeb;
        [DisplayName("Pr")]
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
        private String _nom;
        [DisplayName("Nom d'usage")]
        public String Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
                RaisePropertyChange("Nom");
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
        
        private Nullable<Int64> _voiEntree;
        [DisplayName("Nbr Voies Entrée")]
        public Nullable<Int64> VoiEntree
        {
            get
            {
                return this._voiEntree;
            }
            set
            {
                this._voiEntree = value;
                RaisePropertyChange("VoiEntree");
            }
        }
        
        private Nullable<Int64> _voiSortie;
        [DisplayName("Nbr Voies Sortie")]
        public Nullable<Int64> VoiSortie
        {
            get
            {
                return this._voiSortie;
            }
            set
            {
                this._voiSortie = value;
                RaisePropertyChange("VoiSortie");
            }
        }
        
        private Nullable<Int64> _voiMixte;
        [DisplayName("Nbr Voies Mixte")]
        public Nullable<Int64> VoiMixte
        {
            get
            {
                return this._voiMixte;
            }
            set
            {
                this._voiMixte = value;
                RaisePropertyChange("VoiMixte");
            }
        }
        
        private Nullable<Int64> _voiTsa;
        [DisplayName("Nbr Voies TSA")]
        public Nullable<Int64> VoiTsa
        {
            get
            {
                return this._voiTsa;
            }
            set
            {
                this._voiTsa = value;
                RaisePropertyChange("VoiTsa");
            }
        }
        
        private String _observ;
        [DisplayName("Commentaire")]
        public String Observ
        {
            get
            {
                return this._observ;
            }
            set
            {
                this._observ = value;
                RaisePropertyChange("Observ");
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
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Pr : "+this["AbsDeb"]);
                }
                if (this["NumExploit"] != null)
                {
                    errors.Add("N° Exploitation : "+this["NumExploit"]);
                }
                if (this["Nom"] != null)
                {
                    errors.Add("Nom d'usage : "+this["Nom"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["VoiEntree"] != null)
                {
                    errors.Add("Nbr Voies Entrée : "+this["VoiEntree"]);
                }
                if (this["VoiSortie"] != null)
                {
                    errors.Add("Nbr Voies Sortie : "+this["VoiSortie"]);
                }
                if (this["VoiMixte"] != null)
                {
                    errors.Add("Nbr Voies Mixte : "+this["VoiMixte"]);
                }
                if (this["VoiTsa"] != null)
                {
                    errors.Add("Nbr Voies TSA : "+this["VoiTsa"]);
                }
                if (this["Observ"] != null)
                {
                    errors.Add("Commentaire : "+this["Observ"]);
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
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("NumExploit"))
                {
                }
                if (columnName.Equals("Nom"))
                {
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("VoiEntree"))
                {
                }
                if (columnName.Equals("VoiSortie"))
                {
                }
                if (columnName.Equals("VoiMixte"))
                {
                }
                if (columnName.Equals("VoiTsa"))
                {
                }
                if (columnName.Equals("Observ"))
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
