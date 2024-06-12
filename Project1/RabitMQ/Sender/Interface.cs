namespace Project1.RabitMQ.Sender
{
    public interface IEventBus
    {
        Task PublicAsync<T>(T message, CancellationToken cancellationToken = default)where T : class;
    }
}
