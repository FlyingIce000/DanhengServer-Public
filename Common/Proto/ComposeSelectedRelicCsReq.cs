// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ComposeSelectedRelicCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ComposeSelectedRelicCsReq.proto</summary>
  public static partial class ComposeSelectedRelicCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ComposeSelectedRelicCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ComposeSelectedRelicCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Db21wb3NlU2VsZWN0ZWRSZWxpY0NzUmVxLnByb3RvGhJJdGVtQ29zdERh",
            "dGEucHJvdG8ijgEKGUNvbXBvc2VTZWxlY3RlZFJlbGljQ3NSZXESFQoNbWFp",
            "bl9hZmZpeF9pZBgLIAEoDRITCgtMRE1JSENCS0FDRRgEIAEoDRINCgVjb3Vu",
            "dBgKIAEoDRISCgpjb21wb3NlX2lkGAMgASgNEiIKC0pJTUlOSU5QT0NGGA0g",
            "ASgLMg0uSXRlbUNvc3REYXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ComposeSelectedRelicCsReq), global::EggLink.DanhengServer.Proto.ComposeSelectedRelicCsReq.Parser, new[]{ "MainAffixId", "LDMIHCBKACE", "Count", "ComposeId", "JIMININPOCF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ComposeSelectedRelicCsReq : pb::IMessage<ComposeSelectedRelicCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ComposeSelectedRelicCsReq> _parser = new pb::MessageParser<ComposeSelectedRelicCsReq>(() => new ComposeSelectedRelicCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ComposeSelectedRelicCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ComposeSelectedRelicCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeSelectedRelicCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeSelectedRelicCsReq(ComposeSelectedRelicCsReq other) : this() {
      mainAffixId_ = other.mainAffixId_;
      lDMIHCBKACE_ = other.lDMIHCBKACE_;
      count_ = other.count_;
      composeId_ = other.composeId_;
      jIMININPOCF_ = other.jIMININPOCF_ != null ? other.jIMININPOCF_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeSelectedRelicCsReq Clone() {
      return new ComposeSelectedRelicCsReq(this);
    }

    /// <summary>Field number for the "main_affix_id" field.</summary>
    public const int MainAffixIdFieldNumber = 11;
    private uint mainAffixId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MainAffixId {
      get { return mainAffixId_; }
      set {
        mainAffixId_ = value;
      }
    }

    /// <summary>Field number for the "LDMIHCBKACE" field.</summary>
    public const int LDMIHCBKACEFieldNumber = 4;
    private uint lDMIHCBKACE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LDMIHCBKACE {
      get { return lDMIHCBKACE_; }
      set {
        lDMIHCBKACE_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 10;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "compose_id" field.</summary>
    public const int ComposeIdFieldNumber = 3;
    private uint composeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComposeId {
      get { return composeId_; }
      set {
        composeId_ = value;
      }
    }

    /// <summary>Field number for the "JIMININPOCF" field.</summary>
    public const int JIMININPOCFFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ItemCostData jIMININPOCF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData JIMININPOCF {
      get { return jIMININPOCF_; }
      set {
        jIMININPOCF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ComposeSelectedRelicCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ComposeSelectedRelicCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MainAffixId != other.MainAffixId) return false;
      if (LDMIHCBKACE != other.LDMIHCBKACE) return false;
      if (Count != other.Count) return false;
      if (ComposeId != other.ComposeId) return false;
      if (!object.Equals(JIMININPOCF, other.JIMININPOCF)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MainAffixId != 0) hash ^= MainAffixId.GetHashCode();
      if (LDMIHCBKACE != 0) hash ^= LDMIHCBKACE.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (ComposeId != 0) hash ^= ComposeId.GetHashCode();
      if (jIMININPOCF_ != null) hash ^= JIMININPOCF.GetHashCode();
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
      if (ComposeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ComposeId);
      }
      if (LDMIHCBKACE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LDMIHCBKACE);
      }
      if (Count != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Count);
      }
      if (MainAffixId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MainAffixId);
      }
      if (jIMININPOCF_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(JIMININPOCF);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ComposeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ComposeId);
      }
      if (LDMIHCBKACE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LDMIHCBKACE);
      }
      if (Count != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Count);
      }
      if (MainAffixId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MainAffixId);
      }
      if (jIMININPOCF_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(JIMININPOCF);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MainAffixId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MainAffixId);
      }
      if (LDMIHCBKACE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LDMIHCBKACE);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
      }
      if (ComposeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComposeId);
      }
      if (jIMININPOCF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JIMININPOCF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ComposeSelectedRelicCsReq other) {
      if (other == null) {
        return;
      }
      if (other.MainAffixId != 0) {
        MainAffixId = other.MainAffixId;
      }
      if (other.LDMIHCBKACE != 0) {
        LDMIHCBKACE = other.LDMIHCBKACE;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.ComposeId != 0) {
        ComposeId = other.ComposeId;
      }
      if (other.jIMININPOCF_ != null) {
        if (jIMININPOCF_ == null) {
          JIMININPOCF = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        JIMININPOCF.MergeFrom(other.JIMININPOCF);
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
          case 24: {
            ComposeId = input.ReadUInt32();
            break;
          }
          case 32: {
            LDMIHCBKACE = input.ReadUInt32();
            break;
          }
          case 80: {
            Count = input.ReadUInt32();
            break;
          }
          case 88: {
            MainAffixId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (jIMININPOCF_ == null) {
              JIMININPOCF = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(JIMININPOCF);
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
          case 24: {
            ComposeId = input.ReadUInt32();
            break;
          }
          case 32: {
            LDMIHCBKACE = input.ReadUInt32();
            break;
          }
          case 80: {
            Count = input.ReadUInt32();
            break;
          }
          case 88: {
            MainAffixId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (jIMININPOCF_ == null) {
              JIMININPOCF = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(JIMININPOCF);
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