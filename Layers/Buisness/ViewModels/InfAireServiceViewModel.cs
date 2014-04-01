using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfAireServiceViewModel : ViewModelBase
    {
        public InfAireService Model {get; set;}
        public InfAireServiceViewModel(InfAireService model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfCdService=new InfCdServiceViewModel( this.Model.InfCdService);
            this.InfAire=new InfAireViewModel( this.Model.InfAire);
        }
        public override void Write()
        {
            this.Model.InfCdService=this. InfCdService.Model;
            this.Model.InfAire=this. InfAire.Model;
        }
        private InfCdServiceViewModel _infCdService;
        [DisplayName("Type Service")]
        public virtual InfCdServiceViewModel InfCdService
        {
            get
            {
                return this._infCdService;
            }
            set
            {
                this._infCdService = value;
                RaisePropertyChange("InfCdService");
            }
        }
        
        private InfAireViewModel _infAire;
        [DisplayName("Aires")]
        public virtual InfAireViewModel InfAire
        {
            get
            {
                return this._infAire;
            }
            set
            {
                this._infAire = value;
                RaisePropertyChange("InfAire");
            }
        }
        
    }
}
