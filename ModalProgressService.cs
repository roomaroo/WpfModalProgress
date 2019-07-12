using ModalProgress.ViewModels;
using ModalProgress.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalProgress
{
    public class ModalProgressService
    {
        public void Run(Func<IProgress, Task> action)
        {
            var vm = new ProgressWindowViewModel { Action = action };
            var window = new ProgressWindow { DataContext = vm };
            window.ShowDialog();
        }
    }
}
