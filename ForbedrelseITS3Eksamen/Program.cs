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
            Console.WriteLine("[1]    Fastpris elforbrug");
            Console.WriteLine("[2]    Flekpris elforbrug");
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
                    case '1':
                        Console.WriteLine("Fast El pris");
                        controller.SetPrice("FixedPrice payment");
                        break;
                    case '2':
                        Console.WriteLine("Flex El pris");
                        controller.SetPrice("FlexiblePrice payment");
                        break;
                    case 's':
                    case 'S':
                        Console.WriteLine("---Stopping---");
                        controller.Stopprint();
                        break;
                    case 'x':
                    case 'X':
                        controller.Stop();
                        cont = false;
                        break;
                }
            }
        }
    }
}