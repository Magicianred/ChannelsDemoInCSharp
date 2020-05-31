using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AlanKayIsGenuis
{
    public class TeaMaker
    {
        private readonly Channel<string> channel;

        public TeaMaker(Channel<string> channel) =>
            this.channel = channel;

        public async ValueTask MakeTeaAsync()
        {
            bool isTeaHere = false;
            bool isWaterhere = false;

            while (await this.channel.Reader.WaitToReadAsync())
            {
                string message = await this.channel.Reader.ReadAsync();

                if (message == "Water Boiled!")
                {
                    isWaterhere = true;
                }
                else if (message == "Tea Bought!")
                {
                    isTeaHere = true;
                }

                if (isWaterhere && isTeaHere)
                {
                    Console.WriteLine("Tea is Made!");
                }
            }
        }
    }
}
