using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfRepartitionTraficViewModel : ViewModelBase<InfRepartitionTrafic>
    {
        public InfRepartitionTraficViewModel(InfRepartitionTrafic model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.Annee=this.Model.Annee;
            this.AbsFin=this.Model.AbsFin;
            this.PPl=this.Model.PPl;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.Annee=this.Annee;
            this.Model.AbsFin=this.AbsFin;
            this.Model.PPl=this.PPl;
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
        [DisplayName("PR debut")]
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
        
        private Int64 _annee;
        [DisplayName("Année")]
        public Int64 Annee
        {
            get
            {
                return this._annee;
            }
            set
            {
                this._annee = value;
                RaisePropertyChange("Annee");
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
        
        private Nullable<Int64> _pPl;
        [DisplayName("Répartition trafic PL (%)")]
        public Nullable<Int64> PPl
        {
            get
            {
                return this._pPl;
            }
            set
            {
                this._pPl = value;
                RaisePropertyChange("PPl");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["AbsDeb"] != null)
                {
                    errors.Add("PR debut : "+this["AbsDeb"]);
                }
                if (this["Annee"] != null)
                {
                    errors.Add("Année : "+this["Annee"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("PR fin : "+this["AbsFin"]);
                }
                if (this["PPl"] != null)
                {
                    errors.Add("Répartition trafic PL (%) : "+this["PPl"]);
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
                if (columnName.Equals("Annee"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("PPl"))
                {
                }
                return null;
            }
        }
    }
}
