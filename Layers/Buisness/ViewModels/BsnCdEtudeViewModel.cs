using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdEtudeViewModel : ViewModelBase<BsnCdEtude>
    {
        public BsnCdEtudeViewModel(BsnCdEtude model) : base(model)
        {
            this.BsnInsps = new  ObservableCollection<BsnInspViewModel>();
            
            this.BsnInspTmps = new  ObservableCollection<BsnInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.Etude=this.Model.Etude;
        }
        public override void Write()
        {
            this.Model.Etude=this.Etude;
        }
        public virtual ObservableCollection<BsnInspViewModel> BsnInsps { get; set; }
        
        public virtual ObservableCollection<BsnInspTmpViewModel> BsnInspTmps { get; set; }
        
        private String _etude;
        [DisplayName("Etude-Expertise")]
        public String Etude
        {
            get
            {
                return this._etude;
            }
            set
            {
                this._etude = value;
                RaisePropertyChange("Etude");
            }
        }
    }
}
