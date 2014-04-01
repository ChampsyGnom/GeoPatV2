using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdLiaisonViewModel : ViewModelBase<InfCdLiaison>
    {
        public InfCdLiaisonViewModel(InfCdLiaison model) : base(model)
        {
            this.InfLiaisons = new  ObservableCollection<InfLiaisonViewModel>();
            
        }
        public override void Read()
        {
            this.CdLiaison=this.Model.CdLiaison;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.CdLiaison=this.CdLiaison;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<InfLiaisonViewModel> InfLiaisons { get; set; }
        
        private String _cdLiaison;
        [DisplayName("Code")]
        public String CdLiaison
        {
            get
            {
                return this._cdLiaison;
            }
            set
            {
                this._cdLiaison = value;
                RaisePropertyChange("CdLiaison");
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
