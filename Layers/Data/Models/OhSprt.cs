using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_OH",Schema="OH")]
    public partial class OhSprt : ModelBase
    {
        private OhPrt _ohPrt;
        public virtual OhPrt OhPrt 
        {
            get
            {
                return this._ohPrt;
                
            }
            set
            {
                this._ohPrt = value;
                this.GrpOhIdGrp = this._ohPrt.GrpOhIdGrp;
                this.PrtOhIdPrt = this._ohPrt.IdPrt;
            }
        }
        
        [Required()]
        [Column("PRT_OH_ID_PK",Order=0)]
        public Int64 OhPrtIdPk {get;set;}
        
        public virtual ICollection<OhElt> OhElts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_OH__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpOhIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_OH__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtOhIdPrt { get; set; }
        
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
