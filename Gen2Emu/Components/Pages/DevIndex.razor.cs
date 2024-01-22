using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;

namespace Gen2Emu.Components.Pages;

public partial class DevIndex
{
	private string? _page;

	[Inject]
	public required NavigationManager NavManager { get; set; }

	protected override void OnInitialized()
	{
		var uri = NavManager.ToAbsoluteUri(NavManager.Uri);

		if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("page", out var value))
			_page = value.ToString();
	}
}
