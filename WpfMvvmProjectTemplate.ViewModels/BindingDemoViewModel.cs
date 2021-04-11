using System;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMvvmProjectTemplate.Services;
using WpfMvvmProjectTemplate.Utils;

namespace WpfMvvmProjectTemplate.ViewModels
{
    public class BindingDemoViewModel : BaseViewModel
    {
        private readonly IMessageBoxService _messageBoxService;

        public BindingDemoViewModel(IMessageBoxService messageBoxService)
        {
            this._messageBoxService = messageBoxService;

            GreetCommand = new DelegateCommandAsync(
                new Func<object, Task>(GreetCommandImpl), () => !string.IsNullOrEmpty(GuestName));
        }


        private string guestName;

        public string GuestName
        {
            get { return guestName; }
            set {
                guestName = value;
                OnPropertyChanged();
            }
        }

        public ICommand GreetCommand { get; set; }

        private async Task GreetCommandImpl(object arg)
        {
            await _messageBoxService.DisplayMessageBox("Greeting", $"Hi, {GuestName} ..!!!");
        }
    }
}
