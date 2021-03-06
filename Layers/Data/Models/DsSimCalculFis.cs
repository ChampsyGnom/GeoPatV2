using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_CALCUL_FIS_DS",Schema="DS")]
    public partial class DsSimCalculFis : ModelBase
    {
        private DsSimCalculTrafic _dsSimCalculTrafic;
        public virtual DsSimCalculTrafic DsSimCalculTrafic 
        {
            get
            {
                return this._dsSimCalculTrafic;
                
            }
            set
            {
                this._dsSimCalculTrafic = value;
                this.SimCalculTraficDsId = this._dsSimCalculTrafic.Id;
            }
        }
        
        [Required()]
        [Column("SIM_CALCUL_TRAFIC_DS_ID_PK",Order=0)]
        public Int64 DsSimCalculTraficIdPk {get;set;}
        
        private DsSimFis _dsSimFis;
        public virtual DsSimFis DsSimFis 
        {
            get
            {
                return this._dsSimFis;
                
            }
            set
            {
                this._dsSimFis = value;
                this.SimFisDsId = this._dsSimFis.Id;
            }
        }
        
        [Required()]
        [Column("SIM_FIS_DS_ID_PK",Order=1)]
        public Int64 DsSimFisIdPk {get;set;}
        
        public virtual ICollection<DsSimResult> DsSimResults { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_CALCUL_TRAFIC_DS__ID")]
        [Column("SIM_CALCUL_TRAFIC_DS__ID",Order=3)]
        [Required()]
        public Int64 SimCalculTraficDsId { get; set; }
        
        [Description("SIM_FIS_DS__ID")]
        [Column("SIM_FIS_DS__ID",Order=4)]
        [Required()]
        public Int64 SimFisDsId { get; set; }
        
    }
}
