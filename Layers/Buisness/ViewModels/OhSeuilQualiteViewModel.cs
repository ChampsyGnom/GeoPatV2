using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhSeuilQualiteViewModel : ViewModelBase<OhSeuilQualite>
    {
        public OhSeuilQualiteViewModel(OhSeuilQualite model) : base(model)
        {
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IndiceUrgence"] != null)
                {
                    errors.Add("Indice urgence : "+this["IndiceUrgence"]);
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
                if (columnName.Equals("IndiceUrgence"))
                {
                    if (String.IsNullOrEmpty(this.IndiceUrgence))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
