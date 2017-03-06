﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace RPiQMR.QMRServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class Room : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int RoomIDField;
        
        private string RoomNameField;
        
        private bool OccupiedField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int RoomID {
            get {
                return this.RoomIDField;
            }
            set {
                if ((this.RoomIDField.Equals(value) != true)) {
                    this.RoomIDField = value;
                    this.RaisePropertyChanged("RoomID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string RoomName {
            get {
                return this.RoomNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomNameField, value) != true)) {
                    this.RoomNameField = value;
                    this.RaisePropertyChanged("RoomName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public bool Occupied {
            get {
                return this.OccupiedField;
            }
            set {
                if ((this.OccupiedField.Equals(value) != true)) {
                    this.OccupiedField = value;
                    this.RaisePropertyChanged("Occupied");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://qmr.guttman.cuny.edu/", ConfigurationName="QMRServiceReference.qmrserviceSoap")]
    public interface qmrserviceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://qmr.guttman.cuny.edu/GetRoomByRoomID", ReplyAction="*")]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetRoomByRoomIDResponse> GetRoomByRoomIDAsync(RPiQMR.QMRServiceReference.GetRoomByRoomIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://qmr.guttman.cuny.edu/GetRoomBySensorID", ReplyAction="*")]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetRoomBySensorIDResponse> GetRoomBySensorIDAsync(RPiQMR.QMRServiceReference.GetRoomBySensorIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://qmr.guttman.cuny.edu/GetListRooms", ReplyAction="*")]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetListRoomsResponse> GetListRoomsAsync(RPiQMR.QMRServiceReference.GetListRoomsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://qmr.guttman.cuny.edu/AddRoom", ReplyAction="*")]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.AddRoomResponse> AddRoomAsync(RPiQMR.QMRServiceReference.AddRoomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://qmr.guttman.cuny.edu/AddSensor", ReplyAction="*")]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.AddSensorResponse> AddSensorAsync(RPiQMR.QMRServiceReference.AddSensorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://qmr.guttman.cuny.edu/ReserveRoom", ReplyAction="*")]
        System.Threading.Tasks.Task ReserveRoomAsync(int roomID, bool occupied);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://qmr.guttman.cuny.edu/ReserveRoomBySensor", ReplyAction="*")]
        System.Threading.Tasks.Task ReserveRoomBySensorAsync(int sensorID, int roomID, bool occupied);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://qmr.guttman.cuny.edu/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.LoginResponse> LoginAsync(RPiQMR.QMRServiceReference.LoginRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRoomByRoomIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRoomByRoomID", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.GetRoomByRoomIDRequestBody Body;
        
        public GetRoomByRoomIDRequest() {
        }
        
        public GetRoomByRoomIDRequest(RPiQMR.QMRServiceReference.GetRoomByRoomIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class GetRoomByRoomIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int value;
        
        public GetRoomByRoomIDRequestBody() {
        }
        
        public GetRoomByRoomIDRequestBody(int value) {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRoomByRoomIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRoomByRoomIDResponse", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.GetRoomByRoomIDResponseBody Body;
        
        public GetRoomByRoomIDResponse() {
        }
        
        public GetRoomByRoomIDResponse(RPiQMR.QMRServiceReference.GetRoomByRoomIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class GetRoomByRoomIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public RPiQMR.QMRServiceReference.Room GetRoomByRoomIDResult;
        
        public GetRoomByRoomIDResponseBody() {
        }
        
        public GetRoomByRoomIDResponseBody(RPiQMR.QMRServiceReference.Room GetRoomByRoomIDResult) {
            this.GetRoomByRoomIDResult = GetRoomByRoomIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRoomBySensorIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRoomBySensorID", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.GetRoomBySensorIDRequestBody Body;
        
        public GetRoomBySensorIDRequest() {
        }
        
        public GetRoomBySensorIDRequest(RPiQMR.QMRServiceReference.GetRoomBySensorIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class GetRoomBySensorIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int value;
        
        public GetRoomBySensorIDRequestBody() {
        }
        
        public GetRoomBySensorIDRequestBody(int value) {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRoomBySensorIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRoomBySensorIDResponse", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.GetRoomBySensorIDResponseBody Body;
        
        public GetRoomBySensorIDResponse() {
        }
        
        public GetRoomBySensorIDResponse(RPiQMR.QMRServiceReference.GetRoomBySensorIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class GetRoomBySensorIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public RPiQMR.QMRServiceReference.Room GetRoomBySensorIDResult;
        
        public GetRoomBySensorIDResponseBody() {
        }
        
        public GetRoomBySensorIDResponseBody(RPiQMR.QMRServiceReference.Room GetRoomBySensorIDResult) {
            this.GetRoomBySensorIDResult = GetRoomBySensorIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListRoomsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListRooms", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.GetListRoomsRequestBody Body;
        
        public GetListRoomsRequest() {
        }
        
        public GetListRoomsRequest(RPiQMR.QMRServiceReference.GetListRoomsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetListRoomsRequestBody {
        
        public GetListRoomsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListRoomsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListRoomsResponse", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.GetListRoomsResponseBody Body;
        
        public GetListRoomsResponse() {
        }
        
        public GetListRoomsResponse(RPiQMR.QMRServiceReference.GetListRoomsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class GetListRoomsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<RPiQMR.QMRServiceReference.Room> GetListRoomsResult;
        
        public GetListRoomsResponseBody() {
        }
        
        public GetListRoomsResponseBody(System.Collections.ObjectModel.ObservableCollection<RPiQMR.QMRServiceReference.Room> GetListRoomsResult) {
            this.GetListRoomsResult = GetListRoomsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRoomRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddRoom", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.AddRoomRequestBody Body;
        
        public AddRoomRequest() {
        }
        
        public AddRoomRequest(RPiQMR.QMRServiceReference.AddRoomRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class AddRoomRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string roomName;
        
        public AddRoomRequestBody() {
        }
        
        public AddRoomRequestBody(string roomName) {
            this.roomName = roomName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRoomResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddRoomResponse", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.AddRoomResponseBody Body;
        
        public AddRoomResponse() {
        }
        
        public AddRoomResponse(RPiQMR.QMRServiceReference.AddRoomResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddRoomResponseBody {
        
        public AddRoomResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSensorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSensor", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.AddSensorRequestBody Body;
        
        public AddSensorRequest() {
        }
        
        public AddSensorRequest(RPiQMR.QMRServiceReference.AddSensorRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class AddSensorRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int roomID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ipaddr;
        
        public AddSensorRequestBody() {
        }
        
        public AddSensorRequestBody(int roomID, string ipaddr) {
            this.roomID = roomID;
            this.ipaddr = ipaddr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSensorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSensorResponse", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.AddSensorResponseBody Body;
        
        public AddSensorResponse() {
        }
        
        public AddSensorResponse(RPiQMR.QMRServiceReference.AddSensorResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddSensorResponseBody {
        
        public AddSensorResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(RPiQMR.QMRServiceReference.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="https://qmr.guttman.cuny.edu/", Order=0)]
        public RPiQMR.QMRServiceReference.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(RPiQMR.QMRServiceReference.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://qmr.guttman.cuny.edu/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(string LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface qmrserviceSoapChannel : RPiQMR.QMRServiceReference.qmrserviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class qmrserviceSoapClient : System.ServiceModel.ClientBase<RPiQMR.QMRServiceReference.qmrserviceSoap>, RPiQMR.QMRServiceReference.qmrserviceSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public qmrserviceSoapClient() : 
                base(qmrserviceSoapClient.GetDefaultBinding(), qmrserviceSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.qmrserviceSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public qmrserviceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(qmrserviceSoapClient.GetBindingForEndpoint(endpointConfiguration), qmrserviceSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public qmrserviceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(qmrserviceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public qmrserviceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(qmrserviceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public qmrserviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetRoomByRoomIDResponse> RPiQMR.QMRServiceReference.qmrserviceSoap.GetRoomByRoomIDAsync(RPiQMR.QMRServiceReference.GetRoomByRoomIDRequest request) {
            return base.Channel.GetRoomByRoomIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetRoomByRoomIDResponse> GetRoomByRoomIDAsync(int value) {
            RPiQMR.QMRServiceReference.GetRoomByRoomIDRequest inValue = new RPiQMR.QMRServiceReference.GetRoomByRoomIDRequest();
            inValue.Body = new RPiQMR.QMRServiceReference.GetRoomByRoomIDRequestBody();
            inValue.Body.value = value;
            return ((RPiQMR.QMRServiceReference.qmrserviceSoap)(this)).GetRoomByRoomIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetRoomBySensorIDResponse> RPiQMR.QMRServiceReference.qmrserviceSoap.GetRoomBySensorIDAsync(RPiQMR.QMRServiceReference.GetRoomBySensorIDRequest request) {
            return base.Channel.GetRoomBySensorIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetRoomBySensorIDResponse> GetRoomBySensorIDAsync(int value) {
            RPiQMR.QMRServiceReference.GetRoomBySensorIDRequest inValue = new RPiQMR.QMRServiceReference.GetRoomBySensorIDRequest();
            inValue.Body = new RPiQMR.QMRServiceReference.GetRoomBySensorIDRequestBody();
            inValue.Body.value = value;
            return ((RPiQMR.QMRServiceReference.qmrserviceSoap)(this)).GetRoomBySensorIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetListRoomsResponse> RPiQMR.QMRServiceReference.qmrserviceSoap.GetListRoomsAsync(RPiQMR.QMRServiceReference.GetListRoomsRequest request) {
            return base.Channel.GetListRoomsAsync(request);
        }
        
        public System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.GetListRoomsResponse> GetListRoomsAsync() {
            RPiQMR.QMRServiceReference.GetListRoomsRequest inValue = new RPiQMR.QMRServiceReference.GetListRoomsRequest();
            inValue.Body = new RPiQMR.QMRServiceReference.GetListRoomsRequestBody();
            return ((RPiQMR.QMRServiceReference.qmrserviceSoap)(this)).GetListRoomsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.AddRoomResponse> RPiQMR.QMRServiceReference.qmrserviceSoap.AddRoomAsync(RPiQMR.QMRServiceReference.AddRoomRequest request) {
            return base.Channel.AddRoomAsync(request);
        }
        
        public System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.AddRoomResponse> AddRoomAsync(string roomName) {
            RPiQMR.QMRServiceReference.AddRoomRequest inValue = new RPiQMR.QMRServiceReference.AddRoomRequest();
            inValue.Body = new RPiQMR.QMRServiceReference.AddRoomRequestBody();
            inValue.Body.roomName = roomName;
            return ((RPiQMR.QMRServiceReference.qmrserviceSoap)(this)).AddRoomAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.AddSensorResponse> RPiQMR.QMRServiceReference.qmrserviceSoap.AddSensorAsync(RPiQMR.QMRServiceReference.AddSensorRequest request) {
            return base.Channel.AddSensorAsync(request);
        }
        
        public System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.AddSensorResponse> AddSensorAsync(int roomID, string ipaddr) {
            RPiQMR.QMRServiceReference.AddSensorRequest inValue = new RPiQMR.QMRServiceReference.AddSensorRequest();
            inValue.Body = new RPiQMR.QMRServiceReference.AddSensorRequestBody();
            inValue.Body.roomID = roomID;
            inValue.Body.ipaddr = ipaddr;
            return ((RPiQMR.QMRServiceReference.qmrserviceSoap)(this)).AddSensorAsync(inValue);
        }
        
        public System.Threading.Tasks.Task ReserveRoomAsync(int roomID, bool occupied) {
            return base.Channel.ReserveRoomAsync(roomID, occupied);
        }
        
        public System.Threading.Tasks.Task ReserveRoomBySensorAsync(int sensorID, int roomID, bool occupied) {
            return base.Channel.ReserveRoomBySensorAsync(sensorID, roomID, occupied);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.LoginResponse> RPiQMR.QMRServiceReference.qmrserviceSoap.LoginAsync(RPiQMR.QMRServiceReference.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<RPiQMR.QMRServiceReference.LoginResponse> LoginAsync(string username, string password) {
            RPiQMR.QMRServiceReference.LoginRequest inValue = new RPiQMR.QMRServiceReference.LoginRequest();
            inValue.Body = new RPiQMR.QMRServiceReference.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((RPiQMR.QMRServiceReference.qmrserviceSoap)(this)).LoginAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.qmrserviceSoap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.qmrserviceSoap)) {
                return new System.ServiceModel.EndpointAddress("https://qmr.guttman.cuny.edu/qmr/qmrservice.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return qmrserviceSoapClient.GetBindingForEndpoint(EndpointConfiguration.qmrserviceSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return qmrserviceSoapClient.GetEndpointAddress(EndpointConfiguration.qmrserviceSoap);
        }
        
        public enum EndpointConfiguration {
            
            qmrserviceSoap,
        }
    }
}