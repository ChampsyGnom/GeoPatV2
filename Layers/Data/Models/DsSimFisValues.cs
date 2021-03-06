using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_FIS_VALUES_DS",Schema="DS")]
    public partial class DsSimFisValues : ModelBase
    {
        private DsSimFisClasse _dsSimFisClasse;
        public virtual DsSimFisClasse DsSimFisClasse 
        {
            get
            {
                return this._dsSimFisClasse;
                
            }
            set
            {
                this._dsSimFisClasse = value;
                this.SimFisDsId = this._dsSimFisClasse.SimFisDsId;
                this.SimFisClasseDsId = this._dsSimFisClasse.Id;
            }
        }
        
        [Required()]
        [Column("SIM_FIS_CLASSE_DS_ID_PK",Order=0)]
        public Int64 DsSimFisClasseIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_FIS_DS__ID")]
        [Column("SIM_FIS_DS__ID",Order=2)]
        [Required()]
        public Int64 SimFisDsId { get; set; }
        
        [Description("SIM_FIS_CLASSE_DS__ID")]
        [Column("SIM_FIS_CLASSE_DS__ID",Order=3)]
        [Required()]
        public Int64 SimFisClasseDsId { get; set; }
        
        [Description("SIM_FIS_VALUES_DS__ANNEE")]
        [Column("ANNEE",Order=4)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("SIM_FIS_VALUES_DS__VALEUR")]
        [Column("VALEUR",Order=5)]
        [Required()]
        public Int64 Valeur { get; set; }
        
    }
}
