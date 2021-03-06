using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaHistoNoteViewModel : ViewModelBase<OaHistoNote>
    {
        public OaHistoNoteViewModel(OaHistoNote model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.OaCdOrigin=new OaCdOriginViewModel( this.Model.OaCdOrigin);
            this.DateNote=this.Model.DateNote;
            this.NoteIqoa=this.Model.NoteIqoa;
            this.Note1=this.Model.Note1;
            this.Note2=this.Model.Note2;
            this.Note3=this.Model.Note3;
            this.Urgence=this.Model.Urgence;
            this.Securite=this.Model.Securite;
            this.Prioritaire=this.Model.Prioritaire;
        }
        public override void Write()
        {
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.OaCdOrigin=this. OaCdOrigin.Model;
            this.Model.DateNote=this.DateNote;
            this.Model.NoteIqoa=this.NoteIqoa;
            this.Model.Note1=this.Note1;
            this.Model.Note2=this.Note2;
            this.Model.Note3=this.Note3;
            this.Model.Urgence=this.Urgence;
            this.Model.Securite=this.Securite;
            this.Model.Prioritaire=this.Prioritaire;
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
        
        private OaCdOriginViewModel _oaCdOrigin;
        [DisplayName("Origine Note IQOA")]
        public virtual OaCdOriginViewModel OaCdOrigin
        {
            get
            {
                return this._oaCdOrigin;
            }
            set
            {
                this._oaCdOrigin = value;
                RaisePropertyChange("OaCdOrigin");
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
        
        private String _noteIqoa;
        [DisplayName("Note IQOA")]
        public String NoteIqoa
        {
            get
            {
                return this._noteIqoa;
            }
            set
            {
                this._noteIqoa = value;
                RaisePropertyChange("NoteIqoa");
            }
        }
        private Nullable<Int64> _note1;
        [DisplayName("Note Appuis")]
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
        [DisplayName("Note Tablier")]
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
        [DisplayName("Note Equipement")]
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
        
        private Boolean _prioritaire;
        [DisplayName("Urgence Traitement")]
        public Boolean Prioritaire
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
                if (this["NoteIqoa"] != null)
                {
                    errors.Add("Note IQOA : "+this["NoteIqoa"]);
                }
                if (this["Note1"] != null)
                {
                    errors.Add("Note Appuis : "+this["Note1"]);
                }
                if (this["Note2"] != null)
                {
                    errors.Add("Note Tablier : "+this["Note2"]);
                }
                if (this["Note3"] != null)
                {
                    errors.Add("Note Equipement : "+this["Note3"]);
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
                    errors.Add("Urgence Traitement : "+this["Prioritaire"]);
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
                if (columnName.Equals("NoteIqoa"))
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
