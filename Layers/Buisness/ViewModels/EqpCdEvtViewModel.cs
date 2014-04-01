using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdEvtViewModel : ViewModelBase<EqpCdEvt>
    {
        public EqpCdEvtViewModel(EqpCdEvt model) : base(model)
        {
            this.EqpEvts = new  ObservableCollection<EqpEvtViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
            this.Impact=this.Model.Impact;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
            this.Model.Impact=this.Impact;
        }
        public virtual ObservableCollection<EqpEvtViewModel> EqpEvts { get; set; }
        
        private String _type;
        [DisplayName("Type événement")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
            }
        }
        private Nullable<Boolean> _impact;
        [DisplayName("Impact métier")]
        public Nullable<Boolean> Impact
        {
            get
            {
                return this._impact;
            }
            set
            {
                this._impact = value;
                RaisePropertyChange("Impact");
            }
        }
        
    }
}
