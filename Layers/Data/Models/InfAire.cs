using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("AIRE_INF",Schema="INF")]
    public partial class InfAire : ModelBase
    {
        public virtual InfCdAire InfCdAire {get;set;}
        
        public virtual InfChaussee InfChaussee {get;set;}
        
        public virtual ICollection<InfAirePrestataire> InfAirePrestataires { get; set; }
        
        public virtual ICollection<InfAireService> InfAireServices { get; set; }
        
        public virtual ICollection<InfAirePlace> InfAirePlaces { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Aire")]
        [Column("CD_AIRE_INF__TYPE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String CdAireInfType { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=2)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=3)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("N° Exploitation")]
        [Column("NUM_EXPLOIT",Order=4)]
        [MaxLength(15)] 
        public String NumExploit { get; set; }
        
        [Description("Nom d'usage")]
        [Column("NOM",Order=5)]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=6)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Passerelle")]
        [Column("PASSERELLE",Order=7)]
        public Nullable<int> PasserelleValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Passerelle 
        {
            get
            {
                if (PasserelleValueInt.HasValue) return Convert.ToBoolean(PasserelleValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PasserelleValueInt = Convert.ToInt32(value.Value);}
                else {this.PasserelleValueInt =null;}
            }
        }
        
        [Description("Demi tour")]
        [Column("DEMI_TOUR",Order=8)]
        public Nullable<int> DemiTourValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> DemiTour 
        {
            get
            {
                if (DemiTourValueInt.HasValue) return Convert.ToBoolean(DemiTourValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.DemiTourValueInt = Convert.ToInt32(value.Value);}
                else {this.DemiTourValueInt =null;}
            }
        }
        
        [Description("Bilatérale")]
        [Column("BILATERALE",Order=9)]
        public Nullable<int> BilateraleValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Bilaterale 
        {
            get
            {
                if (BilateraleValueInt.HasValue) return Convert.ToBoolean(BilateraleValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.BilateraleValueInt = Convert.ToInt32(value.Value);}
                else {this.BilateraleValueInt =null;}
            }
        }
        
        [Description("Commentaires")]
        [Column("OBSERV",Order=10)]
        [MaxLength(250)] 
        public String Observ { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=11)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=12)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=13)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=14)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=15)]
        public Nullable<int> TerrainValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Terrain 
        {
            get
            {
                if (TerrainValueInt.HasValue) return Convert.ToBoolean(TerrainValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.TerrainValueInt = Convert.ToInt32(value.Value);}
                else {this.TerrainValueInt =null;}
            }
        }
        
    }
}
