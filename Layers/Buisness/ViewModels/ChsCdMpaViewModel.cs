using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdMpaViewModel : ViewModelBase<ChsCdMpa>
    {
        public ChsCdMpaViewModel(ChsCdMpa model) : base(model)
        {
            this.ChsPlateformes = new  ObservableCollection<ChsPlateformeViewModel>();
            
        }
        public override void Read()
        {
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.Valeur=this.Valeur;
        }
        public virtual ObservableCollection<ChsPlateformeViewModel> ChsPlateformes { get; set; }
        
        private Int64 _valeur;
        [DisplayName("Valeur (MPa)")]
        public Int64 Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Valeur"] != null)
                {
                    errors.Add("Valeur (MPa) : "+this["Valeur"]);
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
                if (columnName.Equals("Valeur"))
                {
                }
                return null;
            }
        }
    }
}
