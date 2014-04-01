using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCampViewModel : ViewModelBase
    {
        public ChsCamp Model {get; set;}
        public ChsCampViewModel(ChsCamp model)
        {
            this.ChsDetailCamps = new  ObservableCollection<ChsDetailCampViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ChsCdMesure=new ChsCdMesureViewModel( this.Model.ChsCdMesure);
            this.Section=this.Model.Section;
            this.Annee=this.Model.Annee;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.Voie=this.Model.Voie;
            this.Dateg=this.Model.Dateg;
            this.Datec=this.Model.Datec;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.DateLoad=this.Model.DateLoad;
            this.DateMes=this.Model.DateMes;
            this.Pas=this.Model.Pas;
            this.Observ=this.Model.Observ;
        }
        public override void Write()
        {
            this.Model.ChsCdMesure=this. ChsCdMesure.Model;
            this.Model.Section=this.Section;
            this.Model.Annee=this.Annee;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.Voie=this.Voie;
            this.Model.Dateg=this.Dateg;
            this.Model.Datec=this.Datec;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateLoad=this.DateLoad;
            this.Model.DateMes=this.DateMes;
            this.Model.Pas=this.Pas;
            this.Model.Observ=this.Observ;
        }
        private ChsCdMesureViewModel _chsCdMesure;
        [DisplayName("Appareils de mesure")]
        public virtual ChsCdMesureViewModel ChsCdMesure
        {
            get
            {
                return this._chsCdMesure;
            }
            set
            {
                this._chsCdMesure = value;
                RaisePropertyChange("ChsCdMesure");
            }
        }
        
        public virtual ObservableCollection<ChsDetailCampViewModel> ChsDetailCamps { get; set; }
        
        private String _section;
        [DisplayName("Num Section")]
        public String Section
        {
            get
            {
                return this._section;
            }
            set
            {
                this._section = value;
                RaisePropertyChange("Section");
            }
        }
        private Int64 _annee;
        [DisplayName("Année")]
        public Int64 Annee
        {
            get
            {
                return this._annee;
            }
            set
            {
                this._annee = value;
                RaisePropertyChange("Annee");
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
        private Nullable<DateTime> _dateg;
        [DisplayName("Date génération")]
        public Nullable<DateTime> Dateg
        {
            get
            {
                return this._dateg;
            }
            set
            {
                this._dateg = value;
                RaisePropertyChange("Dateg");
            }
        }
        
        private DateTime _datec;
        [DisplayName("Date maxi retour")]
        public DateTime Datec
        {
            get
            {
                return this._datec;
            }
            set
            {
                this._datec = value;
                RaisePropertyChange("Datec");
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
        
        private Nullable<DateTime> _dateLoad;
        [DisplayName("Date de chargement")]
        public Nullable<DateTime> DateLoad
        {
            get
            {
                return this._dateLoad;
            }
            set
            {
                this._dateLoad = value;
                RaisePropertyChange("DateLoad");
            }
        }
        
        private Nullable<DateTime> _dateMes;
        [DisplayName("Date des mesures")]
        public Nullable<DateTime> DateMes
        {
            get
            {
                return this._dateMes;
            }
            set
            {
                this._dateMes = value;
                RaisePropertyChange("DateMes");
            }
        }
        
        private Nullable<Int64> _pas;
        [DisplayName("Pas mesure")]
        public Nullable<Int64> Pas
        {
            get
            {
                return this._pas;
            }
            set
            {
                this._pas = value;
                RaisePropertyChange("Pas");
            }
        }
        
        private String _observ;
        [DisplayName("Commentaire")]
        public String Observ
        {
            get
            {
                return this._observ;
            }
            set
            {
                this._observ = value;
                RaisePropertyChange("Observ");
            }
        }
    }
}
