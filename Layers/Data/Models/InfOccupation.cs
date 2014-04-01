using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("OCCUPATION_INF",Schema="INF")]
    public partial class InfOccupation : ModelBase
    {
        public virtual InfCdOccup InfCdOccup {get;set;}
        
        public virtual InfCdOccupant InfCdOccupant {get;set;}
        
        public virtual InfChaussee InfChaussee {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Occupation")]
        [Column("CD_OCCUP_INF__TYPE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String CdOccupInfType { get; set; }
        
        [Description("Nom")]
        [Column("CD_OCCUPANT_INF__NOM",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String CdOccupantInfNom { get; set; }
        
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
        
        [Description("Début")]
        [Column("ABS_DEB",Order=4)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=5)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date Début")]
        [Column("DATE_MS",Order=6)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Date Fin")]
        [Column("DATE_FV",Order=7)]
        public Nullable<DateTime> DateFv { get; set; }
        
        [Description("Traversé")]
        [Column("TRAV",Order=8)]
        public Nullable<int> TravValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Trav 
        {
            get
            {
                if (TravValueInt.HasValue) return Convert.ToBoolean(TravValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.TravValueInt = Convert.ToInt32(value.Value);}
                else {this.TravValueInt =null;}
            }
        }
        
        [Description("Commentaire")]
        [Column("OBS",Order=9)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
