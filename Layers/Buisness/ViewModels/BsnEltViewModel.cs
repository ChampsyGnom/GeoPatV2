using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnEltViewModel : ViewModelBase<BsnElt>
    {
        public BsnEltViewModel(BsnElt model) : base(model)
        {
            this.BsnEltInsps = new  ObservableCollection<BsnEltInspViewModel>();
            
            this.BsnEltInspTmps = new  ObservableCollection<BsnEltInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.BsnSprt=new BsnSprtViewModel( this.Model.BsnSprt);
            this.IdElem=this.Model.IdElem;
            this.Libe=this.Model.Libe;
            this.Ordre=this.Model.Ordre;
            this.Aide=this.Model.Aide;
            this.Indice1=this.Model.Indice1;
            this.Indice2=this.Model.Indice2;
            this.Indice3=this.Model.Indice3;
        }
        public override void Write()
        {
            this.Model.BsnSprt=this. BsnSprt.Model;
            this.Model.IdElem=this.IdElem;
            this.Model.Libe=this.Libe;
            this.Model.Ordre=this.Ordre;
            this.Model.Aide=this.Aide;
            this.Model.Indice1=this.Indice1;
            this.Model.Indice2=this.Indice2;
            this.Model.Indice3=this.Indice3;
        }
        private BsnSprtViewModel _bsnSprt;
        [DisplayName("Sous Partie")]
        public virtual BsnSprtViewModel BsnSprt
        {
            get
            {
                return this._bsnSprt;
            }
            set
            {
                this._bsnSprt = value;
                RaisePropertyChange("BsnSprt");
            }
        }
        
        public virtual ObservableCollection<BsnEltInspViewModel> BsnEltInsps { get; set; }
        
        public virtual ObservableCollection<BsnEltInspTmpViewModel> BsnEltInspTmps { get; set; }
        
        private Int64 _idElem;
        [DisplayName("Identifiant Elément")]
        public Int64 IdElem
        {
            get
            {
                return this._idElem;
            }
            set
            {
                this._idElem = value;
                RaisePropertyChange("IdElem");
            }
        }
        
        private String _libe;
        [DisplayName("Elément")]
        public String Libe
        {
            get
            {
                return this._libe;
            }
            set
            {
                this._libe = value;
                RaisePropertyChange("Libe");
            }
        }
        private Int64 _ordre;
        [DisplayName("N° Ordre")]
        public Int64 Ordre
        {
            get
            {
                return this._ordre;
            }
            set
            {
                this._ordre = value;
                RaisePropertyChange("Ordre");
            }
        }
        
        private String _aide;
        [DisplayName("Aide à la saisie")]
        public String Aide
        {
            get
            {
                return this._aide;
            }
            set
            {
                this._aide = value;
                RaisePropertyChange("Aide");
            }
        }
        private String _indice1;
        [DisplayName("Indice1")]
        public String Indice1
        {
            get
            {
                return this._indice1;
            }
            set
            {
                this._indice1 = value;
                RaisePropertyChange("Indice1");
            }
        }
        private String _indice2;
        [DisplayName("Indice2")]
        public String Indice2
        {
            get
            {
                return this._indice2;
            }
            set
            {
                this._indice2 = value;
                RaisePropertyChange("Indice2");
            }
        }
        private String _indice3;
        [DisplayName("Indice3")]
        public String Indice3
        {
            get
            {
                return this._indice3;
            }
            set
            {
                this._indice3 = value;
                RaisePropertyChange("Indice3");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdElem"] != null)
                {
                    errors.Add("Identifiant Elément : "+this["IdElem"]);
                }
                if (this["Libe"] != null)
                {
                    errors.Add("Elément : "+this["Libe"]);
                }
                if (this["Ordre"] != null)
                {
                    errors.Add("N° Ordre : "+this["Ordre"]);
                }
                if (this["Aide"] != null)
                {
                    errors.Add("Aide à la saisie : "+this["Aide"]);
                }
                if (this["Indice1"] != null)
                {
                    errors.Add("Indice1 : "+this["Indice1"]);
                }
                if (this["Indice2"] != null)
                {
                    errors.Add("Indice2 : "+this["Indice2"]);
                }
                if (this["Indice3"] != null)
                {
                    errors.Add("Indice3 : "+this["Indice3"]);
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
                if (columnName.Equals("IdElem"))
                {
                }
                if (columnName.Equals("Libe"))
                {
                    if (String.IsNullOrEmpty(this.Libe))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Ordre"))
                {
                }
                if (columnName.Equals("Aide"))
                {
                }
                if (columnName.Equals("Indice1"))
                {
                }
                if (columnName.Equals("Indice2"))
                {
                }
                if (columnName.Equals("Indice3"))
                {
                }
                return null;
            }
        }
    }
}
