using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PRT_GMS",Schema="GMS")]
    public partial class GmsPrt : ModelBase
    {
        private GmsGrp _gmsGrp;
        public virtual GmsGrp GmsGrp 
        {
            get
            {
                return this._gmsGrp;
                
            }
            set
            {
                this._gmsGrp = value;
                this.GrpGmsIdGrp = this._gmsGrp.IdGrp;
            }
        }
        
        [Required()]
        [Column("GRP_GMS_ID_PK",Order=0)]
        public Int64 GmsGrpIdPk {get;set;}
        
        public virtual ICollection<GmsSprt> GmsSprts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_GMS__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpGmsIdGrp { get; set; }
        
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
