using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsNeAdminViewModel : ViewModelBase<ChsNeAdmin>
    {
        public ChsNeAdminViewModel(ChsNeAdmin model) : base(model)
        {
        }
        public override void Read()
        {
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.NeAdmiss=this.Model.NeAdmiss;
            this.DateAdmiss=this.Model.DateAdmiss;
        }
        public override void Write()
        {
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.NeAdmiss=this.NeAdmiss;
            this.Model.DateAdmiss=this.DateAdmiss;
        }
        private String _liaison;
        [DisplayName("Liaison")]
        public String Liaison
        {
            get
            {
                return this._liaison;
            }
            set
            {
                this._liaison = value;
                RaisePropertyChange("Liaison");
            }
        }
        private String _sens;
        [DisplayName("Sens")]
        public String Sens
        {
            get
            {
                return this._sens;
            }
            set
            {
                this._sens = value;
                RaisePropertyChange("Sens");
            }
        }
        private Int64 _absDeb;
        [DisplayName("Début")]
        public Int64 AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
            }
        }
        
        private Int64 _absFin;
        [DisplayName("Fin")]
        public Int64 AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
            }
        }
        
        private Nullable<Int64> _neAdmiss;
        [DisplayName("Nbre Essieu Admissible")]
        public Nullable<Int64> NeAdmiss
        {
            get
            {
                return this._neAdmiss;
            }
            set
            {
                this._neAdmiss = value;
                RaisePropertyChange("NeAdmiss");
            }
        }
        
        private Nullable<DateTime> _dateAdmiss;
        [DisplayName("Date démarage NE")]
        public Nullable<DateTime> DateAdmiss
        {
            get
            {
                return this._dateAdmiss;
            }
            set
            {
                this._dateAdmiss = value;
                RaisePropertyChange("DateAdmiss");
            }
        }
        
    }
}
