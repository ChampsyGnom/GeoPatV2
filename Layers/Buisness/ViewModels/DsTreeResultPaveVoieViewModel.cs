using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsTreeResultPaveVoieViewModel : ViewModelBase<DsTreeResultPaveVoie>
    {
        public DsTreeResultPaveVoieViewModel(DsTreeResultPaveVoie model) : base(model)
        {
        }
        public override void Read()
        {
            this.DsTreeResultPave=new DsTreeResultPaveViewModel( this.Model.DsTreeResultPave);
            this.Voie=this.Model.Voie;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
        }
        public override void Write()
        {
            this.Model.DsTreeResultPave=this. DsTreeResultPave.Model;
            this.Model.Voie=this.Voie;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
        }
        private DsTreeResultPaveViewModel _dsTreeResultPave;
        [DisplayName("TREE_RESULT_PAVE_DS")]
        public virtual DsTreeResultPaveViewModel DsTreeResultPave
        {
            get
            {
                return this._dsTreeResultPave;
            }
            set
            {
                this._dsTreeResultPave = value;
                RaisePropertyChange("DsTreeResultPave");
            }
        }
        
        private String _voie;
        [DisplayName("TREE_RESULT_PAVE_VOIE_DS__VOIE")]
        public String Voie
        {
            get
            {
                return this._voie;
            }
            set
            {
                this._voie = value;
                RaisePropertyChange("Voie");
            }
        }
        private Int64 _absDeb;
        [DisplayName("TREE_RESULT_PAVE_VOIE_DS__ABS_DEB")]
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
        [DisplayName("TREE_RESULT_PAVE_VOIE_DS__ABS_FIN")]
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Voie"] != null)
                {
                    errors.Add("TREE_RESULT_PAVE_VOIE_DS__VOIE : "+this["Voie"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("TREE_RESULT_PAVE_VOIE_DS__ABS_DEB : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("TREE_RESULT_PAVE_VOIE_DS__ABS_FIN : "+this["AbsFin"]);
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
                if (columnName.Equals("Voie"))
                {
                    if (String.IsNullOrEmpty(this.Voie))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                return null;
            }
        }
    }
}
