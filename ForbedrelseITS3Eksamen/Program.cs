using ForbedrelseITS3EksamenLibrary;

namespace ForbedrelseITS3Eksamen
{
    public class Program
    {

        static void Main(string[] args)
        {
            SystemMenuController controller = new SystemMenuController();
            controller.Start();

            var cont = true;
            Console.WriteLine("Control menu:");
            Console.WriteLine("-------------");
            Console.WriteLine("[B]    Start print");
            Console.WriteLine("[S]    Stop print");
            Console.WriteLine("[X]    Quit");

            while (cont)
            {
                var key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'b':
                    case 'B':
                        Console.WriteLine("---Starting---");
                        controller.Startprint();
                        break;
                    case 's':
                    case 'S':
                        Console.WriteLine("---Stopping---");
                        controller.Stopprint();
                        break;
                }
            }
        }
    }
}