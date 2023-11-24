namespace BillingSystme.Cases
{
    public class Case4
    {
        
        /*
         *  Дорогу осилит идущий...
         *
         *  Но если он отключится, то его терминал ничего не осилит
         */
        public Case4()
        {
            BaseStation station = new BaseStation();

            Person A = new Person(123, 1, station);
            Person B = new Person(321, 2, station);
            
            A.Terminal.DisconnectFromStation();
            A.Terminal.MakeCall(321);
        }
    }
}