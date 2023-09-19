using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Class4
{
    public class Passport
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public string DateOfBirth { get; set; }

        public Passport(string full_name, int id, string birth) 
        {  
            FullName = full_name;
            ID = id;
            DateOfBirth = birth;
        }

        public void Print()
        {
            Console.WriteLine("Full name: " + FullName);
            Console.WriteLine("Date of birth: " + DateOfBirth);
            Console.WriteLine("Id: " + ID);
        }
    }

    public class ForeignPassport : Passport
    {
        public int ForeignId { get; set; }
        public HashSet<string> Visas { get; set; }

        public ForeignPassport(string full_name, int id, string birth, int foreign_id, string visa) : base(full_name, id, birth)
        {
            ForeignId = foreign_id;
            Visas = new HashSet<string>();
            Visas.Add(visa);
        }

        public void AddVisa(string visa)
        {
            Visas.Add(visa);
        }

        public void PrintForeign()
        {
            Print();
            Console.WriteLine("Foreign passport id: " + ForeignId);
            Console.WriteLine("Visas: ");

            foreach (string visa in Visas)
            {
                Console.WriteLine(visa);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Passport passport = new Passport("QWe", 123, "zxc");
            passport.Print();

            Console.WriteLine("===============================");

            ForeignPassport foreignPassport = new ForeignPassport(passport.FullName, passport.ID, passport.DateOfBirth, 456, "rty");
            foreignPassport.AddVisa("vbn");
            foreignPassport.PrintForeign();
        }
    }
}
