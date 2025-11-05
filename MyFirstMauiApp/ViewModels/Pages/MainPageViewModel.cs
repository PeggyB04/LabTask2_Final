using MyFirstMauiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMauiApp.ViewModels.Pages
{
    public class MainPageViewModel : BaseViewModel
    {
        public MyModel Model { get; set; }
        public string Message { get; set; }
        private int Counter { get; set; }

        public ICommand TestCommand { get; set; }

        public MainPageViewModel()
        {
            Message = "Click me.";
            Model = new();
            TestCommand = new DelegateCommand(Count);
        }

        private void Count()
        {
            Counter++;
            Message = $"Clicked {Counter}";
        }
    }
}
