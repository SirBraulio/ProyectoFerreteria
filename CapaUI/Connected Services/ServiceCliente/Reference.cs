//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaUI.ServiceCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdclienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RutclienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        private int Numero_celularField;
        
        private int Cant_comprasField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Idcliente {
            get {
                return this.IdclienteField;
            }
            set {
                if ((this.IdclienteField.Equals(value) != true)) {
                    this.IdclienteField = value;
                    this.RaisePropertyChanged("Idcliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Rutcliente {
            get {
                return this.RutclienteField;
            }
            set {
                if ((object.ReferenceEquals(this.RutclienteField, value) != true)) {
                    this.RutclienteField = value;
                    this.RaisePropertyChanged("Rutcliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Numero_celular {
            get {
                return this.Numero_celularField;
            }
            set {
                if ((this.Numero_celularField.Equals(value) != true)) {
                    this.Numero_celularField = value;
                    this.RaisePropertyChanged("Numero_celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Cant_compras {
            get {
                return this.Cant_comprasField;
            }
            set {
                if ((this.Cant_comprasField.Equals(value) != true)) {
                    this.Cant_comprasField = value;
                    this.RaisePropertyChanged("Cant_compras");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCliente.WebServiceClienteSoap")]
    public interface WebServiceClienteSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento producto del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Serviceinsertarproducto", ReplyAction="*")]
        CapaUI.ServiceCliente.ServiceinsertarproductoResponse Serviceinsertarproducto(CapaUI.ServiceCliente.ServiceinsertarproductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Serviceinsertarproducto", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServiceinsertarproductoResponse> ServiceinsertarproductoAsync(CapaUI.ServiceCliente.ServiceinsertarproductoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento cliente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServicebuscaCliente", ReplyAction="*")]
        CapaUI.ServiceCliente.ServicebuscaClienteResponse ServicebuscaCliente(CapaUI.ServiceCliente.ServicebuscaClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServicebuscaCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServicebuscaClienteResponse> ServicebuscaClienteAsync(CapaUI.ServiceCliente.ServicebuscaClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento cliente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceactualizarCliente", ReplyAction="*")]
        CapaUI.ServiceCliente.ServiceactualizarClienteResponse ServiceactualizarCliente(CapaUI.ServiceCliente.ServiceactualizarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceactualizarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServiceactualizarClienteResponse> ServiceactualizarClienteAsync(CapaUI.ServiceCliente.ServiceactualizarClienteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceinsertarproductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Serviceinsertarproducto", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceCliente.ServiceinsertarproductoRequestBody Body;
        
        public ServiceinsertarproductoRequest() {
        }
        
        public ServiceinsertarproductoRequest(CapaUI.ServiceCliente.ServiceinsertarproductoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServiceinsertarproductoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaUI.ServiceCliente.Cliente producto;
        
        public ServiceinsertarproductoRequestBody() {
        }
        
        public ServiceinsertarproductoRequestBody(CapaUI.ServiceCliente.Cliente producto) {
            this.producto = producto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceinsertarproductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceinsertarproductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceCliente.ServiceinsertarproductoResponseBody Body;
        
        public ServiceinsertarproductoResponse() {
        }
        
        public ServiceinsertarproductoResponse(CapaUI.ServiceCliente.ServiceinsertarproductoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServiceinsertarproductoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ServiceinsertarproductoResult;
        
        public ServiceinsertarproductoResponseBody() {
        }
        
        public ServiceinsertarproductoResponseBody(bool ServiceinsertarproductoResult) {
            this.ServiceinsertarproductoResult = ServiceinsertarproductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServicebuscaClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServicebuscaCliente", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceCliente.ServicebuscaClienteRequestBody Body;
        
        public ServicebuscaClienteRequest() {
        }
        
        public ServicebuscaClienteRequest(CapaUI.ServiceCliente.ServicebuscaClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServicebuscaClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cliente;
        
        public ServicebuscaClienteRequestBody() {
        }
        
        public ServicebuscaClienteRequestBody(string cliente) {
            this.cliente = cliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServicebuscaClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServicebuscaClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceCliente.ServicebuscaClienteResponseBody Body;
        
        public ServicebuscaClienteResponse() {
        }
        
        public ServicebuscaClienteResponse(CapaUI.ServiceCliente.ServicebuscaClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServicebuscaClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaUI.ServiceCliente.Cliente ServicebuscaClienteResult;
        
        public ServicebuscaClienteResponseBody() {
        }
        
        public ServicebuscaClienteResponseBody(CapaUI.ServiceCliente.Cliente ServicebuscaClienteResult) {
            this.ServicebuscaClienteResult = ServicebuscaClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceactualizarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceactualizarCliente", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceCliente.ServiceactualizarClienteRequestBody Body;
        
        public ServiceactualizarClienteRequest() {
        }
        
        public ServiceactualizarClienteRequest(CapaUI.ServiceCliente.ServiceactualizarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServiceactualizarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaUI.ServiceCliente.Cliente cliente;
        
        public ServiceactualizarClienteRequestBody() {
        }
        
        public ServiceactualizarClienteRequestBody(CapaUI.ServiceCliente.Cliente cliente) {
            this.cliente = cliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceactualizarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceactualizarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceCliente.ServiceactualizarClienteResponseBody Body;
        
        public ServiceactualizarClienteResponse() {
        }
        
        public ServiceactualizarClienteResponse(CapaUI.ServiceCliente.ServiceactualizarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ServiceactualizarClienteResponseBody {
        
        public ServiceactualizarClienteResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceClienteSoapChannel : CapaUI.ServiceCliente.WebServiceClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceClienteSoapClient : System.ServiceModel.ClientBase<CapaUI.ServiceCliente.WebServiceClienteSoap>, CapaUI.ServiceCliente.WebServiceClienteSoap {
        
        public WebServiceClienteSoapClient() {
        }
        
        public WebServiceClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaUI.ServiceCliente.ServiceinsertarproductoResponse CapaUI.ServiceCliente.WebServiceClienteSoap.Serviceinsertarproducto(CapaUI.ServiceCliente.ServiceinsertarproductoRequest request) {
            return base.Channel.Serviceinsertarproducto(request);
        }
        
        public bool Serviceinsertarproducto(CapaUI.ServiceCliente.Cliente producto) {
            CapaUI.ServiceCliente.ServiceinsertarproductoRequest inValue = new CapaUI.ServiceCliente.ServiceinsertarproductoRequest();
            inValue.Body = new CapaUI.ServiceCliente.ServiceinsertarproductoRequestBody();
            inValue.Body.producto = producto;
            CapaUI.ServiceCliente.ServiceinsertarproductoResponse retVal = ((CapaUI.ServiceCliente.WebServiceClienteSoap)(this)).Serviceinsertarproducto(inValue);
            return retVal.Body.ServiceinsertarproductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServiceinsertarproductoResponse> CapaUI.ServiceCliente.WebServiceClienteSoap.ServiceinsertarproductoAsync(CapaUI.ServiceCliente.ServiceinsertarproductoRequest request) {
            return base.Channel.ServiceinsertarproductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServiceinsertarproductoResponse> ServiceinsertarproductoAsync(CapaUI.ServiceCliente.Cliente producto) {
            CapaUI.ServiceCliente.ServiceinsertarproductoRequest inValue = new CapaUI.ServiceCliente.ServiceinsertarproductoRequest();
            inValue.Body = new CapaUI.ServiceCliente.ServiceinsertarproductoRequestBody();
            inValue.Body.producto = producto;
            return ((CapaUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceinsertarproductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaUI.ServiceCliente.ServicebuscaClienteResponse CapaUI.ServiceCliente.WebServiceClienteSoap.ServicebuscaCliente(CapaUI.ServiceCliente.ServicebuscaClienteRequest request) {
            return base.Channel.ServicebuscaCliente(request);
        }
        
        public CapaUI.ServiceCliente.Cliente ServicebuscaCliente(string cliente) {
            CapaUI.ServiceCliente.ServicebuscaClienteRequest inValue = new CapaUI.ServiceCliente.ServicebuscaClienteRequest();
            inValue.Body = new CapaUI.ServiceCliente.ServicebuscaClienteRequestBody();
            inValue.Body.cliente = cliente;
            CapaUI.ServiceCliente.ServicebuscaClienteResponse retVal = ((CapaUI.ServiceCliente.WebServiceClienteSoap)(this)).ServicebuscaCliente(inValue);
            return retVal.Body.ServicebuscaClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServicebuscaClienteResponse> CapaUI.ServiceCliente.WebServiceClienteSoap.ServicebuscaClienteAsync(CapaUI.ServiceCliente.ServicebuscaClienteRequest request) {
            return base.Channel.ServicebuscaClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServicebuscaClienteResponse> ServicebuscaClienteAsync(string cliente) {
            CapaUI.ServiceCliente.ServicebuscaClienteRequest inValue = new CapaUI.ServiceCliente.ServicebuscaClienteRequest();
            inValue.Body = new CapaUI.ServiceCliente.ServicebuscaClienteRequestBody();
            inValue.Body.cliente = cliente;
            return ((CapaUI.ServiceCliente.WebServiceClienteSoap)(this)).ServicebuscaClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaUI.ServiceCliente.ServiceactualizarClienteResponse CapaUI.ServiceCliente.WebServiceClienteSoap.ServiceactualizarCliente(CapaUI.ServiceCliente.ServiceactualizarClienteRequest request) {
            return base.Channel.ServiceactualizarCliente(request);
        }
        
        public void ServiceactualizarCliente(CapaUI.ServiceCliente.Cliente cliente) {
            CapaUI.ServiceCliente.ServiceactualizarClienteRequest inValue = new CapaUI.ServiceCliente.ServiceactualizarClienteRequest();
            inValue.Body = new CapaUI.ServiceCliente.ServiceactualizarClienteRequestBody();
            inValue.Body.cliente = cliente;
            CapaUI.ServiceCliente.ServiceactualizarClienteResponse retVal = ((CapaUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceactualizarCliente(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServiceactualizarClienteResponse> CapaUI.ServiceCliente.WebServiceClienteSoap.ServiceactualizarClienteAsync(CapaUI.ServiceCliente.ServiceactualizarClienteRequest request) {
            return base.Channel.ServiceactualizarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaUI.ServiceCliente.ServiceactualizarClienteResponse> ServiceactualizarClienteAsync(CapaUI.ServiceCliente.Cliente cliente) {
            CapaUI.ServiceCliente.ServiceactualizarClienteRequest inValue = new CapaUI.ServiceCliente.ServiceactualizarClienteRequest();
            inValue.Body = new CapaUI.ServiceCliente.ServiceactualizarClienteRequestBody();
            inValue.Body.cliente = cliente;
            return ((CapaUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceactualizarClienteAsync(inValue);
        }
    }
}
