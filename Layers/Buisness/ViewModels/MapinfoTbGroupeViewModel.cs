using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbGroupeViewModel : ViewModelBase
    {
        public MapinfoTbGroupe Model {get; set;}
        public MapinfoTbGroupeViewModel(MapinfoTbGroupe model)
        {
            this.MapinfoTbMaps = new  ObservableCollection<MapinfoTbMapViewModel>();
            
            this.MapinfoTbGroupeCfgs = new  ObservableCollection<MapinfoTbGroupeCfgViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.MapinfoTbTemplate=new MapinfoTbTemplateViewModel( this.Model.MapinfoTbTemplate);
            this.Groupe=this.Model.Groupe;
            this.Titre=this.Model.Titre;
            this.Rang=this.Model.Rang;
            this.Chemin=this.Model.Chemin;
            this.Boardvisible=this.Model.Boardvisible;
        }
        public override void Write()
        {
            this.Model.MapinfoTbTemplate=this. MapinfoTbTemplate.Model;
            this.Model.Groupe=this.Groupe;
            this.Model.Titre=this.Titre;
            this.Model.Rang=this.Rang;
            this.Model.Chemin=this.Chemin;
            this.Model.Boardvisible=this.Boardvisible;
        }
        private MapinfoTbTemplateViewModel _mapinfoTbTemplate;
        [DisplayName("Template")]
        public virtual MapinfoTbTemplateViewModel MapinfoTbTemplate
        {
            get
            {
                return this._mapinfoTbTemplate;
            }
            set
            {
                this._mapinfoTbTemplate = value;
                RaisePropertyChange("MapinfoTbTemplate");
            }
        }
        
        public virtual ObservableCollection<MapinfoTbMapViewModel> MapinfoTbMaps { get; set; }
        
        public virtual ObservableCollection<MapinfoTbGroupeCfgViewModel> MapinfoTbGroupeCfgs { get; set; }
        
        private String _groupe;
        [DisplayName("Groupe")]
        public String Groupe
        {
            get
            {
                return this._groupe;
            }
            set
            {
                this._groupe = value;
                RaisePropertyChange("Groupe");
            }
        }
        private String _titre;
        [DisplayName("Titre")]
        public String Titre
        {
            get
            {
                return this._titre;
            }
            set
            {
                this._titre = value;
                RaisePropertyChange("Titre");
            }
        }
        private Int64 _rang;
        [DisplayName("Rang")]
        public Int64 Rang
        {
            get
            {
                return this._rang;
            }
            set
            {
                this._rang = value;
                RaisePropertyChange("Rang");
            }
        }
        
        private String _chemin;
        [DisplayName("Chemin")]
        public String Chemin
        {
            get
            {
                return this._chemin;
            }
            set
            {
                this._chemin = value;
                RaisePropertyChange("Chemin");
            }
        }
        private Nullable<Int64> _boardvisible;
        [DisplayName("Afficher")]
        public Nullable<Int64> Boardvisible
        {
            get
            {
                return this._boardvisible;
            }
            set
            {
                this._boardvisible = value;
                RaisePropertyChange("Boardvisible");
            }
        }
        
    }
}
