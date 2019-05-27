using DI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Service
{
    public class ClaimService : IService
    {
        public string ServiceMethod()
        {
            return "ClaimService is running";
        }
    }
}
