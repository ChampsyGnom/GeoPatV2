using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsTreeResultViewModel : ViewModelBase
    {
        public DsTreeResult Model {get; set;}
        public DsTreeResultViewModel(DsTreeResult model)
        {
            this.DsTreeResultPaves = new  ObservableCollection<DsTreeResultPaveViewModel>();
            
            this.Model = model;
            this.Read();
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
    }
}
