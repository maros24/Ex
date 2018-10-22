using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace UI
{
    public class UI
    {
        public static Student[] student;
        static string path;

        public static void menu(Student[] students, string paths) {
           path = paths;
            student = students;
            while (true) {
                Console.Clear();
                Console.WriteLine("Choose action: 1-Show students 2-add student 3-remove student 4-find students");
                int x = 0;
                try {
                     x = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Wrong format!");
                }
                if (x > 0 && x < 5)
                {
                    switch (x)
                    {
                        case 1:
                            StudentShow();
                            break;
                        case 2:
                            AddStudent();
                            break;
                        case 3:
                            Console.WriteLine("Enter index for removing");
                            int i = Convert.ToInt32(Console.ReadLine());
                            if (i < student.Length)
                            {
                                RemoveStudent(i);
                            }
                            else
                            {
                                Console.WriteLine("Wrong index!");
                            }
                            break;
                        case 4:
                            Find();
                            break;
                    }
                }
                else {
                    Console.WriteLine("Unknown action!");
                }
                Console.ReadKey();
            }
            
        }

        private static void StudentShow() {
            if (student.Length > 0)
            {
                for (int i = 0; i < student.Length; i++)
                {
                    Console.WriteLine("Name : " + student[i].FirstName);
                    Console.WriteLine("LastName : " + student[i].LastName);
                    Console.WriteLine("Course : " + student[i].Course);
                    Console.WriteLine("StudentID : " + student[i].StudentID);
                    Console.WriteLine("Army : " + student[i].Army);
                    if (student[i].Army)
                    {
                        Console.WriteLine("ArmyID : " + student[i].ArmyID);
                    }
                    if (student[i].DriveID != null)
                        Console.WriteLine("DriverID : " + student[i].DriveID);

                    Console.WriteLine("\n\n");
                }
            }
            else {
                Console.WriteLine("Couldn't find any info");
            }
        }

        private static void AddStudent() {
            string name = "", lastname = "", StudentId = "", armyId = null, driverId = null;
            int course = 0;
            bool army = false;
            try
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter lastname: ");
                lastname = Console.ReadLine();
                Console.WriteLine("Enter StudentId: ");
                StudentId = Console.ReadLine();
                Console.WriteLine("Enter course: ");
                course = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter army: ");
                army = Convert.ToBoolean(Console.ReadLine());
                armyId = null;
                if (army)
                {
                    Console.WriteLine("Enter armyid: ");
                    armyId = Console.ReadLine();
                }
                Console.WriteLine("Enter DriverId: ");
                driverId = Console.ReadLine();
                if (driverId == "none") driverId = null;
            }
            catch (FormatException){
                Console.WriteLine("Invalid format!");
                return;
            }
            Student st = new Student(name,lastname,course,StudentId,army,armyId, driverId);
            Student[] tmp = new Student[student.Length + 1];
            for (int i = 0; i < student.Length; i++) {
                tmp[i] = student[i];
            }
            tmp[tmp.Length - 1] = st;
            student = tmp;
            DB.MyFileEditor fw = new DB.MyFileEditor();
            fw.WriteToEnd(path,ObjectEditor.getInfo(st));
            Console.WriteLine("Student added");
        }

        public static void RemoveStudent(int index) {
            if (index < student.Length)
            {
                Student st = student[index];
                DB.MyFileEditor fe = new DB.MyFileEditor();
                string s = fe.Read(path);
                s = s.Replace(ObjectEditor.getInfo(st), String.Empty);
                s = s.Replace("\n\n\n","\n");
                s = s.Replace("\n\n","\n");
                fe.Rewrite(path, s);
                student = ObjectEditor.getStudent(s);
                Console.WriteLine("Student " +index+" removed");
            }
            else {
                Console.WriteLine("Wrong index!");
            }
        }

        public static void Find() {
            int count = 0;
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].Army && student[i].Course == 5) {
                    Console.WriteLine("Name : " + student[i].FirstName);
                    Console.WriteLine("LastName : " + student[i].LastName);
                    Console.WriteLine("Course : " + student[i].Course);
                    Console.WriteLine("StudentID : " + student[i].StudentID);
                    Console.WriteLine("Army : " + student[i].Army);
                    if (student[i].Army)
                    {
                        Console.WriteLine("ArmyID : " + student[i].ArmyID);
                    }
                    if (student[i].DriveID != null)
                        Console.WriteLine("DriverID : " + student[i].DriveID);

                    Console.WriteLine("\n\n");

                    count++;
                }
            }

            Console.WriteLine("Count of students = " + count);
        }
    }
}
