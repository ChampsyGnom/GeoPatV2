using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_OH",Schema="OH")]
    public partial class OhPhotoEltInsp : ModelBase
    {
        private OhEltInsp _ohEltInsp;
        public virtual OhEltInsp OhEltInsp 
        {
            get
            {
                return this._ohEltInsp;
                
            }
            set
            {
                this._ohEltInsp = value;
                this.GrpOhIdGrp = this._ohEltInsp.GrpOhIdGrp;
                this.PrtOhIdPrt = this._ohEltInsp.PrtOhIdPrt;
                this.SprtOhIdSprt = this._ohEltInsp.SprtOhIdSprt;
                this.CampOhIdCamp = this._ohEltInsp.CampOhIdCamp;
                this.EltOhIdElem = this._ohEltInsp.EltOhIdElem;
                this.DscOhNumOh = this._ohEltInsp.DscOhNumOh;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_OH_ID_PK",Order=0)]
        public Int64 OhEltInspIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_OH__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpOhIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_OH__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtOhIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_OH__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtOhIdSprt { get; set; }
        
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("Identifiant élément")]
        [Column("ELT_OH__ID_ELEM",Order=6)]
        [Required()]
        public Int64 EltOhIdElem { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=7)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Identifiant de la photo")]
        [Column("ID",Order=8)]
        [Required()]
        [MaxLength(50)] 
        public String Id { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=9)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
