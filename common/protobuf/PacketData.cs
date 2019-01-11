// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: packet_data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Packet {

  /// <summary>Holder for reflection information generated from packet_data.proto</summary>
  public static partial class PacketDataReflection {

    #region Descriptor
    /// <summary>File descriptor for packet_data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PacketDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFwYWNrZXRfZGF0YS5wcm90bxIGcGFja2V0IioKB1ZlY3RvcjMSCQoBeBgB",
            "IAEoAhIJCgF5GAIgASgCEgkKAXoYAyABKAIiTwoIUm9vbVVzZXISEgoKbmV0",
            "d29ya19pZBgBIAEoAxIhCghwb3NpdGlvbhgCIAEoCzIPLnBhY2tldC5WZWN0",
            "b3IzEgwKBG5hbWUYAyABKAkifgoEUm9vbRIKCgJpZBgBIAEoAxIMCgRuYW1l",
            "GAIgASgJEhYKDm1heF91c2VyX2NvdW50GAMgASgFEh4KFm1hc3Rlcl91c2Vy",
            "X25ldHdvcmtfaWQYBCABKAMSJAoKcm9vbV91c2VycxgFIAMoCzIQLnBhY2tl",
            "dC5Sb29tVXNlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Packet.Vector3), global::Packet.Vector3.Parser, new[]{ "X", "Y", "Z" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Packet.RoomUser), global::Packet.RoomUser.Parser, new[]{ "NetworkId", "Position", "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Packet.Room), global::Packet.Room.Parser, new[]{ "Id", "Name", "MaxUserCount", "MasterUserNetworkId", "RoomUsers" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Vector3 : pb::IMessage<Vector3> {
    private static readonly pb::MessageParser<Vector3> _parser = new pb::MessageParser<Vector3>(() => new Vector3());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Vector3> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Packet.PacketDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3(Vector3 other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3 Clone() {
      return new Vector3(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private float z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Vector3);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Vector3 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
      if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
      if (Z != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
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
      if (X != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Z);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (Z != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Vector3 other) {
      if (other == null) {
        return;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Z != 0F) {
        Z = other.Z;
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
          case 13: {
            X = input.ReadFloat();
            break;
          }
          case 21: {
            Y = input.ReadFloat();
            break;
          }
          case 29: {
            Z = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomUser : pb::IMessage<RoomUser> {
    private static readonly pb::MessageParser<RoomUser> _parser = new pb::MessageParser<RoomUser>(() => new RoomUser());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomUser> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Packet.PacketDataReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomUser() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomUser(RoomUser other) : this() {
      networkId_ = other.networkId_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomUser Clone() {
      return new RoomUser(this);
    }

    /// <summary>Field number for the "network_id" field.</summary>
    public const int NetworkIdFieldNumber = 1;
    private long networkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NetworkId {
      get { return networkId_; }
      set {
        networkId_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 2;
    private global::Packet.Vector3 position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Packet.Vector3 Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomUser);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomUser other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NetworkId != other.NetworkId) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NetworkId != 0L) hash ^= NetworkId.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (NetworkId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(NetworkId);
      }
      if (position_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Position);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NetworkId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NetworkId);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomUser other) {
      if (other == null) {
        return;
      }
      if (other.NetworkId != 0L) {
        NetworkId = other.NetworkId;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          position_ = new global::Packet.Vector3();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
            NetworkId = input.ReadInt64();
            break;
          }
          case 18: {
            if (position_ == null) {
              position_ = new global::Packet.Vector3();
            }
            input.ReadMessage(position_);
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Room : pb::IMessage<Room> {
    private static readonly pb::MessageParser<Room> _parser = new pb::MessageParser<Room>(() => new Room());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Room> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Packet.PacketDataReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room(Room other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      maxUserCount_ = other.maxUserCount_;
      masterUserNetworkId_ = other.masterUserNetworkId_;
      roomUsers_ = other.roomUsers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room Clone() {
      return new Room(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_user_count" field.</summary>
    public const int MaxUserCountFieldNumber = 3;
    private int maxUserCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxUserCount {
      get { return maxUserCount_; }
      set {
        maxUserCount_ = value;
      }
    }

    /// <summary>Field number for the "master_user_network_id" field.</summary>
    public const int MasterUserNetworkIdFieldNumber = 4;
    private long masterUserNetworkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MasterUserNetworkId {
      get { return masterUserNetworkId_; }
      set {
        masterUserNetworkId_ = value;
      }
    }

    /// <summary>Field number for the "room_users" field.</summary>
    public const int RoomUsersFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Packet.RoomUser> _repeated_roomUsers_codec
        = pb::FieldCodec.ForMessage(42, global::Packet.RoomUser.Parser);
    private readonly pbc::RepeatedField<global::Packet.RoomUser> roomUsers_ = new pbc::RepeatedField<global::Packet.RoomUser>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Packet.RoomUser> RoomUsers {
      get { return roomUsers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Room);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Room other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (MaxUserCount != other.MaxUserCount) return false;
      if (MasterUserNetworkId != other.MasterUserNetworkId) return false;
      if(!roomUsers_.Equals(other.roomUsers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (MaxUserCount != 0) hash ^= MaxUserCount.GetHashCode();
      if (MasterUserNetworkId != 0L) hash ^= MasterUserNetworkId.GetHashCode();
      hash ^= roomUsers_.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (MaxUserCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MaxUserCount);
      }
      if (MasterUserNetworkId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(MasterUserNetworkId);
      }
      roomUsers_.WriteTo(output, _repeated_roomUsers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (MaxUserCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxUserCount);
      }
      if (MasterUserNetworkId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MasterUserNetworkId);
      }
      size += roomUsers_.CalculateSize(_repeated_roomUsers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Room other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.MaxUserCount != 0) {
        MaxUserCount = other.MaxUserCount;
      }
      if (other.MasterUserNetworkId != 0L) {
        MasterUserNetworkId = other.MasterUserNetworkId;
      }
      roomUsers_.Add(other.roomUsers_);
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
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            MaxUserCount = input.ReadInt32();
            break;
          }
          case 32: {
            MasterUserNetworkId = input.ReadInt64();
            break;
          }
          case 42: {
            roomUsers_.AddEntriesFrom(input, _repeated_roomUsers_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
