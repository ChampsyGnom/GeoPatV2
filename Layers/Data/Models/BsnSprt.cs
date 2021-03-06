using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_BSN",Schema="BSN")]
    public partial class BsnSprt : ModelBase
    {
        private BsnPrt _bsnPrt;
        public virtual BsnPrt BsnPrt 
        {
            get
            {
                return this._bsnPrt;
                
            }
            set
            {
                this._bsnPrt = value;
                this.GrpBsnIdGrp = this._bsnPrt.GrpBsnIdGrp;
                this.PrtBsnIdPrt = this._bsnPrt.IdPrt;
            }
        }
        
        [Required()]
        [Column("PRT_BSN_ID_PK",Order=0)]
        public Int64 BsnPrtIdPk {get;set;}
        
        public virtual ICollection<BsnElt> BsnElts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_BSN__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpBsnIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_BSN__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtBsnIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("ID_SPRT",Order=4)]
        [Required()]
        public Int64 IdSprt { get; set; }
        
        [Description("Sous Partie")]
        [Column("LIBS",Order=5)]
        [Required()]
        [MaxLength(500)] 
        public String Libs { get; set; }
        
        [Description("N° Ordre")]
        [Column("ORDRE",Order=6)]
        [Required()]
        public Int64 Ordre { get; set; }
        
    }
}
