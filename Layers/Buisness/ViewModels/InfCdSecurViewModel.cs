using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdSecurViewModel : ViewModelBase
    {
        public InfCdSecur Model {get; set;}
        public InfCdSecurViewModel(InfCdSecur model)
        {
            this.InfSecurites = new  ObservableCollection<InfSecuriteViewModel>();
            
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
        public virtual ObservableCollection<InfSecuriteViewModel> InfSecurites { get; set; }
        
        private String _type;
        [DisplayName("Sécurité")]
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
