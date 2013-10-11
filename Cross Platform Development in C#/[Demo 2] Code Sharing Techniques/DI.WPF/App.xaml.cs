using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DI.Core;
using Microsoft.Practices.Unity;
namespace DI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<Core.IMessageBoxService, MessageBoxService>();
            unityContainer.RegisterType<Core.IMessageService, MessageService>();
            var mainWindow = unityContainer.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
