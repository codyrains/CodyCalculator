using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodyCalculator
{
    public class Logger
    {
        private string _logDirectory;
        private string _logFullPath;

        public Logger() 
        {
            SetLogFullPath();
        }

        public void Log(string msg)
        {
            FileCheck();

            using (StreamWriter sw = File.AppendText(_logFullPath))
            {
                string text = DateTime.Now.ToShortTimeString() + ": " + msg;
                sw.WriteLine(text);
            }
        }

        public void FileCheck()
        {
            if (!File.Exists(_logFullPath))
            {
                if (!Directory.Exists(_logDirectory))
                {
                    Directory.CreateDirectory(_logDirectory);
                }
                using (File.Create(_logFullPath));
            }
        }

        public void SetLogFullPath()
        {
            var fileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + ".txt";
            _logDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\")) + "CalculatorLog\\";
            _logFullPath = _logDirectory + fileName;
        }
    }
}
