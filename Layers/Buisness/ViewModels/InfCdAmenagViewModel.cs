using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdAmenagViewModel : ViewModelBase<InfCdAmenag>
    {
        public InfCdAmenagViewModel(InfCdAmenag model) : base(model)
        {
            this.InfAmenagements = new  ObservableCollection<InfAmenagementViewModel>();
            
        }
        public override void Read()
        {
            this.TypeAmenag=this.Model.TypeAmenag;
        }
        public override void Write()
        {
            this.Model.TypeAmenag=this.TypeAmenag;
        }
        public virtual ObservableCollection<InfAmenagementViewModel> InfAmenagements { get; set; }
        
        private String _typeAmenag;
        [DisplayName("Aménagement")]
        public String TypeAmenag
        {
            get
            {
                return this._typeAmenag;
            }
            set
            {
                this._typeAmenag = value;
                RaisePropertyChange("TypeAmenag");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["TypeAmenag"] != null)
                {
                    errors.Add("Aménagement : "+this["TypeAmenag"]);
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
                if (columnName.Equals("TypeAmenag"))
                {
                    if (String.IsNullOrEmpty(this.TypeAmenag))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
