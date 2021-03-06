using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SEUIL_QUALITE_GMS",Schema="GMS")]
    public partial class GmsSeuilQualite : ModelBase
    {
        private GmsCdQualite _gmsCdQualite;
        public virtual GmsCdQualite GmsCdQualite 
        {
            get
            {
                return this._gmsCdQualite;
                
            }
            set
            {
                this._gmsCdQualite = value;
                this.CdQualiteGmsQualite = this._gmsCdQualite.Qualite;
            }
        }
        
        [Required()]
        [Column("CD_QUALITE_GMS_ID_PK",Order=0)]
        public Int64 GmsCdQualiteIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Niveau qualité")]
        [Column("CD_QUALITE_GMS__QUALITE",Order=2)]
        [Required()]
        [MaxLength(25)] 
        public String CdQualiteGmsQualite { get; set; }
        
        [Description("Indice urgence")]
        [Column("INDICE_URGENCE",Order=3)]
        [Required()]
        [MaxLength(5)] 
        public String IndiceUrgence { get; set; }
        
    }
}
