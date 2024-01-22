using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Gen2Emu.Api;

[ApiController]
[Route("config.cncg2")]
public class ConfigController : ControllerBase
{
	// TODO we should listen for any configs and return the correct one
	[HttpGet]
	[Route("cncprod150805.cfg")]
	public IActionResult GetExample()
	{
		var config = new Dictionary<string, string>
		{
			["WebBaseUrl"] = "http://localhost",
			["DebugShell"] = "True", // Makes the client ask for an ui wrapper. Useful for ui development! :)
			["UseBlaze"] = "True" // Required, or the client wont start
		};

		return File(
			Encoding.UTF8.GetPreamble()
				.Concat(Encoding.UTF8.GetBytes(string.Join(string.Empty, config.Select(static e => $"-RtsClientSettings.{e.Key} {e.Value}\r\n"))))
				.ToArray(),
			"text/plain"
		);
	}
}
