using MassTransit;
using MassTransit.Transports;
using Project1.Models;

namespace Project1.RabitMQ.Sender
{
    public class EventBus : IEventBus
    {
        private IPublishEndpoint _endpoint;
        public EventBus(IPublishEndpoint endpoint)
        {
            _endpoint = endpoint;
        }
        public async Task PublicAsync<T>(T message, CancellationToken cancellationToken = default) where T : class
        {
            //await _endpoint.Publish(message, cancellationToken);
            await _endpoint.Publish(message, cancellationToken);

        }

    }


}
