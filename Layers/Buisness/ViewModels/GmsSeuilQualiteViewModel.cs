using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsSeuilQualiteViewModel : ViewModelBase
    {
        public GmsSeuilQualite Model {get; set;}
        public GmsSeuilQualiteViewModel(GmsSeuilQualite model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsCdQualite=new GmsCdQualiteViewModel( this.Model.GmsCdQualite);
            this.IndiceUrgence=this.Model.IndiceUrgence;
        }
        public override void Write()
        {
            this.Model.GmsCdQualite=this. GmsCdQualite.Model;
            this.Model.IndiceUrgence=this.IndiceUrgence;
        }
        private GmsCdQualiteViewModel _gmsCdQualite;
        [DisplayName("Libellé Qualité")]
        public virtual GmsCdQualiteViewModel GmsCdQualite
        {
            get
            {
                return this._gmsCdQualite;
            }
            set
            {
                this._gmsCdQualite = value;
                RaisePropertyChange("GmsCdQualite");
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
