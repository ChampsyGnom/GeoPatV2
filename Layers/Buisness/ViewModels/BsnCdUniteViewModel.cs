using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdUniteViewModel : ViewModelBase
    {
        public BsnCdUnite Model {get; set;}
        public BsnCdUniteViewModel(BsnCdUnite model)
        {
            this.BsnBpus = new  ObservableCollection<BsnBpuViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Unite=this.Model.Unite;
        }
        public override void Write()
        {
            this.Model.Unite=this.Unite;
        }
        public virtual ObservableCollection<BsnBpuViewModel> BsnBpus { get; set; }
        
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
