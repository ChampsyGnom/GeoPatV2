using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TABLIER_OA",Schema="OA")]
    public partial class OaTablier : ModelBase
    {
        private OaCdChape _oaCdChape;
        public virtual OaCdChape OaCdChape 
        {
            get
            {
                return this._oaCdChape;
                
            }
            set
            {
                this._oaCdChape = value;
                this.CdChapeOaChape = this._oaCdChape.Chape;
            }
        }
        
        [Column("CD_CHAPE_OA_ID_PK",Order=0)]
        public Nullable<Int64> OaCdChapeIdPk {get;set;}
        
        private OaCdTech _oaCdTech;
        public virtual OaCdTech OaCdTech 
        {
            get
            {
                return this._oaCdTech;
                
            }
            set
            {
                this._oaCdTech = value;
                this.CdTechOaTechnique = this._oaCdTech.Technique;
            }
        }
        
        [Column("CD_TECH_OA_ID_PK",Order=1)]
        public Nullable<Int64> OaCdTechIdPk {get;set;}
        
        private OaCdEntp _oaCdEntp;
        public virtual OaCdEntp OaCdEntp 
        {
            get
            {
                return this._oaCdEntp;
                
            }
            set
            {
                this._oaCdEntp = value;
                this.CdEntpOaEntreprise = this._oaCdEntp.Entreprise;
            }
        }
        
        [Column("CD_ENTP_OA_ID_PK",Order=2)]
        public Nullable<Int64> OaCdEntpIdPk {get;set;}
        
        public virtual ICollection<OaJoint> OaJoints { get; set; }
        
        public virtual ICollection<OaEquipement> OaEquipements { get; set; }
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("N° Tablier")]
        [Column("NUM_TAB",Order=5)]
        [Required()]
        public Int64 NumTab { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_OA__ENTREPRISE",Order=6)]
        [MaxLength(60)] 
        public String CdEntpOaEntreprise { get; set; }
        
        [Description("Technique")]
        [Column("CD_TECH_OA__TECHNIQUE",Order=7)]
        [MaxLength(12)] 
        public String CdTechOaTechnique { get; set; }
        
        [Description("Type chape d'étanchéité")]
        [Column("CD_CHAPE_OA__CHAPE",Order=8)]
        [MaxLength(60)] 
        public String CdChapeOaChape { get; set; }
        
        [Description("Date MS chape")]
        [Column("DATE_MS_CHAPE",Order=9)]
        public Nullable<DateTime> DateMsChape { get; set; }
        
        [Description("Surf chape (m²)")]
        [Column("SURF_CHAPE",Order=10)]
        public Nullable<Double> SurfChape { get; set; }
        
        [Description("Epaisseur Chape (cm)")]
        [Column("EPAIS_CHAPE",Order=11)]
        public Nullable<Double> EpaisChape { get; set; }
        
        [Description("Date_MS Enrobé")]
        [Column("DATE_MS_BB",Order=12)]
        public Nullable<DateTime> DateMsBb { get; set; }
        
        [Description("Epaisseur enrobé(cm)")]
        [Column("EPAIS",Order=13)]
        public Nullable<Double> Epais { get; set; }
        
        [Description("Granulométrie")]
        [Column("GRANULO",Order=14)]
        [MaxLength(8)] 
        public String Granulo { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=15)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
