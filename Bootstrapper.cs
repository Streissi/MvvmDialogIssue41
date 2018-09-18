using MvvmDialogs;
using Prism.Unity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MvvmDialogIssue41.Dialogs;

namespace MvvmDialogIssue41
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;

            App.Current.MainWindow.Show();

            var dialogService = Container.Resolve<IDialogService>();
            if (dialogService != null)
            {
                var mainViewModel = ((Window)Shell).DataContext as MainWindowViewModel;
                var dialogModel = Container.Resolve<InfoViewModel>();
                dialogService.ShowDialog(mainViewModel, dialogModel);
            }
        }

        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterInstance<IDialogService>(new DialogService(), new ContainerControlledLifetimeManager());
        }
    }
}
