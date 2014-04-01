using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfClsViewModel : ViewModelBase<InfCls>
    {
        public InfClsViewModel(InfCls model) : base(model)
        {
            this.InfClsDocs = new  ObservableCollection<InfClsDocViewModel>();
            
        }
        public override void Read()
        {
            this.Id=this.Model.Id;
            this.TableName=this.Model.TableName;
            this.KeyValue=this.Model.KeyValue;
        }
        public override void Write()
        {
            this.Model.Id=this.Id;
            this.Model.TableName=this.TableName;
            this.Model.KeyValue=this.KeyValue;
        }
        public virtual ObservableCollection<InfClsDocViewModel> InfClsDocs { get; set; }
        
        private Int64 _id;
        [DisplayName("Identifiant (cpt)")]
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
        
        private String _tableName;
        [DisplayName("Nom de la table")]
        public String TableName
        {
            get
            {
                return this._tableName;
            }
            set
            {
                this._tableName = value;
                RaisePropertyChange("TableName");
            }
        }
        private String _keyValue;
        [DisplayName("Enregistrement")]
        public String KeyValue
        {
            get
            {
                return this._keyValue;
            }
            set
            {
                this._keyValue = value;
                RaisePropertyChange("KeyValue");
            }
        }
    }
}
