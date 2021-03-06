using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhTravauxViewModel : ViewModelBase<OhTravaux>
    {
        public OhTravauxViewModel(OhTravaux model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhDsc=new OhDscViewModel( this.Model.OhDsc);
            this.OhNatureTrav=new OhNatureTravViewModel( this.Model.OhNatureTrav);
            this.OhCdEntp=new OhCdEntpViewModel( this.Model.OhCdEntp);
            this.DateRcp=this.Model.DateRcp;
            this.DateFinGar=this.Model.DateFinGar;
            this.Cout=this.Model.Cout;
            this.Marche=this.Model.Marche;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OhDsc=this. OhDsc.Model;
            this.Model.OhNatureTrav=this. OhNatureTrav.Model;
            this.Model.OhCdEntp=this. OhCdEntp.Model;
            this.Model.DateRcp=this.DateRcp;
            this.Model.DateFinGar=this.DateFinGar;
            this.Model.Cout=this.Cout;
            this.Model.Marche=this.Marche;
            this.Model.Commentaire=this.Commentaire;
        }
        private OhDscViewModel _ohDsc;
        [DisplayName("Ouvrage Hydraulique")]
        public virtual OhDscViewModel OhDsc
        {
            get
            {
                return this._ohDsc;
            }
            set
            {
                this._ohDsc = value;
                RaisePropertyChange("OhDsc");
            }
        }
        
        private OhNatureTravViewModel _ohNatureTrav;
        [DisplayName("Nature travaux")]
        public virtual OhNatureTravViewModel OhNatureTrav
        {
            get
            {
                return this._ohNatureTrav;
            }
            set
            {
                this._ohNatureTrav = value;
                RaisePropertyChange("OhNatureTrav");
            }
        }
        
        private OhCdEntpViewModel _ohCdEntp;
        [DisplayName("Entreprise")]
        public virtual OhCdEntpViewModel OhCdEntp
        {
            get
            {
                return this._ohCdEntp;
            }
            set
            {
                this._ohCdEntp = value;
                RaisePropertyChange("OhCdEntp");
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["DateRcp"] != null)
                {
                    errors.Add("Date Réception : "+this["DateRcp"]);
                }
                if (this["DateFinGar"] != null)
                {
                    errors.Add("Fin de garantie : "+this["DateFinGar"]);
                }
                if (this["Cout"] != null)
                {
                    errors.Add("Coûts (€) : "+this["Cout"]);
                }
                if (this["Marche"] != null)
                {
                    errors.Add("No Marché : "+this["Marche"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
                }
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                if (columnName.Equals("DateRcp"))
                {
                }
                if (columnName.Equals("DateFinGar"))
                {
                }
                if (columnName.Equals("Cout"))
                {
                }
                if (columnName.Equals("Marche"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                return null;
            }
        }
    }
}
