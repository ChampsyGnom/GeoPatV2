using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdBeViewModel : ViewModelBase<OaCdBe>
    {
        public OaCdBeViewModel(OaCdBe model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Bureau=this.Model.Bureau;
        }
        public override void Write()
        {
            this.Model.Bureau=this.Bureau;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _bureau;
        [DisplayName("Bureau d'étude")]
        public String Bureau
        {
            get
            {
                return this._bureau;
            }
            set
            {
                this._bureau = value;
                RaisePropertyChange("Bureau");
            }
        }
    }
}
