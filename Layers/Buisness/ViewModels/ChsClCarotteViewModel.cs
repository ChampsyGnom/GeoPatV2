using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsClCarotteViewModel : ViewModelBase<ChsClCarotte>
    {
        public ChsClCarotteViewModel(ChsClCarotte model) : base(model)
        {
            this.ChsDetailCarottes = new  ObservableCollection<ChsDetailCarotteViewModel>();
            
            this.ChsExploitCarottes = new  ObservableCollection<ChsExploitCarotteViewModel>();
            
            this.ChsClRouls = new  ObservableCollection<ChsClRoulViewModel>();
            
        }
        public override void Read()
        {
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.Voie=this.Model.Voie;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
        }
        public override void Write()
        {
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.Voie=this.Voie;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
        }
        public virtual ObservableCollection<ChsDetailCarotteViewModel> ChsDetailCarottes { get; set; }
        
        public virtual ObservableCollection<ChsExploitCarotteViewModel> ChsExploitCarottes { get; set; }
        
        public virtual ObservableCollection<ChsClRoulViewModel> ChsClRouls { get; set; }
        
        private String _liaison;
        [DisplayName("Liaison")]
        public String Liaison
        {
            get
            {
                return this._liaison;
            }
            set
            {
                this._liaison = value;
                RaisePropertyChange("Liaison");
            }
        }
        private String _sens;
        [DisplayName("Sens")]
        public String Sens
        {
            get
            {
                return this._sens;
            }
            set
            {
                this._sens = value;
                RaisePropertyChange("Sens");
            }
        }
        private String _voie;
        [DisplayName("Voie")]
        public String Voie
        {
            get
            {
                return this._voie;
            }
            set
            {
                this._voie = value;
                RaisePropertyChange("Voie");
            }
        }
        private Int64 _absDeb;
        [DisplayName("Début")]
        public Int64 AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
            }
        }
        
        private Int64 _absFin;
        [DisplayName("Fin")]
        public Int64 AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
            }
        }
        
    }
}
