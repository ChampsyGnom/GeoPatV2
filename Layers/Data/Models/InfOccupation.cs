using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("OCCUPATION_INF",Schema="INF")]
    public partial class InfOccupation : ModelBase
    {
        private InfCdOccup _infCdOccup;
        public virtual InfCdOccup InfCdOccup 
        {
            get
            {
                return this._infCdOccup;
                
            }
            set
            {
                this._infCdOccup = value;
                this.CdOccupInfType = this._infCdOccup.Type;
            }
        }
        
        [Required()]
        [Column("CD_OCCUP_INF_ID_PK",Order=0)]
        public Int64 InfCdOccupIdPk {get;set;}
        
        private InfCdOccupant _infCdOccupant;
        public virtual InfCdOccupant InfCdOccupant 
        {
            get
            {
                return this._infCdOccupant;
                
            }
            set
            {
                this._infCdOccupant = value;
                this.CdOccupantInfNom = this._infCdOccupant.Nom;
            }
        }
        
        [Required()]
        [Column("CD_OCCUPANT_INF_ID_PK",Order=1)]
        public Int64 InfCdOccupantIdPk {get;set;}
        
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
        [Column("CHAUSSEE_INF_ID_PK",Order=2)]
        public Int64 InfChausseeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Occupation")]
        [Column("CD_OCCUP_INF__TYPE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String CdOccupInfType { get; set; }
        
        [Description("Nom")]
        [Column("CD_OCCUPANT_INF__NOM",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdOccupantInfNom { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=6)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=7)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=8)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=9)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date Début")]
        [Column("DATE_MS",Order=10)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Date Fin")]
        [Column("DATE_FV",Order=11)]
        public Nullable<DateTime> DateFv { get; set; }
        
        [Description("Traversé")]
        [Column("TRAV",Order=12)]
        public Nullable<int> TravValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Trav 
        {
            get
            {
                if (TravValueInt.HasValue) return Convert.ToBoolean(TravValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.TravValueInt = Convert.ToInt32(value.Value);}
                else {this.TravValueInt =null;}
            }
        }
        
        [Description("Commentaire")]
        [Column("OBS",Order=13)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
