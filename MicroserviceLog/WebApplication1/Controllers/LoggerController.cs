using System.Security.Authentication;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GrpcService1.Protos;
using WebApplication1.GrpcService;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoggerController : ControllerBase
	{
		private readonly ServerSideGrpcService _discountService;
		private readonly ServerSideProtoService.ServerSideProtoServiceClient _serverSideClient;
		public LoggerController(ServerSideGrpcService discountService, ServerSideProtoService.ServerSideProtoServiceClient serverSideClient)
		{
			_serverSideClient = serverSideClient;
			_discountService = discountService;
		}
		[HttpGet("all-logs")]
		public async Task<IActionResult> GetAllLogs()
		{
			try
			{


				//var grpcChannel = GrpcChannel.ForAddress("http://localhost:5022");
				//var serverSideClient = new ServerSideProtoService.ServerSideProtoServiceClient(grpcChannel);
			
				//var getAllRequest = new GetAllRequest();
				var getAllResponse = await _discountService.GetAllLogs();
				var loggerModels = getAllResponse;

				// Return the loggerModels as JSON or in any other appropriate format
				return Ok(loggerModels);
			}
			catch (RpcException ex)
			{
				// Handle any gRPC-related exceptions here
				return StatusCode((int)ex.StatusCode, ex.Status.Detail);
			}
		}
	}
}
