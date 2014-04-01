using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnSeuilQualiteViewModel : ViewModelBase<BsnSeuilQualite>
    {
        public BsnSeuilQualiteViewModel(BsnSeuilQualite model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnCdQualite=new BsnCdQualiteViewModel( this.Model.BsnCdQualite);
            this.IndiceUrgence=this.Model.IndiceUrgence;
        }
        public override void Write()
        {
            this.Model.BsnCdQualite=this. BsnCdQualite.Model;
            this.Model.IndiceUrgence=this.IndiceUrgence;
        }
        private BsnCdQualiteViewModel _bsnCdQualite;
        [DisplayName("Code Qualité")]
        public virtual BsnCdQualiteViewModel BsnCdQualite
        {
            get
            {
                return this._bsnCdQualite;
            }
            set
            {
                this._bsnCdQualite = value;
                RaisePropertyChange("BsnCdQualite");
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
