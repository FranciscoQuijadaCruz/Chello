﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoEscritorio.ComentarioWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices/", ConfigurationName="ComentarioWS.ComentarioWS")]
    public interface ComentarioWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/CrearComentarioRequest", ReplyAction="http://webservices/ComentarioWS/CrearComentarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoEscritorio.ComentarioWS.CrearComentarioResponse CrearComentario(ProyectoEscritorio.ComentarioWS.CrearComentarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/CrearComentarioRequest", ReplyAction="http://webservices/ComentarioWS/CrearComentarioResponse")]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.CrearComentarioResponse> CrearComentarioAsync(ProyectoEscritorio.ComentarioWS.CrearComentarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/EliminarComentarioRequest", ReplyAction="http://webservices/ComentarioWS/EliminarComentarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoEscritorio.ComentarioWS.EliminarComentarioResponse EliminarComentario(ProyectoEscritorio.ComentarioWS.EliminarComentarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/EliminarComentarioRequest", ReplyAction="http://webservices/ComentarioWS/EliminarComentarioResponse")]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.EliminarComentarioResponse> EliminarComentarioAsync(ProyectoEscritorio.ComentarioWS.EliminarComentarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/SeleccionarComentarioRequest", ReplyAction="http://webservices/ComentarioWS/SeleccionarComentarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoEscritorio.ComentarioWS.SeleccionarComentarioResponse SeleccionarComentario(ProyectoEscritorio.ComentarioWS.SeleccionarComentarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/SeleccionarComentarioRequest", ReplyAction="http://webservices/ComentarioWS/SeleccionarComentarioResponse")]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.SeleccionarComentarioResponse> SeleccionarComentarioAsync(ProyectoEscritorio.ComentarioWS.SeleccionarComentarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/ObtenerComentariosDeActividadRequest", ReplyAction="http://webservices/ComentarioWS/ObtenerComentariosDeActividadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadResponse ObtenerComentariosDeActividad(ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/ObtenerComentariosDeActividadRequest", ReplyAction="http://webservices/ComentarioWS/ObtenerComentariosDeActividadResponse")]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadResponse> ObtenerComentariosDeActividadAsync(ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/ObtenerComentariosDeUsuarioRequest", ReplyAction="http://webservices/ComentarioWS/ObtenerComentariosDeUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioResponse ObtenerComentariosDeUsuario(ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices/ComentarioWS/ObtenerComentariosDeUsuarioRequest", ReplyAction="http://webservices/ComentarioWS/ObtenerComentariosDeUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioResponse> ObtenerComentariosDeUsuarioAsync(ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CrearComentario", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class CrearComentarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fecha;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idActividad;
        
        public CrearComentarioRequest() {
        }
        
        public CrearComentarioRequest(string descripcion, string fecha, int idUsuario, int idActividad) {
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
            this.idActividad = idActividad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CrearComentarioResponse", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class CrearComentarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public CrearComentarioResponse() {
        }
        
        public CrearComentarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EliminarComentario", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class EliminarComentarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public EliminarComentarioRequest() {
        }
        
        public EliminarComentarioRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EliminarComentarioResponse", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class EliminarComentarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public EliminarComentarioResponse() {
        }
        
        public EliminarComentarioResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices/")]
    public partial class comentario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private string fechaField;
        
        private int idField;
        
        private int idActividadField;
        
        private int idUsuarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
                this.RaisePropertyChanged("fecha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int idActividad {
            get {
                return this.idActividadField;
            }
            set {
                this.idActividadField = value;
                this.RaisePropertyChanged("idActividad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("idUsuario");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SeleccionarComentario", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class SeleccionarComentarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public SeleccionarComentarioRequest() {
        }
        
        public SeleccionarComentarioRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SeleccionarComentarioResponse", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class SeleccionarComentarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoEscritorio.ComentarioWS.comentario @return;
        
        public SeleccionarComentarioResponse() {
        }
        
        public SeleccionarComentarioResponse(ProyectoEscritorio.ComentarioWS.comentario @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerComentariosDeActividad", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class ObtenerComentariosDeActividadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idActividad;
        
        public ObtenerComentariosDeActividadRequest() {
        }
        
        public ObtenerComentariosDeActividadRequest(int idActividad) {
            this.idActividad = idActividad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerComentariosDeActividadResponse", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class ObtenerComentariosDeActividadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoEscritorio.ComentarioWS.comentario[] @return;
        
        public ObtenerComentariosDeActividadResponse() {
        }
        
        public ObtenerComentariosDeActividadResponse(ProyectoEscritorio.ComentarioWS.comentario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerComentariosDeUsuario", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class ObtenerComentariosDeUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idUsuario;
        
        public ObtenerComentariosDeUsuarioRequest() {
        }
        
        public ObtenerComentariosDeUsuarioRequest(int idUsuario) {
            this.idUsuario = idUsuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerComentariosDeUsuarioResponse", WrapperNamespace="http://webservices/", IsWrapped=true)]
    public partial class ObtenerComentariosDeUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoEscritorio.ComentarioWS.comentario[] @return;
        
        public ObtenerComentariosDeUsuarioResponse() {
        }
        
        public ObtenerComentariosDeUsuarioResponse(ProyectoEscritorio.ComentarioWS.comentario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ComentarioWSChannel : ProyectoEscritorio.ComentarioWS.ComentarioWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ComentarioWSClient : System.ServiceModel.ClientBase<ProyectoEscritorio.ComentarioWS.ComentarioWS>, ProyectoEscritorio.ComentarioWS.ComentarioWS {
        
        public ComentarioWSClient() {
        }
        
        public ComentarioWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ComentarioWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComentarioWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComentarioWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoEscritorio.ComentarioWS.CrearComentarioResponse ProyectoEscritorio.ComentarioWS.ComentarioWS.CrearComentario(ProyectoEscritorio.ComentarioWS.CrearComentarioRequest request) {
            return base.Channel.CrearComentario(request);
        }
        
        public int CrearComentario(string descripcion, string fecha, int idUsuario, int idActividad) {
            ProyectoEscritorio.ComentarioWS.CrearComentarioRequest inValue = new ProyectoEscritorio.ComentarioWS.CrearComentarioRequest();
            inValue.descripcion = descripcion;
            inValue.fecha = fecha;
            inValue.idUsuario = idUsuario;
            inValue.idActividad = idActividad;
            ProyectoEscritorio.ComentarioWS.CrearComentarioResponse retVal = ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).CrearComentario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.CrearComentarioResponse> ProyectoEscritorio.ComentarioWS.ComentarioWS.CrearComentarioAsync(ProyectoEscritorio.ComentarioWS.CrearComentarioRequest request) {
            return base.Channel.CrearComentarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.CrearComentarioResponse> CrearComentarioAsync(string descripcion, string fecha, int idUsuario, int idActividad) {
            ProyectoEscritorio.ComentarioWS.CrearComentarioRequest inValue = new ProyectoEscritorio.ComentarioWS.CrearComentarioRequest();
            inValue.descripcion = descripcion;
            inValue.fecha = fecha;
            inValue.idUsuario = idUsuario;
            inValue.idActividad = idActividad;
            return ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).CrearComentarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoEscritorio.ComentarioWS.EliminarComentarioResponse ProyectoEscritorio.ComentarioWS.ComentarioWS.EliminarComentario(ProyectoEscritorio.ComentarioWS.EliminarComentarioRequest request) {
            return base.Channel.EliminarComentario(request);
        }
        
        public bool EliminarComentario(int id) {
            ProyectoEscritorio.ComentarioWS.EliminarComentarioRequest inValue = new ProyectoEscritorio.ComentarioWS.EliminarComentarioRequest();
            inValue.id = id;
            ProyectoEscritorio.ComentarioWS.EliminarComentarioResponse retVal = ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).EliminarComentario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.EliminarComentarioResponse> ProyectoEscritorio.ComentarioWS.ComentarioWS.EliminarComentarioAsync(ProyectoEscritorio.ComentarioWS.EliminarComentarioRequest request) {
            return base.Channel.EliminarComentarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.EliminarComentarioResponse> EliminarComentarioAsync(int id) {
            ProyectoEscritorio.ComentarioWS.EliminarComentarioRequest inValue = new ProyectoEscritorio.ComentarioWS.EliminarComentarioRequest();
            inValue.id = id;
            return ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).EliminarComentarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoEscritorio.ComentarioWS.SeleccionarComentarioResponse ProyectoEscritorio.ComentarioWS.ComentarioWS.SeleccionarComentario(ProyectoEscritorio.ComentarioWS.SeleccionarComentarioRequest request) {
            return base.Channel.SeleccionarComentario(request);
        }
        
        public ProyectoEscritorio.ComentarioWS.comentario SeleccionarComentario(int id) {
            ProyectoEscritorio.ComentarioWS.SeleccionarComentarioRequest inValue = new ProyectoEscritorio.ComentarioWS.SeleccionarComentarioRequest();
            inValue.id = id;
            ProyectoEscritorio.ComentarioWS.SeleccionarComentarioResponse retVal = ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).SeleccionarComentario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.SeleccionarComentarioResponse> ProyectoEscritorio.ComentarioWS.ComentarioWS.SeleccionarComentarioAsync(ProyectoEscritorio.ComentarioWS.SeleccionarComentarioRequest request) {
            return base.Channel.SeleccionarComentarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.SeleccionarComentarioResponse> SeleccionarComentarioAsync(int id) {
            ProyectoEscritorio.ComentarioWS.SeleccionarComentarioRequest inValue = new ProyectoEscritorio.ComentarioWS.SeleccionarComentarioRequest();
            inValue.id = id;
            return ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).SeleccionarComentarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadResponse ProyectoEscritorio.ComentarioWS.ComentarioWS.ObtenerComentariosDeActividad(ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadRequest request) {
            return base.Channel.ObtenerComentariosDeActividad(request);
        }
        
        public ProyectoEscritorio.ComentarioWS.comentario[] ObtenerComentariosDeActividad(int idActividad) {
            ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadRequest inValue = new ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadRequest();
            inValue.idActividad = idActividad;
            ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadResponse retVal = ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).ObtenerComentariosDeActividad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadResponse> ProyectoEscritorio.ComentarioWS.ComentarioWS.ObtenerComentariosDeActividadAsync(ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadRequest request) {
            return base.Channel.ObtenerComentariosDeActividadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadResponse> ObtenerComentariosDeActividadAsync(int idActividad) {
            ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadRequest inValue = new ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeActividadRequest();
            inValue.idActividad = idActividad;
            return ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).ObtenerComentariosDeActividadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioResponse ProyectoEscritorio.ComentarioWS.ComentarioWS.ObtenerComentariosDeUsuario(ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioRequest request) {
            return base.Channel.ObtenerComentariosDeUsuario(request);
        }
        
        public ProyectoEscritorio.ComentarioWS.comentario[] ObtenerComentariosDeUsuario(int idUsuario) {
            ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioRequest inValue = new ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioRequest();
            inValue.idUsuario = idUsuario;
            ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioResponse retVal = ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).ObtenerComentariosDeUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioResponse> ProyectoEscritorio.ComentarioWS.ComentarioWS.ObtenerComentariosDeUsuarioAsync(ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioRequest request) {
            return base.Channel.ObtenerComentariosDeUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioResponse> ObtenerComentariosDeUsuarioAsync(int idUsuario) {
            ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioRequest inValue = new ProyectoEscritorio.ComentarioWS.ObtenerComentariosDeUsuarioRequest();
            inValue.idUsuario = idUsuario;
            return ((ProyectoEscritorio.ComentarioWS.ComentarioWS)(this)).ObtenerComentariosDeUsuarioAsync(inValue);
        }
    }
}
