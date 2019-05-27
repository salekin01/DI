using DI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Service
{
    public class PaymentService : IService
    {
        public string ServiceMethod()
        {
            return "PaymentService is running";
        }
    }
}
