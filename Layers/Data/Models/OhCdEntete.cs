using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ENTETE_OH",Schema="OH")]
    public partial class OhCdEntete : ModelBase
    {
        private OhCdComposant _ohCdComposant;
        public virtual OhCdComposant OhCdComposant 
        {
            get
            {
                return this._ohCdComposant;
                
            }
            set
            {
                this._ohCdComposant = value;
                this.CdComposantOhTypeComp = this._ohCdComposant.TypeComp;
            }
        }
        
        [Required()]
        [Column("CD_COMPOSANT_OH_ID_PK",Order=0)]
        public Int64 OhCdComposantIdPk {get;set;}
        
        public virtual ICollection<OhEntete> OhEntetes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Entête")]
        [Column("ID_ENTETE",Order=2)]
        [Required()]
        public Int64 IdEntete { get; set; }
        
        [Description("Type")]
        [Column("CD_COMPOSANT_OH__TYPE_COMP",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String CdComposantOhTypeComp { get; set; }
        
        [Description("Libellé Entête")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
        [Description("N° ordre Entête")]
        [Column("ORDRE_ENT",Order=5)]
        [Required()]
        public Int64 OrdreEnt { get; set; }
        
        [Description("Guide")]
        [Column("GUIDE",Order=6)]
        [MaxLength(500)] 
        public String Guide { get; set; }
        
    }
}
