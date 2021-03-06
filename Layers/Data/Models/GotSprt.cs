using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_GOT",Schema="GOT")]
    public partial class GotSprt : ModelBase
    {
        private GotPrt _gotPrt;
        public virtual GotPrt GotPrt 
        {
            get
            {
                return this._gotPrt;
                
            }
            set
            {
                this._gotPrt = value;
                this.GrpGotIdGrp = this._gotPrt.GrpGotIdGrp;
                this.PrtGotIdPrt = this._gotPrt.IdPrt;
            }
        }
        
        [Required()]
        [Column("PRT_GOT_ID_PK",Order=0)]
        public Int64 GotPrtIdPk {get;set;}
        
        public virtual ICollection<GotElt> GotElts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_GOT__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpGotIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GOT__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtGotIdPrt { get; set; }
        
        [Description("Identifiant sous partie")]
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
