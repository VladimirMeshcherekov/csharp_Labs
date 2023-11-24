namespace BillingSystme.Cases
{
    public class Case8
    {
        
        /*
         *  Номер одинаковый
         *  я впринципе не знаю что тут должно было быть, оно звонит, так как правила получения номера ничем не регулируется то и пусть
         * 
         */
        public Case8()
        {
            BaseStation station = new BaseStation();

            Person A = new Person(123, 1, station);
            Person B = new Person(123, 2, station);
            
            A.Terminal.MakeCall(123);
        }
    }
}