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
    /// edit & delete user page
    /// </summary>
    public partial class SearchEditPage : Window
    {
        private string loginRole;
        private bool IsAdmin;
        private User admin;

        public SearchEditPage(User admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.loginRole =admin.Role;
            this.IsAdmin = admin.IsAdmin;
        }
        // Searches for user (by name or national code) 
        // Returns user' info
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Content = "";

            ReadWriteJson file = new ReadWriteJson();

            try
            {
                string byType = typeDetectorBox.SelectedItem.ToString();
                string searchMethod = searchArgTextBox.Text;
                User foundUser = new User();

                if (byType.Equals("By Name"))
                {
                    foundUser = file.searchUser(searchMethod);
                }
                else if (byType.Equals("By National Code"))
                {
                    int nationalCode = int.Parse(searchMethod);
                    foundUser = file.searchUser(nationalCode);
                }

                if (foundUser.Role.Equals("Manager") && IsAdmin == false)
                    MessageBox.Show("Access limited");
                else
                {
                    UserControls.UserDetails userDetailUserControl = new UserControls.UserDetails(foundUser, admin.Name);
                    userDetailStackPanel.Children.Clear();
                    userDetailStackPanel.Children.Add(userDetailUserControl);

                    //if (searchMethod.Equals(admin.Name))
                    //    userDetailUserControl.nameTextBox.IsEnabled = true;
                }
            }
            catch (FormatException excp)
            {
                ErrorLogger.LogError(excp);
                resultTextBox.Content = "Wrong format,please check national code!";
                searchArgTextBox.BorderBrush = Brushes.Red;
                //throw new userControl/ ArgumentNullException();
            }
            catch (FileNotFoundException)
            {
                resultTextBox.Content = "UserName not Found!!";
                searchArgTextBox.BorderBrush = Brushes.Red;
                //throw new  userControl/ArgumentNullException();
            }

            catch (ArgumentNullException excp)
            {
                ErrorLogger.LogError(excp);
                resultTextBox.Content = "Data not Found!";
                //throw new  userControl/ArgumentNullException();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
                MessageBox.Show (ex.Message);
            }


        }

        //check to load managerAdd option
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            typeDetectorBox.Items.Insert(0, "By Name");
            typeDetectorBox.Items.Insert(1, "By National Code");
        }

        private void TypeDetectorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            searchArgTextBox.IsEnabled = true;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            {
                AdminWindow main_window = new AdminWindow(admin);
                this.Close();
                main_window.ShowDialog();
            }
        }
    }
}