using static SnackGameExample.All;

var app = new SnakeGameApp();
app.Run();
if (System.Diagnostics.Debugger.IsAttached)
{
    Console.WriteLine("\nPress <Enter> to continue...");
    Console.ReadLine();
}
