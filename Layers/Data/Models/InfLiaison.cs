using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("LIAISON_INF",Schema="INF")]
    public partial class InfLiaison : ModelBase
    {
        private InfCdLiaison _infCdLiaison;
        public virtual InfCdLiaison InfCdLiaison 
        {
            get
            {
                return this._infCdLiaison;
                
            }
            set
            {
                this._infCdLiaison = value;
                this.CdLiaisonInfCdLiaison = this._infCdLiaison.CdLiaison;
            }
        }
        
        [Required()]
        [Column("CD_LIAISON_INF_ID_PK",Order=0)]
        public Int64 InfCdLiaisonIdPk {get;set;}
        
        public virtual ICollection<InfChaussee> InfChaussees { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON",Order=2)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Code")]
        [Column("CD_LIAISON_INF__CD_LIAISON",Order=3)]
        [Required()]
        [MaxLength(5)] 
        public String CdLiaisonInfCdLiaison { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
