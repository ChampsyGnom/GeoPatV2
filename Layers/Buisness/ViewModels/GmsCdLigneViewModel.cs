using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdLigneViewModel : ViewModelBase<GmsCdLigne>
    {
        public GmsCdLigneViewModel(GmsCdLigne model) : base(model)
        {
            this.GmsSprtVsts = new  ObservableCollection<GmsSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.GmsCdChapitre=new GmsCdChapitreViewModel( this.Model.GmsCdChapitre);
            this.IdLigne=this.Model.IdLigne;
            this.Libelle=this.Model.Libelle;
            this.OrdreLigne=this.Model.OrdreLigne;
        }
        public override void Write()
        {
            this.Model.GmsCdChapitre=this. GmsCdChapitre.Model;
            this.Model.IdLigne=this.IdLigne;
            this.Model.Libelle=this.Libelle;
            this.Model.OrdreLigne=this.OrdreLigne;
        }
        private GmsCdChapitreViewModel _gmsCdChapitre;
        [DisplayName("Chapitre")]
        public virtual GmsCdChapitreViewModel GmsCdChapitre
        {
            get
            {
                return this._gmsCdChapitre;
            }
            set
            {
                this._gmsCdChapitre = value;
                RaisePropertyChange("GmsCdChapitre");
            }
        }
        
        public virtual ObservableCollection<GmsSprtVstViewModel> GmsSprtVsts { get; set; }
        
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
        private Nullable<Int64> _ordreLigne;
        [DisplayName("N° ordre ligne")]
        public Nullable<Int64> OrdreLigne
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
