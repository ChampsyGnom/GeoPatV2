using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_OA",Schema="OA")]
    public partial class OaNatureTrav : ModelBase
    {
        private OaCdTravaux _oaCdTravaux;
        public virtual OaCdTravaux OaCdTravaux 
        {
            get
            {
                return this._oaCdTravaux;
                
            }
            set
            {
                this._oaCdTravaux = value;
                this.CdTravauxOaCode = this._oaCdTravaux.Code;
            }
        }
        
        [Required()]
        [Column("CD_TRAVAUX_OA_ID_PK",Order=0)]
        public Int64 OaCdTravauxIdPk {get;set;}
        
        public virtual ICollection<OaTravaux> OaTravauxs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_OA__CODE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxOaCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String Nature { get; set; }
        
    }
}
