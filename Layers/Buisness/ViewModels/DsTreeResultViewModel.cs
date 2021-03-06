using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsTreeResultViewModel : ViewModelBase<DsTreeResult>
    {
        public DsTreeResultViewModel(DsTreeResult model) : base(model)
        {
            this.DsTreeResultPaves = new  ObservableCollection<DsTreeResultPaveViewModel>();
            
        }
        public override void Read()
        {
            this.DsTree=new DsTreeViewModel( this.Model.DsTree);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.DsTree=this. DsTree.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
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
        
        public virtual ObservableCollection<DsTreeResultPaveViewModel> DsTreeResultPaves { get; set; }
        
        private Int64 _id;
        [DisplayName("TREE_RESULT_DS__ID")]
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
        [DisplayName("TREE_RESULT_DS__LIBELLE")]
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("TREE_RESULT_DS__ID : "+this["Id"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("TREE_RESULT_DS__LIBELLE : "+this["Libelle"]);
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
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
