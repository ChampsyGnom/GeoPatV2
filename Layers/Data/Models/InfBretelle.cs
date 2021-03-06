using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BRETELLE_INF",Schema="INF")]
    public partial class InfBretelle : ModelBase
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
        
        [Description("Pr raccordement")]
        [Column("ABS_DEB",Order=4)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("N° Exploitation")]
        [Column("NUM_EXPLOIT",Order=5)]
        [MaxLength(15)] 
        public String NumExploit { get; set; }
        
        [Description("N° Bretelle")]
        [Column("NUM_BRETELLE",Order=6)]
        [MaxLength(15)] 
        public String NumBretelle { get; set; }
        
        [Description("Nom Bretelle")]
        [Column("NOM_BRETELLE",Order=7)]
        [MaxLength(15)] 
        public String NomBretelle { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=8)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Type")]
        [Column("TYPE",Order=9)]
        [MaxLength(60)] 
        public String Type { get; set; }
        
        [Description("Extremité")]
        [Column("EXTREMITE",Order=10)]
        [MaxLength(60)] 
        public String Extremite { get; set; }
        
    }
}
