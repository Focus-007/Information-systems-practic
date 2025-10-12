using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    using System.Text.RegularExpressions;
    using System.Windows.Controls;
    using System.Windows.Media;

    public class InputValidator
    {
        // Паттерн для проверки email
        private static readonly string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        // Метод для проверки email
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            return Regex.IsMatch(email, EmailPattern);
        }

        // Метод для проверки пароля
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            return password.Length >= 6;
        }

        // Метод для проверки имени
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;
            return name.Length >= 3;
        }

        // Вспомогательные методы для WPF TextBox (опционально - для удобства использования)
        public static void ValidateEmailTextBox(TextBox textBox)
        {
            if (!IsValidEmail(textBox.Text))
            {
                textBox.BorderBrush = Brushes.Red;
                //  Дополнительно можно добавить ToolTip с сообщением об ошибке
                textBox.ToolTip = "Некорректный email";
            }
            else
            {
                textBox.BorderBrush = Brushes.Green; // Или другой цвет для валидного значения
                textBox.ToolTip = null; // Убираем ToolTip, если он был
            }
        }

        public static void ValidatePasswordTextBox(TextBox textBox)
        {
            if (!IsValidPassword(textBox.Text))
            {
                textBox.BorderBrush = Brushes.Red;
                textBox.ToolTip = "Пароль должен содержать не менее 6 символов";
            }
            else
            {
                textBox.BorderBrush = Brushes.Green;
                textBox.ToolTip = null;
            }
        }

        public static void ValidateNameTextBox(TextBox textBox)
        {
            if (!IsValidName(textBox.Text))
            {
                textBox.BorderBrush = Brushes.Red;
                textBox.ToolTip = "Имя должно содержать не менее 3 символов";
            }
            else
            {
                textBox.BorderBrush = Brushes.Green;
                textBox.ToolTip = null;
            }
        }
    }

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 form3 = new Window2();
            form3.Show();
            this.Hide();  // Скрываем Form1, не закрывая её
            form3.Closed += (s, args) => this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow form1 = new MainWindow();
            form1.Show();
            this.Hide();  // Скрываем Form1, не закрывая её
            form1.Closed += (s, args) => this.Close();
        }
    }
}
