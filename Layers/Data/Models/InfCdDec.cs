using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_DEC_INF",Schema="INF")]
    public partial class InfCdDec : ModelBase
    {
        private InfFamDec _infFamDec;
        public virtual InfFamDec InfFamDec 
        {
            get
            {
                return this._infFamDec;
                
            }
            set
            {
                this._infFamDec = value;
                this.FamDecInfFamDec = this._infFamDec.FamDec;
            }
        }
        
        [Required()]
        [Column("FAM_DEC_INF_ID_PK",Order=0)]
        public Int64 InfFamDecIdPk {get;set;}
        
        public virtual ICollection<InfTrDec> InfTrDecs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code famille")]
        [Column("FAM_DEC_INF__FAM_DEC",Order=2)]
        [Required()]
        [MaxLength(6)] 
        public String FamDecInfFamDec { get; set; }
        
        [Description("Code decoupage")]
        [Column("CD_DEC",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDec { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
