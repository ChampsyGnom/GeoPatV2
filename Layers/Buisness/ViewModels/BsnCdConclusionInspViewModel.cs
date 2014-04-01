using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdConclusionInspViewModel : ViewModelBase
    {
        public BsnCdConclusionInsp Model {get; set;}
        public BsnCdConclusionInspViewModel(BsnCdConclusionInsp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnInsp=new BsnInspViewModel( this.Model.BsnInsp);
            this.BsnCdConclusion=new BsnCdConclusionViewModel( this.Model.BsnCdConclusion);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.BsnInsp=this. BsnInsp.Model;
            this.Model.BsnCdConclusion=this. BsnCdConclusion.Model;
            this.Model.Contenu=this.Contenu;
        }
        private BsnInspViewModel _bsnInsp;
        [DisplayName("Inspection")]
        public virtual BsnInspViewModel BsnInsp
        {
            get
            {
                return this._bsnInsp;
            }
            set
            {
                this._bsnInsp = value;
                RaisePropertyChange("BsnInsp");
            }
        }
        
        private BsnCdConclusionViewModel _bsnCdConclusion;
        [DisplayName("Code conclusion")]
        public virtual BsnCdConclusionViewModel BsnCdConclusion
        {
            get
            {
                return this._bsnCdConclusion;
            }
            set
            {
                this._bsnCdConclusion = value;
                RaisePropertyChange("BsnCdConclusion");
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
