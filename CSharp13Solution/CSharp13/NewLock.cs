using System.ComponentModel;

namespace CSharp13
{
    public class NewLock
    {
        static Lock objLock = new();
        private static int counter = 0;
        public static int Sum()
        {
            objLock.Enter();
            counter++;
            objLock.Exit();

            return counter;
        }

        public static void Run()
        {
            Parallel.Invoke(() =>
            {
                foreach (int i in Enumerable.Range(1, 10000))
                {
                    Sum();
                }
            },

            () =>
            {
                foreach (int i in Enumerable.Range(1, 10000))
                {
                    Sum();
                }
            });

            Console.WriteLine($"Counter ={counter}");
        }

    }
}
