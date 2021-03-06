using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsPanneauViewModel : ViewModelBase<GmsPanneau>
    {
        public GmsPanneauViewModel(GmsPanneau model) : base(model)
        {
        }
        public override void Read()
        {
            this.GmsCdPanneau=new GmsCdPanneauViewModel( this.Model.GmsCdPanneau);
            this.GmsCdPosPan=new GmsCdPosPanViewModel( this.Model.GmsCdPosPan);
            this.GmsCdEntp=new GmsCdEntpViewModel( this.Model.GmsCdEntp);
            this.GmsCdInterface=new GmsCdInterfaceViewModel( this.Model.GmsCdInterface);
            this.GmsCdFournisseur=new GmsCdFournisseurViewModel( this.Model.GmsCdFournisseur);
            this.DscGmsNumGms=this.Model.DscGmsNumGms;
            this.DateMs=this.Model.DateMs;
            this.Hauteur=this.Model.Hauteur;
            this.Largeur=this.Model.Largeur;
            this.Mention=this.Model.Mention;
            this.Reserve=this.Model.Reserve;
        }
        public override void Write()
        {
            this.Model.GmsCdPanneau=this. GmsCdPanneau.Model;
            this.Model.GmsCdPosPan=this. GmsCdPosPan.Model;
            this.Model.GmsCdEntp=this. GmsCdEntp.Model;
            this.Model.GmsCdInterface=this. GmsCdInterface.Model;
            this.Model.GmsCdFournisseur=this. GmsCdFournisseur.Model;
            this.Model.DscGmsNumGms=this.DscGmsNumGms;
            this.Model.DateMs=this.DateMs;
            this.Model.Hauteur=this.Hauteur;
            this.Model.Largeur=this.Largeur;
            this.Model.Mention=this.Mention;
            this.Model.Reserve=this.Reserve;
        }
        private GmsCdPanneauViewModel _gmsCdPanneau;
        [DisplayName("Type Panneau")]
        public virtual GmsCdPanneauViewModel GmsCdPanneau
        {
            get
            {
                return this._gmsCdPanneau;
            }
            set
            {
                this._gmsCdPanneau = value;
                RaisePropertyChange("GmsCdPanneau");
            }
        }
        
        private GmsCdPosPanViewModel _gmsCdPosPan;
        [DisplayName("Position Panneaux")]
        public virtual GmsCdPosPanViewModel GmsCdPosPan
        {
            get
            {
                return this._gmsCdPosPan;
            }
            set
            {
                this._gmsCdPosPan = value;
                RaisePropertyChange("GmsCdPosPan");
            }
        }
        
        private GmsCdEntpViewModel _gmsCdEntp;
        [DisplayName("Entreprises")]
        public virtual GmsCdEntpViewModel GmsCdEntp
        {
            get
            {
                return this._gmsCdEntp;
            }
            set
            {
                this._gmsCdEntp = value;
                RaisePropertyChange("GmsCdEntp");
            }
        }
        
        private GmsCdInterfaceViewModel _gmsCdInterface;
        [DisplayName("Type de Liaison GMS")]
        public virtual GmsCdInterfaceViewModel GmsCdInterface
        {
            get
            {
                return this._gmsCdInterface;
            }
            set
            {
                this._gmsCdInterface = value;
                RaisePropertyChange("GmsCdInterface");
            }
        }
        
        private GmsCdFournisseurViewModel _gmsCdFournisseur;
        [DisplayName("Nom Fournisseur")]
        public virtual GmsCdFournisseurViewModel GmsCdFournisseur
        {
            get
            {
                return this._gmsCdFournisseur;
            }
            set
            {
                this._gmsCdFournisseur = value;
                RaisePropertyChange("GmsCdFournisseur");
            }
        }
        
        private String _dscGmsNumGms;
        [DisplayName("No GMS")]
        public String DscGmsNumGms
        {
            get
            {
                return this._dscGmsNumGms;
            }
            set
            {
                this._dscGmsNumGms = value;
                RaisePropertyChange("DscGmsNumGms");
            }
        }
        private DateTime _dateMs;
        [DisplayName("Mise en service")]
        public DateTime DateMs
        {
            get
            {
                return this._dateMs;
            }
            set
            {
                this._dateMs = value;
                RaisePropertyChange("DateMs");
            }
        }
        
        private Nullable<Double> _hauteur;
        [DisplayName("Hauteur panneau (m)")]
        public Nullable<Double> Hauteur
        {
            get
            {
                return this._hauteur;
            }
            set
            {
                this._hauteur = value;
                RaisePropertyChange("Hauteur");
            }
        }
        
        private Nullable<Double> _largeur;
        [DisplayName("Largeur (m)")]
        public Nullable<Double> Largeur
        {
            get
            {
                return this._largeur;
            }
            set
            {
                this._largeur = value;
                RaisePropertyChange("Largeur");
            }
        }
        
        private String _mention;
        [DisplayName("Mention")]
        public String Mention
        {
            get
            {
                return this._mention;
            }
            set
            {
                this._mention = value;
                RaisePropertyChange("Mention");
            }
        }
        private Nullable<Int64> _reserve;
        [DisplayName("Réserve %")]
        public Nullable<Int64> Reserve
        {
            get
            {
                return this._reserve;
            }
            set
            {
                this._reserve = value;
                RaisePropertyChange("Reserve");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["DscGmsNumGms"] != null)
                {
                    errors.Add("No GMS : "+this["DscGmsNumGms"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Mise en service : "+this["DateMs"]);
                }
                if (this["Hauteur"] != null)
                {
                    errors.Add("Hauteur panneau (m) : "+this["Hauteur"]);
                }
                if (this["Largeur"] != null)
                {
                    errors.Add("Largeur (m) : "+this["Largeur"]);
                }
                if (this["Mention"] != null)
                {
                    errors.Add("Mention : "+this["Mention"]);
                }
                if (this["Reserve"] != null)
                {
                    errors.Add("Réserve % : "+this["Reserve"]);
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
                if (columnName.Equals("DscGmsNumGms"))
                {
                    if (String.IsNullOrEmpty(this.DscGmsNumGms))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("Hauteur"))
                {
                }
                if (columnName.Equals("Largeur"))
                {
                }
                if (columnName.Equals("Mention"))
                {
                }
                if (columnName.Equals("Reserve"))
                {
                }
                return null;
            }
        }
    }
}
