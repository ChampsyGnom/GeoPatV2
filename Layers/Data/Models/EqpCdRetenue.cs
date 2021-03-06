using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_RETENUE_EQP",Schema="EQP")]
    public partial class EqpCdRetenue : ModelBase
    {
        private EqpCdMateriau _eqpCdMateriau;
        public virtual EqpCdMateriau EqpCdMateriau 
        {
            get
            {
                return this._eqpCdMateriau;
                
            }
            set
            {
                this._eqpCdMateriau = value;
                this.CdMateriauEqpMateriaux = this._eqpCdMateriau.Materiaux;
            }
        }
        
        [Required()]
        [Column("CD_MATERIAU_EQP_ID_PK",Order=0)]
        public Int64 EqpCdMateriauIdPk {get;set;}
        
        public virtual ICollection<EqpDscEs> EqpDscEss { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Matériaux")]
        [Column("CD_MATERIAU_EQP__MATERIAUX",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdMateriauEqpMateriaux { get; set; }
        
        [Description("Type de Dispositif")]
        [Column("DISPOSITIF",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String Dispositif { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
        [Description("Garantie (mois)")]
        [Column("GARANTIE",Order=5)]
        public Nullable<Int64> Garantie { get; set; }
        
        [Description("Durée de vie (mois)")]
        [Column("DVT",Order=6)]
        public Nullable<Int64> Dvt { get; set; }
        
    }
}
