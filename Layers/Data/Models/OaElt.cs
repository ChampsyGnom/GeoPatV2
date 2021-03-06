using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_OA",Schema="OA")]
    public partial class OaElt : ModelBase
    {
        private OaSprt _oaSprt;
        public virtual OaSprt OaSprt 
        {
            get
            {
                return this._oaSprt;
                
            }
            set
            {
                this._oaSprt = value;
                this.GrpOaIdGrp = this._oaSprt.GrpOaIdGrp;
                this.PrtOaIdPrt = this._oaSprt.PrtOaIdPrt;
                this.SprtOaIdSprt = this._oaSprt.IdSprt;
            }
        }
        
        [Required()]
        [Column("SPRT_OA_ID_PK",Order=0)]
        public Int64 OaSprtIdPk {get;set;}
        
        public virtual ICollection<OaEltInsp> OaEltInsps { get; set; }
        
        public virtual ICollection<OaEltInspTmp> OaEltInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_OA__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpOaIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_OA__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtOaIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_OA__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtOaIdSprt { get; set; }
        
        [Description("Identifiant élément")]
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
