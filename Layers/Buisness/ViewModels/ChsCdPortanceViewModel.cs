using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdPortanceViewModel : ViewModelBase<ChsCdPortance>
    {
        public ChsCdPortanceViewModel(ChsCdPortance model) : base(model)
        {
            this.ChsPlateformes = new  ObservableCollection<ChsPlateformeViewModel>();
            
        }
        public override void Read()
        {
            this.Classe=this.Model.Classe;
        }
        public override void Write()
        {
            this.Model.Classe=this.Classe;
        }
        public virtual ObservableCollection<ChsPlateformeViewModel> ChsPlateformes { get; set; }
        
        private String _classe;
        [DisplayName("Classe portance")]
        public String Classe
        {
            get
            {
                return this._classe;
            }
            set
            {
                this._classe = value;
                RaisePropertyChange("Classe");
            }
        }
    }
}
