using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_BSN",Schema="BSN")]
    public partial class BsnElt : ModelBase
    {
        private BsnSprt _bsnSprt;
        public virtual BsnSprt BsnSprt 
        {
            get
            {
                return this._bsnSprt;
                
            }
            set
            {
                this._bsnSprt = value;
                this.GrpBsnIdGrp = this._bsnSprt.GrpBsnIdGrp;
                this.PrtBsnIdPrt = this._bsnSprt.PrtBsnIdPrt;
                this.SprtBsnIdSprt = this._bsnSprt.IdSprt;
            }
        }
        
        [Required()]
        [Column("SPRT_BSN_ID_PK",Order=0)]
        public Int64 BsnSprtIdPk {get;set;}
        
        public virtual ICollection<BsnEltInsp> BsnEltInsps { get; set; }
        
        public virtual ICollection<BsnEltInspTmp> BsnEltInspTmps { get; set; }
        
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
        [Column("SPRT_BSN__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtBsnIdSprt { get; set; }
        
        [Description("Identifiant Elément")]
        [Column("ID_ELEM",Order=5)]
        [Required()]
        public Int64 IdElem { get; set; }
        
        [Description("Elément")]
        [Column("LIBE",Order=6)]
        [Required()]
        [MaxLength(500)] 
        public String Libe { get; set; }
        
        [Description("N° Ordre")]
        [Column("ORDRE",Order=7)]
        [Required()]
        public Int64 Ordre { get; set; }
        
        [Description("Aide à la saisie")]
        [Column("AIDE",Order=8)]
        [MaxLength(500)] 
        public String Aide { get; set; }
        
        [Description("Indice1")]
        [Column("INDICE1",Order=9)]
        [MaxLength(500)] 
        public String Indice1 { get; set; }
        
        [Description("Indice2")]
        [Column("INDICE2",Order=10)]
        [MaxLength(500)] 
        public String Indice2 { get; set; }
        
        [Description("Indice3")]
        [Column("INDICE3",Order=11)]
        [MaxLength(500)] 
        public String Indice3 { get; set; }
        
    }
}
