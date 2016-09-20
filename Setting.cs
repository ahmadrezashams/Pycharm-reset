using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PycharmTrialReset
{
    class Setting
    {
       
        public static void Log(string text)
        {
            StreamWriter sw=null;
            try
            {
                string _path = AppDomain.CurrentDomain.BaseDirectory + @"\logfile.txt";
                sw= new StreamWriter(_path,true);
                sw.WriteLine(text);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {

                Log(DateTime.Now.Date.ToShortDateString() + " Error: " + ex.Message);
            }
           
           

        }
        public static void process()
        {
            try
            {
                    string _path = @"C:\Users\{0}\.PyCharm2016.2\config\eval\PyCharm162.evaluation.key";

                    _path = String.Format(_path, AppDomain.CurrentDomain.BaseDirectory.Split('\\')[2]);

                    if (File.Exists(_path)){
                        File.Delete(_path);
                     Log(DateTime.Now.ToString() + " (Work Service, Delete File)");
                    }
                     
                   
               
                
            }
            catch (Exception ex)
            {

                Log(DateTime.Now.Date.ToShortDateString() +" Error: " +ex.Message);
            }
           
        }
    }
}
