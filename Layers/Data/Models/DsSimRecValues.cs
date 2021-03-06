using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_REC_VALUES_DS",Schema="DS")]
    public partial class DsSimRecValues : ModelBase
    {
        private DsSimRec _dsSimRec;
        public virtual DsSimRec DsSimRec 
        {
            get
            {
                return this._dsSimRec;
                
            }
            set
            {
                this._dsSimRec = value;
                this.SimRecDsId = this._dsSimRec.Id;
            }
        }
        
        [Required()]
        [Column("SIM_REC_DS_ID_PK",Order=0)]
        public Int64 DsSimRecIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_REC_DS__ID")]
        [Column("SIM_REC_DS__ID",Order=2)]
        [Required()]
        public Int64 SimRecDsId { get; set; }
        
        [Description("SIM_REC_VALUES_DS__ANNEE")]
        [Column("ANNEE",Order=3)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("SIM_REC_VALUES_DS__VALEUR")]
        [Column("VALEUR",Order=4)]
        [Required()]
        public Int64 Valeur { get; set; }
        
    }
}
