using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdQualiteViewModel : ViewModelBase
    {
        public GotCdQualite Model {get; set;}
        public GotCdQualiteViewModel(GotCdQualite model)
        {
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotSeuilQualites = new  ObservableCollection<GotSeuilQualiteViewModel>();
            
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
        public virtual ObservableCollection<GotDscViewModel> GotDscs { get; set; }
        
        public virtual ObservableCollection<GotSeuilQualiteViewModel> GotSeuilQualites { get; set; }
        
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
