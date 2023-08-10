using AutoMapper;
using Grpc.Core;
using Microsoft.AspNetCore.Identity;
using ServerSide.Grpc.Models;
using ServerSide.Grpc.Protos;

namespace ServerSide.Grpc.Services
{
	public class ServerSideService : ServerSideProtoService.ServerSideProtoServiceBase
	{
		#region constructor
		private readonly ILogger<ServerSideService> _logger;
		private LoggerDbContext _loggerDb;
		private readonly IMapper _mapper;
		public ServerSideService(ILogger<ServerSideService> logger, IMapper mapper, LoggerDbContext loggerDb)
		{
			_mapper = mapper;
			_logger = logger;
			_loggerDb = loggerDb;
		}
		#endregion

		#region get serverside
		//public override async Task<LoggerModel> GetLog(GetLogRequest request, ServerCallContext context)
		//{
		//	var logger = request.Id;
		//	if (_logger.IsEnabled(LogLevel.Debug))
		//		throw new RpcException(new Status(StatusCode.NotFound, $"ServerSide with id {request.Id} is Not Found"));
		//	_logger.LogInformation("ServerSide is Retrived for Id");
		//	return logger;
		//}
		public override async Task<LoggerModel> CreatetLog(CreateLogRequest request, ServerCallContext context)
		{
			var getLogger = _mapper.Map<LogMessageReciver>(request.Logger);
			_logger.LogInformation($"ServerSide is Successfully create for server tic tac");
			var getLoggerModel = _mapper.Map<LoggerModel>(getLogger);
			return getLoggerModel;
		}



		public override async Task<GetAllResponse> GetAll(GetAllRequest request, ServerCallContext context)
		{
			// Here, you should implement the logic to retrieve a list of LoggerModel instances.
			// This could involve fetching data from a database or any other data source.

			List<LogMessageReciver> allLogs = new List<LogMessageReciver>();


			var response = new GetAllResponse();
			response.Loggers.AddRange(_mapper.Map<IEnumerable<LoggerModel>>(allLogs));
			return response;
		}

		#endregion
	}
}
