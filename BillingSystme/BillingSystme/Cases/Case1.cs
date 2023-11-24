namespace BillingSystme.Cases
{
    public class Case1
    {
        /*
         *  Логичный и единственно верный сценарий использования
         */
        
        public Case1()
        {
            BaseStation station = new BaseStation();

            Person asukaLangleySohryu = new Person(123, 1, station);
            Person reiAyanami = new Person(321, 2, station);
            asukaLangleySohryu.Terminal.MakeCall(321);
        }
    }
}