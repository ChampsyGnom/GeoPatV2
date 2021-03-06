using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_BSN",Schema="BSN")]
    public partial class BsnNatureTrav : ModelBase
    {
        private BsnCdTravaux _bsnCdTravaux;
        public virtual BsnCdTravaux BsnCdTravaux 
        {
            get
            {
                return this._bsnCdTravaux;
                
            }
            set
            {
                this._bsnCdTravaux = value;
                this.CdTravauxBsnCode = this._bsnCdTravaux.Code;
            }
        }
        
        [Required()]
        [Column("CD_TRAVAUX_BSN_ID_PK",Order=0)]
        public Int64 BsnCdTravauxIdPk {get;set;}
        
        public virtual ICollection<BsnTravaux> BsnTravauxs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_BSN__CODE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxBsnCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String Nature { get; set; }
        
    }
}
