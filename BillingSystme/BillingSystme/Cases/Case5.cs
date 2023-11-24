namespace BillingSystme.Cases
{
    /*
     *  Абонент в какой-то момент просто умер
     *
     *  топ 10 предательств 
     * 
     */
    
    public class Case5
    {
        public Case5()
        {
            BaseStation station = new BaseStation();

            Person A = new Person(123, 1, station);
            Person B = new Person(321, 2, station);
            
            A.Terminal.MakeCall(321);
            B.Terminal.DisconnectFromStation();
            A.Terminal.MakeCall(321);
        }
    }
}