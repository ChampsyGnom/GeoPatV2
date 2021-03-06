using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ECLAIRAGE_INF",Schema="INF")]
    public partial class InfEclairage : ModelBase
    {
        private InfCdEclair _infCdEclair;
        public virtual InfCdEclair InfCdEclair 
        {
            get
            {
                return this._infCdEclair;
                
            }
            set
            {
                this._infCdEclair = value;
                this.CdEclairInfType = this._infCdEclair.Type;
            }
        }
        
        [Required()]
        [Column("CD_ECLAIR_INF_ID_PK",Order=0)]
        public Int64 InfCdEclairIdPk {get;set;}
        
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
        [Column("CD_POSIT_INF_ID_PK",Order=1)]
        public Int64 InfCdPositIdPk {get;set;}
        
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
        [Column("CHAUSSEE_INF_ID_PK",Order=2)]
        public Int64 InfChausseeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Eclairage")]
        [Column("CD_ECLAIR_INF__TYPE",Order=4)]
        [Required()]
        [MaxLength(25)] 
        public String CdEclairInfType { get; set; }
        
        [Description("Position")]
        [Column("CD_POSIT_INF__POSIT",Order=5)]
        [Required()]
        [MaxLength(12)] 
        public String CdPositInfPosit { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=6)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=7)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=8)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
    }
}
