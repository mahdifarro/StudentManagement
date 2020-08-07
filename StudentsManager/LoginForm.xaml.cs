using System;
using System.Collections.Generic;
using System.IO;
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

namespace StudentsManager
{
    /// <summary>
    /// User identifier page
    /// </summary>
    public partial class LoginForm : Window
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        //close button
        //closes app
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        //login button
        //checks user's username & pass from users list
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LabelPassed.Content = "";
            string UserName = txt_Usuario.Text;
            string Password = txt_Password.Password.ToString();

            ReadWriteJson file = new ReadWriteJson();
            try
            {
                User userDetails = file.searchUser(UserName);

                if (Password == userDetails.Password && userDetails.Role == "Manager")
                {
                    AdminWindow main = new AdminWindow(userDetails);
                    this.Close();
                    main.ShowDialog();
                }
                else if (Password != userDetails.Password && userDetails.Role == "Manager")
                {
                    LabelPassed.Content = "Wrong password";
                    txt_Password.BorderBrush = Brushes.Red;
                }
                else
                    LabelPassed.Content = "Students can't login!";
            }
            catch (FormatException)
            {
                LabelPassed.Content = "Wrong Input,please check national code!";
                txt_Password.BorderBrush = Brushes.Red;
            }
            catch (FileNotFoundException)
            {
                LabelPassed.Content = "User not found!";
                txt_Usuario.BorderBrush = Brushes.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InstallerAssistant assistant = new InstallerAssistant();
            string PicName = assistant.AppPath + @"loginwpf.PNG";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(PicName);
            bitmap.EndInit();
            backgroundImage.ImageSource = bitmap;
        }
    }
}
