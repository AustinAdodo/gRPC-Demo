using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace DotNETgRPCServiceInteractionDemo.Services
{
    public class loggingservice : MaintenanceLogService.MaintenanceLogServiceBase
    {
        private readonly ILogger<loggingservice> _logger;
        public loggingservice(ILogger<loggingservice> logger)
        {
            _logger = logger;
        }

        public override Task<LogParam> CreateLog(LogParam initlog, ServerCallContext context)
        {
            return Task.FromResult(new LogParam
            {
                EngrFullName = initlog.EngrFullName,
                Date = initlog.Date,
                IsCompleted = true,
                Id = initlog.Id,
                Item = initlog.Item,
                ItemId = initlog.ItemId,
                Status = "Successfully sent to server "
            }) ;
        }

        public override Task<LogParams> RetrieveLogs(Empty request,ServerCallContext context)
        {
            return Task.FromResult(new LogParams
            { 
                Status = "Successfully retrieved from server ",
            });
        }
    }
}
