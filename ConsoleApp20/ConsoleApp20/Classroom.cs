using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Classroom
    {
      public string Name { get; set; }
      public int Id { get; set; }
        public Student[] Students;
        private static int _id=0;
        public ClassroomEnumtype Type { get; set; }



        public Classroom()
        {
            Id = ++_id;
            Students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            if ((Type == ClassroomEnumtype.Backend && Students.Length >= 20) || (Type == ClassroomEnumtype.Frontend && Students.Length >= 15))
                throw new Exception("limit dolmusdur");

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public Student Findid(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                    return student;
            }

            throw new Exception("telebe tapilmadi");
        }
        public void Deletestudent(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                 
                }
                else
                {
                    throw new Exception("telebe tapilmadi");
                }
                   
            }
        }


    }
}
