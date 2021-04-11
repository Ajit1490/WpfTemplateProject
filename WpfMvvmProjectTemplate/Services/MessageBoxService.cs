using System.Threading.Tasks;
using System.Windows;

namespace WpfMvvmProjectTemplate.Services
{
    public sealed class MessageBoxService : IMessageBoxService
    {
        public Task<bool> DisplayMessageBox(string title, string message, ButtonOptions buttonOptions = ButtonOptions.Ok)
        {
            bool res;

            switch (buttonOptions)
            {
                case ButtonOptions.OkCancel:
                    res = MessageBox.Show(message, title, MessageBoxButton.OKCancel) == MessageBoxResult.OK;
                    break;
                case ButtonOptions.YesNo:
                    res = MessageBox.Show(message, title, MessageBoxButton.YesNo) == MessageBoxResult.Yes;
                    break;
                default:
                    res = MessageBox.Show(message, title, MessageBoxButton.OK) == MessageBoxResult.OK;
                    break;
            }

            return Task.FromResult(res);
        }
    }
}
