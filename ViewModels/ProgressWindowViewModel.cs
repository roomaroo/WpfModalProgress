using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModalProgress.ViewModels
{
    public class ProgressWindowViewModel : BindableBase, IProgress
    {
        public EventHandler Close;

        public Func<IProgress, Task> Action { get; set; }
        

        private string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        public ICommand StartWorkCommand { get; }

        private int progress;
        public int Progress
        {
            get { return progress; }
            set { SetProperty(ref progress, value); }
        }

        public ProgressWindowViewModel()
        {
            this.StartWorkCommand = new DelegateCommand(this.ExecuteStartWork);
        }

        private async void ExecuteStartWork()
        {
            if (this.Action != null)
            {
                await this.Action(this);
            }

            this.Close?.Invoke(this, EventArgs.Empty);
        }
    }
}
