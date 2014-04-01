using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsNodeParamViewModel : ViewModelBase
    {
        public DsNodeParam Model {get; set;}
        public DsNodeParamViewModel(DsNodeParam model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.DsNode=new DsNodeViewModel( this.Model.DsNode);
            this.Id=this.Model.Id;
            this.Agr=this.Model.Agr;
            this.Indic=this.Model.Indic;
            this.CompareValue=this.Model.CompareValue;
            this.CompareOp=this.Model.CompareOp;
        }
        public override void Write()
        {
            this.Model.DsNode=this. DsNode.Model;
            this.Model.Id=this.Id;
            this.Model.Agr=this.Agr;
            this.Model.Indic=this.Indic;
            this.Model.CompareValue=this.CompareValue;
            this.Model.CompareOp=this.CompareOp;
        }
        private DsNodeViewModel _dsNode;
        [DisplayName("NODE_DS")]
        public virtual DsNodeViewModel DsNode
        {
            get
            {
                return this._dsNode;
            }
            set
            {
                this._dsNode = value;
                RaisePropertyChange("DsNode");
            }
        }
        
        private Int64 _id;
        [DisplayName("NODE_PARAM_DS__ID")]
        public Int64 Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                RaisePropertyChange("Id");
            }
        }
        
        private String _agr;
        [DisplayName("NODE_PARAM_DS__AGR")]
        public String Agr
        {
            get
            {
                return this._agr;
            }
            set
            {
                this._agr = value;
                RaisePropertyChange("Agr");
            }
        }
        private String _indic;
        [DisplayName("NODE_PARAM_DS__INDIC")]
        public String Indic
        {
            get
            {
                return this._indic;
            }
            set
            {
                this._indic = value;
                RaisePropertyChange("Indic");
            }
        }
        private Nullable<Int64> _compareValue;
        [DisplayName("NODE_PARAM_DS__COMPARE_VALUE")]
        public Nullable<Int64> CompareValue
        {
            get
            {
                return this._compareValue;
            }
            set
            {
                this._compareValue = value;
                RaisePropertyChange("CompareValue");
            }
        }
        
        private String _compareOp;
        [DisplayName("NODE_PARAM_DS__COMPARE_OP")]
        public String CompareOp
        {
            get
            {
                return this._compareOp;
            }
            set
            {
                this._compareOp = value;
                RaisePropertyChange("CompareOp");
            }
        }
    }
}
