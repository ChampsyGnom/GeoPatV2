using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdConclusionInspViewModel : ViewModelBase<OaCdConclusionInsp>
    {
        public OaCdConclusionInspViewModel(OaCdConclusionInsp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaCdConclusion=new OaCdConclusionViewModel( this.Model.OaCdConclusion);
            this.OaInsp=new OaInspViewModel( this.Model.OaInsp);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.OaCdConclusion=this. OaCdConclusion.Model;
            this.Model.OaInsp=this. OaInsp.Model;
            this.Model.Contenu=this.Contenu;
        }
        private OaCdConclusionViewModel _oaCdConclusion;
        [DisplayName("Code conclusion")]
        public virtual OaCdConclusionViewModel OaCdConclusion
        {
            get
            {
                return this._oaCdConclusion;
            }
            set
            {
                this._oaCdConclusion = value;
                RaisePropertyChange("OaCdConclusion");
            }
        }
        
        private OaInspViewModel _oaInsp;
        [DisplayName("Inspection")]
        public virtual OaInspViewModel OaInsp
        {
            get
            {
                return this._oaInsp;
            }
            set
            {
                this._oaInsp = value;
                RaisePropertyChange("OaInsp");
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
