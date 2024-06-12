using MassTransit;
using MassTransit.Configuration;
using MassTransit.Transports;
using Project1.Models;
using Project1.RabitMQ.Consumer;
using Project1.RabitMQ.Sender;
using static MassTransit.Logging.OperationName;

namespace Project1
{
    public static class Extension
    {
        public static IServiceCollection AddRabitMQA(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddMassTransit(config =>
            {
                config.SetKebabCaseEndpointNameFormatter();
                config.AddConsumer<ConsumeBus>();

                config.UsingRabbitMq((context, configurator) =>
                {
                    configurator.Host(configuration["MessageBroker:Host"], host =>
                    {
                        host.Username(configuration["MessageBroker:UserName"]);
                        host.Password(configuration["MessageBroker:Password"]);
                    });

                    configurator.ConfigureEndpoints(context);

                });
            });
            services.AddTransient<IEventBus, EventBus>();
            return services;
        }

    }
}
