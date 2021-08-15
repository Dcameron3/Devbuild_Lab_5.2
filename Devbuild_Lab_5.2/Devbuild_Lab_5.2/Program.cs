using System;
using System.Collections.Generic;

namespace Devbuild_Lab_5._2
{
    public enum CarMake
    {
        Mazda,
        Aston_Martin,
        Jaguar,
        Merkur,
        Scion
    }

    public class Car
    {
        protected CarMake Make;
        protected string Model;
        protected int Year;
        protected decimal Price;

        public Car(CarMake _Make, string _Model, int _Year, Decimal _Price)
        {
            Make = _Make;
            Model = _Model;
            Year = _Year;
            Price = _Price;
        }


    }
    class NewCar : Car
    {
        protected bool ExtendedWarranty;
        public NewCar(CarMake _Make, string _Model, int _Year, Decimal _Price, bool _ExtendedWarranty) : base(_Make, _Model, _Year, _Price)
        {
            ExtendedWarranty = _ExtendedWarranty;
        }
        public override string ToString()
        {
            return $"New {Make} {Model} Year: {Year} Price: {Price} Extended warranty: {ExtendedWarranty}";
        }

    }
    class UsedCar : Car
    {
        protected int NumberOfOwners;
        protected int Mileage;
        public UsedCar(CarMake _Make, string _Model, int _Year, Decimal _Price, int _NumberOfOwners, int _Mileage) : base(_Make, _Model, _Year, _Price)
        {
            NumberOfOwners = _NumberOfOwners;
            Mileage = _Mileage;
        }
        public override string ToString()
        {
            return $"Used {Make} {Model} Year: {Year} Price: {Price} Number of owners: {NumberOfOwners} Mileage: {Mileage}.";
        }



        class Program
        {
            static void ListCars(List<Car> TheList)
            {
               
                for (int index = 0; index < TheList.Count; index++)
                {
            
                    {
                        Console.WriteLine($"{index + 1}. {TheList[index]}");
                    }
            
                    
                }
            }



            public static void Purchase(List<Car> TheList)
            {
                Console.WriteLine("Which car would you like to purchase? (Provide a number.)");
                string which = Console.ReadLine();
                int index = int.Parse(which);
                TheList.RemoveAt(index - 1);
                Console.WriteLine("Thank you for your purchase.");
               
            }

            public static void Add(List<Car> TheList)
            {
                Console.WriteLine("Is this a used or new car?");
                string entry = Console.ReadLine();

                if (entry == "used") 
                {
                    
                    Console.WriteLine("Please enter the make:");
                    string _MakeStr = Console.ReadLine();
                    CarMake _Make = CarMake.Mazda;
                    switch (_MakeStr)
                    {
                        case "Mazda":
                            _Make = CarMake.Mazda;
                            break;
                        case "Aston_Martin":
                            _Make = CarMake.Aston_Martin;
                            break;
                        case "Scion":
                            _Make = CarMake.Scion;
                            break;
                        case "Merkur":
                            _Make = CarMake.Merkur;
                            break;
                        case "Jaguar":
                            _Make = CarMake.Jaguar;
                            break;
                    }


                    Console.WriteLine("The model:");
                    string _Model = Console.ReadLine();
                    Console.WriteLine("The year: ");
                    int _Year = int.Parse(Console.ReadLine());
                    Console.WriteLine("And the price: ");
                    decimal _Price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("How many owners?");
                    int _NumberOfOwners = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mileage: ");
                    int _Mileage = int.Parse(Console.ReadLine());
                    UsedCar inst = new UsedCar(_Make, _Model, _Year, _Price, _NumberOfOwners, _Mileage);
                    TheList.Add(inst);
                }
                else
                {

                    Console.WriteLine("Please enter the make:");
                    string _MakeStr = Console.ReadLine();
                    CarMake _Make = CarMake.Mazda;
                    switch (_MakeStr)
                    {
                        case "Mazda":
                            _Make = CarMake.Mazda;
                            break;
                        case "Aston_Martin":
                            _Make = CarMake.Aston_Martin;
                            break;
                        case "Scion":
                            _Make = CarMake.Scion;
                            break;
                        case "Merkur":
                            _Make = CarMake.Merkur;
                            break;
                        case "Jaguar":
                            _Make = CarMake.Jaguar;
                            break;
                    }
                    Console.WriteLine("The model:");
                    string _Model = Console.ReadLine();
                    Console.WriteLine("The year: ");
                    int _Year = int.Parse(Console.ReadLine());
                    Console.WriteLine("And the price: ");
                    decimal _Price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Extended warranty? y/n");
                    string warrantyResponse = Convert.ToString(Console.ReadLine());
                    bool _ExtendedWarranty;
                    if (warrantyResponse == "y")
                    {
                        _ExtendedWarranty = true;
                    }
                    else _ExtendedWarranty = false;
                    NewCar inst = new NewCar(_Make, _Model, _Year, _Price, _ExtendedWarranty);
                    TheList.Add(inst);
                }
            
                
            }
            static void Main(string[] args)
            {
                
                List<Car> inventory = new List<Car>();

                Car sampleCar;

                sampleCar = new UsedCar(CarMake.Scion, "Allstar", 2020, 20000m, 3, 50000);
                inventory.Add(sampleCar);
                sampleCar = new UsedCar(CarMake.Mazda, "MX-5 Miata", 2019, 28000m, 1, 25000);
                inventory.Add(sampleCar);
                sampleCar = new NewCar(CarMake.Aston_Martin, "BondCar", 2021, 60000m, true);
                inventory.Add(sampleCar);
                sampleCar = new NewCar(CarMake.Merkur, "Merk", 2020, 5000m, false);
                inventory.Add(sampleCar);
                sampleCar = new UsedCar(CarMake.Scion, "Scion1", 1967, 4000m, 78, 220000);
                inventory.Add(sampleCar);

                bool keepGoing = true;
                while (keepGoing == true)
                {
                    Console.WriteLine("Here is our current inventory:");
                    ListCars(inventory);

                    Console.Write("Would you like to Purchase (p), Add (a), or Quit (q)?");
                    string entry = Console.ReadLine();

                    if (entry == "p" || entry == "P")
                    {
                        Purchase(inventory);
                        Console.WriteLine("");
                    }
                    else if (entry == "a" || entry == "A")
                    {
                        Add(inventory);
                        Console.WriteLine("");
                        Console.WriteLine("Your car has been added.");
                    }
                    else if (entry == "q" || entry == "Q")
                    {
                        keepGoing = false;
                    }
                }
                Console.WriteLine("See ya!");

            }
        }
    }
}
