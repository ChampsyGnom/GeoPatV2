using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("GARE_INF",Schema="INF")]
    public partial class InfGare : ModelBase
    {
        private InfCdGare _infCdGare;
        public virtual InfCdGare InfCdGare 
        {
            get
            {
                return this._infCdGare;
                
            }
            set
            {
                this._infCdGare = value;
                this.CdGareInfType = this._infCdGare.Type;
            }
        }
        
        [Required()]
        [Column("CD_GARE_INF_ID_PK",Order=0)]
        public Int64 InfCdGareIdPk {get;set;}
        
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
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Gare")]
        [Column("CD_GARE_INF__TYPE",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String CdGareInfType { get; set; }
        
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
        
        [Description("Pr")]
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
        
        [Description("Nbr Voies Entrée")]
        [Column("VOI_ENTREE",Order=10)]
        public Nullable<Int64> VoiEntree { get; set; }
        
        [Description("Nbr Voies Sortie")]
        [Column("VOI_SORTIE",Order=11)]
        public Nullable<Int64> VoiSortie { get; set; }
        
        [Description("Nbr Voies Mixte")]
        [Column("VOI_MIXTE",Order=12)]
        public Nullable<Int64> VoiMixte { get; set; }
        
        [Description("Nbr Voies TSA")]
        [Column("VOI_TSA",Order=13)]
        public Nullable<Int64> VoiTsa { get; set; }
        
        [Description("Commentaire")]
        [Column("OBSERV",Order=14)]
        [MaxLength(250)] 
        public String Observ { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=15)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=16)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=17)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=18)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=19)]
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
