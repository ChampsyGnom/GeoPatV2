using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsHistoNoteViewModel : ViewModelBase
    {
        public GmsHistoNote Model {get; set;}
        public GmsHistoNoteViewModel(GmsHistoNote model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsCdOrigin=new GmsCdOriginViewModel( this.Model.GmsCdOrigin);
            this.GmsDsc=new GmsDscViewModel( this.Model.GmsDsc);
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
            this.Model.GmsCdOrigin=this. GmsCdOrigin.Model;
            this.Model.GmsDsc=this. GmsDsc.Model;
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
        private GmsCdOriginViewModel _gmsCdOrigin;
        [DisplayName("Origine Note")]
        public virtual GmsCdOriginViewModel GmsCdOrigin
        {
            get
            {
                return this._gmsCdOrigin;
            }
            set
            {
                this._gmsCdOrigin = value;
                RaisePropertyChange("GmsCdOrigin");
            }
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
        [DisplayName("Note Ancrage")]
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
        [DisplayName("Note Structure")]
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
        [DisplayName("Note Fixation")]
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
        [DisplayName("Note Panneau")]
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
        [DisplayName("Note Accessibilité")]
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
        
    }
}
