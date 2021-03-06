using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_DVP_VALUES_DS",Schema="DS")]
    public partial class DsSimDvpValues : ModelBase
    {
        private DsSimDvp _dsSimDvp;
        public virtual DsSimDvp DsSimDvp 
        {
            get
            {
                return this._dsSimDvp;
                
            }
            set
            {
                this._dsSimDvp = value;
                this.SimDvpDsId = this._dsSimDvp.Id;
            }
        }
        
        [Required()]
        [Column("SIM_DVP_DS_ID_PK",Order=0)]
        public Int64 DsSimDvpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_DVP_DS__ID")]
        [Column("SIM_DVP_DS__ID",Order=2)]
        [Required()]
        public Int64 SimDvpDsId { get; set; }
        
        [Description("SIM_DVP_VALUES_DS__ANNEE")]
        [Column("ANNEE",Order=3)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("SIM_DVP_VALUES_DS__VALEUR")]
        [Column("VALEUR",Order=4)]
        [Required()]
        public Int64 Valeur { get; set; }
        
    }
}
