using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsMatViewModel : ViewModelBase<ChsMat>
    {
        public ChsMatViewModel(ChsMat model) : base(model)
        {
            this.ChsMatPaves = new  ObservableCollection<ChsMatPaveViewModel>();
            
        }
        public override void Read()
        {
            this.ChsCdMat=new ChsCdMatViewModel( this.Model.ChsCdMat);
            this.Mat=this.Model.Mat;
        }
        public override void Write()
        {
            this.Model.ChsCdMat=this. ChsCdMat.Model;
            this.Model.Mat=this.Mat;
        }
        private ChsCdMatViewModel _chsCdMat;
        [DisplayName("Nature de matériaux")]
        public virtual ChsCdMatViewModel ChsCdMat
        {
            get
            {
                return this._chsCdMat;
            }
            set
            {
                this._chsCdMat = value;
                RaisePropertyChange("ChsCdMat");
            }
        }
        
        public virtual ObservableCollection<ChsMatPaveViewModel> ChsMatPaves { get; set; }
        
        private String _mat;
        [DisplayName("Matériaux")]
        public String Mat
        {
            get
            {
                return this._mat;
            }
            set
            {
                this._mat = value;
                RaisePropertyChange("Mat");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Mat"] != null)
                {
                    errors.Add("Matériaux : "+this["Mat"]);
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
                if (columnName.Equals("Mat"))
                {
                    if (String.IsNullOrEmpty(this.Mat))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
