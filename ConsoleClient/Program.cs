using System;
using ConsoleClient;

namespace Messenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            Console.WriteLine(msg.ToString());
        }
    }
}
