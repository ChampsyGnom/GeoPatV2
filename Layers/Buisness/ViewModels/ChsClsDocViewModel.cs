using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsClsDocViewModel : ViewModelBase<ChsClsDoc>
    {
        public ChsClsDocViewModel(ChsClsDoc model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsCls=new ChsClsViewModel( this.Model.ChsCls);
            this.ChsDoc=new ChsDocViewModel( this.Model.ChsDoc);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.ChsCls=this. ChsCls.Model;
            this.Model.ChsDoc=this. ChsDoc.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private ChsClsViewModel _chsCls;
        [DisplayName("Classeurs")]
        public virtual ChsClsViewModel ChsCls
        {
            get
            {
                return this._chsCls;
            }
            set
            {
                this._chsCls = value;
                RaisePropertyChange("ChsCls");
            }
        }
        
        private ChsDocViewModel _chsDoc;
        [DisplayName("Documents")]
        public virtual ChsDocViewModel ChsDoc
        {
            get
            {
                return this._chsDoc;
            }
            set
            {
                this._chsDoc = value;
                RaisePropertyChange("ChsDoc");
            }
        }
        
        private Nullable<Boolean> _defaut;
        [DisplayName("Document par défaut")]
        public Nullable<Boolean> Defaut
        {
            get
            {
                return this._defaut;
            }
            set
            {
                this._defaut = value;
                RaisePropertyChange("Defaut");
            }
        }
        
        private String _dossier;
        [DisplayName("Dossier")]
        public String Dossier
        {
            get
            {
                return this._dossier;
            }
            set
            {
                this._dossier = value;
                RaisePropertyChange("Dossier");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Defaut"] != null)
                {
                    errors.Add("Document par défaut : "+this["Defaut"]);
                }
                if (this["Dossier"] != null)
                {
                    errors.Add("Dossier : "+this["Dossier"]);
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
                if (columnName.Equals("Defaut"))
                {
                }
                if (columnName.Equals("Dossier"))
                {
                }
                return null;
            }
        }
    }
}
