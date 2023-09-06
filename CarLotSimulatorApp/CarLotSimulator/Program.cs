using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot myCarLot = new CarLot();


            Car car1 = new Car();
            car1.Year = 2016;
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.IsDriveable = true;

            myCarLot.CarList.Add(car1);

            car1.MakeEngineNoise("Quiet whirr");
            car1.MakeHonkNoise("Beep beep");

            Console.WriteLine(car1.EngineNoise);
            Console.WriteLine(car1.HonkNoise);
            Console.WriteLine("-----------------------");

            Car car2 = new Car() { Year = 2022, Make = "Ford", Model = "F-150", IsDriveable = true};

            car2.MakeEngineNoise("Loud and obnoxious");
            car2.MakeHonkNoise("BWAAA BWAAAA");

            myCarLot.CarList.Add(car2);

            Console.WriteLine(car2.EngineNoise);
            Console.WriteLine(car2.HonkNoise);
            Console.WriteLine("------------------------");

            Car car3 = new Car(2023, "Dodge", "Challenger", true);

            car3.MakeEngineNoise("BRRRRRRRRR");
            car3.MakeHonkNoise("Honk honk");

            myCarLot.CarList.Add(car3);

            Console.WriteLine(car3.EngineNoise);
            Console.WriteLine(car3.HonkNoise);
            Console.WriteLine("------------------------");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in myCarLot.CarList)
            {
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
