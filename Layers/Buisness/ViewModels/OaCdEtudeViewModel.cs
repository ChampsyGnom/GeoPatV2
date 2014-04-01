using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdEtudeViewModel : ViewModelBase<OaCdEtude>
    {
        public OaCdEtudeViewModel(OaCdEtude model) : base(model)
        {
            this.OaInsps = new  ObservableCollection<OaInspViewModel>();
            
            this.OaInspTmps = new  ObservableCollection<OaInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.Etude=this.Model.Etude;
        }
        public override void Write()
        {
            this.Model.Etude=this.Etude;
        }
        public virtual ObservableCollection<OaInspViewModel> OaInsps { get; set; }
        
        public virtual ObservableCollection<OaInspTmpViewModel> OaInspTmps { get; set; }
        
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
