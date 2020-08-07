using System;

namespace StudentsManager
{
    /// <summary>
    /// User class 
    /// contains user info
    /// </summary>
    public class User
    {
        public string Name { get; set; }
        public int NationalCode { get; set; }
        public string ImageAddress { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string Description { get; set; }


        // User class defualt constructor
        public User()
        {
            Name = null;
            NationalCode = 0;
            ImageAddress = null;
            Role = null;
            Password = null;
            IsAdmin = false;
            Description = null;
        }
        // User class constructor
        public User(string Name, int NationalCode, string ImageAddress, string Role, string Password, bool IsAdmin, string Description)
        {
            this.Name = Name;
            this.NationalCode = NationalCode;
            this.ImageAddress = ImageAddress;
            this.Role = Role;
            if (this.Role.Equals("Manager"))
                this.Password = Password;
            else
                this.Password = "0";
            this.IsAdmin = IsAdmin;
            this.Description = Description;
        }

        // converts all infos into one string
        public override string ToString()
        {
            return ("Name:" + this.Name + "   " + "NationalCode:" + this.NationalCode.ToString() + "   " + "Role:" + this.Role + "\n" + "Description:" + this.Description);
        }
    }
}
