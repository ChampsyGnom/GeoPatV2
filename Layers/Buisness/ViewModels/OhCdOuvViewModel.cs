using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdOuvViewModel : ViewModelBase<OhCdOuv>
    {
        public OhCdOuvViewModel(OhCdOuv model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Ouv=this.Model.Ouv;
        }
        public override void Write()
        {
            this.Model.Ouv=this.Ouv;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _ouv;
        [DisplayName("Profil")]
        public String Ouv
        {
            get
            {
                return this._ouv;
            }
            set
            {
                this._ouv = value;
                RaisePropertyChange("Ouv");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Ouv"] != null)
                {
                    errors.Add("Profil : "+this["Ouv"]);
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
                if (columnName.Equals("Ouv"))
                {
                    if (String.IsNullOrEmpty(this.Ouv))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
