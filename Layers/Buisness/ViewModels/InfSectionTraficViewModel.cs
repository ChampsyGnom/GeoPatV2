using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfSectionTraficViewModel : ViewModelBase<InfSectionTrafic>
    {
        public InfSectionTraficViewModel(InfSectionTrafic model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.InfCdClassTraf=new InfCdClassTrafViewModel( this.Model.InfCdClassTraf);
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Tenant=this.Model.Tenant;
            this.Aboutis=this.Model.Aboutis;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.InfCdClassTraf=this. InfCdClassTraf.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Tenant=this.Tenant;
            this.Model.Aboutis=this.Aboutis;
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
        
        private InfCdClassTrafViewModel _infCdClassTraf;
        [DisplayName("Classe de trafic")]
        public virtual InfCdClassTrafViewModel InfCdClassTraf
        {
            get
            {
                return this._infCdClassTraf;
            }
            set
            {
                this._infCdClassTraf = value;
                RaisePropertyChange("InfCdClassTraf");
            }
        }
        
        private Int64 _absDeb;
        [DisplayName("Début")]
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
        
        private Nullable<Int64> _absFin;
        [DisplayName("Fin")]
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
        
        private String _tenant;
        [DisplayName("Tenant")]
        public String Tenant
        {
            get
            {
                return this._tenant;
            }
            set
            {
                this._tenant = value;
                RaisePropertyChange("Tenant");
            }
        }
        private String _aboutis;
        [DisplayName("Aboutissant")]
        public String Aboutis
        {
            get
            {
                return this._aboutis;
            }
            set
            {
                this._aboutis = value;
                RaisePropertyChange("Aboutis");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Début : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Fin : "+this["AbsFin"]);
                }
                if (this["Tenant"] != null)
                {
                    errors.Add("Tenant : "+this["Tenant"]);
                }
                if (this["Aboutis"] != null)
                {
                    errors.Add("Aboutissant : "+this["Aboutis"]);
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
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Tenant"))
                {
                }
                if (columnName.Equals("Aboutis"))
                {
                }
                return null;
            }
        }
    }
}
