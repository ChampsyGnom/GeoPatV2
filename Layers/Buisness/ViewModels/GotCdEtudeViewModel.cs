using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdEtudeViewModel : ViewModelBase
    {
        public GotCdEtude Model {get; set;}
        public GotCdEtudeViewModel(GotCdEtude model)
        {
            this.GotInsps = new  ObservableCollection<GotInspViewModel>();
            
            this.GotInspTmps = new  ObservableCollection<GotInspTmpViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Etude=this.Model.Etude;
        }
        public override void Write()
        {
            this.Model.Etude=this.Etude;
        }
        public virtual ObservableCollection<GotInspViewModel> GotInsps { get; set; }
        
        public virtual ObservableCollection<GotInspTmpViewModel> GotInspTmps { get; set; }
        
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
