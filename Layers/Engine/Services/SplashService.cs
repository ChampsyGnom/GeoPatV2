using Emash.GeoPat.Layers.Engine.Views;
using Emash.GeoPat.Layers.Shared.Enums;
using Emash.GeoPat.Layers.Shared.Events;
using Emash.GeoPat.Layers.Shared.Services;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Emash.GeoPat.Layers.Engine.Services
{
    public class SplashService : INotifyPropertyChanged, ISplashService
    {
        /// <summary>
        /// Action choisi par l'utilisateur a lancer à la fin du SplashScreen
        /// </summary>
        public SplashUserAction SplashUserAction { get; set; }
        /// <summary>
        /// Message affiché en bas de la fenetre 
        /// </summary>
        public String Message { get; private set; }
        /// <summary>
        /// Progression en %
        /// </summary>
        public Int32 Progress { get; private set; }
        /// <summary>
        /// Titre affiché en haut en gras et en gros
        /// Donné issue des information de l'assembly disponible dans les propriétées du projet
        /// </summary>
        public String Title { get; private set; }
        /// <summary>
        /// Description affiché sous le titre
        /// Donné issue des information de l'assembly disponible dans les propriétées du projet
        /// </summary>
        public String Description { get; private set; }
        /// <summary>
        /// Version de l'application affiché en bas à gauche
        /// Donné issue des information de l'assembly disponible dans les propriétées du projet
        /// </summary>
        public String Version { get; private set; }
        /// <summary>
        /// Copyright de l'application affiché en bas à droite
        /// Donné issue des information de l'assembly disponible dans les propriétées du projet
        /// </summary>
        public String Copyright { get; private set; }
        /// <summary>
        /// ResetEvent qui prévient quand le thread STA su splash à finit de créer la fenêtre
        /// </summary>
        private ManualResetEvent _resetEvent;
        /// <summary>
        /// Thread STA qui cré la fenêtre du splash
        /// </summary>
        private Thread _splashThread;
        /// <summary>
        /// Fenêtre du SplashScreen
        /// </summary>
        private SplashView _splashView;

        /// <summary>
        /// Implémentation de PropertyChanged
        /// </summary>
        #region Implémentation de PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion


        /// <summary>
        /// Lance la création du SplashScreen 
        /// </summary>
        public void ShowSplash()
        {
            // On initialise le reset event
            _resetEvent = new ManualResetEvent(false);
            // on cré le thread
            _splashThread = new Thread(StartShowSplash);
            // !!! Super important le ApartmentState
            _splashThread.SetApartmentState(ApartmentState.STA);
            _splashThread.IsBackground = true;
            _splashThread.Name = "Splash Screen";
            // On lance le thread
            _splashThread.Start();
            // On attend un set() sur le resetEvent
            _resetEvent.WaitOne();
        }

        private IEventAggregator _eventAggregator;
        private IUnityContainer _container;
        private Boolean _waitForUserAction;

        public SplashService(IEventAggregator eventAggregator, IUnityContainer container)
        {
            this._eventAggregator = eventAggregator;
            this._container = container;           
            this.Message = "Initialisation ...";

            //Récupération des informations de l'assembly
            AssemblyDescriptionAttribute descriptionAttribute = System.Reflection.Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute)).FirstOrDefault() as AssemblyDescriptionAttribute;
            AssemblyTitleAttribute titleAttribute = System.Reflection.Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute)).FirstOrDefault() as AssemblyTitleAttribute;
            AssemblyCompanyAttribute companyAttribute = System.Reflection.Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute)).FirstOrDefault() as AssemblyCompanyAttribute;
            AssemblyCopyrightAttribute copyrightAttribute = System.Reflection.Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute)).FirstOrDefault() as AssemblyCopyrightAttribute;

            // Pour les infos que l'on as on valorise les propriété qui vont bien
            if (titleAttribute != null)
            { this.Title = titleAttribute.Title; }

            if (descriptionAttribute != null)
            { this.Description = descriptionAttribute.Description; }

            if (copyrightAttribute != null)
            { this.Copyright = copyrightAttribute.Copyright; }

            // Pour la version c'est un poil différent
            this.Version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();

            this._eventAggregator.GetEvent<SplashEvent>().Subscribe(UpdateMessage);

        }

        private void UpdateMessage(String message)
        {
            this.Dispatcher.Invoke(new Action(delegate()
            {            
                this.Message = message;            
                this.RaisePropertyChanged("Message");
            }));
        }
        /// <summary>
        /// Dispatcher mais du Thread STA de Splash attention
        /// </summary>
        private Dispatcher Dispatcher { get; set; }

        /// <summary>
        /// Cré la fenetre
        /// </summary>
        private void StartShowSplash()
        {
            // On récupere le dispatcher du thread STA
            this.Dispatcher = Dispatcher.CurrentDispatcher;
            // On cré la fenetre
            _splashView = new SplashView(this);
            // On observe les pressions de touche
            _splashView.KeyDown += _splashView_KeyDown;
            // On affiche la fenêtre
            _splashView.Show();
            _splashView.Activate();
            // On prévient le resetevent que le boulot est fait
            _resetEvent.Set();
            // On lance le dispatcher pour affiché la fenêtre
            System.Windows.Threading.Dispatcher.Run();


        }

        void _splashView_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.F8)
            {
                this.SplashUserAction = SplashUserAction.ChooseDatabase;
                this._waitForUserAction = false;
            }
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                this.SplashUserAction = SplashUserAction.Exit;
                this._waitForUserAction = false;
            }
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                this._waitForUserAction = false;
            }
        }

      
        public void CloseSplash()
        {
            this.Dispatcher.Invoke(new Action(delegate()
            {
                _splashView.Close();
            }));



        }


        public Task CreateTaskWaitingUserAction(int ms)
        {
            _waitForUserAction = true;
            Task task = new Task(new Action(delegate()
            {

                for (int i = 0; i < ms; i++)
                {
                    if (_waitForUserAction) Thread.Sleep(1);
                    this.Dispatcher.Invoke(new Action(delegate()
                    {
                        this.Progress = (int)(((double)i / (double)ms) * 100D);
                        this.Message = "Choix de la base de donnée (F8)";
                        this.RaisePropertyChanged("Progress");
                        this.RaisePropertyChanged("Message");
                    }));

                }
            }));
            return task;
        }
    }
}
