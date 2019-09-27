using System;
using System.Collections.Generic;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int[,] myArray = new int[10,10];

            List<int> intList = new List<int>();
            intList.Add(3);
            intList.Add(5);
            intList.Add(2);
            intList.Add(7);
            intList.Add(11);
            intList.Add(1);
            intList.Insert(3, 8);
            
            intList.Remove(7);
            bool indeholder8 = intList.Contains(8);
            if (indeholder8)
                Console.WriteLine("Indeholder 8");

            intList[2] = 22;
            intList.Insert(5, 10);

            intList.RemoveAt(3);
            
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Listen efter sortering");
            intList.Sort();
            intList.Reverse();
            //foreach (int i in intList)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine($"På index {i} ligger værdien {intList[i]}");
            }

            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Hjort");
            Animal a3 = new Animal(4, "Spurv");
            Animal a4 = new Animal(6, "Hval");

            List<Animal> animalList = new List<Animal>(){a1, a2, a3, a4};
            //animalList.Add(a1);

            foreach (Animal animal in animalList)
            {
                Console.WriteLine($"{animal.Art } med alderen {animal.Age } ");
            }
            
            Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}