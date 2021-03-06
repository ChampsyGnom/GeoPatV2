using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdTypePvViewModel : ViewModelBase<GotCdTypePv>
    {
        public GotCdTypePvViewModel(GotCdTypePv model) : base(model)
        {
            this.GotCamps = new  ObservableCollection<GotCampViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
            this.Cycle=this.Model.Cycle;
            this.Cout=this.Model.Cout;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
            this.Model.Cycle=this.Cycle;
            this.Model.Cout=this.Cout;
        }
        public virtual ObservableCollection<GotCampViewModel> GotCamps { get; set; }
        
        private String _code;
        [DisplayName("Type de PV")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
            }
        }
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
        private Nullable<Int64> _cycle;
        [DisplayName("Cycle")]
        public Nullable<Int64> Cycle
        {
            get
            {
                return this._cycle;
            }
            set
            {
                this._cycle = value;
                RaisePropertyChange("Cycle");
            }
        }
        
        private Nullable<Int64> _cout;
        [DisplayName("Coût unitaire (€)")]
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Code"] != null)
                {
                    errors.Add("Type de PV : "+this["Code"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["Cycle"] != null)
                {
                    errors.Add("Cycle : "+this["Cycle"]);
                }
                if (this["Cout"] != null)
                {
                    errors.Add("Coût unitaire (€) : "+this["Cout"]);
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
                if (columnName.Equals("Code"))
                {
                    if (String.IsNullOrEmpty(this.Code))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("Cycle"))
                {
                }
                if (columnName.Equals("Cout"))
                {
                }
                return null;
            }
        }
    }
}
