using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BM_TABLE",Schema="PRF")]
    public partial class PrfBmTable : ModelBase
    {
        private PrfBmSchema _prfBmSchema;
        public virtual PrfBmSchema PrfBmSchema 
        {
            get
            {
                return this._prfBmSchema;
                
            }
            set
            {
                this._prfBmSchema = value;
                this.BmSchemaSchema = this._prfBmSchema.Schema;
            }
        }
        
        [Required()]
        [Column("BM_SCHEMA_ID_PK",Order=0)]
        public Int64 PrfBmSchemaIdPk {get;set;}
        
        public virtual ICollection<PrfBmProfilTable> PrfBmProfilTables { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nom")]
        [Column("NOM",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String Nom { get; set; }
        
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
