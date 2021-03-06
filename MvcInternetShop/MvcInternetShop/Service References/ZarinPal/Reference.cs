//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcInternetShop.ZarinPal {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://zarinpal.com/", ConfigurationName="ZarinPal.PaymentGatewayImplementationServicePortType")]
    public interface PaymentGatewayImplementationServicePortType {
        
        // CODEGEN: Generating message contract since element name MerchantID from namespace http://zarinpal.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="#PaymentRequest", ReplyAction="*")]
        MvcInternetShop.ZarinPal.PaymentRequestResponse PaymentRequest(MvcInternetShop.ZarinPal.PaymentRequestRequest request);
        
        // CODEGEN: Generating message contract since element name MerchantID from namespace http://zarinpal.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="#PaymentRequestWithExtra", ReplyAction="*")]
        MvcInternetShop.ZarinPal.PaymentRequestWithExtraResponse PaymentRequestWithExtra(MvcInternetShop.ZarinPal.PaymentRequestWithExtraRequest request);
        
        // CODEGEN: Generating message contract since element name MerchantID from namespace http://zarinpal.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="#PaymentVerification", ReplyAction="*")]
        MvcInternetShop.ZarinPal.PaymentVerificationResponse PaymentVerification(MvcInternetShop.ZarinPal.PaymentVerificationRequest request);
        
        // CODEGEN: Generating message contract since element name MerchantID from namespace http://zarinpal.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="#PaymentVerificationWithExtra", ReplyAction="*")]
        MvcInternetShop.ZarinPal.PaymentVerificationWithExtraResponse PaymentVerificationWithExtra(MvcInternetShop.ZarinPal.PaymentVerificationWithExtraRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentRequest", Namespace="http://zarinpal.com/", Order=0)]
        public MvcInternetShop.ZarinPal.PaymentRequestRequestBody Body;
        
        public PaymentRequestRequest() {
        }
        
        public PaymentRequestRequest(MvcInternetShop.ZarinPal.PaymentRequestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentRequestRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Description;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Mobile;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string CallbackURL;
        
        public PaymentRequestRequestBody() {
        }
        
        public PaymentRequestRequestBody(string MerchantID, int Amount, string Description, string Email, string Mobile, string CallbackURL) {
            this.MerchantID = MerchantID;
            this.Amount = Amount;
            this.Description = Description;
            this.Email = Email;
            this.Mobile = Mobile;
            this.CallbackURL = CallbackURL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentRequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentRequestResponse", Namespace="http://zarinpal.com/", Order=0)]
        public MvcInternetShop.ZarinPal.PaymentRequestResponseBody Body;
        
        public PaymentRequestResponse() {
        }
        
        public PaymentRequestResponse(MvcInternetShop.ZarinPal.PaymentRequestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentRequestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        public PaymentRequestResponseBody() {
        }
        
        public PaymentRequestResponseBody(int Status, string Authority) {
            this.Status = Status;
            this.Authority = Authority;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentRequestWithExtraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentRequestWithExtra", Namespace="http://zarinpal.com/", Order=0)]
        public MvcInternetShop.ZarinPal.PaymentRequestWithExtraRequestBody Body;
        
        public PaymentRequestWithExtraRequest() {
        }
        
        public PaymentRequestWithExtraRequest(MvcInternetShop.ZarinPal.PaymentRequestWithExtraRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentRequestWithExtraRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Description;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string AdditionalData;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Mobile;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string CallbackURL;
        
        public PaymentRequestWithExtraRequestBody() {
        }
        
        public PaymentRequestWithExtraRequestBody(string MerchantID, int Amount, string Description, string AdditionalData, string Email, string Mobile, string CallbackURL) {
            this.MerchantID = MerchantID;
            this.Amount = Amount;
            this.Description = Description;
            this.AdditionalData = AdditionalData;
            this.Email = Email;
            this.Mobile = Mobile;
            this.CallbackURL = CallbackURL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentRequestWithExtraResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentRequestWithExtraResponse", Namespace="http://zarinpal.com/", Order=0)]
        public MvcInternetShop.ZarinPal.PaymentRequestWithExtraResponseBody Body;
        
        public PaymentRequestWithExtraResponse() {
        }
        
        public PaymentRequestWithExtraResponse(MvcInternetShop.ZarinPal.PaymentRequestWithExtraResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentRequestWithExtraResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        public PaymentRequestWithExtraResponseBody() {
        }
        
        public PaymentRequestWithExtraResponseBody(int Status, string Authority) {
            this.Status = Status;
            this.Authority = Authority;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentVerificationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentVerification", Namespace="http://zarinpal.com/", Order=0)]
        public MvcInternetShop.ZarinPal.PaymentVerificationRequestBody Body;
        
        public PaymentVerificationRequest() {
        }
        
        public PaymentVerificationRequest(MvcInternetShop.ZarinPal.PaymentVerificationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentVerificationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Amount;
        
        public PaymentVerificationRequestBody() {
        }
        
        public PaymentVerificationRequestBody(string MerchantID, string Authority, int Amount) {
            this.MerchantID = MerchantID;
            this.Authority = Authority;
            this.Amount = Amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentVerificationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentVerificationResponse", Namespace="http://zarinpal.com/", Order=0)]
        public MvcInternetShop.ZarinPal.PaymentVerificationResponseBody Body;
        
        public PaymentVerificationResponse() {
        }
        
        public PaymentVerificationResponse(MvcInternetShop.ZarinPal.PaymentVerificationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentVerificationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public long RefID;
        
        public PaymentVerificationResponseBody() {
        }
        
        public PaymentVerificationResponseBody(int Status, long RefID) {
            this.Status = Status;
            this.RefID = RefID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentVerificationWithExtraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentVerificationWithExtra", Namespace="http://zarinpal.com/", Order=0)]
        public MvcInternetShop.ZarinPal.PaymentVerificationWithExtraRequestBody Body;
        
        public PaymentVerificationWithExtraRequest() {
        }
        
        public PaymentVerificationWithExtraRequest(MvcInternetShop.ZarinPal.PaymentVerificationWithExtraRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentVerificationWithExtraRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MerchantID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Authority;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Amount;
        
        public PaymentVerificationWithExtraRequestBody() {
        }
        
        public PaymentVerificationWithExtraRequestBody(string MerchantID, string Authority, int Amount) {
            this.MerchantID = MerchantID;
            this.Authority = Authority;
            this.Amount = Amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentVerificationWithExtraResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PaymentVerificationWithExtraResponse", Namespace="http://zarinpal.com/", Order=0)]
        public MvcInternetShop.ZarinPal.PaymentVerificationWithExtraResponseBody Body;
        
        public PaymentVerificationWithExtraResponse() {
        }
        
        public PaymentVerificationWithExtraResponse(MvcInternetShop.ZarinPal.PaymentVerificationWithExtraResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://zarinpal.com/")]
    public partial class PaymentVerificationWithExtraResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public long RefID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ExtraDetail;
        
        public PaymentVerificationWithExtraResponseBody() {
        }
        
        public PaymentVerificationWithExtraResponseBody(int Status, long RefID, string ExtraDetail) {
            this.Status = Status;
            this.RefID = RefID;
            this.ExtraDetail = ExtraDetail;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PaymentGatewayImplementationServicePortTypeChannel : MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentGatewayImplementationServicePortTypeClient : System.ServiceModel.ClientBase<MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType>, MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType {
        
        public PaymentGatewayImplementationServicePortTypeClient() {
        }
        
        public PaymentGatewayImplementationServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentGatewayImplementationServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentGatewayImplementationServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentGatewayImplementationServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MvcInternetShop.ZarinPal.PaymentRequestResponse MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType.PaymentRequest(MvcInternetShop.ZarinPal.PaymentRequestRequest request) {
            return base.Channel.PaymentRequest(request);
        }
        
        public int PaymentRequest(string MerchantID, int Amount, string Description, string Email, string Mobile, string CallbackURL, out string Authority) {
            MvcInternetShop.ZarinPal.PaymentRequestRequest inValue = new MvcInternetShop.ZarinPal.PaymentRequestRequest();
            inValue.Body = new MvcInternetShop.ZarinPal.PaymentRequestRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Amount = Amount;
            inValue.Body.Description = Description;
            inValue.Body.Email = Email;
            inValue.Body.Mobile = Mobile;
            inValue.Body.CallbackURL = CallbackURL;
            MvcInternetShop.ZarinPal.PaymentRequestResponse retVal = ((MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType)(this)).PaymentRequest(inValue);
            Authority = retVal.Body.Authority;
            return retVal.Body.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MvcInternetShop.ZarinPal.PaymentRequestWithExtraResponse MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType.PaymentRequestWithExtra(MvcInternetShop.ZarinPal.PaymentRequestWithExtraRequest request) {
            return base.Channel.PaymentRequestWithExtra(request);
        }
        
        public int PaymentRequestWithExtra(string MerchantID, int Amount, string Description, string AdditionalData, string Email, string Mobile, string CallbackURL, out string Authority) {
            MvcInternetShop.ZarinPal.PaymentRequestWithExtraRequest inValue = new MvcInternetShop.ZarinPal.PaymentRequestWithExtraRequest();
            inValue.Body = new MvcInternetShop.ZarinPal.PaymentRequestWithExtraRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Amount = Amount;
            inValue.Body.Description = Description;
            inValue.Body.AdditionalData = AdditionalData;
            inValue.Body.Email = Email;
            inValue.Body.Mobile = Mobile;
            inValue.Body.CallbackURL = CallbackURL;
            MvcInternetShop.ZarinPal.PaymentRequestWithExtraResponse retVal = ((MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType)(this)).PaymentRequestWithExtra(inValue);
            Authority = retVal.Body.Authority;
            return retVal.Body.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MvcInternetShop.ZarinPal.PaymentVerificationResponse MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType.PaymentVerification(MvcInternetShop.ZarinPal.PaymentVerificationRequest request) {
            return base.Channel.PaymentVerification(request);
        }
        
        public int PaymentVerification(string MerchantID, string Authority, int Amount, out long RefID) {
            MvcInternetShop.ZarinPal.PaymentVerificationRequest inValue = new MvcInternetShop.ZarinPal.PaymentVerificationRequest();
            inValue.Body = new MvcInternetShop.ZarinPal.PaymentVerificationRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Authority = Authority;
            inValue.Body.Amount = Amount;
            MvcInternetShop.ZarinPal.PaymentVerificationResponse retVal = ((MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType)(this)).PaymentVerification(inValue);
            RefID = retVal.Body.RefID;
            return retVal.Body.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MvcInternetShop.ZarinPal.PaymentVerificationWithExtraResponse MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType.PaymentVerificationWithExtra(MvcInternetShop.ZarinPal.PaymentVerificationWithExtraRequest request) {
            return base.Channel.PaymentVerificationWithExtra(request);
        }
        
        public int PaymentVerificationWithExtra(string MerchantID, string Authority, int Amount, out long RefID, out string ExtraDetail) {
            MvcInternetShop.ZarinPal.PaymentVerificationWithExtraRequest inValue = new MvcInternetShop.ZarinPal.PaymentVerificationWithExtraRequest();
            inValue.Body = new MvcInternetShop.ZarinPal.PaymentVerificationWithExtraRequestBody();
            inValue.Body.MerchantID = MerchantID;
            inValue.Body.Authority = Authority;
            inValue.Body.Amount = Amount;
            MvcInternetShop.ZarinPal.PaymentVerificationWithExtraResponse retVal = ((MvcInternetShop.ZarinPal.PaymentGatewayImplementationServicePortType)(this)).PaymentVerificationWithExtra(inValue);
            RefID = retVal.Body.RefID;
            ExtraDetail = retVal.Body.ExtraDetail;
            return retVal.Body.Status;
        }
    }
}
