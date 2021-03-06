using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdConclusionInspTmpViewModel : ViewModelBase<BsnCdConclusionInspTmp>
    {
        public BsnCdConclusionInspTmpViewModel(BsnCdConclusionInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnCdConclusion=new BsnCdConclusionViewModel( this.Model.BsnCdConclusion);
            this.BsnInspTmp=new BsnInspTmpViewModel( this.Model.BsnInspTmp);
            this.Contenu=this.Model.Contenu;
        }
        public override void Write()
        {
            this.Model.BsnCdConclusion=this. BsnCdConclusion.Model;
            this.Model.BsnInspTmp=this. BsnInspTmp.Model;
            this.Model.Contenu=this.Contenu;
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
        
        private BsnInspTmpViewModel _bsnInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual BsnInspTmpViewModel BsnInspTmp
        {
            get
            {
                return this._bsnInspTmp;
            }
            set
            {
                this._bsnInspTmp = value;
                RaisePropertyChange("BsnInspTmp");
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
