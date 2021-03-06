using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsPaveVoieViewModel : ViewModelBase<ChsPaveVoie>
    {
        public ChsPaveVoieViewModel(ChsPaveVoie model) : base(model)
        {
            this.ChsClPaveVoies = new  ObservableCollection<ChsClPaveVoieViewModel>();
            
        }
        public override void Read()
        {
            this.ChsPave=new ChsPaveViewModel( this.Model.ChsPave);
            this.Voie=this.Model.Voie;
            this.Voiedeb=this.Model.Voiedeb;
            this.Voiefin=this.Model.Voiefin;
        }
        public override void Write()
        {
            this.Model.ChsPave=this. ChsPave.Model;
            this.Model.Voie=this.Voie;
            this.Model.Voiedeb=this.Voiedeb;
            this.Model.Voiefin=this.Voiefin;
        }
        private ChsPaveViewModel _chsPave;
        [DisplayName("Pavé MO")]
        public virtual ChsPaveViewModel ChsPave
        {
            get
            {
                return this._chsPave;
            }
            set
            {
                this._chsPave = value;
                RaisePropertyChange("ChsPave");
            }
        }
        
        public virtual ObservableCollection<ChsClPaveVoieViewModel> ChsClPaveVoies { get; set; }
        
        private String _voie;
        [DisplayName("Voie")]
        public String Voie
        {
            get
            {
                return this._voie;
            }
            set
            {
                this._voie = value;
                RaisePropertyChange("Voie");
            }
        }
        private Int64 _voiedeb;
        [DisplayName("Début Voie")]
        public Int64 Voiedeb
        {
            get
            {
                return this._voiedeb;
            }
            set
            {
                this._voiedeb = value;
                RaisePropertyChange("Voiedeb");
            }
        }
        
        private Int64 _voiefin;
        [DisplayName("Fin voie")]
        public Int64 Voiefin
        {
            get
            {
                return this._voiefin;
            }
            set
            {
                this._voiefin = value;
                RaisePropertyChange("Voiefin");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Voie"] != null)
                {
                    errors.Add("Voie : "+this["Voie"]);
                }
                if (this["Voiedeb"] != null)
                {
                    errors.Add("Début Voie : "+this["Voiedeb"]);
                }
                if (this["Voiefin"] != null)
                {
                    errors.Add("Fin voie : "+this["Voiefin"]);
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
                if (columnName.Equals("Voie"))
                {
                    if (String.IsNullOrEmpty(this.Voie))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Voiedeb"))
                {
                }
                if (columnName.Equals("Voiefin"))
                {
                }
                return null;
            }
        }
    }
}
