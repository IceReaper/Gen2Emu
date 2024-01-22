using System.Text;

// TODO it would be cool if we are able to also patch out the activation process here and not rely on pre-patched executable.
if (args.Length == 0)
{
	Console.WriteLine("Usage: ClientPatcher.exe <path to CnC.exe> [host]");

	return;
}

var url = args.Length > 2 ? args[1] : "localhost";

if (url.Length > 19)
{
	Console.WriteLine("URL may not be longer than 19 characters");

	return;
}

var data = new byte[20];
Array.Copy(Encoding.ASCII.GetBytes(url), data, url.Length);

using var stream = File.Open(args[0], FileMode.Open, FileAccess.ReadWrite);
using var reader = new BinaryReader(stream);
using var writer = new BinaryWriter(stream);

stream.Position = 0x1037a4c;

if (Encoding.ASCII.GetString(reader.ReadBytes(16)) != "Unpacked file : ")
{
	Console.WriteLine("This file is not a valid CnC.exe");

	return;
}

stream.Position -= 36;
writer.Write(data);
