using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdConclusionInspTmpViewModel : ViewModelBase<OaCdConclusionInspTmp>
    {
        public OaCdConclusionInspTmpViewModel(OaCdConclusionInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaCdConclusion=new OaCdConclusionViewModel( this.Model.OaCdConclusion);
            this.OaInspTmp=new OaInspTmpViewModel( this.Model.OaInspTmp);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.OaCdConclusion=this. OaCdConclusion.Model;
            this.Model.OaInspTmp=this. OaInspTmp.Model;
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
        
        private OaInspTmpViewModel _oaInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual OaInspTmpViewModel OaInspTmp
        {
            get
            {
                return this._oaInspTmp;
            }
            set
            {
                this._oaInspTmp = value;
                RaisePropertyChange("OaInspTmp");
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
