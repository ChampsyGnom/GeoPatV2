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
    }
}
