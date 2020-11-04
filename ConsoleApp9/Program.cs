using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Cat 
    {
        
        
            public Cat(string name, DateTime birthday)
            {
                Name = name;
                Birthday = birthday;
            }

            public string Name
            {
                get; set;

            }

            public DateTime Birthday
            {

                get; set;

            }

            public void MakeNoise()
            {

                Console.WriteLine("Kit мяукает");

            }

            public int GetAge()
            {
                return (DateTime.Now - Birthday).Days / 365;
            }


            class Program
            {

                static void Main(string[] args)
                {


                    Cat cat = new Cat("Kit", new DateTime(2005, 8, 7));
                    Console.WriteLine($"Коту по имени {cat.Name} уже {cat.GetAge()} лет");
                    {
                    }
                }
            }
        }
        
        }
    

