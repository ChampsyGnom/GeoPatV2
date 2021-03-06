using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdMoViewModel : ViewModelBase<OaCdMo>
    {
        public OaCdMoViewModel(OaCdMo model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.MaitreOuvr=this.Model.MaitreOuvr;
        }
        public override void Write()
        {
            this.Model.MaitreOuvr=this.MaitreOuvr;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _maitreOuvr;
        [DisplayName("Maitre d'ouvrage")]
        public String MaitreOuvr
        {
            get
            {
                return this._maitreOuvr;
            }
            set
            {
                this._maitreOuvr = value;
                RaisePropertyChange("MaitreOuvr");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["MaitreOuvr"] != null)
                {
                    errors.Add("Maitre d'ouvrage : "+this["MaitreOuvr"]);
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
                if (columnName.Equals("MaitreOuvr"))
                {
                    if (String.IsNullOrEmpty(this.MaitreOuvr))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
