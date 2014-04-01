using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdProtectViewModel : ViewModelBase
    {
        public GotCdProtect Model {get; set;}
        public GotCdProtectViewModel(GotCdProtect model)
        {
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotDscTemps = new  ObservableCollection<GotDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<GotDscViewModel> GotDscs { get; set; }
        
        public virtual ObservableCollection<GotDscTempViewModel> GotDscTemps { get; set; }
        
        private String _type;
        [DisplayName("Protections")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
            }
        }
    }
}
