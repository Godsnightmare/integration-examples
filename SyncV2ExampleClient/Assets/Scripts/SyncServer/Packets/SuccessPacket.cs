// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SyncServer
{

using global::System;
using global::FlatBuffers;

public struct SuccessPacket : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static SuccessPacket GetRootAsSuccessPacket(ByteBuffer _bb) { return GetRootAsSuccessPacket(_bb, new SuccessPacket()); }
  public static SuccessPacket GetRootAsSuccessPacket(ByteBuffer _bb, SuccessPacket obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public SuccessPacket __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public short Opcode { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public bool Success { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SuccessPacket> CreateSuccessPacket(FlatBufferBuilder builder,
      short opcode = 0,
      bool success = false) {
    builder.StartObject(2);
    SuccessPacket.AddOpcode(builder, opcode);
    SuccessPacket.AddSuccess(builder, success);
    return SuccessPacket.EndSuccessPacket(builder);
  }

  public static void StartSuccessPacket(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddOpcode(FlatBufferBuilder builder, short opcode) { builder.AddShort(0, opcode, 0); }
  public static void AddSuccess(FlatBufferBuilder builder, bool success) { builder.AddBool(1, success, false); }
  public static Offset<SuccessPacket> EndSuccessPacket(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<SuccessPacket>(o);
  }
};


}