using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_GOT",Schema="GOT")]
    public partial class GotNatureTrav : ModelBase
    {
        private GotCdTravaux _gotCdTravaux;
        public virtual GotCdTravaux GotCdTravaux 
        {
            get
            {
                return this._gotCdTravaux;
                
            }
            set
            {
                this._gotCdTravaux = value;
                this.CdTravauxGotCode = this._gotCdTravaux.Code;
            }
        }
        
        [Required()]
        [Column("CD_TRAVAUX_GOT_ID_PK",Order=0)]
        public Int64 GotCdTravauxIdPk {get;set;}
        
        public virtual ICollection<GotTravaux> GotTravauxs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_GOT__CODE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxGotCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE",Order=3)]
        [Required()]
        [MaxLength(255)] 
        public String Nature { get; set; }
        
    }
}
