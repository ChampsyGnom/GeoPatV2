using Emash.GeoPat.Applications.Profil.Views;
using Emash.GeoPat.Layers.Buisness;
using Emash.GeoPat.Layers.Buisness.ViewModels;
using Emash.GeoPat.Layers.Data;
using Emash.GeoPat.Layers.Data.Models;
using Emash.GeoPat.Layers.Engine.ViewModels;
using Emash.GeoPat.Layers.Shared.Events;
using Emash.GeoPat.Layers.Shared.Services;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Emash.GeoPat.Applications.Profil.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        public DelegateCommand AddUserCommand { get; private set; }
        public DelegateCommand EditUserCommand { get; private set; }

        public DelegateCommand DeleteUserCommand { get; private set; }
        public String Login { get; private set; }
        public  DataContextPrf DataContextPrf { get; private set; }
        public  DataContextInf DataContextInf { get; private set; }
        private ViewModelCollection<PrfBmUser, UserViewModel> _users { get; set; }
        public ListCollectionView Users { get; private set; }
        public MainViewModel() 
        {
            this._users = new ViewModelCollection<PrfBmUser, UserViewModel>();
            this.Users = new ListCollectionView(this._users);
            this.Login = "PRF_ADMIN";
            ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<ReadyEvent>().Subscribe(OnReady);
            this.AddUserCommand = new DelegateCommand(AddUser);
            this.EditUserCommand = new DelegateCommand(EditCurrentUser, CanEditOrDeleteCurrentUser);
            this.DeleteUserCommand = new DelegateCommand(DeleteCurrentUser, CanEditOrDeleteCurrentUser);
            this.Users.CurrentChanged += Users_CurrentChanged;
        }

        void Users_CurrentChanged(object sender, EventArgs e)
        {
            this.EditUserCommand.RaiseCanExecuteChanged();
            this.DeleteUserCommand.RaiseCanExecuteChanged();
        }

        private void AddUser()
        {
            UserView view = new UserView();
            UserViewModel vm = new UserViewModel(new PrfBmUser());
            view.DataContext = vm;
            view.Owner = Application.Current.GetActiveWindow();
            Nullable<Boolean> result = view.ShowDialog();
            if (result.HasValue && result.Value == true)
            {
                vm.Write();
                this.DataContextPrf.Set<PrfBmUser>().Add(vm.Model);
                this.DataContextPrf.SaveChanges();
                this._users.Add(vm);
            }
        }

        private void EditCurrentUser()
        {
            if (this.Users.CurrentItem != null)
            {
                UserView view = new UserView();
                UserViewModel vm = this.Users.CurrentItem as UserViewModel;
                view.DataContext = vm;
                view.Owner = Application.Current.GetActiveWindow();
                Nullable<Boolean> result = view.ShowDialog();
                if (result.HasValue && result.Value == true)
                {
                    vm.Write();
                    this.DataContextPrf.SaveChanges();
                }
                else
                {vm.Read();}
            }
        }

        private void DeleteCurrentUser()
        {
            if (this.Users.CurrentItem != null)
            {
                UserViewModel vm = this.Users.CurrentItem as UserViewModel;
                this.DataContextPrf.Set<PrfBmUser>().Remove(vm.Model);
                this.DataContextPrf.SaveChanges();
                this._users.Remove(vm);
            }
        }

        private Boolean CanEditOrDeleteCurrentUser()
        {
            return this.Users.CurrentItem != null;
        }
        private void OnReady(Boolean ready)
        {
            if (ServiceLocator.Current.GetInstance<IDataService>().Connection != null)
            {
                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation de la base de donnée ...");

                Database.SetInitializer<DataContextPrf>(null);
                Database.SetInitializer<DataContextInf>(null);

                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma PRF ...");
                this.DataContextPrf = new Layers.Data.DataContextPrf(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                this.DataContextPrf.Database.Initialize(false);

                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma INF ...");
                this.DataContextInf = new Layers.Data.DataContextInf(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                this.DataContextInf.Database.Initialize(false);

                
                this._users.Load(this.DataContextPrf);

             
            }
            
        }
        
    }
}
