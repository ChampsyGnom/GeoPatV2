using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CHAUSSEE_INF",Schema="INF")]
    public partial class InfChaussee
    {
        public virtual InfLiaison InfLiaison {get;set;}
        
        public virtual ICollection<InfPtSing> InfPtSings { get; set; }
        
        public virtual ICollection<InfTrDec> InfTrDecs { get; set; }
        
        public virtual ICollection<InfRepere> InfReperes { get; set; }
        
        public virtual ICollection<InfPrevSge> InfPrevSges { get; set; }
        
        public virtual ICollection<InfPk> InfPks { get; set; }
        
        public virtual ICollection<InfTpc> InfTpcs { get; set; }
        
        public virtual ICollection<InfPrOld> InfPrOlds { get; set; }
        
        public virtual ICollection<InfSensible> InfSensibles { get; set; }
        
        public virtual ICollection<InfClim> InfClims { get; set; }
        
        public virtual ICollection<InfAmenagement> InfAmenagements { get; set; }
        
        public virtual ICollection<InfAccident> InfAccidents { get; set; }
        
        public virtual ICollection<InfCorrespondance> InfCorrespondances { get; set; }
        
        public virtual ICollection<InfSecurite> InfSecurites { get; set; }
        
        public virtual ICollection<InfOccupation> InfOccupations { get; set; }
        
        public virtual ICollection<InfEclairage> InfEclairages { get; set; }
        
        public virtual ICollection<InfTalus> InfTaluss { get; set; }
        
        public virtual ICollection<InfClVoie> InfClVoies { get; set; }
        
        public virtual ICollection<InfTrafic> InfTrafics { get; set; }
        
        public virtual ICollection<InfPaveVoie> InfPaveVoies { get; set; }
        
        public virtual ICollection<InfSectionTrafic> InfSectionTrafics { get; set; }
        
        public virtual ICollection<InfRepartitionTrafic> InfRepartitionTrafics { get; set; }
        
        public virtual ICollection<InfGare> InfGares { get; set; }
        
        public virtual ICollection<InfAire> InfAires { get; set; }
        
        public virtual ICollection<InfBifurcation> InfBifurcations { get; set; }
        
        public virtual ICollection<InfBretelle> InfBretelles { get; set; }
        
        [Key]
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=0)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Key]
        [Description("Sens")]
        [Column("SENS",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=2)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=3)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Tenant")]
        [Column("TENANT",Order=5)]
        [MaxLength(60)] 
        public String Tenant { get; set; }
        
        [Description("Aboutissant")]
        [Column("ABOUT",Order=6)]
        [MaxLength(60)] 
        public String About { get; set; }
        
    }
}
