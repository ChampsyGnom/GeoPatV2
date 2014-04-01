using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdDocViewModel : ViewModelBase
    {
        public EqpCdDoc Model {get; set;}
        public EqpCdDocViewModel(EqpCdDoc model)
        {
            this.EqpDocs = new  ObservableCollection<EqpDocViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
            this.Path=this.Model.Path;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
            this.Model.Path=this.Path;
        }
        public virtual ObservableCollection<EqpDocViewModel> EqpDocs { get; set; }
        
        private String _code;
        [DisplayName("Code")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
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
        private String _path;
        [DisplayName("Répertoire")]
        public String Path
        {
            get
            {
                return this._path;
            }
            set
            {
                this._path = value;
                RaisePropertyChange("Path");
            }
        }
    }
}
