using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdMpaViewModel : ViewModelBase<ChsCdMpa>
    {
        public ChsCdMpaViewModel(ChsCdMpa model) : base(model)
        {
            this.ChsPlateformes = new  ObservableCollection<ChsPlateformeViewModel>();
            
        }
        public override void Read()
        {
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.Valeur=this.Valeur;
        }
        public virtual ObservableCollection<ChsPlateformeViewModel> ChsPlateformes { get; set; }
        
        private Int64 _valeur;
        [DisplayName("Valeur (MPa)")]
        public Int64 Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        
    }
}
