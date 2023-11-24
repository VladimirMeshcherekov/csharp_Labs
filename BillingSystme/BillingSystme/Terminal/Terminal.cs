using System;
using System.Collections.Generic;
using System.Linq;

namespace BillingSystme
{
    public class Terminal : ITerminal
    {
        public int PhoneNumber { get; set; }
        private BaseStation _currentStation;
        private StateMachine _terminalState = new StateMachine();
        private Disconnected _disconnectedState = new Disconnected();
        private DisconnectedPort _disconnectedPortState = new DisconnectedPort();
        private ConnectedPort _connectedPortState = new ConnectedPort();
        private Port _connectedPort;
        
        public Terminal()
        {
            _terminalState.Initialize(_disconnectedState);
        }
        public void SetConnectedPort(Port connectedPort)
        {
            _connectedPort = connectedPort;
            _connectedPort.MakeCall += AcceptCall;
        }

        public void ConnectToStation(BaseStation station, int port)
        {
            _currentStation = station;
            station.TryToConnect(port, this);
            _terminalState.ChangeState(_connectedPortState);
        }
        
        public void DisconnectFromStation()
        {
            _currentStation.TryToDisconnect(this);
            _terminalState.ChangeState(_disconnectedState);
            _currentStation = null;
        }

        public void MakeCall(int number)
        {
            _currentStation?.TryToCall(number, this);
        }

        public void AcceptCall(ITerminal caller)
        {
            Console.WriteLine("ring ring from " + caller.PhoneNumber);
        }
    }
}