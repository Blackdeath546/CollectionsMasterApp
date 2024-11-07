using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] intArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            static void RandomPopulate(int[] array)
            {
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                { 
                    array[i] = (rand.Next(0, 51));
                }
            }
            RandomPopulate(intArray);
            //Console.WriteLine($"{intArray[0]}, {intArray[2]}");

            //TODO: Print the first number of the array
            Console.WriteLine(intArray[0]);

            //TODO: Print the last number of the array   
            Console.WriteLine(intArray[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            
            Array.Reverse(intArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 3 == 0)
                {
                    intArray[i] = 0;
                    Console.WriteLine(intArray[i]);
                }
                else
                {
                    Console.WriteLine(intArray[i]);
                }
                
            }

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(intArray);
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
           
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> intList = new List<int>();

            //TODO: Print the capacity of the list to the console

            //int capacity = intList.Capacity;
            
            Console.WriteLine("Capacity: " + intList.Capacity);
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            static void RandomList(List<int> intList, int capacity)
            {
                Random rand = new Random();
                for (int i = 0; i < capacity; i++)
                {
                    intList.Add(rand.Next(0, 51));
                }
                
            }



            //intList.Add(RandomList(intList, 50));
            RandomList(intList,50);
            
            
            //TODO: Print the new capacity
            //int capacity2 = 50;
            Console.WriteLine("New CAPACITY: " + intList.Capacity);
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user's number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            static void SearchNumber(List<int> intList)
            {
                Console.Write("Enter number: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int number))
                {
                    if (intList.Contains(number))
                    {
                        Console.WriteLine("Number found: " + number);
                    }
                    else
                    {
                        Console.WriteLine("Number not found");
                    }
                        
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                
            }
            
            SearchNumber(intList);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            static List<int> EvensOnly(List<int> intList)
            {
                //
                //
                //     foreach (int item in intList)
                //     {
                //         if (item % 2 == 0)
                //         {
                //             Console.WriteLine(item);
                //         }
                //         else
                //         {
                //             intList.Remove(item);
                //
                //         }
                //     }
                //     return intList;
                // }

                for (int i = intList.Count - 1; i >= 0; i--)
                {
                    if (intList[i] % 2 != 0)
                    {
                        intList.RemoveAt(i);
                    }
                }
                return intList;
            }

            EvensOnly(intList);
            //Console.WriteLine(intList);
            NumberPrinter(intList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            intList.Sort();
            //Console.WriteLine($"{intList}");
            NumberPrinter(intList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            int[] numberArray = intList.ToArray();

            //TODO: Clear the list
            
            intList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
