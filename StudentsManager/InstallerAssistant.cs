using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudentsManager
{

    public class InstallerAssistant
    {
        private string appPath = AppDomain.CurrentDomain.BaseDirectory;

        public string AppPath
        {
            get
            {
                return appPath;
            }
        }
        public void CreateSubDirectory(string fileName)
        {
            fileName = appPath + fileName;
            System.IO.Directory.CreateDirectory(fileName);
        }

        public void MoveDirectory(string source,string destination)
        {
            System.IO.Directory.Move(source, destination);
        }

        public void MoveFile(string source, string destination)
        {
            System.IO.File.Move(source, destination);
        }

        public void CopyFile(string source, string destination)
        {
            System.IO.File.Copy(source, destination,true);
        }

        public bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;
            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }
    }
}
