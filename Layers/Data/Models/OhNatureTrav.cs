using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_OH",Schema="OH")]
    public partial class OhNatureTrav : ModelBase
    {
        private OhCdTravaux _ohCdTravaux;
        public virtual OhCdTravaux OhCdTravaux 
        {
            get
            {
                return this._ohCdTravaux;
                
            }
            set
            {
                this._ohCdTravaux = value;
                this.CdTravauxOhCode = this._ohCdTravaux.Code;
            }
        }
        
        [Required()]
        [Column("CD_TRAVAUX_OH_ID_PK",Order=0)]
        public Int64 OhCdTravauxIdPk {get;set;}
        
        public virtual ICollection<OhTravaux> OhTravauxs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_OH__CODE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxOhCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String Nature { get; set; }
        
    }
}
