// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/MaintenanceLog.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcSmallPacketStreaming {
  /// <summary>
  /////MiantenanceLogs for an Aircraft Company.
  /// </summary>
  public static partial class MaintenanceLogService
  {
    static readonly string __ServiceName = "Aircraftlog.MaintenanceLogService";

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
    static readonly grpc::Marshaller<global::GrpcSmallPacketStreaming.LogParam> __Marshaller_Aircraftlog_LogParam = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcSmallPacketStreaming.LogParam.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcSmallPacketStreaming.LogParams> __Marshaller_Aircraftlog_LogParams = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcSmallPacketStreaming.LogParams.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcSmallPacketStreaming.LogParam, global::GrpcSmallPacketStreaming.LogParam> __Method_CreateLog = new grpc::Method<global::GrpcSmallPacketStreaming.LogParam, global::GrpcSmallPacketStreaming.LogParam>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateLog",
        __Marshaller_Aircraftlog_LogParam,
        __Marshaller_Aircraftlog_LogParam);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcSmallPacketStreaming.LogParams> __Method_RetrieveLogs = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcSmallPacketStreaming.LogParams>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RetrieveLogs",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Aircraftlog_LogParams);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcSmallPacketStreaming.MaintenanceLogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MaintenanceLogService</summary>
    [grpc::BindServiceMethod(typeof(MaintenanceLogService), "BindService")]
    public abstract partial class MaintenanceLogServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcSmallPacketStreaming.LogParam> CreateLog(global::GrpcSmallPacketStreaming.LogParam request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcSmallPacketStreaming.LogParams> RetrieveLogs(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(MaintenanceLogServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateLog, serviceImpl.CreateLog)
          .AddMethod(__Method_RetrieveLogs, serviceImpl.RetrieveLogs).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MaintenanceLogServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateLog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcSmallPacketStreaming.LogParam, global::GrpcSmallPacketStreaming.LogParam>(serviceImpl.CreateLog));
      serviceBinder.AddMethod(__Method_RetrieveLogs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcSmallPacketStreaming.LogParams>(serviceImpl.RetrieveLogs));
    }

  }
}
#endregion
