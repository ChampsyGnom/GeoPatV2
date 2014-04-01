using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdUniteViewModel : ViewModelBase<GotCdUnite>
    {
        public GotCdUniteViewModel(GotCdUnite model) : base(model)
        {
            this.GotBpus = new  ObservableCollection<GotBpuViewModel>();
            
        }
        public override void Read()
        {
            this.Unite=this.Model.Unite;
        }
        public override void Write()
        {
            this.Model.Unite=this.Unite;
        }
        public virtual ObservableCollection<GotBpuViewModel> GotBpus { get; set; }
        
        private String _unite;
        [DisplayName("Unité")]
        public String Unite
        {
            get
            {
                return this._unite;
            }
            set
            {
                this._unite = value;
                RaisePropertyChange("Unite");
            }
        }
    }
}
