using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.Text.RegularExpressions;

namespace DBAcess
{
    public class ObjectGenerator
    {
        public static Student[] stGen(string[] s)
        {
            Student[] students = new Student[s.Length];
            Regex r = new Regex("\"[A-z]+\":\"([A-Za-z0-9]+)\"\\s*");
            for (int i = 0; i < s.Length; i++)
            {
                MatchCollection mc = r.Matches(s[i]);
                string[] attr = new string[mc.Count];
                string[] values = new string[7];
                for (int j = 0; j < mc.Count; j++) {
                    attr[j] = mc[j].Value;
                }
                for(int j = 0; j < attr.Length; j++) {

                    if (attr[j].Contains("firstname")) {
                        values[0] = mc[j].Groups[1].Value;
                        //attr[j] = attr[j].Replace("\"", "");
                        //attr[j] = attr[j].Replace("firstname", "");
                        //attr[j] = attr[j].Replace(":", "");
                        //values[0] = attr[j];
                    }
                    if (attr[j].Contains("lastname")) {
                        values[1] = mc[j].Groups[1].Value;
                    }
                    if (attr[j].Contains("course"))
                    {
                        values[2] = mc[j].Groups[1].Value; ;
                    }
                    if (attr[j].Contains("StudentId"))
                    {
                        values[3] = mc[j].Groups[1].Value; 
                    }
                    if (attr[j].Contains("Army\""))
                    {
                        values[4] = mc[j].Groups[1].Value; 
                    }
                    if (attr[j].Contains("ArmyID"))
                    {
                        values[5] = mc[j].Groups[1].Value; ;
                    }
                    if (attr[j].Contains("DriverID"))
                    {
                        values[6] = mc[j].Groups[1].Value; 
                    }
                }
                Student student = new Student(values[0], values[1], int.Parse(values[2]), values[3], values[4] == "True", values[5], values[6]);
                students[i] = student;
            }


            return students;
        }
    }
}
