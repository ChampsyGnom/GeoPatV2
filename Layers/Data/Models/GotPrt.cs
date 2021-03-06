using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PRT_GOT",Schema="GOT")]
    public partial class GotPrt : ModelBase
    {
        private GotGrp _gotGrp;
        public virtual GotGrp GotGrp 
        {
            get
            {
                return this._gotGrp;
                
            }
            set
            {
                this._gotGrp = value;
                this.GrpGotIdGrp = this._gotGrp.IdGrp;
            }
        }
        
        [Required()]
        [Column("GRP_GOT_ID_PK",Order=0)]
        public Int64 GotGrpIdPk {get;set;}
        
        public virtual ICollection<GotSprt> GotSprts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_GOT__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpGotIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("ID_PRT",Order=3)]
        [Required()]
        public Int64 IdPrt { get; set; }
        
        [Description("Partie")]
        [Column("LIBP",Order=4)]
        [Required()]
        [MaxLength(500)] 
        public String Libp { get; set; }
        
        [Description("No Ordre")]
        [Column("ORDRE",Order=5)]
        [Required()]
        public Int64 Ordre { get; set; }
        
    }
}
