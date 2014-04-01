using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsInspecteurViewModel : ViewModelBase
    {
        public GmsInspecteur Model {get; set;}
        public GmsInspecteurViewModel(GmsInspecteur model)
        {
            this.GmsInsps = new  ObservableCollection<GmsInspViewModel>();
            
            this.GmsVsts = new  ObservableCollection<GmsVstViewModel>();
            
            this.GmsInspTmps = new  ObservableCollection<GmsInspTmpViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsCdPresta=new GmsCdPrestaViewModel( this.Model.GmsCdPresta);
            this.Nom=this.Model.Nom;
            this.Fonc=this.Model.Fonc;
        }
        public override void Write()
        {
            this.Model.GmsCdPresta=this. GmsCdPresta.Model;
            this.Model.Nom=this.Nom;
            this.Model.Fonc=this.Fonc;
        }
        private GmsCdPrestaViewModel _gmsCdPresta;
        [DisplayName("Prestataire")]
        public virtual GmsCdPrestaViewModel GmsCdPresta
        {
            get
            {
                return this._gmsCdPresta;
            }
            set
            {
                this._gmsCdPresta = value;
                RaisePropertyChange("GmsCdPresta");
            }
        }
        
        public virtual ObservableCollection<GmsInspViewModel> GmsInsps { get; set; }
        
        public virtual ObservableCollection<GmsVstViewModel> GmsVsts { get; set; }
        
        public virtual ObservableCollection<GmsInspTmpViewModel> GmsInspTmps { get; set; }
        
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
