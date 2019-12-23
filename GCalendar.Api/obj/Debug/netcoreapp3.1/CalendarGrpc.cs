// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Calendar.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Contracts.Calendar {
  public static partial class Calendar
  {
    static readonly string __ServiceName = "Contracts.Calendar.Calendar";

    static readonly grpc::Marshaller<global::Contracts.Calendar.Event> __Marshaller_Contracts_Calendar_Event = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Contracts.Calendar.Event.Parser.ParseFrom);

    static readonly grpc::Method<global::Contracts.Calendar.Event, global::Contracts.Calendar.Event> __Method_InsertEvent = new grpc::Method<global::Contracts.Calendar.Event, global::Contracts.Calendar.Event>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InsertEvent",
        __Marshaller_Contracts_Calendar_Event,
        __Marshaller_Contracts_Calendar_Event);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Contracts.Calendar.CalendarReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Calendar</summary>
    [grpc::BindServiceMethod(typeof(Calendar), "BindService")]
    public abstract partial class CalendarBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Contracts.Calendar.Event> InsertEvent(global::Contracts.Calendar.Event request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CalendarBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_InsertEvent, serviceImpl.InsertEvent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalendarBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_InsertEvent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Contracts.Calendar.Event, global::Contracts.Calendar.Event>(serviceImpl.InsertEvent));
    }

  }
}
#endregion
