using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdPositViewModel : ViewModelBase<ChsCdPosit>
    {
        public ChsCdPositViewModel(ChsCdPosit model) : base(model)
        {
            this.ChsEvts = new  ObservableCollection<ChsEvtViewModel>();
            
        }
        public override void Read()
        {
            this.Posit=this.Model.Posit;
        }
        public override void Write()
        {
            this.Model.Posit=this.Posit;
        }
        public virtual ObservableCollection<ChsEvtViewModel> ChsEvts { get; set; }
        
        private String _posit;
        [DisplayName("Position")]
        public String Posit
        {
            get
            {
                return this._posit;
            }
            set
            {
                this._posit = value;
                RaisePropertyChange("Posit");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Posit"] != null)
                {
                    errors.Add("Position : "+this["Posit"]);
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
                if (columnName.Equals("Posit"))
                {
                    if (String.IsNullOrEmpty(this.Posit))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
