using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ACCIDENT_INF",Schema="INF")]
    public partial class InfAccident : ModelBase
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
        
        [Description("Année")]
        [Column("ANNEE",Order=4)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=5)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Mois")]
        [Column("MOIS",Order=6)]
        [Required()]
        public Int64 Mois { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=7)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Nbre Accidents")]
        [Column("NBR_ACC",Order=8)]
        public Nullable<Int64> NbrAcc { get; set; }
        
        [Description("AM")]
        [Column("NBR_ACC_MOIS",Order=9)]
        public Nullable<Int64> NbrAccMois { get; set; }
        
    }
}
