using System;
using Grpc.Net.Client;
using Google.Protobuf.WellKnownTypes;
using GrpcSmallPacketStreaming;
using Grpc.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clientconsole
{
    public class Sample
    {
        //private readonly MaintenanceLogService.MaintenanceLogServiceClient _responseClient;
        //public Sample(MaintenanceLogService.MaintenanceLogServiceClient responseClient)
        //{
        //    _responseClient = responseClient;
        //}

        //public async void Execute()
        //{
        //    LogParam test = new LogParam();
        //    Console.WriteLine("Kindly Enter the Engr. Full Name");
        //    test.EngrFullName = Console.ReadLine();
        //    Console.WriteLine("Kindly Enter true or false to make this readable");
        //    test.IsCompleted = bool.Parse(Console.ReadLine().ToLower());
        //    Console.WriteLine("Kindly Enter an Item Name E.g ... Buoyancy Container or vertical stabilizer hinge");
        //    test.Item = Console.ReadLine();
        //    /*var responseClient = new MaintenanceLogService.MaintenanceLogServiceClient(GrpcChannel.ForAddress("https://localhost:5001"));*/  ///server address
        //    await _responseClient.CreateLogAsync(test);
        //    Console.WriteLine("Try another........Press 1 to continue, 2 to retrieve stream and 0 exit");
        //    var choice = Console.ReadLine();
        //    if (choice == "1")
        //    {
        //        Execute();//recursive
        //    };
        //    if (choice == "2")
        //    {
        //        ExecuteStream();
        //    };
        //    if (choice == "0")
        //    {
        //        Environment.Exit(0);
        //    }
        //    Console.WriteLine("Kindly select 1, 2 or 3");
        //}
        //public async void ExecuteStream()
        //{
        //    Empty empty = new Empty();
        //    var reply1 = await _responseClient.RetrieveLogsAsync(empty);
        //    foreach (var stream in reply1.Logs)
        //    {
        //        Console.WriteLine((stream.Id == 1) ? "StartRequest..........this request for" + stream.Id + "  " + stream.EngrFullName + "\n"
        //            + "............Date" + "  " + stream.Date + "\n"
        //            + "............Engr Id." + "  " + stream.Id + "\n"
        //            + "............Item Id" + "  " + stream.ItemId + "\n"
        //            + "............Status" + "  " + stream.Status + "\n"
        //            :
        //              "chunk.................. Engr. Full Name" + stream.Id + " " + stream.EngrFullName + "\n"
        //            + "chunk.................. Date" + "  " + stream.Date + "\n"
        //            + "chunk..................Engr Id" + "  " + stream.Id + "\n"
        //            + "chunk..................Item Id" + "  " + stream.ItemId + "\n"
        //            + "chunk..................Status" + "  " + stream.Status + "\n");
        //    }
        //    Console.WriteLine(reply1.Status + ".................................................");
        //    Console.WriteLine("next you can create your own custom Engr. Log data............. wanna try? Press 1 to continue, 2 to retrieve stream and 0 exit");

        //    var choice = Console.ReadLine();
        //    if (choice == "1")
        //    {
        //        Execute();
        //    };
        //    if (choice == "2")
        //    {
        //        ExecuteStream();
        //    };
        //    if (choice == "0")
        //    {
        //        Environment.Exit(0);
        //    }
        //    Console.WriteLine("Kindly select 1, 2 or 3");
        //}
    }
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Kindly wait 1 second for server to load in tandem with client and then follow the prompt where necessary..................");
            Empty empty = new Empty();
            var _responseClient = new MaintenanceLogService.MaintenanceLogServiceClient(GrpcChannel.ForAddress("https://localhost:5001"));
            var reply1 = await _responseClient.RetrieveLogsAsync(empty);
            foreach (var stream in reply1.Logs)
            {
                Console.WriteLine((stream.Id == 1) ? "StartRequest..........this request for" + stream.Id + "  " + stream.EngrFullName + "\n"
                    + "StartRequest............Date" + "  " + stream.Date + "\n"
                    + "StartRequest............Engr Id." + "  " + stream.Id + "\n"
                    + "StartRequest............Item Id" + "  " + stream.ItemId + "\n"
                    + "StartRequest............Status" + "  " + reply1.Status + "\n"
                    :
                      "chunk.................. Engr. Full Name" + stream.Id + " " + stream.EngrFullName + "\n"
                    + "chunk.................. Date" + "  " + stream.Date + "\n"
                    + "chunk..................Engr Id" + "  " + stream.Id + "\n"
                    + "chunk..................Item Id" + "  " + stream.ItemId + "\n"
                    + "chunk..................Status" + "  " + reply1.Status + "\n");
            }
            Console.WriteLine("..................................................................................................................................");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("next you can create your own custom Engr. Log data............. wanna try? Press 1 to continue and 0 exit");
            var choice = Console.ReadLine();
            if (choice == "1")
            {
                LogParam test = new LogParam();
                Console.WriteLine("Kindly Enter the Engr. Full Name");
                test.EngrFullName = Console.ReadLine();
                Console.WriteLine("Kindly Enter true or false to make this readable");
                test.IsCompleted = bool.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("Kindly Enter an Item Name E.g ... Buoyancy Container or vertical stabilizer hinge");
                test.Item = Console.ReadLine();
                var reply = await _responseClient.CreateLogAsync(test);
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine(
                   "chunk.................. Engr. Full Name" + reply.Id + " " + reply.EngrFullName + "\n"
                   + "chunk.................. Date" + "  " + reply.Date + "\n"
                   + "chunk..................Engr Id" + "  " + reply.Id + "\n"
                   + "chunk..................Item Id" + "  " + reply.ItemId + "\n"
                   + "chunk..................Status" + "  " + reply.Status + "\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("Press 0 exit.......................................");
                var choice1 = Console.ReadLine();
                if (choice1 == "0")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("Kindly select 1, 2 or 3");
            };
            if (choice == "0")
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Kindly select 1, 2 or 3");
        }
    }
}

