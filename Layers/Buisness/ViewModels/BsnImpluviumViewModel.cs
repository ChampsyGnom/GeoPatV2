using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnImpluviumViewModel : ViewModelBase<BsnImpluvium>
    {
        public BsnImpluviumViewModel(BsnImpluvium model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Surface=this.Model.Surface;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Surface=this.Surface;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnDscViewModel _bsnDsc;
        [DisplayName("Bassin")]
        public virtual BsnDscViewModel BsnDsc
        {
            get
            {
                return this._bsnDsc;
            }
            set
            {
                this._bsnDsc = value;
                RaisePropertyChange("BsnDsc");
            }
        }
        
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
        private Int64 _absDeb;
        [DisplayName("PR début")]
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
        [DisplayName("PR fin")]
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
        
        private Nullable<Double> _surface;
        [DisplayName("Surface (ha)")]
        public Nullable<Double> Surface
        {
            get
            {
                return this._surface;
            }
            set
            {
                this._surface = value;
                RaisePropertyChange("Surface");
            }
        }
        
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
    }
}
