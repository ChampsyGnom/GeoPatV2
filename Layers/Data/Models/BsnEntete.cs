using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ENTETE_BSN",Schema="BSN")]
    public partial class BsnEntete : ModelBase
    {
        private BsnCdEntete _bsnCdEntete;
        public virtual BsnCdEntete BsnCdEntete 
        {
            get
            {
                return this._bsnCdEntete;
                
            }
            set
            {
                this._bsnCdEntete = value;
                this.CdEnteteBsnIdEntete = this._bsnCdEntete.IdEntete;
            }
        }
        
        [Required()]
        [Column("CD_ENTETE_BSN_ID_PK",Order=0)]
        public Int64 BsnCdEnteteIdPk {get;set;}
        
        private BsnVst _bsnVst;
        public virtual BsnVst BsnVst 
        {
            get
            {
                return this._bsnVst;
                
            }
            set
            {
                this._bsnVst = value;
                this.CampBsnIdCamp = this._bsnVst.CampBsnIdCamp;
                this.DscBsnNumBsn = this._bsnVst.DscBsnNumBsn;
            }
        }
        
        [Required()]
        [Column("VST_BSN_ID_PK",Order=1)]
        public Int64 BsnVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identifiant Entête")]
        [Column("CD_ENTETE_BSN__ID_ENTETE",Order=5)]
        [Required()]
        public Int64 CdEnteteBsnIdEntete { get; set; }
        
        [Description("Valeur")]
        [Column("VALEUR",Order=6)]
        [MaxLength(250)] 
        public String Valeur { get; set; }
        
    }
}
