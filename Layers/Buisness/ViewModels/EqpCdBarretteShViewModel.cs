using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdBarretteShViewModel : ViewModelBase<EqpCdBarretteSh>
    {
        public EqpCdBarretteShViewModel(EqpCdBarretteSh model) : base(model)
        {
            this.EqpDscShs = new  ObservableCollection<EqpDscShViewModel>();
            
        }
        public override void Read()
        {
            this.Barette=this.Model.Barette;
        }
        public override void Write()
        {
            this.Model.Barette=this.Barette;
        }
        public virtual ObservableCollection<EqpDscShViewModel> EqpDscShs { get; set; }
        
        private String _barette;
        [DisplayName("Barette")]
        public String Barette
        {
            get
            {
                return this._barette;
            }
            set
            {
                this._barette = value;
                RaisePropertyChange("Barette");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Barette"] != null)
                {
                    errors.Add("Barette : "+this["Barette"]);
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
                if (columnName.Equals("Barette"))
                {
                    if (String.IsNullOrEmpty(this.Barette))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
