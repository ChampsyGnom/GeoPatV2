using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdFranchViewModel : ViewModelBase
    {
        public EqpCdFranch Model {get; set;}
        public EqpCdFranchViewModel(EqpCdFranch model)
        {
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.AntiFranch=this.Model.AntiFranch;
        }
        public override void Write()
        {
            this.Model.AntiFranch=this.AntiFranch;
        }
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        private String _antiFranch;
        [DisplayName("Anti franchissement")]
        public String AntiFranch
        {
            get
            {
                return this._antiFranch;
            }
            set
            {
                this._antiFranch = value;
                RaisePropertyChange("AntiFranch");
            }
        }
    }
}
