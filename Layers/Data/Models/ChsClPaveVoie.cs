using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CL_PAVE_VOIE_CHS",Schema="CHS")]
    public partial class ChsClPaveVoie : ModelBase
    {
        private ChsPaveVoie _chsPaveVoie;
        public virtual ChsPaveVoie ChsPaveVoie 
        {
            get
            {
                return this._chsPaveVoie;
                
            }
            set
            {
                this._chsPaveVoie = value;
                this.CdCouChsCouche = this._chsPaveVoie.CdCouChsCouche;
                this.PaveChsDateMs = this._chsPaveVoie.PaveChsDateMs;
                this.PaveChsLiaison = this._chsPaveVoie.PaveChsLiaison;
                this.PaveChsSens = this._chsPaveVoie.PaveChsSens;
                this.PaveChsAbsDeb = this._chsPaveVoie.PaveChsAbsDeb;
                this.PaveChsAbsFin = this._chsPaveVoie.PaveChsAbsFin;
                this.PaveVoieChsVoie = this._chsPaveVoie.Voie;
                this.PaveVoieChsVoiedeb = this._chsPaveVoie.Voiedeb;
                this.PaveVoieChsVoiefin = this._chsPaveVoie.Voiefin;
            }
        }
        
        [Required()]
        [Column("PAVE_VOIE_CHS_ID_PK",Order=0)]
        public Int64 ChsPaveVoieIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Couche")]
        [Column("CD_COU_CHS__COUCHE",Order=2)]
        [Required()]
        [MaxLength(14)] 
        public String CdCouChsCouche { get; set; }
        
        [Description("Date MS")]
        [Column("PAVE_CHS__DATE_MS",Order=3)]
        [Required()]
        public DateTime PaveChsDateMs { get; set; }
        
        [Description("Liaison")]
        [Column("PAVE_CHS__LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String PaveChsLiaison { get; set; }
        
        [Description("Sens")]
        [Column("PAVE_CHS__SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String PaveChsSens { get; set; }
        
        [Description("Début")]
        [Column("PAVE_CHS__ABS_DEB",Order=6)]
        [Required()]
        public Int64 PaveChsAbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("PAVE_CHS__ABS_FIN",Order=7)]
        [Required()]
        public Int64 PaveChsAbsFin { get; set; }
        
        [Description("Voie")]
        [Column("PAVE_VOIE_CHS__VOIE",Order=8)]
        [Required()]
        [MaxLength(6)] 
        public String PaveVoieChsVoie { get; set; }
        
        [Description("Début Voie")]
        [Column("PAVE_VOIE_CHS__VOIEDEB",Order=9)]
        [Required()]
        public Int64 PaveVoieChsVoiedeb { get; set; }
        
        [Description("Fin voie")]
        [Column("PAVE_VOIE_CHS__VOIEFIN",Order=10)]
        [Required()]
        public Int64 PaveVoieChsVoiefin { get; set; }
        
        [Description("Début pavé voie")]
        [Column("ABS_DEB",Order=11)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin pavé voie")]
        [Column("ABS_FIN",Order=12)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
    }
}
