﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMC.MBWay.Net.API.FinancialOperations {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/", ConfigurationName="API.FinancialOperations.MerchantFinancialOperationWS")]
    public interface MerchantFinancialOperationWS {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://financial.services.merchant.channelmanagermsp.sibs/MerchantFinancialOperat" +
            "ionWS/requestFinancialOperationRequest", ReplyAction="http://financial.services.merchant.channelmanagermsp.sibs/MerchantFinancialOperat" +
            "ionWS/requestFinancialOperationResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResponse requestFinancialOperation(PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/")]
    public partial class requestFinancialOperationRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageTypeField;
        
        private string aditionalDataField;
        
        private alias aliasField;
        
        private financialOperation financialOperationField;
        
        private financialOperation referencedFinancialOperationField;
        
        private merchant merchantField;
        
        private messageProperties messagePropertiesField;
        
        public requestFinancialOperationRequest() {
            this.messageTypeField = "N0003";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string messageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
                this.RaisePropertyChanged("messageType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string aditionalData {
            get {
                return this.aditionalDataField;
            }
            set {
                this.aditionalDataField = value;
                this.RaisePropertyChanged("aditionalData");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public alias alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
                this.RaisePropertyChanged("alias");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public financialOperation financialOperation {
            get {
                return this.financialOperationField;
            }
            set {
                this.financialOperationField = value;
                this.RaisePropertyChanged("financialOperation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public financialOperation referencedFinancialOperation {
            get {
                return this.referencedFinancialOperationField;
            }
            set {
                this.referencedFinancialOperationField = value;
                this.RaisePropertyChanged("referencedFinancialOperation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public merchant merchant {
            get {
                return this.merchantField;
            }
            set {
                this.merchantField = value;
                this.RaisePropertyChanged("merchant");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public messageProperties messageProperties {
            get {
                return this.messagePropertiesField;
            }
            set {
                this.messagePropertiesField = value;
                this.RaisePropertyChanged("messageProperties");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/")]
    public partial class alias : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string aliasNameField;
        
        private string aliasTypeCdeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string aliasName {
            get {
                return this.aliasNameField;
            }
            set {
                this.aliasNameField = value;
                this.RaisePropertyChanged("aliasName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string aliasTypeCde {
            get {
                return this.aliasTypeCdeField;
            }
            set {
                this.aliasTypeCdeField = value;
                this.RaisePropertyChanged("aliasTypeCde");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/")]
    public partial class requestFinancialOperationResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int amountField;
        
        private bool amountFieldSpecified;
        
        private string currencyCodeField;
        
        private string merchantOperationIDField;
        
        private string statusCodeField;
        
        private System.DateTime timestampField;
        
        private string tokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
                this.RaisePropertyChanged("amountSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string currencyCode {
            get {
                return this.currencyCodeField;
            }
            set {
                this.currencyCodeField = value;
                this.RaisePropertyChanged("currencyCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string merchantOperationID {
            get {
                return this.merchantOperationIDField;
            }
            set {
                this.merchantOperationIDField = value;
                this.RaisePropertyChanged("merchantOperationID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("statusCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
                this.RaisePropertyChanged("token");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/")]
    public partial class messageProperties : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string channelField;
        
        private string apiVersionField;
        
        private string channelTypeCodeField;
        
        private string networkCodeField;
        
        private string serviceTypeField;
        
        private System.DateTime timestampField;
        
        public messageProperties() {
            this.channelField = "01";
            this.apiVersionField = "1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string channel {
            get {
                return this.channelField;
            }
            set {
                this.channelField = value;
                this.RaisePropertyChanged("channel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string apiVersion {
            get {
                return this.apiVersionField;
            }
            set {
                this.apiVersionField = value;
                this.RaisePropertyChanged("apiVersion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string channelTypeCode {
            get {
                return this.channelTypeCodeField;
            }
            set {
                this.channelTypeCodeField = value;
                this.RaisePropertyChanged("channelTypeCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string networkCode {
            get {
                return this.networkCodeField;
            }
            set {
                this.networkCodeField = value;
                this.RaisePropertyChanged("networkCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string serviceType {
            get {
                return this.serviceTypeField;
            }
            set {
                this.serviceTypeField = value;
                this.RaisePropertyChanged("serviceType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/")]
    public partial class merchant : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string iPAddressField;
        
        private string posIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string iPAddress {
            get {
                return this.iPAddressField;
            }
            set {
                this.iPAddressField = value;
                this.RaisePropertyChanged("iPAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string posId {
            get {
                return this.posIdField;
            }
            set {
                this.posIdField = value;
                this.RaisePropertyChanged("posId");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/")]
    public partial class financialOperation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int amountField;
        
        private string currencyCodeField;
        
        private string operationTypeCodeField;
        
        private string merchantOprIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string currencyCode {
            get {
                return this.currencyCodeField;
            }
            set {
                this.currencyCodeField = value;
                this.RaisePropertyChanged("currencyCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string operationTypeCode {
            get {
                return this.operationTypeCodeField;
            }
            set {
                this.operationTypeCodeField = value;
                this.RaisePropertyChanged("operationTypeCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string merchantOprId {
            get {
                return this.merchantOprIdField;
            }
            set {
                this.merchantOprIdField = value;
                this.RaisePropertyChanged("merchantOprId");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="requestFinancialOperation", WrapperNamespace="http://financial.services.merchant.channelmanagermsp.sibs/", IsWrapped=true)]
    public partial class requestFinancialOperationRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationRequest arg0;
        
        public requestFinancialOperationRequest1() {
        }
        
        public requestFinancialOperationRequest1(PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationRequest arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="requestFinancialOperationResponse", WrapperNamespace="http://financial.services.merchant.channelmanagermsp.sibs/", IsWrapped=true)]
    public partial class requestFinancialOperationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://financial.services.merchant.channelmanagermsp.sibs/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResult @return;
        
        public requestFinancialOperationResponse() {
        }
        
        public requestFinancialOperationResponse(PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResult @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MerchantFinancialOperationWSChannel : PMC.MBWay.Net.API.FinancialOperations.MerchantFinancialOperationWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MerchantFinancialOperationWSClient : System.ServiceModel.ClientBase<PMC.MBWay.Net.API.FinancialOperations.MerchantFinancialOperationWS>, PMC.MBWay.Net.API.FinancialOperations.MerchantFinancialOperationWS {
        
        public MerchantFinancialOperationWSClient() {
        }
        
        public MerchantFinancialOperationWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MerchantFinancialOperationWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MerchantFinancialOperationWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MerchantFinancialOperationWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResponse PMC.MBWay.Net.API.FinancialOperations.MerchantFinancialOperationWS.requestFinancialOperation(PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationRequest1 request) {
            return base.Channel.requestFinancialOperation(request);
        }
        
        public PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResult requestFinancialOperation(PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationRequest arg0) {
            PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationRequest1 inValue = new PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationRequest1();
            inValue.arg0 = arg0;
            PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResponse retVal = ((PMC.MBWay.Net.API.FinancialOperations.MerchantFinancialOperationWS)(this)).requestFinancialOperation(inValue);
            return retVal.@return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.sibsmerchant.com/", ConfigurationName="API.FinancialOperations.FinancialOperationAsyncResult")]
    public interface FinancialOperationAsyncResult {
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.sibsmerchant.com/FinancialOperationAsyncResult/financialOperat" +
            "ionResultRequest", ReplyAction="http://webservices.sibsmerchant.com/FinancialOperationAsyncResult/financialOperat" +
            "ionResultResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PMC.MBWay.Net.API.FinancialOperations.financialOperationResultResponse financialOperationResult(PMC.MBWay.Net.API.FinancialOperations.financialOperationResultRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="financialOperationResult", WrapperNamespace="http://webservices.sibsmerchant.com/", IsWrapped=true)]
    public partial class financialOperationResultRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.sibsmerchant.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResult arg0;
        
        public financialOperationResultRequest() {
        }
        
        public financialOperationResultRequest(PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResult arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="financialOperationResultResponse", WrapperNamespace="http://webservices.sibsmerchant.com/", IsWrapped=true)]
    public partial class financialOperationResultResponse {
        
        public financialOperationResultResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FinancialOperationAsyncResultChannel : PMC.MBWay.Net.API.FinancialOperations.FinancialOperationAsyncResult, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FinancialOperationAsyncResultClient : System.ServiceModel.ClientBase<PMC.MBWay.Net.API.FinancialOperations.FinancialOperationAsyncResult>, PMC.MBWay.Net.API.FinancialOperations.FinancialOperationAsyncResult {
        
        public FinancialOperationAsyncResultClient() {
        }
        
        public FinancialOperationAsyncResultClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FinancialOperationAsyncResultClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinancialOperationAsyncResultClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinancialOperationAsyncResultClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PMC.MBWay.Net.API.FinancialOperations.financialOperationResultResponse PMC.MBWay.Net.API.FinancialOperations.FinancialOperationAsyncResult.financialOperationResult(PMC.MBWay.Net.API.FinancialOperations.financialOperationResultRequest request) {
            return base.Channel.financialOperationResult(request);
        }
        
        public void financialOperationResult(PMC.MBWay.Net.API.FinancialOperations.requestFinancialOperationResult arg0) {
            PMC.MBWay.Net.API.FinancialOperations.financialOperationResultRequest inValue = new PMC.MBWay.Net.API.FinancialOperations.financialOperationResultRequest();
            inValue.arg0 = arg0;
            PMC.MBWay.Net.API.FinancialOperations.financialOperationResultResponse retVal = ((PMC.MBWay.Net.API.FinancialOperations.FinancialOperationAsyncResult)(this)).financialOperationResult(inValue);
        }
    }
}
