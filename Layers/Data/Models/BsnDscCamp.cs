using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_CAMP_BSN",Schema="BSN")]
    public partial class BsnDscCamp : ModelBase
    {
        private BsnDsc _bsnDsc;
        public virtual BsnDsc BsnDsc 
        {
            get
            {
                return this._bsnDsc;
                
            }
            set
            {
                this._bsnDsc = value;
                this.DscBsnNumBsn = this._bsnDsc.NumBsn;
            }
        }
        
        [Required()]
        [Column("DSC_BSN_ID_PK",Order=0)]
        public Int64 BsnDscIdPk {get;set;}
        
        private BsnCamp _bsnCamp;
        public virtual BsnCamp BsnCamp 
        {
            get
            {
                return this._bsnCamp;
                
            }
            set
            {
                this._bsnCamp = value;
                this.CampBsnIdCamp = this._bsnCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_BSN_ID_PK",Order=1)]
        public Int64 BsnCampIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("Contrôle Réalisé")]
        [Column("REALISER",Order=5)]
        public Nullable<int> RealiserValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Realiser 
        {
            get
            {
                if (RealiserValueInt.HasValue) return Convert.ToBoolean(RealiserValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RealiserValueInt = Convert.ToInt32(value.Value);}
                else {this.RealiserValueInt =null;}
            }
        }
        
    }
}
