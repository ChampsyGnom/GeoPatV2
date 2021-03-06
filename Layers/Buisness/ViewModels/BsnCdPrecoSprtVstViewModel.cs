using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdPrecoSprtVstViewModel : ViewModelBase<BsnCdPrecoSprtVst>
    {
        public BsnCdPrecoSprtVstViewModel(BsnCdPrecoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnBpu=new BsnBpuViewModel( this.Model.BsnBpu);
            this.BsnSprtVst=new BsnSprtVstViewModel( this.Model.BsnSprtVst);
            this.Realise=this.Model.Realise;
        }
        public override void Write()
        {
            this.Model.BsnBpu=this. BsnBpu.Model;
            this.Model.BsnSprtVst=this. BsnSprtVst.Model;
            this.Model.Realise=this.Realise;
        }
        private BsnBpuViewModel _bsnBpu;
        [DisplayName("Bordereau Prix")]
        public virtual BsnBpuViewModel BsnBpu
        {
            get
            {
                return this._bsnBpu;
            }
            set
            {
                this._bsnBpu = value;
                RaisePropertyChange("BsnBpu");
            }
        }
        
        private BsnSprtVstViewModel _bsnSprtVst;
        [DisplayName("Détail visite")]
        public virtual BsnSprtVstViewModel BsnSprtVst
        {
            get
            {
                return this._bsnSprtVst;
            }
            set
            {
                this._bsnSprtVst = value;
                RaisePropertyChange("BsnSprtVst");
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
