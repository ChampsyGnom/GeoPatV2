using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_GMS",Schema="GMS")]
    public partial class GmsElt : ModelBase
    {
        private GmsSprt _gmsSprt;
        public virtual GmsSprt GmsSprt 
        {
            get
            {
                return this._gmsSprt;
                
            }
            set
            {
                this._gmsSprt = value;
                this.GrpGmsIdGrp = this._gmsSprt.GrpGmsIdGrp;
                this.PrtGmsIdPrt = this._gmsSprt.PrtGmsIdPrt;
                this.SprtGmsIdSprt = this._gmsSprt.IdSprt;
            }
        }
        
        [Required()]
        [Column("SPRT_GMS_ID_PK",Order=0)]
        public Int64 GmsSprtIdPk {get;set;}
        
        public virtual ICollection<GmsEltInsp> GmsEltInsps { get; set; }
        
        public virtual ICollection<GmsEltInspTmp> GmsEltInspTmps { get; set; }
        
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
        [Column("SPRT_GMS__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtGmsIdSprt { get; set; }
        
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
