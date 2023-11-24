namespace BillingSystme.Cases
{
    public class Case9
    {
        
        /*
         *  3 забавных чуда
         * 
         */
        public Case9()
        {
            BaseStation station = new BaseStation();

            Person A = new Person(123, 1, station);
            Person B = new Person(456, 2, station);
            Person C = new Person(789, 3, station);
            
            A.Terminal.MakeCall(456);
            A.Terminal.MakeCall(789);
            C.Terminal.MakeCall(123);
        }
    }
}