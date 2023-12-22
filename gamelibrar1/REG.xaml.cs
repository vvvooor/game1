using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace gamelibrar1
{
    public partial class REG : Window
    {
        public REG()
        {
            InitializeComponent();
        }

         private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
          {
              //код для проверки валидности логина
              string username = UsernameTextBox.Text;

              if (!IsValidUsername(username))
              {
                  MessageBox.Show("Логин должен содержать только буквы и цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                  UsernameTextBox.Focus();
              }
          }

          private bool IsValidUsername(string username)
          {
              // Простая проверка валидности логина (буквы и цифры)
              return Regex.IsMatch(username, "^[a-zA-Z0-9]+$");
          }


          private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
          {
              // Ваш код для проверки валидности почты
              string email = EmailTextBox.Text;

              if (!IsValidEmail(email))
              {
                  MessageBox.Show("Некорректный адрес электронной почты", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                  EmailTextBox.Focus();
              }
          }

          private void RemoveTextPassword(object sender, RoutedEventArgs e)
          {
              // Ваш код для обработки фокуса на поле ввода пароля
              txtPasswordPlaceholder.Visibility = Visibility.Collapsed;
              txtPassword.Visibility = Visibility.Visible;
              txtPassword.Focus();
          }

          private bool IsValidEmail(string email)
          {
              // Простая проверка валидности адреса электронной почты (можно использовать другие методы)
              return email.Contains("@") && email.Contains(".");
          }


          private void NextButton_Click(object sender, RoutedEventArgs e)
          {
              // Ваш код для обработки нажатия кнопки "Далее"

              // Предположим, что NextPage - это ваша страница, на которую нужно перейти
              Frame frame = GetParentFrame(this);
              if (frame != null)
              {
                  frame.Navigate(new masterpage());
              }
          }

          private Frame GetParentFrame(UIElement element)
          {
              DependencyObject parent = VisualTreeHelper.GetParent(element);

              while (parent != null && !(parent is Frame))
              {
                  parent = VisualTreeHelper.GetParent(parent);
              }

              return parent as Frame;
          }
      }
  }
