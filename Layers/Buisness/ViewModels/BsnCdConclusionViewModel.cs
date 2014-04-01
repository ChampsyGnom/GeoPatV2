using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdConclusionViewModel : ViewModelBase<BsnCdConclusion>
    {
        public BsnCdConclusionViewModel(BsnCdConclusion model) : base(model)
        {
            this.BsnCdConclusionInsps = new  ObservableCollection<BsnCdConclusionInspViewModel>();
            
            this.BsnCdConclusionInspTmps = new  ObservableCollection<BsnCdConclusionInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.IdConc=this.Model.IdConc;
            this.Libelle=this.Model.Libelle;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.IdConc=this.IdConc;
            this.Model.Libelle=this.Libelle;
            this.Model.Ordre=this.Ordre;
        }
        public virtual ObservableCollection<BsnCdConclusionInspViewModel> BsnCdConclusionInsps { get; set; }
        
        public virtual ObservableCollection<BsnCdConclusionInspTmpViewModel> BsnCdConclusionInspTmps { get; set; }
        
        private Int64 _idConc;
        [DisplayName("Identifiant Conclusion")]
        public Int64 IdConc
        {
            get
            {
                return this._idConc;
            }
            set
            {
                this._idConc = value;
                RaisePropertyChange("IdConc");
            }
        }
        
        private String _libelle;
        [DisplayName("Libellé Conclusion")]
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
        private Int64 _ordre;
        [DisplayName("N° oredre Conclusion")]
        public Int64 Ordre
        {
            get
            {
                return this._ordre;
            }
            set
            {
                this._ordre = value;
                RaisePropertyChange("Ordre");
            }
        }
        
    }
}
