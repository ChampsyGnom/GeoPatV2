using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdPenteViewModel : ViewModelBase<GotCdPente>
    {
        public GotCdPenteViewModel(GotCdPente model) : base(model)
        {
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotDscTemps = new  ObservableCollection<GotDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Pente=this.Model.Pente;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Pente=this.Pente;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<GotDscViewModel> GotDscs { get; set; }
        
        public virtual ObservableCollection<GotDscTempViewModel> GotDscTemps { get; set; }
        
        private String _pente;
        [DisplayName("Pente")]
        public String Pente
        {
            get
            {
                return this._pente;
            }
            set
            {
                this._pente = value;
                RaisePropertyChange("Pente");
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Pente"] != null)
                {
                    errors.Add("Pente : "+this["Pente"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
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
                if (columnName.Equals("Pente"))
                {
                    if (String.IsNullOrEmpty(this.Pente))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                }
                return null;
            }
        }
    }
}
