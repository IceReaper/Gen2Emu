using Gen2Emu.Components;
using Gen2Emu.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddSingleton<BlazeService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
	app.UseHsts();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapControllers();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
