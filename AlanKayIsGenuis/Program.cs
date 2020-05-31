using System;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AlanKayIsGenuis
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Channel<string> channel = Channel.CreateUnbounded<string>();
            var waterBoiler = new WaterBoiler(channel);
            await waterBoiler.BoilWaterAsync();

            var teaBuyer = new CompletelyNewTeaBuyer(channel);
            await teaBuyer.BuySomething("Tea Bought!");

            var teaMaker = new TeaMaker(channel);
            await teaMaker.MakeTeaAsync();
        }
    }
}
