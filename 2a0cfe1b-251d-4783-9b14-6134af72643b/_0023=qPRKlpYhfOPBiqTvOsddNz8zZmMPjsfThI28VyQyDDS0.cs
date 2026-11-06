// Decompiled with JetBrains decompiler
// Type: #=qPRKlpYhfOPBiqTvOsddNz8zZmMPjsfThI28VyQyDDS0=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

#nullable disable
internal sealed class \u0023\u003DqPRKlpYhfOPBiqTvOsddNz8zZmMPjsfThI28VyQyDDS0\u003D : 
  \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D,
  IDisposable
{
  private \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D \u0023\u003Dzv_DK75M\u003D;
  private byte[] \u0023\u003DzOsmxM1I\u003D;
  private readonly int \u0023\u003DzAElFq6M\u003D;
  private readonly int \u0023\u003DzhBh6D88\u003D;

  public \u0023\u003DqPRKlpYhfOPBiqTvOsddNz8zZmMPjsfThI28VyQyDDS0\u003D(
    \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D _param1)
  {
    if (_param1 == null)
      throw new ArgumentNullException();
    \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D pzUi1vgal1cJsctq = !_param1.\u0023\u003DzyVXFEBxLfXY6pdkUOUUG_Pww66hKya_jDpGGunJZXjSu() ? _param1 : throw new NotSupportedException();
    if (true)
      goto label_8;
label_5:
    byte[] numArray = new byte[_param1.\u0023\u003DzyWFI3vSTNmOhc14Xyi1erNdl2kN0y6Px5NBgvJtAFTpmpTrw4hH9aHQTyyz0MFI25KVkC\u0024c\u003D()];
    if (true)
      goto label_9;
label_6:
    int num = this.\u0023\u003Dz7byK1kWUbPwc3LW4_TfeNMnaq846U6pE1w\u003D\u003D();
    if (true)
      goto label_10;
label_7:
    this.\u0023\u003DzhBh6D88\u003D = this.\u0023\u003DzMnFQFN\u0024QrzZkM11qS\u0024QcDZAsBxvlaJzSW\u0024CSIFc\u003D();
    return;
label_10:
    this.\u0023\u003DzAElFq6M\u003D = num;
    goto label_7;
label_9:
    this.\u0023\u003DzOsmxM1I\u003D = numArray;
    goto label_6;
label_8:
    this.\u0023\u003Dzv_DK75M\u003D = pzUi1vgal1cJsctq;
    goto label_5;
  }

  private int \u0023\u003Dz7byK1kWUbPwc3LW4_TfeNMnaq846U6pE1w\u003D\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dz9nPncFm3EG2SxfRwi9oRRCfjr3F03Hf3atqy30osRUxhEaHgDxg5d5wFx4Pf0c3LllaiJl6sUDfjWZqxrQ\u003D\u003D();
  }

  private int \u0023\u003DzMnFQFN\u0024QrzZkM11qS\u0024QcDZAsBxvlaJzSW\u0024CSIFc\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzyWFI3vSTNmOhc14Xyi1erNdl2kN0y6Px5NBgvJtAFTpmpTrw4hH9aHQTyyz0MFI25KVkC\u0024c\u003D() - 10;
  }

  [CompilerGenerated]
  [SpecialName]
  public int \u0023\u003Dz9nPncFm3EG2SxfRwi9oRRCfjr3F03Hf3atqy30osRUxhEaHgDxg5d5wFx4Pf0c3LllaiJl6sUDfjWZqxrQ\u003D\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzAElFq6M\u003D;
  }

  [CompilerGenerated]
  [SpecialName]
  public int \u0023\u003DzyWFI3vSTNmOhc14Xyi1erNdl2kN0y6Px5NBgvJtAFTpmpTrw4hH9aHQTyyz0MFI25KVkC\u0024c\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzhBh6D88\u003D;
  }

  public int \u0023\u003DzMcp1j9HeFzOJtlfrJ79aMlkKYXTeLciLbkTjBenGOAT6pOmq6v8B9K\u00240TJVdV_I5Pj8GRwllj5snhj4t9wnEJZM\u003D(
    byte[] _param1,
    int _param2,
    int _param3,
    byte[] _param4,
    int _param5,
    RandomNumberGenerator _param6)
  {
    if (true)
      ;
    byte[] numArray1 = _param1;
    if (true)
      ;
    int num1 = _param2;
    if (true)
      ;
    int num2 = _param3;
    byte[] numArray2 = _param4;
    int num3 = _param5;
    RandomNumberGenerator randomNumberGenerator = _param6;
    return this.\u0023\u003DzowNJWzCeC_i0fuUTtIfVkmpBY5345FUD7jcwNPPyn\u00241S(numArray1, num1, num2, numArray2, num3, randomNumberGenerator);
  }

  private int \u0023\u003DzowNJWzCeC_i0fuUTtIfVkmpBY5345FUD7jcwNPPyn\u00241S(
    byte[] _param1,
    int _param2,
    int _param3,
    byte[] _param4,
    int _param5,
    RandomNumberGenerator _param6)
  {
    int num1 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzyWFI3vSTNmOhc14Xyi1erNdl2kN0y6Px5NBgvJtAFTpmpTrw4hH9aHQTyyz0MFI25KVkC\u0024c\u003D();
    if (true)
      goto label_4;
label_1:
    byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_5;
label_2:
    byte[] src;
    this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzMcp1j9HeFzOJtlfrJ79aMlkKYXTeLciLbkTjBenGOAT6pOmq6v8B9K\u00240TJVdV_I5Pj8GRwllj5snhj4t9wnEJZM\u003D(_param1, _param2, _param3, src, 0, _param6);
    int num2 = (int) src[0];
    int num3 = num2 != 2 ? 1 : 0;
    if (true)
      goto label_6;
label_3:
    int num4;
    int srcOffset = \u0023\u003DqPRKlpYhfOPBiqTvOsddNz8zZmMPjsfThI28VyQyDDS0\u003D.\u0023\u003Dz8LNm8mDP4mhc0IJiqavvPAOqenxY((byte) num2, src, 0, num4) + 1;
    bool flag;
    if (flag | srcOffset < 10)
      throw new InvalidOperationException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772625236));
    int count = num4 - srcOffset;
    Buffer.BlockCopy((Array) src, srcOffset, (Array) _param4, _param5, count);
    return count;
label_6:
    flag = num3 != 0;
    goto label_3;
label_5:
    src = zOsmxM1I;
    goto label_2;
label_4:
    num4 = num1;
    goto label_1;
  }

  private static int \u0023\u003Dz8LNm8mDP4mhc0IJiqavvPAOqenxY(
    byte _param0,
    byte[] _param1,
    int _param2,
    int _param3)
  {
    int num1 = _param2 + 1;
    int index;
    if (true)
      index = num1;
    while (index != _param2 + _param3)
    {
      if (_param1[index] == (byte) 0)
        return index;
      int num2 = index + 1;
      if (true)
        index = num2;
    }
    return -1;
  }

  public void Dispose()
  {
    if (this.\u0023\u003Dzv_DK75M\u003D == null)
      return;
    this.\u0023\u003Dzv_DK75M\u003D.Dispose();
    if (false)
      return;
    this.\u0023\u003Dzv_DK75M\u003D = (\u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D) null;
  }
}
