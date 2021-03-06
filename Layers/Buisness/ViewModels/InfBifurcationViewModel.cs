using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfBifurcationViewModel : ViewModelBase<InfBifurcation>
    {
        public InfBifurcationViewModel(InfBifurcation model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfCdBif=new InfCdBifViewModel( this.Model.InfCdBif);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.Nom=this.Model.Nom;
            this.NumExploit=this.Model.NumExploit;
            this.DateMs=this.Model.DateMs;
            this.Observ=this.Model.Observ;
            this.X1=this.Model.X1;
            this.Y1=this.Model.Y1;
            this.Z1=this.Model.Z1;
            this.DateReleve=this.Model.DateReleve;
            this.Terrain=this.Model.Terrain;
        }
        public override void Write()
        {
            this.Model.InfCdBif=this. InfCdBif.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.Nom=this.Nom;
            this.Model.NumExploit=this.NumExploit;
            this.Model.DateMs=this.DateMs;
            this.Model.Observ=this.Observ;
            this.Model.X1=this.X1;
            this.Model.Y1=this.Y1;
            this.Model.Z1=this.Z1;
            this.Model.DateReleve=this.DateReleve;
            this.Model.Terrain=this.Terrain;
        }
        private InfCdBifViewModel _infCdBif;
        [DisplayName("Type Bifurcation")]
        public virtual InfCdBifViewModel InfCdBif
        {
            get
            {
                return this._infCdBif;
            }
            set
            {
                this._infCdBif = value;
                RaisePropertyChange("InfCdBif");
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
        [DisplayName("Pr Axe")]
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
                    errors.Add("Pr Axe : "+this["AbsDeb"]);
                }
                if (this["Nom"] != null)
                {
                    errors.Add("Nom d'usage : "+this["Nom"]);
                }
                if (this["NumExploit"] != null)
                {
                    errors.Add("N° Exploitation : "+this["NumExploit"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
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
                if (columnName.Equals("Nom"))
                {
                }
                if (columnName.Equals("NumExploit"))
                {
                }
                if (columnName.Equals("DateMs"))
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
