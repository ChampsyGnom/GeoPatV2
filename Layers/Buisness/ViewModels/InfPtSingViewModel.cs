using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfPtSingViewModel : ViewModelBase<InfPtSing>
    {
        public InfPtSingViewModel(InfPtSing model) : base(model)
        {
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Début : "+this["AbsDeb"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["NomUsage"] != null)
                {
                    errors.Add("Nom d'usage : "+this["NomUsage"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
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
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("NomUsage"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                return null;
            }
        }
    }
}
