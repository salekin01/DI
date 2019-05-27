using DI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Service
{
    public class AdjudicationService : IService
    {
        public string ServiceMethod()
        {
            return "AdjudicationService is running";
        }
    }
}
