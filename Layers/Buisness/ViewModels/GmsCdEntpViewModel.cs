using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdEntpViewModel : ViewModelBase<GmsCdEntp>
    {
        public GmsCdEntpViewModel(GmsCdEntp model) : base(model)
        {
            this.GmsDscs = new  ObservableCollection<GmsDscViewModel>();
            
            this.GmsTravauxs = new  ObservableCollection<GmsTravauxViewModel>();
            
            this.GmsPanneaus = new  ObservableCollection<GmsPanneauViewModel>();
            
            this.GmsDscTemps = new  ObservableCollection<GmsDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Entreprise=this.Model.Entreprise;
        }
        public override void Write()
        {
            this.Model.Entreprise=this.Entreprise;
        }
        public virtual ObservableCollection<GmsDscViewModel> GmsDscs { get; set; }
        
        public virtual ObservableCollection<GmsTravauxViewModel> GmsTravauxs { get; set; }
        
        public virtual ObservableCollection<GmsPanneauViewModel> GmsPanneaus { get; set; }
        
        public virtual ObservableCollection<GmsDscTempViewModel> GmsDscTemps { get; set; }
        
        private String _entreprise;
        [DisplayName("Entreprise")]
        public String Entreprise
        {
            get
            {
                return this._entreprise;
            }
            set
            {
                this._entreprise = value;
                RaisePropertyChange("Entreprise");
            }
        }
    }
}
