﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEP.EventGenerators.EventReceiverService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EventReceiverService.IEventReceiverService")]
    public interface IEventReceiverService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventReceiverService/SendEvent", ReplyAction="http://tempuri.org/IEventReceiverService/SendEventResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.TaskEvent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.TaskStop))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.TaskResume))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.TaskComplete))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.TaskResourceAllocation))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.TaskStart))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.TaskSuspend))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.ProcessEvent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.ProcessStart))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.ProcessSuspend))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.ProcessResume))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.ProcessStop))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Events.ProcessComplete))]
        void SendEvent(CEP.Common.Events.RawEvent obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventReceiverService/SendEvent", ReplyAction="http://tempuri.org/IEventReceiverService/SendEventResponse")]
        System.Threading.Tasks.Task SendEventAsync(CEP.Common.Events.RawEvent obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventReceiverServiceChannel : CEP.EventGenerators.EventReceiverService.IEventReceiverService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventReceiverServiceClient : System.ServiceModel.ClientBase<CEP.EventGenerators.EventReceiverService.IEventReceiverService>, CEP.EventGenerators.EventReceiverService.IEventReceiverService {
        
        public EventReceiverServiceClient() {
        }
        
        public EventReceiverServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventReceiverServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventReceiverServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventReceiverServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendEvent(CEP.Common.Events.RawEvent obj) {
            base.Channel.SendEvent(obj);
        }
        
        public System.Threading.Tasks.Task SendEventAsync(CEP.Common.Events.RawEvent obj) {
            return base.Channel.SendEventAsync(obj);
        }
    }
}
