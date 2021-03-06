using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdIqoaViewModel : ViewModelBase<OaCdIqoa>
    {
        public OaCdIqoaViewModel(OaCdIqoa model) : base(model)
        {
            this.OaInsps = new  ObservableCollection<OaInspViewModel>();
            
            this.OaCdQualites = new  ObservableCollection<OaCdQualiteViewModel>();
            
            this.OaInspTmps = new  ObservableCollection<OaInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.NoteIqoa=this.Model.NoteIqoa;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.NoteIqoa=this.NoteIqoa;
            this.Model.Commentaire=this.Commentaire;
        }
        public virtual ObservableCollection<OaInspViewModel> OaInsps { get; set; }
        
        public virtual ObservableCollection<OaCdQualiteViewModel> OaCdQualites { get; set; }
        
        public virtual ObservableCollection<OaInspTmpViewModel> OaInspTmps { get; set; }
        
        private String _noteIqoa;
        [DisplayName("Note IQOA")]
        public String NoteIqoa
        {
            get
            {
                return this._noteIqoa;
            }
            set
            {
                this._noteIqoa = value;
                RaisePropertyChange("NoteIqoa");
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
                if (this["NoteIqoa"] != null)
                {
                    errors.Add("Note IQOA : "+this["NoteIqoa"]);
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
                if (columnName.Equals("NoteIqoa"))
                {
                    if (String.IsNullOrEmpty(this.NoteIqoa))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                return null;
            }
        }
    }
}
