using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car : Vechicle, IRideable, IComparable<Car>
    {
        public void Ride()
        {
            Console.WriteLine("Jadę samochodem");
        }
        private int year;//rok produkcji
        private string brand; // marka

        public Car(int year, string brand)
        {
            this.brand = brand;
            this.year = year;
        }
        public Car()
        {

        }
        public int GetYear()
        {
            return year;
        }
        public string GetBrand()
        {
            return brand;
        }
        public int CompareTo(Car other)
        {
            if (this.year == other.year)
            {
                return this.brand.CompareTo(other.brand);
            }
            return other.year.CompareTo(this.year);
        }
    }
}
