using System;
using GameServer;

namespace LudoServer
{
    class MainClass
    {
        private static GServer GServer;

        public static void Main(String[] args)
        {
            int ListeningPort;
            if (args.Length > 0 && ProgramHelperFunctions.GetPort(args[0], out ListeningPort))
            {
                GServer = new GServer(ListeningPort);
                GServer.Start();
            }
            else
            {
                Console.WriteLine("Server port expected as first and only argument (Invalid port or no port supplied).");
            }
        }
    }
}
