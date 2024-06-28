/* Class: Exercise 1 developed by Dr.Muhammad Shafique
* Application: BMI
* Author: Marwa Ahmadzai
* Date: June 10, 2024
*/
using System;

namespace AhmadzaiMarwa_ClassEx1
{
    // BMI class to encapsulate BMI-related data and methods
    public class BMI
    {
        // Properties
        public string Name { get; }
        public int Age { get; }
        public float WeightInPounds { get; }
        public float HeightInInches { get; }

        // Constructor
        public BMI(string name, int age, float weightInPounds, float heightInInches)
        {
            // Validate input parameters
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name must not be null or empty.");
            if (age <= 0)
                throw new ArgumentException("Age must be greater than 0.");
            if (weightInPounds <= 0)
                throw new ArgumentException("Weight must be greater than 0.");
            if (heightInInches <= 0)
                throw new ArgumentException("Height must be greater than 0.");

            // Initialize properties
            Name = name;
            Age = age;
            WeightInPounds = weightInPounds;
            HeightInInches = heightInInches;
        }

        // Method to calculate BMI
        public float CalculateBMI()
        {
            // Convert height to meters
            float heightInMeters = HeightInInches * 0.0254f; // 1 inch = 0.0254 meters

            // Convert weight to kilograms
            float weightInKg = WeightInPounds * 0.453592f; // 1 pound = 0.453592 kilograms

            // Calculate BMI using the formula: weight (kg) / (height (m))^2
            return weightInKg / (heightInMeters * heightInMeters);
        }

        // Method to interpret BMI based on classifications
        public string InterpretBMI(float bmi)
        {
            // Determine BMI interpretation based on standard classifications
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                return "Normal weight";
            else if (bmi >= 25 && bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }

        // Override ToString method to provide formatted output
        public override string ToString()
        {
            // Calculate BMI
            float bmi = CalculateBMI();

            // Interpret BMI
            string interpretation = InterpretBMI(bmi);

            // Format output string with name, BMI value, and interpretation
            return $"{Name,-15} {bmi,-10:F2} {interpretation}";
        }
    }
}
