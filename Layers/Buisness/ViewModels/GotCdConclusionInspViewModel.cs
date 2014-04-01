using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdConclusionInspViewModel : ViewModelBase
    {
        public GotCdConclusionInsp Model {get; set;}
        public GotCdConclusionInspViewModel(GotCdConclusionInsp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotCdConclusion=new GotCdConclusionViewModel( this.Model.GotCdConclusion);
            this.GotInsp=new GotInspViewModel( this.Model.GotInsp);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.GotCdConclusion=this. GotCdConclusion.Model;
            this.Model.GotInsp=this. GotInsp.Model;
            this.Model.Contenu=this.Contenu;
        }
        private GotCdConclusionViewModel _gotCdConclusion;
        [DisplayName("Code conclusion")]
        public virtual GotCdConclusionViewModel GotCdConclusion
        {
            get
            {
                return this._gotCdConclusion;
            }
            set
            {
                this._gotCdConclusion = value;
                RaisePropertyChange("GotCdConclusion");
            }
        }
        
        private GotInspViewModel _gotInsp;
        [DisplayName("Inspection")]
        public virtual GotInspViewModel GotInsp
        {
            get
            {
                return this._gotInsp;
            }
            set
            {
                this._gotInsp = value;
                RaisePropertyChange("GotInsp");
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
