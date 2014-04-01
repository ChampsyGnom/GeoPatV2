using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsSeuilUrgenceViewModel : ViewModelBase
    {
        public GmsSeuilUrgence Model {get; set;}
        public GmsSeuilUrgenceViewModel(GmsSeuilUrgence model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Ordre=this.Model.Ordre;
            this.NbrNote=this.Model.NbrNote;
            this.ValNote=this.Model.ValNote;
            this.Indice=this.Model.Indice;
        }
        public override void Write()
        {
            this.Model.Ordre=this.Ordre;
            this.Model.NbrNote=this.NbrNote;
            this.Model.ValNote=this.ValNote;
            this.Model.Indice=this.Indice;
        }
        private Int64 _ordre;
        [DisplayName("No Ordre")]
        public Int64 Ordre
        {
            get
            {
                return this._ordre;
            }
            set
            {
                this._ordre = value;
                RaisePropertyChange("Ordre");
            }
        }
        
        private Nullable<Int64> _nbrNote;
        [DisplayName(">= Nbre de note")]
        public Nullable<Int64> NbrNote
        {
            get
            {
                return this._nbrNote;
            }
            set
            {
                this._nbrNote = value;
                RaisePropertyChange("NbrNote");
            }
        }
        
        private Nullable<Int64> _valNote;
        [DisplayName("Valeur de note")]
        public Nullable<Int64> ValNote
        {
            get
            {
                return this._valNote;
            }
            set
            {
                this._valNote = value;
                RaisePropertyChange("ValNote");
            }
        }
        
        private Nullable<Int64> _indice;
        [DisplayName("Ind dégradation")]
        public Nullable<Int64> Indice
        {
            get
            {
                return this._indice;
            }
            set
            {
                this._indice = value;
                RaisePropertyChange("Indice");
            }
        }
        
    }
}
