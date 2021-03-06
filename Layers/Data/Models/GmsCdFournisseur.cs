using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FOURNISSEUR_GMS",Schema="GMS")]
    public partial class GmsCdFournisseur : ModelBase
    {
        public virtual ICollection<GmsPanneau> GmsPanneaus { get; set; }
        
        public virtual ICollection<GmsDsc> GmsDscs { get; set; }
        
        public virtual ICollection<GmsDscTemp> GmsDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Fournisseur")]
        [Column("NOM",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
    }
}
