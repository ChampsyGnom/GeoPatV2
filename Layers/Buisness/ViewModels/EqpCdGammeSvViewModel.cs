using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdGammeSvViewModel : ViewModelBase
    {
        public EqpCdGammeSv Model {get; set;}
        public EqpCdGammeSvViewModel(EqpCdGammeSv model)
        {
            this.EqpPanneaus = new  ObservableCollection<EqpPanneauViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Gamme=this.Model.Gamme;
            this.Dimension=this.Model.Dimension;
        }
        public override void Write()
        {
            this.Model.Gamme=this.Gamme;
            this.Model.Dimension=this.Dimension;
        }
        public virtual ObservableCollection<EqpPanneauViewModel> EqpPanneaus { get; set; }
        
        private String _gamme;
        [DisplayName("Gamme")]
        public String Gamme
        {
            get
            {
                return this._gamme;
            }
            set
            {
                this._gamme = value;
                RaisePropertyChange("Gamme");
            }
        }
        private Nullable<Int64> _dimension;
        [DisplayName("Dimension (mm)")]
        public Nullable<Int64> Dimension
        {
            get
            {
                return this._dimension;
            }
            set
            {
                this._dimension = value;
                RaisePropertyChange("Dimension");
            }
        }
        
    }
}
