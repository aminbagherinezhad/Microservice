// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ServerSide.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServerSide.Grpc.Protos {
  public static partial class ServerSideProtoService
  {
    static readonly string __ServiceName = "ServerSideProtoService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerSide.Grpc.Protos.GetDiscountRequest> __Marshaller_GetDiscountRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerSide.Grpc.Protos.GetDiscountRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerSide.Grpc.Protos.LoggerModel> __Marshaller_LoggerModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerSide.Grpc.Protos.LoggerModel.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerSide.Grpc.Protos.CreateLogRequest> __Marshaller_CreateLogRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerSide.Grpc.Protos.CreateLogRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerSide.Grpc.Protos.GetAllRequest> __Marshaller_GetAllRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerSide.Grpc.Protos.GetAllRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ServerSide.Grpc.Protos.GetAllResponse> __Marshaller_GetAllResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServerSide.Grpc.Protos.GetAllResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerSide.Grpc.Protos.GetDiscountRequest, global::ServerSide.Grpc.Protos.LoggerModel> __Method_GetDiscount = new grpc::Method<global::ServerSide.Grpc.Protos.GetDiscountRequest, global::ServerSide.Grpc.Protos.LoggerModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDiscount",
        __Marshaller_GetDiscountRequest,
        __Marshaller_LoggerModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerSide.Grpc.Protos.CreateLogRequest, global::ServerSide.Grpc.Protos.LoggerModel> __Method_CreatetLog = new grpc::Method<global::ServerSide.Grpc.Protos.CreateLogRequest, global::ServerSide.Grpc.Protos.LoggerModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreatetLog",
        __Marshaller_CreateLogRequest,
        __Marshaller_LoggerModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ServerSide.Grpc.Protos.GetAllRequest, global::ServerSide.Grpc.Protos.GetAllResponse> __Method_GetAll = new grpc::Method<global::ServerSide.Grpc.Protos.GetAllRequest, global::ServerSide.Grpc.Protos.GetAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_GetAllRequest,
        __Marshaller_GetAllResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServerSide.Grpc.Protos.ServerSideReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServerSideProtoService</summary>
    [grpc::BindServiceMethod(typeof(ServerSideProtoService), "BindService")]
    public abstract partial class ServerSideProtoServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ServerSide.Grpc.Protos.LoggerModel> GetDiscount(global::ServerSide.Grpc.Protos.GetDiscountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ServerSide.Grpc.Protos.LoggerModel> CreatetLog(global::ServerSide.Grpc.Protos.CreateLogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ServerSide.Grpc.Protos.GetAllResponse> GetAll(global::ServerSide.Grpc.Protos.GetAllRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ServerSideProtoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetDiscount, serviceImpl.GetDiscount)
          .AddMethod(__Method_CreatetLog, serviceImpl.CreatetLog)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServerSideProtoServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetDiscount, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerSide.Grpc.Protos.GetDiscountRequest, global::ServerSide.Grpc.Protos.LoggerModel>(serviceImpl.GetDiscount));
      serviceBinder.AddMethod(__Method_CreatetLog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerSide.Grpc.Protos.CreateLogRequest, global::ServerSide.Grpc.Protos.LoggerModel>(serviceImpl.CreatetLog));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerSide.Grpc.Protos.GetAllRequest, global::ServerSide.Grpc.Protos.GetAllResponse>(serviceImpl.GetAll));
    }

  }
}
#endregion
