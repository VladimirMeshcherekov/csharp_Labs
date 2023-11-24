using System;

namespace BillingSystme
{
    public class Port
    {
        public readonly int ID;
        private readonly StateMachine _portStateMachine = new StateMachine();
        public event Action<ITerminal> MakeCall; 
        public ITerminal ConnectedTerminal { get; private set; }

        private DisconnectedPort _disconnectedPortState = new DisconnectedPort();
        private ConnectedPort _connectedPortState = new ConnectedPort();
        private CallingPort _callingPortState = new CallingPort();
        
        
        public Port(int id)
        {
            this.ID = id;
            _portStateMachine.Initialize(_disconnectedPortState);
            ConnectedTerminal = null;
        }

        public void ConnectToTerminal(ITerminal terminal)
        {
            ConnectedTerminal = terminal;
            _portStateMachine.ChangeState(_connectedPortState);
        }


        public void DisconnectToTerminal()
        {
            ConnectedTerminal = null;
            _portStateMachine.ChangeState(_disconnectedPortState);
            
        }
        public void ConnectFrom(ITerminal terminal)
        {
            MakeCall?.Invoke(terminal);
            _portStateMachine.ChangeState(_callingPortState);
            
            /*
             * Кнока сброса звонка появилась в 1876
             * Люди до 1876: 
             */
            
            _portStateMachine.ChangeState(_connectedPortState);
        }
    }
}