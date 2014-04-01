using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsDetailCampViewModel : ViewModelBase
    {
        public ChsDetailCamp Model {get; set;}
        public ChsDetailCampViewModel(ChsDetailCamp model)
        {
            this.ChsMesures = new  ObservableCollection<ChsMesureViewModel>();
            
            this.ChsAgreges = new  ObservableCollection<ChsAgregeViewModel>();
            
            this.ChsZhs = new  ObservableCollection<ChsZhViewModel>();
            
            this.ChsClCamps = new  ObservableCollection<ChsClCampViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ChsCdIndic=new ChsCdIndicViewModel( this.Model.ChsCdIndic);
            this.ChsCamp=new ChsCampViewModel( this.Model.ChsCamp);
        }
        public override void Write()
        {
            this.Model.ChsCdIndic=this. ChsCdIndic.Model;
            this.Model.ChsCamp=this. ChsCamp.Model;
        }
        private ChsCdIndicViewModel _chsCdIndic;
        [DisplayName("Indicateurs")]
        public virtual ChsCdIndicViewModel ChsCdIndic
        {
            get
            {
                return this._chsCdIndic;
            }
            set
            {
                this._chsCdIndic = value;
                RaisePropertyChange("ChsCdIndic");
            }
        }
        
        private ChsCampViewModel _chsCamp;
        [DisplayName("Campagnes de mesures")]
        public virtual ChsCampViewModel ChsCamp
        {
            get
            {
                return this._chsCamp;
            }
            set
            {
                this._chsCamp = value;
                RaisePropertyChange("ChsCamp");
            }
        }
        
        public virtual ObservableCollection<ChsMesureViewModel> ChsMesures { get; set; }
        
        public virtual ObservableCollection<ChsAgregeViewModel> ChsAgreges { get; set; }
        
        public virtual ObservableCollection<ChsZhViewModel> ChsZhs { get; set; }
        
        public virtual ObservableCollection<ChsClCampViewModel> ChsClCamps { get; set; }
        
    }
}
