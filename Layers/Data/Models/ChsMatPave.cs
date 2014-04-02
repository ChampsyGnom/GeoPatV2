using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("MAT_PAVE_CHS",Schema="CHS")]
    public partial class ChsMatPave : ModelBase
    {
        public virtual ChsFabCar ChsFabCar {get;set;}
        
        [Required()]
        [Column("FAB_CAR_CHS_ID_PK",Order=0)]
        public Int64 ChsFabCarIdPk {get;set;}
        
        public virtual ChsMat ChsMat {get;set;}
        
        [Required()]
        [Column("MAT_CHS_ID_PK",Order=1)]
        public Int64 ChsMatIdPk {get;set;}
        
        public virtual ChsPave ChsPave {get;set;}
        
        [Required()]
        [Column("PAVE_CHS_ID_PK",Order=2)]
        public Int64 ChsPaveIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Couche")]
        [Column("CD_COU_CHS__COUCHE",Order=4)]
        [Required()]
        [MaxLength(14)] 
        public String CdCouChsCouche { get; set; }
        
        [Description("Date MS")]
        [Column("PAVE_CHS__DATE_MS",Order=5)]
        [Required()]
        public DateTime PaveChsDateMs { get; set; }
        
        [Description("Liaison")]
        [Column("PAVE_CHS__LIAISON",Order=6)]
        [Required()]
        [MaxLength(15)] 
        public String PaveChsLiaison { get; set; }
        
        [Description("Sens")]
        [Column("PAVE_CHS__SENS",Order=7)]
        [Required()]
        [MaxLength(6)] 
        public String PaveChsSens { get; set; }
        
        [Description("Début")]
        [Column("PAVE_CHS__ABS_DEB",Order=8)]
        [Required()]
        public Int64 PaveChsAbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("PAVE_CHS__ABS_FIN",Order=9)]
        [Required()]
        public Int64 PaveChsAbsFin { get; set; }
        
        [Description("No Ordre")]
        [Column("NUM",Order=10)]
        [Required()]
        public Int64 Num { get; set; }
        
        [Description("Nature de matériaux")]
        [Column("CD_MAT_CHS__CODE",Order=11)]
        [Required()]
        [MaxLength(12)] 
        public String CdMatChsCode { get; set; }
        
        [Description("Type fabricant/carrière")]
        [Column("CD_ORIG_CHS__CODE",Order=12)]
        [Required()]
        [MaxLength(20)] 
        public String CdOrigChsCode { get; set; }
        
        [Description("Fabricant/carrières")]
        [Column("FAB_CAR_CHS__NOM",Order=13)]
        [Required()]
        [MaxLength(60)] 
        public String FabCarChsNom { get; set; }
        
        [Description("Matériaux")]
        [Column("MAT_CHS__MAT",Order=14)]
        [Required()]
        [MaxLength(60)] 
        public String MatChsMat { get; set; }
        
        [Description("Classe matériau")]
        [Column("CLASSE",Order=15)]
        [MaxLength(8)] 
        public String Classe { get; set; }
        
        [Description("Dosage")]
        [Column("DOSAGE",Order=16)]
        [MaxLength(50)] 
        public String Dosage { get; set; }
        
        [Description("Observation")]
        [Column("OBSERV",Order=17)]
        [MaxLength(255)] 
        public String Observ { get; set; }
        
    }
}
