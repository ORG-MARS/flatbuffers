// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame
{

using global::System;
using global::FlatBuffers;

public struct MonsterExtra : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static MonsterExtra GetRootAsMonsterExtra(ByteBuffer _bb) { return GetRootAsMonsterExtra(_bb, new MonsterExtra()); }
  public static MonsterExtra GetRootAsMonsterExtra(ByteBuffer _bb, MonsterExtra obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool MonsterExtraBufferHasIdentifier(ByteBuffer _bb) { return Table.__has_identifier(_bb, "MONE"); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public MonsterExtra __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float TestfNan { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)Single.NaN; } }
  public bool MutateTestfNan(float testf_nan) { int o = __p.__offset(4); if (o != 0) { __p.bb.PutFloat(o + __p.bb_pos, testf_nan); return true; } else { return false; } }
  public float TestfPinf { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)Single.PositiveInfinity; } }
  public bool MutateTestfPinf(float testf_pinf) { int o = __p.__offset(6); if (o != 0) { __p.bb.PutFloat(o + __p.bb_pos, testf_pinf); return true; } else { return false; } }
  public float TestfNinf { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)Single.NegativeInfinity; } }
  public bool MutateTestfNinf(float testf_ninf) { int o = __p.__offset(8); if (o != 0) { __p.bb.PutFloat(o + __p.bb_pos, testf_ninf); return true; } else { return false; } }
  public double TestdNan { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)Double.NaN; } }
  public bool MutateTestdNan(double testd_nan) { int o = __p.__offset(10); if (o != 0) { __p.bb.PutDouble(o + __p.bb_pos, testd_nan); return true; } else { return false; } }
  public double TestdPinf { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)Double.PositiveInfinity; } }
  public bool MutateTestdPinf(double testd_pinf) { int o = __p.__offset(12); if (o != 0) { __p.bb.PutDouble(o + __p.bb_pos, testd_pinf); return true; } else { return false; } }
  public double TestdNinf { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)Double.NegativeInfinity; } }
  public bool MutateTestdNinf(double testd_ninf) { int o = __p.__offset(14); if (o != 0) { __p.bb.PutDouble(o + __p.bb_pos, testd_ninf); return true; } else { return false; } }
  public float TestfVec(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int TestfVecLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTestfVecBytes() { return __p.__vector_as_span(16); }
#else
  public ArraySegment<byte>? GetTestfVecBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public float[] GetTestfVecArray() { return __p.__vector_as_array<float>(16); }
  public bool MutateTestfVec(int j, float testf_vec) { int o = __p.__offset(16); if (o != 0) { __p.bb.PutFloat(__p.__vector(o) + j * 4, testf_vec); return true; } else { return false; } }
  public double TestdVec(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetDouble(__p.__vector(o) + j * 8) : (double)0; }
  public int TestdVecLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTestdVecBytes() { return __p.__vector_as_span(18); }
#else
  public ArraySegment<byte>? GetTestdVecBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public double[] GetTestdVecArray() { return __p.__vector_as_array<double>(18); }
  public bool MutateTestdVec(int j, double testd_vec) { int o = __p.__offset(18); if (o != 0) { __p.bb.PutDouble(__p.__vector(o) + j * 8, testd_vec); return true; } else { return false; } }

  public static Offset<MonsterExtra> CreateMonsterExtra(FlatBufferBuilder builder,
      float testf_nan = Single.NaN,
      float testf_pinf = Single.PositiveInfinity,
      float testf_ninf = Single.NegativeInfinity,
      double testd_nan = Double.NaN,
      double testd_pinf = Double.PositiveInfinity,
      double testd_ninf = Double.NegativeInfinity,
      VectorOffset testf_vecOffset = default(VectorOffset),
      VectorOffset testd_vecOffset = default(VectorOffset)) {
    builder.StartObject(8);
    MonsterExtra.AddTestdNinf(builder, testd_ninf);
    MonsterExtra.AddTestdPinf(builder, testd_pinf);
    MonsterExtra.AddTestdNan(builder, testd_nan);
    MonsterExtra.AddTestdVec(builder, testd_vecOffset);
    MonsterExtra.AddTestfVec(builder, testf_vecOffset);
    MonsterExtra.AddTestfNinf(builder, testf_ninf);
    MonsterExtra.AddTestfPinf(builder, testf_pinf);
    MonsterExtra.AddTestfNan(builder, testf_nan);
    return MonsterExtra.EndMonsterExtra(builder);
  }

  public static void StartMonsterExtra(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddTestfNan(FlatBufferBuilder builder, float testfNan) { builder.AddFloat(0, testfNan, Single.NaN); }
  public static void AddTestfPinf(FlatBufferBuilder builder, float testfPinf) { builder.AddFloat(1, testfPinf, Single.PositiveInfinity); }
  public static void AddTestfNinf(FlatBufferBuilder builder, float testfNinf) { builder.AddFloat(2, testfNinf, Single.NegativeInfinity); }
  public static void AddTestdNan(FlatBufferBuilder builder, double testdNan) { builder.AddDouble(3, testdNan, Double.NaN); }
  public static void AddTestdPinf(FlatBufferBuilder builder, double testdPinf) { builder.AddDouble(4, testdPinf, Double.PositiveInfinity); }
  public static void AddTestdNinf(FlatBufferBuilder builder, double testdNinf) { builder.AddDouble(5, testdNinf, Double.NegativeInfinity); }
  public static void AddTestfVec(FlatBufferBuilder builder, VectorOffset testfVecOffset) { builder.AddOffset(6, testfVecOffset.Value, 0); }
  public static VectorOffset CreateTestfVecVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTestfVecVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartTestfVecVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTestdVec(FlatBufferBuilder builder, VectorOffset testdVecOffset) { builder.AddOffset(7, testdVecOffset.Value, 0); }
  public static VectorOffset CreateTestdVecVector(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddDouble(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTestdVecVectorBlock(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static void StartTestdVecVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<MonsterExtra> EndMonsterExtra(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<MonsterExtra>(o);
  }
  public static void FinishMonsterExtraBuffer(FlatBufferBuilder builder, Offset<MonsterExtra> offset) { builder.Finish(offset.Value, "MONE"); }
  public static void FinishSizePrefixedMonsterExtraBuffer(FlatBufferBuilder builder, Offset<MonsterExtra> offset) { builder.FinishSizePrefixed(offset.Value, "MONE"); }
};


}