using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaDictionnaireViewModel : ViewModelBase<OaDictionnaire>
    {
        public OaDictionnaireViewModel(OaDictionnaire model) : base(model)
        {
        }
        public override void Read()
        {
            this.Nom=this.Model.Nom;
            this.Description=this.Model.Description;
            this.Definition=this.Model.Definition;
            this.Motscles=this.Model.Motscles;
        }
        public override void Write()
        {
            this.Model.Nom=this.Nom;
            this.Model.Description=this.Description;
            this.Model.Definition=this.Definition;
            this.Model.Motscles=this.Motscles;
        }
        private String _nom;
        [DisplayName("Nom")]
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
        private String _description;
        [DisplayName("Description")]
        public String Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
                RaisePropertyChange("Description");
            }
        }
        private String _definition;
        [DisplayName("Définition")]
        public String Definition
        {
            get
            {
                return this._definition;
            }
            set
            {
                this._definition = value;
                RaisePropertyChange("Definition");
            }
        }
        private String _motscles;
        [DisplayName("Mots clés")]
        public String Motscles
        {
            get
            {
                return this._motscles;
            }
            set
            {
                this._motscles = value;
                RaisePropertyChange("Motscles");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Nom"] != null)
                {
                    errors.Add("Nom : "+this["Nom"]);
                }
                if (this["Description"] != null)
                {
                    errors.Add("Description : "+this["Description"]);
                }
                if (this["Definition"] != null)
                {
                    errors.Add("Définition : "+this["Definition"]);
                }
                if (this["Motscles"] != null)
                {
                    errors.Add("Mots clés : "+this["Motscles"]);
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
                if (columnName.Equals("Description"))
                {
                }
                if (columnName.Equals("Definition"))
                {
                }
                if (columnName.Equals("Motscles"))
                {
                }
                return null;
            }
        }
    }
}
