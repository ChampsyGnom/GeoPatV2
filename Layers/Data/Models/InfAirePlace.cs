using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("AIRE__PLACE_INF",Schema="INF")]
    public partial class InfAirePlace : ModelBase
    {
        private InfCdPlace _infCdPlace;
        public virtual InfCdPlace InfCdPlace 
        {
            get
            {
                return this._infCdPlace;
                
            }
            set
            {
                this._infCdPlace = value;
                this.CdPlaceInfParking = this._infCdPlace.Parking;
            }
        }
        
        [Required()]
        [Column("CD_PLACE_INF_ID_PK",Order=0)]
        public Int64 InfCdPlaceIdPk {get;set;}
        
        private InfAire _infAire;
        public virtual InfAire InfAire 
        {
            get
            {
                return this._infAire;
                
            }
            set
            {
                this._infAire = value;
                this.LiaisonInfLiaison = this._infAire.LiaisonInfLiaison;
                this.CdAireInfType = this._infAire.CdAireInfType;
                this.ChausseeInfSens = this._infAire.ChausseeInfSens;
                this.AireInfAbsDeb = this._infAire.AbsDeb;
            }
        }
        
        [Required()]
        [Column("AIRE_INF_ID_PK",Order=1)]
        public Int64 InfAireIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Parking")]
        [Column("CD_PLACE_INF__PARKING",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String CdPlaceInfParking { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Type Aire")]
        [Column("CD_AIRE_INF__TYPE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdAireInfType { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=6)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("AIRE_INF__ABS_DEB",Order=7)]
        [Required()]
        public Int64 AireInfAbsDeb { get; set; }
        
        [Description("Nbre de place")]
        [Column("NBRE",Order=8)]
        public Nullable<Int64> Nbre { get; set; }
        
    }
}
