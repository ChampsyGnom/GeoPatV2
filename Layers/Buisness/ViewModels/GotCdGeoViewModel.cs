using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdGeoViewModel : ViewModelBase<GotCdGeo>
    {
        public GotCdGeoViewModel(GotCdGeo model) : base(model)
        {
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotDscTemps = new  ObservableCollection<GotDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Geologie=this.Model.Geologie;
        }
        public override void Write()
        {
            this.Model.Geologie=this.Geologie;
        }
        public virtual ObservableCollection<GotDscViewModel> GotDscs { get; set; }
        
        public virtual ObservableCollection<GotDscTempViewModel> GotDscTemps { get; set; }
        
        private String _geologie;
        [DisplayName("Géologie")]
        public String Geologie
        {
            get
            {
                return this._geologie;
            }
            set
            {
                this._geologie = value;
                RaisePropertyChange("Geologie");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Geologie"] != null)
                {
                    errors.Add("Géologie : "+this["Geologie"]);
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
                if (columnName.Equals("Geologie"))
                {
                    if (String.IsNullOrEmpty(this.Geologie))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
