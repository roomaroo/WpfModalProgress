using Prism.Commands;
using Prism.Mvvm;
using System.Windows;
using System.Windows.Input;

namespace ModalProgress.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private readonly ModalProgressService modalProgressService;
        private readonly SlowService slowService;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ICommand DoWorkCommand { get; private set; }

        public MainWindowViewModel(ModalProgressService modalProgressService, SlowService slowService)
        {
            this.DoWorkCommand = new DelegateCommand(this.ExecuteDoWork);
            this.modalProgressService = modalProgressService;
            this.slowService = slowService;
        }

        private void ExecuteDoWork()
        {
            modalProgressService.Run(slowService.DoStuff);
            MessageBox.Show("Done");
        }
    }
}
