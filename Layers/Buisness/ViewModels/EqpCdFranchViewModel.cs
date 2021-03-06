using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdFranchViewModel : ViewModelBase<EqpCdFranch>
    {
        public EqpCdFranchViewModel(EqpCdFranch model) : base(model)
        {
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
        }
        public override void Read()
        {
            this.AntiFranch=this.Model.AntiFranch;
        }
        public override void Write()
        {
            this.Model.AntiFranch=this.AntiFranch;
        }
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        private String _antiFranch;
        [DisplayName("Anti franchissement")]
        public String AntiFranch
        {
            get
            {
                return this._antiFranch;
            }
            set
            {
                this._antiFranch = value;
                RaisePropertyChange("AntiFranch");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["AntiFranch"] != null)
                {
                    errors.Add("Anti franchissement : "+this["AntiFranch"]);
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
                if (columnName.Equals("AntiFranch"))
                {
                    if (String.IsNullOrEmpty(this.AntiFranch))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
