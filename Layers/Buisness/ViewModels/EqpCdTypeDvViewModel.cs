using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdTypeDvViewModel : ViewModelBase<EqpCdTypeDv>
    {
        public EqpCdTypeDvViewModel(EqpCdTypeDv model) : base(model)
        {
            this.EqpDscDvs = new  ObservableCollection<EqpDscDvViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<EqpDscDvViewModel> EqpDscDvs { get; set; }
        
        private String _code;
        [DisplayName("Type")]
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
        [DisplayName("Libellé")]
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
    }
}
