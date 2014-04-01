using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdPrestataireViewModel : ViewModelBase<InfCdPrestataire>
    {
        public InfCdPrestataireViewModel(InfCdPrestataire model) : base(model)
        {
            this.InfPrestataires = new  ObservableCollection<InfPrestataireViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<InfPrestataireViewModel> InfPrestataires { get; set; }
        
        private String _type;
        [DisplayName("Type Prestataire")]
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
