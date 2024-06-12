using MassTransit;
using Project1.Models;

namespace Project1.RabitMQ.Consumer
{
    public class ConsumeBus : IConsumer<UpdateCustomerAddress>
    {
        public Task Consume(ConsumeContext<UpdateCustomerAddress> consume)
        {
            var ss = consume.Message;
            return Task.CompletedTask;
        }
    }
}
