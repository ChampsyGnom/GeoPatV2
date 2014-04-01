using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaJointViewModel : ViewModelBase
    {
        public OaJoint Model {get; set;}
        public OaJointViewModel(OaJoint model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaTablier=new OaTablierViewModel( this.Model.OaTablier);
            this.OaCdJoint=new OaCdJointViewModel( this.Model.OaCdJoint);
            this.NumJoint=this.Model.NumJoint;
            this.DateMs=this.Model.DateMs;
            this.Longueur=this.Model.Longueur;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaTablier=this. OaTablier.Model;
            this.Model.OaCdJoint=this. OaCdJoint.Model;
            this.Model.NumJoint=this.NumJoint;
            this.Model.DateMs=this.DateMs;
            this.Model.Longueur=this.Longueur;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaTablierViewModel _oaTablier;
        [DisplayName("Tabliers")]
        public virtual OaTablierViewModel OaTablier
        {
            get
            {
                return this._oaTablier;
            }
            set
            {
                this._oaTablier = value;
                RaisePropertyChange("OaTablier");
            }
        }
        
        private OaCdJointViewModel _oaCdJoint;
        [DisplayName("Types de joint")]
        public virtual OaCdJointViewModel OaCdJoint
        {
            get
            {
                return this._oaCdJoint;
            }
            set
            {
                this._oaCdJoint = value;
                RaisePropertyChange("OaCdJoint");
            }
        }
        
        private Int64 _numJoint;
        [DisplayName("N° joint")]
        public Int64 NumJoint
        {
            get
            {
                return this._numJoint;
            }
            set
            {
                this._numJoint = value;
                RaisePropertyChange("NumJoint");
            }
        }
        
        private Nullable<DateTime> _dateMs;
        [DisplayName("Date de MS")]
        public Nullable<DateTime> DateMs
        {
            get
            {
                return this._dateMs;
            }
            set
            {
                this._dateMs = value;
                RaisePropertyChange("DateMs");
            }
        }
        
        private Nullable<Double> _longueur;
        [DisplayName("Longueur joint")]
        public Nullable<Double> Longueur
        {
            get
            {
                return this._longueur;
            }
            set
            {
                this._longueur = value;
                RaisePropertyChange("Longueur");
            }
        }
        
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
    }
}
