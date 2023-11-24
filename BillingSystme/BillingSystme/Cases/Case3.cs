namespace BillingSystme.Cases
{
    public class Case3
    {
        /*
         * Абонент не абонент, попытка позвонить тому кто отключился от станции
         *
         * это же буквально матук и я
         */
        
        public Case3()
        {
            BaseStation station = new BaseStation();

            Person A = new Person(123, 1, station);
            Person B = new Person(321, 2, station);
            
            B.Terminal.DisconnectFromStation();
            
            A.Terminal.MakeCall(321);
        }
    }
}