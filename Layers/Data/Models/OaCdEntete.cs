using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ENTETE_OA",Schema="OA")]
    public partial class OaCdEntete : ModelBase
    {
        private OaCdComposant _oaCdComposant;
        public virtual OaCdComposant OaCdComposant 
        {
            get
            {
                return this._oaCdComposant;
                
            }
            set
            {
                this._oaCdComposant = value;
                this.CdComposantOaTypeComp = this._oaCdComposant.TypeComp;
            }
        }
        
        [Required()]
        [Column("CD_COMPOSANT_OA_ID_PK",Order=0)]
        public Int64 OaCdComposantIdPk {get;set;}
        
        public virtual ICollection<OaEntete> OaEntetes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Entête")]
        [Column("ID_ENTETE",Order=2)]
        [Required()]
        public Int64 IdEntete { get; set; }
        
        [Description("Type")]
        [Column("CD_COMPOSANT_OA__TYPE_COMP",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String CdComposantOaTypeComp { get; set; }
        
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
