using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsTreeResultPaveViewModel : ViewModelBase<DsTreeResultPave>
    {
        public DsTreeResultPaveViewModel(DsTreeResultPave model) : base(model)
        {
            this.DsTreeResultPaveVoies = new  ObservableCollection<DsTreeResultPaveVoieViewModel>();
            
        }
        public override void Read()
        {
            this.DsTreeResult=new DsTreeResultViewModel( this.Model.DsTreeResult);
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Technique=this.Model.Technique;
        }
        public override void Write()
        {
            this.Model.DsTreeResult=this. DsTreeResult.Model;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Technique=this.Technique;
        }
        private DsTreeResultViewModel _dsTreeResult;
        [DisplayName("TREE_RESULT_DS")]
        public virtual DsTreeResultViewModel DsTreeResult
        {
            get
            {
                return this._dsTreeResult;
            }
            set
            {
                this._dsTreeResult = value;
                RaisePropertyChange("DsTreeResult");
            }
        }
        
        public virtual ObservableCollection<DsTreeResultPaveVoieViewModel> DsTreeResultPaveVoies { get; set; }
        
        private String _liaison;
        [DisplayName("TREE_RESULT_PAVE_DS__LIAISON")]
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
        [DisplayName("TREE_RESULT_PAVE_DS__SENS")]
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
        [DisplayName("TREE_RESULT_PAVE_DS__ABS_DEB")]
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
        [DisplayName("TREE_RESULT_PAVE_DS__ABS_FIN")]
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
        
        private String _technique;
        [DisplayName("TREE_RESULT_PAVE_DS__TECHNIQUE")]
        public String Technique
        {
            get
            {
                return this._technique;
            }
            set
            {
                this._technique = value;
                RaisePropertyChange("Technique");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Liaison"] != null)
                {
                    errors.Add("TREE_RESULT_PAVE_DS__LIAISON : "+this["Liaison"]);
                }
                if (this["Sens"] != null)
                {
                    errors.Add("TREE_RESULT_PAVE_DS__SENS : "+this["Sens"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("TREE_RESULT_PAVE_DS__ABS_DEB : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("TREE_RESULT_PAVE_DS__ABS_FIN : "+this["AbsFin"]);
                }
                if (this["Technique"] != null)
                {
                    errors.Add("TREE_RESULT_PAVE_DS__TECHNIQUE : "+this["Technique"]);
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
                if (columnName.Equals("Liaison"))
                {
                    if (String.IsNullOrEmpty(this.Liaison))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Sens"))
                {
                    if (String.IsNullOrEmpty(this.Sens))
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
                if (columnName.Equals("Technique"))
                {
                    if (String.IsNullOrEmpty(this.Technique))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
