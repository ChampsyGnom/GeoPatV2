using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdProduitShViewModel : ViewModelBase<EqpCdProduitSh>
    {
        public EqpCdProduitShViewModel(EqpCdProduitSh model) : base(model)
        {
            this.EqpDscShs = new  ObservableCollection<EqpDscShViewModel>();
            
        }
        public override void Read()
        {
            this.Produit=this.Model.Produit;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Produit=this.Produit;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<EqpDscShViewModel> EqpDscShs { get; set; }
        
        private String _produit;
        [DisplayName("Produit")]
        public String Produit
        {
            get
            {
                return this._produit;
            }
            set
            {
                this._produit = value;
                RaisePropertyChange("Produit");
            }
        }
        private Nullable<Int64> _garantie;
        [DisplayName("Garantie (mois)")]
        public Nullable<Int64> Garantie
        {
            get
            {
                return this._garantie;
            }
            set
            {
                this._garantie = value;
                RaisePropertyChange("Garantie");
            }
        }
        
        private Nullable<Int64> _dvt;
        [DisplayName("Durée de vie (mois)")]
        public Nullable<Int64> Dvt
        {
            get
            {
                return this._dvt;
            }
            set
            {
                this._dvt = value;
                RaisePropertyChange("Dvt");
            }
        }
        
    }
}
