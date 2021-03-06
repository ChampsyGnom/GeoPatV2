using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaSeuilUrgenceViewModel : ViewModelBase<OaSeuilUrgence>
    {
        public OaSeuilUrgenceViewModel(OaSeuilUrgence model) : base(model)
        {
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
        [DisplayName(">= Nbre de Note")]
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
        [DisplayName("Valeur Note")]
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
        [DisplayName("Indice dégradation")]
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Ordre"] != null)
                {
                    errors.Add("No Ordre : "+this["Ordre"]);
                }
                if (this["NbrNote"] != null)
                {
                    errors.Add(">= Nbre de Note : "+this["NbrNote"]);
                }
                if (this["ValNote"] != null)
                {
                    errors.Add("Valeur Note : "+this["ValNote"]);
                }
                if (this["Indice"] != null)
                {
                    errors.Add("Indice dégradation : "+this["Indice"]);
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
                if (columnName.Equals("Ordre"))
                {
                }
                if (columnName.Equals("NbrNote"))
                {
                }
                if (columnName.Equals("ValNote"))
                {
                }
                if (columnName.Equals("Indice"))
                {
                }
                return null;
            }
        }
    }
}
