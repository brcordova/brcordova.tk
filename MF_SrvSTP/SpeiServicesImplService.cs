

namespace MF_SrvSTP
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "SpeiServicesImplServiceSoapBinding", Namespace = "http://h2h.integration.spei.enlacefi.lgec.com/")]
    public partial class SpeiServicesImplService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback registraOrdenesTraspasosOperationCompleted;

        private System.Threading.SendOrPostCallback confirmaAbonoOperationCompleted;

        private System.Threading.SendOrPostCallback tiempoEntregaCargoOperationCompleted;

        private System.Threading.SendOrPostCallback tiempoEntregaAbonoRastreoOperationCompleted;

        private System.Threading.SendOrPostCallback devuelveOrdenRazonRechazoOperationCompleted;

        private System.Threading.SendOrPostCallback registraDetalleErrorRecepcionOperationCompleted;

        private System.Threading.SendOrPostCallback confirmaCargoOperationCompleted;

        private System.Threading.SendOrPostCallback devuelveOrdenClaveRastreoOperationCompleted;

        private System.Threading.SendOrPostCallback registraTraspasoOperationCompleted;

        private System.Threading.SendOrPostCallback devuelveOrdenOperationCompleted;

        private System.Threading.SendOrPostCallback consultaOrdenEnviadaOperationCompleted;

        private System.Threading.SendOrPostCallback tiempoEntregaCargoRastreoOperationCompleted;

        private System.Threading.SendOrPostCallback registraDetalleErrorEnvioOperationCompleted;

        private System.Threading.SendOrPostCallback confirmaAbonoDelayOperationCompleted;

        private System.Threading.SendOrPostCallback consultaNominaTesofeOperationCompleted;

        private System.Threading.SendOrPostCallback consultaNominaTesofeFechaOperacionOperationCompleted;

        private System.Threading.SendOrPostCallback consultaOrdenEnviadaRastreoOperationCompleted;

        private System.Threading.SendOrPostCallback confirmaAbonoIdOperationCompleted;

        private System.Threading.SendOrPostCallback registraOrdenOperationCompleted;

        private System.Threading.SendOrPostCallback consultaOrdenRecibidaOperationCompleted;

        private System.Threading.SendOrPostCallback tiempoEntregaAbonoOperationCompleted;

        private System.Threading.SendOrPostCallback registraOrdenesOperationCompleted;

        /// <remarks/>
        public SpeiServicesImplService() { }

        /// <remarks/>
        public event registraOrdenesTraspasosCompletedEventHandler registraOrdenesTraspasosCompleted;

        /// <remarks/>
        public event confirmaAbonoCompletedEventHandler confirmaAbonoCompleted;

        /// <remarks/>
        public event tiempoEntregaCargoCompletedEventHandler tiempoEntregaCargoCompleted;

        /// <remarks/>
        public event tiempoEntregaAbonoRastreoCompletedEventHandler tiempoEntregaAbonoRastreoCompleted;

        /// <remarks/>
        public event devuelveOrdenRazonRechazoCompletedEventHandler devuelveOrdenRazonRechazoCompleted;

        /// <remarks/>
        public event registraDetalleErrorRecepcionCompletedEventHandler registraDetalleErrorRecepcionCompleted;

        /// <remarks/>
        public event confirmaCargoCompletedEventHandler confirmaCargoCompleted;

        /// <remarks/>
        public event devuelveOrdenClaveRastreoCompletedEventHandler devuelveOrdenClaveRastreoCompleted;

        /// <remarks/>
        public event registraTraspasoCompletedEventHandler registraTraspasoCompleted;

        /// <remarks/>
        public event devuelveOrdenCompletedEventHandler devuelveOrdenCompleted;

        /// <remarks/>
        public event consultaOrdenEnviadaCompletedEventHandler consultaOrdenEnviadaCompleted;

        /// <remarks/>
        public event tiempoEntregaCargoRastreoCompletedEventHandler tiempoEntregaCargoRastreoCompleted;

        /// <remarks/>
        public event registraDetalleErrorEnvioCompletedEventHandler registraDetalleErrorEnvioCompleted;

        /// <remarks/>
        public event confirmaAbonoDelayCompletedEventHandler confirmaAbonoDelayCompleted;

        /// <remarks/>
        public event consultaNominaTesofeCompletedEventHandler consultaNominaTesofeCompleted;

        /// <remarks/>
        public event consultaNominaTesofeFechaOperacionCompletedEventHandler consultaNominaTesofeFechaOperacionCompleted;

        /// <remarks/>
        public event consultaOrdenEnviadaRastreoCompletedEventHandler consultaOrdenEnviadaRastreoCompleted;

        /// <remarks/>
        public event confirmaAbonoIdCompletedEventHandler confirmaAbonoIdCompleted;

        /// <remarks/>
        public event registraOrdenCompletedEventHandler registraOrdenCompleted;

        /// <remarks/>
        public event consultaOrdenRecibidaCompletedEventHandler consultaOrdenRecibidaCompleted;

        /// <remarks/>
        public event tiempoEntregaAbonoCompletedEventHandler tiempoEntregaAbonoCompleted;

        /// <remarks/>
        public event registraOrdenesCompletedEventHandler registraOrdenesCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public responseOrdenTraspaso registraOrdenesTraspasos([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] ordenesTraspasos ordenesTraspasos)
        {
            object[] results = this.Invoke("registraOrdenesTraspasos", new object[] {
                    ordenesTraspasos});
            return ((responseOrdenTraspaso)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginregistraOrdenesTraspasos(ordenesTraspasos ordenesTraspasos, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("registraOrdenesTraspasos", new object[] {
                    ordenesTraspasos}, callback, asyncState);
        }

        /// <remarks/>
        public responseOrdenTraspaso EndregistraOrdenesTraspasos(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((responseOrdenTraspaso)(results[0]));
        }

        /// <remarks/>
        public void registraOrdenesTraspasosAsync(ordenesTraspasos ordenesTraspasos)
        {
            this.registraOrdenesTraspasosAsync(ordenesTraspasos, null);
        }

        /// <remarks/>
        public void registraOrdenesTraspasosAsync(ordenesTraspasos ordenesTraspasos, object userState)
        {
            if ((this.registraOrdenesTraspasosOperationCompleted == null))
            {
                this.registraOrdenesTraspasosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregistraOrdenesTraspasosOperationCompleted);
            }
            this.InvokeAsync("registraOrdenesTraspasos", new object[] {
                    ordenesTraspasos}, this.registraOrdenesTraspasosOperationCompleted, userState);
        }

        private void OnregistraOrdenesTraspasosOperationCompleted(object arg)
        {
            if ((this.registraOrdenesTraspasosCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registraOrdenesTraspasosCompleted(this, new registraOrdenesTraspasosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse confirmaAbono([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int fechaOperacion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool fechaOperacionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int institucionContraparte, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool institucionContraparteSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string claveRastreo, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string rfc)
        {
            object[] results = this.Invoke("confirmaAbono", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    institucionContraparte,
                    institucionContraparteSpecified,
                    claveRastreo,
                    rfc});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconfirmaAbono(int fechaOperacion, bool fechaOperacionSpecified, int institucionContraparte, bool institucionContraparteSpecified, string claveRastreo, string rfc, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("confirmaAbono", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    institucionContraparte,
                    institucionContraparteSpecified,
                    claveRastreo,
                    rfc}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EndconfirmaAbono(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void confirmaAbonoAsync(int fechaOperacion, bool fechaOperacionSpecified, int institucionContraparte, bool institucionContraparteSpecified, string claveRastreo, string rfc)
        {
            this.confirmaAbonoAsync(fechaOperacion, fechaOperacionSpecified, institucionContraparte, institucionContraparteSpecified, claveRastreo, rfc, null);
        }

        /// <remarks/>
        public void confirmaAbonoAsync(int fechaOperacion, bool fechaOperacionSpecified, int institucionContraparte, bool institucionContraparteSpecified, string claveRastreo, string rfc, object userState)
        {
            if ((this.confirmaAbonoOperationCompleted == null))
            {
                this.confirmaAbonoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconfirmaAbonoOperationCompleted);
            }
            this.InvokeAsync("confirmaAbono", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    institucionContraparte,
                    institucionContraparteSpecified,
                    claveRastreo,
                    rfc}, this.confirmaAbonoOperationCompleted, userState);
        }

        private void OnconfirmaAbonoOperationCompleted(object arg)
        {
            if ((this.confirmaAbonoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.confirmaAbonoCompleted(this, new confirmaAbonoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void tiempoEntregaCargo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idOrden, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idOrdenSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] out long @return, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
        {
            object[] results = this.Invoke("tiempoEntregaCargo", new object[] {
                    idOrden,
                    idOrdenSpecified});
            @return = ((long)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public System.IAsyncResult BegintiempoEntregaCargo(int idOrden, bool idOrdenSpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("tiempoEntregaCargo", new object[] {
                    idOrden,
                    idOrdenSpecified}, callback, asyncState);
        }

        /// <remarks/>
        public void EndtiempoEntregaCargo(System.IAsyncResult asyncResult, out long @return, out bool returnSpecified)
        {
            object[] results = this.EndInvoke(asyncResult);
            @return = ((long)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public void tiempoEntregaCargoAsync(int idOrden, bool idOrdenSpecified)
        {
            this.tiempoEntregaCargoAsync(idOrden, idOrdenSpecified, null);
        }

        /// <remarks/>
        public void tiempoEntregaCargoAsync(int idOrden, bool idOrdenSpecified, object userState)
        {
            if ((this.tiempoEntregaCargoOperationCompleted == null))
            {
                this.tiempoEntregaCargoOperationCompleted = new System.Threading.SendOrPostCallback(this.OntiempoEntregaCargoOperationCompleted);
            }
            this.InvokeAsync("tiempoEntregaCargo", new object[] {
                    idOrden,
                    idOrdenSpecified}, this.tiempoEntregaCargoOperationCompleted, userState);
        }

        private void OntiempoEntregaCargoOperationCompleted(object arg)
        {
            if ((this.tiempoEntregaCargoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.tiempoEntregaCargoCompleted(this, new tiempoEntregaCargoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void tiempoEntregaAbonoRastreo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int fechaOperacion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool fechaOperacionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string rastreo, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int instContraparte, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool instContraparteSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] out long @return, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
        {
            object[] results = this.Invoke("tiempoEntregaAbonoRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    rastreo,
                    instContraparte,
                    instContraparteSpecified});
            @return = ((long)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public System.IAsyncResult BegintiempoEntregaAbonoRastreo(int fechaOperacion, bool fechaOperacionSpecified, string rastreo, int instContraparte, bool instContraparteSpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("tiempoEntregaAbonoRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    rastreo,
                    instContraparte,
                    instContraparteSpecified}, callback, asyncState);
        }

        /// <remarks/>
        public void EndtiempoEntregaAbonoRastreo(System.IAsyncResult asyncResult, out long @return, out bool returnSpecified)
        {
            object[] results = this.EndInvoke(asyncResult);
            @return = ((long)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public void tiempoEntregaAbonoRastreoAsync(int fechaOperacion, bool fechaOperacionSpecified, string rastreo, int instContraparte, bool instContraparteSpecified)
        {
            this.tiempoEntregaAbonoRastreoAsync(fechaOperacion, fechaOperacionSpecified, rastreo, instContraparte, instContraparteSpecified, null);
        }

        /// <remarks/>
        public void tiempoEntregaAbonoRastreoAsync(int fechaOperacion, bool fechaOperacionSpecified, string rastreo, int instContraparte, bool instContraparteSpecified, object userState)
        {
            if ((this.tiempoEntregaAbonoRastreoOperationCompleted == null))
            {
                this.tiempoEntregaAbonoRastreoOperationCompleted = new System.Threading.SendOrPostCallback(this.OntiempoEntregaAbonoRastreoOperationCompleted);
            }
            this.InvokeAsync("tiempoEntregaAbonoRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    rastreo,
                    instContraparte,
                    instContraparteSpecified}, this.tiempoEntregaAbonoRastreoOperationCompleted, userState);
        }

        private void OntiempoEntregaAbonoRastreoOperationCompleted(object arg)
        {
            if ((this.tiempoEntregaAbonoRastreoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.tiempoEntregaAbonoRastreoCompleted(this, new tiempoEntregaAbonoRastreoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse devuelveOrdenRazonRechazo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idOrden, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idOrdenSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int causaDevolucion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool causaDevolucionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string nuevoRastreo, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int medioEntrega, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool medioEntregaSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string usuario, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string razonRechazo)
        {
            object[] results = this.Invoke("devuelveOrdenRazonRechazo", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario,
                    razonRechazo});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegindevuelveOrdenRazonRechazo(int idOrden, bool idOrdenSpecified, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario, string razonRechazo, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("devuelveOrdenRazonRechazo", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario,
                    razonRechazo}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EnddevuelveOrdenRazonRechazo(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void devuelveOrdenRazonRechazoAsync(int idOrden, bool idOrdenSpecified, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario, string razonRechazo)
        {
            this.devuelveOrdenRazonRechazoAsync(idOrden, idOrdenSpecified, causaDevolucion, causaDevolucionSpecified, nuevoRastreo, medioEntrega, medioEntregaSpecified, usuario, razonRechazo, null);
        }

        /// <remarks/>
        public void devuelveOrdenRazonRechazoAsync(int idOrden, bool idOrdenSpecified, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario, string razonRechazo, object userState)
        {
            if ((this.devuelveOrdenRazonRechazoOperationCompleted == null))
            {
                this.devuelveOrdenRazonRechazoOperationCompleted = new System.Threading.SendOrPostCallback(this.OndevuelveOrdenRazonRechazoOperationCompleted);
            }
            this.InvokeAsync("devuelveOrdenRazonRechazo", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario,
                    razonRechazo}, this.devuelveOrdenRazonRechazoOperationCompleted, userState);
        }

        private void OndevuelveOrdenRazonRechazoOperationCompleted(object arg)
        {
            if ((this.devuelveOrdenRazonRechazoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.devuelveOrdenRazonRechazoCompleted(this, new devuelveOrdenRazonRechazoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void registraDetalleErrorRecepcion([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int id, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string detalleError)
        {
            this.Invoke("registraDetalleErrorRecepcion", new object[] {
                    id,
                    idSpecified,
                    detalleError});
        }

        /// <remarks/>
        public System.IAsyncResult BeginregistraDetalleErrorRecepcion(int id, bool idSpecified, string detalleError, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("registraDetalleErrorRecepcion", new object[] {
                    id,
                    idSpecified,
                    detalleError}, callback, asyncState);
        }

        /// <remarks/>
        public void EndregistraDetalleErrorRecepcion(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void registraDetalleErrorRecepcionAsync(int id, bool idSpecified, string detalleError)
        {
            this.registraDetalleErrorRecepcionAsync(id, idSpecified, detalleError, null);
        }

        /// <remarks/>
        public void registraDetalleErrorRecepcionAsync(int id, bool idSpecified, string detalleError, object userState)
        {
            if ((this.registraDetalleErrorRecepcionOperationCompleted == null))
            {
                this.registraDetalleErrorRecepcionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregistraDetalleErrorRecepcionOperationCompleted);
            }
            this.InvokeAsync("registraDetalleErrorRecepcion", new object[] {
                    id,
                    idSpecified,
                    detalleError}, this.registraDetalleErrorRecepcionOperationCompleted, userState);
        }

        private void OnregistraDetalleErrorRecepcionOperationCompleted(object arg)
        {
            if ((this.registraDetalleErrorRecepcionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registraDetalleErrorRecepcionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse confirmaCargo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idOrden, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idOrdenSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string razonCancelacion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string nuevoEstado, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string folio)
        {
            object[] results = this.Invoke("confirmaCargo", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    razonCancelacion,
                    nuevoEstado,
                    folio});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconfirmaCargo(int idOrden, bool idOrdenSpecified, string razonCancelacion, string nuevoEstado, string folio, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("confirmaCargo", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    razonCancelacion,
                    nuevoEstado,
                    folio}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EndconfirmaCargo(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void confirmaCargoAsync(int idOrden, bool idOrdenSpecified, string razonCancelacion, string nuevoEstado, string folio)
        {
            this.confirmaCargoAsync(idOrden, idOrdenSpecified, razonCancelacion, nuevoEstado, folio, null);
        }

        /// <remarks/>
        public void confirmaCargoAsync(int idOrden, bool idOrdenSpecified, string razonCancelacion, string nuevoEstado, string folio, object userState)
        {
            if ((this.confirmaCargoOperationCompleted == null))
            {
                this.confirmaCargoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconfirmaCargoOperationCompleted);
            }
            this.InvokeAsync("confirmaCargo", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    razonCancelacion,
                    nuevoEstado,
                    folio}, this.confirmaCargoOperationCompleted, userState);
        }

        private void OnconfirmaCargoOperationCompleted(object arg)
        {
            if ((this.confirmaCargoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.confirmaCargoCompleted(this, new confirmaCargoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse devuelveOrdenClaveRastreo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int claveInstitucion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool claveInstitucionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string claveRastreo, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int causaDevolucion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool causaDevolucionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string nuevoRastreo, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int medioEntrega, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool medioEntregaSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string usuario)
        {
            object[] results = this.Invoke("devuelveOrdenClaveRastreo", new object[] {
                    claveInstitucion,
                    claveInstitucionSpecified,
                    claveRastreo,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegindevuelveOrdenClaveRastreo(int claveInstitucion, bool claveInstitucionSpecified, string claveRastreo, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("devuelveOrdenClaveRastreo", new object[] {
                    claveInstitucion,
                    claveInstitucionSpecified,
                    claveRastreo,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EnddevuelveOrdenClaveRastreo(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void devuelveOrdenClaveRastreoAsync(int claveInstitucion, bool claveInstitucionSpecified, string claveRastreo, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario)
        {
            this.devuelveOrdenClaveRastreoAsync(claveInstitucion, claveInstitucionSpecified, claveRastreo, causaDevolucion, causaDevolucionSpecified, nuevoRastreo, medioEntrega, medioEntregaSpecified, usuario, null);
        }

        /// <remarks/>
        public void devuelveOrdenClaveRastreoAsync(int claveInstitucion, bool claveInstitucionSpecified, string claveRastreo, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario, object userState)
        {
            if ((this.devuelveOrdenClaveRastreoOperationCompleted == null))
            {
                this.devuelveOrdenClaveRastreoOperationCompleted = new System.Threading.SendOrPostCallback(this.OndevuelveOrdenClaveRastreoOperationCompleted);
            }
            this.InvokeAsync("devuelveOrdenClaveRastreo", new object[] {
                    claveInstitucion,
                    claveInstitucionSpecified,
                    claveRastreo,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario}, this.devuelveOrdenClaveRastreoOperationCompleted, userState);
        }

        private void OndevuelveOrdenClaveRastreoOperationCompleted(object arg)
        {
            if ((this.devuelveOrdenClaveRastreoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.devuelveOrdenClaveRastreoCompleted(this, new devuelveOrdenClaveRastreoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse registraTraspaso([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] traspasoWS traspaso)
        {
            object[] results = this.Invoke("registraTraspaso", new object[] {
                    traspaso});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginregistraTraspaso(traspasoWS traspaso, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("registraTraspaso", new object[] {
                    traspaso}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EndregistraTraspaso(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void registraTraspasoAsync(traspasoWS traspaso)
        {
            this.registraTraspasoAsync(traspaso, null);
        }

        /// <remarks/>
        public void registraTraspasoAsync(traspasoWS traspaso, object userState)
        {
            if ((this.registraTraspasoOperationCompleted == null))
            {
                this.registraTraspasoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregistraTraspasoOperationCompleted);
            }
            this.InvokeAsync("registraTraspaso", new object[] {
                    traspaso}, this.registraTraspasoOperationCompleted, userState);
        }

        private void OnregistraTraspasoOperationCompleted(object arg)
        {
            if ((this.registraTraspasoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registraTraspasoCompleted(this, new registraTraspasoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse devuelveOrden([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idOrden, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idOrdenSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int causaDevolucion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool causaDevolucionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string nuevoRastreo, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int medioEntrega, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool medioEntregaSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string usuario)
        {
            object[] results = this.Invoke("devuelveOrden", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegindevuelveOrden(int idOrden, bool idOrdenSpecified, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("devuelveOrden", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EnddevuelveOrden(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void devuelveOrdenAsync(int idOrden, bool idOrdenSpecified, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario)
        {
            this.devuelveOrdenAsync(idOrden, idOrdenSpecified, causaDevolucion, causaDevolucionSpecified, nuevoRastreo, medioEntrega, medioEntregaSpecified, usuario, null);
        }

        /// <remarks/>
        public void devuelveOrdenAsync(int idOrden, bool idOrdenSpecified, int causaDevolucion, bool causaDevolucionSpecified, string nuevoRastreo, int medioEntrega, bool medioEntregaSpecified, string usuario, object userState)
        {
            if ((this.devuelveOrdenOperationCompleted == null))
            {
                this.devuelveOrdenOperationCompleted = new System.Threading.SendOrPostCallback(this.OndevuelveOrdenOperationCompleted);
            }
            this.InvokeAsync("devuelveOrden", new object[] {
                    idOrden,
                    idOrdenSpecified,
                    causaDevolucion,
                    causaDevolucionSpecified,
                    nuevoRastreo,
                    medioEntrega,
                    medioEntregaSpecified,
                    usuario}, this.devuelveOrdenOperationCompleted, userState);
        }

        private void OndevuelveOrdenOperationCompleted(object arg)
        {
            if ((this.devuelveOrdenCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.devuelveOrdenCompleted(this, new devuelveOrdenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ordenPagoWS consultaOrdenEnviada([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idOrden, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idOrdenSpecified)
        {
            object[] results = this.Invoke("consultaOrdenEnviada", new object[] {
                    idOrden,
                    idOrdenSpecified});
            return ((ordenPagoWS)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconsultaOrdenEnviada(int idOrden, bool idOrdenSpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("consultaOrdenEnviada", new object[] {
                    idOrden,
                    idOrdenSpecified}, callback, asyncState);
        }

        /// <remarks/>
        public ordenPagoWS EndconsultaOrdenEnviada(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ordenPagoWS)(results[0]));
        }

        /// <remarks/>
        public void consultaOrdenEnviadaAsync(int idOrden, bool idOrdenSpecified)
        {
            this.consultaOrdenEnviadaAsync(idOrden, idOrdenSpecified, null);
        }

        /// <remarks/>
        public void consultaOrdenEnviadaAsync(int idOrden, bool idOrdenSpecified, object userState)
        {
            if ((this.consultaOrdenEnviadaOperationCompleted == null))
            {
                this.consultaOrdenEnviadaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultaOrdenEnviadaOperationCompleted);
            }
            this.InvokeAsync("consultaOrdenEnviada", new object[] {
                    idOrden,
                    idOrdenSpecified}, this.consultaOrdenEnviadaOperationCompleted, userState);
        }

        private void OnconsultaOrdenEnviadaOperationCompleted(object arg)
        {
            if ((this.consultaOrdenEnviadaCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultaOrdenEnviadaCompleted(this, new consultaOrdenEnviadaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void tiempoEntregaCargoRastreo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int fechaOperacion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool fechaOperacionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string rastreo, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int instOperante, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool instOperanteSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] out long @return, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
        {
            object[] results = this.Invoke("tiempoEntregaCargoRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    rastreo,
                    instOperante,
                    instOperanteSpecified});
            @return = ((long)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public System.IAsyncResult BegintiempoEntregaCargoRastreo(int fechaOperacion, bool fechaOperacionSpecified, string rastreo, int instOperante, bool instOperanteSpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("tiempoEntregaCargoRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    rastreo,
                    instOperante,
                    instOperanteSpecified}, callback, asyncState);
        }

        /// <remarks/>
        public void EndtiempoEntregaCargoRastreo(System.IAsyncResult asyncResult, out long @return, out bool returnSpecified)
        {
            object[] results = this.EndInvoke(asyncResult);
            @return = ((long)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public void tiempoEntregaCargoRastreoAsync(int fechaOperacion, bool fechaOperacionSpecified, string rastreo, int instOperante, bool instOperanteSpecified)
        {
            this.tiempoEntregaCargoRastreoAsync(fechaOperacion, fechaOperacionSpecified, rastreo, instOperante, instOperanteSpecified, null);
        }

        /// <remarks/>
        public void tiempoEntregaCargoRastreoAsync(int fechaOperacion, bool fechaOperacionSpecified, string rastreo, int instOperante, bool instOperanteSpecified, object userState)
        {
            if ((this.tiempoEntregaCargoRastreoOperationCompleted == null))
            {
                this.tiempoEntregaCargoRastreoOperationCompleted = new System.Threading.SendOrPostCallback(this.OntiempoEntregaCargoRastreoOperationCompleted);
            }
            this.InvokeAsync("tiempoEntregaCargoRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    rastreo,
                    instOperante,
                    instOperanteSpecified}, this.tiempoEntregaCargoRastreoOperationCompleted, userState);
        }

        private void OntiempoEntregaCargoRastreoOperationCompleted(object arg)
        {
            if ((this.tiempoEntregaCargoRastreoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.tiempoEntregaCargoRastreoCompleted(this, new tiempoEntregaCargoRastreoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void registraDetalleErrorEnvio([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int id, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string detalleError)
        {
            this.Invoke("registraDetalleErrorEnvio", new object[] {
                    id,
                    idSpecified,
                    detalleError});
        }

        /// <remarks/>
        public System.IAsyncResult BeginregistraDetalleErrorEnvio(int id, bool idSpecified, string detalleError, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("registraDetalleErrorEnvio", new object[] {
                    id,
                    idSpecified,
                    detalleError}, callback, asyncState);
        }

        /// <remarks/>
        public void EndregistraDetalleErrorEnvio(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void registraDetalleErrorEnvioAsync(int id, bool idSpecified, string detalleError)
        {
            this.registraDetalleErrorEnvioAsync(id, idSpecified, detalleError, null);
        }

        /// <remarks/>
        public void registraDetalleErrorEnvioAsync(int id, bool idSpecified, string detalleError, object userState)
        {
            if ((this.registraDetalleErrorEnvioOperationCompleted == null))
            {
                this.registraDetalleErrorEnvioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregistraDetalleErrorEnvioOperationCompleted);
            }
            this.InvokeAsync("registraDetalleErrorEnvio", new object[] {
                    id,
                    idSpecified,
                    detalleError}, this.registraDetalleErrorEnvioOperationCompleted, userState);
        }

        private void OnregistraDetalleErrorEnvioOperationCompleted(object arg)
        {
            if ((this.registraDetalleErrorEnvioCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registraDetalleErrorEnvioCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse confirmaAbonoDelay([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idEF, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idEFSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string rfc, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] long delay, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool delaySpecified)
        {
            object[] results = this.Invoke("confirmaAbonoDelay", new object[] {
                    idEF,
                    idEFSpecified,
                    rfc,
                    delay,
                    delaySpecified});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconfirmaAbonoDelay(int idEF, bool idEFSpecified, string rfc, long delay, bool delaySpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("confirmaAbonoDelay", new object[] {
                    idEF,
                    idEFSpecified,
                    rfc,
                    delay,
                    delaySpecified}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EndconfirmaAbonoDelay(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void confirmaAbonoDelayAsync(int idEF, bool idEFSpecified, string rfc, long delay, bool delaySpecified)
        {
            this.confirmaAbonoDelayAsync(idEF, idEFSpecified, rfc, delay, delaySpecified, null);
        }

        /// <remarks/>
        public void confirmaAbonoDelayAsync(int idEF, bool idEFSpecified, string rfc, long delay, bool delaySpecified, object userState)
        {
            if ((this.confirmaAbonoDelayOperationCompleted == null))
            {
                this.confirmaAbonoDelayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconfirmaAbonoDelayOperationCompleted);
            }
            this.InvokeAsync("confirmaAbonoDelay", new object[] {
                    idEF,
                    idEFSpecified,
                    rfc,
                    delay,
                    delaySpecified}, this.confirmaAbonoDelayOperationCompleted, userState);
        }

        private void OnconfirmaAbonoDelayOperationCompleted(object arg)
        {
            if ((this.confirmaAbonoDelayCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.confirmaAbonoDelayCompleted(this, new confirmaAbonoDelayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public nominaTesofeWS consultaNominaTesofe([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int institucion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool institucionSpecified)
        {
            object[] results = this.Invoke("consultaNominaTesofe", new object[] {
                    institucion,
                    institucionSpecified});
            return ((nominaTesofeWS)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconsultaNominaTesofe(int institucion, bool institucionSpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("consultaNominaTesofe", new object[] {
                    institucion,
                    institucionSpecified}, callback, asyncState);
        }

        /// <remarks/>
        public nominaTesofeWS EndconsultaNominaTesofe(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((nominaTesofeWS)(results[0]));
        }

        /// <remarks/>
        public void consultaNominaTesofeAsync(int institucion, bool institucionSpecified)
        {
            this.consultaNominaTesofeAsync(institucion, institucionSpecified, null);
        }

        /// <remarks/>
        public void consultaNominaTesofeAsync(int institucion, bool institucionSpecified, object userState)
        {
            if ((this.consultaNominaTesofeOperationCompleted == null))
            {
                this.consultaNominaTesofeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultaNominaTesofeOperationCompleted);
            }
            this.InvokeAsync("consultaNominaTesofe", new object[] {
                    institucion,
                    institucionSpecified}, this.consultaNominaTesofeOperationCompleted, userState);
        }

        private void OnconsultaNominaTesofeOperationCompleted(object arg)
        {
            if ((this.consultaNominaTesofeCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultaNominaTesofeCompleted(this, new consultaNominaTesofeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public nominaTesofeWS consultaNominaTesofeFechaOperacion([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int institucion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool institucionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int fechaOperacion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool fechaOperacionSpecified)
        {
            object[] results = this.Invoke("consultaNominaTesofeFechaOperacion", new object[] {
                    institucion,
                    institucionSpecified,
                    fechaOperacion,
                    fechaOperacionSpecified});
            return ((nominaTesofeWS)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconsultaNominaTesofeFechaOperacion(int institucion, bool institucionSpecified, int fechaOperacion, bool fechaOperacionSpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("consultaNominaTesofeFechaOperacion", new object[] {
                    institucion,
                    institucionSpecified,
                    fechaOperacion,
                    fechaOperacionSpecified}, callback, asyncState);
        }

        /// <remarks/>
        public nominaTesofeWS EndconsultaNominaTesofeFechaOperacion(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((nominaTesofeWS)(results[0]));
        }

        /// <remarks/>
        public void consultaNominaTesofeFechaOperacionAsync(int institucion, bool institucionSpecified, int fechaOperacion, bool fechaOperacionSpecified)
        {
            this.consultaNominaTesofeFechaOperacionAsync(institucion, institucionSpecified, fechaOperacion, fechaOperacionSpecified, null);
        }

        /// <remarks/>
        public void consultaNominaTesofeFechaOperacionAsync(int institucion, bool institucionSpecified, int fechaOperacion, bool fechaOperacionSpecified, object userState)
        {
            if ((this.consultaNominaTesofeFechaOperacionOperationCompleted == null))
            {
                this.consultaNominaTesofeFechaOperacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultaNominaTesofeFechaOperacionOperationCompleted);
            }
            this.InvokeAsync("consultaNominaTesofeFechaOperacion", new object[] {
                    institucion,
                    institucionSpecified,
                    fechaOperacion,
                    fechaOperacionSpecified}, this.consultaNominaTesofeFechaOperacionOperationCompleted, userState);
        }

        private void OnconsultaNominaTesofeFechaOperacionOperationCompleted(object arg)
        {
            if ((this.consultaNominaTesofeFechaOperacionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultaNominaTesofeFechaOperacionCompleted(this, new consultaNominaTesofeFechaOperacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ordenPagoWS consultaOrdenEnviadaRastreo([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int fechaOperacion, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool fechaOperacionSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int operante, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool operanteSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string rastreo)
        {
            object[] results = this.Invoke("consultaOrdenEnviadaRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    operante,
                    operanteSpecified,
                    rastreo});
            return ((ordenPagoWS)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconsultaOrdenEnviadaRastreo(int fechaOperacion, bool fechaOperacionSpecified, int operante, bool operanteSpecified, string rastreo, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("consultaOrdenEnviadaRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    operante,
                    operanteSpecified,
                    rastreo}, callback, asyncState);
        }

        /// <remarks/>
        public ordenPagoWS EndconsultaOrdenEnviadaRastreo(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ordenPagoWS)(results[0]));
        }

        /// <remarks/>
        public void consultaOrdenEnviadaRastreoAsync(int fechaOperacion, bool fechaOperacionSpecified, int operante, bool operanteSpecified, string rastreo)
        {
            this.consultaOrdenEnviadaRastreoAsync(fechaOperacion, fechaOperacionSpecified, operante, operanteSpecified, rastreo, null);
        }

        /// <remarks/>
        public void consultaOrdenEnviadaRastreoAsync(int fechaOperacion, bool fechaOperacionSpecified, int operante, bool operanteSpecified, string rastreo, object userState)
        {
            if ((this.consultaOrdenEnviadaRastreoOperationCompleted == null))
            {
                this.consultaOrdenEnviadaRastreoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultaOrdenEnviadaRastreoOperationCompleted);
            }
            this.InvokeAsync("consultaOrdenEnviadaRastreo", new object[] {
                    fechaOperacion,
                    fechaOperacionSpecified,
                    operante,
                    operanteSpecified,
                    rastreo}, this.consultaOrdenEnviadaRastreoOperationCompleted, userState);
        }

        private void OnconsultaOrdenEnviadaRastreoOperationCompleted(object arg)
        {
            if ((this.consultaOrdenEnviadaRastreoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultaOrdenEnviadaRastreoCompleted(this, new consultaOrdenEnviadaRastreoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse confirmaAbonoId([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idEF, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idEFSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string rfc)
        {
            object[] results = this.Invoke("confirmaAbonoId", new object[] {
                    idEF,
                    idEFSpecified,
                    rfc});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconfirmaAbonoId(int idEF, bool idEFSpecified, string rfc, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("confirmaAbonoId", new object[] {
                    idEF,
                    idEFSpecified,
                    rfc}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EndconfirmaAbonoId(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void confirmaAbonoIdAsync(int idEF, bool idEFSpecified, string rfc)
        {
            this.confirmaAbonoIdAsync(idEF, idEFSpecified, rfc, null);
        }

        /// <remarks/>
        public void confirmaAbonoIdAsync(int idEF, bool idEFSpecified, string rfc, object userState)
        {
            if ((this.confirmaAbonoIdOperationCompleted == null))
            {
                this.confirmaAbonoIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconfirmaAbonoIdOperationCompleted);
            }
            this.InvokeAsync("confirmaAbonoId", new object[] {
                    idEF,
                    idEFSpecified,
                    rfc}, this.confirmaAbonoIdOperationCompleted, userState);
        }

        private void OnconfirmaAbonoIdOperationCompleted(object arg)
        {
            if ((this.confirmaAbonoIdCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.confirmaAbonoIdCompleted(this, new confirmaAbonoIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse registraOrden([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] ordenPagoWS ordenPago)
        {
            object[] results = this.Invoke("registraOrden", new object[] {
                    ordenPago});
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginregistraOrden(ordenPagoWS ordenPago, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("registraOrden", new object[] {
                    ordenPago}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse EndregistraOrden(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse)(results[0]));
        }

        /// <remarks/>
        public void registraOrdenAsync(ordenPagoWS ordenPago)
        {
            this.registraOrdenAsync(ordenPago, null);
        }

        /// <remarks/>
        public void registraOrdenAsync(ordenPagoWS ordenPago, object userState)
        {
            if ((this.registraOrdenOperationCompleted == null))
            {
                this.registraOrdenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregistraOrdenOperationCompleted);
            }
            this.InvokeAsync("registraOrden", new object[] {
                    ordenPago}, this.registraOrdenOperationCompleted, userState);
        }

        private void OnregistraOrdenOperationCompleted(object arg)
        {
            if ((this.registraOrdenCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registraOrdenCompleted(this, new registraOrdenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ordenPagoWS consultaOrdenRecibida([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idOrden, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idOrdenSpecified)
        {
            object[] results = this.Invoke("consultaOrdenRecibida", new object[] {
                    idOrden,
                    idOrdenSpecified});
            return ((ordenPagoWS)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconsultaOrdenRecibida(int idOrden, bool idOrdenSpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("consultaOrdenRecibida", new object[] {
                    idOrden,
                    idOrdenSpecified}, callback, asyncState);
        }

        /// <remarks/>
        public ordenPagoWS EndconsultaOrdenRecibida(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ordenPagoWS)(results[0]));
        }

        /// <remarks/>
        public void consultaOrdenRecibidaAsync(int idOrden, bool idOrdenSpecified)
        {
            this.consultaOrdenRecibidaAsync(idOrden, idOrdenSpecified, null);
        }

        /// <remarks/>
        public void consultaOrdenRecibidaAsync(int idOrden, bool idOrdenSpecified, object userState)
        {
            if ((this.consultaOrdenRecibidaOperationCompleted == null))
            {
                this.consultaOrdenRecibidaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultaOrdenRecibidaOperationCompleted);
            }
            this.InvokeAsync("consultaOrdenRecibida", new object[] {
                    idOrden,
                    idOrdenSpecified}, this.consultaOrdenRecibidaOperationCompleted, userState);
        }

        private void OnconsultaOrdenRecibidaOperationCompleted(object arg)
        {
            if ((this.consultaOrdenRecibidaCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultaOrdenRecibidaCompleted(this, new consultaOrdenRecibidaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void tiempoEntregaAbono([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] int idOrden, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idOrdenSpecified, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] out long @return, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
        {
            object[] results = this.Invoke("tiempoEntregaAbono", new object[] {
                    idOrden,
                    idOrdenSpecified});
            @return = ((long)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public System.IAsyncResult BegintiempoEntregaAbono(int idOrden, bool idOrdenSpecified, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("tiempoEntregaAbono", new object[] {
                    idOrden,
                    idOrdenSpecified}, callback, asyncState);
        }

        /// <remarks/>
        public void EndtiempoEntregaAbono(System.IAsyncResult asyncResult, out long @return, out bool returnSpecified)
        {
            object[] results = this.EndInvoke(asyncResult);
            @return = ((long)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public void tiempoEntregaAbonoAsync(int idOrden, bool idOrdenSpecified)
        {
            this.tiempoEntregaAbonoAsync(idOrden, idOrdenSpecified, null);
        }

        /// <remarks/>
        public void tiempoEntregaAbonoAsync(int idOrden, bool idOrdenSpecified, object userState)
        {
            if ((this.tiempoEntregaAbonoOperationCompleted == null))
            {
                this.tiempoEntregaAbonoOperationCompleted = new System.Threading.SendOrPostCallback(this.OntiempoEntregaAbonoOperationCompleted);
            }
            this.InvokeAsync("tiempoEntregaAbono", new object[] {
                    idOrden,
                    idOrdenSpecified}, this.tiempoEntregaAbonoOperationCompleted, userState);
        }

        private void OntiempoEntregaAbonoOperationCompleted(object arg)
        {
            if ((this.tiempoEntregaAbonoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.tiempoEntregaAbonoCompleted(this, new tiempoEntregaAbonoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", ResponseNamespace = "http://h2h.integration.spei.enlacefi.lgec.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public speiServiceResponse[] registraOrdenes([System.Xml.Serialization.XmlElementAttribute("ordenesPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] ordenPagoWS[] ordenesPago)
        {
            object[] results = this.Invoke("registraOrdenes", new object[] {
                    ordenesPago});
            return ((speiServiceResponse[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginregistraOrdenes(ordenPagoWS[] ordenesPago, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("registraOrdenes", new object[] {
                    ordenesPago}, callback, asyncState);
        }

        /// <remarks/>
        public speiServiceResponse[] EndregistraOrdenes(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((speiServiceResponse[])(results[0]));
        }

        /// <remarks/>
        public void registraOrdenesAsync(ordenPagoWS[] ordenesPago)
        {
            this.registraOrdenesAsync(ordenesPago, null);
        }

        /// <remarks/>
        public void registraOrdenesAsync(ordenPagoWS[] ordenesPago, object userState)
        {
            if ((this.registraOrdenesOperationCompleted == null))
            {
                this.registraOrdenesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregistraOrdenesOperationCompleted);
            }
            this.InvokeAsync("registraOrdenes", new object[] {
                    ordenesPago}, this.registraOrdenesOperationCompleted, userState);
        }

        private void OnregistraOrdenesOperationCompleted(object arg)
        {
            if ((this.registraOrdenesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registraOrdenesCompleted(this, new registraOrdenesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://h2h.integration.spei.enlacefi.lgec.com/")]
    public partial class ordenesTraspasos
    {

        private ordenPagoWS[] ordenesPagoField;

        private traspasoWS[] traspasosWSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ordenesPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public ordenPagoWS[] ordenesPago
        {
            get
            {
                return this.ordenesPagoField;
            }
            set
            {
                this.ordenesPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("traspasosWS", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public traspasoWS[] traspasosWS
        {
            get
            {
                return this.traspasosWSField;
            }
            set
            {
                this.traspasosWSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://h2h.integration.spei.enlacefi.lgec.com/")]
    public partial class ordenPagoWS
    {

        private int causaDevolucionField;

        private bool causaDevolucionFieldSpecified;

        private string claveCatUsuario1Field;

        private string claveCatUsuario2Field;

        private string clavePagoField;

        private string claveRastreoField;

        private string claveRastreoDevolucionField;

        private string conceptoPagoField;

        private string conceptoPago2Field;

        private string cuentaBeneficiarioField;

        private string cuentaBeneficiario2Field;

        private string cuentaOrdenanteField;

        private string emailBeneficiarioField;

        private string empresaField;

        private string estadoField;

        private int fechaOperacionField;

        private bool fechaOperacionFieldSpecified;

        private string firmaField;

        private string folioOrigenField;

        private string idClienteField;

        private int institucionContraparteField;

        private bool institucionContraparteFieldSpecified;

        private int institucionOperanteField;

        private bool institucionOperanteFieldSpecified;

        private double ivaField;

        private bool ivaFieldSpecified;

        private int medioEntregaField;

        private bool medioEntregaFieldSpecified;

        private decimal montoField;

        private bool montoFieldSpecified;

        private string nombreBeneficiarioField;

        private string nombreBeneficiario2Field;

        private string nombreOrdenanteField;

        private int prioridadField;

        private bool prioridadFieldSpecified;

        private string referenciaCobranzaField;

        private int referenciaNumericaField;

        private bool referenciaNumericaFieldSpecified;

        private string rfcCurpBeneficiarioField;

        private string rfcCurpBeneficiario2Field;

        private string rfcCurpOrdenanteField;

        private int tipoCuentaBeneficiarioField;

        private bool tipoCuentaBeneficiarioFieldSpecified;

        private int tipoCuentaBeneficiario2Field;

        private bool tipoCuentaBeneficiario2FieldSpecified;

        private int tipoCuentaOrdenanteField;

        private bool tipoCuentaOrdenanteFieldSpecified;

        private int tipoOperacionField;

        private bool tipoOperacionFieldSpecified;

        private int tipoPagoField;

        private bool tipoPagoFieldSpecified;

        private string topologiaField;

        private string usuarioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int causaDevolucion
        {
            get
            {
                return this.causaDevolucionField;
            }
            set
            {
                this.causaDevolucionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool causaDevolucionSpecified
        {
            get
            {
                return this.causaDevolucionFieldSpecified;
            }
            set
            {
                this.causaDevolucionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string claveCatUsuario1
        {
            get
            {
                return this.claveCatUsuario1Field;
            }
            set
            {
                this.claveCatUsuario1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string claveCatUsuario2
        {
            get
            {
                return this.claveCatUsuario2Field;
            }
            set
            {
                this.claveCatUsuario2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string clavePago
        {
            get
            {
                return this.clavePagoField;
            }
            set
            {
                this.clavePagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string claveRastreo
        {
            get
            {
                return this.claveRastreoField;
            }
            set
            {
                this.claveRastreoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string claveRastreoDevolucion
        {
            get
            {
                return this.claveRastreoDevolucionField;
            }
            set
            {
                this.claveRastreoDevolucionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string conceptoPago
        {
            get
            {
                return this.conceptoPagoField;
            }
            set
            {
                this.conceptoPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string conceptoPago2
        {
            get
            {
                return this.conceptoPago2Field;
            }
            set
            {
                this.conceptoPago2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cuentaBeneficiario
        {
            get
            {
                return this.cuentaBeneficiarioField;
            }
            set
            {
                this.cuentaBeneficiarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cuentaBeneficiario2
        {
            get
            {
                return this.cuentaBeneficiario2Field;
            }
            set
            {
                this.cuentaBeneficiario2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cuentaOrdenante
        {
            get
            {
                return this.cuentaOrdenanteField;
            }
            set
            {
                this.cuentaOrdenanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string emailBeneficiario
        {
            get
            {
                return this.emailBeneficiarioField;
            }
            set
            {
                this.emailBeneficiarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string empresa
        {
            get
            {
                return this.empresaField;
            }
            set
            {
                this.empresaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int fechaOperacion
        {
            get
            {
                return this.fechaOperacionField;
            }
            set
            {
                this.fechaOperacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaOperacionSpecified
        {
            get
            {
                return this.fechaOperacionFieldSpecified;
            }
            set
            {
                this.fechaOperacionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string firma
        {
            get
            {
                return this.firmaField;
            }
            set
            {
                this.firmaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string folioOrigen
        {
            get
            {
                return this.folioOrigenField;
            }
            set
            {
                this.folioOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idCliente
        {
            get
            {
                return this.idClienteField;
            }
            set
            {
                this.idClienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int institucionContraparte
        {
            get
            {
                return this.institucionContraparteField;
            }
            set
            {
                this.institucionContraparteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool institucionContraparteSpecified
        {
            get
            {
                return this.institucionContraparteFieldSpecified;
            }
            set
            {
                this.institucionContraparteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int institucionOperante
        {
            get
            {
                return this.institucionOperanteField;
            }
            set
            {
                this.institucionOperanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool institucionOperanteSpecified
        {
            get
            {
                return this.institucionOperanteFieldSpecified;
            }
            set
            {
                this.institucionOperanteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double iva
        {
            get
            {
                return this.ivaField;
            }
            set
            {
                this.ivaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ivaSpecified
        {
            get
            {
                return this.ivaFieldSpecified;
            }
            set
            {
                this.ivaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int medioEntrega
        {
            get
            {
                return this.medioEntregaField;
            }
            set
            {
                this.medioEntregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool medioEntregaSpecified
        {
            get
            {
                return this.medioEntregaFieldSpecified;
            }
            set
            {
                this.medioEntregaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal monto
        {
            get
            {
                return this.montoField;
            }
            set
            {
                this.montoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool montoSpecified
        {
            get
            {
                return this.montoFieldSpecified;
            }
            set
            {
                this.montoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombreBeneficiario
        {
            get
            {
                return this.nombreBeneficiarioField;
            }
            set
            {
                this.nombreBeneficiarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombreBeneficiario2
        {
            get
            {
                return this.nombreBeneficiario2Field;
            }
            set
            {
                this.nombreBeneficiario2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombreOrdenante
        {
            get
            {
                return this.nombreOrdenanteField;
            }
            set
            {
                this.nombreOrdenanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int prioridad
        {
            get
            {
                return this.prioridadField;
            }
            set
            {
                this.prioridadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prioridadSpecified
        {
            get
            {
                return this.prioridadFieldSpecified;
            }
            set
            {
                this.prioridadFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string referenciaCobranza
        {
            get
            {
                return this.referenciaCobranzaField;
            }
            set
            {
                this.referenciaCobranzaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int referenciaNumerica
        {
            get
            {
                return this.referenciaNumericaField;
            }
            set
            {
                this.referenciaNumericaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenciaNumericaSpecified
        {
            get
            {
                return this.referenciaNumericaFieldSpecified;
            }
            set
            {
                this.referenciaNumericaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rfcCurpBeneficiario
        {
            get
            {
                return this.rfcCurpBeneficiarioField;
            }
            set
            {
                this.rfcCurpBeneficiarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rfcCurpBeneficiario2
        {
            get
            {
                return this.rfcCurpBeneficiario2Field;
            }
            set
            {
                this.rfcCurpBeneficiario2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rfcCurpOrdenante
        {
            get
            {
                return this.rfcCurpOrdenanteField;
            }
            set
            {
                this.rfcCurpOrdenanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int tipoCuentaBeneficiario
        {
            get
            {
                return this.tipoCuentaBeneficiarioField;
            }
            set
            {
                this.tipoCuentaBeneficiarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoCuentaBeneficiarioSpecified
        {
            get
            {
                return this.tipoCuentaBeneficiarioFieldSpecified;
            }
            set
            {
                this.tipoCuentaBeneficiarioFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int tipoCuentaBeneficiario2
        {
            get
            {
                return this.tipoCuentaBeneficiario2Field;
            }
            set
            {
                this.tipoCuentaBeneficiario2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoCuentaBeneficiario2Specified
        {
            get
            {
                return this.tipoCuentaBeneficiario2FieldSpecified;
            }
            set
            {
                this.tipoCuentaBeneficiario2FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int tipoCuentaOrdenante
        {
            get
            {
                return this.tipoCuentaOrdenanteField;
            }
            set
            {
                this.tipoCuentaOrdenanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoCuentaOrdenanteSpecified
        {
            get
            {
                return this.tipoCuentaOrdenanteFieldSpecified;
            }
            set
            {
                this.tipoCuentaOrdenanteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int tipoOperacion
        {
            get
            {
                return this.tipoOperacionField;
            }
            set
            {
                this.tipoOperacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoOperacionSpecified
        {
            get
            {
                return this.tipoOperacionFieldSpecified;
            }
            set
            {
                this.tipoOperacionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int tipoPago
        {
            get
            {
                return this.tipoPagoField;
            }
            set
            {
                this.tipoPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoPagoSpecified
        {
            get
            {
                return this.tipoPagoFieldSpecified;
            }
            set
            {
                this.tipoPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string topologia
        {
            get
            {
                return this.topologiaField;
            }
            set
            {
                this.topologiaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario
        {
            get
            {
                return this.usuarioField;
            }
            set
            {
                this.usuarioField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://h2h.integration.spei.enlacefi.lgec.com/")]
    public partial class nominaTesofeWS
    {

        private decimal montoPagosField;

        private bool montoPagosFieldSpecified;

        private int numeroPagosField;

        private bool numeroPagosFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal montoPagos
        {
            get
            {
                return this.montoPagosField;
            }
            set
            {
                this.montoPagosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool montoPagosSpecified
        {
            get
            {
                return this.montoPagosFieldSpecified;
            }
            set
            {
                this.montoPagosFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroPagos
        {
            get
            {
                return this.numeroPagosField;
            }
            set
            {
                this.numeroPagosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroPagosSpecified
        {
            get
            {
                return this.numeroPagosFieldSpecified;
            }
            set
            {
                this.numeroPagosFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(speiServiceFolioOrigenResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://h2h.integration.spei.enlacefi.lgec.com/")]
    public partial class speiServiceResponse
    {

        private string descripcionErrorField;

        private int idField;

        private bool idFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcionError
        {
            get
            {
                return this.descripcionErrorField;
            }
            set
            {
                this.descripcionErrorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://h2h.integration.spei.enlacefi.lgec.com/")]
    public partial class speiServiceFolioOrigenResponse : speiServiceResponse
    {

        private string folioOrigenField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string folioOrigen
        {
            get
            {
                return this.folioOrigenField;
            }
            set
            {
                this.folioOrigenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://h2h.integration.spei.enlacefi.lgec.com/")]
    public partial class responseOrdenTraspaso
    {

        private string descripcionErrorField;

        private bool existeErrorField;

        private bool existeErrorFieldSpecified;

        private string folioOrigenField;

        private speiServiceFolioOrigenResponse[] responsesOrdenesField;

        private speiServiceFolioOrigenResponse[] responsesTrapasosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcionError
        {
            get
            {
                return this.descripcionErrorField;
            }
            set
            {
                this.descripcionErrorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool existeError
        {
            get
            {
                return this.existeErrorField;
            }
            set
            {
                this.existeErrorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existeErrorSpecified
        {
            get
            {
                return this.existeErrorFieldSpecified;
            }
            set
            {
                this.existeErrorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string folioOrigen
        {
            get
            {
                return this.folioOrigenField;
            }
            set
            {
                this.folioOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responsesOrdenes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public speiServiceFolioOrigenResponse[] responsesOrdenes
        {
            get
            {
                return this.responsesOrdenesField;
            }
            set
            {
                this.responsesOrdenesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responsesTrapasos", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public speiServiceFolioOrigenResponse[] responsesTrapasos
        {
            get
            {
                return this.responsesTrapasosField;
            }
            set
            {
                this.responsesTrapasosField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://h2h.integration.spei.enlacefi.lgec.com/")]
    public partial class traspasoWS
    {

        private string claveRastreoField;

        private string estadoField;

        private int fechaOperacionField;

        private bool fechaOperacionFieldSpecified;

        private string folioOrigenField;

        private string institucionCASFIMField;

        private int institucionSpeiField;

        private bool institucionSpeiFieldSpecified;

        private int medioEntregaField;

        private bool medioEntregaFieldSpecified;

        private decimal montoField;

        private bool montoFieldSpecified;

        private int tipoTraspasoField;

        private bool tipoTraspasoFieldSpecified;

        private long tsLiquidacionField;

        private bool tsLiquidacionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string claveRastreo
        {
            get
            {
                return this.claveRastreoField;
            }
            set
            {
                this.claveRastreoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int fechaOperacion
        {
            get
            {
                return this.fechaOperacionField;
            }
            set
            {
                this.fechaOperacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaOperacionSpecified
        {
            get
            {
                return this.fechaOperacionFieldSpecified;
            }
            set
            {
                this.fechaOperacionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string folioOrigen
        {
            get
            {
                return this.folioOrigenField;
            }
            set
            {
                this.folioOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string institucionCASFIM
        {
            get
            {
                return this.institucionCASFIMField;
            }
            set
            {
                this.institucionCASFIMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int institucionSpei
        {
            get
            {
                return this.institucionSpeiField;
            }
            set
            {
                this.institucionSpeiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool institucionSpeiSpecified
        {
            get
            {
                return this.institucionSpeiFieldSpecified;
            }
            set
            {
                this.institucionSpeiFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int medioEntrega
        {
            get
            {
                return this.medioEntregaField;
            }
            set
            {
                this.medioEntregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool medioEntregaSpecified
        {
            get
            {
                return this.medioEntregaFieldSpecified;
            }
            set
            {
                this.medioEntregaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal monto
        {
            get
            {
                return this.montoField;
            }
            set
            {
                this.montoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool montoSpecified
        {
            get
            {
                return this.montoFieldSpecified;
            }
            set
            {
                this.montoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int tipoTraspaso
        {
            get
            {
                return this.tipoTraspasoField;
            }
            set
            {
                this.tipoTraspasoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoTraspasoSpecified
        {
            get
            {
                return this.tipoTraspasoFieldSpecified;
            }
            set
            {
                this.tipoTraspasoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long tsLiquidacion
        {
            get
            {
                return this.tsLiquidacionField;
            }
            set
            {
                this.tsLiquidacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tsLiquidacionSpecified
        {
            get
            {
                return this.tsLiquidacionFieldSpecified;
            }
            set
            {
                this.tsLiquidacionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void registraOrdenesTraspasosCompletedEventHandler(object sender, registraOrdenesTraspasosCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class registraOrdenesTraspasosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal registraOrdenesTraspasosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public responseOrdenTraspaso Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((responseOrdenTraspaso)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void confirmaAbonoCompletedEventHandler(object sender, confirmaAbonoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class confirmaAbonoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal confirmaAbonoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void tiempoEntregaCargoCompletedEventHandler(object sender, tiempoEntregaCargoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class tiempoEntregaCargoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal tiempoEntregaCargoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public long @return
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool returnSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void tiempoEntregaAbonoRastreoCompletedEventHandler(object sender, tiempoEntregaAbonoRastreoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class tiempoEntregaAbonoRastreoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal tiempoEntregaAbonoRastreoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public long @return
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool returnSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void devuelveOrdenRazonRechazoCompletedEventHandler(object sender, devuelveOrdenRazonRechazoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class devuelveOrdenRazonRechazoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal devuelveOrdenRazonRechazoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void registraDetalleErrorRecepcionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void confirmaCargoCompletedEventHandler(object sender, confirmaCargoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class confirmaCargoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal confirmaCargoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void devuelveOrdenClaveRastreoCompletedEventHandler(object sender, devuelveOrdenClaveRastreoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class devuelveOrdenClaveRastreoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal devuelveOrdenClaveRastreoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void registraTraspasoCompletedEventHandler(object sender, registraTraspasoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class registraTraspasoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal registraTraspasoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void devuelveOrdenCompletedEventHandler(object sender, devuelveOrdenCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class devuelveOrdenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal devuelveOrdenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void consultaOrdenEnviadaCompletedEventHandler(object sender, consultaOrdenEnviadaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultaOrdenEnviadaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal consultaOrdenEnviadaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ordenPagoWS Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ordenPagoWS)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void tiempoEntregaCargoRastreoCompletedEventHandler(object sender, tiempoEntregaCargoRastreoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class tiempoEntregaCargoRastreoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal tiempoEntregaCargoRastreoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public long @return
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool returnSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void registraDetalleErrorEnvioCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void confirmaAbonoDelayCompletedEventHandler(object sender, confirmaAbonoDelayCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class confirmaAbonoDelayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal confirmaAbonoDelayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void consultaNominaTesofeCompletedEventHandler(object sender, consultaNominaTesofeCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultaNominaTesofeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal consultaNominaTesofeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public nominaTesofeWS Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((nominaTesofeWS)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void consultaNominaTesofeFechaOperacionCompletedEventHandler(object sender, consultaNominaTesofeFechaOperacionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultaNominaTesofeFechaOperacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal consultaNominaTesofeFechaOperacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public nominaTesofeWS Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((nominaTesofeWS)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void consultaOrdenEnviadaRastreoCompletedEventHandler(object sender, consultaOrdenEnviadaRastreoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultaOrdenEnviadaRastreoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal consultaOrdenEnviadaRastreoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ordenPagoWS Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ordenPagoWS)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void confirmaAbonoIdCompletedEventHandler(object sender, confirmaAbonoIdCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class confirmaAbonoIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal confirmaAbonoIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void registraOrdenCompletedEventHandler(object sender, registraOrdenCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class registraOrdenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal registraOrdenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void consultaOrdenRecibidaCompletedEventHandler(object sender, consultaOrdenRecibidaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultaOrdenRecibidaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal consultaOrdenRecibidaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ordenPagoWS Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ordenPagoWS)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void tiempoEntregaAbonoCompletedEventHandler(object sender, tiempoEntregaAbonoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class tiempoEntregaAbonoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal tiempoEntregaAbonoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public long @return
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool returnSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void registraOrdenesCompletedEventHandler(object sender, registraOrdenesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class registraOrdenesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal registraOrdenesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public speiServiceResponse[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((speiServiceResponse[])(this.results[0]));
            }
        }
    }

}
