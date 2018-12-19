using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> doctor = new List<Human>()
            {
                new Human { LastName = "Иванов", Age = 30, Weight = 75, Specialization = "Окулист" },
                new Human { LastName = "Петров", Age = 23, Weight = 59, Specialization = "Стоматолог" },
                new Human { LastName = "Сидоров",Age = 35, Weight = 80, Specialization = "Дерматолог" },
                new Human { LastName = "Макаров",Age = 49, Weight = 89, Specialization = "Хирург" },
             };

            Console.WriteLine(doctor);
            Console.ReadKey();

            var sortedDoc = from d in doctor 
            orderby d.LastName ascending
            select d; //сортировка по возрастанию фамилий

            foreach (Human d in sortedDoc)
                Console.WriteLine(d.LastName);
            Console.ReadKey();

            Console.WriteLine();
            var sortedDoctor = from d in doctor 
            orderby d.Specialization descending
            select d; //сортировка по убыванию названия направления

            foreach (Human d in sortedDoc)
                Console.WriteLine(d.Specialization);
            Console.ReadKey();
        }
    }
    public class Human
    {
        public string LastName {get;set;}
        public int Age {get;set;}
        public int Weight {get;set;}
        public string Specialization {get;set;}
    }
}



