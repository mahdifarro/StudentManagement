using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace StudentsManager.UserControls
{
    /// <summary>
    /// displays requested user's info
    /// </summary>
    public partial class UserDetails : System.Windows.Controls.UserControl
    {
        //todo write a function to calcute by national code
        //todo exceptions for each buttons

        User foundedUser = new User();
        string adminUser;
        //int foundedUserIndex;
        //string imageAdd;

        public UserDetails(User foundedUser,string admin)
        {
            InitializeComponent();
            this.foundedUser = foundedUser;
            this.adminUser = admin;
        }
        //private void BrowserButton_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog imageDir = new OpenFileDialog();
        //    imageDir.Filter = "image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
        //    if (imageDir.ShowDialog() == DialogResult.OK)
        //    {
        //        string managerPicName = imageDir.FileName;
        //        imageAdd = managerPicName;
        //        BitmapImage bitmap = new BitmapImage();
        //        bitmap.BeginInit();
        //        bitmap.UriSource = new Uri(managerPicName);
        //        bitmap.EndInit();
        //        mainPic.Source = bitmap;
        //    }
        //}

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = foundedUser.Name;
            nationalCodeTextBox.Text = foundedUser.NationalCode.ToString();
            descriptionTextBox.Text = foundedUser.Description;
            foundedUserTypeDetectorBox.Content = foundedUser.Role;
            //string managerPicName = foundedUser.ImageAddress;
            //imageAdd = managerPicName;
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.BeginInit();
            //bitmap.UriSource = new Uri(managerPicName);
            //bitmap.EndInit();
            //mainPic.Source = bitmap;
        }

        //edits selected user password and description
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InstallerAssistant assistant = new InstallerAssistant();
                ReadWriteJson file = new ReadWriteJson();

                string name = nameTextBox.Text;
                int nationalCode = Int32.Parse(nationalCodeTextBox.Text);

                //  being used by an unknown source!!!
                //if(imageAdd!= assistant.AppPath + @"Images\" + name + imageExtension)
                //{
                //    imageAddress = assistant.AppPath + @"Images\" + name + imageExtension;
                //    assistant.CopyFile(imageAdd, imageAddress);
                //}

                string description = descriptionTextBox.Text;

                User editedUser = new User(name, nationalCode, foundedUser.ImageAddress, foundedUser.Role, foundedUser.Password, foundedUser.IsAdmin, description);


                file.EditUser(editedUser);
                ((System.Windows.Controls.Panel)this.Parent).Children.Clear();
            }
            catch (FormatException)
            {
                nationalCodeTextBox.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        //deletes selected user
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReadWriteJson file = new ReadWriteJson();

                if (foundedUser.Name != adminUser)
                {
                    file.DeleteUser(foundedUser.Name);
                    File.Delete(foundedUser.ImageAddress);
                    ((System.Windows.Controls.Panel)this.Parent).Children.Remove(this);
                    //File.Delete(foundedUser.ImageAddress);
                }

            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

        }

    }
}