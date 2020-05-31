using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AlanKayIsGenuis
{
    public class TeaBuyer
    {
        private readonly Channel<string> channel;

        public TeaBuyer(Channel<string> channel) =>
            this.channel = channel;

        public async ValueTask BuyTeaAsync() =>
            await this.channel.Writer.WriteAsync("Tea Bought!");
    }
}
