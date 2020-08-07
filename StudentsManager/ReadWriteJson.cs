using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StudentsManager.UserControls;

namespace StudentsManager
{
    class ReadWriteJson
    {
        InstallerAssistant assistant = new InstallerAssistant();
        

        //read files and make a user list from the file
        private List<User> ReadUser()
        {
            string path = assistant.AppPath + "\\list\\userDetails.txt";
            if (File.Exists(path))
            {
                List<User> usersList = new List<User>();
                string[] list = File.ReadAllLines(path);
                foreach (string user in list)
                {
                    User userDetail = JsonConvert.DeserializeObject<User>(user);
                    usersList.Add(userDetail);
                }
                return usersList;
            }
            else
                throw new FileNotFoundException("File not existed!");
        }

        private void WriteFile(List<User> usersList)
        {
            DeleteWord();

            string path = assistant.AppPath + "\\list\\userDetails.txt";

                foreach (User user in usersList)
                {
                    WriteUser(user);
                }
        }

        public void WriteWord()
        {
            List<User> usersList = ReadUser();
            string path = assistant.AppPath + "\\list\\userDetails.doc";


            foreach (User user in usersList)
            {
                WriteUserWord(user);
            }

        }

        //check if given username is duplicate or not
        public bool CheckUser(string userName)
        {
            string path = assistant.AppPath + "\\list\\userDetails.txt";

            List<User> usersList = ReadUser();
            foreach (User user in usersList)
            {
                if (user.Name.Equals(userName))
                {
                    return true;
                }
            }
            return false;
        }

        // Search file by user's name and return found user 
        public User searchUser(string userName)
        {
            List<User> usersList = ReadUser();
            foreach (User user in usersList)
            {
                if (user.Name.Equals(userName))
                {
                    return user;
                }
            }
            throw new FileNotFoundException("User not existed!");
        }

        // Search file by user's national code and return found user 
        public User searchUser(int nationalCode)
        {
            List<User> usersList = ReadUser();
            foreach (User user in usersList)
            {
                if (user.NationalCode == nationalCode)
                {
                    return user;
                }
            }
            throw new FileNotFoundException("User not existed!");
        }

        // Write user info to pre-selected path
        public void WriteUser(User userDetails)
        {
            string path = assistant.AppPath + @"\list\userDetails.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(JsonConvert.SerializeObject(userDetails));
            }
        }

        public void WriteUserWord(User userDetails)
        {
            string path = assistant.AppPath + @"\list\userList.doc";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(userDetails.ToString()); ;
            }
        }

        // Delete users data file from selected path
        public void DeleteFile()
        {
            string path = assistant.AppPath + @"\list\userDetails.txt";

            File.Delete(path);
        }

        private void DeleteWord()
        {
            string path = assistant.AppPath + @"\list\userList.doc";

            File.Delete(path);
        }

        // Edit selected user info to pre-selected path
        public void EditUser(User userDetails)
        {
            List<User> usersList = ReadUser();
            var item = usersList.SingleOrDefault(x => x.Name == userDetails.Name);
            usersList.Remove(item);
            usersList.Add(userDetails);
            DeleteFile();
            WriteFile(usersList);
        }

        // Delete selected user info to pre-selected path
        public void DeleteUser(string userName)
        {
            List<User> usersList = ReadUser();
            var item = usersList.SingleOrDefault(x => x.Name == userName);
            usersList.Remove(item);
            DeleteFile();
            WriteFile(usersList);
        }
    }
}
