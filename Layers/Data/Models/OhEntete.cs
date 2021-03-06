using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ENTETE_OH",Schema="OH")]
    public partial class OhEntete : ModelBase
    {
        private OhCdEntete _ohCdEntete;
        public virtual OhCdEntete OhCdEntete 
        {
            get
            {
                return this._ohCdEntete;
                
            }
            set
            {
                this._ohCdEntete = value;
                this.CdEnteteOhIdEntete = this._ohCdEntete.IdEntete;
            }
        }
        
        [Required()]
        [Column("CD_ENTETE_OH_ID_PK",Order=0)]
        public Int64 OhCdEnteteIdPk {get;set;}
        
        private OhVst _ohVst;
        public virtual OhVst OhVst 
        {
            get
            {
                return this._ohVst;
                
            }
            set
            {
                this._ohVst = value;
                this.CampOhIdCamp = this._ohVst.CampOhIdCamp;
                this.DscOhNumOh = this._ohVst.DscOhNumOh;
            }
        }
        
        [Required()]
        [Column("VST_OH_ID_PK",Order=1)]
        public Int64 OhVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Identifiant Entête")]
        [Column("CD_ENTETE_OH__ID_ENTETE",Order=5)]
        [Required()]
        public Int64 CdEnteteOhIdEntete { get; set; }
        
        [Description("Valeur")]
        [Column("VALEUR",Order=6)]
        [MaxLength(250)] 
        public String Valeur { get; set; }
        
    }
}
