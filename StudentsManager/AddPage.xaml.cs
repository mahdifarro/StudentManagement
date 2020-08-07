using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace StudentsManager
{
    /// <summary>
    /// adds user to userlist
    /// </summary>
    public partial class AddPage : Window
    {
        //checks it a admin or manager (manager has limits)
        InstallerAssistant assistant = new InstallerAssistant();

        private User admin;
        private string loginRole;
        private bool IsAdmin;
        string imageAdd;

        public AddPage(User admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.loginRole = admin.Role;
            this.IsAdmin = admin.IsAdmin;
        }

        //sumbit a new user
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Brush fill = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF622F96");
            nameTextBox.BorderBrush = fill;
            nationalCodeTextBox.BorderBrush = fill;
            typeDetectorBox.BorderBrush = fill;

            ReadWriteJson file = new ReadWriteJson();
            try
            {
                
                string name = nameTextBox.Text;
                int nationalCode = Int32.Parse(nationalCodeTextBox.Text);
                string imageAddress = mainPic.Source.ToString();
                string role = typeDetectorBox.Text;
                string description = descriptionTextBox.Text;
                bool isAdmin;

                if (adminChecker.IsChecked == true)
                    isAdmin = true;
                else
                    isAdmin = false;

                if (typeDetectorBox.SelectedIndex == -1)
                    throw new NullReferenceException();
                else if (file.CheckUser(name) != false)
                {
                    resultTextBox.Content = "User already existed!Choose another Name";
                    nameTextBox.BorderBrush = Brushes.Red;
                }   
                string imageExtension=Path.GetExtension(imageAdd);
                assistant.CopyFile(imageAdd, assistant.AppPath + @"Images\" + name+imageExtension);
                imageAddress = assistant.AppPath + @"Images\" + name+imageExtension;
                User newUser = new User(name, nationalCode, imageAddress, role, nationalCode.ToString(), isAdmin, description);

                file.WriteUser(newUser);
                
                resultTextBox.Content = "Registered!";

                nameTextBox.Text = "";
                nationalCodeTextBox.Text = "";
                string PicName = assistant.AppPath + @"NoImage.PNG";
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(PicName);
                bitmap.EndInit();
                mainPic.Source = bitmap;
                typeDetectorBox.SelectedIndex = -1;
                adminChecker.IsChecked = false;
                descriptionTextBox.Text="";

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
                nameTextBox.BorderBrush = Brushes.Red;
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

        //browse profile image
        private void Browser_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog imageDir = new OpenFileDialog();
            imageDir.Filter = "image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (imageDir.ShowDialog() == true)
            {
                string managerPicName = imageDir.FileName;
                imageAdd = managerPicName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(managerPicName);
                bitmap.EndInit();
                mainPic.Source = bitmap;
            }

        }

        //check to load managerAdd option
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            typeDetectorBox.Items.Insert(0, "Student");
            imageAdd = assistant.AppPath + @"NoImage.PNG";
            if (loginRole == "Manager" && IsAdmin == true)
            {

                typeDetectorBox.Items.Insert(1, "Manager");
            }
        }

        //checks to load adminAdd option
        ///!!!!!
        ///typeDetectorBox.SelectedItem returns null
        private void TypeDetectorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            adminChecker.Visibility = Visibility.Hidden;
            try
            {
                int type = typeDetectorBox.SelectedIndex;

                if (type==1)
                    adminChecker.Visibility = Visibility.Visible;
                else if (type==2)
                {
                    adminChecker.Visibility = Visibility.Hidden;
                }
                adminChecker.IsChecked = false;
            }
            catch (Exception excp)
            {
                ErrorLogger.LogError(excp);
                MessageBox.Show(excp.Message);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow main_window = new AdminWindow(admin);
            this.Close();
            main_window.ShowDialog();
        }
    }
}
