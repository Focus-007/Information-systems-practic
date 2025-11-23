using System.Text;
using System.Text.RegularExpressions;
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
            Window2 form3 = new Window2();
            form3.Show();
            this.Hide();  // Скрываем Form1, не закрывая её
            form3.Closed += (s, args) => this.Close();
        }

       
        private void Регистрация_Click(object sender, RoutedEventArgs e)
        {
            Window1 form2 = new Window1();
            form2.Show();
            this.Hide();  // Скрываем Form1, не закрывая её
            form2.Closed += (s, args) => this.Close();
        }
    }
}