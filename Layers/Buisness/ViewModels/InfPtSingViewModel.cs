using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfPtSingViewModel : ViewModelBase
    {
        public InfPtSing Model {get; set;}
        public InfPtSingViewModel(InfPtSing model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.InfCdPtSing=new InfCdPtSingViewModel( this.Model.InfCdPtSing);
            this.AbsDeb=this.Model.AbsDeb;
            this.Libelle=this.Model.Libelle;
            this.NomUsage=this.Model.NomUsage;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.InfCdPtSing=this. InfCdPtSing.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.Libelle=this.Libelle;
            this.Model.NomUsage=this.NomUsage;
            this.Model.Commentaire=this.Commentaire;
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
        
        private InfCdPtSingViewModel _infCdPtSing;
        [DisplayName("Type Point Singulier")]
        public virtual InfCdPtSingViewModel InfCdPtSing
        {
            get
            {
                return this._infCdPtSing;
            }
            set
            {
                this._infCdPtSing = value;
                RaisePropertyChange("InfCdPtSing");
            }
        }
        
        private Int64 _absDeb;
        [DisplayName("Début")]
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
        private String _nomUsage;
        [DisplayName("Nom d'usage")]
        public String NomUsage
        {
            get
            {
                return this._nomUsage;
            }
            set
            {
                this._nomUsage = value;
                RaisePropertyChange("NomUsage");
            }
        }
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
    }
}
