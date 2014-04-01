using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpClsViewModel : ViewModelBase
    {
        public EqpCls Model {get; set;}
        public EqpClsViewModel(EqpCls model)
        {
            this.EqpClsDocs = new  ObservableCollection<EqpClsDocViewModel>();
            
            this.Model = model;
            this.Read();
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
        public virtual ObservableCollection<EqpClsDocViewModel> EqpClsDocs { get; set; }
        
        private Int64 _id;
        [DisplayName("Identifiant du classeur(cpt)")]
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
        [DisplayName("Table")]
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
