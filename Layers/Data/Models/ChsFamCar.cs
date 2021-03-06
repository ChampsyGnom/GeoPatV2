using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("FAM_CAR_CHS",Schema="CHS")]
    public partial class ChsFamCar : ModelBase
    {
        private ChsCdFamCar _chsCdFamCar;
        public virtual ChsCdFamCar ChsCdFamCar 
        {
            get
            {
                return this._chsCdFamCar;
                
            }
            set
            {
                this._chsCdFamCar = value;
                this.CdFamCarChsFamille = this._chsCdFamCar.Famille;
            }
        }
        
        [Required()]
        [Column("CD_FAM_CAR_CHS_ID_PK",Order=0)]
        public Int64 ChsCdFamCarIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille")]
        [Column("CD_FAM_CAR_CHS__FAMILLE",Order=2)]
        [Required()]
        [MaxLength(12)] 
        public String CdFamCarChsFamille { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=4)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=5)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=6)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Structure progressive")]
        [Column("PROGRESSIVE",Order=7)]
        public Nullable<int> ProgressiveValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Progressive 
        {
            get
            {
                if (ProgressiveValueInt.HasValue) return Convert.ToBoolean(ProgressiveValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.ProgressiveValueInt = Convert.ToInt32(value.Value);}
                else {this.ProgressiveValueInt =null;}
            }
        }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=8)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
