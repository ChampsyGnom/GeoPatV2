using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SECURITE_INF",Schema="INF")]
    public partial class InfSecurite : ModelBase
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
        
        private InfCdSecur _infCdSecur;
        public virtual InfCdSecur InfCdSecur 
        {
            get
            {
                return this._infCdSecur;
                
            }
            set
            {
                this._infCdSecur = value;
                this.CdSecurInfType = this._infCdSecur.Type;
            }
        }
        
        [Required()]
        [Column("CD_SECUR_INF_ID_PK",Order=1)]
        public Int64 InfCdSecurIdPk {get;set;}
        
        private InfCdPosit _infCdPosit;
        public virtual InfCdPosit InfCdPosit 
        {
            get
            {
                return this._infCdPosit;
                
            }
            set
            {
                this._infCdPosit = value;
                this.CdPositInfPosit = this._infCdPosit.Posit;
            }
        }
        
        [Required()]
        [Column("CD_POSIT_INF_ID_PK",Order=2)]
        public Int64 InfCdPositIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Sécurité")]
        [Column("CD_SECUR_INF__TYPE",Order=6)]
        [Required()]
        [MaxLength(25)] 
        public String CdSecurInfType { get; set; }
        
        [Description("Position")]
        [Column("CD_POSIT_INF__POSIT",Order=7)]
        [Required()]
        [MaxLength(12)] 
        public String CdPositInfPosit { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=8)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=9)]
        public Nullable<Int64> AbsFin { get; set; }
        
    }
}
