using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfDictionnaireViewModel : ViewModelBase
    {
        public InfDictionnaire Model {get; set;}
        public InfDictionnaireViewModel(InfDictionnaire model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Nom=this.Model.Nom;
            this.Description=this.Model.Description;
            this.Motscles=this.Model.Motscles;
            this.Definition=this.Model.Definition;
        }
        public override void Write()
        {
            this.Model.Nom=this.Nom;
            this.Model.Description=this.Description;
            this.Model.Motscles=this.Motscles;
            this.Model.Definition=this.Definition;
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
    }
}
