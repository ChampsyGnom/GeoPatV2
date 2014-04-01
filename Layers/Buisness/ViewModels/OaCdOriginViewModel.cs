using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdOriginViewModel : ViewModelBase<OaCdOrigin>
    {
        public OaCdOriginViewModel(OaCdOrigin model) : base(model)
        {
            this.OaHistoNotes = new  ObservableCollection<OaHistoNoteViewModel>();
            
        }
        public override void Read()
        {
            this.Origine=this.Model.Origine;
        }
        public override void Write()
        {
            this.Model.Origine=this.Origine;
        }
        public virtual ObservableCollection<OaHistoNoteViewModel> OaHistoNotes { get; set; }
        
        private String _origine;
        [DisplayName("Origine")]
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
