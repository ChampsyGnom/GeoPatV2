using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsNodeViewModel : ViewModelBase<DsNode>
    {
        public DsNodeViewModel(DsNode model) : base(model)
        {
            this.DsNodeParams = new  ObservableCollection<DsNodeParamViewModel>();
            
        }
        public override void Read()
        {
            this.DsTree=new DsTreeViewModel( this.Model.DsTree);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Type=this.Model.Type;
            this.ParentId=this.Model.ParentId;
            this.Technique=this.Model.Technique;
            this.Structure=this.Model.Structure;
            this.NbSi=this.Model.NbSi;
            this.IsForTrue=this.Model.IsForTrue;
        }
        public override void Write()
        {
            this.Model.DsTree=this. DsTree.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Type=this.Type;
            this.Model.ParentId=this.ParentId;
            this.Model.Technique=this.Technique;
            this.Model.Structure=this.Structure;
            this.Model.NbSi=this.NbSi;
            this.Model.IsForTrue=this.IsForTrue;
        }
        private DsTreeViewModel _dsTree;
        [DisplayName("TREE_DS")]
        public virtual DsTreeViewModel DsTree
        {
            get
            {
                return this._dsTree;
            }
            set
            {
                this._dsTree = value;
                RaisePropertyChange("DsTree");
            }
        }
        
        public virtual ObservableCollection<DsNodeParamViewModel> DsNodeParams { get; set; }
        
        private Int64 _id;
        [DisplayName("NODE_DS__ID")]
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
        
        private String _libelle;
        [DisplayName("NODE_DS__LIBELLE")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
        private String _type;
        [DisplayName("NODE_DS__TYPE")]
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
        private Int64 _parentId;
        [DisplayName("NODE_DS__PARENT_ID")]
        public Int64 ParentId
        {
            get
            {
                return this._parentId;
            }
            set
            {
                this._parentId = value;
                RaisePropertyChange("ParentId");
            }
        }
        
        private String _technique;
        [DisplayName("NODE_DS__TECHNIQUE")]
        public String Technique
        {
            get
            {
                return this._technique;
            }
            set
            {
                this._technique = value;
                RaisePropertyChange("Technique");
            }
        }
        private String _structure;
        [DisplayName("NODE_DS__STRUCTURE")]
        public String Structure
        {
            get
            {
                return this._structure;
            }
            set
            {
                this._structure = value;
                RaisePropertyChange("Structure");
            }
        }
        private Nullable<Int64> _nbSi;
        [DisplayName("NODE_DS__NB_SI")]
        public Nullable<Int64> NbSi
        {
            get
            {
                return this._nbSi;
            }
            set
            {
                this._nbSi = value;
                RaisePropertyChange("NbSi");
            }
        }
        
        private Int64 _isForTrue;
        [DisplayName("NODE_DS__IS_FOR_TRUE")]
        public Int64 IsForTrue
        {
            get
            {
                return this._isForTrue;
            }
            set
            {
                this._isForTrue = value;
                RaisePropertyChange("IsForTrue");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("NODE_DS__ID : "+this["Id"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("NODE_DS__LIBELLE : "+this["Libelle"]);
                }
                if (this["Type"] != null)
                {
                    errors.Add("NODE_DS__TYPE : "+this["Type"]);
                }
                if (this["ParentId"] != null)
                {
                    errors.Add("NODE_DS__PARENT_ID : "+this["ParentId"]);
                }
                if (this["Technique"] != null)
                {
                    errors.Add("NODE_DS__TECHNIQUE : "+this["Technique"]);
                }
                if (this["Structure"] != null)
                {
                    errors.Add("NODE_DS__STRUCTURE : "+this["Structure"]);
                }
                if (this["NbSi"] != null)
                {
                    errors.Add("NODE_DS__NB_SI : "+this["NbSi"]);
                }
                if (this["IsForTrue"] != null)
                {
                    errors.Add("NODE_DS__IS_FOR_TRUE : "+this["IsForTrue"]);
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
                if (columnName.Equals("Id"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("Type"))
                {
                    if (String.IsNullOrEmpty(this.Type))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("ParentId"))
                {
                }
                if (columnName.Equals("Technique"))
                {
                }
                if (columnName.Equals("Structure"))
                {
                }
                if (columnName.Equals("NbSi"))
                {
                }
                if (columnName.Equals("IsForTrue"))
                {
                }
                return null;
            }
        }
    }
}
