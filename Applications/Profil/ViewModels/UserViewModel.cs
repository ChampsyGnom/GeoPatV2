using Emash.GeoPat.Layers.Buisness.ViewModels;
using Emash.GeoPat.Layers.Data.Models;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Emash.GeoPat.Applications.Profil.ViewModels
{
    public class UserViewModel : PrfBmUserViewModel
    {

        public DelegateCommand<Window> ValidateCommand { get; private set; }
        public UserViewModel(PrfBmUser model) : base(model)
        {
            this.ValidateCommand = new DelegateCommand<Window>(Validate, CanValidate);
              
            
        }

        private void Validate(Window window)
        { }

        private Boolean CanValidate(Window window)
        { return true; }
    }
}
