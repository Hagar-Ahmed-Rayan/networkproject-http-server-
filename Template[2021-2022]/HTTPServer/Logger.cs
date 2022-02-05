using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    class Logger
    {
        //static StreamWriter sr = new StreamWriter("log.txt");
        public static void LogException(Exception ex)
        {
            // TODO: Create log file named log.txt to log exception details in it
            //FileStream fs = new FileStream(@"D:\STUDY\networks\Template[2021-2022]
            // \HTTPServer\bin\Debug\log.txt",   FileMode.OpenOrCreate);
            //Datetime:
            //message:
            // for each exception write its details associated with datetime 
            StreamWriter sr = new StreamWriter("log.txt");
            sr.WriteLine("date time: " + DateTime.Now.ToString());
            sr.WriteLine("massege: " + ex.Message);

            sr.Close();
        }
    }
}