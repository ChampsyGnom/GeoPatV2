using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdFameqpViewModel : ViewModelBase<BsnCdFameqp>
    {
        public BsnCdFameqpViewModel(BsnCdFameqp model) : base(model)
        {
            this.BsnCdTypeqps = new  ObservableCollection<BsnCdTypeqpViewModel>();
            
        }
        public override void Read()
        {
            this.Fam=this.Model.Fam;
        }
        public override void Write()
        {
            this.Model.Fam=this.Fam;
        }
        public virtual ObservableCollection<BsnCdTypeqpViewModel> BsnCdTypeqps { get; set; }
        
        private String _fam;
        [DisplayName("Famille EQP")]
        public String Fam
        {
            get
            {
                return this._fam;
            }
            set
            {
                this._fam = value;
                RaisePropertyChange("Fam");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Fam"] != null)
                {
                    errors.Add("Famille EQP : "+this["Fam"]);
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
                if (columnName.Equals("Fam"))
                {
                    if (String.IsNullOrEmpty(this.Fam))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
