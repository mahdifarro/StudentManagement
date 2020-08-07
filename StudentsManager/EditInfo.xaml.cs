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

namespace StudentsManager
{
    /// <summary>
    /// Interaction logic for EditInfo.xaml
    /// </summary>
    public partial class EditInfo : Window
    {
        User admin = new User();
        public EditInfo(User admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Brush fill = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF622F96");
            nationalCodeTextBox.BorderBrush = fill;

            ReadWriteJson file = new ReadWriteJson();
            try
            {

                int nationalCode = Int32.Parse(nationalCodeTextBox.Text);
                string password = PasswordTextBox.Text;
                string description = descriptionTextBox.Text;

                User editedUser = new User(admin.Name, nationalCode, admin.ImageAddress,admin.Role, password, admin.IsAdmin, description);

                file.EditUser(editedUser);
                admin = editedUser;
                resultTextBox.Content = "Edited!";

            }
            catch (FormatException)
            {
                resultTextBox.Content = "Wrong format,please check national code!";
                nationalCodeTextBox.BorderBrush = Brushes.Red;
                //throw new  userControl/ArgumentFormatException();
            }
            catch (NullReferenceException)
            {
                resultTextBox.Content = "Fill the blank boxes!";
                nationalCodeTextBox.BorderBrush = Brushes.Red;
                typeDetectorBox.BorderBrush = Brushes.Red;
                //throw new  userControl/ArgumentNullException();
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
                ErrorLogger.LogError(excp);
                //pop error in center
                //UserControls.ErrorBox Error = new UserControls.ErrorBox();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            typeDetectorBox.Content = admin.Role;
            nameTextBox.Text = admin.Name;
            nationalCodeTextBox.Text = admin.NationalCode.ToString();
            PasswordTextBox.Text = admin.Password;
            string managerPicName = admin.ImageAddress;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(managerPicName);
            bitmap.EndInit();
            mainPic.Source = bitmap;
            descriptionTextBox.Text = admin.Description;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow main_window = new AdminWindow(admin);
            this.Close();
            main_window.ShowDialog();
        }
    }
}
