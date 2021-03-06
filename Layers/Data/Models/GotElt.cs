using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_GOT",Schema="GOT")]
    public partial class GotElt : ModelBase
    {
        private GotSprt _gotSprt;
        public virtual GotSprt GotSprt 
        {
            get
            {
                return this._gotSprt;
                
            }
            set
            {
                this._gotSprt = value;
                this.GrpGotIdGrp = this._gotSprt.GrpGotIdGrp;
                this.PrtGotIdPrt = this._gotSprt.PrtGotIdPrt;
                this.SprtGotIdSprt = this._gotSprt.IdSprt;
            }
        }
        
        [Required()]
        [Column("SPRT_GOT_ID_PK",Order=0)]
        public Int64 GotSprtIdPk {get;set;}
        
        public virtual ICollection<GotEltInsp> GotEltInsps { get; set; }
        
        public virtual ICollection<GotEltInspTmp> GotEltInspTmps { get; set; }
        
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
        [Column("SPRT_GOT__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtGotIdSprt { get; set; }
        
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
