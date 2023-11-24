namespace BillingSystme.Cases
{
    public class Case6
    {
        /*
         *  абонента не сущетвовало
         */
        
        public Case6()
        {
            BaseStation station = new BaseStation();

            Person A = new Person(123, 1, station);
            A.Terminal.MakeCall(321);
        }
    }
}