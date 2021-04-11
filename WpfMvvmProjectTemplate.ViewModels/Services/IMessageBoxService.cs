using System.Threading.Tasks;

namespace WpfMvvmProjectTemplate.Services
{
    public enum ButtonOptions
    {
        Ok,
        OkCancel,
        YesNo
    }

    public interface IMessageBoxService
    {
        Task<bool> DisplayMessageBox(string title, string message, ButtonOptions buttonOptions = ButtonOptions.Ok);
    }
}
