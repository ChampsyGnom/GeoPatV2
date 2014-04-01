using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdMoViewModel : ViewModelBase<OaCdMo>
    {
        public OaCdMoViewModel(OaCdMo model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.MaitreOuvr=this.Model.MaitreOuvr;
        }
        public override void Write()
        {
            this.Model.MaitreOuvr=this.MaitreOuvr;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _maitreOuvr;
        [DisplayName("Maitre d'ouvrage")]
        public String MaitreOuvr
        {
            get
            {
                return this._maitreOuvr;
            }
            set
            {
                this._maitreOuvr = value;
                RaisePropertyChange("MaitreOuvr");
            }
        }
    }
}
