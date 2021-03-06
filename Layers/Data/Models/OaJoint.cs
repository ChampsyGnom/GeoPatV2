using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("JOINT_OA",Schema="OA")]
    public partial class OaJoint : ModelBase
    {
        private OaTablier _oaTablier;
        public virtual OaTablier OaTablier 
        {
            get
            {
                return this._oaTablier;
                
            }
            set
            {
                this._oaTablier = value;
                this.DscOaNumOa = this._oaTablier.DscOaNumOa;
                this.TablierOaNumTab = this._oaTablier.NumTab;
            }
        }
        
        [Required()]
        [Column("TABLIER_OA_ID_PK",Order=0)]
        public Int64 OaTablierIdPk {get;set;}
        
        private OaCdJoint _oaCdJoint;
        public virtual OaCdJoint OaCdJoint 
        {
            get
            {
                return this._oaCdJoint;
                
            }
            set
            {
                this._oaCdJoint = value;
                this.CdJointOaType = this._oaCdJoint.Type;
            }
        }
        
        [Required()]
        [Column("CD_JOINT_OA_ID_PK",Order=1)]
        public Int64 OaCdJointIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("N° Tablier")]
        [Column("TABLIER_OA__NUM_TAB",Order=4)]
        [Required()]
        public Int64 TablierOaNumTab { get; set; }
        
        [Description("N° joint")]
        [Column("NUM_JOINT",Order=5)]
        [Required()]
        public Int64 NumJoint { get; set; }
        
        [Description("Joint")]
        [Column("CD_JOINT_OA__TYPE",Order=6)]
        [Required()]
        [MaxLength(60)] 
        public String CdJointOaType { get; set; }
        
        [Description("Date de MS")]
        [Column("DATE_MS",Order=7)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Longueur joint")]
        [Column("LONGUEUR",Order=8)]
        public Nullable<Double> Longueur { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=9)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
