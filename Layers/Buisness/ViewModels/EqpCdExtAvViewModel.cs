using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdExtAvViewModel : ViewModelBase<EqpCdExtAv>
    {
        public EqpCdExtAvViewModel(EqpCdExtAv model) : base(model)
        {
            this.EqpDscEss = new  ObservableCollection<EqpDscEsViewModel>();
            
        }
        public override void Read()
        {
            this.ExtFin=this.Model.ExtFin;
        }
        public override void Write()
        {
            this.Model.ExtFin=this.ExtFin;
        }
        public virtual ObservableCollection<EqpDscEsViewModel> EqpDscEss { get; set; }
        
        private String _extFin;
        [DisplayName("Extrémité fin")]
        public String ExtFin
        {
            get
            {
                return this._extFin;
            }
            set
            {
                this._extFin = value;
                RaisePropertyChange("ExtFin");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["ExtFin"] != null)
                {
                    errors.Add("Extrémité fin : "+this["ExtFin"]);
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
                if (columnName.Equals("ExtFin"))
                {
                    if (String.IsNullOrEmpty(this.ExtFin))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
