using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace HMW_FileIO
{
    [XmlRoot("Sport_Car")]
    public class Car
    {
        //Fields
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Codan { get; set; }
        public int NumberOfSeats { get; set; }

        //Constructors
        public Car()
        {
        }

        public Car(string model,string brand,string color,int year,int codan,int numOfSeats)
        {
            Model = model;
            Brand = brand;
            Color = color;
            Year = year;
            Codan = codan;
            NumberOfSeats = numOfSeats;
        }


        //Part B | Challenge - Constructor
        public Car(Stream stream)
        {
            Car car = new();
            XmlSerializer firstXml = new XmlSerializer(typeof(Car));
            firstXml.Serialize(stream, car);
        }


        //Methods
        public int GetCodan(int carCode)
        {
            Codan = carCode;
            return carCode;
        }

        public int GetNumberOfSeats(int seats)
        {
            NumberOfSeats = seats;
            return NumberOfSeats;
        }

        public void ChangeNumberOfSeats(int newNumberOfSeats)
        {
            NumberOfSeats = newNumberOfSeats;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        //Part B | Challenge - Methods
        public static void SerilizeACar(Stream stream,Car car)
        {
            XmlSerializer xml11 = new XmlSerializer(typeof(Car));
            xml11.Serialize(stream, car);
        }

        public static void SerilizeACarArray(Stream stream, Car[] carArr)
        {
            XmlSerializer xml11 = new XmlSerializer(typeof(Car));
            xml11.Serialize(stream, carArr);
        }

        
        

        

    }
}
