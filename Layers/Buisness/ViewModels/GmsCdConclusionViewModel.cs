using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdConclusionViewModel : ViewModelBase
    {
        public GmsCdConclusion Model {get; set;}
        public GmsCdConclusionViewModel(GmsCdConclusion model)
        {
            this.GmsCdConclusionInsps = new  ObservableCollection<GmsCdConclusionInspViewModel>();
            
            this.GmsCdConclusionInspTmps = new  ObservableCollection<GmsCdConclusionInspTmpViewModel>();
            
            this.Model = model;
            this.Read();
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
        public virtual ObservableCollection<GmsCdConclusionInspViewModel> GmsCdConclusionInsps { get; set; }
        
        public virtual ObservableCollection<GmsCdConclusionInspTmpViewModel> GmsCdConclusionInspTmps { get; set; }
        
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
        [DisplayName("N° ordre Conclusion")]
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
