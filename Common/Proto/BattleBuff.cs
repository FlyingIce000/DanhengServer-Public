// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattleBuff.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BattleBuff.proto</summary>
  public static partial class BattleBuffReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleBuff.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleBuffReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBCYXR0bGVCdWZmLnByb3RvItgBCgpCYXR0bGVCdWZmEgoKAmlkGAEgASgN",
            "Eg0KBWxldmVsGAIgASgNEhMKC293bmVyX2luZGV4GAMgASgNEhEKCXdhdmVf",
            "ZmxhZxgEIAEoDRIZChF0YXJnZXRfaW5kZXhfbGlzdBgFIAMoDRI2Cg5keW5h",
            "bWljX3ZhbHVlcxgGIAMoCzIeLkJhdHRsZUJ1ZmYuRHluYW1pY1ZhbHVlc0Vu",
            "dHJ5GjQKEkR5bmFtaWNWYWx1ZXNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFs",
            "dWUYAiABKAI6AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BattleBuff), global::EggLink.DanhengServer.Proto.BattleBuff.Parser, new[]{ "Id", "Level", "OwnerIndex", "WaveFlag", "TargetIndexList", "DynamicValues" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattleBuff : pb::IMessage<BattleBuff>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattleBuff> _parser = new pb::MessageParser<BattleBuff>(() => new BattleBuff());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattleBuff> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BattleBuffReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleBuff() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleBuff(BattleBuff other) : this() {
      id_ = other.id_;
      level_ = other.level_;
      ownerIndex_ = other.ownerIndex_;
      waveFlag_ = other.waveFlag_;
      targetIndexList_ = other.targetIndexList_.Clone();
      dynamicValues_ = other.dynamicValues_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleBuff Clone() {
      return new BattleBuff(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "owner_index" field.</summary>
    public const int OwnerIndexFieldNumber = 3;
    private uint ownerIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerIndex {
      get { return ownerIndex_; }
      set {
        ownerIndex_ = value;
      }
    }

    /// <summary>Field number for the "wave_flag" field.</summary>
    public const int WaveFlagFieldNumber = 4;
    private uint waveFlag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WaveFlag {
      get { return waveFlag_; }
      set {
        waveFlag_ = value;
      }
    }

    /// <summary>Field number for the "target_index_list" field.</summary>
    public const int TargetIndexListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_targetIndexList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> targetIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetIndexList {
      get { return targetIndexList_; }
    }

    /// <summary>Field number for the "dynamic_values" field.</summary>
    public const int DynamicValuesFieldNumber = 6;
    private static readonly pbc::MapField<string, float>.Codec _map_dynamicValues_codec
        = new pbc::MapField<string, float>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForFloat(21, 0F), 50);
    private readonly pbc::MapField<string, float> dynamicValues_ = new pbc::MapField<string, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, float> DynamicValues {
      get { return dynamicValues_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattleBuff);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattleBuff other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Level != other.Level) return false;
      if (OwnerIndex != other.OwnerIndex) return false;
      if (WaveFlag != other.WaveFlag) return false;
      if(!targetIndexList_.Equals(other.targetIndexList_)) return false;
      if (!DynamicValues.Equals(other.DynamicValues)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (OwnerIndex != 0) hash ^= OwnerIndex.GetHashCode();
      if (WaveFlag != 0) hash ^= WaveFlag.GetHashCode();
      hash ^= targetIndexList_.GetHashCode();
      hash ^= DynamicValues.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (OwnerIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OwnerIndex);
      }
      if (WaveFlag != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WaveFlag);
      }
      targetIndexList_.WriteTo(output, _repeated_targetIndexList_codec);
      dynamicValues_.WriteTo(output, _map_dynamicValues_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (OwnerIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OwnerIndex);
      }
      if (WaveFlag != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WaveFlag);
      }
      targetIndexList_.WriteTo(ref output, _repeated_targetIndexList_codec);
      dynamicValues_.WriteTo(ref output, _map_dynamicValues_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (OwnerIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerIndex);
      }
      if (WaveFlag != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaveFlag);
      }
      size += targetIndexList_.CalculateSize(_repeated_targetIndexList_codec);
      size += dynamicValues_.CalculateSize(_map_dynamicValues_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattleBuff other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.OwnerIndex != 0) {
        OwnerIndex = other.OwnerIndex;
      }
      if (other.WaveFlag != 0) {
        WaveFlag = other.WaveFlag;
      }
      targetIndexList_.Add(other.targetIndexList_);
      dynamicValues_.MergeFrom(other.dynamicValues_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 24: {
            OwnerIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            WaveFlag = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            targetIndexList_.AddEntriesFrom(input, _repeated_targetIndexList_codec);
            break;
          }
          case 50: {
            dynamicValues_.AddEntriesFrom(input, _map_dynamicValues_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 24: {
            OwnerIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            WaveFlag = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            targetIndexList_.AddEntriesFrom(ref input, _repeated_targetIndexList_codec);
            break;
          }
          case 50: {
            dynamicValues_.AddEntriesFrom(ref input, _map_dynamicValues_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code