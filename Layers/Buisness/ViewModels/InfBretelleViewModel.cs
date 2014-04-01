using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfBretelleViewModel : ViewModelBase<InfBretelle>
    {
        public InfBretelleViewModel(InfBretelle model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.NumExploit=this.Model.NumExploit;
            this.NumBretelle=this.Model.NumBretelle;
            this.NomBretelle=this.Model.NomBretelle;
            this.Libelle=this.Model.Libelle;
            this.Type=this.Model.Type;
            this.Extremite=this.Model.Extremite;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.NumExploit=this.NumExploit;
            this.Model.NumBretelle=this.NumBretelle;
            this.Model.NomBretelle=this.NomBretelle;
            this.Model.Libelle=this.Libelle;
            this.Model.Type=this.Type;
            this.Model.Extremite=this.Extremite;
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
        
        private Int64 _absDeb;
        [DisplayName("Pr raccordement")]
        public Int64 AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
            }
        }
        
        private String _numExploit;
        [DisplayName("N° Exploitation")]
        public String NumExploit
        {
            get
            {
                return this._numExploit;
            }
            set
            {
                this._numExploit = value;
                RaisePropertyChange("NumExploit");
            }
        }
        private String _numBretelle;
        [DisplayName("N° Bretelle")]
        public String NumBretelle
        {
            get
            {
                return this._numBretelle;
            }
            set
            {
                this._numBretelle = value;
                RaisePropertyChange("NumBretelle");
            }
        }
        private String _nomBretelle;
        [DisplayName("Nom Bretelle")]
        public String NomBretelle
        {
            get
            {
                return this._nomBretelle;
            }
            set
            {
                this._nomBretelle = value;
                RaisePropertyChange("NomBretelle");
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
        private String _extremite;
        [DisplayName("Extremité")]
        public String Extremite
        {
            get
            {
                return this._extremite;
            }
            set
            {
                this._extremite = value;
                RaisePropertyChange("Extremite");
            }
        }
    }
}
