// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FIPGDJHGAEC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FIPGDJHGAEC.proto</summary>
  public static partial class FIPGDJHGAECReflection {

    #region Descriptor
    /// <summary>File descriptor for FIPGDJHGAEC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FIPGDJHGAECReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGSVBHREpIR0FFQy5wcm90byJFCgtGSVBHREpIR0FFQxITCgtDTEdEQ0hM",
            "TkNMSBgMIAMoDRITCgtBREJOSUhQQkRCRRgHIAEoDRIMCgR0eXBlGAggASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FIPGDJHGAEC), global::EggLink.DanhengServer.Proto.FIPGDJHGAEC.Parser, new[]{ "CLGDCHLNCLH", "ADBNIHPBDBE", "Type" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FIPGDJHGAEC : pb::IMessage<FIPGDJHGAEC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FIPGDJHGAEC> _parser = new pb::MessageParser<FIPGDJHGAEC>(() => new FIPGDJHGAEC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FIPGDJHGAEC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FIPGDJHGAECReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FIPGDJHGAEC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FIPGDJHGAEC(FIPGDJHGAEC other) : this() {
      cLGDCHLNCLH_ = other.cLGDCHLNCLH_.Clone();
      aDBNIHPBDBE_ = other.aDBNIHPBDBE_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FIPGDJHGAEC Clone() {
      return new FIPGDJHGAEC(this);
    }

    /// <summary>Field number for the "CLGDCHLNCLH" field.</summary>
    public const int CLGDCHLNCLHFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_cLGDCHLNCLH_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> cLGDCHLNCLH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CLGDCHLNCLH {
      get { return cLGDCHLNCLH_; }
    }

    /// <summary>Field number for the "ADBNIHPBDBE" field.</summary>
    public const int ADBNIHPBDBEFieldNumber = 7;
    private uint aDBNIHPBDBE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ADBNIHPBDBE {
      get { return aDBNIHPBDBE_; }
      set {
        aDBNIHPBDBE_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 8;
    private uint type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FIPGDJHGAEC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FIPGDJHGAEC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cLGDCHLNCLH_.Equals(other.cLGDCHLNCLH_)) return false;
      if (ADBNIHPBDBE != other.ADBNIHPBDBE) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cLGDCHLNCLH_.GetHashCode();
      if (ADBNIHPBDBE != 0) hash ^= ADBNIHPBDBE.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
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
      if (ADBNIHPBDBE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ADBNIHPBDBE);
      }
      if (Type != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Type);
      }
      cLGDCHLNCLH_.WriteTo(output, _repeated_cLGDCHLNCLH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ADBNIHPBDBE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ADBNIHPBDBE);
      }
      if (Type != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Type);
      }
      cLGDCHLNCLH_.WriteTo(ref output, _repeated_cLGDCHLNCLH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += cLGDCHLNCLH_.CalculateSize(_repeated_cLGDCHLNCLH_codec);
      if (ADBNIHPBDBE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ADBNIHPBDBE);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FIPGDJHGAEC other) {
      if (other == null) {
        return;
      }
      cLGDCHLNCLH_.Add(other.cLGDCHLNCLH_);
      if (other.ADBNIHPBDBE != 0) {
        ADBNIHPBDBE = other.ADBNIHPBDBE;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
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
          case 56: {
            ADBNIHPBDBE = input.ReadUInt32();
            break;
          }
          case 64: {
            Type = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            cLGDCHLNCLH_.AddEntriesFrom(input, _repeated_cLGDCHLNCLH_codec);
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
          case 56: {
            ADBNIHPBDBE = input.ReadUInt32();
            break;
          }
          case 64: {
            Type = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            cLGDCHLNCLH_.AddEntriesFrom(ref input, _repeated_cLGDCHLNCLH_codec);
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