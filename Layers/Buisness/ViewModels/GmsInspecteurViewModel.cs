using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsInspecteurViewModel : ViewModelBase<GmsInspecteur>
    {
        public GmsInspecteurViewModel(GmsInspecteur model) : base(model)
        {
            this.GmsInsps = new  ObservableCollection<GmsInspViewModel>();
            
            this.GmsVsts = new  ObservableCollection<GmsVstViewModel>();
            
            this.GmsInspTmps = new  ObservableCollection<GmsInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.GmsCdPresta=new GmsCdPrestaViewModel( this.Model.GmsCdPresta);
            this.Nom=this.Model.Nom;
            this.Fonc=this.Model.Fonc;
        }
        public override void Write()
        {
            this.Model.GmsCdPresta=this. GmsCdPresta.Model;
            this.Model.Nom=this.Nom;
            this.Model.Fonc=this.Fonc;
        }
        private GmsCdPrestaViewModel _gmsCdPresta;
        [DisplayName("Prestataire")]
        public virtual GmsCdPrestaViewModel GmsCdPresta
        {
            get
            {
                return this._gmsCdPresta;
            }
            set
            {
                this._gmsCdPresta = value;
                RaisePropertyChange("GmsCdPresta");
            }
        }
        
        public virtual ObservableCollection<GmsInspViewModel> GmsInsps { get; set; }
        
        public virtual ObservableCollection<GmsVstViewModel> GmsVsts { get; set; }
        
        public virtual ObservableCollection<GmsInspTmpViewModel> GmsInspTmps { get; set; }
        
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
