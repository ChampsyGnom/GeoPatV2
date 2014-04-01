using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdQualiteViewModel : ViewModelBase
    {
        public OhCdQualite Model {get; set;}
        public OhCdQualiteViewModel(OhCdQualite model)
        {
            this.OhSeuilQualites = new  ObservableCollection<OhSeuilQualiteViewModel>();
            
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Qualite=this.Model.Qualite;
        }
        public override void Write()
        {
            this.Model.Qualite=this.Qualite;
        }
        public virtual ObservableCollection<OhSeuilQualiteViewModel> OhSeuilQualites { get; set; }
        
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        private String _qualite;
        [DisplayName("Niveau qualité")]
        public String Qualite
        {
            get
            {
                return this._qualite;
            }
            set
            {
                this._qualite = value;
                RaisePropertyChange("Qualite");
            }
        }
    }
}
