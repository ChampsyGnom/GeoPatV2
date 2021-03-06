using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdPrecoSprtVstViewModel : ViewModelBase<GmsCdPrecoSprtVst>
    {
        public GmsCdPrecoSprtVstViewModel(GmsCdPrecoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.GmsBpu=new GmsBpuViewModel( this.Model.GmsBpu);
            this.GmsSprtVst=new GmsSprtVstViewModel( this.Model.GmsSprtVst);
            this.Realise=this.Model.Realise;
        }
        public override void Write()
        {
            this.Model.GmsBpu=this. GmsBpu.Model;
            this.Model.GmsSprtVst=this. GmsSprtVst.Model;
            this.Model.Realise=this.Realise;
        }
        private GmsBpuViewModel _gmsBpu;
        [DisplayName("Bordereau Prix")]
        public virtual GmsBpuViewModel GmsBpu
        {
            get
            {
                return this._gmsBpu;
            }
            set
            {
                this._gmsBpu = value;
                RaisePropertyChange("GmsBpu");
            }
        }
        
        private GmsSprtVstViewModel _gmsSprtVst;
        [DisplayName("Détail visite")]
        public virtual GmsSprtVstViewModel GmsSprtVst
        {
            get
            {
                return this._gmsSprtVst;
            }
            set
            {
                this._gmsSprtVst = value;
                RaisePropertyChange("GmsSprtVst");
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
