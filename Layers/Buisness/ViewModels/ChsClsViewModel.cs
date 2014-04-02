using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsClsViewModel : ViewModelBase<ChsCls>
    {
        public ChsClsViewModel(ChsCls model) : base(model)
        {
            this.ChsClsDocs = new  ObservableCollection<ChsClsDocViewModel>();
            
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
        public virtual ObservableCollection<ChsClsDocViewModel> ChsClsDocs { get; set; }
        
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("Identifiant du classeur(cpt) : "+this["Id"]);
                }
                if (this["TableName"] != null)
                {
                    errors.Add("Table : "+this["TableName"]);
                }
                if (this["KeyValue"] != null)
                {
                    errors.Add("Enregistrement : "+this["KeyValue"]);
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
                if (columnName.Equals("TableName"))
                {
                }
                if (columnName.Equals("KeyValue"))
                {
                }
                return null;
            }
        }
    }
}
