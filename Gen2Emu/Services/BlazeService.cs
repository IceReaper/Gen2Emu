using System.Net;
using System.Net.Sockets;

namespace Gen2Emu.Services;

public class BlazeService : IDisposable
{
	private bool _disposed;

	public void Start()
	{
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
		Listen(10071);
		Listen(42127); // gosredirector.online.ea.com gosca.ea.com 44125
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
	}

	private async Task Listen(int port)
	{
		var listener = new TcpListener(IPAddress.Any, port);
		listener.Start();

		Console.WriteLine($"Listening on port {port}");

		while (!_disposed)
		{
			var client = await listener.AcceptTcpClientAsync();

			Console.WriteLine($"{client.Client.RemoteEndPoint} =>{client.Client.LocalEndPoint}");
		}
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		_disposed = true;
	}
}
