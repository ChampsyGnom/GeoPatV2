using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdOuvViewModel : ViewModelBase
    {
        public OhCdOuv Model {get; set;}
        public OhCdOuvViewModel(OhCdOuv model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Ouv=this.Model.Ouv;
        }
        public override void Write()
        {
            this.Model.Ouv=this.Ouv;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _ouv;
        [DisplayName("Profil")]
        public String Ouv
        {
            get
            {
                return this._ouv;
            }
            set
            {
                this._ouv = value;
                RaisePropertyChange("Ouv");
            }
        }
    }
}
