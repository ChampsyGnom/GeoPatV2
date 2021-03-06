using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_GMS",Schema="GMS")]
    public partial class GmsSprt : ModelBase
    {
        private GmsPrt _gmsPrt;
        public virtual GmsPrt GmsPrt 
        {
            get
            {
                return this._gmsPrt;
                
            }
            set
            {
                this._gmsPrt = value;
                this.GrpGmsIdGrp = this._gmsPrt.GrpGmsIdGrp;
                this.PrtGmsIdPrt = this._gmsPrt.IdPrt;
            }
        }
        
        [Required()]
        [Column("PRT_GMS_ID_PK",Order=0)]
        public Int64 GmsPrtIdPk {get;set;}
        
        public virtual ICollection<GmsElt> GmsElts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_GMS__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpGmsIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GMS__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtGmsIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("ID_SPRT",Order=4)]
        [Required()]
        public Int64 IdSprt { get; set; }
        
        [Description("Sous partie")]
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
