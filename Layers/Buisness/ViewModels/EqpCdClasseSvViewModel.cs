using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdClasseSvViewModel : ViewModelBase<EqpCdClasseSv>
    {
        public EqpCdClasseSvViewModel(EqpCdClasseSv model) : base(model)
        {
            this.EqpPanneaus = new  ObservableCollection<EqpPanneauViewModel>();
            
        }
        public override void Read()
        {
            this.Classe=this.Model.Classe;
        }
        public override void Write()
        {
            this.Model.Classe=this.Classe;
        }
        public virtual ObservableCollection<EqpPanneauViewModel> EqpPanneaus { get; set; }
        
        private String _classe;
        [DisplayName("Classe du film")]
        public String Classe
        {
            get
            {
                return this._classe;
            }
            set
            {
                this._classe = value;
                RaisePropertyChange("Classe");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Classe"] != null)
                {
                    errors.Add("Classe du film : "+this["Classe"]);
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
                if (columnName.Equals("Classe"))
                {
                    if (String.IsNullOrEmpty(this.Classe))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
