using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    public static class Admin
    {
        private static string filepath = "students.txt";
        public static void SaveStudents(string zapis)
        {
            using(StreamWriter sw = new StreamWriter(filepath, true))
            {
                sw.WriteLine(zapis);    
            }
        }
        public static  List<Student> LoadStudents()
        {
            List<Student> students = new List<Student>();
            if (File.Exists(filepath))
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        {
                            Student s = new Student();
                            s.Ime = parts[0];
                            s.Prezime = parts[1];
                            s.Datum_Rodenja =DateTime.Parse( parts[2]);
                            s.Razred = parts[3];
                            s.Broj_izostanaka =int.Parse(parts[4]);
                            s.Opravdano = int.Parse(parts[5]);
                            students.Add(s);
                        }

                        
                    }
                }
            }
            return students;
    
        }
        public static List<string> GetAllAsStrings()
        {
            List<string> students = new List<string>();
            List<Student> studentList = LoadStudents();
            return students;
            foreach (Student s in studentList)
            {
                students.Add(s.ToString()); 
            } 
            return students;
        }   
        public static List<string>SearhByName(string name)
        {
            List<string> students = new List<string>();
            List<Student> studentList = LoadStudents();
            foreach (Student s in studentList)
            {
                if (s.Ime==name)
                {
                    students.Add(s.ToString());
                }
            }
            return students;
        }
            public static List<string> GetCountByRazred(string razred){
            List<string> students = new List<string>();
            List<Student> studentList = LoadStudents();
            int count = 0;
            foreach (Student s in studentList)
            {
                if (s.Razred == razred)
                {
                    count++;
                }
            }
            students.Add("Broj učenika u razredu {razred} je: {count}");
            return students;


            }
        
    }


}
