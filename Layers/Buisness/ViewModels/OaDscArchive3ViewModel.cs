using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaDscArchive3ViewModel : ViewModelBase<OaDscArchive3>
    {
        public OaDscArchive3ViewModel(OaDscArchive3 model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaArchive3=new OaArchive3ViewModel( this.Model.OaArchive3);
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.Note3x=this.Model.Note3x;
            this.Ecarte=this.Model.Ecarte;
        }
        public override void Write()
        {
            this.Model.OaArchive3=this. OaArchive3.Model;
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.Note3x=this.Note3x;
            this.Model.Ecarte=this.Ecarte;
        }
        private OaArchive3ViewModel _oaArchive3;
        [DisplayName("Archive Etat")]
        public virtual OaArchive3ViewModel OaArchive3
        {
            get
            {
                return this._oaArchive3;
            }
            set
            {
                this._oaArchive3 = value;
                RaisePropertyChange("OaArchive3");
            }
        }
        
        private OaDscViewModel _oaDsc;
        [DisplayName("Ouvrages d'Art")]
        public virtual OaDscViewModel OaDsc
        {
            get
            {
                return this._oaDsc;
            }
            set
            {
                this._oaDsc = value;
                RaisePropertyChange("OaDsc");
            }
        }
        
        private String _note3x;
        [DisplayName("Note 3x")]
        public String Note3x
        {
            get
            {
                return this._note3x;
            }
            set
            {
                this._note3x = value;
                RaisePropertyChange("Note3x");
            }
        }
        private Nullable<Boolean> _ecarte;
        [DisplayName("Ouvrage écarté")]
        public Nullable<Boolean> Ecarte
        {
            get
            {
                return this._ecarte;
            }
            set
            {
                this._ecarte = value;
                RaisePropertyChange("Ecarte");
            }
        }
        
    }
}
