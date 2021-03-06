using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("GEOMETRIE_BSN",Schema="BSN")]
    public partial class BsnGeometrie : ModelBase
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
        
        [Description("Surf. Bassin (m²)")]
        [Column("SURF",Order=3)]
        public Nullable<Double> Surf { get; set; }
        
        [Description("Prof. Bassin (m)")]
        [Column("PROF",Order=4)]
        public Nullable<Double> Prof { get; set; }
        
        [Description("Pente Talus (%)")]
        [Column("PENTE",Order=5)]
        public Nullable<Double> Pente { get; set; }
        
        [Description("Périmètre clôture (m)")]
        [Column("PERIMETRE",Order=6)]
        public Nullable<Double> Perimetre { get; set; }
        
    }
}
