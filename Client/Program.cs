using System;
using Grpc.Net.Client;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System.Collections.Generic;
using DotNETgRPCServiceInteractionDemo;

            var responseClient = new MaintenanceLogService.MaintenanceLogServiceClient(GrpcChannel.ForAddress("http://localhost:5000"));  ///server address
            List<LogParam> Logs = new();
            Logs.Add(new LogParam
            {
                EngrFullName = "Henrich Larsson",
                Date = DateTime.Today.ToString(),
                Id = 2,
                IsCompleted = true,
                Item = "Piston Crank",
                ItemId = 100002
            });
            Logs.Add(new LogParam
            {
                EngrFullName = "Adodo Austin",
                Date = DateTime.Today.ToString(),
                Id = 3,
                IsCompleted = true,
                Item = "Air filter",
                ItemId = 100003
            });
            Logs.Add(new LogParam
            {
                EngrFullName = "Ian Flemming",
                Date = DateTime.Today.ToString(),
                Id = 4,
                IsCompleted = true,
                Item = "Central Bushin Actuator",
                ItemId = 100004
            });
            //create async
            var stream = await responseClient.CreateLogAsync(new LogParam
            {
                EngrFullName = "Mattias Sammer",
                Date = DateTime.Today.ToString(),
                Id = 1,
                IsCompleted = true,
                Item = "HVAC Central Valve",
                ItemId = 100001
            });
            var empty = new Empty();
            Console.WriteLine((stream.Id == 1) ? "StartRequest...." + stream : stream);
            foreach (LogParam log in Logs)
            {
                var stream2 = await responseClient.CreateLogAsync(log);
                Console.WriteLine("Chunk,  Payload......"+ stream2.Id + stream2 + "\n");
            }
