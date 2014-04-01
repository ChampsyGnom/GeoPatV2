using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsTravauxViewModel : ViewModelBase
    {
        public GmsTravaux Model {get; set;}
        public GmsTravauxViewModel(GmsTravaux model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsDsc=new GmsDscViewModel( this.Model.GmsDsc);
            this.GmsNatureTrav=new GmsNatureTravViewModel( this.Model.GmsNatureTrav);
            this.GmsCdEntp=new GmsCdEntpViewModel( this.Model.GmsCdEntp);
            this.DateRcp=this.Model.DateRcp;
            this.DateFinGar=this.Model.DateFinGar;
            this.Cout=this.Model.Cout;
            this.Marche=this.Model.Marche;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GmsDsc=this. GmsDsc.Model;
            this.Model.GmsNatureTrav=this. GmsNatureTrav.Model;
            this.Model.GmsCdEntp=this. GmsCdEntp.Model;
            this.Model.DateRcp=this.DateRcp;
            this.Model.DateFinGar=this.DateFinGar;
            this.Model.Cout=this.Cout;
            this.Model.Marche=this.Marche;
            this.Model.Commentaire=this.Commentaire;
        }
        private GmsDscViewModel _gmsDsc;
        [DisplayName("Grand Matériel de Signalisation")]
        public virtual GmsDscViewModel GmsDsc
        {
            get
            {
                return this._gmsDsc;
            }
            set
            {
                this._gmsDsc = value;
                RaisePropertyChange("GmsDsc");
            }
        }
        
        private GmsNatureTravViewModel _gmsNatureTrav;
        [DisplayName("Nature travaux")]
        public virtual GmsNatureTravViewModel GmsNatureTrav
        {
            get
            {
                return this._gmsNatureTrav;
            }
            set
            {
                this._gmsNatureTrav = value;
                RaisePropertyChange("GmsNatureTrav");
            }
        }
        
        private GmsCdEntpViewModel _gmsCdEntp;
        [DisplayName("Entreprises")]
        public virtual GmsCdEntpViewModel GmsCdEntp
        {
            get
            {
                return this._gmsCdEntp;
            }
            set
            {
                this._gmsCdEntp = value;
                RaisePropertyChange("GmsCdEntp");
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
