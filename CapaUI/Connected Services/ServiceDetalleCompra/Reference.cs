﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaUI.ServiceDetalleCompra {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetalleCompra", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class DetalleCompra : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdDetalleCompraField;
        
        private int IdCompraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdProductoField;
        
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
        public int IdDetalleCompra {
            get {
                return this.IdDetalleCompraField;
            }
            set {
                if ((this.IdDetalleCompraField.Equals(value) != true)) {
                    this.IdDetalleCompraField = value;
                    this.RaisePropertyChanged("IdDetalleCompra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int IdCompra {
            get {
                return this.IdCompraField;
            }
            set {
                if ((this.IdCompraField.Equals(value) != true)) {
                    this.IdCompraField = value;
                    this.RaisePropertyChanged("IdCompra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string IdProducto {
            get {
                return this.IdProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.IdProductoField, value) != true)) {
                    this.IdProductoField = value;
                    this.RaisePropertyChanged("IdProducto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceDetalleCompra.WebServiceDetalleCompraSoap")]
    public interface WebServiceDetalleCompraSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento idProducto del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServicioBuscarDetalleCompraPorIdProducto", ReplyAction="*")]
        CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoResponse ServicioBuscarDetalleCompraPorIdProducto(CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServicioBuscarDetalleCompraPorIdProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoResponse> ServicioBuscarDetalleCompraPorIdProductoAsync(CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServicioBuscarDetalleCompraPorIdProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServicioBuscarDetalleCompraPorIdProducto", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequestBody Body;
        
        public ServicioBuscarDetalleCompraPorIdProductoRequest() {
        }
        
        public ServicioBuscarDetalleCompraPorIdProductoRequest(CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServicioBuscarDetalleCompraPorIdProductoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idProducto;
        
        public ServicioBuscarDetalleCompraPorIdProductoRequestBody() {
        }
        
        public ServicioBuscarDetalleCompraPorIdProductoRequestBody(string idProducto) {
            this.idProducto = idProducto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServicioBuscarDetalleCompraPorIdProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServicioBuscarDetalleCompraPorIdProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoResponseBody Body;
        
        public ServicioBuscarDetalleCompraPorIdProductoResponse() {
        }
        
        public ServicioBuscarDetalleCompraPorIdProductoResponse(CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServicioBuscarDetalleCompraPorIdProductoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaUI.ServiceDetalleCompra.DetalleCompra ServicioBuscarDetalleCompraPorIdProductoResult;
        
        public ServicioBuscarDetalleCompraPorIdProductoResponseBody() {
        }
        
        public ServicioBuscarDetalleCompraPorIdProductoResponseBody(CapaUI.ServiceDetalleCompra.DetalleCompra ServicioBuscarDetalleCompraPorIdProductoResult) {
            this.ServicioBuscarDetalleCompraPorIdProductoResult = ServicioBuscarDetalleCompraPorIdProductoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceDetalleCompraSoapChannel : CapaUI.ServiceDetalleCompra.WebServiceDetalleCompraSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceDetalleCompraSoapClient : System.ServiceModel.ClientBase<CapaUI.ServiceDetalleCompra.WebServiceDetalleCompraSoap>, CapaUI.ServiceDetalleCompra.WebServiceDetalleCompraSoap {
        
        public WebServiceDetalleCompraSoapClient() {
        }
        
        public WebServiceDetalleCompraSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceDetalleCompraSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceDetalleCompraSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceDetalleCompraSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoResponse CapaUI.ServiceDetalleCompra.WebServiceDetalleCompraSoap.ServicioBuscarDetalleCompraPorIdProducto(CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequest request) {
            return base.Channel.ServicioBuscarDetalleCompraPorIdProducto(request);
        }
        
        public CapaUI.ServiceDetalleCompra.DetalleCompra ServicioBuscarDetalleCompraPorIdProducto(string idProducto) {
            CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequest inValue = new CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequest();
            inValue.Body = new CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequestBody();
            inValue.Body.idProducto = idProducto;
            CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoResponse retVal = ((CapaUI.ServiceDetalleCompra.WebServiceDetalleCompraSoap)(this)).ServicioBuscarDetalleCompraPorIdProducto(inValue);
            return retVal.Body.ServicioBuscarDetalleCompraPorIdProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoResponse> CapaUI.ServiceDetalleCompra.WebServiceDetalleCompraSoap.ServicioBuscarDetalleCompraPorIdProductoAsync(CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequest request) {
            return base.Channel.ServicioBuscarDetalleCompraPorIdProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoResponse> ServicioBuscarDetalleCompraPorIdProductoAsync(string idProducto) {
            CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequest inValue = new CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequest();
            inValue.Body = new CapaUI.ServiceDetalleCompra.ServicioBuscarDetalleCompraPorIdProductoRequestBody();
            inValue.Body.idProducto = idProducto;
            return ((CapaUI.ServiceDetalleCompra.WebServiceDetalleCompraSoap)(this)).ServicioBuscarDetalleCompraPorIdProductoAsync(inValue);
        }
    }
}