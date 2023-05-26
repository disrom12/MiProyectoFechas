using MiProyecto;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bienvenidos a mi programa en GIT");

try
{
	Console.WriteLine(new Date(2400, 2, 29));
	Console.WriteLine(new Date(1974, 09, 23));
	Console.WriteLine(new Date(1985, 11, 30));

}
catch (Exception error)
{
	Console.WriteLine(error.Message);
	
}