using System;
using ConsoleClient;
using Newtonsoft.Json;

namespace Messenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message(userName: "Antis", messageText: "Hi", timeStamp: DateTime.Now);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message desOutput = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(desOutput);
            // { "UserName":"Antis","MessageText":"Hi","TimeStamp":"2022-07-24T22:11:11.6134272+03:00"}
            // Antis < 24.07.2022 22:11:11 >: Hi
        }
    }
}
