using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhHistoNoteViewModel : ViewModelBase<OhHistoNote>
    {
        public OhHistoNoteViewModel(OhHistoNote model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhDsc=new OhDscViewModel( this.Model.OhDsc);
            this.OhCdOrigin=new OhCdOriginViewModel( this.Model.OhCdOrigin);
            this.DateNote=this.Model.DateNote;
            this.Note1=this.Model.Note1;
            this.Note2=this.Model.Note2;
            this.Note3=this.Model.Note3;
            this.Note4=this.Model.Note4;
            this.Note5=this.Model.Note5;
            this.Urgence=this.Model.Urgence;
            this.Securite=this.Model.Securite;
            this.Prioritaire=this.Model.Prioritaire;
        }
        public override void Write()
        {
            this.Model.OhDsc=this. OhDsc.Model;
            this.Model.OhCdOrigin=this. OhCdOrigin.Model;
            this.Model.DateNote=this.DateNote;
            this.Model.Note1=this.Note1;
            this.Model.Note2=this.Note2;
            this.Model.Note3=this.Note3;
            this.Model.Note4=this.Note4;
            this.Model.Note5=this.Note5;
            this.Model.Urgence=this.Urgence;
            this.Model.Securite=this.Securite;
            this.Model.Prioritaire=this.Prioritaire;
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
        
        private OhCdOriginViewModel _ohCdOrigin;
        [DisplayName("Origine Note")]
        public virtual OhCdOriginViewModel OhCdOrigin
        {
            get
            {
                return this._ohCdOrigin;
            }
            set
            {
                this._ohCdOrigin = value;
                RaisePropertyChange("OhCdOrigin");
            }
        }
        
        private DateTime _dateNote;
        [DisplayName("Date Note")]
        public DateTime DateNote
        {
            get
            {
                return this._dateNote;
            }
            set
            {
                this._dateNote = value;
                RaisePropertyChange("DateNote");
            }
        }
        
        private Nullable<Int64> _note1;
        [DisplayName("Note Abords Amont")]
        public Nullable<Int64> Note1
        {
            get
            {
                return this._note1;
            }
            set
            {
                this._note1 = value;
                RaisePropertyChange("Note1");
            }
        }
        
        private Nullable<Int64> _note2;
        [DisplayName("Note Protection Amont")]
        public Nullable<Int64> Note2
        {
            get
            {
                return this._note2;
            }
            set
            {
                this._note2 = value;
                RaisePropertyChange("Note2");
            }
        }
        
        private Nullable<Int64> _note3;
        [DisplayName("Note Conduit")]
        public Nullable<Int64> Note3
        {
            get
            {
                return this._note3;
            }
            set
            {
                this._note3 = value;
                RaisePropertyChange("Note3");
            }
        }
        
        private Nullable<Int64> _note4;
        [DisplayName("Note Protection Aval")]
        public Nullable<Int64> Note4
        {
            get
            {
                return this._note4;
            }
            set
            {
                this._note4 = value;
                RaisePropertyChange("Note4");
            }
        }
        
        private Nullable<Int64> _note5;
        [DisplayName("Note Abords Aval")]
        public Nullable<Int64> Note5
        {
            get
            {
                return this._note5;
            }
            set
            {
                this._note5 = value;
                RaisePropertyChange("Note5");
            }
        }
        
        private String _urgence;
        [DisplayName("Niveau Urgence")]
        public String Urgence
        {
            get
            {
                return this._urgence;
            }
            set
            {
                this._urgence = value;
                RaisePropertyChange("Urgence");
            }
        }
        private Nullable<Boolean> _securite;
        [DisplayName("Problème de sécurité")]
        public Nullable<Boolean> Securite
        {
            get
            {
                return this._securite;
            }
            set
            {
                this._securite = value;
                RaisePropertyChange("Securite");
            }
        }
        
        private Nullable<Boolean> _prioritaire;
        [DisplayName("Urgence traitement")]
        public Nullable<Boolean> Prioritaire
        {
            get
            {
                return this._prioritaire;
            }
            set
            {
                this._prioritaire = value;
                RaisePropertyChange("Prioritaire");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["DateNote"] != null)
                {
                    errors.Add("Date Note : "+this["DateNote"]);
                }
                if (this["Note1"] != null)
                {
                    errors.Add("Note Abords Amont : "+this["Note1"]);
                }
                if (this["Note2"] != null)
                {
                    errors.Add("Note Protection Amont : "+this["Note2"]);
                }
                if (this["Note3"] != null)
                {
                    errors.Add("Note Conduit : "+this["Note3"]);
                }
                if (this["Note4"] != null)
                {
                    errors.Add("Note Protection Aval : "+this["Note4"]);
                }
                if (this["Note5"] != null)
                {
                    errors.Add("Note Abords Aval : "+this["Note5"]);
                }
                if (this["Urgence"] != null)
                {
                    errors.Add("Niveau Urgence : "+this["Urgence"]);
                }
                if (this["Securite"] != null)
                {
                    errors.Add("Problème de sécurité : "+this["Securite"]);
                }
                if (this["Prioritaire"] != null)
                {
                    errors.Add("Urgence traitement : "+this["Prioritaire"]);
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
                if (columnName.Equals("DateNote"))
                {
                }
                if (columnName.Equals("Note1"))
                {
                }
                if (columnName.Equals("Note2"))
                {
                }
                if (columnName.Equals("Note3"))
                {
                }
                if (columnName.Equals("Note4"))
                {
                }
                if (columnName.Equals("Note5"))
                {
                }
                if (columnName.Equals("Urgence"))
                {
                }
                if (columnName.Equals("Securite"))
                {
                }
                if (columnName.Equals("Prioritaire"))
                {
                }
                return null;
            }
        }
    }
}
