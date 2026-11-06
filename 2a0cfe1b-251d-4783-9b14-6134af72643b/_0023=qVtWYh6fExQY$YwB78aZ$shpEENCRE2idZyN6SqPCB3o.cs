// Decompiled with JetBrains decompiler
// Type: #=qVtWYh6fExQY$YwB78aZ$shpEENCRE2idZyN6SqPCB3o=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;

#nullable disable
internal static class \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D
{
  public static byte[] \u0023\u003DzI48lJhIqAO2gLoOo5g\u003D\u003D(
    object _param0,
    ulong _param1,
    \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D _param2,
    RandomNumberGenerator _param3)
  {
    object obj = _param0;
    if (true)
      ;
    byte[] numArray1 = \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DzmvXCRPJmAdrn6w7e7xhrD5gRKcjf(obj);
    long num = (long) _param1;
    if (true)
      ;
    byte[] numArray2 = \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003Dz5HLCDg0l0uNKUK0uFGAz8_WN8wsd6udnVw\u003D\u003D((ulong) num);
    \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D ag11ryi4o2Vum3dp7WbJp8U = _param2;
    if (true)
      ;
    RandomNumberGenerator randomNumberGenerator = _param3;
    return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003Dz1lHAc4q_ZTapDFWGTCbDwoM\u003D(numArray1, numArray2, ag11ryi4o2Vum3dp7WbJp8U, randomNumberGenerator);
  }

  public static byte[] \u0023\u003Dz1lHAc4q_ZTapDFWGTCbDwoM\u003D(
    byte[] _param0,
    byte[] _param1,
    \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D _param2,
    RandomNumberGenerator _param3)
  {
    int length = _param0.Length;
    if (true)
      goto label_2;
label_1:
    int count;
    if (count == 0)
      throw new ArgumentException();
    int num1 = _param2.\u0023\u003Dz9nPncFm3EG2SxfRwi9oRRCfjr3F03Hf3atqy30osRUxhEaHgDxg5d5wFx4Pf0c3LllaiJl6sUDfjWZqxrQ\u003D\u003D();
    if (true)
      goto label_7;
label_5:
    int num2 = _param2.\u0023\u003DzyWFI3vSTNmOhc14Xyi1erNdl2kN0y6Px5NBgvJtAFTpmpTrw4hH9aHQTyyz0MFI25KVkC\u0024c\u003D();
    if (true)
      goto label_8;
label_6:
    int num3;
    int num4 = count % num3;
    int num5 = (count + (num3 - 1)) / num3;
    byte[] dst;
    if (num4 == 0)
    {
      dst = new byte[count];
      Buffer.BlockCopy((Array) _param0, 0, (Array) dst, 0, count);
    }
    else
    {
      int num6 = \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003Dzs0MszMlssy12o8zd3Jc1gA6VgDTM(num4);
      byte[] bytes = new \u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D(_param0, _param1, num6).GetBytes(num3);
      if (num5 == 1)
      {
        dst = bytes;
      }
      else
      {
        dst = new byte[num3 * num5];
        Buffer.BlockCopy((Array) bytes, 0, (Array) dst, num3 * (num5 - 1), num3);
      }
      Buffer.BlockCopy((Array) _param0, 0, (Array) dst, 0, _param0.Length);
    }
    \u0023\u003DqLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI\u003D.\u0023\u003DzrMC1_sY_rwDTx6JLOAVJvCHd5Fd2kMkekw\u003D\u003D(dst, 0, dst.Length / 4 * 4, _param1);
    byte[] numArray = new byte[_param2.\u0023\u003DzyWFI3vSTNmOhc14Xyi1erNdl2kN0y6Px5NBgvJtAFTpmpTrw4hH9aHQTyyz0MFI25KVkC\u0024c\u003D() * num5];
    int num7;
    for (int index = 0; index < num5; ++index)
      _param2.\u0023\u003DzMcp1j9HeFzOJtlfrJ79aMlkKYXTeLciLbkTjBenGOAT6pOmq6v8B9K\u00240TJVdV_I5Pj8GRwllj5snhj4t9wnEJZM\u003D(dst, num3 * index, num3, numArray, num7 * index, _param3);
    return numArray;
label_8:
    num7 = num2;
    goto label_6;
label_7:
    num3 = num1;
    goto label_5;
label_2:
    count = length;
    goto label_1;
  }

  private static int \u0023\u003Dzs0MszMlssy12o8zd3Jc1gA6VgDTM(int _param0)
  {
    int num = _param0;
    if (true)
      ;
    return num < 8 ? 200 : 1;
  }

