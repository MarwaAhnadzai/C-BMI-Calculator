/* Class: Exercise 1 developed by Dr.Muhammad Shafique
* Application: BMI
* Author: Marwa Ahmadzai
* Date: June 10, 2024
*/
using System;
using System.Collections.Generic;

namespace AhmadzaiMarwa_ClassEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            // List to store BMI objects
            List<BMI> bmiList = new List<BMI>();

            // Read input from console
            while (true)
            {
                try
                {
                    // Prompt user for input
                    Console.WriteLine("Enter person's name (or type 'done' to finish): ");
                    string name = Console.ReadLine().Trim();

                    // Check if user wants to finish entering data
                    if (name.ToLower() == "done")
                        break;

                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Enter weight in pounds: ");
                    float weight = float.Parse(Console.ReadLine());

                    Console.Write("Enter height in inches: ");
                    float height = float.Parse(Console.ReadLine());

                    // Create BMI object
                    BMI bmi = new BMI(name, age, weight, height);

                    // Add BMI object to list
                    bmiList.Add(bmi);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Display results in tabular form
            Console.WriteLine("\nBMI Results:");
            Console.WriteLine("===============================================");
            Console.WriteLine("Name           BMI       Interpretation");
            Console.WriteLine("===============================================");
            foreach (var bmi in bmiList)
            {
                Console.WriteLine(bmi); // Calls the ToString() method of BMI class for formatted output
            }
            Console.WriteLine("===============================================");
        }
    }
}

