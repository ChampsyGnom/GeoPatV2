using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdEntpViewModel : ViewModelBase<EqpCdEntp>
    {
        public EqpCdEntpViewModel(EqpCdEntp model) : base(model)
        {
            this.EqpDscSvs = new  ObservableCollection<EqpDscSvViewModel>();
            
            this.EqpDscShs = new  ObservableCollection<EqpDscShViewModel>();
            
            this.EqpDscEss = new  ObservableCollection<EqpDscEsViewModel>();
            
            this.EqpDscPos = new  ObservableCollection<EqpDscPoViewModel>();
            
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
            this.EqpTravauxs = new  ObservableCollection<EqpTravauxViewModel>();
            
            this.EqpDscDvs = new  ObservableCollection<EqpDscDvViewModel>();
            
        }
        public override void Read()
        {
            this.Entreprise=this.Model.Entreprise;
        }
        public override void Write()
        {
            this.Model.Entreprise=this.Entreprise;
        }
        public virtual ObservableCollection<EqpDscSvViewModel> EqpDscSvs { get; set; }
        
        public virtual ObservableCollection<EqpDscShViewModel> EqpDscShs { get; set; }
        
        public virtual ObservableCollection<EqpDscEsViewModel> EqpDscEss { get; set; }
        
        public virtual ObservableCollection<EqpDscPoViewModel> EqpDscPos { get; set; }
        
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        public virtual ObservableCollection<EqpTravauxViewModel> EqpTravauxs { get; set; }
        
        public virtual ObservableCollection<EqpDscDvViewModel> EqpDscDvs { get; set; }
        
        private String _entreprise;
        [DisplayName("Entreprise")]
        public String Entreprise
        {
            get
            {
                return this._entreprise;
            }
            set
            {
                this._entreprise = value;
                RaisePropertyChange("Entreprise");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Entreprise"] != null)
                {
                    errors.Add("Entreprise : "+this["Entreprise"]);
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
                if (columnName.Equals("Entreprise"))
                {
                    if (String.IsNullOrEmpty(this.Entreprise))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
