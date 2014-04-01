using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdJointViewModel : ViewModelBase
    {
        public OaCdJoint Model {get; set;}
        public OaCdJointViewModel(OaCdJoint model)
        {
            this.OaJoints = new  ObservableCollection<OaJointViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<OaJointViewModel> OaJoints { get; set; }
        
        private String _type;
        [DisplayName("Joint")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
            }
        }
        private Nullable<Int64> _garantie;
        [DisplayName("Garantie")]
        public Nullable<Int64> Garantie
        {
            get
            {
                return this._garantie;
            }
            set
            {
                this._garantie = value;
                RaisePropertyChange("Garantie");
            }
        }
        
        private Nullable<Int64> _dvt;
        [DisplayName("Durée de vie (mois)")]
        public Nullable<Int64> Dvt
        {
            get
            {
                return this._dvt;
            }
            set
            {
                this._dvt = value;
                RaisePropertyChange("Dvt");
            }
        }
        
    }
}
