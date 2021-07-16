using System;
namespace AWSGameLiftServerTest
{
    class Program
    {
        static private GameServer server = new GameServer(); 
        static void Main(string[] args)
        {
            server.Start();
        }
    }
}
