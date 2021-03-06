using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdConclusionInspTmpViewModel : ViewModelBase<GmsCdConclusionInspTmp>
    {
        public GmsCdConclusionInspTmpViewModel(GmsCdConclusionInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.GmsCdConclusion=new GmsCdConclusionViewModel( this.Model.GmsCdConclusion);
            this.GmsInspTmp=new GmsInspTmpViewModel( this.Model.GmsInspTmp);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.GmsCdConclusion=this. GmsCdConclusion.Model;
            this.Model.GmsInspTmp=this. GmsInspTmp.Model;
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
        
        private GmsInspTmpViewModel _gmsInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual GmsInspTmpViewModel GmsInspTmp
        {
            get
            {
                return this._gmsInspTmp;
            }
            set
            {
                this._gmsInspTmp = value;
                RaisePropertyChange("GmsInspTmp");
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
