using DI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class Program
    {
        static void Main(string[] args)
        {
            BusinessLogicImplementation obj = new BusinessLogicImplementation(new PaymentService());
            obj.CallService();
            Console.ReadLine();
        }
    }
}
