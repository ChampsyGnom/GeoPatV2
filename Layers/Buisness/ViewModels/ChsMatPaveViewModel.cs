using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsMatPaveViewModel : ViewModelBase<ChsMatPave>
    {
        public ChsMatPaveViewModel(ChsMatPave model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsFabCar=new ChsFabCarViewModel( this.Model.ChsFabCar);
            this.ChsMat=new ChsMatViewModel( this.Model.ChsMat);
            this.ChsPave=new ChsPaveViewModel( this.Model.ChsPave);
            this.Num=this.Model.Num;
            this.Classe=this.Model.Classe;
            this.Dosage=this.Model.Dosage;
            this.Observ=this.Model.Observ;
        }
        public override void Write()
        {
            this.Model.ChsFabCar=this. ChsFabCar.Model;
            this.Model.ChsMat=this. ChsMat.Model;
            this.Model.ChsPave=this. ChsPave.Model;
            this.Model.Num=this.Num;
            this.Model.Classe=this.Classe;
            this.Model.Dosage=this.Dosage;
            this.Model.Observ=this.Observ;
        }
        private ChsFabCarViewModel _chsFabCar;
        [DisplayName("Fabricant/Carrière")]
        public virtual ChsFabCarViewModel ChsFabCar
        {
            get
            {
                return this._chsFabCar;
            }
            set
            {
                this._chsFabCar = value;
                RaisePropertyChange("ChsFabCar");
            }
        }
        
        private ChsMatViewModel _chsMat;
        [DisplayName("Materiaux")]
        public virtual ChsMatViewModel ChsMat
        {
            get
            {
                return this._chsMat;
            }
            set
            {
                this._chsMat = value;
                RaisePropertyChange("ChsMat");
            }
        }
        
        private ChsPaveViewModel _chsPave;
        [DisplayName("Pavé MO")]
        public virtual ChsPaveViewModel ChsPave
        {
            get
            {
                return this._chsPave;
            }
            set
            {
                this._chsPave = value;
                RaisePropertyChange("ChsPave");
            }
        }
        
        private Int64 _num;
        [DisplayName("No Ordre")]
        public Int64 Num
        {
            get
            {
                return this._num;
            }
            set
            {
                this._num = value;
                RaisePropertyChange("Num");
            }
        }
        
        private String _classe;
        [DisplayName("Classe matériau")]
        public String Classe
        {
            get
            {
                return this._classe;
            }
            set
            {
                this._classe = value;
                RaisePropertyChange("Classe");
            }
        }
        private String _dosage;
        [DisplayName("Dosage")]
        public String Dosage
        {
            get
            {
                return this._dosage;
            }
            set
            {
                this._dosage = value;
                RaisePropertyChange("Dosage");
            }
        }
        private String _observ;
        [DisplayName("Observation")]
        public String Observ
        {
            get
            {
                return this._observ;
            }
            set
            {
                this._observ = value;
                RaisePropertyChange("Observ");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Num"] != null)
                {
                    errors.Add("No Ordre : "+this["Num"]);
                }
                if (this["Classe"] != null)
                {
                    errors.Add("Classe matériau : "+this["Classe"]);
                }
                if (this["Dosage"] != null)
                {
                    errors.Add("Dosage : "+this["Dosage"]);
                }
                if (this["Observ"] != null)
                {
                    errors.Add("Observation : "+this["Observ"]);
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
                if (columnName.Equals("Num"))
                {
                }
                if (columnName.Equals("Classe"))
                {
                }
                if (columnName.Equals("Dosage"))
                {
                }
                if (columnName.Equals("Observ"))
                {
                }
                return null;
            }
        }
    }
}
