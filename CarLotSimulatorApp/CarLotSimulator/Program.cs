using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO
         var lot = new CarLot();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var vehicule = new Car();
            vehicule.Make = "Ford";
            vehicule.Model = "Taurus";
            vehicule.Year = 2015;
            vehicule.HonkNoise = "beep";
            vehicule.EngineNoise = "vroom";
            vehicule.IsDrivable = true;
            lot.Cars.Add(vehicule);
            var lorry = new Car()
            {
                Year = 2018,
                    Make="Tesla",
                    Model="cyber Truck",
                    HonkNoise ="...",
                    EngineNoise = "bruuunp",
                IsDrivable = false,



            };
            lot.Cars.Add(lorry);
            var EssonaniCar = new Car(2020, "Toyota", "Cierra", "Nothing", "Silence",true);
            vehicule.MakeHonkNoise(vehicule.EngineNoise);
            lorry.MakeEngineNoise(lorry.EngineNoise);
            EssonaniCar.MakeEngineNoise(EssonaniCar.EngineNoise);
            lot.Cars.Add(EssonaniCar);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year:{ car.Year } Make:{ car.Make } Model:{ car.Model}");
            }
        }
    }
}
