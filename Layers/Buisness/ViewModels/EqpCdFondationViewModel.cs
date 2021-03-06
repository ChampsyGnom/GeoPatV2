using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdFondationViewModel : ViewModelBase<EqpCdFondation>
    {
        public EqpCdFondationViewModel(EqpCdFondation model) : base(model)
        {
            this.EqpDscSvs = new  ObservableCollection<EqpDscSvViewModel>();
            
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
        }
        public override void Read()
        {
            this.Fondation=this.Model.Fondation;
        }
        public override void Write()
        {
            this.Model.Fondation=this.Fondation;
        }
        public virtual ObservableCollection<EqpDscSvViewModel> EqpDscSvs { get; set; }
        
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        private String _fondation;
        [DisplayName("Type fondation")]
        public String Fondation
        {
            get
            {
                return this._fondation;
            }
            set
            {
                this._fondation = value;
                RaisePropertyChange("Fondation");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Fondation"] != null)
                {
                    errors.Add("Type fondation : "+this["Fondation"]);
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
                if (columnName.Equals("Fondation"))
                {
                    if (String.IsNullOrEmpty(this.Fondation))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
