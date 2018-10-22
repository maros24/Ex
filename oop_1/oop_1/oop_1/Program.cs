using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BusinessLogic;
using DB;

namespace oop_1
{
    class Program
    {
        static string path = "C:/Users/Юрий/Desktop/oop_1/oop_1/DB\\TextFile1.txt";

        static void Main(string[] args)
        {
            MyFileEditor fe = new MyFileEditor();
            string s = fe.Read(path);
            Student[] students = ObjectEditor.getStudent(s);
            UI.UI.menu(students,path);


            Console.ReadKey();
        }
    }
}
