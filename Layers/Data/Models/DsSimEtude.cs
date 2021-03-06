using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_ETUDE_DS",Schema="DS")]
    public partial class DsSimEtude : ModelBase
    {
        public virtual ICollection<DsSimFis> DsSimFiss { get; set; }
        
        public virtual ICollection<DsSimDvp> DsSimDvps { get; set; }
        
        public virtual ICollection<DsSimRec> DsSimRecs { get; set; }
        
        public virtual ICollection<DsSimEntretien> DsSimEntretiens { get; set; }
        
        public virtual ICollection<DsSimCalcul> DsSimCalculs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_ETUDE_DS__ID")]
        [Column("ID",Order=1)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("SIM_ETUDE_DS__LIBELLE")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("SIM_ETUDE_DS__ANNEE_MIN")]
        [Column("ANNEE_MIN",Order=3)]
        [Required()]
        public Int64 AnneeMin { get; set; }
        
        [Description("SIM_ETUDE_DS__ANNEE_MAX")]
        [Column("ANNEE_MAX",Order=4)]
        [Required()]
        public Int64 AnneeMax { get; set; }
        
        [Description("SIM_ETUDE_DS__ANNEE_MIN_CALCUL")]
        [Column("ANNEE_MIN_CALCUL",Order=5)]
        [Required()]
        public Int64 AnneeMinCalcul { get; set; }
        
        [Description("SIM_ETUDE_DS__ANNEE_MAX_CALCUL")]
        [Column("ANNEE_MAX_CALCUL",Order=6)]
        [Required()]
        public Int64 AnneeMaxCalcul { get; set; }
        
    }
}
