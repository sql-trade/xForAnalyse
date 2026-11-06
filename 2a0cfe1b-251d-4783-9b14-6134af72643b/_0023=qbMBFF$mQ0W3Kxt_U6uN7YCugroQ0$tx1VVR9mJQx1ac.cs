// Decompiled with JetBrains decompiler
// Type: #=qbMBFF$mQ0W3Kxt_U6uN7YCugroQ0$tx1VVR9mJQx1ac=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
internal static class \u0023\u003DqbMBFF\u0024mQ0W3Kxt_U6uN7YCugroQ0\u0024tx1VVR9mJQx1ac\u003D
{
  private static readonly uint[] \u0023\u003Dzv_DK75M\u003D;

  static \u0023\u003DqbMBFF\u0024mQ0W3Kxt_U6uN7YCugroQ0\u0024tx1VVR9mJQx1ac\u003D()
  {
    uint[] numArray = new uint[5];
    // ISSUE: field reference
    RuntimeFieldHandle fldHandle = __fieldref (\u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg8RM5ZWWkt3skFZ4SUG6C3Q\u003D.\u0023\u003Dzv_DK75M\u003D);
    if (true)
      goto label_3;
label_1:
    if (false)
      return;
    \u0023\u003DqbMBFF\u0024mQ0W3Kxt_U6uN7YCugroQ0\u0024tx1VVR9mJQx1ac\u003D.\u0023\u003Dzv_DK75M\u003D = numArray;
    return;
label_3:
    RuntimeHelpers.InitializeArray((Array) numArray, fldHandle);
    goto label_1;
  }

  public static byte[] \u0023\u003DzYsXdQZy3FEamov97KQ\u003D\u003D(string _param0)
  {
    MemoryStream memoryStream1 = _param0 != null ? new MemoryStream(_param0.Length * 4 / 5) : throw new Exception();
    MemoryStream memoryStream2;
    if (true)
      memoryStream2 = memoryStream1;
    try
    {
      if (true)
        goto label_7;
label_5:
      if (true)
        goto label_8;
label_6:
      int index1;
      uint num;
      foreach (char ch in _param0)
      {
        if (ch == 'z' && index1 == 0)
        {
          \u0023\u003DqbMBFF\u0024mQ0W3Kxt_U6uN7YCugroQ0\u0024tx1VVR9mJQx1ac\u003D.\u0023\u003DzEdHzjpgHX_KjCrTnl_JZKBo\u003D((Stream) memoryStream2, num, 0);
        }
        else
        {
          if (ch < '!' || ch > 'u')
            throw new Exception();
          checked { num += (uint) ((long) \u0023\u003DqbMBFF\u0024mQ0W3Kxt_U6uN7YCugroQ0\u0024tx1VVR9mJQx1ac\u003D.\u0023\u003Dzv_DK75M\u003D[index1] * (long) ((int) ch - 33)); }
          ++index1;
          if (index1 == 5)
          {
            \u0023\u003DqbMBFF\u0024mQ0W3Kxt_U6uN7YCugroQ0\u0024tx1VVR9mJQx1ac\u003D.\u0023\u003DzEdHzjpgHX_KjCrTnl_JZKBo\u003D((Stream) memoryStream2, num, 0);
            index1 = 0;
            num = 0U;
          }
        }
      }
      if (index1 == 1)
        throw new Exception();
      if (index1 > 1)
      {
        for (int index2 = index1; index2 < 5; ++index2)
          checked { num += 84U * \u0023\u003DqbMBFF\u0024mQ0W3Kxt_U6uN7YCugroQ0\u0024tx1VVR9mJQx1ac\u003D.\u0023\u003Dzv_DK75M\u003D[index2]; }
        \u0023\u003DqbMBFF\u0024mQ0W3Kxt_U6uN7YCugroQ0\u0024tx1VVR9mJQx1ac\u003D.\u0023\u003DzEdHzjpgHX_KjCrTnl_JZKBo\u003D((Stream) memoryStream2, num, 5 - index1);
      }
      return memoryStream2.ToArray();
label_8:
      num = 0U;
      goto label_6;
label_7:
      index1 = 0;
      goto label_5;
    }
    finally
    {
      ((IDisposable) memoryStream2).Dispose();
    }
  }

  private static void \u0023\u003DzEdHzjpgHX_KjCrTnl_JZKBo\u003D(
    Stream _param0,
    uint _param1,
    int _param2)
  {
    Stream stream = _param0;
    if (true)
      ;
    int num1 = (int) _param1;
    if (true)
      ;
    int num2 = (int) (byte) (num1 >>> 24);
    stream.WriteByte((byte) num2);
    int num3 = _param2;
    if (true)
      ;
    if (num3 == 3)
      return;
    _param0.WriteByte((byte) (_param1 >> 16 /*0x10*/));
    if (_param2 == 2)
      return;
    _param0.WriteByte((byte) (_param1 >> 8));
    if (_param2 == 1)
      return;
    _param0.WriteByte((byte) _param1);
  }
}
