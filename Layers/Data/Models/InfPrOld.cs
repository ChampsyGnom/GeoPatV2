using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PR_OLD_INF",Schema="INF")]
    public partial class InfPrOld : ModelBase
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
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=2)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Numéro PR")]
        [Column("NUM",Order=4)]
        [Required()]
        public Int64 Num { get; set; }
        
        [Description("Inter PR")]
        [Column("INTER",Order=5)]
        [Required()]
        public Int64 Inter { get; set; }
        
        [Description("Abscisse cumulée")]
        [Column("ABS_CUM",Order=6)]
        public Nullable<Int64> AbsCum { get; set; }
        
    }
}
