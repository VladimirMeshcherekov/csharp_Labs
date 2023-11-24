namespace BillingSystme.Cases
{
    public class Case2
    {
        /*
         * попытка позвонить на несуществующий номер
         *
         * Ничего не происходит, как и ожидалось
         * 
         */
        
        public Case2()
        {
            BaseStation station = new BaseStation();

            Person A = new Person(123, 1, station);
            Person B = new Person(321, 2, station);
            
            A.Terminal.MakeCall(416574653);
        }
    }
}