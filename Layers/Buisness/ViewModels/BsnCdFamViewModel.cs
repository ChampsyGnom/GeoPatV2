using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdFamViewModel : ViewModelBase<BsnCdFam>
    {
        public BsnCdFamViewModel(BsnCdFam model) : base(model)
        {
            this.BsnDscs = new  ObservableCollection<BsnDscViewModel>();
            
            this.BsnDscTemps = new  ObservableCollection<BsnDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Famille=this.Model.Famille;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Famille=this.Famille;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<BsnDscViewModel> BsnDscs { get; set; }
        
        public virtual ObservableCollection<BsnDscTempViewModel> BsnDscTemps { get; set; }
        
        private String _famille;
        [DisplayName("Dénomination")]
        public String Famille
        {
            get
            {
                return this._famille;
            }
            set
            {
                this._famille = value;
                RaisePropertyChange("Famille");
            }
        }
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
    }
}
