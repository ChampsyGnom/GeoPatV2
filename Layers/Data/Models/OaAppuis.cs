using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("APPUIS_OA",Schema="OA")]
    public partial class OaAppuis : ModelBase
    {
        public virtual OaDsc OaDsc {get;set;}
        
        [Required()]
        [Column("DSC_OA_ID_PK",Order=0)]
        public Int64 OaDscIdPk {get;set;}
        
        public virtual OaCdFamAppui OaCdFamAppui {get;set;}
        
        [Required()]
        [Column("CD_FAM_APPUI_OA_ID_PK",Order=1)]
        public Int64 OaCdFamAppuiIdPk {get;set;}
        
        public virtual OaCdAppui OaCdAppui {get;set;}
        
        [Required()]
        [Column("CD_APPUI_OA_ID_PK",Order=2)]
        public Int64 OaCdAppuiIdPk {get;set;}
        
        public virtual OaCdAppAppui OaCdAppAppui {get;set;}
        
        [Required()]
        [Column("CD_APP_APPUI_OA_ID_PK",Order=3)]
        public Int64 OaCdAppAppuiIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=4)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Famille d'appuis")]
        [Column("CD_FAM_APPUI_OA__FAM_APP",Order=6)]
        [Required()]
        [MaxLength(60)] 
        public String CdFamAppuiOaFamApp { get; set; }
        
        [Description("Type d'appui")]
        [Column("CD_APPUI_OA__APP",Order=7)]
        [Required()]
        [MaxLength(60)] 
        public String CdAppuiOaApp { get; set; }
        
        [Description("Type app appui")]
        [Column("CD_APP_APPUI_OA__APPUI",Order=8)]
        [Required()]
        [MaxLength(60)] 
        public String CdAppAppuiOaAppui { get; set; }
        
        [Description("Nbr app. appui")]
        [Column("NBR_APPAREIL",Order=9)]
        public Nullable<Int64> NbrAppareil { get; set; }
        
        [Description("Date MS app appui")]
        [Column("DATE_MS",Order=10)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=11)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
