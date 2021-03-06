using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PREV_SGE_INF",Schema="INF")]
    public partial class InfPrevSge : ModelBase
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
        
        [Description("Base métier")]
        [Column("SCHEMA",Order=4)]
        [Required()]
        [MaxLength(5)] 
        public String Schema { get; set; }
        
        [Description("Date début")]
        [Column("DATE_DEB",Order=5)]
        [Required()]
        public DateTime DateDeb { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=6)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Nature")]
        [Column("NATURE",Order=7)]
        [Required()]
        [MaxLength(125)] 
        public String Nature { get; set; }
        
        [Description("Num Ouvrage")]
        [Column("NUM_OUVRAGE",Order=8)]
        [Required()]
        [MaxLength(20)] 
        public String NumOuvrage { get; set; }
        
        [Description("Date fin")]
        [Column("DATE_FIN",Order=9)]
        public Nullable<DateTime> DateFin { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=10)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Contrainte d'exploit")]
        [Column("CE",Order=11)]
        [MaxLength(100)] 
        public String Ce { get; set; }
        
        [Description("Date Publication")]
        [Column("DATE_PUB",Order=12)]
        public Nullable<DateTime> DatePub { get; set; }
        
        [Description("Date Fin Publication")]
        [Column("DATE_FINPUB",Order=13)]
        public Nullable<DateTime> DateFinpub { get; set; }
        
        [Description("Date demande")]
        [Column("DATE_DEMANDE",Order=14)]
        public Nullable<DateTime> DateDemande { get; set; }
        
        [Description("Nom d'usage")]
        [Column("NOM_USAGE",Order=15)]
        [MaxLength(30)] 
        public String NomUsage { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=16)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
