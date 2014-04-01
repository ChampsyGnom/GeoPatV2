using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsPonViewModel : ViewModelBase<DsPon>
    {
        public DsPonViewModel(DsPon model) : base(model)
        {
            this.DsPonParams = new  ObservableCollection<DsPonParamViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
            this.Agr=this.Model.Agr;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
            this.Model.Agr=this.Agr;
        }
        public virtual ObservableCollection<DsPonParamViewModel> DsPonParams { get; set; }
        
        private String _code;
        [DisplayName("PON_DS__CODE")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
            }
        }
        private String _libelle;
        [DisplayName("PON_DS__LIBELLE")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
        private String _agr;
        [DisplayName("PON_DS__AGR")]
        public String Agr
        {
            get
            {
                return this._agr;
            }
            set
            {
                this._agr = value;
                RaisePropertyChange("Agr");
            }
        }
    }
}
