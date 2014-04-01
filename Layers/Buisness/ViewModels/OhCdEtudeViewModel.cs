using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdEtudeViewModel : ViewModelBase<OhCdEtude>
    {
        public OhCdEtudeViewModel(OhCdEtude model) : base(model)
        {
            this.OhInsps = new  ObservableCollection<OhInspViewModel>();
            
            this.OhInspTmps = new  ObservableCollection<OhInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.Etude=this.Model.Etude;
        }
        public override void Write()
        {
            this.Model.Etude=this.Etude;
        }
        public virtual ObservableCollection<OhInspViewModel> OhInsps { get; set; }
        
        public virtual ObservableCollection<OhInspTmpViewModel> OhInspTmps { get; set; }
        
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
