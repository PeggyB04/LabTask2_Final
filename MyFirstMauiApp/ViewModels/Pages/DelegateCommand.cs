using System.Windows.Input;

namespace MyFirstMauiApp.ViewModels.Pages
{
    internal class DelegateCommand : ICommand
    {
        public DelegateCommand(Action count)
        {
            Count = count;
        }

        public Action Count { get; }
    }
}