using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfSecuriteViewModel : ViewModelBase<InfSecurite>
    {
        public InfSecuriteViewModel(InfSecurite model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.InfCdSecur=new InfCdSecurViewModel( this.Model.InfCdSecur);
            this.InfCdPosit=new InfCdPositViewModel( this.Model.InfCdPosit);
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.InfCdSecur=this. InfCdSecur.Model;
            this.Model.InfCdPosit=this. InfCdPosit.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
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
        
        private InfCdSecurViewModel _infCdSecur;
        [DisplayName("Type Sécurité")]
        public virtual InfCdSecurViewModel InfCdSecur
        {
            get
            {
                return this._infCdSecur;
            }
            set
            {
                this._infCdSecur = value;
                RaisePropertyChange("InfCdSecur");
            }
        }
        
        private InfCdPositViewModel _infCdPosit;
        [DisplayName("Code Position")]
        public virtual InfCdPositViewModel InfCdPosit
        {
            get
            {
                return this._infCdPosit;
            }
            set
            {
                this._infCdPosit = value;
                RaisePropertyChange("InfCdPosit");
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
                return null;
            }
        }
    }
}
