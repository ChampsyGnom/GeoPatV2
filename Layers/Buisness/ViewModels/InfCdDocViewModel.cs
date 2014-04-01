using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdDocViewModel : ViewModelBase
    {
        public InfCdDoc Model {get; set;}
        public InfCdDocViewModel(InfCdDoc model)
        {
            this.InfDocs = new  ObservableCollection<InfDocViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Path=this.Model.Path;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Path=this.Path;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<InfDocViewModel> InfDocs { get; set; }
        
        private String _code;
        [DisplayName("Code document")]
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
    }
}
