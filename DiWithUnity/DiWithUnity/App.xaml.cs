using DiWithUnity.Services;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DiWithUnity
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            UnityContainer _unityContainer = new UnityContainer();

            _unityContainer.RegisterType<IProductsService, ProductsService>();
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(_unityContainer));
            int a = 7;
            MainPage =new NavigationPage( new DiWithUnity.V.ProductsPage()); //new DiWithUnity.V.ProductsPage();// new DiWithUnity.MainPage();
            int b = 4;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
