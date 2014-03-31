using Emash.GeoPat.Layers.Shared.Enums;
using System;
using System.Threading.Tasks;
namespace Emash.GeoPat.Layers.Shared.Services
{
   public  interface ISplashService
    {
        void CloseSplash();
        Task CreateTaskWaitingUserAction(int ms);
        void ShowSplash();
        SplashUserAction SplashUserAction { get; set; }
    }
}
