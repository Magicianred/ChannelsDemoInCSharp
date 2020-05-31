using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AlanKayIsGenuis
{
    public class WaterBoiler
    {
        private readonly Channel<string> channel;

        public WaterBoiler(Channel<string> channel) =>
            this.channel = channel;

        public async ValueTask BoilWaterAsync() =>
            await this.channel.Writer.WriteAsync("Water Boiled!");
    }
}
