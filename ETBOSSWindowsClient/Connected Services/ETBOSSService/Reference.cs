﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETBOSSWindowsClient.ETBOSSService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ETBOSSService.IETBOSSService")]
    public interface IETBOSSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IETBOSSService/GetCustomerName", ReplyAction="http://tempuri.org/IETBOSSService/GetCustomerNameResponse")]
        string GetCustomerName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IETBOSSService/GetCustomerName", ReplyAction="http://tempuri.org/IETBOSSService/GetCustomerNameResponse")]
        System.Threading.Tasks.Task<string> GetCustomerNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IETBOSSServiceChannel : ETBOSSWindowsClient.ETBOSSService.IETBOSSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ETBOSSServiceClient : System.ServiceModel.ClientBase<ETBOSSWindowsClient.ETBOSSService.IETBOSSService>, ETBOSSWindowsClient.ETBOSSService.IETBOSSService {
        
        public ETBOSSServiceClient() {
        }
        
        public ETBOSSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ETBOSSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ETBOSSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ETBOSSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetCustomerName(string name) {
            return base.Channel.GetCustomerName(name);
        }
        
        public System.Threading.Tasks.Task<string> GetCustomerNameAsync(string name) {
            return base.Channel.GetCustomerNameAsync(name);
        }
    }
}
