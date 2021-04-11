using System.Windows;
using WpfMvvmProjectTemplate;
using WpfMvvmProjectTemplate.Services;
using WpfMvvmProjectTemplate.ViewModels;

namespace WpfMvvmProjectTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.MainWindowContentPresenter.Content = new MainViewModel(new MessageBoxService());
            mainWindow.Show();
        }
    }
}
