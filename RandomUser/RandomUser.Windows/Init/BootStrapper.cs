using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using RandomUser.Core.Interfaces.Repository;
using RandomUser.Core.Interfaces.Service;
using RandomUser.Core.Repository;
using RandomUser.Core.Service;
using RandomUser.Core.ViewModel;
using RandomUser.Windows.Service;

namespace RandomUser.Windows.Init
{
    public class BootStrapper
    {
        public BootStrapper()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Register Services
            SimpleIoc.Default.Register<IDataService, DataService>();
            SimpleIoc.Default.Register<IDialogService, DialogService>();
            SimpleIoc.Default.Register<IHttpClientService, HttpClientService>();
            SimpleIoc.Default.Register<IMappingService, MappingService>();
            SimpleIoc.Default.Register<IResourceService, ResourceService>();
            
            // Register Repositories
            SimpleIoc.Default.Register<IUserRepository, UserRepository>();

            // Register ViewModels
            SimpleIoc.Default.Register<UserOverviewViewModel>();
            SimpleIoc.Default.Register<UserDetailViewModel>();
        }

        public UserOverviewViewModel UserOverviewViewModel => SimpleIoc.Default.GetInstance<UserOverviewViewModel>();
        public UserDetailViewModel UserDetailViewModel => SimpleIoc.Default.GetInstance<UserDetailViewModel>();
    }
}