using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaTravauxViewModel : ViewModelBase<OaTravaux>
    {
        public OaTravauxViewModel(OaTravaux model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.OaNatureTrav=new OaNatureTravViewModel( this.Model.OaNatureTrav);
            this.OaCdEntp=new OaCdEntpViewModel( this.Model.OaCdEntp);
            this.DateRcp=this.Model.DateRcp;
            this.DateFinGar=this.Model.DateFinGar;
            this.Cout=this.Model.Cout;
            this.Marche=this.Model.Marche;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.OaNatureTrav=this. OaNatureTrav.Model;
            this.Model.OaCdEntp=this. OaCdEntp.Model;
            this.Model.DateRcp=this.DateRcp;
            this.Model.DateFinGar=this.DateFinGar;
            this.Model.Cout=this.Cout;
            this.Model.Marche=this.Marche;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaDscViewModel _oaDsc;
        [DisplayName("Ouvrages d'Art")]
        public virtual OaDscViewModel OaDsc
        {
            get
            {
                return this._oaDsc;
            }
            set
            {
                this._oaDsc = value;
                RaisePropertyChange("OaDsc");
            }
        }
        
        private OaNatureTravViewModel _oaNatureTrav;
        [DisplayName("Nature travaux")]
        public virtual OaNatureTravViewModel OaNatureTrav
        {
            get
            {
                return this._oaNatureTrav;
            }
            set
            {
                this._oaNatureTrav = value;
                RaisePropertyChange("OaNatureTrav");
            }
        }
        
        private OaCdEntpViewModel _oaCdEntp;
        [DisplayName("Entreprise")]
        public virtual OaCdEntpViewModel OaCdEntp
        {
            get
            {
                return this._oaCdEntp;
            }
            set
            {
                this._oaCdEntp = value;
                RaisePropertyChange("OaCdEntp");
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
