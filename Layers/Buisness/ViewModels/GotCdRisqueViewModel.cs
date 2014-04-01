using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdRisqueViewModel : ViewModelBase
    {
        public GotCdRisque Model {get; set;}
        public GotCdRisqueViewModel(GotCdRisque model)
        {
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotHistoNotes = new  ObservableCollection<GotHistoNoteViewModel>();
            
            this.Model = model;
            this.Read();
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
