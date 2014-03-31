using Emash.GeoPat.Layers.Engine.Services;
using Emash.GeoPat.Layers.Engine.ViewModels;
using Emash.GeoPat.Layers.Engine.Views;
using Emash.GeoPat.Layers.Shared.Enums;
using Emash.GeoPat.Layers.Shared.Models;
using Emash.GeoPat.Layers.Shared.Services;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Emash.GeoPat.Layers.Engine
{
    public class Bootstrapper<VM, V> : UnityBootstrapper
        where VM : IMainViewModel
        where V : Window, IMainView
    {

        public Bootstrapper()
        {
            String modulesPath = System.IO.Path.Combine(System.Windows.Application.Current.GetStartupPath(),"Modules");
            if (!System.IO.Directory.Exists(modulesPath))
            {System.IO.Directory.CreateDirectory(modulesPath);}

        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            String modulesPath = System.IO.Path.Combine(System.Windows.Application.Current.GetStartupPath(), "Modules");          
            this.ModuleCatalog = new DirectoryModuleCatalog() { ModulePath = modulesPath };


        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.RegisterType<IMainViewModel, VM>(new ContainerControlledLifetimeManager());
            this.Container.RegisterType<IMainView, V>(new ContainerControlledLifetimeManager());
            this.Container.RegisterType<ISplashService,SplashService>(new ContainerControlledLifetimeManager());
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            System.Windows.Application.Current.MainWindow = this.Container.Resolve<V>();

        }


        protected override System.Windows.DependencyObject CreateShell()
        {
            V mainView = this.Container.Resolve<V>();
            return mainView;
        }

        protected override void InitializeModules()
        {

            this.Container.Resolve<ISplashService>().ShowSplash();            
            base.InitializeModules();
            this.Container.Resolve<IDataService>().LoadConfiguration();
            ConfigurationDatabase defaultDatabase = this.Container.Resolve<IDataService>().GetDefaultDatabase();
            if (defaultDatabase == null)
            {
                this.Container.Resolve<ISplashService>().SplashUserAction = SplashUserAction.ChooseDatabase;
                Task taskWaitingUserAction = this.Container.Resolve<ISplashService>().CreateTaskWaitingUserAction(0);
                taskWaitingUserAction.Start();
                taskWaitingUserAction.Wait();
            }
            else
            {
                Task taskWaitingUserAction = this.Container.Resolve<ISplashService>().CreateTaskWaitingUserAction(1000);
                taskWaitingUserAction.Start();
                taskWaitingUserAction.Wait();
            }
           
            if (this.Container.Resolve<ISplashService>().SplashUserAction == SplashUserAction.Exit)
            {
                System.Windows.Application.Current.Shutdown();
                return;
            }

            if (this.Container.Resolve<ISplashService>().SplashUserAction == SplashUserAction.ChooseDatabase)
            {
                defaultDatabase = this.Container.Resolve<IDataService>().ShowSelectDatabaseDialog();
                if (defaultDatabase == null)
               {
                   System.Windows.Application.Current.Shutdown();
                   return;
               }
              
            }
            Dictionary<String, Boolean> connexions = new Dictionary<string, bool>();
            string login = this.Container.Resolve<IMainViewModel>().Login;
            string password = this.Container.Resolve<IDataService>().GetPasswordForLogin(defaultDatabase,login);
            bool connected = false;
            while (!connected)
            {
                if (password == null)
                {
                    password = this.Container.Resolve<IDataService>().ShowInputPasswordDialog(defaultDatabase,login);
                    if (password == null)
                    {
                        System.Windows.Application.Current.Shutdown();
                        return;
                    }
                    else
                    {
                        connected = this.Container.Resolve<IDataService>().TryConnect(defaultDatabase,login, password);
                        if (!connected) password = null;
                    }
                }
                else
                {
                    connected = this.Container.Resolve<IDataService>().TryConnect(defaultDatabase,login, password);
                    if (!connected) password = null;
                }
                if (connected)
                {
                    this.Container.Resolve<IDataService>().SetPasswordForLogin(defaultDatabase,login, password);
                    this.Container.Resolve<IDataService>().SetDefaultDatabase(defaultDatabase);
                    this.Container.Resolve<IDataService>().CreateConnection(defaultDatabase,login, password);

                }
            }
            
        }
    }
}
