using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto1 = new Car();
            Bicycle rower1 = new Bicycle();
            auto1.Ride();
            rower1.Ride();
            rower1.PlayMelody();
            Skateboard deska1 = new Skateboard();
            deska1.Ride();
            Console.WriteLine();

            List<Car> cars = new List<Car>();
            cars.Add(new Car(2016, "Ford"));
            cars.Add(new Car(2016, "Fiat"));
            cars.Add(new Car(2012, "Skoda"));
            cars.Add(new Car(2010, "BMW"));
            
            foreach (var element in cars)
            {
                Console.WriteLine(element.GetYear()+", "+element.GetBrand());
            }
            Console.WriteLine();
            cars.Sort();
            foreach (var element in cars)
            {
                Console.WriteLine(element.GetYear()+", "+element.GetBrand());
            }


            Console.ReadKey();
        }
    }
}
