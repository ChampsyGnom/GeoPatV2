using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PAVE_VOIE_CHS",Schema="CHS")]
    public partial class ChsPaveVoie : ModelBase
    {
        private ChsPave _chsPave;
        public virtual ChsPave ChsPave 
        {
            get
            {
                return this._chsPave;
                
            }
            set
            {
                this._chsPave = value;
                this.CdCouChsCouche = this._chsPave.CdCouChsCouche;
                this.PaveChsDateMs = this._chsPave.DateMs;
                this.PaveChsLiaison = this._chsPave.Liaison;
                this.PaveChsSens = this._chsPave.Sens;
                this.PaveChsAbsDeb = this._chsPave.AbsDeb;
                this.PaveChsAbsFin = this._chsPave.AbsFin;
            }
        }
        
        [Required()]
        [Column("PAVE_CHS_ID_PK",Order=0)]
        public Int64 ChsPaveIdPk {get;set;}
        
        public virtual ICollection<ChsClPaveVoie> ChsClPaveVoies { get; set; }
        
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
        [Column("VOIE",Order=8)]
        [Required()]
        [MaxLength(6)] 
        public String Voie { get; set; }
        
        [Description("Début Voie")]
        [Column("VOIEDEB",Order=9)]
        [Required()]
        public Int64 Voiedeb { get; set; }
        
        [Description("Fin voie")]
        [Column("VOIEFIN",Order=10)]
        [Required()]
        public Int64 Voiefin { get; set; }
        
    }
}
