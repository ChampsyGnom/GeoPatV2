using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaInspecteurViewModel : ViewModelBase<OaInspecteur>
    {
        public OaInspecteurViewModel(OaInspecteur model) : base(model)
        {
            this.OaInsps = new  ObservableCollection<OaInspViewModel>();
            
            this.OaVsts = new  ObservableCollection<OaVstViewModel>();
            
            this.OaInspTmps = new  ObservableCollection<OaInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.OaCdPresta=new OaCdPrestaViewModel( this.Model.OaCdPresta);
            this.Nom=this.Model.Nom;
            this.Fonc=this.Model.Fonc;
        }
        public override void Write()
        {
            this.Model.OaCdPresta=this. OaCdPresta.Model;
            this.Model.Nom=this.Nom;
            this.Model.Fonc=this.Fonc;
        }
        private OaCdPrestaViewModel _oaCdPresta;
        [DisplayName("Prestataire")]
        public virtual OaCdPrestaViewModel OaCdPresta
        {
            get
            {
                return this._oaCdPresta;
            }
            set
            {
                this._oaCdPresta = value;
                RaisePropertyChange("OaCdPresta");
            }
        }
        
        public virtual ObservableCollection<OaInspViewModel> OaInsps { get; set; }
        
        public virtual ObservableCollection<OaVstViewModel> OaVsts { get; set; }
        
        public virtual ObservableCollection<OaInspTmpViewModel> OaInspTmps { get; set; }
        
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
