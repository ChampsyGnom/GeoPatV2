using Emash.GeoPat.Layers.Buisness.ViewModels;
using Emash.GeoPat.Layers.Data.Models;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Emash.GeoPat.Applications.Profil.ViewModels
{
    public class ProfilViewModel : PrfBmProfilViewModel
    {
        public DelegateCommand<Window> ValidateCommand { get; private set; }
        public ProfilViewModel(PrfBmProfil model)
            : base(model)
        {
            this.ReadProfilTables();
            this.ValidateCommand = new DelegateCommand<Window>(Validate);
        }
        private void Validate(Window window)
        {
            window.DialogResult = true;
            window.Close();
        }

       


        public void ReadProfilTables()
        {
            this.PrfBmProfilTables.Clear();
            foreach (PrfBmProfilTable peofilTable in Model.PrfBmProfilTables)
            {
                this.PrfBmProfilTables.Add(new PrfBmProfilTableViewModel(peofilTable));
            }
        }
    }
}
