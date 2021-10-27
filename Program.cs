using System;
using System.Threading;
using System.Threading.Tasks;

namespace BreakfastAsync
{
    class Program
    {
        static void CutMushRooms(int number)
        {
            for(int i = 1; i<=number;i++ )
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Mushroom {i} is cut");
                
            }
            Console.WriteLine("All mushrooms are cut");
        }
        static void FryMushRooms()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Musrooms are fryed");
        }
        static void Frybreradslice(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Slice {i} is fryed");

            }
            Console.WriteLine("All bread are fryed");
        }
        static void FryEggs(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Egg {i} is fryed");

            }
            Console.WriteLine("All eggs are fryed");
        }
        static async void FryEggsAsync(int number)
        {
            await Task.Run(() => FryEggs(number));
        }
        static async void FrybreradsliceAsync(int number)
        {
            await Task.Run(() => Frybreradslice(number));
        }
       

      
        static void Main(string[] args)
        {
            Console.WriteLine("start to cook breakfast ");
            FryEggsAsync(2);
            FrybreradsliceAsync(2);
            CutMushRooms(5);
            FryMushRooms();
                      
            Console.WriteLine("Breakfast is done");
        }
    }
}
