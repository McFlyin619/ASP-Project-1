using System;
using System.Collections.Generic;

namespace ASP_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Test();
           
        }


        void Test() {
            Console.WriteLine("Hello There");

            string name = "OBrien"; // declare variable: Type Name = Value; String must have Double Quote
            string lastName = "McQuade";
            int age = 32;
            // float average = 3.22223f; // float for all numbers except money
            // decimal total = 1244.212m; // decimal is used for money
            // bool found = true;
            // Rarely used 
            // char letter = 'O'; 
            // uint positives = 1234;
            // double largeNumbers = 13449923786748248763266428;
            Console.WriteLine(name);

            for (int i=0; i<=10; i++) {
                Console.WriteLine(i);

                if(i == 5) {
                    Console.WriteLine("its a five bro");
                }
            }

            string message = SayHello(name, lastName, age);
            Console.WriteLine(message);

            ListTest();
        }

        public string SayHello(string name, string lastName, int age) {
            return $"Hello {name} {lastName} your age is:{age}";
        }

        // null -> void does not return anything
        void ListTest() {
            // string[] ages = new string[999]; 
            List<int> listOfAges = new List<int>();
            listOfAges.Add(9);
            listOfAges.Add(2);
            listOfAges.Add(33);
            listOfAges.Add(40);
            listOfAges.Add(69);
            listOfAges.Add(13);
            
            //variables
            var total = 0;
            var smallest = listOfAges[0];
            var biggest = listOfAges[0];
            var evens = 0;

            for(var i=0; i<listOfAges.Count; i++) {
                var age = listOfAges[i];
                total += age;

                if(age < smallest) {
                    smallest = age;
                }
                
                if(age > biggest) {
                    biggest = age;
                }

                if(age % 2 == 0) {
                    evens += 1;
                }
            }
            
            System.Console.WriteLine("The sum is " + total);
            System.Console.WriteLine("The average is " + (total / listOfAges.Count) );
            System.Console.WriteLine("The smallest is " + smallest);
            System.Console.WriteLine("The biggest is " + biggest);
            System.Console.WriteLine("There are " + evens + " even numbers" );

            
          
            //print
            /*
                1 -> smallest number on the list
                2 -> biggest number on the list
                3 -> sum of all numbers
                4 -> average of all numbers
                5 -> count the even numbers

            */
        }
    }
}
