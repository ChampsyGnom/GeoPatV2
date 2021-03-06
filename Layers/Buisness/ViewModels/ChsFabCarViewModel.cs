using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsFabCarViewModel : ViewModelBase<ChsFabCar>
    {
        public ChsFabCarViewModel(ChsFabCar model) : base(model)
        {
            this.ChsMatPaves = new  ObservableCollection<ChsMatPaveViewModel>();
            
        }
        public override void Read()
        {
            this.ChsCdOrig=new ChsCdOrigViewModel( this.Model.ChsCdOrig);
            this.Nom=this.Model.Nom;
        }
        public override void Write()
        {
            this.Model.ChsCdOrig=this. ChsCdOrig.Model;
            this.Model.Nom=this.Nom;
        }
        private ChsCdOrigViewModel _chsCdOrig;
        [DisplayName("Type d'origine")]
        public virtual ChsCdOrigViewModel ChsCdOrig
        {
            get
            {
                return this._chsCdOrig;
            }
            set
            {
                this._chsCdOrig = value;
                RaisePropertyChange("ChsCdOrig");
            }
        }
        
        public virtual ObservableCollection<ChsMatPaveViewModel> ChsMatPaves { get; set; }
        
        private String _nom;
        [DisplayName("Fabricant/carrières")]
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Nom"] != null)
                {
                    errors.Add("Fabricant/carrières : "+this["Nom"]);
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
                return null;
            }
        }
    }
}
