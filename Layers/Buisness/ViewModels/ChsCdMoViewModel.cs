using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdMoViewModel : ViewModelBase<ChsCdMo>
    {
        public ChsCdMoViewModel(ChsCdMo model) : base(model)
        {
            this.ChsPaves = new  ObservableCollection<ChsPaveViewModel>();
            
        }
        public override void Read()
        {
            this.Mo=this.Model.Mo;
        }
        public override void Write()
        {
            this.Model.Mo=this.Mo;
        }
        public virtual ObservableCollection<ChsPaveViewModel> ChsPaves { get; set; }
        
        private String _mo;
        [DisplayName("Maître d'oeuvre")]
        public String Mo
        {
            get
            {
                return this._mo;
            }
            set
            {
                this._mo = value;
                RaisePropertyChange("Mo");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Mo"] != null)
                {
                    errors.Add("Maître d'oeuvre : "+this["Mo"]);
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
                if (columnName.Equals("Mo"))
                {
                    if (String.IsNullOrEmpty(this.Mo))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
