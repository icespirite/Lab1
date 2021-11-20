using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        public static int lenght = 100;
        int id;
        public List<string> surname = new List<string>();
        public List<string> name = new List<string>();
        public List<string> lastname = new List<string>();
        public List<int> phone = new List<int>();
        public List<string> country = new List<string>();
        public List<string> dateOfBithday = new List<string>();
        public List<string> organization = new List<string>();
        public List<string> position = new List<string>();
        public List<string> otherNotes = new List<string>();
       
        static void Main(string[] args)
        {
            Program pro = new Program();
            Console.WriteLine("NOTEBOOK");

            while (true)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - create note");
                Console.WriteLine("2 - edit note");
                Console.WriteLine("3 - delete note");
                Console.WriteLine("4 - view notes");
                Console.WriteLine("5 - view short notes");
                Console.WriteLine("0 - exit");
                int k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        pro.CreateNote();
                        break;
                    case 2:
                        pro.EditNote();
                        break;
                    case 3:
                        pro.DeleteNote();
                        break;
                    case 4:
                        pro.LookNotes();
                        break;
                    case 5:
                        pro.LookShortNotes();
                        break;
                    case 0: break;
                }

                if (k == 0) break;
            }

        }
        public void CreateNote()
        {

            int result;




            Console.WriteLine("Enter surname");
            surname.Add(Console.ReadLine());
            Console.WriteLine("Enter name");
            name.Add(Console.ReadLine());

            Console.WriteLine("Enter phone");
            if (int.TryParse(Console.ReadLine(), out result))
                phone.Add(result);
            else
            {
                Console.WriteLine("Eror");

            }
            Console.WriteLine("Enter country");
            country.Add(Console.ReadLine());
            Console.WriteLine("Enter lastname");
            lastname.Add(Console.ReadLine());
            Console.WriteLine("Enter dateOfBithday");
            dateOfBithday.Add(Console.ReadLine());
            Console.WriteLine("Enter organization");
            organization.Add(Console.ReadLine());
            Console.WriteLine("Enter position");
            position.Add(Console.ReadLine());
            Console.WriteLine("Enter otherNotes");
            otherNotes.Add(Console.ReadLine());
            

        }
        public void EditNote()
        {
            Console.WriteLine("Enter id number of note");
            int i = Convert.ToInt32(Console.ReadLine());
             
                Console.WriteLine("Enter which field you want to edit");
                string k = Console.ReadLine();
                int result;
            switch (k)
            {
                case "surname":
                    Console.WriteLine("Enter surname");
                    surname[i - 1] = Console.ReadLine();
                    break;
                case "name":
                    Console.WriteLine("Enter name");
                    name[i - 1] = Console.ReadLine();
                    break;
                case "Lastname":
                    Console.WriteLine("Enter Lastname");
                    lastname[i - 1] = Console.ReadLine();
                    break;
                case "phone":
                    Console.WriteLine("Enter phone");
                    if (int.TryParse(Console.ReadLine(), out result))
                        phone[i - 1] = result;
                    else
                    {
                        Console.WriteLine("Eror");

                    }
                    break;
                case "country":
                    Console.WriteLine("Enter country");
                    country[i - 1] = Console.ReadLine();
                    break;
                case "dateOfBithday":
                    Console.WriteLine("Enter dateOfBithday");
                    dateOfBithday[i - 1] = Console.ReadLine();
                    break;
                case "organization":
                    Console.WriteLine("Enter organization");
                    organization[i - 1] = Console.ReadLine();
                    break;
                case "doljnost":
                    Console.WriteLine("Enter doljnost");
                    position[i - 1] = Console.ReadLine();
                    break;
                case "otherNotes":
                    Console.WriteLine("Enter otherNotes");
                    otherNotes[i - 1] = Console.ReadLine();
                    break;
            }
        }
        public void DeleteNote()
        {
            Console.WriteLine("Enter id which you want to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            id = id - 1;
            name.RemoveAt(id);
            
           
        }

        public void LookNotes()
        {

            for (int i = 0; i < surname.Count; i++)
            {

                Console.WriteLine($"{i + 1}//{surname[i]}//{name[i]}//{lastname[i]}//{phone[i]}//{country[i]}//{dateOfBithday[i]}//" +
                    $"{organization[i]}//{position[i]}//{otherNotes[i]}");
            }
              
        }
        public void LookShortNotes()
        {
            for (int i = 0; i < name.Count; i++)
            {
                
                Console.WriteLine($"{i + 1}//{surname[i]}//{name[i]}//{phone[i]}");
               
            }
        }
    }
}
