﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaUI.ServiceDetCompra {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetalleCompra", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class DetalleCompra : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdCompraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdproveedorField;
        
        private int IdDetalleCompraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdProductoField;
        
        private int IdStockField;
        
        private int CantidadField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Idproveedor {
            get {
                return this.IdproveedorField;
            }
            set {
                if ((object.ReferenceEquals(this.IdproveedorField, value) != true)) {
                    this.IdproveedorField = value;
                    this.RaisePropertyChanged("Idproveedor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int IdStock {
            get {
                return this.IdStockField;
            }
            set {
                if ((this.IdStockField.Equals(value) != true)) {
                    this.IdStockField = value;
                    this.RaisePropertyChanged("IdStock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceDetCompra.WebServiceDetalleCompraSoap")]
    public interface WebServiceDetalleCompraSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento idProducto del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServicioBuscarDetalleCompraPorIdProducto", ReplyAction="*")]
        CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoResponse ServicioBuscarDetalleCompraPorIdProducto(CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServicioBuscarDetalleCompraPorIdProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoResponse> ServicioBuscarDetalleCompraPorIdProductoAsync(CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServicioBuscarDetalleCompraPorIdProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServicioBuscarDetalleCompraPorIdProducto", Namespace="http://tempuri.org/", Order=0)]
        public CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequestBody Body;
        
        public ServicioBuscarDetalleCompraPorIdProductoRequest() {
        }
        
        public ServicioBuscarDetalleCompraPorIdProductoRequest(CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequestBody Body) {
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
        public CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoResponseBody Body;
        
        public ServicioBuscarDetalleCompraPorIdProductoResponse() {
        }
        
        public ServicioBuscarDetalleCompraPorIdProductoResponse(CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServicioBuscarDetalleCompraPorIdProductoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaUI.ServiceDetCompra.DetalleCompra ServicioBuscarDetalleCompraPorIdProductoResult;
        
        public ServicioBuscarDetalleCompraPorIdProductoResponseBody() {
        }
        
        public ServicioBuscarDetalleCompraPorIdProductoResponseBody(CapaUI.ServiceDetCompra.DetalleCompra ServicioBuscarDetalleCompraPorIdProductoResult) {
            this.ServicioBuscarDetalleCompraPorIdProductoResult = ServicioBuscarDetalleCompraPorIdProductoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceDetalleCompraSoapChannel : CapaUI.ServiceDetCompra.WebServiceDetalleCompraSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceDetalleCompraSoapClient : System.ServiceModel.ClientBase<CapaUI.ServiceDetCompra.WebServiceDetalleCompraSoap>, CapaUI.ServiceDetCompra.WebServiceDetalleCompraSoap {
        
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
        CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoResponse CapaUI.ServiceDetCompra.WebServiceDetalleCompraSoap.ServicioBuscarDetalleCompraPorIdProducto(CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequest request) {
            return base.Channel.ServicioBuscarDetalleCompraPorIdProducto(request);
        }
        
        public CapaUI.ServiceDetCompra.DetalleCompra ServicioBuscarDetalleCompraPorIdProducto(string idProducto) {
            CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequest inValue = new CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequest();
            inValue.Body = new CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequestBody();
            inValue.Body.idProducto = idProducto;
            CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoResponse retVal = ((CapaUI.ServiceDetCompra.WebServiceDetalleCompraSoap)(this)).ServicioBuscarDetalleCompraPorIdProducto(inValue);
            return retVal.Body.ServicioBuscarDetalleCompraPorIdProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoResponse> CapaUI.ServiceDetCompra.WebServiceDetalleCompraSoap.ServicioBuscarDetalleCompraPorIdProductoAsync(CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequest request) {
            return base.Channel.ServicioBuscarDetalleCompraPorIdProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoResponse> ServicioBuscarDetalleCompraPorIdProductoAsync(string idProducto) {
            CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequest inValue = new CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequest();
            inValue.Body = new CapaUI.ServiceDetCompra.ServicioBuscarDetalleCompraPorIdProductoRequestBody();
            inValue.Body.idProducto = idProducto;
            return ((CapaUI.ServiceDetCompra.WebServiceDetalleCompraSoap)(this)).ServicioBuscarDetalleCompraPorIdProductoAsync(inValue);
        }
    }
}