using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdQualiteViewModel : ViewModelBase<OaCdQualite>
    {
        public OaCdQualiteViewModel(OaCdQualite model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
        }
        public override void Read()
        {
            this.OaCdIqoa=new OaCdIqoaViewModel( this.Model.OaCdIqoa);
            this.Qualite=this.Model.Qualite;
        }
        public override void Write()
        {
            this.Model.OaCdIqoa=this. OaCdIqoa.Model;
            this.Model.Qualite=this.Qualite;
        }
        private OaCdIqoaViewModel _oaCdIqoa;
        [DisplayName("Code IQOA")]
        public virtual OaCdIqoaViewModel OaCdIqoa
        {
            get
            {
                return this._oaCdIqoa;
            }
            set
            {
                this._oaCdIqoa = value;
                RaisePropertyChange("OaCdIqoa");
            }
        }
        
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
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
