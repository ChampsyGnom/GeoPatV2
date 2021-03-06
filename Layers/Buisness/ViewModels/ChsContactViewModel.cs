using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsContactViewModel : ViewModelBase<ChsContact>
    {
        public ChsContactViewModel(ChsContact model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsDoc=new ChsDocViewModel( this.Model.ChsDoc);
            this.Givenname=this.Model.Givenname;
            this.Sn=this.Model.Sn;
            this.Cn=this.Model.Cn;
            this.O=this.Model.O;
            this.Mail=this.Model.Mail;
            this.Telephonenumber=this.Model.Telephonenumber;
            this.Mobile=this.Model.Mobile;
            this.Facsimiletelephonenumber=this.Model.Facsimiletelephonenumber;
            this.Street=this.Model.Street;
            this.Mozillaworkstreet2=this.Model.Mozillaworkstreet2;
            this.L=this.Model.L;
            this.Postalcode=this.Model.Postalcode;
            this.Modifytimestamp=this.Model.Modifytimestamp;
        }
        public override void Write()
        {
            this.Model.ChsDoc=this. ChsDoc.Model;
            this.Model.Givenname=this.Givenname;
            this.Model.Sn=this.Sn;
            this.Model.Cn=this.Cn;
            this.Model.O=this.O;
            this.Model.Mail=this.Mail;
            this.Model.Telephonenumber=this.Telephonenumber;
            this.Model.Mobile=this.Mobile;
            this.Model.Facsimiletelephonenumber=this.Facsimiletelephonenumber;
            this.Model.Street=this.Street;
            this.Model.Mozillaworkstreet2=this.Mozillaworkstreet2;
            this.Model.L=this.L;
            this.Model.Postalcode=this.Postalcode;
            this.Model.Modifytimestamp=this.Modifytimestamp;
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
        
        private String _givenname;
        [DisplayName("Prénom")]
        public String Givenname
        {
            get
            {
                return this._givenname;
            }
            set
            {
                this._givenname = value;
                RaisePropertyChange("Givenname");
            }
        }
        private String _sn;
        [DisplayName("Nom")]
        public String Sn
        {
            get
            {
                return this._sn;
            }
            set
            {
                this._sn = value;
                RaisePropertyChange("Sn");
            }
        }
        private String _cn;
        [DisplayName("Nom complet")]
        public String Cn
        {
            get
            {
                return this._cn;
            }
            set
            {
                this._cn = value;
                RaisePropertyChange("Cn");
            }
        }
        private String _o;
        [DisplayName("Organisation")]
        public String O
        {
            get
            {
                return this._o;
            }
            set
            {
                this._o = value;
                RaisePropertyChange("O");
            }
        }
        private String _mail;
        [DisplayName("Email")]
        public String Mail
        {
            get
            {
                return this._mail;
            }
            set
            {
                this._mail = value;
                RaisePropertyChange("Mail");
            }
        }
        private String _telephonenumber;
        [DisplayName("Téléphone fixe")]
        public String Telephonenumber
        {
            get
            {
                return this._telephonenumber;
            }
            set
            {
                this._telephonenumber = value;
                RaisePropertyChange("Telephonenumber");
            }
        }
        private String _mobile;
        [DisplayName("Téléphone mobile")]
        public String Mobile
        {
            get
            {
                return this._mobile;
            }
            set
            {
                this._mobile = value;
                RaisePropertyChange("Mobile");
            }
        }
        private String _facsimiletelephonenumber;
        [DisplayName("Fax")]
        public String Facsimiletelephonenumber
        {
            get
            {
                return this._facsimiletelephonenumber;
            }
            set
            {
                this._facsimiletelephonenumber = value;
                RaisePropertyChange("Facsimiletelephonenumber");
            }
        }
        private String _street;
        [DisplayName("Adresse")]
        public String Street
        {
            get
            {
                return this._street;
            }
            set
            {
                this._street = value;
                RaisePropertyChange("Street");
            }
        }
        private String _mozillaworkstreet2;
        [DisplayName("Adresse complémentaire")]
        public String Mozillaworkstreet2
        {
            get
            {
                return this._mozillaworkstreet2;
            }
            set
            {
                this._mozillaworkstreet2 = value;
                RaisePropertyChange("Mozillaworkstreet2");
            }
        }
        private String _l;
        [DisplayName("Ville")]
        public String L
        {
            get
            {
                return this._l;
            }
            set
            {
                this._l = value;
                RaisePropertyChange("L");
            }
        }
        private String _postalcode;
        [DisplayName("Code Postal")]
        public String Postalcode
        {
            get
            {
                return this._postalcode;
            }
            set
            {
                this._postalcode = value;
                RaisePropertyChange("Postalcode");
            }
        }
        private Nullable<DateTime> _modifytimestamp;
        [DisplayName("Date MAJ")]
        public Nullable<DateTime> Modifytimestamp
        {
            get
            {
                return this._modifytimestamp;
            }
            set
            {
                this._modifytimestamp = value;
                RaisePropertyChange("Modifytimestamp");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Givenname"] != null)
                {
                    errors.Add("Prénom : "+this["Givenname"]);
                }
                if (this["Sn"] != null)
                {
                    errors.Add("Nom : "+this["Sn"]);
                }
                if (this["Cn"] != null)
                {
                    errors.Add("Nom complet : "+this["Cn"]);
                }
                if (this["O"] != null)
                {
                    errors.Add("Organisation : "+this["O"]);
                }
                if (this["Mail"] != null)
                {
                    errors.Add("Email : "+this["Mail"]);
                }
                if (this["Telephonenumber"] != null)
                {
                    errors.Add("Téléphone fixe : "+this["Telephonenumber"]);
                }
                if (this["Mobile"] != null)
                {
                    errors.Add("Téléphone mobile : "+this["Mobile"]);
                }
                if (this["Facsimiletelephonenumber"] != null)
                {
                    errors.Add("Fax : "+this["Facsimiletelephonenumber"]);
                }
                if (this["Street"] != null)
                {
                    errors.Add("Adresse : "+this["Street"]);
                }
                if (this["Mozillaworkstreet2"] != null)
                {
                    errors.Add("Adresse complémentaire : "+this["Mozillaworkstreet2"]);
                }
                if (this["L"] != null)
                {
                    errors.Add("Ville : "+this["L"]);
                }
                if (this["Postalcode"] != null)
                {
                    errors.Add("Code Postal : "+this["Postalcode"]);
                }
                if (this["Modifytimestamp"] != null)
                {
                    errors.Add("Date MAJ : "+this["Modifytimestamp"]);
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
                if (columnName.Equals("Givenname"))
                {
                }
                if (columnName.Equals("Sn"))
                {
                }
                if (columnName.Equals("Cn"))
                {
                }
                if (columnName.Equals("O"))
                {
                }
                if (columnName.Equals("Mail"))
                {
                }
                if (columnName.Equals("Telephonenumber"))
                {
                }
                if (columnName.Equals("Mobile"))
                {
                }
                if (columnName.Equals("Facsimiletelephonenumber"))
                {
                }
                if (columnName.Equals("Street"))
                {
                }
                if (columnName.Equals("Mozillaworkstreet2"))
                {
                }
                if (columnName.Equals("L"))
                {
                }
                if (columnName.Equals("Postalcode"))
                {
                }
                if (columnName.Equals("Modifytimestamp"))
                {
                }
                return null;
            }
        }
    }
}
