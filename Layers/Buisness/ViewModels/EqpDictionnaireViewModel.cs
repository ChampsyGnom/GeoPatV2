using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpDictionnaireViewModel : ViewModelBase
    {
        public EqpDictionnaire Model {get; set;}
        public EqpDictionnaireViewModel(EqpDictionnaire model)
        {
            this.Model = model;
            this.Read();
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
    }
}
