using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Student
    {
        public int Id { get; set; }
        private static int _id=0;
        public string Surname { get; set; }
        public string Name { get; set; }
        public Student()
        {
            Id=++_id;
          
    }
    }
       
    }

