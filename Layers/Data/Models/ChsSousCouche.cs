using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SOUS_COUCHE_CHS",Schema="CHS")]
    public partial class ChsSousCouche : ModelBase
    {
        private ChsPave _chsPave;
        public virtual ChsPave ChsPave 
        {
            get
            {
                return this._chsPave;
                
            }
            set
            {
                this._chsPave = value;
                this.CdCouChsCouche = this._chsPave.CdCouChsCouche;
                this.PaveChsDateMs = this._chsPave.DateMs;
                this.PaveChsLiaison = this._chsPave.Liaison;
                this.PaveChsSens = this._chsPave.Sens;
                this.PaveChsAbsDeb = this._chsPave.AbsDeb;
                this.PaveChsAbsFin = this._chsPave.AbsFin;
            }
        }
        
        [Required()]
        [Column("PAVE_CHS_ID_PK",Order=0)]
        public Int64 ChsPaveIdPk {get;set;}
        
        private ChsCdTech _chsCdTech;
        public virtual ChsCdTech ChsCdTech 
        {
            get
            {
                return this._chsCdTech;
                
            }
            set
            {
                this._chsCdTech = value;
                this.CdFamTechChsCode = this._chsCdTech.CdFamTechChsCode;
                this.CdTechChsTechnique = this._chsCdTech.Technique;
            }
        }
        
        [Required()]
        [Column("CD_TECH_CHS_ID_PK",Order=1)]
        public Int64 ChsCdTechIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Couche")]
        [Column("CD_COU_CHS__COUCHE",Order=3)]
        [Required()]
        [MaxLength(14)] 
        public String CdCouChsCouche { get; set; }
        
        [Description("Date MS")]
        [Column("PAVE_CHS__DATE_MS",Order=4)]
        [Required()]
        public DateTime PaveChsDateMs { get; set; }
        
        [Description("Liaison")]
        [Column("PAVE_CHS__LIAISON",Order=5)]
        [Required()]
        [MaxLength(15)] 
        public String PaveChsLiaison { get; set; }
        
        [Description("Sens")]
        [Column("PAVE_CHS__SENS",Order=6)]
        [Required()]
        [MaxLength(6)] 
        public String PaveChsSens { get; set; }
        
        [Description("Début")]
        [Column("PAVE_CHS__ABS_DEB",Order=7)]
        [Required()]
        public Int64 PaveChsAbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("PAVE_CHS__ABS_FIN",Order=8)]
        [Required()]
        public Int64 PaveChsAbsFin { get; set; }
        
        [Description("No Ordre")]
        [Column("NUMORDRE",Order=9)]
        [Required()]
        public Int64 Numordre { get; set; }
        
        [Description("Famille technique")]
        [Column("CD_FAM_TECH_CHS__CODE",Order=10)]
        [Required()]
        [MaxLength(15)] 
        public String CdFamTechChsCode { get; set; }
        
        [Description("Technique")]
        [Column("CD_TECH_CHS__TECHNIQUE",Order=11)]
        [Required()]
        [MaxLength(12)] 
        public String CdTechChsTechnique { get; set; }
        
        [Description("Epaisseur (cm)")]
        [Column("EPAIS",Order=12)]
        [Required()]
        public Double Epais { get; set; }
        
        [Description("Dosage")]
        [Column("DOSAGE",Order=13)]
        [MaxLength(5)] 
        public String Dosage { get; set; }
        
    }
}
