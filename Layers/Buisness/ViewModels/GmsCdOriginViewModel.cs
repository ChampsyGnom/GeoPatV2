using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdOriginViewModel : ViewModelBase<GmsCdOrigin>
    {
        public GmsCdOriginViewModel(GmsCdOrigin model) : base(model)
        {
            this.GmsHistoNotes = new  ObservableCollection<GmsHistoNoteViewModel>();
            
        }
        public override void Read()
        {
            this.Origine=this.Model.Origine;
        }
        public override void Write()
        {
            this.Model.Origine=this.Origine;
        }
        public virtual ObservableCollection<GmsHistoNoteViewModel> GmsHistoNotes { get; set; }
        
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
