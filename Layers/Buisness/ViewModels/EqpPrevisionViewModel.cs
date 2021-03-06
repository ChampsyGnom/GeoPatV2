using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpPrevisionViewModel : ViewModelBase<EqpPrevision>
    {
        public EqpPrevisionViewModel(EqpPrevision model) : base(model)
        {
        }
        public override void Read()
        {
            this.EqpBpu=new EqpBpuViewModel( this.Model.EqpBpu);
            this.EqpCdType=new EqpCdTypeViewModel( this.Model.EqpCdType);
            this.EqpCdContrainte=new EqpCdContrainteViewModel( this.Model.EqpCdContrainte);
            this.IdPrev=this.Model.IdPrev;
            this.Ouvrage=this.Model.Ouvrage;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.Position=this.Model.Position;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.DateDebut=this.Model.DateDebut;
            this.Montant=this.Model.Montant;
            this.DateFin=this.Model.DateFin;
            this.Commentaire=this.Model.Commentaire;
            this.Realise=this.Model.Realise;
        }
        public override void Write()
        {
            this.Model.EqpBpu=this. EqpBpu.Model;
            this.Model.EqpCdType=this. EqpCdType.Model;
            this.Model.EqpCdContrainte=this. EqpCdContrainte.Model;
            this.Model.IdPrev=this.IdPrev;
            this.Model.Ouvrage=this.Ouvrage;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.Position=this.Position;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateDebut=this.DateDebut;
            this.Model.Montant=this.Montant;
            this.Model.DateFin=this.DateFin;
            this.Model.Commentaire=this.Commentaire;
            this.Model.Realise=this.Realise;
        }
        private EqpBpuViewModel _eqpBpu;
        [DisplayName("Bordereau Prix")]
        public virtual EqpBpuViewModel EqpBpu
        {
            get
            {
                return this._eqpBpu;
            }
            set
            {
                this._eqpBpu = value;
                RaisePropertyChange("EqpBpu");
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
        
        private EqpCdContrainteViewModel _eqpCdContrainte;
        [DisplayName("Contrainte exploitation")]
        public virtual EqpCdContrainteViewModel EqpCdContrainte
        {
            get
            {
                return this._eqpCdContrainte;
            }
            set
            {
                this._eqpCdContrainte = value;
                RaisePropertyChange("EqpCdContrainte");
            }
        }
        
        private Int64 _idPrev;
        [DisplayName("Identifiant Prévisions")]
        public Int64 IdPrev
        {
            get
            {
                return this._idPrev;
            }
            set
            {
                this._idPrev = value;
                RaisePropertyChange("IdPrev");
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
        
        private DateTime _dateDebut;
        [DisplayName("Date début")]
        public DateTime DateDebut
        {
            get
            {
                return this._dateDebut;
            }
            set
            {
                this._dateDebut = value;
                RaisePropertyChange("DateDebut");
            }
        }
        
        private Nullable<Int64> _montant;
        [DisplayName("Coûts (€)")]
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
        
        private Nullable<DateTime> _dateFin;
        [DisplayName("Date fin")]
        public Nullable<DateTime> DateFin
        {
            get
            {
                return this._dateFin;
            }
            set
            {
                this._dateFin = value;
                RaisePropertyChange("DateFin");
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
        private Nullable<Boolean> _realise;
        [DisplayName("Réalisé")]
        public Nullable<Boolean> Realise
        {
            get
            {
                return this._realise;
            }
            set
            {
                this._realise = value;
                RaisePropertyChange("Realise");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdPrev"] != null)
                {
                    errors.Add("Identifiant Prévisions : "+this["IdPrev"]);
                }
                if (this["Ouvrage"] != null)
                {
                    errors.Add("N° Ouvrage : "+this["Ouvrage"]);
                }
                if (this["Liaison"] != null)
                {
                    errors.Add("Liaison : "+this["Liaison"]);
                }
                if (this["Sens"] != null)
                {
                    errors.Add("Sens : "+this["Sens"]);
                }
                if (this["Position"] != null)
                {
                    errors.Add("Position : "+this["Position"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("du PR : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("au PR : "+this["AbsFin"]);
                }
                if (this["DateDebut"] != null)
                {
                    errors.Add("Date début : "+this["DateDebut"]);
                }
                if (this["Montant"] != null)
                {
                    errors.Add("Coûts (€) : "+this["Montant"]);
                }
                if (this["DateFin"] != null)
                {
                    errors.Add("Date fin : "+this["DateFin"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
                }
                if (this["Realise"] != null)
                {
                    errors.Add("Réalisé : "+this["Realise"]);
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
                if (columnName.Equals("IdPrev"))
                {
                }
                if (columnName.Equals("Ouvrage"))
                {
                }
                if (columnName.Equals("Liaison"))
                {
                }
                if (columnName.Equals("Sens"))
                {
                }
                if (columnName.Equals("Position"))
                {
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("DateDebut"))
                {
                }
                if (columnName.Equals("Montant"))
                {
                }
                if (columnName.Equals("DateFin"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                if (columnName.Equals("Realise"))
                {
                }
                return null;
            }
        }
    }
}
