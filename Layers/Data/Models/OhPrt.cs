using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PRT_OH",Schema="OH")]
    public partial class OhPrt : ModelBase
    {
        private OhGrp _ohGrp;
        public virtual OhGrp OhGrp 
        {
            get
            {
                return this._ohGrp;
                
            }
            set
            {
                this._ohGrp = value;
                this.GrpOhIdGrp = this._ohGrp.IdGrp;
            }
        }
        
        [Required()]
        [Column("GRP_OH_ID_PK",Order=0)]
        public Int64 OhGrpIdPk {get;set;}
        
        public virtual ICollection<OhSprt> OhSprts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_OH__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpOhIdGrp { get; set; }
        
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
