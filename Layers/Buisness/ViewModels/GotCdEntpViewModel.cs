using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdEntpViewModel : ViewModelBase<GotCdEntp>
    {
        public GotCdEntpViewModel(GotCdEntp model) : base(model)
        {
            this.GotTravauxs = new  ObservableCollection<GotTravauxViewModel>();
            
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotDscTemps = new  ObservableCollection<GotDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Entreprise=this.Model.Entreprise;
        }
        public override void Write()
        {
            this.Model.Entreprise=this.Entreprise;
        }
        public virtual ObservableCollection<GotTravauxViewModel> GotTravauxs { get; set; }
        
        public virtual ObservableCollection<GotDscViewModel> GotDscs { get; set; }
        
        public virtual ObservableCollection<GotDscTempViewModel> GotDscTemps { get; set; }
        
        private String _entreprise;
        [DisplayName("Entreprise")]
        public String Entreprise
        {
            get
            {
                return this._entreprise;
            }
            set
            {
                this._entreprise = value;
                RaisePropertyChange("Entreprise");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Entreprise"] != null)
                {
                    errors.Add("Entreprise : "+this["Entreprise"]);
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
                if (columnName.Equals("Entreprise"))
                {
                    if (String.IsNullOrEmpty(this.Entreprise))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
