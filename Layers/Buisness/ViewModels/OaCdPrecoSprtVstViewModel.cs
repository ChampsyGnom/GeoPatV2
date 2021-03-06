using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdPrecoSprtVstViewModel : ViewModelBase<OaCdPrecoSprtVst>
    {
        public OaCdPrecoSprtVstViewModel(OaCdPrecoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaVst=new OaVstViewModel( this.Model.OaVst);
            this.OaBpu=new OaBpuViewModel( this.Model.OaBpu);
            this.CdPrecoSprtVstOhRealise=this.Model.CdPrecoSprtVstOhRealise;
        }
        public override void Write()
        {
            this.Model.OaVst=this. OaVst.Model;
            this.Model.OaBpu=this. OaBpu.Model;
            this.Model.CdPrecoSprtVstOhRealise=this.CdPrecoSprtVstOhRealise;
        }
        private OaVstViewModel _oaVst;
        [DisplayName("Visite")]
        public virtual OaVstViewModel OaVst
        {
            get
            {
                return this._oaVst;
            }
            set
            {
                this._oaVst = value;
                RaisePropertyChange("OaVst");
            }
        }
        
        private OaBpuViewModel _oaBpu;
        [DisplayName("Bordereau Prix")]
        public virtual OaBpuViewModel OaBpu
        {
            get
            {
                return this._oaBpu;
            }
            set
            {
                this._oaBpu = value;
                RaisePropertyChange("OaBpu");
            }
        }
        
        private Nullable<Boolean> _cdPrecoSprtVstOhRealise;
        [DisplayName("Entretien réalisé")]
        public Nullable<Boolean> CdPrecoSprtVstOhRealise
        {
            get
            {
                return this._cdPrecoSprtVstOhRealise;
            }
            set
            {
                this._cdPrecoSprtVstOhRealise = value;
                RaisePropertyChange("CdPrecoSprtVstOhRealise");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["CdPrecoSprtVstOhRealise"] != null)
                {
                    errors.Add("Entretien réalisé : "+this["CdPrecoSprtVstOhRealise"]);
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
                if (columnName.Equals("CdPrecoSprtVstOhRealise"))
                {
                }
                return null;
            }
        }
    }
}
