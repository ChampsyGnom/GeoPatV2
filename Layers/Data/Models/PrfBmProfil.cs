using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BM_PROFIL",Schema="PRF")]
    public partial class PrfBmProfil : ModelBase
    {
        public virtual PrfBmSchema PrfBmSchema {get;set;}
        
        [Required()]
        [Column("BM_SCHEMA_ID_PK",Order=0)]
        public Int64 PrfBmSchemaIdPk {get;set;}
        
        public virtual ICollection<PrfBmProfilTable> PrfBmProfilTables { get; set; }
        
        public virtual ICollection<PrfBmUserProfil> PrfBmUserProfils { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Profil")]
        [Column("PROFIL",Order=2)]
        [Required()]
        [MaxLength(20)] 
        public String Profil { get; set; }
        
        [Description("Code schéma")]
        [Column("BM_SCHEMA__SCHEMA",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String BmSchemaSchema { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
