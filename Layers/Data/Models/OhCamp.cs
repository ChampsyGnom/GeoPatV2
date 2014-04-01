using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CAMP_OH",Schema="OH")]
    public partial class OhCamp : ModelBase
    {
        public virtual OhCdPresta OhCdPresta {get;set;}
        
        public virtual OhCdTypePv OhCdTypePv {get;set;}
        
        public virtual ICollection<OhInsp> OhInsps { get; set; }
        
        public virtual ICollection<OhVst> OhVsts { get; set; }
        
        public virtual ICollection<OhDscTemp> OhDscTemps { get; set; }
        
        public virtual ICollection<OhDscCamp> OhDscCamps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("ID_CAMP",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String IdCamp { get; set; }
        
        [Description("Prestataire")]
        [Column("CD_PRESTA_OH__PRESTATAIRE",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaOhPrestataire { get; set; }
        
        [Description("Type de PV")]
        [Column("CD_TYPE_PV_OH__CODE",Order=2)]
        [Required()]
        [MaxLength(15)] 
        public String CdTypePvOhCode { get; set; }
        
        [Description("Année")]
        [Column("ANNEE",Order=3)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("Date maxi retour")]
        [Column("DATER",Order=4)]
        [Required()]
        public DateTime Dater { get; set; }
        
        [Description("Date génération")]
        [Column("DATEG",Order=5)]
        public Nullable<DateTime> Dateg { get; set; }
        
        [Description("Nom Créateur")]
        [Column("USERG",Order=6)]
        [MaxLength(250)] 
        public String Userg { get; set; }
        
        [Description("Commentaire")]
        [Column("OBSERV",Order=7)]
        [MaxLength(500)] 
        public String Observ { get; set; }
        
    }
}
