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
        private InfCdAire _infCdAire;
        public virtual InfCdAire InfCdAire 
        {
            get
            {
                return this._infCdAire;
                
            }
            set
            {
                this._infCdAire = value;
                this.CdAireInfType = this._infCdAire.Type;
            }
        }
        
        [Required()]
        [Column("CD_AIRE_INF_ID_PK",Order=0)]
        public Int64 InfCdAireIdPk {get;set;}
        
        private InfChaussee _infChaussee;
        public virtual InfChaussee InfChaussee 
        {
            get
            {
                return this._infChaussee;
                
            }
            set
            {
                this._infChaussee = value;
                this.LiaisonInfLiaison = this._infChaussee.LiaisonInfLiaison;
                this.ChausseeInfSens = this._infChaussee.Sens;
            }
        }
        
        [Required()]
        [Column("CHAUSSEE_INF_ID_PK",Order=1)]
        public Int64 InfChausseeIdPk {get;set;}
        
        public virtual ICollection<InfAirePrestataire> InfAirePrestataires { get; set; }
        
        public virtual ICollection<InfAireService> InfAireServices { get; set; }
        
        public virtual ICollection<InfAirePlace> InfAirePlaces { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Aire")]
        [Column("CD_AIRE_INF__TYPE",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String CdAireInfType { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=6)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("N° Exploitation")]
        [Column("NUM_EXPLOIT",Order=7)]
        [MaxLength(15)] 
        public String NumExploit { get; set; }
        
        [Description("Nom d'usage")]
        [Column("NOM",Order=8)]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=9)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Passerelle")]
        [Column("PASSERELLE",Order=10)]
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
        [Column("DEMI_TOUR",Order=11)]
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
        [Column("BILATERALE",Order=12)]
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
        [Column("OBSERV",Order=13)]
        [MaxLength(250)] 
        public String Observ { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=14)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=15)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=16)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=17)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=18)]
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
