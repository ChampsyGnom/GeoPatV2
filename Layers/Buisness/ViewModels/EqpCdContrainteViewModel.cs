using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdContrainteViewModel : ViewModelBase<EqpCdContrainte>
    {
        public EqpCdContrainteViewModel(EqpCdContrainte model) : base(model)
        {
            this.EqpPrevisions = new  ObservableCollection<EqpPrevisionViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<EqpPrevisionViewModel> EqpPrevisions { get; set; }
        
        private String _type;
        [DisplayName("Contrainte exploit")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Type"] != null)
                {
                    errors.Add("Contrainte exploit : "+this["Type"]);
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
                if (columnName.Equals("Type"))
                {
                    if (String.IsNullOrEmpty(this.Type))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
