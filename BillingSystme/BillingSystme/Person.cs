namespace BillingSystme
{
    public class Person
    {
        public readonly Terminal Terminal;

        public Person(int phoneNum, int portToConnect, BaseStation station)
        {
            Terminal = new Terminal
            {
                PhoneNumber = phoneNum
            };
            Terminal.ConnectToStation(station, portToConnect);
        }
        
    }
}