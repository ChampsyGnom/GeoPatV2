using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdGammeSvViewModel : ViewModelBase<EqpCdGammeSv>
    {
        public EqpCdGammeSvViewModel(EqpCdGammeSv model) : base(model)
        {
            this.EqpPanneaus = new  ObservableCollection<EqpPanneauViewModel>();
            
        }
        public override void Read()
        {
            this.Gamme=this.Model.Gamme;
            this.Dimension=this.Model.Dimension;
        }
        public override void Write()
        {
            this.Model.Gamme=this.Gamme;
            this.Model.Dimension=this.Dimension;
        }
        public virtual ObservableCollection<EqpPanneauViewModel> EqpPanneaus { get; set; }
        
        private String _gamme;
        [DisplayName("Gamme")]
        public String Gamme
        {
            get
            {
                return this._gamme;
            }
            set
            {
                this._gamme = value;
                RaisePropertyChange("Gamme");
            }
        }
        private Nullable<Int64> _dimension;
        [DisplayName("Dimension (mm)")]
        public Nullable<Int64> Dimension
        {
            get
            {
                return this._dimension;
            }
            set
            {
                this._dimension = value;
                RaisePropertyChange("Dimension");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Gamme"] != null)
                {
                    errors.Add("Gamme : "+this["Gamme"]);
                }
                if (this["Dimension"] != null)
                {
                    errors.Add("Dimension (mm) : "+this["Dimension"]);
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
                if (columnName.Equals("Gamme"))
                {
                    if (String.IsNullOrEmpty(this.Gamme))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Dimension"))
                {
                }
                return null;
            }
        }
    }
}
