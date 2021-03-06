using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ARCHIVE_3_OA",Schema="OA")]
    public partial class OaArchive3 : ModelBase
    {
        public virtual ICollection<OaDscArchive3> OaDscArchive3s { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Date Calcul")]
        [Column("DATE_CALC",Order=1)]
        [Required()]
        public DateTime DateCalc { get; set; }
        
        [Description("Nbre Total OA")]
        [Column("NBRE",Order=2)]
        [Required()]
        public Int64 Nbre { get; set; }
        
        [Description("Surf totale")]
        [Column("SURF",Order=3)]
        [Required()]
        public Int64 Surf { get; set; }
        
        [Description("Etat 3x")]
        [Column("ETAT_3X",Order=4)]
        [Required()]
        [MaxLength(3)] 
        public String Etat3x { get; set; }
        
        [Description("Délai")]
        [Column("DELAI",Order=5)]
        public Nullable<Int64> Delai { get; set; }
        
        [Description("Etat Lolf")]
        [Column("ETAT_LOLF",Order=6)]
        public Nullable<Double> EtatLolf { get; set; }
        
        [Description("Montant pénalité")]
        [Column("MONTANT",Order=7)]
        public Nullable<Int64> Montant { get; set; }
        
        [Description("Commentaire")]
        [Column("OBSV",Order=8)]
        [MaxLength(255)] 
        public String Obsv { get; set; }
        
    }
}
