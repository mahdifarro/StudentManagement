using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    static class ErrorLogger
    {
       
        public static void LogError(Exception excp)
        {
            InstallerAssistant assistant = new InstallerAssistant();
            string path = assistant.AppPath+"Log.txt";
                string[] error= { DateTime.Now.ToString(), excp.Message ,excp.StackTrace};
                File.AppendAllLines(path,error);
        }
    }
}
