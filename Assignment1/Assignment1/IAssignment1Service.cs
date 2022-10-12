using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAssignment1Service
    {
        [OperationContract]
        string primeCheck(int number);
        [OperationContract]
        int sumOfDigits(int number);
        [OperationContract]
        string reverseString(string word);
        [OperationContract]
        string printHtml(string string1);
        [OperationContract]
        int[] sortFiveNumbers(int[] intArray);

    }
}
