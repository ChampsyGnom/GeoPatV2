using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdConclusionInspViewModel : ViewModelBase
    {
        public GmsCdConclusionInsp Model {get; set;}
        public GmsCdConclusionInspViewModel(GmsCdConclusionInsp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsCdConclusion=new GmsCdConclusionViewModel( this.Model.GmsCdConclusion);
            this.GmsInsp=new GmsInspViewModel( this.Model.GmsInsp);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.GmsCdConclusion=this. GmsCdConclusion.Model;
            this.Model.GmsInsp=this. GmsInsp.Model;
            this.Model.Contenu=this.Contenu;
        }
        private GmsCdConclusionViewModel _gmsCdConclusion;
        [DisplayName("Code conclusion")]
        public virtual GmsCdConclusionViewModel GmsCdConclusion
        {
            get
            {
                return this._gmsCdConclusion;
            }
            set
            {
                this._gmsCdConclusion = value;
                RaisePropertyChange("GmsCdConclusion");
            }
        }
        
        private GmsInspViewModel _gmsInsp;
        [DisplayName("Inspection")]
        public virtual GmsInspViewModel GmsInsp
        {
            get
            {
                return this._gmsInsp;
            }
            set
            {
                this._gmsInsp = value;
                RaisePropertyChange("GmsInsp");
            }
        }
        
        private String _contenu;
        [DisplayName("Contenu")]
        public String Contenu
        {
            get
            {
                return this._contenu;
            }
            set
            {
                this._contenu = value;
                RaisePropertyChange("Contenu");
            }
        }
    }
}
