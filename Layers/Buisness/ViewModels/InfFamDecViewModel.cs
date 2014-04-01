using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfFamDecViewModel : ViewModelBase<InfFamDec>
    {
        public InfFamDecViewModel(InfFamDec model) : base(model)
        {
            this.InfCdDecs = new  ObservableCollection<InfCdDecViewModel>();
            
        }
        public override void Read()
        {
            this.FamDec=this.Model.FamDec;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.FamDec=this.FamDec;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<InfCdDecViewModel> InfCdDecs { get; set; }
        
        private String _famDec;
        [DisplayName("Code famille")]
        public String FamDec
        {
            get
            {
                return this._famDec;
            }
            set
            {
                this._famDec = value;
                RaisePropertyChange("FamDec");
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
