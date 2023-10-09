namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class MassTransitConsumer :
        IConsumer<MassTransit>
    {
        readonly ILogger<MassTransitConsumer> _logger;

        public MassTransitConsumer(ILogger<MassTransitConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<MassTransit> context)
        {
            _logger.LogInformation("Hello {Name}", context.Message.Name);
            return Task.CompletedTask;
        }
    }
}