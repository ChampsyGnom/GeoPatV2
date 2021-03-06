using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdConclusionInspViewModel : ViewModelBase<OhCdConclusionInsp>
    {
        public OhCdConclusionInspViewModel(OhCdConclusionInsp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhInsp=new OhInspViewModel( this.Model.OhInsp);
            this.OhCdConclusion=new OhCdConclusionViewModel( this.Model.OhCdConclusion);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.OhInsp=this. OhInsp.Model;
            this.Model.OhCdConclusion=this. OhCdConclusion.Model;
            this.Model.Contenu=this.Contenu;
        }
        private OhInspViewModel _ohInsp;
        [DisplayName("Inspection")]
        public virtual OhInspViewModel OhInsp
        {
            get
            {
                return this._ohInsp;
            }
            set
            {
                this._ohInsp = value;
                RaisePropertyChange("OhInsp");
            }
        }
        
        private OhCdConclusionViewModel _ohCdConclusion;
        [DisplayName("Code conclusion")]
        public virtual OhCdConclusionViewModel OhCdConclusion
        {
            get
            {
                return this._ohCdConclusion;
            }
            set
            {
                this._ohCdConclusion = value;
                RaisePropertyChange("OhCdConclusion");
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
