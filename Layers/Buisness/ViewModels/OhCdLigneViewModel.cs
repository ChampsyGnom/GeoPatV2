using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdLigneViewModel : ViewModelBase<OhCdLigne>
    {
        public OhCdLigneViewModel(OhCdLigne model) : base(model)
        {
            this.OhSprtVsts = new  ObservableCollection<OhSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.OhCdChapitre=new OhCdChapitreViewModel( this.Model.OhCdChapitre);
            this.IdLigne=this.Model.IdLigne;
            this.Libelle=this.Model.Libelle;
            this.OrdreLigne=this.Model.OrdreLigne;
        }
        public override void Write()
        {
            this.Model.OhCdChapitre=this. OhCdChapitre.Model;
            this.Model.IdLigne=this.IdLigne;
            this.Model.Libelle=this.Libelle;
            this.Model.OrdreLigne=this.OrdreLigne;
        }
        private OhCdChapitreViewModel _ohCdChapitre;
        [DisplayName("Chapitre")]
        public virtual OhCdChapitreViewModel OhCdChapitre
        {
            get
            {
                return this._ohCdChapitre;
            }
            set
            {
                this._ohCdChapitre = value;
                RaisePropertyChange("OhCdChapitre");
            }
        }
        
        public virtual ObservableCollection<OhSprtVstViewModel> OhSprtVsts { get; set; }
        
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
        [DisplayName("Libellé Ligne")]
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
        [DisplayName("N° ordre ligne")]
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
