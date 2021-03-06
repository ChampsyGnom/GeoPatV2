using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotSeuilQualiteViewModel : ViewModelBase<GotSeuilQualite>
    {
        public GotSeuilQualiteViewModel(GotSeuilQualite model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotCdQualite=new GotCdQualiteViewModel( this.Model.GotCdQualite);
            this.IndiceUrgence=this.Model.IndiceUrgence;
        }
        public override void Write()
        {
            this.Model.GotCdQualite=this. GotCdQualite.Model;
            this.Model.IndiceUrgence=this.IndiceUrgence;
        }
        private GotCdQualiteViewModel _gotCdQualite;
        [DisplayName("Libellé Qualité")]
        public virtual GotCdQualiteViewModel GotCdQualite
        {
            get
            {
                return this._gotCdQualite;
            }
            set
            {
                this._gotCdQualite = value;
                RaisePropertyChange("GotCdQualite");
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
