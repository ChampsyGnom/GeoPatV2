using Emash.GeoPat.Applications.Profil.IO;
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
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Emash.GeoPat.Applications.Profil.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        public ParameterViewModel Parameters { get; private set; }
        public DelegateCommand LoadConfigurationCommand { get; private set; }
        public DelegateCommand SaveConfigurationCommand { get; private set; }
        public DelegateCommand AddUserCommand { get; private set; }
        public DelegateCommand EditUserCommand { get; private set; }
        public DelegateCommand EditProfilCommand { get; private set; }
        public DelegateCommand EditParamCommand { get; private set; }
        public DelegateCommand EditSchemaCommand { get; private set; }
        public DelegateCommand DeleteUserCommand { get; private set; }
        public String Login { get; private set; }
        public  DataContextPrf DataContextPrf { get; private set; }
        public  DataContextInf DataContextInf { get; private set; }

        public DataContextOh DataContextOh { get; private set; }

        public DataContextOa DataContextOa { get; private set; }

        public DataContextBsn DataContextBsn { get; private set; }

        public DataContextChs DataContextChs { get; private set; }

        public DataContextDs DataContextDs { get; private set; }

        public DataContextEqp DataContextEqp { get; private set; }

        public DataContextGms DataContextGms { get; private set; }

        public DataContextGot DataContextGot { get; private set; }

        public DataContextMapinfo DataContextMapinfo { get; private set; }

        public DataContextWeb DataContextWeb { get; private set; }
   
        private ViewModelCollection<PrfBmUser, UserViewModel> _users { get; set; }
        private ViewModelCollection<PrfBmProfil, ProfilViewModel> _profils { get; set; }
        private ViewModelCollection<PrfBmSchema, SchemaViewModel> _schemas { get; set; }
        public ListCollectionView Users { get; private set; }
        public ListCollectionView Profils { get; private set; }

        public ListCollectionView Schemas { get; private set; }
        public IUnityContainer Container { get; private set; }
        public MainViewModel(IUnityContainer container) 
        {
            this.Container = container;
            this.Parameters = new ParameterViewModel();
            this._users = new ViewModelCollection<PrfBmUser, UserViewModel>();
            this.Users = new ListCollectionView(this._users);
            this._profils = new ViewModelCollection<PrfBmProfil, ProfilViewModel>();
            this.Profils = new ListCollectionView(this._profils);
            this._schemas = new ViewModelCollection<PrfBmSchema, SchemaViewModel>();
            this.Schemas = new ListCollectionView(this._schemas);
            this.Login = "PRF_ADMIN";
            ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<ReadyEvent>().Subscribe(OnReady);
            this.AddUserCommand = new DelegateCommand(AddUser);
            this.EditUserCommand = new DelegateCommand(EditCurrentUser, CanEditOrDeleteCurrentUser);
            this.DeleteUserCommand = new DelegateCommand(DeleteCurrentUser, CanEditOrDeleteCurrentUser);
            this.Users.CurrentChanged += Users_CurrentChanged;
            this.Profils.CurrentChanged += Profils_CurrentChanged;
            this.Schemas.CurrentChanged += Schemas_CurrentChanged;
            this.LoadConfigurationCommand = new DelegateCommand(LoadConfiguration);
            this.SaveConfigurationCommand = new DelegateCommand(SaveConfiguration);
            this.EditProfilCommand = new DelegateCommand(EditProfil, CanEditProfil);
            this.EditSchemaCommand = new DelegateCommand(EditSchema, CanEditSchema);
            this.EditParamCommand = new DelegateCommand(EditParam);

        }
        private void EditParam()
        {
            ParameterViewModel cloneVm = new ParameterViewModel();
            ParametersView view = new ParametersView();
            view.DataContext = cloneVm;
            view.Owner = Application.Current.GetActiveWindow();
            Nullable<Boolean> result = view.ShowDialog();
        }
        void Schemas_CurrentChanged(object sender, EventArgs e)
        {
            this.EditSchemaCommand.RaiseCanExecuteChanged();
        }
        private void EditSchema()
        {
            if (this.Schemas.CurrentItem != null)
            {
                SchemaViewModel vm = this.Schemas.CurrentItem as SchemaViewModel;
                SchemaViewModel cloneVm = new SchemaViewModel(vm.Model);
                cloneVm.DbContext = vm.DbContext;
                SchemaView view = new SchemaView();
                view.DataContext = cloneVm;
                view.Owner = Application.Current.GetActiveWindow();
                Nullable<Boolean> result = view.ShowDialog();
                if (result.HasValue && result.Value == true)
                {
                    if (!String.IsNullOrEmpty(cloneVm.PathDocuments))
                    { vm.DbContext.SetSysUser("DBS_MAIN", "<NULL>", "<NULL>", "<NULL>", "PATH_DOC", cloneVm.PathDocuments); }

                    if (!String.IsNullOrEmpty(cloneVm.PathDatas))
                    {
                        String pathCampagnes = System.IO.Path.Combine(cloneVm.PathDatas, "Campagnes");
                        String pathLogs = System.IO.Path.Combine(cloneVm.PathDatas, "Logs");
                        String pathImportExports = System.IO.Path.Combine(cloneVm.PathDatas, "ImportExports");
                        vm.DbContext.SetSysUser("DBS_MAIN", "<NULL>", "<NULL>", "<NULL>", "PATH_CAMP", pathCampagnes);
                        vm.DbContext.SetSysUser("DBS_MAIN", "<NULL>", "<NULL>", "<NULL>", "PATH_LOG", pathLogs);
                        vm.DbContext.SetSysUser("DBS_MAIN", "<NULL>", "<NULL>", "<NULL>", "PATH_IMPEXP", pathImportExports);
                    }

                    if (!String.IsNullOrEmpty(cloneVm.PathExe))
                    { vm.DbContext.SetSysUser("DBS_MAIN", "<NULL>", "<NULL>", "<NULL>", "PATH_EXE", cloneVm.PathExe); }

                    vm.ReadPaths();
                  
                }
            }
        }
        private Boolean CanEditSchema()
        {
            return this.Schemas.CurrentItem != null;
        }

        void Profils_CurrentChanged(object sender, EventArgs e)
        {
            this.EditProfilCommand.RaiseCanExecuteChanged();
        }

        private void EditProfil()
        {
            if (this.Profils.CurrentItem != null)
            {
                ProfilViewModel vm = this.Profils.CurrentItem as ProfilViewModel;
                ProfilViewModel vmClone = new ProfilViewModel(vm.Model);
                ProfilView view = new ProfilView();
                view.DataContext = vmClone;
                view.Owner = Application.Current.GetActiveWindow();
                Nullable<Boolean> result = view.ShowDialog();
                if (result.HasValue && result.Value == true)
                {
                    foreach (PrfBmProfilTableViewModel vmProfilTable in vmClone.PrfBmProfilTables)
                    {
                        vmProfilTable.Write();
                    }
                    this.DataContextPrf.SaveChanges();
                    vm.ReadProfilTables();

                }
            }
        }

        private Boolean CanEditProfil()
        {
            return this.Profils.CurrentItem != null;
        }

        private void LoadConfiguration()
        {
            List<String> configurationFiles = new List<string>();
            String[] files = System.IO.Directory.GetFiles(Application.Current.GetStartupPath(), "*.txt");
            foreach (String file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Name.StartsWith("EXP_PRF"))
                { configurationFiles.Add(fileInfo.FullName); }
            }
            if (configurationFiles.Count == 0)
            {
                MessageBox.Show("Aucun fichier de configuration trouvé", "Fichier absent", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (configurationFiles.Count == 1)
            {
                this.LoadConfiguration(configurationFiles[0]);
            }
            else
            { 
                /// choix fichier
            }
        }

        private void LoadConfiguration(string fileName)
        {
            ConfigurationReader reader = new ConfigurationReader(fileName);
            this.LoadUsers();
            this.LoadProfils();
            this.LoadSchemas();
        }


        private void SaveConfiguration()
        { }

        void Users_CurrentChanged(object sender, EventArgs e)
        {
            this.EditUserCommand.RaiseCanExecuteChanged();
            this.DeleteUserCommand.RaiseCanExecuteChanged();
        }

        private void AddUser()
        {
            UserView view = new UserView();
            PrfBmUser user = new PrfBmUser();

            DbSet<PrfBmSchema> setSchema = this.DataContextPrf.Set<PrfBmSchema>();
            DbSet<PrfBmProfil> setProfils = this.DataContextPrf.Set<PrfBmProfil>();
            DbSet<PrfBmUserProfil> setUserProfils = this.DataContextPrf.Set<PrfBmUserProfil>();


            UserViewModel vm = new UserViewModel(user);
           
            view.DataContext = vm;
            view.Title = "Ajout d'un utilisateur";
            view.Owner = Application.Current.GetActiveWindow();
            Nullable<Boolean> result = view.ShowDialog();
            if (result.HasValue && result.Value == true)
            {
                vm.Write();
                if (vm.FamDec != null && vm.CdDec != null)
                {

                    vm.Model.FamDecInf = vm.FamDec.FamDec;
                    vm.Model.CdDecInf = vm.CdDec.CdDec;
                }
                else
                {
                    vm.Model.FamDecInf = null;
                    vm.Model.CdDecInf = null;
                }
                this.DataContextPrf.Set<PrfBmUser>().Add(vm.Model);
                this.DataContextPrf.SaveChanges();
                this._users.Add(vm);

                foreach (UserProfilViewModel profilVm in vm.Profils)
                {
                    PrfBmUserProfil userProfil = new PrfBmUserProfil();
                    userProfil.BmUserLogin = vm.Model.Login;
                    switch (profilVm.PrivilegeLevel)
                    { 
                        case Layers.Shared.Enums.PrivilegeLevel.Administrateur :
                            userProfil.BmProfilProfil = "ADMIN_"+profilVm.Schema.Schema ;
                            break;
                        case Layers.Shared.Enums.PrivilegeLevel.Consultant:
                            userProfil.BmProfilProfil ="CONSULT_"+ profilVm.Schema.Schema ;
                            break;
                        case Layers.Shared.Enums.PrivilegeLevel.Valideur:
                            userProfil.BmProfilProfil = "VALID_"+profilVm.Schema.Schema;
                            break;
                    }
                    userProfil.PrfBmUserIdPk = vm.Model.IdPk;
                    userProfil.PrfBmProfilIdPk = (from p in setProfils where p.Profil.Equals (userProfil.BmProfilProfil) select p.IdPk).FirstOrDefault();
                    setUserProfils.Add(userProfil);
                }
                 this.DataContextPrf.SaveChanges();
                 vm.RaiseChanges();
            }
        }

        private void EditCurrentUser()
        {
            if (this.Users.CurrentItem != null)
            {
                DbSet<PrfBmProfil> setProfils = this.DataContextPrf.Set<PrfBmProfil>();
                DbSet<PrfBmUserProfil> setUserProfils = this.DataContextPrf.Set<PrfBmUserProfil>();
                UserView view = new UserView();
                view.Title ="Modification d'un utilisateur";
                UserViewModel vm = this.Users.CurrentItem as UserViewModel;
                UserViewModel vmClone = new UserViewModel(vm.Model);
                view.DataContext = vmClone;
                view.Owner = Application.Current.GetActiveWindow();
                Nullable<Boolean> result = view.ShowDialog();
                if (result.HasValue && result.Value == true)
                {
                    

                    vmClone.Write();
                    if (vmClone.FamDec != null && vmClone.CdDec != null)
                    {

                        vmClone.Model.FamDecInf = vmClone.FamDec.FamDec;
                        vmClone.Model.CdDecInf = vmClone.CdDec.CdDec;
                    }
                    else
                    {
                        vmClone.Model.FamDecInf = null;
                        vmClone.Model.CdDecInf = null;
                    }
                    vm.FamDec = vmClone.FamDec;
                    vm.CdDec = vmClone.CdDec;
                    this.DataContextPrf.SaveChanges();
                    foreach (UserProfilViewModel userProfilVm in vmClone.Profils)
                    {
                        PrfBmUserProfil prfBmUserProfil = (from p in setUserProfils where p.PrfBmUser.IdPk.Equals (vm.Model.IdPk) && p.PrfBmProfil.PrfBmSchema.IdPk.Equals (userProfilVm.Schema.IdPk) select p).FirstOrDefault();
                        switch (userProfilVm.PrivilegeLevel)
                        { 
                            case Layers.Shared.Enums.PrivilegeLevel.Administrateur:
                                prfBmUserProfil.PrfBmProfil = (from p in setProfils where p.PrfBmSchema.IdPk.Equals (userProfilVm.Schema.IdPk) && p.Profil.Equals ("ADMIN_"+userProfilVm.Schema.Schema ) select p).FirstOrDefault();
                                break;
                            case Layers.Shared.Enums.PrivilegeLevel.Valideur:
                                prfBmUserProfil.PrfBmProfil = (from p in setProfils where p.PrfBmSchema.IdPk.Equals(userProfilVm.Schema.IdPk) && p.Profil.Equals("VALID_"+userProfilVm.Schema.Schema ) select p).FirstOrDefault();
                                break;
                            case Layers.Shared.Enums.PrivilegeLevel.Consultant:
                                 prfBmUserProfil.PrfBmProfil = (from p in setProfils where p.PrfBmSchema.IdPk.Equals (userProfilVm.Schema.IdPk) && p.Profil.Equals ("CONSULT_"+userProfilVm.Schema.Schema ) select p).FirstOrDefault();
                                break;
                        }
                    }
                    this.DataContextPrf.SaveChanges();
                    vm.Read();
                    vm.ReadProfils();
                    vm.RaiseChanges();
                }                
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
                this.Container.RegisterInstance(this.DataContextPrf);

                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma INF ...");
                this.DataContextInf = new Layers.Data.DataContextInf(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                this.DataContextInf.Database.Initialize(false);
                this.Container.RegisterInstance(this.DataContextInf);            
               

                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Bsn ...");
                    this.DataContextBsn = new DataContextBsn(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                  //  this.DataContextBsn.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextBsn);   
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }

                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Chs ...");
                    this.DataContextChs = new DataContextChs(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                 //   this.DataContextChs.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextChs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }

                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Ds ...");
                    this.DataContextDs = new DataContextDs(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                 //   this.DataContextDs.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextDs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }


                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Eqp ...");
                    this.DataContextEqp = new DataContextEqp(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                 //   this.DataContextEqp.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextEqp);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }


                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Gms ...");
                    this.DataContextGms = new DataContextGms(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                 //   this.DataContextGms.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextGms);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }

                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Got ...");
                    this.DataContextGot = new DataContextGot(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                //    this.DataContextGot.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextGot);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }

                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Mapinfo ...");
                    this.DataContextMapinfo = new DataContextMapinfo(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                  //  this.DataContextMapinfo.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextMapinfo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }

                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Oa ...");
                    this.DataContextOa = new DataContextOa(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                 //   this.DataContextOa.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextOa);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }

                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Oh ...");
                    this.DataContextOh = new DataContextOh(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                 //   this.DataContextOh.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextOh);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }

                try
                {
                    ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma Web ...");
                    this.DataContextWeb = new DataContextWeb(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                //    this.DataContextOh.Database.Initialize(false);
                    this.Container.RegisterInstance(this.DataContextWeb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Impossible d'initialiser le contexte Bsn " + ex.Message);
                }
                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Chargement des utilisateurs ...");
                this.LoadUsers();
                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Chargement des profils ...");
                this.LoadProfils();
                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Chargement des métiers ...");
                this.LoadSchemas();

            }
            
        }

        private void LoadSchemas()
        {
            this._schemas.Load(this.DataContextPrf);
            foreach (SchemaViewModel schema in this._schemas)
            {
                if (schema.Schema.Equals("BSN"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextBsn>();
                }
                else if (schema.Schema.Equals("CHS"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextChs>();
                }
                else if (schema.Schema.Equals("DS"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextDs>();
                }
                else if (schema.Schema.Equals("EQP"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextEqp>();
                }
                else if (schema.Schema.Equals("GMS"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextGms>();
                }
                else if (schema.Schema.Equals("GOT"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextGot>();
                }
                else if (schema.Schema.Equals("INF"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextInf>();
                }
                else if (schema.Schema.Equals("MAPINFO"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextMapinfo>();
                }
                else if (schema.Schema.Equals("OA"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextOa>();
                }                
                else if (schema.Schema.Equals("OH"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextOh>();
                }
                else if (schema.Schema.Equals("PRF"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextPrf>();
                }
                else if (schema.Schema.Equals("WEB"))
                {
                    schema.DbContext = this.Container.Resolve<DataContextWeb>();
                }
            }
        }

        private void LoadProfils()
        {
            this._profils.Load(this.DataContextPrf);
        }

        private void LoadUsers()
        {
            this._users.Load(this.DataContextPrf);
           
        }

        
        
    }
}
