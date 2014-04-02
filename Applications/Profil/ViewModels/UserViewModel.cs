using Emash.GeoPat.Layers.Buisness.ViewModels;
using Emash.GeoPat.Layers.Data;
using Emash.GeoPat.Layers.Data.Models;
using Emash.GeoPat.Layers.Shared.Models;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Emash.GeoPat.Applications.Profil.ViewModels
{
    public class UserViewModel : PrfBmUserViewModel
    {
  
        [Browsable(false)]
        public DelegateCommand<Window> ValidateCommand { get; private set; }
        public ObservableCollection<UserProfilViewModel> Profils { get; private set; }
        public ListCollectionView DecoupageFamilles { get; private set; }
        public ListCollectionView DecoupageCodes { get; private set; }
        private List<Object> _decoupageFamilles;
        private List<Object> _decoupageCodes;

        public InfFamDec FamDec { get;  set; }
        public InfCdDec CdDec { get;  set; }

        public UserViewModel(PrfBmUser model) : base(model)
        {
            this.ValidateCommand = new DelegateCommand<Window>(Validate, CanValidate);
            this.Profils = new ObservableCollection<UserProfilViewModel>();
            this.ReadProfils();
            DbSet<InfFamDec> setFamDec = ServiceLocator.Current.GetInstance<DataContextInf>().Set<InfFamDec>();
            DbSet<InfCdDec> setCdDec = ServiceLocator.Current.GetInstance<DataContextInf>().Set<InfCdDec>();           
            _decoupageFamilles = setFamDec.ToList<Object>();
            _decoupageFamilles.Insert(0,new  EmptyItem());
            _decoupageCodes = setCdDec.ToList<Object>();
            _decoupageCodes.Insert(0,new EmptyItem());
            this.DecoupageFamilles = new ListCollectionView(_decoupageFamilles);
            this.DecoupageCodes = new ListCollectionView(_decoupageCodes);

       
            if (!String.IsNullOrEmpty(this.Model.FamDecInf) && !String.IsNullOrEmpty(this.Model.CdDecInf))
            {
                this.FamDec = (from f in setFamDec where f.FamDec.Equals(this.Model.FamDecInf) select f).FirstOrDefault();
                this.CdDec = (from f in setCdDec where f.CdDec.Equals(this.Model.CdDecInf) select f).FirstOrDefault();
                this.DecoupageFamilles.MoveCurrentTo(this.FamDec);
                this.DecoupageCodes.MoveCurrentTo(this.CdDec);
            }
            this.DecoupageCodes.Filter = FilteredCode;
            this.DecoupageFamilles.CurrentChanged += DecoupageFamilles_CurrentChanged;
            this.DecoupageCodes.CurrentChanged += DecoupageCodes_CurrentChanged;
            this.PropertyChanged += UserViewModel_PropertyChanged;
        }

        void UserViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.ValidateCommand.RaiseCanExecuteChanged();
        }

        void DecoupageCodes_CurrentChanged(object sender, EventArgs e)
        {
            this.CdDec = this.DecoupageCodes.CurrentItem as InfCdDec;
        }

        void DecoupageFamilles_CurrentChanged(object sender, EventArgs e)
        {
            this.DecoupageCodes.Refresh();
            this.FamDec = this.DecoupageFamilles.CurrentItem as InfFamDec;
        }
        public Boolean FilteredCode(Object item)
        {
            if (this.DecoupageFamilles.CurrentItem != null && this.DecoupageFamilles.CurrentItem is InfFamDec)
            {
                InfFamDec famDec = (this.DecoupageFamilles.CurrentItem as InfFamDec);
                if (item != null && item is InfCdDec)
                {
                    InfCdDec cdDec = item as InfCdDec;
                    return cdDec.FamDecInfFamDec.Equals(famDec.FamDec);
                }
                else return false;
            }
            else
            {
                return item == null;
            }
            
        }
        public void ReadProfils()
        {
            this.Profils.Clear();
            DbSet<PrfBmSchema> setSchema = ServiceLocator.Current.GetInstance<DataContextPrf>().Set<PrfBmSchema>();
            if (this.Model.PrfBmUserProfils == null)
            {
                foreach (PrfBmSchema schema in setSchema)
                {
                    UserProfilViewModel profilVm = new UserProfilViewModel();
                    profilVm.PrivilegeLevel = Layers.Shared.Enums.PrivilegeLevel.Consultant;
                    profilVm.Schema = schema;
                    this.Profils.Add(profilVm);
                }
            }
            else
            {

                foreach (PrfBmUserProfil userProfil in this.Model.PrfBmUserProfils)
                {
                    if (userProfil.BmProfilProfil.StartsWith("ADMIN"))
                    {
                        UserProfilViewModel vmProfil = new UserProfilViewModel();
                        vmProfil.PrivilegeLevel = Layers.Shared.Enums.PrivilegeLevel.Administrateur;
                        vmProfil.Schema = userProfil.PrfBmProfil.PrfBmSchema;
                        this.Profils.Add(vmProfil);
                    }
                    else if (userProfil.BmProfilProfil.StartsWith("VALID"))
                    {
                        UserProfilViewModel vmProfil = new UserProfilViewModel();
                        vmProfil.PrivilegeLevel = Layers.Shared.Enums.PrivilegeLevel.Valideur;
                        vmProfil.Schema = userProfil.PrfBmProfil.PrfBmSchema;
                        this.Profils.Add(vmProfil);
                    }
                    else if (userProfil.BmProfilProfil.StartsWith("CONSULT"))
                    {
                        UserProfilViewModel vmProfil = new UserProfilViewModel();
                        vmProfil.PrivilegeLevel = Layers.Shared.Enums.PrivilegeLevel.Consultant;
                        vmProfil.Schema = userProfil.PrfBmProfil.PrfBmSchema;
                        this.Profils.Add(vmProfil);
                    }
                }

            }
        }

        private void Validate(Window window)
        {
            window.DialogResult = true;
            window.Close();
        }

        private Boolean CanValidate(Window window)
        { return this.Error == null; }

        internal void RaiseChanges()
        {
            this.RaisePropertyChange("FamDec");
            this.RaisePropertyChange("CdDec");
        }
    }
}
