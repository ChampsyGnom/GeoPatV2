using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TALUS_INF",Schema="INF")]
    public partial class InfTalus : ModelBase
    {
        private InfCdTalus _infCdTalus;
        public virtual InfCdTalus InfCdTalus 
        {
            get
            {
                return this._infCdTalus;
                
            }
            set
            {
                this._infCdTalus = value;
                this.CdTalusInfType = this._infCdTalus.Type;
            }
        }
        
        [Required()]
        [Column("CD_TALUS_INF_ID_PK",Order=0)]
        public Int64 InfCdTalusIdPk {get;set;}
        
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
        [Column("CHAUSSEE_INF_ID_PK",Order=1)]
        public Int64 InfChausseeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Talus")]
        [Column("CD_TALUS_INF__TYPE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdTalusInfType { get; set; }
        
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
        
        [Description("Début")]
        [Column("ABS_DEB",Order=6)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=7)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("hauteur (m)")]
        [Column("HAUT",Order=8)]
        public Nullable<Double> Haut { get; set; }
        
    }
}
