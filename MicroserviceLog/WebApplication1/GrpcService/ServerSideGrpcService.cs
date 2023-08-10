using System.Net;
using Grpc.Net.Client;
using GrpcService1.Protos;

namespace WebApplication1.GrpcService
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
			try
			{
			
				var getAllRequest = new GetAllRequest();
				var getAllResponse = await _discountProtoService.GetAllAsync(getAllRequest);
				return getAllResponse.Loggers.ToList();
			}
			catch (Exception ex)
			{

				throw;
			}

		}

		#endregion
	}
}
