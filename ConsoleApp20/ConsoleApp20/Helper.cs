using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    
        public static class Helper
        {
            public static bool Checkname(string name)
            {
               
                if ( name.Length < 3)
                    return false;

               
                if (!char.IsUpper(name[0]))
                    return false;

               
                 

                return true;
            }
        public static bool Checksurname(string surname)
        {

            if (surname.Length < 3)
                return false;


            if (!char.IsUpper(surname[0]))
                return false;


           

            return true;
        }

        public static bool CheckClassroomname(string classroomname)
            {
               
                if (classroomname.Length != 5)
                    return false;

                for (int i = 0; i < 2; i++)
                {
                    if (!char.IsUpper(classroomname[i]))
                        return false;
                }

                for (int i = 2; i < 5; i++)
                {
                    if (!char.IsDigit(classroomname[i]))
                        return false;
                }

                return true;
            }
        }
    }

