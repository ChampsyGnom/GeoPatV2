using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CL_ROUL_CHS",Schema="CHS")]
    public partial class ChsClRoul : ModelBase
    {
        private ChsClCarotte _chsClCarotte;
        public virtual ChsClCarotte ChsClCarotte 
        {
            get
            {
                return this._chsClCarotte;
                
            }
            set
            {
                this._chsClCarotte = value;
                this.ClCarotteChsLiaison = this._chsClCarotte.Liaison;
                this.ClCarotteChsSens = this._chsClCarotte.Sens;
                this.ClCarotteChsVoie = this._chsClCarotte.Voie;
                this.ClCarotteChsAbsDeb = this._chsClCarotte.AbsDeb;
            }
        }
        
        [Required()]
        [Column("CL_CAROTTE_CHS_ID_PK",Order=0)]
        public Int64 ChsClCarotteIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("CL_CAROTTE_CHS__LIAISON",Order=2)]
        [Required()]
        [MaxLength(15)] 
        public String ClCarotteChsLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CL_CAROTTE_CHS__SENS",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String ClCarotteChsSens { get; set; }
        
        [Description("Voie")]
        [Column("CL_CAROTTE_CHS__VOIE",Order=4)]
        [Required()]
        [MaxLength(6)] 
        public String ClCarotteChsVoie { get; set; }
        
        [Description("Début")]
        [Column("CL_CAROTTE_CHS__ABS_DEB",Order=5)]
        [Required()]
        public Int64 ClCarotteChsAbsDeb { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=6)]
        [Required()]
        public DateTime DateMs { get; set; }
        
        [Description("Pr fin")]
        [Column("ABS_FIN",Order=7)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Technique")]
        [Column("TECHNIQUE",Order=8)]
        [MaxLength(12)] 
        public String Technique { get; set; }
        
        [Description("Epaisseur")]
        [Column("EPAIS",Order=9)]
        public Nullable<Double> Epais { get; set; }
        
        [Description("Granulométrie")]
        [Column("GRANULO",Order=10)]
        [MaxLength(6)] 
        public String Granulo { get; set; }
        
    }
}
