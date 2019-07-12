using ModalProgress.ViewModels;
using System.Windows;

namespace ModalProgress.Views
{
    /// <summary>
    /// Interaction logic for ProgressWindow.xaml
    /// </summary>
    public partial class ProgressWindow : Window
    {
        public ProgressWindow()
        {
            InitializeComponent();
            this.DataContextChanged += (s1, e1) =>
            {
                if (this.DataContext is ProgressWindowViewModel vm)
                {
                    vm.Close += (s2, e2) =>
                    {
                        if (this.IsVisible)
                        {
                            this.Close();
                        }
                    };
                }
            };
        }
    }
}
