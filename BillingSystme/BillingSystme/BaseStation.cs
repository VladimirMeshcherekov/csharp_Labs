using System;
using System.Collections.Generic;
using System.Linq;

namespace BillingSystme
{
    public class BaseStation
    {
        public List<Port> NPorts = new List<Port>();

        public BaseStation()
        {
            for (int i = 0; i < 10; i++)
            {
                NPorts.Add(new Port(i));
            }
        }


        public bool TryToDisconnect(ITerminal terminal)
        {
            for (int i = 0; i < NPorts.Count; i++)
            {
                if (NPorts[i].ConnectedTerminal == null)
                {
                    continue;
                }

                if (NPorts[i].ConnectedTerminal == terminal)
                {
                    NPorts[i].DisconnectToTerminal();
                    return true;
                }
            }

            return false;
        }
        
        public bool TryToConnect(int portID, ITerminal terminal)
        {
            if (NPorts.Where(port => port.ID == portID).ToList().Where(port => port.ConnectedTerminal == null).ToList().Count != 0)
            {
                NPorts.Where(port => port.ID == portID).ToList()[0].ConnectToTerminal(terminal);
                terminal.SetConnectedPort(NPorts.Where(port => port.ID == portID).ToList()[0]);
                return true;
            }

            throw new Exception("port already in use");
            return false;
        }


        public bool TryToCall(int number, ITerminal caller)
        {
            for (int i = 0; i < NPorts.Count; i++)
            {
                if (NPorts[i].ConnectedTerminal == null)
                {
                    continue;
                }

                if (NPorts[i].ConnectedTerminal.PhoneNumber == number)
                {
                    NPorts[i].ConnectFrom(caller);
                    return true;
                }
            }

            return false;
        }
    }
}