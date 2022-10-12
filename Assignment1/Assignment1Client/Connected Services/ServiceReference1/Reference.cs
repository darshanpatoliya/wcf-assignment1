﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAssignment1Service")]
    public interface IAssignment1Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/primeCheck", ReplyAction="http://tempuri.org/IAssignment1Service/primeCheckResponse")]
        string primeCheck(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/primeCheck", ReplyAction="http://tempuri.org/IAssignment1Service/primeCheckResponse")]
        System.Threading.Tasks.Task<string> primeCheckAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/sumOfDigits", ReplyAction="http://tempuri.org/IAssignment1Service/sumOfDigitsResponse")]
        int sumOfDigits(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/sumOfDigits", ReplyAction="http://tempuri.org/IAssignment1Service/sumOfDigitsResponse")]
        System.Threading.Tasks.Task<int> sumOfDigitsAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/reverseString", ReplyAction="http://tempuri.org/IAssignment1Service/reverseStringResponse")]
        string reverseString(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/reverseString", ReplyAction="http://tempuri.org/IAssignment1Service/reverseStringResponse")]
        System.Threading.Tasks.Task<string> reverseStringAsync(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/printHtml", ReplyAction="http://tempuri.org/IAssignment1Service/printHtmlResponse")]
        string printHtml(string string1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/printHtml", ReplyAction="http://tempuri.org/IAssignment1Service/printHtmlResponse")]
        System.Threading.Tasks.Task<string> printHtmlAsync(string string1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/sortFiveNumbers", ReplyAction="http://tempuri.org/IAssignment1Service/sortFiveNumbersResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] sortFiveNumbers(object[] intArray);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAssignment1Service/sortFiveNumbers", ReplyAction="http://tempuri.org/IAssignment1Service/sortFiveNumbersResponse")]
        System.Threading.Tasks.Task<object[]> sortFiveNumbersAsync(object[] intArray);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAssignment1ServiceChannel : Assignment1Client.ServiceReference1.IAssignment1Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Assignment1ServiceClient : System.ServiceModel.ClientBase<Assignment1Client.ServiceReference1.IAssignment1Service>, Assignment1Client.ServiceReference1.IAssignment1Service {
        
        public Assignment1ServiceClient() {
        }
        
        public Assignment1ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Assignment1ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Assignment1ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Assignment1ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string primeCheck(int number) {
            return base.Channel.primeCheck(number);
        }
        
        public System.Threading.Tasks.Task<string> primeCheckAsync(int number) {
            return base.Channel.primeCheckAsync(number);
        }
        
        public int sumOfDigits(int number) {
            return base.Channel.sumOfDigits(number);
        }
        
        public System.Threading.Tasks.Task<int> sumOfDigitsAsync(int number) {
            return base.Channel.sumOfDigitsAsync(number);
        }
        
        public string reverseString(string word) {
            return base.Channel.reverseString(word);
        }
        
        public System.Threading.Tasks.Task<string> reverseStringAsync(string word) {
            return base.Channel.reverseStringAsync(word);
        }
        
        public string printHtml(string string1) {
            return base.Channel.printHtml(string1);
        }
        
        public System.Threading.Tasks.Task<string> printHtmlAsync(string string1) {
            return base.Channel.printHtmlAsync(string1);
        }
        
        public object[] sortFiveNumbers(object[] intArray) {
            return base.Channel.sortFiveNumbers(intArray);
        }
        
        public System.Threading.Tasks.Task<object[]> sortFiveNumbersAsync(object[] intArray) {
            return base.Channel.sortFiveNumbersAsync(intArray);
        }
    }
}