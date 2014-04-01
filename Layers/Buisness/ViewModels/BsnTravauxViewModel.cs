using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnTravauxViewModel : ViewModelBase
    {
        public BsnTravaux Model {get; set;}
        public BsnTravauxViewModel(BsnTravaux model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.BsnNatureTrav=new BsnNatureTravViewModel( this.Model.BsnNatureTrav);
            this.BsnCdEntp=new BsnCdEntpViewModel( this.Model.BsnCdEntp);
            this.DateRcp=this.Model.DateRcp;
            this.DateFinGar=this.Model.DateFinGar;
            this.Cout=this.Model.Cout;
            this.Marche=this.Model.Marche;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.BsnNatureTrav=this. BsnNatureTrav.Model;
            this.Model.BsnCdEntp=this. BsnCdEntp.Model;
            this.Model.DateRcp=this.DateRcp;
            this.Model.DateFinGar=this.DateFinGar;
            this.Model.Cout=this.Cout;
            this.Model.Marche=this.Marche;
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
        
        private BsnNatureTravViewModel _bsnNatureTrav;
        [DisplayName("Nature travaux")]
        public virtual BsnNatureTravViewModel BsnNatureTrav
        {
            get
            {
                return this._bsnNatureTrav;
            }
            set
            {
                this._bsnNatureTrav = value;
                RaisePropertyChange("BsnNatureTrav");
            }
        }
        
        private BsnCdEntpViewModel _bsnCdEntp;
        [DisplayName("Entreprise")]
        public virtual BsnCdEntpViewModel BsnCdEntp
        {
            get
            {
                return this._bsnCdEntp;
            }
            set
            {
                this._bsnCdEntp = value;
                RaisePropertyChange("BsnCdEntp");
            }
        }
        
        private DateTime _dateRcp;
        [DisplayName("Date Réception")]
        public DateTime DateRcp
        {
            get
            {
                return this._dateRcp;
            }
            set
            {
                this._dateRcp = value;
                RaisePropertyChange("DateRcp");
            }
        }
        
        private Nullable<DateTime> _dateFinGar;
        [DisplayName("Fin de garantie")]
        public Nullable<DateTime> DateFinGar
        {
            get
            {
                return this._dateFinGar;
            }
            set
            {
                this._dateFinGar = value;
                RaisePropertyChange("DateFinGar");
            }
        }
        
        private Nullable<Int64> _cout;
        [DisplayName("Coût")]
        public Nullable<Int64> Cout
        {
            get
            {
                return this._cout;
            }
            set
            {
                this._cout = value;
                RaisePropertyChange("Cout");
            }
        }
        
        private String _marche;
        [DisplayName("No Marché")]
        public String Marche
        {
            get
            {
                return this._marche;
            }
            set
            {
                this._marche = value;
                RaisePropertyChange("Marche");
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
