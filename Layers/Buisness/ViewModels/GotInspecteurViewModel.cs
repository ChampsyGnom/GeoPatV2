using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotInspecteurViewModel : ViewModelBase
    {
        public GotInspecteur Model {get; set;}
        public GotInspecteurViewModel(GotInspecteur model)
        {
            this.GotInsps = new  ObservableCollection<GotInspViewModel>();
            
            this.GotVsts = new  ObservableCollection<GotVstViewModel>();
            
            this.GotInspTmps = new  ObservableCollection<GotInspTmpViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotCdPresta=new GotCdPrestaViewModel( this.Model.GotCdPresta);
            this.Nom=this.Model.Nom;
            this.Fonc=this.Model.Fonc;
        }
        public override void Write()
        {
            this.Model.GotCdPresta=this. GotCdPresta.Model;
            this.Model.Nom=this.Nom;
            this.Model.Fonc=this.Fonc;
        }
        private GotCdPrestaViewModel _gotCdPresta;
        [DisplayName("Prestataire")]
        public virtual GotCdPrestaViewModel GotCdPresta
        {
            get
            {
                return this._gotCdPresta;
            }
            set
            {
                this._gotCdPresta = value;
                RaisePropertyChange("GotCdPresta");
            }
        }
        
        public virtual ObservableCollection<GotInspViewModel> GotInsps { get; set; }
        
        public virtual ObservableCollection<GotVstViewModel> GotVsts { get; set; }
        
        public virtual ObservableCollection<GotInspTmpViewModel> GotInspTmps { get; set; }
        
        private String _nom;
        [DisplayName("Nom inspecteur")]
        public String Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
                RaisePropertyChange("Nom");
            }
        }
        private String _fonc;
        [DisplayName("Fonction")]
        public String Fonc
        {
            get
            {
                return this._fonc;
            }
            set
            {
                this._fonc = value;
                RaisePropertyChange("Fonc");
            }
        }
    }
}
