using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PT_SING_INF",Schema="INF")]
    public partial class InfPtSing : ModelBase
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
        
        private InfCdPtSing _infCdPtSing;
        public virtual InfCdPtSing InfCdPtSing 
        {
            get
            {
                return this._infCdPtSing;
                
            }
            set
            {
                this._infCdPtSing = value;
                this.CdPtSingInfCode = this._infCdPtSing.Code;
            }
        }
        
        [Required()]
        [Column("CD_PT_SING_INF_ID_PK",Order=1)]
        public Int64 InfCdPtSingIdPk {get;set;}
        
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
        
        [Description("Code type")]
        [Column("CD_PT_SING_INF__CODE",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String CdPtSingInfCode { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=6)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=7)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Nom d'usage")]
        [Column("NOM_USAGE",Order=8)]
        [MaxLength(60)] 
        public String NomUsage { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=9)]
        [MaxLength(1000)] 
        public String Commentaire { get; set; }
        
    }
}
