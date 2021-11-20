using System;
using System.Collections.Generic;

namespace NoteBookApp
{
    class Record
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public long Phone { get; set; }
        public string Country { get; set; }
        public string DateOfBithday { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string OtherNotes { get; set; }
        public Record()
        {
            Surname = "";
            Name = "";
            Lastname = "";
            Phone = 0;
            Country = "";
            DateOfBithday = "";
            Organization = "";
            Position = "";
            OtherNotes = "";

        }
        public override string ToString()
        {
            return $"{Surname}//{Name}//{Lastname}//{Phone}//{Country}//{DateOfBithday}//" +
                    $"{Organization}//{Position}//{OtherNotes}";
        }
    }
    class Program
    {        
        int id;
        List<Record> records = new List<Record>();
       
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
            long result;
            Record record = new Record();
            while (record.Surname == "")
            {
                Console.WriteLine("Enter surname");
                record.Surname = Console.ReadLine();
            }
            while (record.Name == "")
            {
                Console.WriteLine("Enter name");
                record.Name = Console.ReadLine();
            }
            while (record.Phone == 0)
            {
                Console.WriteLine("Enter phone");
                if (long.TryParse(Console.ReadLine(), out result))
                    record.Phone = result;
                else
                {
                    Console.WriteLine("Enter digits only.");

                }
            }
            Console.WriteLine("Enter country");
            record.Country = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            record.Lastname = Console.ReadLine();
            Console.WriteLine("Enter dateOfBithday");
            record.DateOfBithday = Console.ReadLine();
            Console.WriteLine("Enter organization");
            record.Organization = Console.ReadLine();
            Console.WriteLine("Enter position");
            record.Position = Console.ReadLine();
            Console.WriteLine("Enter otherNotes");
            record.OtherNotes = Console.ReadLine();
            records.Add(record);

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
                    records[i-1].Surname = Console.ReadLine();
                    break;
                case "name":
                    Console.WriteLine("Enter name");
                    records[i-1].Name = Console.ReadLine();
                    break;
                case "Lastname":
                    Console.WriteLine("Enter Lastname");
                    records[i - 1].Lastname = Console.ReadLine();
                    break;
                case "phone":
                    Console.WriteLine("Enter phone");
                    if (int.TryParse(Console.ReadLine(), out result))
                        records[i - 1].Phone = result;
                    else
                    {
                        Console.WriteLine("Eror");

                    }
                    break;
                case "country":
                    Console.WriteLine("Enter country");
                    records[i - 1].Country = Console.ReadLine();
                    break;
                case "dateOfBithday":
                    Console.WriteLine("Enter dateOfBithday");
                    records[i - 1].DateOfBithday  = Console.ReadLine();
                    break;
                case "organization":
                    Console.WriteLine("Enter organization");
                    records[i - 1].Organization = Console.ReadLine();
                    break;
                case "doljnost":
                    Console.WriteLine("Enter doljnost");
                    records[i - 1].Position  = Console.ReadLine();
                    break;
                case "otherNotes":
                    Console.WriteLine("Enter otherNotes");
                    records[i - 1].OtherNotes  = Console.ReadLine();
                    break;
            }
        }
        public void DeleteNote()
        {
            Console.WriteLine("Enter id which you want to delete");
            int i = Convert.ToInt32(Console.ReadLine()) - 1;
            if(i < records.Count)
            records.RemoveAt(i);                        
           
        }

        public void LookNotes()
        {

            for (int i = 0; i < records.Count; i++)
            {

                Console.WriteLine(i+1 + "//" + records[i]);
            }
              
        }
        public void LookShortNotes()
        {
            for (int i = 0; i < records.Count; i++)
            {
                
                Console.WriteLine($"{i + 1}//{records[i].Surname }//{records[i].Name}//{records[i].Phone}");
               
            }
        }
    }
}