  public static byte[] \u0023\u003DzmvXCRPJmAdrn6w7e7xhrD5gRKcjf(object _param0)
  {
    switch (_param0)
    {
      case sbyte num9:
        int num1 = (int) num9;
        sbyte num2;
        if (true)
          num2 = (sbyte) num1;
        return new byte[1]{ (byte) num2 };
      case byte num10:
        int num3 = (int) num10;
        byte num4;
        if (true)
          num4 = (byte) num3;
        return new byte[1]{ num4 };
      case short num11:
        int num5 = (int) num11;
        short num6;
        if (true)
          num6 = (short) num5;
        return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003Dzf89ealaqSP26utf38SDwzAOXoufl(num6);
      case ushort num12:
        int num7 = (int) num12;
        ushort num8;
        if (true)
          num8 = (ushort) num7;
        return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DzQoo_v6\u0024q\u0024Zr9TgkjQCMZYlFaksvnBiJxQxn9QCaSx2Pl(num8);
      case int num13:
        return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003Dzo3G0LY0eo6LY_n_Z25DjbuE\u003D(num13);
      case uint num14:
        return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DzGb4cE1Vj7GAQ4FAyZoMhpogOJ8FhHfJ5Tw\u003D\u003D(num14);
      case long num15:
        return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DziIoXC1Mp10YCD3o85Ho7BHO0xQcIfxU_o1xj\u0024xA\u003D(num15);
      case ulong num16:
        return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003Dz5HLCDg0l0uNKUK0uFGAz8_WN8wsd6udnVw\u003D\u003D(num16);
      case byte[] numArray1:
        return numArray1;
      case string str:
        return Encoding.Unicode.GetBytes(str);
      case IEnumerable enumerable:
        MemoryStream memoryStream = new MemoryStream();
        foreach (object obj in enumerable)
        {
          byte[] numArray = \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DzmvXCRPJmAdrn6w7e7xhrD5gRKcjf(obj);
          ((Stream) memoryStream).Write(numArray, 0, numArray.Length);
        }
        return memoryStream.ToArray();
      default:
        throw new ArgumentOutOfRangeException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622681));
    }
  }

  private static byte[] \u0023\u003Dzf89ealaqSP26utf38SDwzAOXoufl(short _param0)
  {
    int num = (int) _param0;
    if (true)
      ;
    return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DzQoo_v6\u0024q\u0024Zr9TgkjQCMZYlFaksvnBiJxQxn9QCaSx2Pl((ushort) num);
  }

  private static byte[] \u0023\u003DzQoo_v6\u0024q\u0024Zr9TgkjQCMZYlFaksvnBiJxQxn9QCaSx2Pl(
    ushort _param0)
  {
    byte[] numArray = new byte[2];
    int num1 = (int) _param0;
    if (true)
      ;
    numArray[1] = (byte) num1;
    int num2 = (int) _param0;
    if (true)
      ;
    numArray[0] = (byte) (num2 >> 8);
    return numArray;
  }

  private static byte[] \u0023\u003Dzo3G0LY0eo6LY_n_Z25DjbuE\u003D(int _param0)
  {
    int num = _param0;
    if (true)
      ;
    return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DzGb4cE1Vj7GAQ4FAyZoMhpogOJ8FhHfJ5Tw\u003D\u003D((uint) num);
  }

  private static byte[] \u0023\u003DzGb4cE1Vj7GAQ4FAyZoMhpogOJ8FhHfJ5Tw\u003D\u003D(uint _param0)
  {
    byte[] numArray = new byte[4];
    int num1 = (int) _param0;
    if (true)
      ;
    numArray[3] = (byte) num1;
    int num2 = (int) _param0;
    if (true)
      ;
    numArray[2] = (byte) (num2 >>> 8);
    int num3 = (int) _param0;
    if (true)
      ;
    numArray[1] = (byte) (num3 >>> 16 /*0x10*/);
    numArray[0] = (byte) (_param0 >> 24);
    return numArray;
  }

  private static byte[] \u0023\u003DziIoXC1Mp10YCD3o85Ho7BHO0xQcIfxU_o1xj\u0024xA\u003D(long _param0)
  {
    long num = _param0;
    if (true)
      ;
    return \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003Dz5HLCDg0l0uNKUK0uFGAz8_WN8wsd6udnVw\u003D\u003D((ulong) num);
  }

  private static byte[] \u0023\u003Dz5HLCDg0l0uNKUK0uFGAz8_WN8wsd6udnVw\u003D\u003D(ulong _param0)
  {
    byte[] numArray = new byte[8];
    long num1 = (long) _param0;
    if (true)
      ;
    numArray[7] = (byte) num1;
    long num2 = (long) _param0;
    if (true)
      ;
    numArray[6] = (byte) (num2 >>> 8);
    long num3 = (long) _param0;
    if (true)
      ;
    numArray[5] = (byte) (num3 >>> 16 /*0x10*/);
    numArray[4] = (byte) (_param0 >> 24);
    numArray[3] = (byte) (_param0 >> 32 /*0x20*/);
    numArray[2] = (byte) (_param0 >> 40);
    numArray[1] = (byte) (_param0 >> 48 /*0x30*/);
    numArray[0] = (byte) (_param0 >> 56);
    return numArray;
  }
}
