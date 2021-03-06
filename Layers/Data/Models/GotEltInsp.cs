using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_INSP_GOT",Schema="GOT")]
    public partial class GotEltInsp : ModelBase
    {
        private GotInsp _gotInsp;
        public virtual GotInsp GotInsp 
        {
            get
            {
                return this._gotInsp;
                
            }
            set
            {
                this._gotInsp = value;
                this.DscGotNumGot = this._gotInsp.DscGotNumGot;
                this.CampGotIdCamp = this._gotInsp.CampGotIdCamp;
            }
        }
        
        [Required()]
        [Column("INSP_GOT_ID_PK",Order=0)]
        public Int64 GotInspIdPk {get;set;}
        
        private GotElt _gotElt;
        public virtual GotElt GotElt 
        {
            get
            {
                return this._gotElt;
                
            }
            set
            {
                this._gotElt = value;
                this.GrpGotIdGrp = this._gotElt.GrpGotIdGrp;
                this.PrtGotIdPrt = this._gotElt.PrtGotIdPrt;
                this.SprtGotIdSprt = this._gotElt.SprtGotIdSprt;
                this.EltGotIdElem = this._gotElt.IdElem;
            }
        }
        
        [Required()]
        [Column("ELT_GOT_ID_PK",Order=1)]
        public Int64 GotEltIdPk {get;set;}
        
        public virtual ICollection<GotPhotoEltInsp> GotPhotoEltInsps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=3)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("Identifiant Groupe")]
        [Column("GRP_GOT__ID_GRP",Order=5)]
        [Required()]
        public Int64 GrpGotIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GOT__ID_PRT",Order=6)]
        [Required()]
        public Int64 PrtGotIdPrt { get; set; }
        
        [Description("Identifiant sous partie")]
        [Column("SPRT_GOT__ID_SPRT",Order=7)]
        [Required()]
        public Int64 SprtGotIdSprt { get; set; }
        
        [Description("Identifiant Elément")]
        [Column("ELT_GOT__ID_ELEM",Order=8)]
        [Required()]
        public Int64 EltGotIdElem { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=9)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=10)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
