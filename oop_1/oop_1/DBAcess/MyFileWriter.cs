using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DBAcess
{
    public class MyFileWriter
    {
        private bool append;

        public MyFileWriter() {
            append = true;
        }

        public MyFileWriter(bool append) {
            this.append = append;
        }

        public StreamWriter OpenForWrite(string path) {
            StreamWriter sw = null;
            try
            {
                if (append)
                    sw = new StreamWriter(path, true);
                else
                    sw = new StreamWriter(path,false);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

            return sw;
        }

        public void AddToEnd(string path,string obj) {
            StreamWriter sw = OpenForWrite(path);
            sw.WriteLine(obj);
            sw.Close();
        }

        public void Rewrite(string path, string obj) {
            StreamWriter sw = OpenForWrite(path);
            sw.WriteLine(obj);
            sw.Close();
        }
    }
}
