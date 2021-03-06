using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdMailleViewModel : ViewModelBase<EqpCdMaille>
    {
        public EqpCdMailleViewModel(EqpCdMaille model) : base(model)
        {
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
        }
        public override void Read()
        {
            this.Maille=this.Model.Maille;
        }
        public override void Write()
        {
            this.Model.Maille=this.Maille;
        }
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        private String _maille;
        [DisplayName("Maille")]
        public String Maille
        {
            get
            {
                return this._maille;
            }
            set
            {
                this._maille = value;
                RaisePropertyChange("Maille");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Maille"] != null)
                {
                    errors.Add("Maille : "+this["Maille"]);
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
                if (columnName.Equals("Maille"))
                {
                    if (String.IsNullOrEmpty(this.Maille))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
