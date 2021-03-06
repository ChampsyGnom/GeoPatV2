using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TR_DEC_INF",Schema="INF")]
    public partial class InfTrDec : ModelBase
    {
        private InfChaussee _infChaussee;
        public virtual InfChaussee InfChaussee 
        {
            get
            {
                return this._infChaussee;
                
            }
            set
            {
                this._infChaussee = value;
                this.LiaisonInfLiaison = this._infChaussee.LiaisonInfLiaison;
                this.ChausseeInfSens = this._infChaussee.Sens;
            }
        }
        
        [Required()]
        [Column("CHAUSSEE_INF_ID_PK",Order=0)]
        public Int64 InfChausseeIdPk {get;set;}
        
        private InfCdDec _infCdDec;
        public virtual InfCdDec InfCdDec 
        {
            get
            {
                return this._infCdDec;
                
            }
            set
            {
                this._infCdDec = value;
                this.FamDecInfFamDec = this._infCdDec.FamDecInfFamDec;
                this.CdDecInfCdDec = this._infCdDec.CdDec;
            }
        }
        
        [Required()]
        [Column("CD_DEC_INF_ID_PK",Order=1)]
        public Int64 InfCdDecIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=4)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Code famille")]
        [Column("FAM_DEC_INF__FAM_DEC",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String FamDecInfFamDec { get; set; }
        
        [Description("Code decoupage")]
        [Column("CD_DEC_INF__CD_DEC",Order=6)]
        [Required()]
        [MaxLength(15)] 
        public String CdDecInfCdDec { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=7)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=8)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
    }
}
