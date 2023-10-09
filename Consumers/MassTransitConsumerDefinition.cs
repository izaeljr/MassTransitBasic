namespace Company.Consumers
{
    using MassTransit;

    public class MassTransitConsumerDefinition :
        ConsumerDefinition<MassTransitConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<MassTransitConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}