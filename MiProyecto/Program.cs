using MiProyecto;

Console.ForegroundColor = ConsoleColor.Green;

try
{
	Console.WriteLine(new Date(2400, 2, 29));
	Console.WriteLine(new Date(1974, 09, 23));
	Console.WriteLine(new Date(1985, 11, 30));

}
catch (Exception error)
{
	Console.WriteLine(error.Message);
	//throw;
}