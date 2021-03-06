using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdEvtViewModel : ViewModelBase<OhCdEvt>
    {
        public OhCdEvtViewModel(OhCdEvt model) : base(model)
        {
            this.OhEvts = new  ObservableCollection<OhEvtViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
            this.Impact=this.Model.Impact;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
            this.Model.Impact=this.Impact;
        }
        public virtual ObservableCollection<OhEvtViewModel> OhEvts { get; set; }
        
        private String _type;
        [DisplayName("Type événement")]
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
        private Nullable<Boolean> _impact;
        [DisplayName("Impact métier")]
        public Nullable<Boolean> Impact
        {
            get
            {
                return this._impact;
            }
            set
            {
                this._impact = value;
                RaisePropertyChange("Impact");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Type"] != null)
                {
                    errors.Add("Type événement : "+this["Type"]);
                }
                if (this["Impact"] != null)
                {
                    errors.Add("Impact métier : "+this["Impact"]);
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
                if (columnName.Equals("Impact"))
                {
                }
                return null;
            }
        }
    }
}
