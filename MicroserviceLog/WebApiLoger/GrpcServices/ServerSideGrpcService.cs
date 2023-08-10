using Grpc.Core;
using ServerSide.Grpc.Protos;

namespace WebApiLoger.GrpcServices
{
	public class ServerSideGrpcService
	{
		#region constructor

		private readonly ServerSideProtoService.ServerSideProtoServiceClient _discountProtoService;

		public ServerSideGrpcService(ServerSideProtoService.ServerSideProtoServiceClient discountProtoService)
		{
			_discountProtoService = discountProtoService;
		}

		#endregion

		#region get discount

		public async Task<List<LoggerModel>> GetAllLogs()
		{
			var getAllRequest = new GetAllRequest();
			var getAllResponse = await _discountProtoService.GetAllAsync(getAllRequest);
			return getAllResponse.Loggers.ToList();
		}

		#endregion
	}
}
