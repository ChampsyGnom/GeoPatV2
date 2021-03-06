using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PRT_OA",Schema="OA")]
    public partial class OaPrt : ModelBase
    {
        private OaGrp _oaGrp;
        public virtual OaGrp OaGrp 
        {
            get
            {
                return this._oaGrp;
                
            }
            set
            {
                this._oaGrp = value;
                this.GrpOaIdGrp = this._oaGrp.IdGrp;
            }
        }
        
        [Required()]
        [Column("GRP_OA_ID_PK",Order=0)]
        public Int64 OaGrpIdPk {get;set;}
        
        public virtual ICollection<OaSprt> OaSprts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_OA__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpOaIdGrp { get; set; }
        
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
