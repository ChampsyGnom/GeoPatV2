using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ENTETE_GOT",Schema="GOT")]
    public partial class GotCdEntete : ModelBase
    {
        private GotCdComposant _gotCdComposant;
        public virtual GotCdComposant GotCdComposant 
        {
            get
            {
                return this._gotCdComposant;
                
            }
            set
            {
                this._gotCdComposant = value;
                this.CdComposantGotTypeComp = this._gotCdComposant.TypeComp;
            }
        }
        
        [Required()]
        [Column("CD_COMPOSANT_GOT_ID_PK",Order=0)]
        public Int64 GotCdComposantIdPk {get;set;}
        
        public virtual ICollection<GotEntete> GotEntetes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Entête")]
        [Column("ID_ENTETE",Order=2)]
        [Required()]
        public Int64 IdEntete { get; set; }
        
        [Description("Type")]
        [Column("CD_COMPOSANT_GOT__TYPE_COMP",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String CdComposantGotTypeComp { get; set; }
        
        [Description("Ligne d'entête")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
        [Description("Ordre")]
        [Column("ORDRE_ENT",Order=5)]
        [Required()]
        public Int64 OrdreEnt { get; set; }
        
        [Description("Guide")]
        [Column("GUIDE",Order=6)]
        [MaxLength(500)] 
        public String Guide { get; set; }
        
    }
}
