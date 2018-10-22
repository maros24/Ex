using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace DBAcess
{
    //public class MyFileReader
    //{
    //    public string lastinfo;

    //    public string ReadFile(string path) {
    //        StreamReader sr = null;
    //        try
    //        {
    //            sr = new StreamReader(path);
    //            lastinfo = sr.ReadToEnd();
    //        }
    //        catch (FileNotFoundException)
    //        {

    //        }
    //        finally {
    //            sr.Close();
    //        }
    //        return lastinfo;
    //    }

    //    public string[] RegularObjectFind(string str) {
    //        string[] objects;
    //        string pattern = "(\\b[A-Za-z]+\\b\\s*){2}\\{\\s*(\"[A-z]+\":\"[A-Za-z0-9]+\",\\s*)+\"[A-z]+\":\"[A-Za-z0-9]+\"\\s*\\};"; 
    //        Regex r = new Regex(pattern);
    //        MatchCollection mc = r.Matches(str);
    //        objects = new string[mc.Count];
    //        if (mc.Count > 0) {
    //            for (int i = 0; i < mc.Count; i++) {
    //                objects[i] = mc[i].Value;
    //            }
    //        }

    //        return objects;
    //    }
    //}
}
