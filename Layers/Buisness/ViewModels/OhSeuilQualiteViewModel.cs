using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhSeuilQualiteViewModel : ViewModelBase
    {
        public OhSeuilQualite Model {get; set;}
        public OhSeuilQualiteViewModel(OhSeuilQualite model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhCdQualite=new OhCdQualiteViewModel( this.Model.OhCdQualite);
            this.IndiceUrgence=this.Model.IndiceUrgence;
        }
        public override void Write()
        {
            this.Model.OhCdQualite=this. OhCdQualite.Model;
            this.Model.IndiceUrgence=this.IndiceUrgence;
        }
        private OhCdQualiteViewModel _ohCdQualite;
        [DisplayName("Code Qualité")]
        public virtual OhCdQualiteViewModel OhCdQualite
        {
            get
            {
                return this._ohCdQualite;
            }
            set
            {
                this._ohCdQualite = value;
                RaisePropertyChange("OhCdQualite");
            }
        }
        
        private String _indiceUrgence;
        [DisplayName("Indice urgence")]
        public String IndiceUrgence
        {
            get
            {
                return this._indiceUrgence;
            }
            set
            {
                this._indiceUrgence = value;
                RaisePropertyChange("IndiceUrgence");
            }
        }
    }
}
