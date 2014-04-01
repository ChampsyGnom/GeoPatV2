using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdModShViewModel : ViewModelBase
    {
        public EqpCdModSh Model {get; set;}
        public EqpCdModShViewModel(EqpCdModSh model)
        {
            this.EqpCdMarquageShs = new  ObservableCollection<EqpCdMarquageShViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Mod=this.Model.Mod;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Mod=this.Mod;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<EqpCdMarquageShViewModel> EqpCdMarquageShs { get; set; }
        
        private String _mod;
        [DisplayName("Modulation")]
        public String Mod
        {
            get
            {
                return this._mod;
            }
            set
            {
                this._mod = value;
                RaisePropertyChange("Mod");
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
