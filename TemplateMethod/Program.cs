using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough(); 
            sourdough.Make();
            TwelveGrain welveGrain = new TwelveGrain();
            welveGrain.Make();
            WholeWheat wholeWheat = new WholeWheat(); 
            wholeWheat.Make(); 
            Console.ReadKey();
        }
    }
}
