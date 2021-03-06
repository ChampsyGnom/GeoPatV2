using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfTraficViewModel : ViewModelBase<InfTrafic>
    {
        public InfTraficViewModel(InfTrafic model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.Annee=this.Model.Annee;
            this.Pl=this.Model.Pl;
            this.Tmja=this.Model.Tmja;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.Annee=this.Annee;
            this.Model.Pl=this.Pl;
            this.Model.Tmja=this.Tmja;
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
        
        private Nullable<Double> _pl;
        [DisplayName("PL (%)")]
        public Nullable<Double> Pl
        {
            get
            {
                return this._pl;
            }
            set
            {
                this._pl = value;
                RaisePropertyChange("Pl");
            }
        }
        
        private Nullable<Int64> _tmja;
        [DisplayName("TMJA")]
        public Nullable<Int64> Tmja
        {
            get
            {
                return this._tmja;
            }
            set
            {
                this._tmja = value;
                RaisePropertyChange("Tmja");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Annee"] != null)
                {
                    errors.Add("Année : "+this["Annee"]);
                }
                if (this["Pl"] != null)
                {
                    errors.Add("PL (%) : "+this["Pl"]);
                }
                if (this["Tmja"] != null)
                {
                    errors.Add("TMJA : "+this["Tmja"]);
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
                if (columnName.Equals("Annee"))
                {
                }
                if (columnName.Equals("Pl"))
                {
                }
                if (columnName.Equals("Tmja"))
                {
                }
                return null;
            }
        }
    }
}
