using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_FIS_DS",Schema="DS")]
    public partial class DsSimFis : ModelBase
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
        
        public virtual ICollection<DsSimFisClasse> DsSimFisClasses { get; set; }
        
        public virtual ICollection<DsSimCalculFis> DsSimCalculFiss { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_FIS_DS__ID")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("SIM_ETUDE_DS__ID")]
        [Column("SIM_ETUDE_DS__ID",Order=3)]
        [Required()]
        public Int64 SimEtudeDsId { get; set; }
        
        [Description("SIM_FIS_DS__LIBELLE")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("SIM_FIS_DS__COULEUR")]
        [Column("COULEUR",Order=5)]
        [Required()]
        [MaxLength(12)] 
        public String Couleur { get; set; }
        
    }
}
