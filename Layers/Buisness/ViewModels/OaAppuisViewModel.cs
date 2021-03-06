using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaAppuisViewModel : ViewModelBase<OaAppuis>
    {
        public OaAppuisViewModel(OaAppuis model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.OaCdFamAppui=new OaCdFamAppuiViewModel( this.Model.OaCdFamAppui);
            this.OaCdAppui=new OaCdAppuiViewModel( this.Model.OaCdAppui);
            this.OaCdAppAppui=new OaCdAppAppuiViewModel( this.Model.OaCdAppAppui);
            this.NbrAppareil=this.Model.NbrAppareil;
            this.DateMs=this.Model.DateMs;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.OaCdFamAppui=this. OaCdFamAppui.Model;
            this.Model.OaCdAppui=this. OaCdAppui.Model;
            this.Model.OaCdAppAppui=this. OaCdAppAppui.Model;
            this.Model.NbrAppareil=this.NbrAppareil;
            this.Model.DateMs=this.DateMs;
            this.Model.Commentaire=this.Commentaire;
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
        
        private OaCdFamAppuiViewModel _oaCdFamAppui;
        [DisplayName("Familles d'appuis")]
        public virtual OaCdFamAppuiViewModel OaCdFamAppui
        {
            get
            {
                return this._oaCdFamAppui;
            }
            set
            {
                this._oaCdFamAppui = value;
                RaisePropertyChange("OaCdFamAppui");
            }
        }
        
        private OaCdAppuiViewModel _oaCdAppui;
        [DisplayName("Types d'appuis")]
        public virtual OaCdAppuiViewModel OaCdAppui
        {
            get
            {
                return this._oaCdAppui;
            }
            set
            {
                this._oaCdAppui = value;
                RaisePropertyChange("OaCdAppui");
            }
        }
        
        private OaCdAppAppuiViewModel _oaCdAppAppui;
        [DisplayName("Types d'appareil d' appui")]
        public virtual OaCdAppAppuiViewModel OaCdAppAppui
        {
            get
            {
                return this._oaCdAppAppui;
            }
            set
            {
                this._oaCdAppAppui = value;
                RaisePropertyChange("OaCdAppAppui");
            }
        }
        
        private Nullable<Int64> _nbrAppareil;
        [DisplayName("Nbr app. appui")]
        public Nullable<Int64> NbrAppareil
        {
            get
            {
                return this._nbrAppareil;
            }
            set
            {
                this._nbrAppareil = value;
                RaisePropertyChange("NbrAppareil");
            }
        }
        
        private Nullable<DateTime> _dateMs;
        [DisplayName("Date MS app appui")]
        public Nullable<DateTime> DateMs
        {
            get
            {
                return this._dateMs;
            }
            set
            {
                this._dateMs = value;
                RaisePropertyChange("DateMs");
            }
        }
        
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["NbrAppareil"] != null)
                {
                    errors.Add("Nbr app. appui : "+this["NbrAppareil"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS app appui : "+this["DateMs"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
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
                if (columnName.Equals("NbrAppareil"))
                {
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                return null;
            }
        }
    }
}
