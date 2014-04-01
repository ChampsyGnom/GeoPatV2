using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpTravauxViewModel : ViewModelBase
    {
        public EqpTravaux Model {get; set;}
        public EqpTravauxViewModel(EqpTravaux model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.EqpNatureTrav=new EqpNatureTravViewModel( this.Model.EqpNatureTrav);
            this.EqpCdEntp=new EqpCdEntpViewModel( this.Model.EqpCdEntp);
            this.EqpCdType=new EqpCdTypeViewModel( this.Model.EqpCdType);
            this.IdTrav=this.Model.IdTrav;
            this.Ouvrage=this.Model.Ouvrage;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.Position=this.Model.Position;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.DateRcp=this.Model.DateRcp;
            this.Cout=this.Model.Cout;
            this.DateFinGar=this.Model.DateFinGar;
            this.Marche=this.Model.Marche;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.EqpNatureTrav=this. EqpNatureTrav.Model;
            this.Model.EqpCdEntp=this. EqpCdEntp.Model;
            this.Model.EqpCdType=this. EqpCdType.Model;
            this.Model.IdTrav=this.IdTrav;
            this.Model.Ouvrage=this.Ouvrage;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.Position=this.Position;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateRcp=this.DateRcp;
            this.Model.Cout=this.Cout;
            this.Model.DateFinGar=this.DateFinGar;
            this.Model.Marche=this.Marche;
            this.Model.Commentaire=this.Commentaire;
        }
        private EqpNatureTravViewModel _eqpNatureTrav;
        [DisplayName("Nature travaux")]
        public virtual EqpNatureTravViewModel EqpNatureTrav
        {
            get
            {
                return this._eqpNatureTrav;
            }
            set
            {
                this._eqpNatureTrav = value;
                RaisePropertyChange("EqpNatureTrav");
            }
        }
        
        private EqpCdEntpViewModel _eqpCdEntp;
        [DisplayName("Nom Entreprise")]
        public virtual EqpCdEntpViewModel EqpCdEntp
        {
            get
            {
                return this._eqpCdEntp;
            }
            set
            {
                this._eqpCdEntp = value;
                RaisePropertyChange("EqpCdEntp");
            }
        }
        
        private EqpCdTypeViewModel _eqpCdType;
        [DisplayName("Type d'équipement")]
        public virtual EqpCdTypeViewModel EqpCdType
        {
            get
            {
                return this._eqpCdType;
            }
            set
            {
                this._eqpCdType = value;
                RaisePropertyChange("EqpCdType");
            }
        }
        
        private Int64 _idTrav;
        [DisplayName("Identifiant Travaux")]
        public Int64 IdTrav
        {
            get
            {
                return this._idTrav;
            }
            set
            {
                this._idTrav = value;
                RaisePropertyChange("IdTrav");
            }
        }
        
        private String _ouvrage;
        [DisplayName("N° Ouvrage")]
        public String Ouvrage
        {
            get
            {
                return this._ouvrage;
            }
            set
            {
                this._ouvrage = value;
                RaisePropertyChange("Ouvrage");
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
        private String _position;
        [DisplayName("Position")]
        public String Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
                RaisePropertyChange("Position");
            }
        }
        private Nullable<Int64> _absDeb;
        [DisplayName("du PR")]
        public Nullable<Int64> AbsDeb
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
        
        private Nullable<Int64> _absFin;
        [DisplayName("au PR")]
        public Nullable<Int64> AbsFin
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
        
        private Nullable<DateTime> _dateRcp;
        [DisplayName("Date Réception")]
        public Nullable<DateTime> DateRcp
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
        
        private Nullable<Int64> _cout;
        [DisplayName("Coût (€)")]
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
