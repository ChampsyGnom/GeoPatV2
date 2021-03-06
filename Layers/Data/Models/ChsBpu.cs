using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BPU_CHS",Schema="CHS")]
    public partial class ChsBpu : ModelBase
    {
        private ChsCdTravaux _chsCdTravaux;
        public virtual ChsCdTravaux ChsCdTravaux 
        {
            get
            {
                return this._chsCdTravaux;
                
            }
            set
            {
                this._chsCdTravaux = value;
                this.CdTravauxChsCode = this._chsCdTravaux.Code;
            }
        }
        
        [Required()]
        [Column("CD_TRAVAUX_CHS_ID_PK",Order=0)]
        public Int64 ChsCdTravauxIdPk {get;set;}
        
        public virtual ICollection<ChsPrevision> ChsPrevisions { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Technique")]
        [Column("CODE",Order=2)]
        [Required()]
        [MaxLength(25)] 
        public String Code { get; set; }
        
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_CHS__CODE",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxChsCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(250)] 
        public String Libelle { get; set; }
        
        [Description("Prix Unitaire (€)")]
        [Column("PRIX",Order=5)]
        public Nullable<Int64> Prix { get; set; }
        
        [Description("Date MAJ")]
        [Column("DATE_MAJ",Order=6)]
        public Nullable<DateTime> DateMaj { get; set; }
        
    }
}
