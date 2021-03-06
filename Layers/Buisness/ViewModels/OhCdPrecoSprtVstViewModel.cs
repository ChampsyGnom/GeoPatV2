using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdPrecoSprtVstViewModel : ViewModelBase<OhCdPrecoSprtVst>
    {
        public OhCdPrecoSprtVstViewModel(OhCdPrecoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhSprtVst=new OhSprtVstViewModel( this.Model.OhSprtVst);
            this.OhBpu=new OhBpuViewModel( this.Model.OhBpu);
            this.Realise=this.Model.Realise;
        }
        public override void Write()
        {
            this.Model.OhSprtVst=this. OhSprtVst.Model;
            this.Model.OhBpu=this. OhBpu.Model;
            this.Model.Realise=this.Realise;
        }
        private OhSprtVstViewModel _ohSprtVst;
        [DisplayName("Détail visite")]
        public virtual OhSprtVstViewModel OhSprtVst
        {
            get
            {
                return this._ohSprtVst;
            }
            set
            {
                this._ohSprtVst = value;
                RaisePropertyChange("OhSprtVst");
            }
        }
        
        private OhBpuViewModel _ohBpu;
        [DisplayName("Bordereau Prix")]
        public virtual OhBpuViewModel OhBpu
        {
            get
            {
                return this._ohBpu;
            }
            set
            {
                this._ohBpu = value;
                RaisePropertyChange("OhBpu");
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
