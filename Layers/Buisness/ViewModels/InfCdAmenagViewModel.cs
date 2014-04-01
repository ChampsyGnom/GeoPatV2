using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdAmenagViewModel : ViewModelBase
    {
        public InfCdAmenag Model {get; set;}
        public InfCdAmenagViewModel(InfCdAmenag model)
        {
            this.InfAmenagements = new  ObservableCollection<InfAmenagementViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.TypeAmenag=this.Model.TypeAmenag;
        }
        public override void Write()
        {
            this.Model.TypeAmenag=this.TypeAmenag;
        }
        public virtual ObservableCollection<InfAmenagementViewModel> InfAmenagements { get; set; }
        
        private String _typeAmenag;
        [DisplayName("Aménagement")]
        public String TypeAmenag
        {
            get
            {
                return this._typeAmenag;
            }
            set
            {
                this._typeAmenag = value;
                RaisePropertyChange("TypeAmenag");
            }
        }
    }
}
