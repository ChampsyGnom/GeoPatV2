using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdConclusionInspViewModel : ViewModelBase<BsnCdConclusionInsp>
    {
        public BsnCdConclusionInspViewModel(BsnCdConclusionInsp model) : base(model)
        {
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Contenu"] != null)
                {
                    errors.Add("Contenu : "+this["Contenu"]);
                }
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                if (columnName.Equals("Contenu"))
                {
                }
                return null;
            }
        }
    }
}
