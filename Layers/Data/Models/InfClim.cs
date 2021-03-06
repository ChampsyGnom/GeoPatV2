using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLIM_INF",Schema="INF")]
    public partial class InfClim : ModelBase
    {
        private InfCdClim _infCdClim;
        public virtual InfCdClim InfCdClim 
        {
            get
            {
                return this._infCdClim;
                
            }
            set
            {
                this._infCdClim = value;
                this.CdClimInfCode = this._infCdClim.Code;
            }
        }
        
        [Required()]
        [Column("CD_CLIM_INF_ID_PK",Order=0)]
        public Int64 InfCdClimIdPk {get;set;}
        
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
        [Description("Type Climat")]
        [Column("CD_CLIM_INF__CODE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdClimInfCode { get; set; }
        
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
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=7)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=8)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
