using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdQualiteViewModel : ViewModelBase<GotCdQualite>
    {
        public GotCdQualiteViewModel(GotCdQualite model) : base(model)
        {
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotSeuilQualites = new  ObservableCollection<GotSeuilQualiteViewModel>();
            
        }
        public override void Read()
        {
            this.Qualite=this.Model.Qualite;
        }
        public override void Write()
        {
            this.Model.Qualite=this.Qualite;
        }
        public virtual ObservableCollection<GotDscViewModel> GotDscs { get; set; }
        
        public virtual ObservableCollection<GotSeuilQualiteViewModel> GotSeuilQualites { get; set; }
        
        private String _qualite;
        [DisplayName("Niveau qualité")]
        public String Qualite
        {
            get
            {
                return this._qualite;
            }
            set
            {
                this._qualite = value;
                RaisePropertyChange("Qualite");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Qualite"] != null)
                {
                    errors.Add("Niveau qualité : "+this["Qualite"]);
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
                if (columnName.Equals("Qualite"))
                {
                    if (String.IsNullOrEmpty(this.Qualite))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
