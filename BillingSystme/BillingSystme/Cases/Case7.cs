namespace BillingSystme.Cases
{
    /*
     *ребята порт не поделили, так быть, добавлю хоть одно исключение
     * (обработки его не будет)
     * 
     */
    public class Case7
    {
        public Case7()
        {
            BaseStation station = new BaseStation();

            Person A = new Person(123, 1, station);
            Person B = new Person(321, 1, station);
            
            A.Terminal.MakeCall(321);
        }
    }
}