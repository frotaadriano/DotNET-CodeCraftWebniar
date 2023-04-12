namespace CodeCraftMinimal
{
    public class Counter
    {
        private int count;
        private static Counter instance = null;

        private Counter()
        {
            count = 0;
        }

        public static Counter Instance()
        {
            if (instance == null)
            {
                instance = new Counter();
            }
            return instance;
        }

        public void Increment()
        {
            count++;
        }

        public void Decrement()
        {
            count--;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
