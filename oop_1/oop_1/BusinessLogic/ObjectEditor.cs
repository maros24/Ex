using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class ObjectEditor
    {
        public static Student[] getStudent(string bdstr)
        {
            string pattern = "\\b([A-Za-z]+\\b\\s*){2}\\{\\s*(\"([A-z]+)\":\"([A-Za-z0-9]+)\",\\s*)+\"([A-z]+)\":\"([A-Za-z0-9]+)\"\\s*\\};";
            string attrPatern = "\"[A-z]+\":\"([A-Za-z0-9]+)\"\\s*";
            Regex r = new Regex(pattern);
            Regex r2 = new Regex(attrPatern);
            MatchCollection mc = r.Matches(bdstr);
            Student[] students = new Student[mc.Count];
            string[] attr = new string[7];

            for (int i = 0; i < mc.Count; i++)
            {
                MatchCollection mc2 = r2.Matches(mc[i].Value);
                for (int j = 0; j < mc2.Count; j++)
                {
                    string value = mc2[j].Value;
                    if (value.Contains("firstname"))
                    {
                        attr[0] = mc2[j].Groups[1].Value;
                    }
                    if (value.Contains("lastname"))
                    {
                        attr[1] = mc2[j].Groups[1].Value;
                    }
                    if (value.Contains("course"))
                    {
                        attr[2] = mc2[j].Groups[1].Value;
                    }
                    if (value.Contains("StudentId"))
                    {
                        attr[3] = mc2[j].Groups[1].Value;
                    }
                    if (value.Contains("Army\""))
                    {
                        attr[4] = mc2[j].Groups[1].Value;
                    }
                    if (value.Contains("ArmyID"))
                    {
                        attr[5] = mc2[j].Groups[1].Value;
                    }
                    if (value.Contains("DriverID"))
                    {
                        attr[6] = mc2[j].Groups[1].Value;
                    }
                }
                Student st = new Student(attr[0], attr[1], int.Parse(attr[2]), attr[3], attr[4] == "True", attr[5], attr[6]);
                students[i] = st;
            }

            return students;
        }

        public static string getInfo(Student st)
        {

            string s = "Student " + st.FirstName + "\n{";
            s += "\"firstname\":\"" + st.FirstName + "\",\n";
            s += "\"lastname\":\"" + st.LastName + "\",\n";
            s += "\"course\":\"" + st.Course + "\",\n";
            s += "\"StudentId\":\"" + st.StudentID + "\",";
            s += "\n\"Army\":\"" + st.Army + "\",";
            if (st.Army)
                s += "\n\"ArmyID\":\"" + st.ArmyID + "\",";
            if (st.DriveID != null)
            {
                s += "\n\"DriverID\":\"" + st.DriveID + "\"";
            }
            else
            {
                s += "\n\"DriverID\":\"" + "null" + "\"";
            }
            s += "};\n";

            return s;
        }

    }
}
