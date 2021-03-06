using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhInspecteurViewModel : ViewModelBase<OhInspecteur>
    {
        public OhInspecteurViewModel(OhInspecteur model) : base(model)
        {
            this.OhInsps = new  ObservableCollection<OhInspViewModel>();
            
            this.OhVsts = new  ObservableCollection<OhVstViewModel>();
            
            this.OhInspTmps = new  ObservableCollection<OhInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.OhCdPresta=new OhCdPrestaViewModel( this.Model.OhCdPresta);
            this.Nom=this.Model.Nom;
            this.Fonc=this.Model.Fonc;
        }
        public override void Write()
        {
            this.Model.OhCdPresta=this. OhCdPresta.Model;
            this.Model.Nom=this.Nom;
            this.Model.Fonc=this.Fonc;
        }
        private OhCdPrestaViewModel _ohCdPresta;
        [DisplayName("Prestataire")]
        public virtual OhCdPrestaViewModel OhCdPresta
        {
            get
            {
                return this._ohCdPresta;
            }
            set
            {
                this._ohCdPresta = value;
                RaisePropertyChange("OhCdPresta");
            }
        }
        
        public virtual ObservableCollection<OhInspViewModel> OhInsps { get; set; }
        
        public virtual ObservableCollection<OhVstViewModel> OhVsts { get; set; }
        
        public virtual ObservableCollection<OhInspTmpViewModel> OhInspTmps { get; set; }
        
        private String _nom;
        [DisplayName("Nom inspecteur")]
        public String Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
                RaisePropertyChange("Nom");
            }
        }
        private String _fonc;
        [DisplayName("Fonction")]
        public String Fonc
        {
            get
            {
                return this._fonc;
            }
            set
            {
                this._fonc = value;
                RaisePropertyChange("Fonc");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Nom"] != null)
                {
                    errors.Add("Nom inspecteur : "+this["Nom"]);
                }
                if (this["Fonc"] != null)
                {
                    errors.Add("Fonction : "+this["Fonc"]);
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
                if (columnName.Equals("Nom"))
                {
                    if (String.IsNullOrEmpty(this.Nom))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Fonc"))
                {
                }
                return null;
            }
        }
    }
}
