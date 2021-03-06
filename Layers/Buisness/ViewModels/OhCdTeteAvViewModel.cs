using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdTeteAvViewModel : ViewModelBase<OhCdTeteAv>
    {
        public OhCdTeteAvViewModel(OhCdTeteAv model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.TeteAv=this.Model.TeteAv;
        }
        public override void Write()
        {
            this.Model.TeteAv=this.TeteAv;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _teteAv;
        [DisplayName("Tête aval")]
        public String TeteAv
        {
            get
            {
                return this._teteAv;
            }
            set
            {
                this._teteAv = value;
                RaisePropertyChange("TeteAv");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["TeteAv"] != null)
                {
                    errors.Add("Tête aval : "+this["TeteAv"]);
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
                if (columnName.Equals("TeteAv"))
                {
                    if (String.IsNullOrEmpty(this.TeteAv))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
