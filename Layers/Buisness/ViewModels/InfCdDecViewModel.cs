using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdDecViewModel : ViewModelBase
    {
        public InfCdDec Model {get; set;}
        public InfCdDecViewModel(InfCdDec model)
        {
            this.InfTrDecs = new  ObservableCollection<InfTrDecViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfFamDec=new InfFamDecViewModel( this.Model.InfFamDec);
            this.CdDec=this.Model.CdDec;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.InfFamDec=this. InfFamDec.Model;
            this.Model.CdDec=this.CdDec;
            this.Model.Libelle=this.Libelle;
        }
        private InfFamDecViewModel _infFamDec;
        [DisplayName("Famille découpage")]
        public virtual InfFamDecViewModel InfFamDec
        {
            get
            {
                return this._infFamDec;
            }
            set
            {
                this._infFamDec = value;
                RaisePropertyChange("InfFamDec");
            }
        }
        
        public virtual ObservableCollection<InfTrDecViewModel> InfTrDecs { get; set; }
        
        private String _cdDec;
        [DisplayName("Code decoupage")]
        public String CdDec
        {
            get
            {
                return this._cdDec;
            }
            set
            {
                this._cdDec = value;
                RaisePropertyChange("CdDec");
            }
        }
        private String _libelle;
        [DisplayName("Libellé")]
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
