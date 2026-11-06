// Decompiled with JetBrains decompiler
// Type: #=qLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal static class \u0023\u003DqLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI\u003D
{
  private static uint \u0023\u003DzmV1yV4G8kvEs0khNQ1xkjZI\u003D(
    uint _param0,
    uint _param1,
    uint _param2,
    int _param3,
    uint _param4,
    uint[] _param5)
  {
    int num1 = (int) _param2;
    if (true)
      ;
    int num2 = num1 >>> 5;
    int num3 = (int) _param1;
    if (true)
      ;
    int num4 = num3 << 2;
    int num5 = num2 ^ num4;
    int num6 = (int) _param1;
    if (true)
      ;
    int num7 = num6 >>> 3 ^ (int) _param2 << 4;
    return (uint) (num5 + num7 ^ ((int) _param0 ^ (int) _param1) + ((int) _param5[(long) (_param3 & 3) ^ (long) _param4] ^ (int) _param2));
  }

  public static void \u0023\u003DzrMC1_sY_rwDTx6JLOAVJvCHd5Fd2kMkekw\u003D\u003D(
    byte[] _param0,
    int _param1,
    int _param2,
    byte[] _param3)
  {
    if (_param0.Length == 0 || _param0.Length == 0)
      return;
    if (_param1 + _param2 > _param0.Length || _param2 % 4 != 0 || _param2 < 8)
      throw new ArgumentException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772625191));
    if (_param3 == null || _param3.Length > 16 /*0x10*/)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772625204));
    uint[] numArray1 = new uint[_param2 / 4];
    if (true)
      goto label_9;
label_6:
    uint[] numArray2;
    \u0023\u003DqLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI\u003D.\u0023\u003Dz3qEZSJhH7GtdS_6IMkmnnvM\u003D(_param0, _param1, _param2, numArray2, 0);
    uint[] numArray3 = new uint[4];
    if (true)
      goto label_10;
label_7:
    uint[] numArray4;
    \u0023\u003DqLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI\u003D.\u0023\u003Dz3qEZSJhH7GtdS_6IMkmnnvM\u003D(_param3, 0, _param3.Length, numArray4, 0);
    uint[] numArray5 = numArray2;
    uint[] numArray6 = numArray4;
    if (true)
      goto label_11;
label_8:
    \u0023\u003DqLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI\u003D.\u0023\u003DzSeQKJ4wMl4rxmo064JD0a1UWOsBRLIuB9gr37nM\u003D(numArray2, 0, numArray2.Length, _param0, _param1);
    return;
label_11:
    \u0023\u003DqLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI\u003D.\u0023\u003DzsEal\u0024g\u0024A_4NseoSUZpgGz12h1\u00241U(numArray5, numArray6);
    goto label_8;
label_10:
    numArray4 = numArray3;
    goto label_7;
label_9:
    numArray2 = numArray1;
    goto label_6;
  }

  private static void \u0023\u003DzsEal\u0024g\u0024A_4NseoSUZpgGz12h1\u00241U(
    uint[] _param0,
    uint[] _param1)
  {
    int num1 = _param0.Length - 1;
    if (true)
      goto label_3;
label_1:
    int index1;
    if (index1 < 1)
      return;
    int num2 = (int) _param0[index1];
    if (true)
      goto label_8;
label_6:
    if (true)
      goto label_9;
label_7:
    int num3 = 6 + 52 / (index1 + 1);
    uint num4;
    uint num5;
    while (0 < num3--)
    {
      num5 += 2654435769U;
      uint num6 = num5 >> 2 & 3U;
      int index2;
      for (index2 = 0; index2 < index1; ++index2)
      {
        uint num7 = _param0[index2 + 1];
        num4 = (_param0[index2] += \u0023\u003DqLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI\u003D.\u0023\u003DzmV1yV4G8kvEs0khNQ1xkjZI\u003D(num5, num7, num4, index2, num6, _param1));
      }
      uint num8 = _param0[0];
      num4 = (_param0[index1] += \u0023\u003DqLGOxky9lGZWelnlPpn9Fe_4gLQaU5r7YCLO6t4Qj8XI\u003D.\u0023\u003DzmV1yV4G8kvEs0khNQ1xkjZI\u003D(num5, num8, num4, index2, num6, _param1));
    }
    return;
label_9:
    num5 = 0U;
    goto label_7;
label_8:
    num4 = (uint) num2;
    goto label_6;
label_3:
    index1 = num1;
    goto label_1;
  }

  private static uint[] \u0023\u003Dz3qEZSJhH7GtdS_6IMkmnnvM\u003D(
    byte[] _param0,
    int _param1,
    int _param2,
    uint[] _param3,
    int _param4)
  {
    if (_param1 + _param2 > _param0.Length)
      throw new ArgumentException();
    int num1 = _param2 / 4;
    if (true)
      goto label_4;
label_3:
    int num2;
    if (_param4 + num2 > _param3.Length)
      throw new ArgumentException();
    int num3 = _param1 + _param2;
    if (true)
      goto label_8;
label_7:
    int num4 = _param1;
    int index;
    if (true)
      index = num4;
    int num5;
    for (; index < num5; index += 4)
      _param3[_param4 + (index - _param1) / 4] = (uint) ((int) _param0[index] | (int) _param0[index + 1] << 8 | (int) _param0[index + 2] << 16 /*0x10*/ | (int) _param0[index + 3] << 24);
    return _param3;
label_8:
    num5 = num3;
    goto label_7;
label_4:
    num2 = num1;
    goto label_3;
  }

  private static void \u0023\u003DzSeQKJ4wMl4rxmo064JD0a1UWOsBRLIuB9gr37nM\u003D(
    uint[] _param0,
    int _param1,
    int _param2,
    byte[] _param3,
    int _param4)
  {
    if (_param1 + _param2 > _param0.Length)
      throw new ArgumentException();
    int num1 = _param2 * 4;
    if (true)
      goto label_4;
label_3:
    int num2;
    if (_param4 + num2 > _param3.Length)
      throw new ArgumentException();
    int num3 = _param4 + num2;
    if (true)
      goto label_9;
label_7:
    int num4 = _param4;
    int index;
    if (true)
      index = num4;
    int num5;
    for (; index < num5; index += 4)
    {
      uint num6 = _param0[(index - _param4) / 4 + _param1];
      _param3[index] = (byte) num6;
      _param3[index + 1] = (byte) (num6 >> 8);
      _param3[index + 2] = (byte) (num6 >> 16 /*0x10*/);
      _param3[index + 3] = (byte) (num6 >> 24);
    }
    return;
label_9:
    num5 = num3;
    goto label_7;
label_4:
    num2 = num1;
    goto label_3;
  }
}
