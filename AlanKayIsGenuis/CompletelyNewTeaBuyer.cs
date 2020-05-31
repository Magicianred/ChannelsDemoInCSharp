using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AlanKayIsGenuis
{
    public class CompletelyNewTeaBuyer
    {
        private readonly Channel<string> channel;

        public CompletelyNewTeaBuyer(Channel<string> channel) =>
            this.channel = channel;

        public async ValueTask BuySomething(string something) =>
            await this.channel.Writer.WriteAsync(something);
    }
}
