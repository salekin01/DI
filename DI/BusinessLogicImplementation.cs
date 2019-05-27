using DI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class BusinessLogicImplementation
    {
        private IService _client;
        public BusinessLogicImplementation(IService client)
        {
            this._client = client;
        }

        public void CallService()
        {
            Console.WriteLine("Current Service : {0}", _client.ServiceMethod());
        }

    }
}
