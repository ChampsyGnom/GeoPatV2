using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdConclusionInspTmpViewModel : ViewModelBase<GotCdConclusionInspTmp>
    {
        public GotCdConclusionInspTmpViewModel(GotCdConclusionInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotCdConclusion=new GotCdConclusionViewModel( this.Model.GotCdConclusion);
            this.GotInspTmp=new GotInspTmpViewModel( this.Model.GotInspTmp);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.GotCdConclusion=this. GotCdConclusion.Model;
            this.Model.GotInspTmp=this. GotInspTmp.Model;
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
        
        private GotInspTmpViewModel _gotInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual GotInspTmpViewModel GotInspTmp
        {
            get
            {
                return this._gotInspTmp;
            }
            set
            {
                this._gotInspTmp = value;
                RaisePropertyChange("GotInspTmp");
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
