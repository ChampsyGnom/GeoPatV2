using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PRT_BSN",Schema="BSN")]
    public partial class BsnPrt : ModelBase
    {
        private BsnGrp _bsnGrp;
        public virtual BsnGrp BsnGrp 
        {
            get
            {
                return this._bsnGrp;
                
            }
            set
            {
                this._bsnGrp = value;
                this.GrpBsnIdGrp = this._bsnGrp.IdGrp;
            }
        }
        
        [Required()]
        [Column("GRP_BSN_ID_PK",Order=0)]
        public Int64 BsnGrpIdPk {get;set;}
        
        public virtual ICollection<BsnSprt> BsnSprts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_BSN__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpBsnIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("ID_PRT",Order=3)]
        [Required()]
        public Int64 IdPrt { get; set; }
        
        [Description("Partie")]
        [Column("LIBP",Order=4)]
        [Required()]
        [MaxLength(500)] 
        public String Libp { get; set; }
        
        [Description("N° Ordre")]
        [Column("ORDRE",Order=5)]
        [Required()]
        public Int64 Ordre { get; set; }
        
    }
}
