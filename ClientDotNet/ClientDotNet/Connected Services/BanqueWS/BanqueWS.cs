//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientDotNet.BanqueWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService.example.org/", ConfigurationName="ClientDotNet.BanqueWS.BanqueService")]
    public interface BanqueService
    {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'Microsoft.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService.example.org/BanqueService/ConversionEuroToDhRequest", ReplyAction="http://WebService.example.org/BanqueService/ConversionEuroToDhResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClientDotNet.BanqueWS.ConversionEuroToDhResponse ConversionEuroToDh(ClientDotNet.BanqueWS.ConversionEuroToDhRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService.example.org/BanqueService/ConversionEuroToDhRequest", ReplyAction="http://WebService.example.org/BanqueService/ConversionEuroToDhResponse")]
        System.Threading.Tasks.Task<ClientDotNet.BanqueWS.ConversionEuroToDhResponse> ConversionEuroToDhAsync(ClientDotNet.BanqueWS.ConversionEuroToDhRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'Microsoft.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService.example.org/BanqueService/getComptesRequest", ReplyAction="http://WebService.example.org/BanqueService/getComptesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClientDotNet.BanqueWS.getComptesResponse getComptes(ClientDotNet.BanqueWS.getComptesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService.example.org/BanqueService/getComptesRequest", ReplyAction="http://WebService.example.org/BanqueService/getComptesResponse")]
        System.Threading.Tasks.Task<ClientDotNet.BanqueWS.getComptesResponse> getComptesAsync(ClientDotNet.BanqueWS.getComptesRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'Microsoft.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService.example.org/BanqueService/getCompteRequest", ReplyAction="http://WebService.example.org/BanqueService/getCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClientDotNet.BanqueWS.getCompteResponse getCompte(ClientDotNet.BanqueWS.getCompteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService.example.org/BanqueService/getCompteRequest", ReplyAction="http://WebService.example.org/BanqueService/getCompteResponse")]
        System.Threading.Tasks.Task<ClientDotNet.BanqueWS.getCompteResponse> getCompteAsync(ClientDotNet.BanqueWS.getCompteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDh", WrapperNamespace="http://WebService.example.org/", IsWrapped=true)]
    public partial class ConversionEuroToDhRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService.example.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double arg0;
        
        public ConversionEuroToDhRequest()
        {
        }
        
        public ConversionEuroToDhRequest(double arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDhResponse", WrapperNamespace="http://WebService.example.org/", IsWrapped=true)]
    public partial class ConversionEuroToDhResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService.example.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public ConversionEuroToDhResponse()
        {
        }
        
        public ConversionEuroToDhResponse(double @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService.example.org/")]
    public partial class compte
    {
        
        private int codeField;
        
        private System.DateTime dateCreationField;
        
        private bool dateCreationFieldSpecified;
        
        private double soldeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime dateCreation
        {
            get
            {
                return this.dateCreationField;
            }
            set
            {
                this.dateCreationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateCreationSpecified
        {
            get
            {
                return this.dateCreationFieldSpecified;
            }
            set
            {
                this.dateCreationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double solde
        {
            get
            {
                return this.soldeField;
            }
            set
            {
                this.soldeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getComptes", WrapperNamespace="http://WebService.example.org/", IsWrapped=true)]
    public partial class getComptesRequest
    {
        
        public getComptesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getComptesResponse", WrapperNamespace="http://WebService.example.org/", IsWrapped=true)]
    public partial class getComptesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService.example.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClientDotNet.BanqueWS.compte[] @return;
        
        public getComptesResponse()
        {
        }
        
        public getComptesResponse(ClientDotNet.BanqueWS.compte[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompte", WrapperNamespace="http://WebService.example.org/", IsWrapped=true)]
    public partial class getCompteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService.example.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public getCompteRequest()
        {
        }
        
        public getCompteRequest(int arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompteResponse", WrapperNamespace="http://WebService.example.org/", IsWrapped=true)]
    public partial class getCompteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService.example.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClientDotNet.BanqueWS.compte @return;
        
        public getCompteResponse()
        {
        }
        
        public getCompteResponse(ClientDotNet.BanqueWS.compte @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface BanqueServiceChannel : ClientDotNet.BanqueWS.BanqueService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class BanqueServiceClient : System.ServiceModel.ClientBase<ClientDotNet.BanqueWS.BanqueService>, ClientDotNet.BanqueWS.BanqueService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BanqueServiceClient() : 
                base(BanqueServiceClient.GetDefaultBinding(), BanqueServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BanqueServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), BanqueServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientDotNet.BanqueWS.ConversionEuroToDhResponse ClientDotNet.BanqueWS.BanqueService.ConversionEuroToDh(ClientDotNet.BanqueWS.ConversionEuroToDhRequest request)
        {
            return base.Channel.ConversionEuroToDh(request);
        }
        
        public double ConversionEuroToDh(double arg0)
        {
            ClientDotNet.BanqueWS.ConversionEuroToDhRequest inValue = new ClientDotNet.BanqueWS.ConversionEuroToDhRequest();
            inValue.arg0 = arg0;
            ClientDotNet.BanqueWS.ConversionEuroToDhResponse retVal = ((ClientDotNet.BanqueWS.BanqueService)(this)).ConversionEuroToDh(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientDotNet.BanqueWS.ConversionEuroToDhResponse> ClientDotNet.BanqueWS.BanqueService.ConversionEuroToDhAsync(ClientDotNet.BanqueWS.ConversionEuroToDhRequest request)
        {
            return base.Channel.ConversionEuroToDhAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientDotNet.BanqueWS.ConversionEuroToDhResponse> ConversionEuroToDhAsync(double arg0)
        {
            ClientDotNet.BanqueWS.ConversionEuroToDhRequest inValue = new ClientDotNet.BanqueWS.ConversionEuroToDhRequest();
            inValue.arg0 = arg0;
            return ((ClientDotNet.BanqueWS.BanqueService)(this)).ConversionEuroToDhAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientDotNet.BanqueWS.getComptesResponse ClientDotNet.BanqueWS.BanqueService.getComptes(ClientDotNet.BanqueWS.getComptesRequest request)
        {
            return base.Channel.getComptes(request);
        }
        
        public ClientDotNet.BanqueWS.compte[] getComptes()
        {
            ClientDotNet.BanqueWS.getComptesRequest inValue = new ClientDotNet.BanqueWS.getComptesRequest();
            ClientDotNet.BanqueWS.getComptesResponse retVal = ((ClientDotNet.BanqueWS.BanqueService)(this)).getComptes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientDotNet.BanqueWS.getComptesResponse> ClientDotNet.BanqueWS.BanqueService.getComptesAsync(ClientDotNet.BanqueWS.getComptesRequest request)
        {
            return base.Channel.getComptesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientDotNet.BanqueWS.getComptesResponse> getComptesAsync()
        {
            ClientDotNet.BanqueWS.getComptesRequest inValue = new ClientDotNet.BanqueWS.getComptesRequest();
            return ((ClientDotNet.BanqueWS.BanqueService)(this)).getComptesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientDotNet.BanqueWS.getCompteResponse ClientDotNet.BanqueWS.BanqueService.getCompte(ClientDotNet.BanqueWS.getCompteRequest request)
        {
            return base.Channel.getCompte(request);
        }
        
        public ClientDotNet.BanqueWS.compte getCompte(int arg0)
        {
            ClientDotNet.BanqueWS.getCompteRequest inValue = new ClientDotNet.BanqueWS.getCompteRequest();
            inValue.arg0 = arg0;
            ClientDotNet.BanqueWS.getCompteResponse retVal = ((ClientDotNet.BanqueWS.BanqueService)(this)).getCompte(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientDotNet.BanqueWS.getCompteResponse> ClientDotNet.BanqueWS.BanqueService.getCompteAsync(ClientDotNet.BanqueWS.getCompteRequest request)
        {
            return base.Channel.getCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientDotNet.BanqueWS.getCompteResponse> getCompteAsync(int arg0)
        {
            ClientDotNet.BanqueWS.getCompteRequest inValue = new ClientDotNet.BanqueWS.getCompteRequest();
            inValue.arg0 = arg0;
            return ((ClientDotNet.BanqueWS.BanqueService)(this)).getCompteAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BanqueServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BanqueServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8080/BanqueWS");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BanqueServiceClient.GetBindingForEndpoint(EndpointConfiguration.BanqueServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BanqueServiceClient.GetEndpointAddress(EndpointConfiguration.BanqueServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            BanqueServicePort,
        }
    }
}
