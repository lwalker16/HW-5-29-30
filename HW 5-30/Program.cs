using System;

namespace HW_5_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car(2030, "Ford Mustang GT");
            Car1.Color("Red with black stripes");
            Car1.Body("Spoiler on the back");


            Car Car2 = new Car(2030, "Tesla");
            Car2.Color("Lightblue");
            Car2.Body("Sunroof");

            Car Car3 = new Car(2030, "Dodge Charger");
            Car3.Color("Matte Black");
            Car3.Body("Spoiler on the back");


        }
    }

    public class Car
    {

        public static string _name { set; get; }
        public static int _Year { set; get; }


        public Car(int Year, string name)
        {
            _name = name;
            _Year = Year;
            

            Console.WriteLine("{1} {0}", name, Year);
        }
       
        public void Color(string CarColor)
        {
            Console.WriteLine("The color of this car is: {0}", CarColor);

        }

        public void Body(string Bod)
        {
            Console.WriteLine("Accessory is a {0}", Bod);

        }
    }

}
