using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdConclusionViewModel : ViewModelBase
    {
        public OaCdConclusion Model {get; set;}
        public OaCdConclusionViewModel(OaCdConclusion model)
        {
            this.OaCdConclusionInsps = new  ObservableCollection<OaCdConclusionInspViewModel>();
            
            this.OaCdConclusionInspTmps = new  ObservableCollection<OaCdConclusionInspTmpViewModel>();
            
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
        public virtual ObservableCollection<OaCdConclusionInspViewModel> OaCdConclusionInsps { get; set; }
        
        public virtual ObservableCollection<OaCdConclusionInspTmpViewModel> OaCdConclusionInspTmps { get; set; }
        
        private Int64 _idConc;
        [DisplayName("Identifiant conclusion")]
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
        [DisplayName("Libellé conclusion")]
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
        [DisplayName("N° ordre conclusion")]
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
