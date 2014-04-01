using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfLiaisonViewModel : ViewModelBase<InfLiaison>
    {
        public InfLiaisonViewModel(InfLiaison model) : base(model)
        {
            this.InfChaussees = new  ObservableCollection<InfChausseeViewModel>();
            
        }
        public override void Read()
        {
            this.InfCdLiaison=new InfCdLiaisonViewModel( this.Model.InfCdLiaison);
            this.Liaison=this.Model.Liaison;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.InfCdLiaison=this. InfCdLiaison.Model;
            this.Model.Liaison=this.Liaison;
            this.Model.Libelle=this.Libelle;
        }
        private InfCdLiaisonViewModel _infCdLiaison;
        [DisplayName("Type Liaison")]
        public virtual InfCdLiaisonViewModel InfCdLiaison
        {
            get
            {
                return this._infCdLiaison;
            }
            set
            {
                this._infCdLiaison = value;
                RaisePropertyChange("InfCdLiaison");
            }
        }
        
        public virtual ObservableCollection<InfChausseeViewModel> InfChaussees { get; set; }
        
        private String _liaison;
        [DisplayName("Liaison")]
        public String Liaison
        {
            get
            {
                return this._liaison;
            }
            set
            {
                this._liaison = value;
                RaisePropertyChange("Liaison");
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
