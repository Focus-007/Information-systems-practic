using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop
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

        }

        private void Watermarkedtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Watermarkedtxt.Visibility = System.Windows.Visibility.Collapsed;
            userInput.Visibility = System.Windows.Visibility.Visible;
            userInput.Focus();
        }


        private void userInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput.Text))
            {
                userInput.Visibility = System.Windows.Visibility.Collapsed;
                Watermarkedtxt.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void userInput_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput.Text))
            {
                userInput.Visibility = System.Windows.Visibility.Collapsed;
                Watermarkedtxt.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Watermarkedtxt_GotFocus(object sender, RoutedEventArgs e)
        {
            Watermarkedtxt.Visibility = System.Windows.Visibility.Collapsed;
            userInput.Visibility = System.Windows.Visibility.Visible;
            userInput.Focus();
        }


       

    }
}