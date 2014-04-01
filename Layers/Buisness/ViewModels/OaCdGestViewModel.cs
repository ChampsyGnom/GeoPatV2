using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdGestViewModel : ViewModelBase
    {
        public OaCdGest Model {get; set;}
        public OaCdGestViewModel(OaCdGest model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Gestionnaire=this.Model.Gestionnaire;
        }
        public override void Write()
        {
            this.Model.Gestionnaire=this.Gestionnaire;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _gestionnaire;
        [DisplayName("Gestionnaire")]
        public String Gestionnaire
        {
            get
            {
                return this._gestionnaire;
            }
            set
            {
                this._gestionnaire = value;
                RaisePropertyChange("Gestionnaire");
            }
        }
    }
}
