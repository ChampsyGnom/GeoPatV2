using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdHierarchieViewModel : ViewModelBase
    {
        public OaCdHierarchie Model {get; set;}
        public OaCdHierarchieViewModel(OaCdHierarchie model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Hierarchie=this.Model.Hierarchie;
        }
        public override void Write()
        {
            this.Model.Hierarchie=this.Hierarchie;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        private String _hierarchie;
        [DisplayName("Caractère stratégique")]
        public String Hierarchie
        {
            get
            {
                return this._hierarchie;
            }
            set
            {
                this._hierarchie = value;
                RaisePropertyChange("Hierarchie");
            }
        }
    }
}
