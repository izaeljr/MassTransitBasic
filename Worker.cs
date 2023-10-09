using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace MassTransit
public class Worker : BackgroundService
{
	readonly IBus _bus;

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		while (!stoppingToken.IsCancellationRequested)
		{
			await _bus.Publish(new HelloMessage
			{
				Name = "World"
			}, stoppingToken);

			await Task.Delay(1000, stoppingToken);
		}
	}
}
