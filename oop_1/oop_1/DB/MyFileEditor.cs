using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DB
{
    public class MyFileEditor
    {
        public string Read(string path) {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
            }
            catch (FileNotFoundException){
                ErrorFile();
                return null;
            }
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }

        public void Rewrite(string path,string obj) {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path, false);
            }
            catch (FileNotFoundException){
                ErrorFile();
                    Console.ReadKey();
                return;
            }
            sw.WriteLine(obj);
            sw.Close();
        }

        public void WriteToEnd(string path, string obj)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path, true);
            }
            catch (FileNotFoundException)
            {
                ErrorFile();
                return;
            }

            sw.WriteLine(obj);
            sw.Close();
        }

        public void ErrorFile() {
            Console.WriteLine("File not found");
        }

    }
}
