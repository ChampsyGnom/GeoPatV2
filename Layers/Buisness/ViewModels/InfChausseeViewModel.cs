using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfChausseeViewModel : ViewModelBase<InfChaussee>
    {
        public InfChausseeViewModel(InfChaussee model) : base(model)
        {
            this.InfPtSings = new  ObservableCollection<InfPtSingViewModel>();
            
            this.InfTrDecs = new  ObservableCollection<InfTrDecViewModel>();
            
            this.InfReperes = new  ObservableCollection<InfRepereViewModel>();
            
            this.InfPrevSges = new  ObservableCollection<InfPrevSgeViewModel>();
            
            this.InfPks = new  ObservableCollection<InfPkViewModel>();
            
            this.InfTpcs = new  ObservableCollection<InfTpcViewModel>();
            
            this.InfPrOlds = new  ObservableCollection<InfPrOldViewModel>();
            
            this.InfSensibles = new  ObservableCollection<InfSensibleViewModel>();
            
            this.InfClims = new  ObservableCollection<InfClimViewModel>();
            
            this.InfAmenagements = new  ObservableCollection<InfAmenagementViewModel>();
            
            this.InfAccidents = new  ObservableCollection<InfAccidentViewModel>();
            
            this.InfCorrespondances = new  ObservableCollection<InfCorrespondanceViewModel>();
            
            this.InfSecurites = new  ObservableCollection<InfSecuriteViewModel>();
            
            this.InfOccupations = new  ObservableCollection<InfOccupationViewModel>();
            
            this.InfEclairages = new  ObservableCollection<InfEclairageViewModel>();
            
            this.InfTaluss = new  ObservableCollection<InfTalusViewModel>();
            
            this.InfClVoies = new  ObservableCollection<InfClVoieViewModel>();
            
            this.InfTrafics = new  ObservableCollection<InfTraficViewModel>();
            
            this.InfPaveVoies = new  ObservableCollection<InfPaveVoieViewModel>();
            
            this.InfSectionTrafics = new  ObservableCollection<InfSectionTraficViewModel>();
            
            this.InfRepartitionTrafics = new  ObservableCollection<InfRepartitionTraficViewModel>();
            
            this.InfGares = new  ObservableCollection<InfGareViewModel>();
            
            this.InfAires = new  ObservableCollection<InfAireViewModel>();
            
            this.InfBifurcations = new  ObservableCollection<InfBifurcationViewModel>();
            
            this.InfBretelles = new  ObservableCollection<InfBretelleViewModel>();
            
        }
        public override void Read()
        {
            this.InfLiaison=new InfLiaisonViewModel( this.Model.InfLiaison);
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Libelle=this.Model.Libelle;
            this.Tenant=this.Model.Tenant;
            this.About=this.Model.About;
        }
        public override void Write()
        {
            this.Model.InfLiaison=this. InfLiaison.Model;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Libelle=this.Libelle;
            this.Model.Tenant=this.Tenant;
            this.Model.About=this.About;
        }
        private InfLiaisonViewModel _infLiaison;
        [DisplayName("Liaison")]
        public virtual InfLiaisonViewModel InfLiaison
        {
            get
            {
                return this._infLiaison;
            }
            set
            {
                this._infLiaison = value;
                RaisePropertyChange("InfLiaison");
            }
        }
        
        public virtual ObservableCollection<InfPtSingViewModel> InfPtSings { get; set; }
        
        public virtual ObservableCollection<InfTrDecViewModel> InfTrDecs { get; set; }
        
        public virtual ObservableCollection<InfRepereViewModel> InfReperes { get; set; }
        
        public virtual ObservableCollection<InfPrevSgeViewModel> InfPrevSges { get; set; }
        
        public virtual ObservableCollection<InfPkViewModel> InfPks { get; set; }
        
        public virtual ObservableCollection<InfTpcViewModel> InfTpcs { get; set; }
        
        public virtual ObservableCollection<InfPrOldViewModel> InfPrOlds { get; set; }
        
        public virtual ObservableCollection<InfSensibleViewModel> InfSensibles { get; set; }
        
        public virtual ObservableCollection<InfClimViewModel> InfClims { get; set; }
        
        public virtual ObservableCollection<InfAmenagementViewModel> InfAmenagements { get; set; }
        
        public virtual ObservableCollection<InfAccidentViewModel> InfAccidents { get; set; }
        
        public virtual ObservableCollection<InfCorrespondanceViewModel> InfCorrespondances { get; set; }
        
        public virtual ObservableCollection<InfSecuriteViewModel> InfSecurites { get; set; }
        
        public virtual ObservableCollection<InfOccupationViewModel> InfOccupations { get; set; }
        
        public virtual ObservableCollection<InfEclairageViewModel> InfEclairages { get; set; }
        
        public virtual ObservableCollection<InfTalusViewModel> InfTaluss { get; set; }
        
        public virtual ObservableCollection<InfClVoieViewModel> InfClVoies { get; set; }
        
        public virtual ObservableCollection<InfTraficViewModel> InfTrafics { get; set; }
        
        public virtual ObservableCollection<InfPaveVoieViewModel> InfPaveVoies { get; set; }
        
        public virtual ObservableCollection<InfSectionTraficViewModel> InfSectionTrafics { get; set; }
        
        public virtual ObservableCollection<InfRepartitionTraficViewModel> InfRepartitionTrafics { get; set; }
        
        public virtual ObservableCollection<InfGareViewModel> InfGares { get; set; }
        
        public virtual ObservableCollection<InfAireViewModel> InfAires { get; set; }
        
        public virtual ObservableCollection<InfBifurcationViewModel> InfBifurcations { get; set; }
        
        public virtual ObservableCollection<InfBretelleViewModel> InfBretelles { get; set; }
        
        private String _sens;
        [DisplayName("Sens")]
        public String Sens
        {
            get
            {
                return this._sens;
            }
            set
            {
                this._sens = value;
                RaisePropertyChange("Sens");
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
        
        private Int64 _absFin;
        [DisplayName("Fin")]
        public Int64 AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
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
        private String _tenant;
        [DisplayName("Tenant")]
        public String Tenant
        {
            get
            {
                return this._tenant;
            }
            set
            {
                this._tenant = value;
                RaisePropertyChange("Tenant");
            }
        }
        private String _about;
        [DisplayName("Aboutissant")]
        public String About
        {
            get
            {
                return this._about;
            }
            set
            {
                this._about = value;
                RaisePropertyChange("About");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Sens"] != null)
                {
                    errors.Add("Sens : "+this["Sens"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Début : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Fin : "+this["AbsFin"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["Tenant"] != null)
                {
                    errors.Add("Tenant : "+this["Tenant"]);
                }
                if (this["About"] != null)
                {
                    errors.Add("Aboutissant : "+this["About"]);
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
                if (columnName.Equals("Sens"))
                {
                    if (String.IsNullOrEmpty(this.Sens))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("Tenant"))
                {
                }
                if (columnName.Equals("About"))
                {
                }
                return null;
            }
        }
    }
}
