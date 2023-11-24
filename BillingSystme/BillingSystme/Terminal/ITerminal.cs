namespace BillingSystme
{
    public interface ITerminal
    {
        int PhoneNumber { get; }
    
        void SetConnectedPort(Port connectedPort);
        void ConnectToStation(BaseStation station, int port);
        void DisconnectFromStation();
        void MakeCall(int number);
        void AcceptCall(ITerminal caller);
    }
}