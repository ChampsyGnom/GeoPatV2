using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdTypePvViewModel : ViewModelBase<OhCdTypePv>
    {
        public OhCdTypePvViewModel(OhCdTypePv model) : base(model)
        {
            this.OhCamps = new  ObservableCollection<OhCampViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
            this.Cycle=this.Model.Cycle;
            this.Cout=this.Model.Cout;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
            this.Model.Cycle=this.Cycle;
            this.Model.Cout=this.Cout;
        }
        public virtual ObservableCollection<OhCampViewModel> OhCamps { get; set; }
        
        private String _code;
        [DisplayName("Type de PV")]
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
        private Nullable<Int64> _cycle;
        [DisplayName("Cycle")]
        public Nullable<Int64> Cycle
        {
            get
            {
                return this._cycle;
            }
            set
            {
                this._cycle = value;
                RaisePropertyChange("Cycle");
            }
        }
        
        private Nullable<Int64> _cout;
        [DisplayName("Coût unitaire (€)")]
        public Nullable<Int64> Cout
        {
            get
            {
                return this._cout;
            }
            set
            {
                this._cout = value;
                RaisePropertyChange("Cout");
            }
        }
        
    }
}
