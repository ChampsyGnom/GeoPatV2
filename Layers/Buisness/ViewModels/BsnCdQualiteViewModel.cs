using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdQualiteViewModel : ViewModelBase<BsnCdQualite>
    {
        public BsnCdQualiteViewModel(BsnCdQualite model) : base(model)
        {
            this.BsnSeuilQualites = new  ObservableCollection<BsnSeuilQualiteViewModel>();
            
            this.BsnDscs = new  ObservableCollection<BsnDscViewModel>();
            
        }
        public override void Read()
        {
            this.Qualite=this.Model.Qualite;
        }
        public override void Write()
        {
            this.Model.Qualite=this.Qualite;
        }
        public virtual ObservableCollection<BsnSeuilQualiteViewModel> BsnSeuilQualites { get; set; }
        
        public virtual ObservableCollection<BsnDscViewModel> BsnDscs { get; set; }
        
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
