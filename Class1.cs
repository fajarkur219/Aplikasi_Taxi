using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTaxi_21._11._4383
{
    public class Taxi
    {
        public string Drivername { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Drivername: {0}", Drivername);
            Console.WriteLine("OnDuty: {0}", OnDuty);
            Console.WriteLine("NumPassenger: {0}", NumPassenger);
    
        }

        public void PickUpPassenger() 
        {
            Console.WriteLine("{0} sedang Menjemput penumpang\n", Drivername);
        }
        public void DropOffPasssenger()
        {
            Console.WriteLine("{0} selesai Mengantar penumpang\n", Drivername);
        }
    }
}
