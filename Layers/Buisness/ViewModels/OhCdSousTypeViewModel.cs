using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdSousTypeViewModel : ViewModelBase
    {
        public OhCdSousType Model {get; set;}
        public OhCdSousTypeViewModel(OhCdSousType model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.SousType=this.Model.SousType;
        }
        public override void Write()
        {
            this.Model.SousType=this.SousType;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _sousType;
        [DisplayName("Sous type OH")]
        public String SousType
        {
            get
            {
                return this._sousType;
            }
            set
            {
                this._sousType = value;
                RaisePropertyChange("SousType");
            }
        }
    }
}
