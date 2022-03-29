using System;
using System.IO;
using System.Xml.Serialization;
namespace HMW_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Excersice 16
            
            Console.WriteLine("---------------------------Excercise 16---------------------------");

            //Write First 10 Files *USING MACBOOK* - (This Is Not Same Way As Windows)
            int i = 0;
            foreach (string files in Directory.EnumerateDirectories(@"/users/gio"))
            {
                i++;
                Console.WriteLine(files);
                if (i == 10)
                {
                    i = 0;
                    break;
                }
            }
            
            #endregion

            #region Excersice 17

            string newPath = @"/users/gio/desktop/FormulaCar.txt";
            Car Formula1 = new Car();
            Car[] carsArray = new Car[5];

            XmlSerializer xml = new XmlSerializer(typeof(Car));
            using (Stream streamForCar = new FileStream(newPath, FileMode.Create))
            {
                xml.Serialize(streamForCar, Formula1);
                Formula1.Brand = "BMW";
                Formula1.Color = "Black";
                Formula1.Model = "M8 Competition";
                Formula1.NumberOfSeats = 2;
                Formula1.Codan = 7717;
                Formula1.Year = 2019;
            }

            //Check If XML Is Changing After Updating Number Of Seats
            Formula1.ChangeNumberOfSeats(8);
            Console.WriteLine($"Number Of Seats After Changing:\n{Formula1.NumberOfSeats}");

            Stream path = new FileStream(@"/users/gio/desktop/FormulaCar.txt", FileMode.Open);
            Car newCar = new Car(path);



            #endregion
        }
    }
}
