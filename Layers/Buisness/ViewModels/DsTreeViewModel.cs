using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsTreeViewModel : ViewModelBase<DsTree>
    {
        public DsTreeViewModel(DsTree model) : base(model)
        {
            this.DsNodes = new  ObservableCollection<DsNodeViewModel>();
            
            this.DsTreeResults = new  ObservableCollection<DsTreeResultViewModel>();
            
        }
        public override void Read()
        {
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<DsNodeViewModel> DsNodes { get; set; }
        
        public virtual ObservableCollection<DsTreeResultViewModel> DsTreeResults { get; set; }
        
        private Int64 _id;
        [DisplayName("TREE_DS__ID")]
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
        [DisplayName("TREE_DS__LIBELLE")]
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
