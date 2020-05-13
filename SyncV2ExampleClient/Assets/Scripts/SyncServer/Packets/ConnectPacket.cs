// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SyncServer
{

using global::System;
using global::FlatBuffers;

public struct ConnectPacket : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ConnectPacket GetRootAsConnectPacket(ByteBuffer _bb) { return GetRootAsConnectPacket(_bb, new ConnectPacket()); }
  public static ConnectPacket GetRootAsConnectPacket(ByteBuffer _bb, ConnectPacket obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ConnectPacket __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public short Opcode { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public long UserId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string MatchId { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMatchIdBytes() { return __p.__vector_as_span(8); }
#else
  public ArraySegment<byte>? GetMatchIdBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetMatchIdArray() { return __p.__vector_as_array<byte>(8); }
  public string ExternalToken { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExternalTokenBytes() { return __p.__vector_as_span(10); }
#else
  public ArraySegment<byte>? GetExternalTokenBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetExternalTokenArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<ConnectPacket> CreateConnectPacket(FlatBufferBuilder builder,
      short opcode = 0,
      long userId = 0,
      StringOffset matchIdOffset = default(StringOffset),
      StringOffset externalTokenOffset = default(StringOffset)) {
    builder.StartObject(4);
    ConnectPacket.AddUserId(builder, userId);
    ConnectPacket.AddExternalToken(builder, externalTokenOffset);
    ConnectPacket.AddMatchId(builder, matchIdOffset);
    ConnectPacket.AddOpcode(builder, opcode);
    return ConnectPacket.EndConnectPacket(builder);
  }

  public static void StartConnectPacket(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddOpcode(FlatBufferBuilder builder, short opcode) { builder.AddShort(0, opcode, 0); }
  public static void AddUserId(FlatBufferBuilder builder, long userId) { builder.AddLong(1, userId, 0); }
  public static void AddMatchId(FlatBufferBuilder builder, StringOffset matchIdOffset) { builder.AddOffset(2, matchIdOffset.Value, 0); }
  public static void AddExternalToken(FlatBufferBuilder builder, StringOffset externalTokenOffset) { builder.AddOffset(3, externalTokenOffset.Value, 0); }
  public static Offset<ConnectPacket> EndConnectPacket(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ConnectPacket>(o);
  }
};


}
