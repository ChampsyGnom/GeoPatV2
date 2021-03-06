using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_CALCUL_DS",Schema="DS")]
    public partial class DsSimCalcul : ModelBase
    {
        private DsSimEtude _dsSimEtude;
        public virtual DsSimEtude DsSimEtude 
        {
            get
            {
                return this._dsSimEtude;
                
            }
            set
            {
                this._dsSimEtude = value;
                this.SimEtudeDsId = this._dsSimEtude.Id;
            }
        }
        
        [Required()]
        [Column("SIM_ETUDE_DS_ID_PK",Order=0)]
        public Int64 DsSimEtudeIdPk {get;set;}
        
        public virtual ICollection<DsSimCalculTrafic> DsSimCalculTrafics { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_CALCUL_DS__ID")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("SIM_ETUDE_DS__ID")]
        [Column("SIM_ETUDE_DS__ID",Order=3)]
        [Required()]
        public Int64 SimEtudeDsId { get; set; }
        
        [Description("SIM_CALCUL_DS__LIBELLE")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("SIM_CALCUL_DS__COMMENT")]
        [Column("COMMENT",Order=5)]
        [MaxLength(2000)] 
        public String Comment { get; set; }
        
    }
}
