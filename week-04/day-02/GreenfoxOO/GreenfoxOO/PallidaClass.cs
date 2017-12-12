using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOO
{
    class PallidaClass
    {
        public PallidaClass(string classname)
        {
            className = classname;
        }

        public string className { get; set; }

        List<Student> students = new List<Student>();
        List<Mentor> mentors = new List<Mentor>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            mentors.Add( mentor);
        }
        public void Info()
        {
            Console.WriteLine("Pallida"+ className+" class has"+ students.Count +" students and"+ mentors.Count  +"mentors.");
        }

    }
}
