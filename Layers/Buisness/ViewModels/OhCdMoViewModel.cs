using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdMoViewModel : ViewModelBase<OhCdMo>
    {
        public OhCdMoViewModel(OhCdMo model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Mo=this.Model.Mo;
        }
        public override void Write()
        {
            this.Model.Mo=this.Mo;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _mo;
        [DisplayName("Maitre d'ouvrage")]
        public String Mo
        {
            get
            {
                return this._mo;
            }
            set
            {
                this._mo = value;
                RaisePropertyChange("Mo");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Mo"] != null)
                {
                    errors.Add("Maitre d'ouvrage : "+this["Mo"]);
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
                if (columnName.Equals("Mo"))
                {
                    if (String.IsNullOrEmpty(this.Mo))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
