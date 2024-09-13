using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp17
{
    internal class Program
    {
        public static void Add(string name, string surname, int age, List<string> strings)
        {
            strings.Add(name);
            strings.Add(surname);
            strings.Add(age.ToString());

        }

        public static void Remove(string name, string surname, int age, List<string> strings)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i < n + 3; i++)
            {
                strings.RemoveAt(i);
            }
        }

        public static void GetAll(List<string> strings)
        {
            int count = 0;
            for (int i = 0; i < strings.Count; i++)
            {
                Console.Write(strings[i] + " ");
                count++;
                if (count == 3)
                {
                    Console.WriteLine("\n");
                    count = 0;
                }
            }
        }

        public static void GetById(int n, List<string> strings)
        {


            for (int i = n; i < n + 3; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }

        public static void Add1(string mark, string model, int age, List<string> cars)
        {
            cars.Add(mark);
            cars.Add(model);
            cars.Add(age.ToString());
        }

        public static void Remove1(int n, List<string> cars)
        {

            for (int i = 0; i < 3; i++)
            {
                cars.RemoveAt(n);

            }
        }


        public static void GetAll1(List<string> cars)
        {
            int count = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                Console.Write(cars[i] + " ");
                count++;
                if (count == 3)
                {
                    Console.WriteLine("\n");
                    count = 0;
                }
            }
        }

        public static void GetById1(int n1, List<string> cars)
        {


            for (int i = n1; i <= n1 + 3; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }

        public static void CreateAnimals(string animal, string breed, string name, string[] animals, int k)
        {
            int index = 0;
            for (int i = index; i < k; i++)
            {
                animals[index] = animal;
                index++;
                animals[index] = name;
                index++;
                animals[index] = breed;
                index++;
            }
        }

        public static void RemoveAnimals(int n, string[] animals)
        {
            for (int i = n; i < animals.Length - 3; i++)
            {
                animals[i] = animals[i + 3];
            }

            animals[animals.Length - 3] = null;
            animals[animals.Length - 2] = null;
            animals[animals.Length - 1] = null;
        }


        public static void GetAllAnimals(string[] animals)
        {
            int count = 0;

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i] + "");
                count++;
                if (count == 3)
                {
                    Console.WriteLine("\n");
                    count = 0;
                }
            }
        }


        public static void GetByIdAnimals(int n1, string[] animals)
        {
            for (int i = n1; i < n1 + 3; i++)
            {
                Console.WriteLine(animals[i]);
            }
        }



        public static void AddPerson(string[] people, int id, string name, string surname, int age)
        {
            int emptyIndex = GetFirstEmptyIndex(people);
            people[emptyIndex] = id.ToString();
            people[emptyIndex + 1] = name;
            people[emptyIndex + 2] = surname;
            people[emptyIndex + 3] = age.ToString();
        }
        public static void RemovePerson(string[] people, int id)
        {
            int idIndex = GetPersonInfoStartIndex(people, id);
            people[idIndex] = null;
            people[idIndex + 1] = null;
            people[idIndex + 2] = null;
            people[idIndex + 3] = null;
        }
        public static void GetById(string[] people, int id)
        {
            int personStartIndex = GetPersonInfoStartIndex(people, id);
            for (int i = personStartIndex; i < personStartIndex + 4; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
        public static void PrintItems(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine("---------------------------------");
        }
        public static int GetPersonInfoStartIndex(string[] people, int id)
        {
            for (int i = 0; i < people.Length; i += 4)
            {
                if (people[i] == id.ToString())
                {
                    return i;
                }
            }
            return -1;
        }
        public static int GetFirstEmptyIndex(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }



        public static void AppendId(string[] people, int id, string name, string surname, int age)
        {
            for(int i = 0;i < people.Length;i++)
            {
                if(people[i] == id.ToString())
                {
                    people[i + 1] = name;
                    people[i + 2] = surname;
                    people[i + 3]=age.ToString();
                }
            }
        }

        static void Main(string[] args)
        {

            string[] people = new string[2000];
            AddPerson(people, 1, "Armen", "Poghosyan", 25);
            AddPerson(people, 2, "Armine", "Vardanyan", 25);
            AddPerson(people, 3, "Mane", "Soghomonyan", 25);
            PrintItems(people);
            RemovePerson(people, 2);
            PrintItems(people);
            AddPerson(people, 4, "Samvel", "Petrosyan", 30);
            PrintItems(people);
            GetById(people, 4);
            AppendId(people, 4, "Ani", "Ananyan", 20);
            PrintItems(people);
           //int k = Convert.ToInt32(Console.ReadLine());
            //string animal = null;
            //string breed = null;
            //string name = null;
            //string[] animals = new string[k * 3];
            //for (int i = 0; i < k; i++)
            //{
            //    animal = Console.ReadLine();
            //    breed = Console.ReadLine();
            //    name = Console.ReadLine();
            //    CreateAnimals(animal, breed, name, animals, k);
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //RemoveAnimals(n, animals);
            //GetAllAnimals(animals);
            //GetByIdAnimals(n1, animals);




            //int k = Convert.ToInt32(Console.ReadLine());
            //string mark = null;
            //string model = null;
            //int age = 0;
            //List<string> cars = new List<string>();
            //for (int i = 0; i < k; i++)
            //{
            //    mark = Console.ReadLine();
            //    model = Console.ReadLine();
            //    age = Convert.ToInt32(Console.ReadLine());
            //    Add1(mark, model, age, cars);
            //}
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Remove1(3, cars);
            //GetAll1(cars);
            //GetById1(n1, cars);
            //string name = null;
            //string surname = null;
            //int age = 0;
            //List<string> strings = new List<string>();

            //for (int i = 0; i < k; i++)
            //{
            //    name = Console.ReadLine();
            //    surname = Console.ReadLine();
            //    age = Convert.ToInt32(Console.ReadLine());

            //    Add(name, surname, age, strings);
            //}

            //Remove(name, surname, age, strings);
            //GetAll(strings);
            //int n = Convert.ToInt32(Console.ReadLine());
            //GetById(n, strings);
            Console.ReadLine();
        }
    }
}
