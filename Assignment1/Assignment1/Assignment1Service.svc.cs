using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IAssignment1Service
    {
        public string primeCheck(int number)
        {
            int i;
            int temp = number / 2;

            for (i = 2; i <= temp; i++)
            {
                if (number % i == 0)
                {
                    break;
                }
            }
            if (i > temp)
            {
                return "Number is Prime";
            }
            else
            {
                return "Number is not Prime";
            }
        }
    }
}
