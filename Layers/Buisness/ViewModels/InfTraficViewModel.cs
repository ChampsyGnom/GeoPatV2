using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfTraficViewModel : ViewModelBase
    {
        public InfTrafic Model {get; set;}
        public InfTraficViewModel(InfTrafic model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.Annee=this.Model.Annee;
            this.Pl=this.Model.Pl;
            this.Tmja=this.Model.Tmja;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.Annee=this.Annee;
            this.Model.Pl=this.Pl;
            this.Model.Tmja=this.Tmja;
        }
        private InfChausseeViewModel _infChaussee;
        [DisplayName("Chaussée")]
        public virtual InfChausseeViewModel InfChaussee
        {
            get
            {
                return this._infChaussee;
            }
            set
            {
                this._infChaussee = value;
                RaisePropertyChange("InfChaussee");
            }
        }
        
        private Int64 _annee;
        [DisplayName("Année")]
        public Int64 Annee
        {
            get
            {
                return this._annee;
            }
            set
            {
                this._annee = value;
                RaisePropertyChange("Annee");
            }
        }
        
        private Nullable<Double> _pl;
        [DisplayName("PL (%)")]
        public Nullable<Double> Pl
        {
            get
            {
                return this._pl;
            }
            set
            {
                this._pl = value;
                RaisePropertyChange("Pl");
            }
        }
        
        private Nullable<Int64> _tmja;
        [DisplayName("TMJA")]
        public Nullable<Int64> Tmja
        {
            get
            {
                return this._tmja;
            }
            set
            {
                this._tmja = value;
                RaisePropertyChange("Tmja");
            }
        }
        
    }
}
