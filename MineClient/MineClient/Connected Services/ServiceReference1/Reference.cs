﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MineClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
    [System.SerializableAttribute()]
    public partial class UserFaultException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMineService", CallbackContract=typeof(MineClient.ServiceReference1.IMineServiceCallback))]
    public interface IMineService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/ClientConnected", ReplyAction="http://tempuri.org/IMineService/ClientConnectedResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/ClientConnectedUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void ClientConnected(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/ClientConnected", ReplyAction="http://tempuri.org/IMineService/ClientConnectedResponse")]
        System.Threading.Tasks.Task ClientConnectedAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/ClientDisconnected", ReplyAction="http://tempuri.org/IMineService/ClientDisconnectedResponse")]
        void ClientDisconnected(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/ClientDisconnected", ReplyAction="http://tempuri.org/IMineService/ClientDisconnectedResponse")]
        System.Threading.Tasks.Task ClientDisconnectedAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/Register", ReplyAction="http://tempuri.org/IMineService/RegisterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/RegisterUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void Register(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/Register", ReplyAction="http://tempuri.org/IMineService/RegisterResponse")]
        System.Threading.Tasks.Task RegisterAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/RefreshClientListFromUser", ReplyAction="http://tempuri.org/IMineService/RefreshClientListFromUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/RefreshClientListFromUserUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void RefreshClientListFromUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/RefreshClientListFromUser", ReplyAction="http://tempuri.org/IMineService/RefreshClientListFromUserResponse")]
        System.Threading.Tasks.Task RefreshClientListFromUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/PlayerAvailible", ReplyAction="http://tempuri.org/IMineService/PlayerAvailibleResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/PlayerAvailibleUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        bool PlayerAvailible(string player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/PlayerAvailible", ReplyAction="http://tempuri.org/IMineService/PlayerAvailibleResponse")]
        System.Threading.Tasks.Task<bool> PlayerAvailibleAsync(string player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/GameRequest", ReplyAction="http://tempuri.org/IMineService/GameRequestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/GameRequestUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void GameRequest(string fromClient, string toClient, string gameType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/GameRequest", ReplyAction="http://tempuri.org/IMineService/GameRequestResponse")]
        System.Threading.Tasks.Task GameRequestAsync(string fromClient, string toClient, string gameType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/DeleteClient", ReplyAction="http://tempuri.org/IMineService/DeleteClientResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/DeleteClientUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void DeleteClient(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/DeleteClient", ReplyAction="http://tempuri.org/IMineService/DeleteClientResponse")]
        System.Threading.Tasks.Task DeleteClientAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/PlayerTurn", ReplyAction="http://tempuri.org/IMineService/PlayerTurnResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/PlayerTurnUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        bool PlayerTurn(int row, int col, string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/PlayerTurn", ReplyAction="http://tempuri.org/IMineService/PlayerTurnResponse")]
        System.Threading.Tasks.Task<bool> PlayerTurnAsync(int row, int col, string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/ChangeClientPassword", ReplyAction="http://tempuri.org/IMineService/ChangeClientPasswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/ChangeClientPasswordUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void ChangeClientPassword(string userName, string oldPassword, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/ChangeClientPassword", ReplyAction="http://tempuri.org/IMineService/ChangeClientPasswordResponse")]
        System.Threading.Tasks.Task ChangeClientPasswordAsync(string userName, string oldPassword, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/StartGame")]
        void StartGame(string Player1, string Player2, string gameType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/StartGame")]
        System.Threading.Tasks.Task StartGameAsync(string Player1, string Player2, string gameType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/GetPlayerStatistics", ReplyAction="http://tempuri.org/IMineService/GetPlayerStatisticsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/GetPlayerStatisticsUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MineClient.ServiceReference1.UserFaultException))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<int, int[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(int[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        object[] GetPlayerStatistics(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/GetPlayerStatistics", ReplyAction="http://tempuri.org/IMineService/GetPlayerStatisticsResponse")]
        System.Threading.Tasks.Task<object[]> GetPlayerStatisticsAsync(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/ClientExist", ReplyAction="http://tempuri.org/IMineService/ClientExistResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/ClientExistUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        bool ClientExist(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/ClientExist", ReplyAction="http://tempuri.org/IMineService/ClientExistResponse")]
        System.Threading.Tasks.Task<bool> ClientExistAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/SendMessage")]
        void SendMessage(string message, string fromClient, string toClient);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(string message, string fromClient, string toClient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/GenerateMines", ReplyAction="http://tempuri.org/IMineService/GenerateMinesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/GenerateMinesUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        System.Collections.Generic.Dictionary<int, int[]> GenerateMines(int minesAmmount, int RowsNum, bool regenerate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/GenerateMines", ReplyAction="http://tempuri.org/IMineService/GenerateMinesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, int[]>> GenerateMinesAsync(int minesAmmount, int RowsNum, bool regenerate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/SendMineLocation", ReplyAction="http://tempuri.org/IMineService/SendMineLocationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/SendMineLocationUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void SendMineLocation(System.Collections.Generic.Dictionary<int, int[]> mineLocation, int safePlaceAmount, string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/SendMineLocation", ReplyAction="http://tempuri.org/IMineService/SendMineLocationResponse")]
        System.Threading.Tasks.Task SendMineLocationAsync(System.Collections.Generic.Dictionary<int, int[]> mineLocation, int safePlaceAmount, string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/SendMoveToOpponent", ReplyAction="http://tempuri.org/IMineService/SendMoveToOpponentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/SendMoveToOpponentUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void SendMoveToOpponent(string opponent, int row, int col);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/SendMoveToOpponent", ReplyAction="http://tempuri.org/IMineService/SendMoveToOpponentResponse")]
        System.Threading.Tasks.Task SendMoveToOpponentAsync(string opponent, int row, int col);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/PlayerFinishedPlaying", ReplyAction="http://tempuri.org/IMineService/PlayerFinishedPlayingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/PlayerFinishedPlayingUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        void PlayerFinishedPlaying(string playerName, string opponent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/PlayerFinishedPlaying", ReplyAction="http://tempuri.org/IMineService/PlayerFinishedPlayingResponse")]
        System.Threading.Tasks.Task PlayerFinishedPlayingAsync(string playerName, string opponent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/GetGameStatistics", ReplyAction="http://tempuri.org/IMineService/GetGameStatisticsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineClient.ServiceReference1.UserFaultException), Action="http://tempuri.org/IMineService/GetGameStatisticsUserFaultExceptionFault", Name="UserFaultException", Namespace="http://schemas.datacontract.org/2004/07/WcfMineServer")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MineClient.ServiceReference1.UserFaultException))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<int, int[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(int[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        object[] GetGameStatistics(string getFactor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineService/GetGameStatistics", ReplyAction="http://tempuri.org/IMineService/GetGameStatisticsResponse")]
        System.Threading.Tasks.Task<object[]> GetGameStatisticsAsync(string getFactor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMineServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/UpdateClientsList")]
        void UpdateClientsList(string[] users);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/SendGameRequest")]
        void SendGameRequest(string toClient, string fromClient, string gameType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/SendMessageToClient")]
        void SendMessageToClient(string message, string fromClient);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/GameFinished")]
        void GameFinished(string winner, string looser);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/GameExit")]
        void GameExit(string opponent);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/GameInit")]
        void GameInit(string player1, string player2, string gameType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineService/SendMove")]
        void SendMove(int row, int col);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMineServiceChannel : MineClient.ServiceReference1.IMineService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MineServiceClient : System.ServiceModel.DuplexClientBase<MineClient.ServiceReference1.IMineService>, MineClient.ServiceReference1.IMineService {
        
        public MineServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MineServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MineServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MineServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MineServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void ClientConnected(string username, string password) {
            base.Channel.ClientConnected(username, password);
        }
        
        public System.Threading.Tasks.Task ClientConnectedAsync(string username, string password) {
            return base.Channel.ClientConnectedAsync(username, password);
        }
        
        public void ClientDisconnected(string username) {
            base.Channel.ClientDisconnected(username);
        }
        
        public System.Threading.Tasks.Task ClientDisconnectedAsync(string username) {
            return base.Channel.ClientDisconnectedAsync(username);
        }
        
        public void Register(string userName, string password) {
            base.Channel.Register(userName, password);
        }
        
        public System.Threading.Tasks.Task RegisterAsync(string userName, string password) {
            return base.Channel.RegisterAsync(userName, password);
        }
        
        public void RefreshClientListFromUser() {
            base.Channel.RefreshClientListFromUser();
        }
        
        public System.Threading.Tasks.Task RefreshClientListFromUserAsync() {
            return base.Channel.RefreshClientListFromUserAsync();
        }
        
        public bool PlayerAvailible(string player) {
            return base.Channel.PlayerAvailible(player);
        }
        
        public System.Threading.Tasks.Task<bool> PlayerAvailibleAsync(string player) {
            return base.Channel.PlayerAvailibleAsync(player);
        }
        
        public void GameRequest(string fromClient, string toClient, string gameType) {
            base.Channel.GameRequest(fromClient, toClient, gameType);
        }
        
        public System.Threading.Tasks.Task GameRequestAsync(string fromClient, string toClient, string gameType) {
            return base.Channel.GameRequestAsync(fromClient, toClient, gameType);
        }
        
        public void DeleteClient(string userName, string password) {
            base.Channel.DeleteClient(userName, password);
        }
        
        public System.Threading.Tasks.Task DeleteClientAsync(string userName, string password) {
            return base.Channel.DeleteClientAsync(userName, password);
        }
        
        public bool PlayerTurn(int row, int col, string playerName) {
            return base.Channel.PlayerTurn(row, col, playerName);
        }
        
        public System.Threading.Tasks.Task<bool> PlayerTurnAsync(int row, int col, string playerName) {
            return base.Channel.PlayerTurnAsync(row, col, playerName);
        }
        
        public void ChangeClientPassword(string userName, string oldPassword, string newPassword) {
            base.Channel.ChangeClientPassword(userName, oldPassword, newPassword);
        }
        
        public System.Threading.Tasks.Task ChangeClientPasswordAsync(string userName, string oldPassword, string newPassword) {
            return base.Channel.ChangeClientPasswordAsync(userName, oldPassword, newPassword);
        }
        
        public void StartGame(string Player1, string Player2, string gameType) {
            base.Channel.StartGame(Player1, Player2, gameType);
        }
        
        public System.Threading.Tasks.Task StartGameAsync(string Player1, string Player2, string gameType) {
            return base.Channel.StartGameAsync(Player1, Player2, gameType);
        }
        
        public object[] GetPlayerStatistics(string playerName) {
            return base.Channel.GetPlayerStatistics(playerName);
        }
        
        public System.Threading.Tasks.Task<object[]> GetPlayerStatisticsAsync(string playerName) {
            return base.Channel.GetPlayerStatisticsAsync(playerName);
        }
        
        public bool ClientExist(string username, string password) {
            return base.Channel.ClientExist(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> ClientExistAsync(string username, string password) {
            return base.Channel.ClientExistAsync(username, password);
        }
        
        public void SendMessage(string message, string fromClient, string toClient) {
            base.Channel.SendMessage(message, fromClient, toClient);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string message, string fromClient, string toClient) {
            return base.Channel.SendMessageAsync(message, fromClient, toClient);
        }
        
        public System.Collections.Generic.Dictionary<int, int[]> GenerateMines(int minesAmmount, int RowsNum, bool regenerate) {
            return base.Channel.GenerateMines(minesAmmount, RowsNum, regenerate);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, int[]>> GenerateMinesAsync(int minesAmmount, int RowsNum, bool regenerate) {
            return base.Channel.GenerateMinesAsync(minesAmmount, RowsNum, regenerate);
        }
        
        public void SendMineLocation(System.Collections.Generic.Dictionary<int, int[]> mineLocation, int safePlaceAmount, string playerName) {
            base.Channel.SendMineLocation(mineLocation, safePlaceAmount, playerName);
        }
        
        public System.Threading.Tasks.Task SendMineLocationAsync(System.Collections.Generic.Dictionary<int, int[]> mineLocation, int safePlaceAmount, string playerName) {
            return base.Channel.SendMineLocationAsync(mineLocation, safePlaceAmount, playerName);
        }
        
        public void SendMoveToOpponent(string opponent, int row, int col) {
            base.Channel.SendMoveToOpponent(opponent, row, col);
        }
        
        public System.Threading.Tasks.Task SendMoveToOpponentAsync(string opponent, int row, int col) {
            return base.Channel.SendMoveToOpponentAsync(opponent, row, col);
        }
        
        public void PlayerFinishedPlaying(string playerName, string opponent) {
            base.Channel.PlayerFinishedPlaying(playerName, opponent);
        }
        
        public System.Threading.Tasks.Task PlayerFinishedPlayingAsync(string playerName, string opponent) {
            return base.Channel.PlayerFinishedPlayingAsync(playerName, opponent);
        }
        
        public object[] GetGameStatistics(string getFactor) {
            return base.Channel.GetGameStatistics(getFactor);
        }
        
        public System.Threading.Tasks.Task<object[]> GetGameStatisticsAsync(string getFactor) {
            return base.Channel.GetGameStatisticsAsync(getFactor);
        }
    }
}