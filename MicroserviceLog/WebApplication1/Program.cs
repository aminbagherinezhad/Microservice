using GrpcService1.Protos;
using WebApplication1.GrpcService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;
builder.Services.AddGrpcClient<ServerSideProtoService.ServerSideProtoServiceClient>
	(options =>
	{
		options.Address = new Uri(configuration["GrpcSettings:DiscountUrl"]);
	});

builder.Services.AddScoped<ServerSideGrpcService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
