using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_GOT",Schema="GOT")]
    public partial class GotPhotoEltInsp : ModelBase
    {
        private GotEltInsp _gotEltInsp;
        public virtual GotEltInsp GotEltInsp 
        {
            get
            {
                return this._gotEltInsp;
                
            }
            set
            {
                this._gotEltInsp = value;
                this.GrpGotIdGrp = this._gotEltInsp.GrpGotIdGrp;
                this.PrtGotIdPrt = this._gotEltInsp.PrtGotIdPrt;
                this.DscGotNumGot = this._gotEltInsp.DscGotNumGot;
                this.CampGotIdCamp = this._gotEltInsp.CampGotIdCamp;
                this.SprtGotIdSprt = this._gotEltInsp.SprtGotIdSprt;
                this.EltGotIdElem = this._gotEltInsp.EltGotIdElem;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_GOT_ID_PK",Order=0)]
        public Int64 GotEltInspIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_GOT__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpGotIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GOT__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtGotIdPrt { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("Identifiant sous partie")]
        [Column("SPRT_GOT__ID_SPRT",Order=6)]
        [Required()]
        public Int64 SprtGotIdSprt { get; set; }
        
        [Description("Identifiant Elément")]
        [Column("ELT_GOT__ID_ELEM",Order=7)]
        [Required()]
        public Int64 EltGotIdElem { get; set; }
        
        [Description("Identifiant")]
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
