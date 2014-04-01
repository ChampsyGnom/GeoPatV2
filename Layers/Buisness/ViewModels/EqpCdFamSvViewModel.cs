using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdFamSvViewModel : ViewModelBase<EqpCdFamSv>
    {
        public EqpCdFamSvViewModel(EqpCdFamSv model) : base(model)
        {
            this.EqpDscSvs = new  ObservableCollection<EqpDscSvViewModel>();
            
            this.EqpCdTypeSvs = new  ObservableCollection<EqpCdTypeSvViewModel>();
            
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
        public virtual ObservableCollection<EqpDscSvViewModel> EqpDscSvs { get; set; }
        
        public virtual ObservableCollection<EqpCdTypeSvViewModel> EqpCdTypeSvs { get; set; }
        
        private String _famille;
        [DisplayName("Famille")]
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
