using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaArchive3ViewModel : ViewModelBase<OaArchive3>
    {
        public OaArchive3ViewModel(OaArchive3 model) : base(model)
        {
            this.OaDscArchive3s = new  ObservableCollection<OaDscArchive3ViewModel>();
            
        }
        public override void Read()
        {
            this.DateCalc=this.Model.DateCalc;
            this.Nbre=this.Model.Nbre;
            this.Surf=this.Model.Surf;
            this.Etat3x=this.Model.Etat3x;
            this.Delai=this.Model.Delai;
            this.EtatLolf=this.Model.EtatLolf;
            this.Montant=this.Model.Montant;
            this.Obsv=this.Model.Obsv;
        }
        public override void Write()
        {
            this.Model.DateCalc=this.DateCalc;
            this.Model.Nbre=this.Nbre;
            this.Model.Surf=this.Surf;
            this.Model.Etat3x=this.Etat3x;
            this.Model.Delai=this.Delai;
            this.Model.EtatLolf=this.EtatLolf;
            this.Model.Montant=this.Montant;
            this.Model.Obsv=this.Obsv;
        }
        public virtual ObservableCollection<OaDscArchive3ViewModel> OaDscArchive3s { get; set; }
        
        private DateTime _dateCalc;
        [DisplayName("Date Calcul")]
        public DateTime DateCalc
        {
            get
            {
                return this._dateCalc;
            }
            set
            {
                this._dateCalc = value;
                RaisePropertyChange("DateCalc");
            }
        }
        
        private Int64 _nbre;
        [DisplayName("Nbre Total OA")]
        public Int64 Nbre
        {
            get
            {
                return this._nbre;
            }
            set
            {
                this._nbre = value;
                RaisePropertyChange("Nbre");
            }
        }
        
        private Int64 _surf;
        [DisplayName("Surf totale")]
        public Int64 Surf
        {
            get
            {
                return this._surf;
            }
            set
            {
                this._surf = value;
                RaisePropertyChange("Surf");
            }
        }
        
        private String _etat3x;
        [DisplayName("Etat 3x")]
        public String Etat3x
        {
            get
            {
                return this._etat3x;
            }
            set
            {
                this._etat3x = value;
                RaisePropertyChange("Etat3x");
            }
        }
        private Nullable<Int64> _delai;
        [DisplayName("Délai")]
        public Nullable<Int64> Delai
        {
            get
            {
                return this._delai;
            }
            set
            {
                this._delai = value;
                RaisePropertyChange("Delai");
            }
        }
        
        private Nullable<Double> _etatLolf;
        [DisplayName("Etat Lolf")]
        public Nullable<Double> EtatLolf
        {
            get
            {
                return this._etatLolf;
            }
            set
            {
                this._etatLolf = value;
                RaisePropertyChange("EtatLolf");
            }
        }
        
        private Nullable<Int64> _montant;
        [DisplayName("Montant pénalité")]
        public Nullable<Int64> Montant
        {
            get
            {
                return this._montant;
            }
            set
            {
                this._montant = value;
                RaisePropertyChange("Montant");
            }
        }
        
        private String _obsv;
        [DisplayName("Commentaire")]
        public String Obsv
        {
            get
            {
                return this._obsv;
            }
            set
            {
                this._obsv = value;
                RaisePropertyChange("Obsv");
            }
        }
    }
}
