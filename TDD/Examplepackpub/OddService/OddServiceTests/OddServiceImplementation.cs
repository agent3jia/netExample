namespace OddServiceTests
{
    public class OddServiceImplementation
    {
        public OddServiceImplementation()
        {
        }

        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}