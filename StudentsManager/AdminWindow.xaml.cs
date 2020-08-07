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
    /// dashboard of admin
    /// limited access for manager
    /// full access for admin
    /// </summary>
    public partial class AdminWindow : Window
    {
        User admin = new User();


        public AdminWindow(User user)
        {
            InitializeComponent();
            this.admin = user;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //loads current user info
        private void Load_Page(object sender, RoutedEventArgs e)
        {
            InstallerAssistant assistant = new InstallerAssistant();
            try
            {
                dasboard_name.Text = admin.Name;
                DescriptionPanel.Text = admin.Description;
                string managerPicName = admin.ImageAddress;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(managerPicName);
                bitmap.EndInit();
                adminPic.ImageSource = bitmap;

                
                string PicName = assistant.AppPath + @"Amazing.JPG";
                BitmapImage bitmapProfile = new BitmapImage();
                bitmapProfile.BeginInit();
                bitmapProfile.UriSource = new Uri(PicName);
                bitmapProfile.EndInit();
                backgroundImage.Source = bitmapProfile;
            }
            catch(Exception ex)
            {
                ErrorLogger.LogError(ex);
                MessageBox.Show(ex.Message);
            }

        }

        private void Search_Icon_Click(object sender, RoutedEventArgs e)
        {
            SearchEditPage search_edit = new SearchEditPage(admin);
            this.Close();
            search_edit.ShowDialog();
        }

        private void Add_Icon_Click(object sender, RoutedEventArgs e)
        {
            AddPage add = new AddPage(admin);
            this.Close();
            add.ShowDialog();
        }

        private void Out_Icon_Click(object sender, RoutedEventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Close();
            login.ShowDialog();
        }

        private void editInfo_Icon_Click(object sender, RoutedEventArgs e)
        {
            EditInfo edit = new EditInfo(admin);
            this.Close();
            edit.ShowDialog();
        }

        private void createWord_Icon_Click(object sender, RoutedEventArgs e)
        {
            ReadWriteJson file = new ReadWriteJson();
            file.WriteWord();
        }
    }
}
