using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdEntpViewModel : ViewModelBase
    {
        public OaCdEntp Model {get; set;}
        public OaCdEntpViewModel(OaCdEntp model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaTravauxs = new  ObservableCollection<OaTravauxViewModel>();
            
            this.OaTabliers = new  ObservableCollection<OaTablierViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Entreprise=this.Model.Entreprise;
        }
        public override void Write()
        {
            this.Model.Entreprise=this.Entreprise;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaTravauxViewModel> OaTravauxs { get; set; }
        
        public virtual ObservableCollection<OaTablierViewModel> OaTabliers { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
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
