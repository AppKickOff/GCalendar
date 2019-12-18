// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/calendar.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc {

  /// <summary>Holder for reflection information generated from Protos/calendar.proto</summary>
  public static partial class CalendarReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/calendar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CalendarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvY2FsZW5kYXIucHJvdG8SBEdycGMifwoFRXZlbnQSEgoKY2Fs",
            "ZW5kYXJJZBgBIAEoCRIKCgJJZBgCIAEoCRIaCgVzdGFydBgDIAEoCzILLkdy",
            "cGMuU3RhcnQSFgoDZW5kGAQgASgLMgkuR3JwYy5FbmQSDQoFdGl0bGUYBSAB",
            "KAkSEwoLZGVzY3JpcHRpb24YBiABKAkiKAoFU3RhcnQSDQoFVGlja3MYASAB",
            "KAMSEAoIdGltZVpvbmUYAiABKAkiJgoDRW5kEg0KBVRpY2tzGAEgASgDEhAK",
            "CHRpbWVab25lGAIgASgJMjMKCENhbGVuZGFyEicKC0luc2VydEV2ZW50Egsu",
            "R3JwYy5FdmVudBoLLkdycGMuRXZlbnRCB6oCBEdycGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Event), global::Grpc.Event.Parser, new[]{ "CalendarId", "Id", "Start", "End", "Title", "Description" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Start), global::Grpc.Start.Parser, new[]{ "Ticks", "TimeZone" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.End), global::Grpc.End.Parser, new[]{ "Ticks", "TimeZone" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Event : pb::IMessage<Event> {
    private static readonly pb::MessageParser<Event> _parser = new pb::MessageParser<Event>(() => new Event());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Event> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.CalendarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event(Event other) : this() {
      calendarId_ = other.calendarId_;
      id_ = other.id_;
      start_ = other.start_ != null ? other.start_.Clone() : null;
      end_ = other.end_ != null ? other.end_.Clone() : null;
      title_ = other.title_;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event Clone() {
      return new Event(this);
    }

    /// <summary>Field number for the "calendarId" field.</summary>
    public const int CalendarIdFieldNumber = 1;
    private string calendarId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CalendarId {
      get { return calendarId_; }
      set {
        calendarId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 3;
    private global::Grpc.Start start_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.Start Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 4;
    private global::Grpc.End end_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.End End {
      get { return end_; }
      set {
        end_ = value;
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 5;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 6;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Event);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Event other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CalendarId != other.CalendarId) return false;
      if (Id != other.Id) return false;
      if (!object.Equals(Start, other.Start)) return false;
      if (!object.Equals(End, other.End)) return false;
      if (Title != other.Title) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CalendarId.Length != 0) hash ^= CalendarId.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (start_ != null) hash ^= Start.GetHashCode();
      if (end_ != null) hash ^= End.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CalendarId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CalendarId);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (start_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Start);
      }
      if (end_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(End);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Title);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CalendarId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CalendarId);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (start_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Start);
      }
      if (end_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(End);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Event other) {
      if (other == null) {
        return;
      }
      if (other.CalendarId.Length != 0) {
        CalendarId = other.CalendarId;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.start_ != null) {
        if (start_ == null) {
          Start = new global::Grpc.Start();
        }
        Start.MergeFrom(other.Start);
      }
      if (other.end_ != null) {
        if (end_ == null) {
          End = new global::Grpc.End();
        }
        End.MergeFrom(other.End);
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CalendarId = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (start_ == null) {
              Start = new global::Grpc.Start();
            }
            input.ReadMessage(Start);
            break;
          }
          case 34: {
            if (end_ == null) {
              End = new global::Grpc.End();
            }
            input.ReadMessage(End);
            break;
          }
          case 42: {
            Title = input.ReadString();
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Start : pb::IMessage<Start> {
    private static readonly pb::MessageParser<Start> _parser = new pb::MessageParser<Start>(() => new Start());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Start> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.CalendarReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Start() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Start(Start other) : this() {
      ticks_ = other.ticks_;
      timeZone_ = other.timeZone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Start Clone() {
      return new Start(this);
    }

    /// <summary>Field number for the "Ticks" field.</summary>
    public const int TicksFieldNumber = 1;
    private long ticks_;
    /// <summary>
    /// Number of .1 ms intervals since 00:00:00 01/01/0001
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Ticks {
      get { return ticks_; }
      set {
        ticks_ = value;
      }
    }

    /// <summary>Field number for the "timeZone" field.</summary>
    public const int TimeZoneFieldNumber = 2;
    private string timeZone_ = "";
    /// <summary>
    /// IANA Time Zone
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeZone {
      get { return timeZone_; }
      set {
        timeZone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Start);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Start other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ticks != other.Ticks) return false;
      if (TimeZone != other.TimeZone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ticks != 0L) hash ^= Ticks.GetHashCode();
      if (TimeZone.Length != 0) hash ^= TimeZone.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ticks != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Ticks);
      }
      if (TimeZone.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TimeZone);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ticks != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Ticks);
      }
      if (TimeZone.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeZone);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Start other) {
      if (other == null) {
        return;
      }
      if (other.Ticks != 0L) {
        Ticks = other.Ticks;
      }
      if (other.TimeZone.Length != 0) {
        TimeZone = other.TimeZone;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Ticks = input.ReadInt64();
            break;
          }
          case 18: {
            TimeZone = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class End : pb::IMessage<End> {
    private static readonly pb::MessageParser<End> _parser = new pb::MessageParser<End>(() => new End());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<End> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.CalendarReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public End() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public End(End other) : this() {
      ticks_ = other.ticks_;
      timeZone_ = other.timeZone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public End Clone() {
      return new End(this);
    }

    /// <summary>Field number for the "Ticks" field.</summary>
    public const int TicksFieldNumber = 1;
    private long ticks_;
    /// <summary>
    /// Number of .1 ms intervals since 00:00:00 01/01/0001
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Ticks {
      get { return ticks_; }
      set {
        ticks_ = value;
      }
    }

    /// <summary>Field number for the "timeZone" field.</summary>
    public const int TimeZoneFieldNumber = 2;
    private string timeZone_ = "";
    /// <summary>
    /// IANA Time Zone
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeZone {
      get { return timeZone_; }
      set {
        timeZone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as End);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(End other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ticks != other.Ticks) return false;
      if (TimeZone != other.TimeZone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ticks != 0L) hash ^= Ticks.GetHashCode();
      if (TimeZone.Length != 0) hash ^= TimeZone.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ticks != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Ticks);
      }
      if (TimeZone.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TimeZone);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ticks != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Ticks);
      }
      if (TimeZone.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeZone);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(End other) {
      if (other == null) {
        return;
      }
      if (other.Ticks != 0L) {
        Ticks = other.Ticks;
      }
      if (other.TimeZone.Length != 0) {
        TimeZone = other.TimeZone;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Ticks = input.ReadInt64();
            break;
          }
          case 18: {
            TimeZone = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code