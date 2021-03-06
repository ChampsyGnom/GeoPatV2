using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PRESTATAIRE_INF",Schema="INF")]
    public partial class InfPrestataire : ModelBase
    {
        private InfCdPrestataire _infCdPrestataire;
        public virtual InfCdPrestataire InfCdPrestataire 
        {
            get
            {
                return this._infCdPrestataire;
                
            }
            set
            {
                this._infCdPrestataire = value;
                this.CdPrestataireInfType = this._infCdPrestataire.Type;
            }
        }
        
        [Required()]
        [Column("CD_PRESTATAIRE_INF_ID_PK",Order=0)]
        public Int64 InfCdPrestataireIdPk {get;set;}
        
        public virtual ICollection<InfAirePrestataire> InfAirePrestataires { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Prestataire")]
        [Column("CD_PRESTATAIRE_INF__TYPE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdPrestataireInfType { get; set; }
        
        [Description("Enseigne")]
        [Column("NOM",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
    }
}
