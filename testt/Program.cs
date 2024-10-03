using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Function Tasks
            Console.WriteLine("Function Tasks:");
            Console.WriteLine($"Sum: {FunctionTasks.Add(5, 3)}");
            Console.WriteLine($"Area of rectangle: {FunctionTasks.CalculateArea(5)}");
            FunctionTasks.PrintMessage("Hello, World!");
            FunctionTasks.PrintMessage("Count:", 5);

            FunctionTasks.GetSumAndProduct(4, 5, out int sum, out int product);
            Console.WriteLine($"Sum: {sum}, Product: {product}");

           

            // Class and Inheritance
            Console.WriteLine("\nClass and Inheritance:");
            Vehicle myCar = new Car { Make = "Toyota", Model = "Camry", Year = 2020 };
            myCar.DisplayInfo();

            Animal myDog = new Dog();
            myDog.MakeSound();
            Animal myCat = new Cat();
            myCat.MakeSound();

            Employee employee = new Employee("John", "Doe", 30, 12345, "Developer");
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, ID: {employee.EmployeeId}");

            // Polymorphism
            Console.WriteLine("\nPolymorphism:");
            Shape rectangle = new Rectangle { Width = 5, Height = 10 };
            Shape circle = new Circle { Radius = 7 };
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
            Console.WriteLine($"Circle Area: {circle.GetArea()}");

            // Interfaces
           

            IShape myRectangle = new RectangleShape { Width = 4, Height = 5 };
            myRectangle.CalculateArea();
            Console.WriteLine($"Rectangle Area: {myRectangle.Area}");

            FlyingCar flyingCar = new FlyingCar();
            flyingCar.Fly();
            flyingCar.Drive();
        }
    }
    }

