using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdQualiteViewModel : ViewModelBase<OhCdQualite>
    {
        public OhCdQualiteViewModel(OhCdQualite model) : base(model)
        {
            this.OhSeuilQualites = new  ObservableCollection<OhSeuilQualiteViewModel>();
            
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
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
