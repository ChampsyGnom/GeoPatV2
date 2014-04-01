using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdTypeSvViewModel : ViewModelBase
    {
        public EqpCdTypeSv Model {get; set;}
        public EqpCdTypeSvViewModel(EqpCdTypeSv model)
        {
            this.EqpCdStypeSvs = new  ObservableCollection<EqpCdStypeSvViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.EqpCdFamSv=new EqpCdFamSvViewModel( this.Model.EqpCdFamSv);
            this.Type=this.Model.Type;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.EqpCdFamSv=this. EqpCdFamSv.Model;
            this.Model.Type=this.Type;
            this.Model.Libelle=this.Libelle;
        }
        private EqpCdFamSvViewModel _eqpCdFamSv;
        [DisplayName("Famille Equipement")]
        public virtual EqpCdFamSvViewModel EqpCdFamSv
        {
            get
            {
                return this._eqpCdFamSv;
            }
            set
            {
                this._eqpCdFamSv = value;
                RaisePropertyChange("EqpCdFamSv");
            }
        }
        
        public virtual ObservableCollection<EqpCdStypeSvViewModel> EqpCdStypeSvs { get; set; }
        
        private String _type;
        [DisplayName("Type")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
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
