using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdLigneViewModel : ViewModelBase<GotCdLigne>
    {
        public GotCdLigneViewModel(GotCdLigne model) : base(model)
        {
            this.GotSprtVsts = new  ObservableCollection<GotSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.GotCdChapitre=new GotCdChapitreViewModel( this.Model.GotCdChapitre);
            this.IdLigne=this.Model.IdLigne;
            this.Libelle=this.Model.Libelle;
            this.OrdreLigne=this.Model.OrdreLigne;
        }
        public override void Write()
        {
            this.Model.GotCdChapitre=this. GotCdChapitre.Model;
            this.Model.IdLigne=this.IdLigne;
            this.Model.Libelle=this.Libelle;
            this.Model.OrdreLigne=this.OrdreLigne;
        }
        private GotCdChapitreViewModel _gotCdChapitre;
        [DisplayName("Chapitre")]
        public virtual GotCdChapitreViewModel GotCdChapitre
        {
            get
            {
                return this._gotCdChapitre;
            }
            set
            {
                this._gotCdChapitre = value;
                RaisePropertyChange("GotCdChapitre");
            }
        }
        
        public virtual ObservableCollection<GotSprtVstViewModel> GotSprtVsts { get; set; }
        
        private Int64 _idLigne;
        [DisplayName("Identifiant ligne")]
        public Int64 IdLigne
        {
            get
            {
                return this._idLigne;
            }
            set
            {
                this._idLigne = value;
                RaisePropertyChange("IdLigne");
            }
        }
        
        private String _libelle;
        [DisplayName("Libellé ligne")]
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
        private Int64 _ordreLigne;
        [DisplayName("N° d'ordre ligne")]
        public Int64 OrdreLigne
        {
            get
            {
                return this._ordreLigne;
            }
            set
            {
                this._ordreLigne = value;
                RaisePropertyChange("OrdreLigne");
            }
        }
        
    }
}
