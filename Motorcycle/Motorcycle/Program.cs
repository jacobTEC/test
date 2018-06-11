using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Cycle Motorcycle1 = new Cycle("Honda", true);
            Motorcycle1.Start();
            Motorcycle1.SetRpm();
            Motorcycle1.GetRpm();
            Motorcycle1.ShiftGearsUp();
            Motorcycle1.ShiftGearsUp();
            Motorcycle1.ShiftGearsUp();
            Motorcycle1.ShiftGearsDown(2);
            Motorcycle1.GetGear();
            Motorcycle1.GetSpeed();

            Console.WriteLine(Motorcycle1.ToString());

            Console.ReadKey();
            Console.Clear();

        }
    }
}
