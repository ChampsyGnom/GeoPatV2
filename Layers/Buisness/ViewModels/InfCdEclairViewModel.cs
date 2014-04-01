using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdEclairViewModel : ViewModelBase<InfCdEclair>
    {
        public InfCdEclairViewModel(InfCdEclair model) : base(model)
        {
            this.InfEclairages = new  ObservableCollection<InfEclairageViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<InfEclairageViewModel> InfEclairages { get; set; }
        
        private String _type;
        [DisplayName("Eclairage")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
            }
        }
    }
}
