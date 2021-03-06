using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("AMENAGEMENT_INF",Schema="INF")]
    public partial class InfAmenagement : ModelBase
    {
        private InfCdAmenag _infCdAmenag;
        public virtual InfCdAmenag InfCdAmenag 
        {
            get
            {
                return this._infCdAmenag;
                
            }
            set
            {
                this._infCdAmenag = value;
                this.CdAmenagInfTypeAmenag = this._infCdAmenag.TypeAmenag;
            }
        }
        
        [Required()]
        [Column("CD_AMENAG_INF_ID_PK",Order=0)]
        public Int64 InfCdAmenagIdPk {get;set;}
        
        private InfChaussee _infChaussee;
        public virtual InfChaussee InfChaussee 
        {
            get
            {
                return this._infChaussee;
                
            }
            set
            {
                this._infChaussee = value;
                this.LiaisonInfLiaison = this._infChaussee.LiaisonInfLiaison;
                this.ChausseeInfSens = this._infChaussee.Sens;
            }
        }
        
        [Required()]
        [Column("CHAUSSEE_INF_ID_PK",Order=1)]
        public Int64 InfChausseeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Aménagement")]
        [Column("CD_AMENAG_INF__TYPE_AMENAG",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String CdAmenagInfTypeAmenag { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Date début")]
        [Column("DATE_DEB",Order=6)]
        [Required()]
        public DateTime DateDeb { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=7)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Date Fin")]
        [Column("DATE_FIN",Order=8)]
        public Nullable<DateTime> DateFin { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=9)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Coûts (k€)")]
        [Column("COUT",Order=10)]
        public Nullable<Int64> Cout { get; set; }
        
        [Description("Commentaire")]
        [Column("OBSERV",Order=11)]
        [MaxLength(255)] 
        public String Observ { get; set; }
        
    }
}
