using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdInterfaceViewModel : ViewModelBase
    {
        public GmsCdInterface Model {get; set;}
        public GmsCdInterfaceViewModel(GmsCdInterface model)
        {
            this.GmsDscs = new  ObservableCollection<GmsDscViewModel>();
            
            this.GmsPanneaus = new  ObservableCollection<GmsPanneauViewModel>();
            
            this.GmsDscTemps = new  ObservableCollection<GmsDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
            this.Frequence=this.Model.Frequence;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
            this.Model.Frequence=this.Frequence;
        }
        public virtual ObservableCollection<GmsDscViewModel> GmsDscs { get; set; }
        
        public virtual ObservableCollection<GmsPanneauViewModel> GmsPanneaus { get; set; }
        
        public virtual ObservableCollection<GmsDscTempViewModel> GmsDscTemps { get; set; }
        
        private String _type;
        [DisplayName("Type de liaison GMS")]
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
        private Nullable<Int64> _frequence;
        [DisplayName("Fréquence vérification des serrages (mois)")]
        public Nullable<Int64> Frequence
        {
            get
            {
                return this._frequence;
            }
            set
            {
                this._frequence = value;
                RaisePropertyChange("Frequence");
            }
        }
        
    }
}
