using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_CALCUL_TRAFIC_DS",Schema="DS")]
    public partial class DsSimCalculTrafic : ModelBase
    {
        private DsSimDvp _dsSimDvp;
        public virtual DsSimDvp DsSimDvp 
        {
            get
            {
                return this._dsSimDvp;
                
            }
            set
            {
                this._dsSimDvp = value;
                this.SimDvpDsId = this._dsSimDvp.Id;
            }
        }
        
        [Column("SIM_DVP_DS_ID_PK",Order=0)]
        public Nullable<Int64> DsSimDvpIdPk {get;set;}
        
        private DsSimRec _dsSimRec;
        public virtual DsSimRec DsSimRec 
        {
            get
            {
                return this._dsSimRec;
                
            }
            set
            {
                this._dsSimRec = value;
                this.SimRecDsId = this._dsSimRec.Id;
            }
        }
        
        [Column("SIM_REC_DS_ID_PK",Order=1)]
        public Nullable<Int64> DsSimRecIdPk {get;set;}
        
        private DsSimEntretien _dsSimEntretien;
        public virtual DsSimEntretien DsSimEntretien 
        {
            get
            {
                return this._dsSimEntretien;
                
            }
            set
            {
                this._dsSimEntretien = value;
                this.SimEntretienDsId = this._dsSimEntretien.Id;
            }
        }
        
        [Column("SIM_ENTRETIEN_DS_ID_PK",Order=2)]
        public Nullable<Int64> DsSimEntretienIdPk {get;set;}
        
        private DsSimCalcul _dsSimCalcul;
        public virtual DsSimCalcul DsSimCalcul 
        {
            get
            {
                return this._dsSimCalcul;
                
            }
            set
            {
                this._dsSimCalcul = value;
                this.SimCalculDsId = this._dsSimCalcul.Id;
            }
        }
        
        [Required()]
        [Column("SIM_CALCUL_DS_ID_PK",Order=3)]
        public Int64 DsSimCalculIdPk {get;set;}
        
        public virtual ICollection<DsSimCalculFis> DsSimCalculFiss { get; set; }
        
        [Key]
        [Column("ID_PK",Order=4)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_CALCUL_TRAFIC_DS__ID")]
        [Column("ID",Order=5)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("SIM_CALCUL_DS__ID")]
        [Column("SIM_CALCUL_DS__ID",Order=6)]
        [Required()]
        public Int64 SimCalculDsId { get; set; }
        
        [Description("SIM_ENTRETIEN_DS__ID")]
        [Column("SIM_ENTRETIEN_DS__ID",Order=7)]
        public Nullable<Int64> SimEntretienDsId { get; set; }
        
        [Description("SIM_DVP_DS__ID")]
        [Column("SIM_DVP_DS__ID",Order=8)]
        public Nullable<Int64> SimDvpDsId { get; set; }
        
        [Description("SIM_REC_DS__ID")]
        [Column("SIM_REC_DS__ID",Order=9)]
        public Nullable<Int64> SimRecDsId { get; set; }
        
        [Description("SIM_CALCUL_TRAFIC_DS__TRAFIC")]
        [Column("TRAFIC",Order=10)]
        [Required()]
        [MaxLength(10)] 
        public String Trafic { get; set; }
        
    }
}
