using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdOriginViewModel : ViewModelBase
    {
        public GotCdOrigin Model {get; set;}
        public GotCdOriginViewModel(GotCdOrigin model)
        {
            this.GotHistoNotes = new  ObservableCollection<GotHistoNoteViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Origine=this.Model.Origine;
        }
        public override void Write()
        {
            this.Model.Origine=this.Origine;
        }
        public virtual ObservableCollection<GotHistoNoteViewModel> GotHistoNotes { get; set; }
        
        private String _origine;
        [DisplayName("Origine Note")]
        public String Origine
        {
            get
            {
                return this._origine;
            }
            set
            {
                this._origine = value;
                RaisePropertyChange("Origine");
            }
        }
    }
}
