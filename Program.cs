namespace TrabalhoArquiteturaDIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var lamp = new Lamp();
            var lightSwitch = new Switch();

            lightSwitch.SetDevice(lamp);

            Console.WriteLine("Pressione Enter para alternar a lâmpada.");

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                    lightSwitch.Press();
            }
        }
    }
}
