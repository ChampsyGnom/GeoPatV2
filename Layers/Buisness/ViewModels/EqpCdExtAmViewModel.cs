using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdExtAmViewModel : ViewModelBase<EqpCdExtAm>
    {
        public EqpCdExtAmViewModel(EqpCdExtAm model) : base(model)
        {
            this.EqpDscEss = new  ObservableCollection<EqpDscEsViewModel>();
            
        }
        public override void Read()
        {
            this.ExtDeb=this.Model.ExtDeb;
        }
        public override void Write()
        {
            this.Model.ExtDeb=this.ExtDeb;
        }
        public virtual ObservableCollection<EqpDscEsViewModel> EqpDscEss { get; set; }
        
        private String _extDeb;
        [DisplayName("Extrémité début")]
        public String ExtDeb
        {
            get
            {
                return this._extDeb;
            }
            set
            {
                this._extDeb = value;
                RaisePropertyChange("ExtDeb");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["ExtDeb"] != null)
                {
                    errors.Add("Extrémité début : "+this["ExtDeb"]);
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
                if (columnName.Equals("ExtDeb"))
                {
                    if (String.IsNullOrEmpty(this.ExtDeb))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
