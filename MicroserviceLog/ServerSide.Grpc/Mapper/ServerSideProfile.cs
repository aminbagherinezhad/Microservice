using AutoMapper;
using ServerSide.Grpc.Protos;
using ServerSide.Grpc.Models;

namespace ServerSide.Grpc.Mapper
{
	public class ServerSideProfile : Profile
	{
		public ServerSideProfile()
		{
			CreateMap<LogMessageReciver, LoggerModel>().ReverseMap();
		}
	}
}
