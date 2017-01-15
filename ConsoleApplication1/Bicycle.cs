using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bicycle : Vechicle, IRideable, IMusic
    {
        public void Ride()
        {
            Console.WriteLine("Jadę rowerem");
        }
        public void PlayMelody()
        {
            Console.WriteLine("Gram muzykę na rowerze");
        }
    }
}
