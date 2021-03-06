using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnInspecteurViewModel : ViewModelBase<BsnInspecteur>
    {
        public BsnInspecteurViewModel(BsnInspecteur model) : base(model)
        {
            this.BsnInsps = new  ObservableCollection<BsnInspViewModel>();
            
            this.BsnVsts = new  ObservableCollection<BsnVstViewModel>();
            
            this.BsnInspTmps = new  ObservableCollection<BsnInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.BsnCdPresta=new BsnCdPrestaViewModel( this.Model.BsnCdPresta);
            this.Nom=this.Model.Nom;
            this.Fonc=this.Model.Fonc;
        }
        public override void Write()
        {
            this.Model.BsnCdPresta=this. BsnCdPresta.Model;
            this.Model.Nom=this.Nom;
            this.Model.Fonc=this.Fonc;
        }
        private BsnCdPrestaViewModel _bsnCdPresta;
        [DisplayName("Prestataire")]
        public virtual BsnCdPrestaViewModel BsnCdPresta
        {
            get
            {
                return this._bsnCdPresta;
            }
            set
            {
                this._bsnCdPresta = value;
                RaisePropertyChange("BsnCdPresta");
            }
        }
        
        public virtual ObservableCollection<BsnInspViewModel> BsnInsps { get; set; }
        
        public virtual ObservableCollection<BsnVstViewModel> BsnVsts { get; set; }
        
        public virtual ObservableCollection<BsnInspTmpViewModel> BsnInspTmps { get; set; }
        
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
