using WpfMvvmProjectTemplate.Services;
using WpfMvvmProjectTemplate.Utils;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmProjectTemplate.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IMessageBoxService _messageBoxService;

        public MainViewModel(IMessageBoxService messageBoxService)
        {
            _messageBoxService = messageBoxService;

            GoToBindingDemoCommand = new DelegateCommandAsync(new Func<object, Task>(GoToBindingDemo));
            GoToHomeCommand = new DelegateCommandAsync(new Func<object, Task>(GoToHome));

            HomeVM = new HomeViewModel();
            CurrentViewModel = HomeVM;
        }

        public string AppTitle => "WPF MVVM Template Project";
        public string AppCopyRightMessage => "Copyright 2021, WPF MVVM Project Template.";


        public ICommand GoToBindingDemoCommand { get; }
        public ICommand GoToHomeCommand { get; }


        BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel { 
            get => _currentViewModel;
            set {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public BindingDemoViewModel BindingDemoVM { get; private set; }
        public HomeViewModel HomeVM { get; private set; }

        private async Task GoToBindingDemo(object arg)
        {
            if (BindingDemoVM == null)
            {
                BindingDemoVM = new BindingDemoViewModel(_messageBoxService);
            }
            CurrentViewModel = BindingDemoVM;
        }

        private async Task GoToHome(object arg)
        {
            CurrentViewModel = HomeVM;
        }
    }
}
