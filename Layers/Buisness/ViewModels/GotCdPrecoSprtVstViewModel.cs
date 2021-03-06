using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdPrecoSprtVstViewModel : ViewModelBase<GotCdPrecoSprtVst>
    {
        public GotCdPrecoSprtVstViewModel(GotCdPrecoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotVst=new GotVstViewModel( this.Model.GotVst);
            this.GotBpu=new GotBpuViewModel( this.Model.GotBpu);
            this.Realise=this.Model.Realise;
        }
        public override void Write()
        {
            this.Model.GotVst=this. GotVst.Model;
            this.Model.GotBpu=this. GotBpu.Model;
            this.Model.Realise=this.Realise;
        }
        private GotVstViewModel _gotVst;
        [DisplayName("Visite")]
        public virtual GotVstViewModel GotVst
        {
            get
            {
                return this._gotVst;
            }
            set
            {
                this._gotVst = value;
                RaisePropertyChange("GotVst");
            }
        }
        
        private GotBpuViewModel _gotBpu;
        [DisplayName("Bordereau Prix")]
        public virtual GotBpuViewModel GotBpu
        {
            get
            {
                return this._gotBpu;
            }
            set
            {
                this._gotBpu = value;
                RaisePropertyChange("GotBpu");
            }
        }
        
        private Nullable<Boolean> _realise;
        [DisplayName("Entretien réalisé")]
        public Nullable<Boolean> Realise
        {
            get
            {
                return this._realise;
            }
            set
            {
                this._realise = value;
                RaisePropertyChange("Realise");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Realise"] != null)
                {
                    errors.Add("Entretien réalisé : "+this["Realise"]);
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
                if (columnName.Equals("Realise"))
                {
                }
                return null;
            }
        }
    }
}
