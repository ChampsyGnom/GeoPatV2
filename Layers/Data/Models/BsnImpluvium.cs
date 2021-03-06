using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("IMPLUVIUM_BSN",Schema="BSN")]
    public partial class BsnImpluvium : ModelBase
    {
        private BsnDsc _bsnDsc;
        public virtual BsnDsc BsnDsc 
        {
            get
            {
                return this._bsnDsc;
                
            }
            set
            {
                this._bsnDsc = value;
                this.DscBsnNumBsn = this._bsnDsc.NumBsn;
            }
        }
        
        [Required()]
        [Column("DSC_BSN_ID_PK",Order=0)]
        public Int64 BsnDscIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=2)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
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
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=5)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=6)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Surface (ha)")]
        [Column("SURFACE",Order=7)]
        public Nullable<Double> Surface { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=8)]
        [MaxLength(500)] 
        public String Commentaire { get; set; }
        
    }
}
