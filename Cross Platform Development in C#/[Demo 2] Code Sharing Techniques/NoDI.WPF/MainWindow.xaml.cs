using System.Windows;
using WPF.Core;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageService messageService = new MessageService();
                messageService.ShowMessage(txtTitle.Text,txtBody.Text);
        }
    }
}
