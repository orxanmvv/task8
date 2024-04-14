using System.Xml.Linq;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classroom clasroom1=new Classroom();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. classroom yarat");
                Console.WriteLine("2. telebe yarat");
                Console.WriteLine("3. butun telebeleri ekrana cxart");
                Console.WriteLine("4. Secilmis sinifdeki telebeleri ekrana cixart");
                Console.WriteLine("5. telebeni cxart");
                Console.WriteLine("6. cixis");
                Console.Write("Seçenek: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateClassroom();
                        break;
                    case "2":
                        CreateStudent();
                        break;
                    case "3":
                        //ListAllStudents();
                        break;
                    case "4":
                        clasroom1.Findid(1);
                        break;
                    case "5":
                        //DeleteStudent();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek!");
                        break;
                }
            }
        }

        static void CreateClassroom()
        {
            Console.Write("classroomun adi: ");
            string name = Console.ReadLine();
            Console.Write("classroomun  tipi : ");
            string typeInput = Console.ReadLine();

            if (typeInput=="Frontend")
            {
                Console.WriteLine("classroom yaradilidi frontend");
            }
            else if (typeInput == "Backend")
            {
                Console.WriteLine("clasroom yaradildi backend");
            }
            else { Console.WriteLine("clasroom yaradilmadi"); }



        }
         static void CreateStudent()
        {
            Console.WriteLine("telebenin adi");
            string name = Console.ReadLine();

            Console.WriteLine("telebenin soyadi");

            string surname = Console.ReadLine();

            if (!Helper.Checkname(name) || !Helper.Checksurname(surname))
            {
                Console.WriteLine("student yaradildi");
            }
            else { Console.WriteLine("yanlis ad ve soyad daxil edilib"); }

        }
        

    }
    }
