using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdRisqueViewModel : ViewModelBase<GotCdRisque>
    {
        public GotCdRisqueViewModel(GotCdRisque model) : base(model)
        {
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotHistoNotes = new  ObservableCollection<GotHistoNoteViewModel>();
            
        }
        public override void Read()
        {
            this.Risque=this.Model.Risque;
        }
        public override void Write()
        {
            this.Model.Risque=this.Risque;
        }
        public virtual ObservableCollection<GotDscViewModel> GotDscs { get; set; }
        
        public virtual ObservableCollection<GotHistoNoteViewModel> GotHistoNotes { get; set; }
        
        private String _risque;
        [DisplayName("Note Risque")]
        public String Risque
        {
            get
            {
                return this._risque;
            }
            set
            {
                this._risque = value;
                RaisePropertyChange("Risque");
            }
        }
    }
}
