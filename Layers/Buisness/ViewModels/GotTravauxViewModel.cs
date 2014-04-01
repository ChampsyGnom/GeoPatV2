using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotTravauxViewModel : ViewModelBase<GotTravaux>
    {
        public GotTravauxViewModel(GotTravaux model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotDsc=new GotDscViewModel( this.Model.GotDsc);
            this.GotNatureTrav=new GotNatureTravViewModel( this.Model.GotNatureTrav);
            this.GotCdEntp=new GotCdEntpViewModel( this.Model.GotCdEntp);
            this.DateRcp=this.Model.DateRcp;
            this.DateFinGar=this.Model.DateFinGar;
            this.Cout=this.Model.Cout;
            this.Marche=this.Model.Marche;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotDsc=this. GotDsc.Model;
            this.Model.GotNatureTrav=this. GotNatureTrav.Model;
            this.Model.GotCdEntp=this. GotCdEntp.Model;
            this.Model.DateRcp=this.DateRcp;
            this.Model.DateFinGar=this.DateFinGar;
            this.Model.Cout=this.Cout;
            this.Model.Marche=this.Marche;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotDscViewModel _gotDsc;
        [DisplayName("Terrassement")]
        public virtual GotDscViewModel GotDsc
        {
            get
            {
                return this._gotDsc;
            }
            set
            {
                this._gotDsc = value;
                RaisePropertyChange("GotDsc");
            }
        }
        
        private GotNatureTravViewModel _gotNatureTrav;
        [DisplayName("Nature travaux")]
        public virtual GotNatureTravViewModel GotNatureTrav
        {
            get
            {
                return this._gotNatureTrav;
            }
            set
            {
                this._gotNatureTrav = value;
                RaisePropertyChange("GotNatureTrav");
            }
        }
        
        private GotCdEntpViewModel _gotCdEntp;
        [DisplayName("Entreprises")]
        public virtual GotCdEntpViewModel GotCdEntp
        {
            get
            {
                return this._gotCdEntp;
            }
            set
            {
                this._gotCdEntp = value;
                RaisePropertyChange("GotCdEntp");
            }
        }
        
        private DateTime _dateRcp;
        [DisplayName("Date réception")]
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
        [DisplayName("Date fin de garantie")]
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
        [DisplayName("Coûts (€)")]
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
