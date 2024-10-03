using System;

namespace testt
{
    //functions
    public class FunctionTasks
    {


        // 1. Create a Simple Function
        public static int Add(int a, int b)
        {
            return a + b;
        }





        // 2. Function with Default Parameters
        public static double CalculateArea(double width, double height = 1)
        {
            return width * height;
        }





        // 3. Function Overloading
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintMessage(string message, int number)
        {
            Console.WriteLine($"{message} {number}");
        }






        // 4. Return Multiple Values using out
        public static void GetSumAndProduct(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
     }












    // class and inheretince

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }

    public class Car : Vehicle { }
    public class Truck : Vehicle { }

    // Abstract Class and Method
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    // Constructor Inheritance
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string JobTitle { get; set; }

        public Employee(string firstName, string lastName, int age, int employeeId, string jobTitle)
            : base(firstName, lastName, age)
        {
            EmployeeId = employeeId;
            JobTitle = jobTitle;
        }
    }

    // Polymorphism with Virtual and Override
    public class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }






    // Interfaces


    public interface IVehicle
    {
        void Start();
        void Stop();
    }

   

    public class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bicycle started.");
        }

        public void Stop()
        {
            Console.WriteLine("Bicycle stopped.");
        }
    }

    public interface IShape
    {
        double Area { get; }
        void CalculateArea();
    }

    public class RectangleShape : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; private set; }

        public void CalculateArea()
        {
            Area = Width * Height;
        }
    }

    public class CircleShape : IShape
    {
        public double Radius { get; set; }
        public double Area { get; private set; }

        public void CalculateArea()
        {
            Area = Math.PI * Radius * Radius;
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface IDriveable
    {
        void Drive();
    }

    public class FlyingCar : IFlyable, IDriveable
    {
        public void Fly()
        {
            Console.WriteLine("Flying car is flying.");
        }

        public void Drive()
        {
            Console.WriteLine("Flying car is driving.");
        }
    }









}
