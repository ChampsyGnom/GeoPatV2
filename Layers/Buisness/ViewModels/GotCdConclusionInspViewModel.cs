using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdConclusionInspViewModel : ViewModelBase<GotCdConclusionInsp>
    {
        public GotCdConclusionInspViewModel(GotCdConclusionInsp model) : base(model)
        {
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
