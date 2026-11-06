// Decompiled with JetBrains decompiler
// Type: #=qWXiM5IgM4IB0l6guG5SIS47oMmxD9T4jAexYk5zwE6Q=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Security.Cryptography;

#nullable disable
internal sealed class \u0023\u003DqWXiM5IgM4IB0l6guG5SIS47oMmxD9T4jAexYk5zwE6Q\u003D : DeriveBytes
{
  private byte[] \u0023\u003Dzv_DK75M\u003D;
  private byte[] \u0023\u003DzOsmxM1I\u003D;
  private int \u0023\u003DzAElFq6M\u003D;
  private readonly \u0023\u003DqtuMvwRMbpOd86cuUR3wb0qLv3NGr30SlWasBaI3MGiA\u003D \u0023\u003DzhBh6D88\u003D;
  private readonly byte[] \u0023\u003DzsIRkzxg\u003D;

  public \u0023\u003DqWXiM5IgM4IB0l6guG5SIS47oMmxD9T4jAexYk5zwE6Q\u003D(
    byte[] _param1,
    byte[] _param2,
    int _param3)
  {
    \u0023\u003DqtuMvwRMbpOd86cuUR3wb0qLv3NGr30SlWasBaI3MGiA\u003D ngr30SlWasBaI3MgiA = new \u0023\u003DqtuMvwRMbpOd86cuUR3wb0qLv3NGr30SlWasBaI3MGiA\u003D();
    if (true)
      goto label_2;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    if (_param1 == null)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622556));
    if (_param2 == null)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622497));
    if (_param3 < 1)
      throw new ArgumentException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622510));
    byte[] numArray1 = (byte[]) _param1.Clone();
    if (true)
      goto label_11;
label_9:
    byte[] numArray2 = (byte[]) _param2.Clone();
    if (true)
      goto label_12;
label_10:
    this.\u0023\u003DzAElFq6M\u003D = _param3;
    this.\u0023\u003DzsIRkzxg\u003D = new byte[this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzvcVxlbN816e0irqPkH\u0024YopevsRSs6xDh5Q\u003D\u003D()];
    return;
label_12:
    this.\u0023\u003DzOsmxM1I\u003D = numArray2;
    goto label_10;
label_11:
    this.\u0023\u003Dzv_DK75M\u003D = numArray1;
    goto label_9;
label_2:
    this.\u0023\u003DzhBh6D88\u003D = ngr30SlWasBaI3MgiA;
    goto label_1;
  }

  private void \u0023\u003Dzg_xVTckepi_1fEA_Gg\u003D\u003D(
    byte[] _param1,
    int _param2,
    byte[] _param3,
    byte[] _param4,
    int _param5)
  {
    if (_param1 != null)
      this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzQPVSGA1hoxsL_1m5_\u0024KM1eNmEApd(_param1, 0, _param1.Length);
    this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzQPVSGA1hoxsL_1m5_\u0024KM1eNmEApd(_param3, 0, _param3.Length);
    this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzOAd27jmHdLwiFLQfvJRwgUrXlnuPZehBY7L842U\u003D(this.\u0023\u003DzsIRkzxg\u003D, 0);
    byte[] zsIrkzxg = this.\u0023\u003DzsIRkzxg\u003D;
    byte[] dst = _param4;
    int dstOffset = _param5;
    int length = this.\u0023\u003DzsIRkzxg\u003D.Length;
    if (true)
      goto label_4;
label_3:
    int num;
    if (true)
      num = 1;
    for (; num < _param2; ++num)
    {
      this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzQPVSGA1hoxsL_1m5_\u0024KM1eNmEApd(this.\u0023\u003DzsIRkzxg\u003D, 0, this.\u0023\u003DzsIRkzxg\u003D.Length);
      this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzOAd27jmHdLwiFLQfvJRwgUrXlnuPZehBY7L842U\u003D(this.\u0023\u003DzsIRkzxg\u003D, 0);
      int index;
      if (true)
        index = 0;
      for (; index < this.\u0023\u003DzsIRkzxg\u003D.Length; ++index)
        _param4[_param5 + index] ^= this.\u0023\u003DzsIRkzxg\u003D[index];
    }
    return;
label_4:
    Buffer.BlockCopy((Array) zsIrkzxg, 0, (Array) dst, dstOffset, length);
    goto label_3;
  }

  public override byte[] GetBytes(int _param1)
  {
    int num1 = this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzvcVxlbN816e0irqPkH\u0024YopevsRSs6xDh5Q\u003D\u003D();
    if (true)
      goto label_4;
label_1:
    int num2;
    int num3 = (_param1 + num2 - 1) / num2;
    if (true)
      goto label_5;
label_2:
    byte[] numArray1 = new byte[4];
    if (true)
      goto label_6;
label_3:
    int num4;
    byte[] src = new byte[num4 * num2];
    int num5 = 0;
    this.\u0023\u003DzhBh6D88\u003D.\u0023\u003Dz4Gdf\u0024uJft_R0pJCXrf2gjApLe8et(this.\u0023\u003Dzv_DK75M\u003D);
    byte[] numArray2;
    for (int index1 = 1; index1 <= num4; ++index1)
    {
      int index2 = 3;
      while (++numArray2[index2] == (byte) 0)
        --index2;
      this.\u0023\u003Dzg_xVTckepi_1fEA_Gg\u003D\u003D(this.\u0023\u003DzOsmxM1I\u003D, this.\u0023\u003DzAElFq6M\u003D, numArray2, src, num5);
      num5 += num2;
    }
    if (_param1 < src.Length)
    {
      byte[] dst = new byte[_param1];
      Buffer.BlockCopy((Array) src, 0, (Array) dst, 0, _param1);
      src = dst;
    }
    return src;
label_6:
    numArray2 = numArray1;
    goto label_3;
label_5:
    num4 = num3;
    goto label_2;
label_4:
    num2 = num1;
    goto label_1;
  }

  public override void Reset() => throw new NotSupportedException();
}
