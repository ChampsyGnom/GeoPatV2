using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_RESULT_DS",Schema="DS")]
    public partial class DsSimResult : ModelBase
    {
        private DsSimCalculFis _dsSimCalculFis;
        public virtual DsSimCalculFis DsSimCalculFis 
        {
            get
            {
                return this._dsSimCalculFis;
                
            }
            set
            {
                this._dsSimCalculFis = value;
                this.SimCalculTraficDsId = this._dsSimCalculFis.SimCalculTraficDsId;
                this.SimFisDsId = this._dsSimCalculFis.SimFisDsId;
            }
        }
        
        [Required()]
        [Column("SIM_CALCUL_FIS_DS_ID_PK",Order=0)]
        public Int64 DsSimCalculFisIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_CALCUL_TRAFIC_DS__ID")]
        [Column("SIM_CALCUL_TRAFIC_DS__ID",Order=2)]
        [Required()]
        public Int64 SimCalculTraficDsId { get; set; }
        
        [Description("SIM_FIS_DS__ID")]
        [Column("SIM_FIS_DS__ID",Order=3)]
        [Required()]
        public Int64 SimFisDsId { get; set; }
        
        [Description("SIM_RESULT_DS__LIAISON")]
        [Column("LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("SIM_RESULT_DS__SENS")]
        [Column("SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("SIM_RESULT_DS__ABS_DEB")]
        [Column("ABS_DEB",Order=6)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("SIM_RESULT_DS__ANNEE")]
        [Column("ANNEE",Order=7)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("SIM_RESULT_DS__ABS_FIN")]
        [Column("ABS_FIN",Order=8)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("SIM_RESULT_DS__DVP")]
        [Column("DVR",Order=9)]
        [Required()]
        public Int64 Dvr { get; set; }
        
        [Description("SIM_RESULT_DS__FIS")]
        [Column("FIS",Order=10)]
        [Required()]
        public Int64 Fis { get; set; }
        
        [Description("SIM_RESULT_DS__LINEAIRE")]
        [Column("LINEAIRE",Order=11)]
        [Required()]
        public Int64 Lineaire { get; set; }
        
        [Description("SIM_RESULT_DS__SURFACE")]
        [Column("SURFACE",Order=12)]
        [Required()]
        public Int64 Surface { get; set; }
        
        [Description("SIM_RESULT_DS__EPAISSEUR")]
        [Column("EPAISSEUR",Order=13)]
        [Required()]
        public Int64 Epaisseur { get; set; }
        
    }
}
