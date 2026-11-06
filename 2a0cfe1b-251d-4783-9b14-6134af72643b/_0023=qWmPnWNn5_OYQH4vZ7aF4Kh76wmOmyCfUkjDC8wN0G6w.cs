// Decompiled with JetBrains decompiler
// Type: #=qWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

#nullable disable
internal sealed class \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D : 
  SymmetricAlgorithm
{
  private static byte[] \u0023\u003Dzv_DK75M\u003D;

  public \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D()
  {
    KeySizes[] keySizesArray1 = new KeySizes[1]
    {
      new KeySizes(32 /*0x20*/, 32 /*0x20*/, 0)
    };
    if (true)
      goto label_4;
label_1:
    KeySizes[] keySizesArray2 = new KeySizes[1]
    {
      new KeySizes(80 /*0x50*/, 80 /*0x50*/, 0)
    };
    if (true)
      goto label_5;
label_2:
    if (true)
      goto label_6;
label_3:
    this.KeySizeValue = 80 /*0x50*/;
    this.ModeValue = CipherMode.ECB;
    this.PaddingValue = PaddingMode.None;
    return;
label_6:
    this.BlockSizeValue = 32 /*0x20*/;
    goto label_3;
label_5:
    this.LegalKeySizesValue = keySizesArray2;
    goto label_2;
label_4:
    this.LegalBlockSizesValue = keySizesArray1;
    goto label_1;
  }

  public \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D(byte[] _param1)
  {
    if (true)
      ;
    // ISSUE: explicit constructor call
    this.\u002Ector();
    if (true)
      ;
    byte[] numArray = _param1;
    if (true)
      ;
    this.Key = numArray != null ? numArray : throw new ArgumentNullException();
  }

  static \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D()
  {
    byte[] numArray = new byte[256 /*0x0100*/];
    // ISSUE: field reference
    RuntimeFieldHandle fldHandle = __fieldref (\u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AIviALitMCSCbJxropfq0yw\u003D.\u0023\u003DzOsmxM1I\u003D);
    if (true)
      goto label_3;
label_1:
    if (false)
      return;
    \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003Dzv_DK75M\u003D = numArray;
    return;
label_3:
    RuntimeHelpers.InitializeArray((Array) numArray, fldHandle);
    goto label_1;
  }

  public override ICryptoTransform CreateDecryptor(byte[] _param1, byte[] _param2)
  {
    byte[] numArray = _param1;
    if (true)
      ;
    return (ICryptoTransform) new \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003Dzv_DK75M\u003D(numArray, false);
  }

  public override ICryptoTransform CreateEncryptor(byte[] _param1, byte[] _param2)
  {
    byte[] numArray = _param1;
    if (true)
      ;
    return (ICryptoTransform) new \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003Dzv_DK75M\u003D(numArray, true);
  }

  public override void GenerateIV() => throw new NotImplementedException();

  public override void GenerateKey() => throw new NotImplementedException();

  private static ushort \u0023\u003DznepQl9aImDrJq_Qkd9mXy2nX5jdj\u0024h_EbnFxYHE\u003D(
    byte[] _param0,
    int _param1,
    ushort _param2)
  {
    int num1 = (int) (byte) ((uint) _param2 >> 8);
    if (true)
      goto label_4;
label_1:
    int num2 = (int) (byte) _param2;
    if (true)
      goto label_5;
label_2:
    byte num3;
    byte num4;
    int num5 = (int) (byte) ((uint) \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003Dzv_DK75M\u003D[(int) num3 ^ (int) _param0[4 * _param1 % 10]] ^ (uint) num4);
    if (true)
      goto label_6;
label_3:
    byte num6;
    byte num7 = (byte) ((uint) \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003Dzv_DK75M\u003D[(int) num6 ^ (int) _param0[(4 * _param1 + 1) % 10]] ^ (uint) num3);
    byte num8 = (byte) ((uint) \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003Dzv_DK75M\u003D[(int) num7 ^ (int) _param0[(4 * _param1 + 2) % 10]] ^ (uint) num6);
    byte num9 = (byte) ((uint) \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003Dzv_DK75M\u003D[(int) num8 ^ (int) _param0[(4 * _param1 + 3) % 10]] ^ (uint) num7);
    return (ushort) (((uint) num8 << 8) + (uint) num9);
label_6:
    num6 = (byte) num5;
    goto label_3;
label_5:
    num3 = (byte) num2;
    goto label_2;
label_4:
    num4 = (byte) num1;
    goto label_1;
  }

  private static void \u0023\u003DzfeGB2V4KYaRD8RDbwKoy9Z5VY_y\u00245VoIQs4hh0c5O6ou(
    byte[] _param0,
    byte[] _param1,
    int _param2,
    byte[] _param3,
    int _param4,
    bool _param5)
  {
    int num1;
    int num2;
    if (_param5)
    {
      if (true)
        goto label_3;
label_2:
      if (true)
      {
        num2 = 0;
        goto label_8;
      }
      goto label_8;
label_3:
      num1 = 1;
      goto label_2;
    }
    if (true)
      goto label_7;
label_6:
    num2 = 23;
    goto label_8;
label_7:
    num1 = -1;
    goto label_6;
label_8:
    ushort num3 = (ushort) (((uint) _param1[_param2] << 8) + (uint) _param1[_param2 + 1]);
    ushort num4 = (ushort) (((uint) _param1[_param2 + 2] << 8) + (uint) _param1[_param2 + 3]);
    for (int index = 0; index < 12; ++index)
    {
      num4 ^= (ushort) ((uint) \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003DznepQl9aImDrJq_Qkd9mXy2nX5jdj\u0024h_EbnFxYHE\u003D(_param0, num2, num3) ^ (uint) num2);
      int num5 = num2 + num1;
      num3 ^= (ushort) ((uint) \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003DznepQl9aImDrJq_Qkd9mXy2nX5jdj\u0024h_EbnFxYHE\u003D(_param0, num5, num4) ^ (uint) num5);
      num2 = num5 + num1;
    }
    _param3[_param4] = (byte) ((uint) num4 >> 8);
    _param3[_param4 + 1] = (byte) num4;
    _param3[_param4 + 2] = (byte) ((uint) num3 >> 8);
    _param3[_param4 + 3] = (byte) num3;
  }

  private sealed class \u0023\u003Dzv_DK75M\u003D : ICryptoTransform, IDisposable
  {
    private byte[] \u0023\u003Dzv_DK75M\u003D;
    private bool \u0023\u003DzOsmxM1I\u003D;

    public \u0023\u003Dzv_DK75M\u003D(byte[] _param1, bool _param2)
    {
      byte[] numArray = _param1;
      if (true)
        goto label_3;
label_1:
      int num = _param2 ? 1 : 0;
      if (false)
        return;
      this.\u0023\u003DzOsmxM1I\u003D = num != 0;
      return;
label_3:
      this.\u0023\u003Dzv_DK75M\u003D = numArray;
      goto label_1;
    }

    public int InputBlockSize => 4;

    public int OutputBlockSize => 4;

    public bool CanTransformMultipleBlocks => true;

    public bool CanReuseTransform => true;

    public void Dispose()
    {
    }

    public int TransformBlock(
      byte[] _param1,
      int _param2,
      int _param3,
      byte[] _param4,
      int _param5)
    {
      if (_param3 % 4 != 0)
        throw new ArgumentOutOfRangeException();
      int num1;
      if (true)
        num1 = 0;
      while (num1 < _param3)
      {
        byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
        byte[] numArray1 = _param1;
        int num2 = _param2 + num1;
        byte[] numArray2 = _param4;
        int num3 = _param5 + num1;
        int num4 = this.\u0023\u003DzOsmxM1I\u003D ? 1 : 0;
        if (true)
          goto label_6;
label_5:
        int num5 = num1 + 4;
        if (true)
        {
          num1 = num5;
          continue;
        }
        continue;
label_6:
        \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D.\u0023\u003DzfeGB2V4KYaRD8RDbwKoy9Z5VY_y\u00245VoIQs4hh0c5O6ou(zvDk75M, numArray1, num2, numArray2, num3, num4 != 0);
        goto label_5;
      }
      return _param3;
    }

    public byte[] TransformFinalBlock(byte[] _param1, int _param2, int _param3)
    {
      byte[] numArray1 = new byte[_param3];
      if (true)
        goto label_2;
label_1:
      byte[] numArray2;
      this.TransformBlock(_param1, _param2, _param3, numArray2, 0);
      return numArray2;
label_2:
      numArray2 = numArray1;
      goto label_1;
    }
  }
}
