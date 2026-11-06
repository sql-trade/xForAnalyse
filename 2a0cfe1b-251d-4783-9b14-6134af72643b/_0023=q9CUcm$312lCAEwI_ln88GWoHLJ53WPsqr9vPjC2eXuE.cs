// Decompiled with JetBrains decompiler
// Type: #=q9CUcm$312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
internal sealed class \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D
{
  private static readonly int[] \u0023\u003Dzv_DK75M\u003D;
  public static readonly \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003DzOsmxM1I\u003D;
  public static readonly \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003DzAElFq6M\u003D;
  private static readonly byte[] \u0023\u003DzhBh6D88\u003D;
  private int[] \u0023\u003DzsIRkzxg\u003D;
  private int \u0023\u003DzQvRsjjA\u003D;
  private int \u0023\u003DzlrX5m0o\u003D;
  private int \u0023\u003DzDnwpn_c\u003D;

  static \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D()
  {
    int[] numArray1 = Array.Empty<int>();
    if (true)
      goto label_4;
label_1:
    byte[] numArray2 = new byte[256 /*0x0100*/];
    // ISSUE: field reference
    RuntimeFieldHandle fldHandle = __fieldref (\u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AIviALitMCSCbJxropfq0yw\u003D.\u0023\u003Dzv_DK75M\u003D);
    if (true)
      goto label_5;
label_2:
    if (true)
      goto label_6;
label_3:
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzOsmxM1I\u003D = new \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(0, \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzv_DK75M\u003D, false);
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzOsmxM1I\u003D.\u0023\u003DzlrX5m0o\u003D = 0;
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzAElFq6M\u003D = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzrx\u002470FOZNDufe_iMFpccZWDmxetFyA3cuQ\u003D\u003D(1UL);
    return;
label_6:
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzhBh6D88\u003D = numArray2;
    goto label_3;
label_5:
    RuntimeHelpers.InitializeArray((Array) numArray2, fldHandle);
    goto label_2;
label_4:
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzv_DK75M\u003D = numArray1;
    goto label_1;
  }

  public \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(
    int _param1,
    int[] _param2,
    bool _param3)
  {
    if (true)
      goto label_2;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    if (_param3)
    {
      int sourceIndex;
      if (true)
        sourceIndex = 0;
      while (sourceIndex < _param2.Length && _param2[sourceIndex] == 0)
      {
        int num = sourceIndex + 1;
        if (true)
          sourceIndex = num;
      }
      if (sourceIndex == _param2.Length)
      {
        this.\u0023\u003DzQvRsjjA\u003D = 0;
        this.\u0023\u003DzsIRkzxg\u003D = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzv_DK75M\u003D;
        return;
      }
      this.\u0023\u003DzQvRsjjA\u003D = _param1;
      if (sourceIndex == 0)
      {
        this.\u0023\u003DzsIRkzxg\u003D = _param2;
        return;
      }
      this.\u0023\u003DzsIRkzxg\u003D = new int[_param2.Length - sourceIndex];
      Array.Copy((Array) _param2, sourceIndex, (Array) this.\u0023\u003DzsIRkzxg\u003D, 0, this.\u0023\u003DzsIRkzxg\u003D.Length);
      return;
    }
    this.\u0023\u003DzQvRsjjA\u003D = _param1;
    this.\u0023\u003DzsIRkzxg\u003D = _param2;
    return;
label_2:
    this.\u0023\u003DzlrX5m0o\u003D = -1;
    goto label_1;
  }

  public \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(
    int _param1,
    byte[] _param2)
  {
    if (true)
      ;
    int num = _param1;
    if (true)
      ;
    byte[] numArray = _param2;
    if (true)
      ;
    int length = _param2.Length;
    // ISSUE: explicit constructor call
    this.\u002Ector(num, numArray, 0, length);
  }

  public \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(
    int _param1,
    byte[] _param2,
    int _param3,
    int _param4)
  {
    if (true)
      goto label_2;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    if (_param1 == 0)
    {
      if (true)
        goto label_6;
label_4:
      int[] zvDk75M = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzv_DK75M\u003D;
      if (false)
        return;
      this.\u0023\u003DzsIRkzxg\u003D = zvDk75M;
      return;
label_6:
      this.\u0023\u003DzQvRsjjA\u003D = 0;
      goto label_4;
    }
    this.\u0023\u003DzsIRkzxg\u003D = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz99tzl\u0024e2GM0nyTtPuADYtFM\u003D(_param2, _param3, _param4);
    this.\u0023\u003DzQvRsjjA\u003D = this.\u0023\u003DzsIRkzxg\u003D.Length < 1 ? 0 : _param1;
    return;
label_2:
    this.\u0023\u003DzlrX5m0o\u003D = -1;
    goto label_1;
  }

  public int[] \u0023\u003DzeFvCiahFxm6HyZ\u0024_Zri3HCWOUi\u0024i()
  {
    if (true)
      ;
    return this.\u0023\u003DzsIRkzxg\u003D;
  }

  private static int \u0023\u003DzopC65qbyKgh0utCQa_q0c8SJyQxcYTMAMH6\u0024nzjv6g31(int _param0)
  {
    int num = _param0;
    if (true)
      ;
    return (num + 8 - 1) / 8;
  }

  private static int[] \u0023\u003Dz99tzl\u0024e2GM0nyTtPuADYtFM\u003D(
    byte[] _param0,
    int _param1,
    int _param2)
  {
    int num1 = _param1 + _param2;
    if (true)
      goto label_2;
label_1:
    int num2 = _param1;
    int index1;
    if (true)
      index1 = num2;
    int num3;
    while (index1 < num3 && _param0[index1] == (byte) 0)
    {
      int num4 = index1 + 1;
      if (true)
        index1 = num4;
    }
    if (index1 >= num3)
      return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzv_DK75M\u003D;
    int length = (num3 - index1 + 3) / 4;
    int num5 = (num3 - index1) % 4;
    if (num5 == 0)
      num5 = 4;
    if (length < 1)
      return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzv_DK75M\u003D;
    int[] numArray = new int[length];
    int num6 = 0;
    int index2 = 0;
    for (int index3 = index1; index3 < num3; ++index3)
    {
      num6 = num6 << 8 | (int) _param0[index3] & (int) byte.MaxValue;
      --num5;
      if (num5 <= 0)
      {
        numArray[index2] = num6;
        ++index2;
        num5 = 4;
        num6 = 0;
      }
    }
    if (index2 < numArray.Length)
      numArray[index2] = num6;
    return numArray;
label_2:
    num3 = num1;
    goto label_1;
  }

  private static int \u0023\u003DzxUwcAO94JEVbnJx3lUffKPkfDP37(
    int _param0,
    int _param1,
    int[] _param2)
  {
    while (_param1 < _param2.Length)
    {
      if (_param2[_param1] == 0)
      {
        int num = _param1 + 1;
        if (true)
          _param1 = num;
      }
      else
      {
        int num1 = 32 /*0x20*/ * (_param2.Length - _param1 - 1);
        int num2 = _param2[_param1];
        if (true)
          goto label_7;
label_6:
        int num3;
        int num4 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz5WY5cPzK12Q_Vuq0eXyfSBqstMqf(num3);
        return num1 + num4;
label_7:
        num3 = num2;
        goto label_6;
      }
    }
    return 0;
  }

  public int \u0023\u003DzAjJbjbfVsnq4ZrdywTuyL9vODPi5()
  {
    if (true)
      ;
    if (this.\u0023\u003DzlrX5m0o\u003D == -1)
    {
      if (true)
        ;
      if (true)
        ;
      this.\u0023\u003DzlrX5m0o\u003D = this.\u0023\u003DzQvRsjjA\u003D == 0 ? 0 : \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzxUwcAO94JEVbnJx3lUffKPkfDP37(this.\u0023\u003DzQvRsjjA\u003D, 0, this.\u0023\u003DzsIRkzxg\u003D);
    }
    return this.\u0023\u003DzlrX5m0o\u003D;
  }

  private static int \u0023\u003Dz5WY5cPzK12Q_Vuq0eXyfSBqstMqf(int _param0)
  {
    int num1 = _param0;
    if (true)
      goto label_3;
label_1:
    uint index1;
    int num2 = (int) (index1 >> 24);
    if (true)
      goto label_4;
label_2:
    uint index2;
    if (index2 != 0U)
      return 24 + (int) \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzhBh6D88\u003D[(int) index2];
    int num3 = (int) (index1 >> 16 /*0x10*/);
    if (true)
      goto label_8;
label_7:
    if (index2 != 0U)
      return 16 /*0x10*/ + (int) \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzhBh6D88\u003D[(int) index2];
    uint index3 = index1 >> 8;
    return index3 != 0U ? 8 + (int) \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzhBh6D88\u003D[(int) index3] : (int) \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzhBh6D88\u003D[(int) index1];
label_8:
    index2 = (uint) num3;
    goto label_7;
label_4:
    index2 = (uint) num2;
    goto label_2;
label_3:
    index1 = (uint) num1;
    goto label_1;
  }

  public int \u0023\u003Dz5GDqD2H2eHIMk\u0024X9zF4yxiCYAaAU_7l4qYhX0da1PbOE(object _param1)
  {
    if (true)
      ;
    object obj = _param1;
    if (true)
      ;
    return this.\u0023\u003DzqQlhvSuOh2TIWBRo\u0024qZo1BU59Hw_\u0024uSKqwvn8VQ\u003D((\u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D) obj);
  }

  private static int \u0023\u003DzZYKH28p_jLPnVxSpQmWk7TRcZh9jJZ3pnDjj_GnLctuc(
    int _param0,
    int[] _param1,
    int _param2,
    int[] _param3)
  {
    while (_param0 != _param1.Length && _param1[_param0] == 0)
    {
      int num = _param0 + 1;
      if (true)
        _param0 = num;
    }
    while (_param2 != _param3.Length && _param3[_param2] == 0)
    {
      int num = _param2 + 1;
      if (true)
        _param2 = num;
    }
    return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz3ceLNBGXSSc_4Kp6KtEwy8w\u003D(_param0, _param1, _param2, _param3);
  }

  private static int \u0023\u003Dz3ceLNBGXSSc_4Kp6KtEwy8w\u003D(
    int _param0,
    int[] _param1,
    int _param2,
    int[] _param3)
  {
    int num1 = _param1.Length - _param3.Length - (_param0 - _param2);
    if (true)
      goto label_2;
label_1:
    int num2;
    if (num2 != 0)
      return num2 >= 0 ? 1 : -1;
    while (_param0 < _param1.Length)
    {
      int[] numArray = _param1;
      int index = _param0;
      int num3 = index + 1;
      if (true)
        goto label_9;
label_7:
      int num4 = numArray[index];
      if (true)
        goto label_10;
label_8:
      uint num5 = (uint) _param3[_param2++];
      uint num6;
      if ((int) num6 != (int) num5)
        return num6 >= num5 ? 1 : -1;
      continue;
label_10:
      num6 = (uint) num4;
      goto label_8;
label_9:
      _param0 = num3;
      goto label_7;
    }
    return 0;
label_2:
    num2 = num1;
    goto label_1;
  }

  public int \u0023\u003DzqQlhvSuOh2TIWBRo\u0024qZo1BU59Hw_\u0024uSKqwvn8VQ\u003D(
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D _param1)
  {
    if (true)
      ;
    int zQvRsjjA1 = this.\u0023\u003DzQvRsjjA\u003D;
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE = _param1;
    if (true)
      ;
    int zQvRsjjA2 = j53Wpsqr9vPjC2eXuE.\u0023\u003DzQvRsjjA\u003D;
    if (zQvRsjjA1 < zQvRsjjA2)
      return -1;
    if (true)
      ;
    if (this.\u0023\u003DzQvRsjjA\u003D > _param1.\u0023\u003DzQvRsjjA\u003D)
      return 1;
    return this.\u0023\u003DzQvRsjjA\u003D != 0 ? this.\u0023\u003DzQvRsjjA\u003D * \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz3ceLNBGXSSc_4Kp6KtEwy8w\u003D(0, this.\u0023\u003DzsIRkzxg\u003D, 0, _param1.\u0023\u003DzsIRkzxg\u003D) : 0;
  }

  public override bool Equals(object _param1)
  {
    if (_param1 == this)
      return true;
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE1 = _param1 as \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D;
    if (true)
      goto label_4;
label_3:
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE2;
    return j53Wpsqr9vPjC2eXuE2 != null && this.\u0023\u003DzQvRsjjA\u003D == j53Wpsqr9vPjC2eXuE2.\u0023\u003DzQvRsjjA\u003D && this.\u0023\u003Dzmh9r8PpCbcrZo6fyPYesLq0\u003D(j53Wpsqr9vPjC2eXuE2);
label_4:
    j53Wpsqr9vPjC2eXuE2 = j53Wpsqr9vPjC2eXuE1;
    goto label_3;
  }

  public override int GetHashCode()
  {
    int length = this.\u0023\u003DzsIRkzxg\u003D.Length;
    if (true)
      goto label_2;
label_1:
    int hashCode;
    if (this.\u0023\u003DzsIRkzxg\u003D.Length != 0)
    {
      int num1 = hashCode ^ this.\u0023\u003DzsIRkzxg\u003D[0];
      if (true)
        goto label_5;
label_4:
      if (this.\u0023\u003DzsIRkzxg\u003D.Length > 1)
      {
        int num2 = hashCode ^ this.\u0023\u003DzsIRkzxg\u003D[this.\u0023\u003DzsIRkzxg\u003D.Length - 1];
        if (true)
        {
          hashCode = num2;
          goto label_8;
        }
        goto label_8;
      }
      goto label_8;
label_5:
      hashCode = num1;
      goto label_4;
    }
label_8:
    return hashCode;
label_2:
    hashCode = length;
    goto label_1;
  }

  private bool \u0023\u003Dzmh9r8PpCbcrZo6fyPYesLq0\u003D(
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D _param1)
  {
    int[] zsIrkzxg = _param1.\u0023\u003DzsIRkzxg\u003D;
    if (this.\u0023\u003DzsIRkzxg\u003D.Length != _param1.\u0023\u003DzsIRkzxg\u003D.Length)
      return false;
    int index;
    if (true)
      index = 0;
    while (index < this.\u0023\u003DzsIRkzxg\u003D.Length)
    {
      if (this.\u0023\u003DzsIRkzxg\u003D[index] != _param1.\u0023\u003DzsIRkzxg\u003D[index])
        return false;
      int num = index + 1;
      if (true)
        index = num;
    }
    return true;
  }

  public \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003DzpDcdzGaGyziIggkUkXOW7W4Dt8j1FpI8Ww\u003D\u003D(
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D _param1,
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D _param2)
  {
    if (_param2.Equals((object) \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzAElFq6M\u003D))
      return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzOsmxM1I\u003D;
    if (_param1.\u0023\u003DzQvRsjjA\u003D == 0)
      return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzAElFq6M\u003D;
    if (this.\u0023\u003DzQvRsjjA\u003D == 0)
      return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_8;
label_7:
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE1;
    if (!_param1.Equals((object) \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzAElFq6M\u003D))
    {
      \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE2 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzkOLqx7cNtkCtoLk9hOeIRBo\u003D(j53Wpsqr9vPjC2eXuE1, _param1.\u0023\u003DzsIRkzxg\u003D[0], _param2);
      if (true)
        j53Wpsqr9vPjC2eXuE1 = j53Wpsqr9vPjC2eXuE2;
    }
    return j53Wpsqr9vPjC2eXuE1;
label_8:
    j53Wpsqr9vPjC2eXuE1 = this;
    goto label_7;
  }

  private static \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003DzkOLqx7cNtkCtoLk9hOeIRBo\u003D(
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D _param0,
    int _param1,
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D _param2)
  {
    int length1 = _param2.\u0023\u003DzsIRkzxg\u003D.Length;
    if (true)
      goto label_5;
label_1:
    int length2;
    int num1 = 32 /*0x20*/ * length2;
    if (true)
      goto label_6;
label_2:
    int num2;
    int num3 = _param2.\u0023\u003DzAjJbjbfVsnq4ZrdywTuyL9vODPi5() + 2 <= num2 ? 1 : 0;
    if (true)
      goto label_7;
label_3:
    int num4 = _param2.\u0023\u003DzUVi7\u0024lNj9s\u0024ugCHWMJnHSmA\u003D();
    if (true)
      goto label_8;
label_4:
    _param0 = _param0.\u0023\u003Dz\u00241rj\u0024kbiClSNMGXTUkvSfCgzj\u0024F21UALdg\u003D\u003D(num2).\u0023\u003DzBh7JT2pKputLB8eFCHM1Wm7C97DCBp9EuA\u003D\u003D(_param2);
    int[] numArray1 = new int[length2 + 1];
    int[] src = _param0.\u0023\u003DzsIRkzxg\u003D;
    if (src.Length < length2)
    {
      int[] dst = new int[length2];
      Buffer.BlockCopy((Array) src, 0, (Array) dst, length2 - src.Length, src.Length * 4);
      src = dst;
    }
    int[] numArray2 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzwN0ur\u0024dhXu2QYgPgPIkSZkQ\u003D(src);
    bool flag;
    uint num5;
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzwOH43xE9iIIpRcGjkYU76IeD3hsc\u0024cX4qwhiAOhvmsQC(numArray1, numArray2, _param2.\u0023\u003DzsIRkzxg\u003D, num5, flag);
    int[] numArray3 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzEvT3pJfv4ggJzF_pTcckkOc\u003D(_param1);
    int num6 = (numArray3[0] >> 8) - 1;
    int num7 = 1;
    while (true)
    {
      int[] numArray4 = numArray3;
      int index1 = num7++;
      int num8;
      if ((num8 = numArray4[index1]) != -1)
      {
        int num9 = num6 + 1;
        for (int index2 = 0; index2 < num9; ++index2)
          \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzwOH43xE9iIIpRcGjkYU76IeD3hsc\u0024cX4qwhiAOhvmsQC(numArray1, numArray2, _param2.\u0023\u003DzsIRkzxg\u003D, num5, flag);
        \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzT8QS\u0024wcVK3iKPa39UC71Es8\u003D(numArray1, numArray2, src, _param2.\u0023\u003DzsIRkzxg\u003D, num5, flag);
        num6 = num8 >> 8;
      }
      else
        break;
    }
    for (int index = 0; index < num6; ++index)
      \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzwOH43xE9iIIpRcGjkYU76IeD3hsc\u0024cX4qwhiAOhvmsQC(numArray1, numArray2, _param2.\u0023\u003DzsIRkzxg\u003D, num5, flag);
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzbrbRzDyD24gljs9bOC19ytw\u003D(numArray2, _param2.\u0023\u003DzsIRkzxg\u003D, num5);
    return new \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(1, numArray2, true);
label_8:
    num5 = (uint) num4;
    goto label_4;
label_7:
    flag = num3 != 0;
    goto label_3;
label_6:
    num2 = num1;
    goto label_2;
label_5:
    length2 = length1;
    goto label_1;
  }

  private static int \u0023\u003DzBM5SA5vXRcfWMVtel\u00247ylgi_KVHz(int _param0)
  {
    int num1 = _param0 + ((_param0 + 1 & 4) << 1);
    if (true)
      goto label_4;
label_1:
    int num2;
    int num3 = num2 * (2 - _param0 * num2);
    if (true)
      goto label_5;
label_2:
    int num4 = num2 * (2 - _param0 * num2);
    if (true)
      goto label_6;
label_3:
    return num2 * (2 - _param0 * num2);
label_6:
    num2 = num4;
    goto label_3;
label_5:
    num2 = num3;
    goto label_2;
label_4:
    num2 = num1;
    goto label_1;
  }

  private int \u0023\u003DzUVi7\u0024lNj9s\u0024ugCHWMJnHSmA\u003D()
  {
    if (this.\u0023\u003DzDnwpn_c\u003D != 0)
      return this.\u0023\u003DzDnwpn_c\u003D;
    int num1 = -this.\u0023\u003DzsIRkzxg\u003D[this.\u0023\u003DzsIRkzxg\u003D.Length - 1];
    if (true)
      goto label_6;
label_3:
    int num2;
    int num3 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzBM5SA5vXRcfWMVtel\u00247ylgi_KVHz(num2);
    if (true)
      goto label_7;
label_4:
    if (true)
      goto label_8;
label_5:
    int num4;
    return num4;
label_8:
    this.\u0023\u003DzDnwpn_c\u003D = num3;
    goto label_5;
label_7:
    num4 = num3;
    goto label_4;
label_6:
    num2 = num1;
    goto label_3;
  }

  private static void \u0023\u003DzbrbRzDyD24gljs9bOC19ytw\u003D(
    int[] _param0,
    int[] _param1,
    uint _param2)
  {
    int length = _param1.Length;
    if (true)
      goto label_3;
label_1:
    int num1;
    int num2 = num1 - 1;
    int num3;
    if (true)
      num3 = num2;
    for (; num3 >= 0; --num3)
    {
      int num4 = _param0[num1 - 1];
      if (true)
        goto label_7;
label_6:
      uint num5;
      ulong num6 = (ulong) (num5 * _param2);
      ulong num7 = num6 * (ulong) (uint) _param1[num1 - 1] + (ulong) num5 >> 32 /*0x20*/;
      for (int index = num1 - 2; index >= 0; --index)
      {
        ulong num8 = num7 + (num6 * (ulong) (uint) _param1[index] + (ulong) (uint) _param0[index]);
        _param0[index + 1] = (int) num8;
        num7 = num8 >> 32 /*0x20*/;
      }
      _param0[0] = (int) num7;
      continue;
label_7:
      num5 = (uint) num4;
      goto label_6;
    }
    if (\u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzZYKH28p_jLPnVxSpQmWk7TRcZh9jJZ3pnDjj_GnLctuc(0, _param0, 0, _param1) < 0)
      return;
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzvQnToYzojDvBN\u00249oQ4jgPK7WBnV2(0, _param0, 0, _param1);
    return;
label_3:
    num1 = length;
    goto label_1;
  }

  private static void \u0023\u003DzT8QS\u0024wcVK3iKPa39UC71Es8\u003D(
    int[] _param0,
    int[] _param1,
    int[] _param2,
    int[] _param3,
    uint _param4,
    bool _param5)
  {
    int length1 = _param3.Length;
    if (true)
      goto label_2;
label_1:
    int length2;
    if (length2 == 1)
    {
      _param1[0] = (int) \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzEwlV4rtoJ29h3Q5f2ZeIsv\u0024hWOiX((uint) _param1[0], (uint) _param2[0], (uint) _param3[0], _param4);
      return;
    }
    int num1 = _param2[length2 - 1];
    if (true)
      goto label_12;
label_5:
    long num2 = (long) (uint) _param1[length2 - 1];
    if (true)
      goto label_13;
label_6:
    ulong num3;
    uint num4;
    long num5 = (long) num3 * (long) num4;
    if (true)
      goto label_14;
label_7:
    ulong num6;
    long num7 = (long) ((uint) num6 * _param4);
    if (true)
      goto label_15;
label_8:
    ulong num8;
    long num9 = (long) num8 * (long) (uint) _param3[length2 - 1];
    if (true)
      goto label_16;
label_9:
    ulong num10;
    long num11 = (long) num6 + (long) (uint) num10;
    if (true)
      goto label_17;
label_10:
    long num12 = (long) (num6 >> 32 /*0x20*/) + (long) (num10 >> 32 /*0x20*/);
    if (true)
      goto label_18;
label_11:
    int num13 = length2 - 2;
    int index1;
    if (true)
      index1 = num13;
    for (; index1 >= 0; --index1)
    {
      ulong num14 = num3 * (ulong) (uint) _param2[index1];
      ulong num15 = num8 * (ulong) (uint) _param3[index1];
      ulong num16 = num6 + ((num14 & (ulong) uint.MaxValue) + (ulong) (uint) num15);
      _param0[index1 + 2] = (int) num16;
      num6 = (num16 >> 32 /*0x20*/) + (num14 >> 32 /*0x20*/) + (num15 >> 32 /*0x20*/);
    }
    _param0[1] = (int) num6;
    int num17 = (int) (num6 >> 32 /*0x20*/);
    for (int index2 = length2 - 2; index2 >= 0; --index2)
    {
      uint num18 = (uint) _param0[length2];
      ulong num19 = (ulong) (uint) _param1[index2];
      ulong num20 = num19 * (ulong) num4;
      ulong num21 = (num20 & (ulong) uint.MaxValue) + (ulong) num18;
      ulong num22 = (ulong) ((uint) num21 * _param4);
      ulong num23 = num22 * (ulong) (uint) _param3[length2 - 1];
      ulong num24 = (num21 + (ulong) (uint) num23 >> 32 /*0x20*/) + (num20 >> 32 /*0x20*/) + (num23 >> 32 /*0x20*/);
      for (int index3 = length2 - 2; index3 >= 0; --index3)
      {
        ulong num25 = num19 * (ulong) (uint) _param2[index3];
        ulong num26 = num22 * (ulong) (uint) _param3[index3];
        ulong num27 = num24 + ((num25 & (ulong) uint.MaxValue) + (ulong) (uint) num26 + (ulong) (uint) _param0[index3 + 1]);
        _param0[index3 + 2] = (int) num27;
        num24 = (num27 >> 32 /*0x20*/) + (num25 >> 32 /*0x20*/) + (num26 >> 32 /*0x20*/);
      }
      ulong num28 = num24 + (ulong) (uint) num17;
      _param0[1] = (int) num28;
      num17 = (int) (num28 >> 32 /*0x20*/);
    }
    _param0[0] = num17;
    if (!_param5 && \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzZYKH28p_jLPnVxSpQmWk7TRcZh9jJZ3pnDjj_GnLctuc(0, _param0, 0, _param3) >= 0)
      \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzvQnToYzojDvBN\u00249oQ4jgPK7WBnV2(0, _param0, 0, _param3);
    Array.Copy((Array) _param0, 1, (Array) _param1, 0, length2);
    return;
label_18:
    num6 = (ulong) num12;
    goto label_11;
label_17:
    num6 = (ulong) num11;
    goto label_10;
label_16:
    num10 = (ulong) num9;
    goto label_9;
label_15:
    num8 = (ulong) num7;
    goto label_8;
label_14:
    num6 = (ulong) num5;
    goto label_7;
label_13:
    num3 = (ulong) num2;
    goto label_6;
label_12:
    num4 = (uint) num1;
    goto label_5;
label_2:
    length2 = length1;
    goto label_1;
  }

  private static void \u0023\u003DzwOH43xE9iIIpRcGjkYU76IeD3hsc\u0024cX4qwhiAOhvmsQC(
    int[] _param0,
    int[] _param1,
    int[] _param2,
    uint _param3,
    bool _param4)
  {
    int length1 = _param2.Length;
    if (true)
      goto label_2;
label_1:
    int length2;
    if (length2 == 1)
    {
      int num1 = _param1[0];
      if (true)
        goto label_5;
label_4:
      uint num2;
      _param1[0] = (int) \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzEwlV4rtoJ29h3Q5f2ZeIsv\u0024hWOiX(num2, num2, (uint) _param2[0], _param3);
      return;
label_5:
      num2 = (uint) num1;
      goto label_4;
    }
    long num3 = (long) (uint) _param1[length2 - 1];
    if (true)
      goto label_13;
label_7:
    ulong num4;
    long num5 = (long) num4 * (long) num4;
    if (true)
      goto label_14;
label_8:
    ulong num6;
    long num7 = (long) ((uint) num6 * _param3);
    if (true)
      goto label_15;
label_9:
    ulong num8;
    long num9 = (long) num8 * (long) (uint) _param2[length2 - 1];
    if (true)
      goto label_16;
label_10:
    ulong num10;
    long num11 = (long) num6 + (long) (uint) num10;
    if (true)
      goto label_17;
label_11:
    long num12 = (long) (num6 >> 32 /*0x20*/) + (long) (num10 >> 32 /*0x20*/);
    if (true)
      goto label_18;
label_12:
    int num13 = length2 - 2;
    int index1;
    if (true)
      index1 = num13;
    for (; index1 >= 0; --index1)
    {
      long num14 = (long) num4 * (long) (uint) _param1[index1];
      if (true)
        goto label_22;
label_21:
      ulong num15 = num8 * (ulong) (uint) _param2[index1];
      ulong num16;
      ulong num17 = num6 + ((num15 & (ulong) uint.MaxValue) + (ulong) ((uint) num16 << 1));
      _param0[index1 + 2] = (int) num17;
      num6 = (num17 >> 32 /*0x20*/) + (num16 >> 31 /*0x1F*/) + (num15 >> 32 /*0x20*/);
      continue;
label_22:
      num16 = (ulong) num14;
      goto label_21;
    }
    _param0[1] = (int) num6;
    int num18 = (int) (num6 >> 32 /*0x20*/);
    for (int index2 = length2 - 2; index2 >= 0; --index2)
    {
      uint num19 = (uint) _param0[length2];
      ulong num20 = (ulong) (num19 * _param3);
      ulong num21 = num20 * (ulong) (uint) _param2[length2 - 1] + (ulong) num19 >> 32 /*0x20*/;
      for (int index3 = length2 - 2; index3 > index2; --index3)
      {
        ulong num22 = num21 + (num20 * (ulong) (uint) _param2[index3] + (ulong) (uint) _param0[index3 + 1]);
        _param0[index3 + 2] = (int) num22;
        num21 = num22 >> 32 /*0x20*/;
      }
      ulong num23 = (ulong) (uint) _param1[index2];
      ulong num24 = num23 * num23;
      ulong num25 = num20 * (ulong) (uint) _param2[index2];
      ulong num26 = num21 + ((num24 & (ulong) uint.MaxValue) + (ulong) (uint) num25 + (ulong) (uint) _param0[index2 + 1]);
      _param0[index2 + 2] = (int) num26;
      ulong num27 = (num26 >> 32 /*0x20*/) + (num24 >> 32 /*0x20*/) + (num25 >> 32 /*0x20*/);
      for (int index4 = index2 - 1; index4 >= 0; --index4)
      {
        ulong num28 = num23 * (ulong) (uint) _param1[index4];
        ulong num29 = num20 * (ulong) (uint) _param2[index4];
        ulong num30 = num27 + ((num29 & (ulong) uint.MaxValue) + (ulong) ((uint) num28 << 1) + (ulong) (uint) _param0[index4 + 1]);
        _param0[index4 + 2] = (int) num30;
        num27 = (num30 >> 32 /*0x20*/) + (num28 >> 31 /*0x1F*/) + (num29 >> 32 /*0x20*/);
      }
      ulong num31 = num27 + (ulong) (uint) num18;
      _param0[1] = (int) num31;
      num18 = (int) (num31 >> 32 /*0x20*/);
    }
    _param0[0] = num18;
    if (!_param4 && \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzZYKH28p_jLPnVxSpQmWk7TRcZh9jJZ3pnDjj_GnLctuc(0, _param0, 0, _param2) >= 0)
      \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzvQnToYzojDvBN\u00249oQ4jgPK7WBnV2(0, _param0, 0, _param2);
    Array.Copy((Array) _param0, 1, (Array) _param1, 0, length2);
    return;
label_18:
    num6 = (ulong) num12;
    goto label_12;
label_17:
    num6 = (ulong) num11;
    goto label_11;
label_16:
    num10 = (ulong) num9;
    goto label_10;
label_15:
    num8 = (ulong) num7;
    goto label_9;
label_14:
    num6 = (ulong) num5;
    goto label_8;
label_13:
    num4 = (ulong) num3;
    goto label_7;
label_2:
    length2 = length1;
    goto label_1;
  }

  private static uint \u0023\u003DzEwlV4rtoJ29h3Q5f2ZeIsv\u0024hWOiX(
    uint _param0,
    uint _param1,
    uint _param2,
    uint _param3)
  {
    long num1 = (long) _param0 * (long) _param1;
    if (true)
      goto label_4;
label_1:
    ulong num2;
    int num3 = (int) (uint) num2 * (int) _param3;
    if (true)
      goto label_5;
label_2:
    long num4 = (long) _param2;
    if (true)
      goto label_6;
label_3:
    ulong num5;
    uint num6;
    ulong num7 = num5 * (ulong) num6;
    ulong num8 = (num2 + (ulong) (uint) num7 >> 32 /*0x20*/) + (num7 >> 32 /*0x20*/);
    if (num8 > num5)
      num8 -= num5;
    return (uint) num8;
label_6:
    num5 = (ulong) num4;
    goto label_3;
label_5:
    num6 = (uint) num3;
    goto label_2;
label_4:
    num2 = (ulong) num1;
    goto label_1;
  }

  private static int[] \u0023\u003DzEvT3pJfv4ggJzF_pTcckkOc\u003D(int _param0)
  {
    int num1 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz5WY5cPzK12Q_Vuq0eXyfSBqstMqf(_param0);
    if (true)
      goto label_4;
label_1:
    int num2;
    int[] numArray1 = new int[num2 + 2];
    if (true)
      goto label_5;
label_2:
    if (true)
      goto label_6;
label_3:
    int num3 = 33 - num2;
    _param0 <<= num3;
    int num4 = 0;
    int[] numArray2;
    int num5;
    for (; num3 < 32 /*0x20*/; ++num3)
    {
      if (_param0 < 0)
      {
        numArray2[num5++] = 1 | num4 << 8;
        num4 = 0;
      }
      else
        ++num4;
      _param0 <<= 1;
    }
    int[] numArray3 = numArray2;
    int index1 = num5;
    int index2 = index1 + 1;
    int num6 = 1 | num4 << 8;
    numArray3[index1] = num6;
    numArray2[index2] = -1;
    return numArray2;
label_6:
    num5 = 0;
    goto label_3;
label_5:
    numArray2 = numArray1;
    goto label_2;
label_4:
    num2 = num1;
    goto label_1;
  }

  private static int[] \u0023\u003DzX5cyxTQ15yzKEzDH17sWMwqUgAhxXM20ko8apDM\u003D(
    int[] _param0,
    int _param1)
  {
    int num1 = _param1 >>> 5;
    if (true)
      goto label_4;
label_1:
    int num2 = _param1 & 31 /*0x1F*/;
    if (true)
      goto label_5;
label_2:
    int length = _param0.Length;
    if (true)
      goto label_6;
label_3:
    int num3;
    int num4;
    int num5;
    int[] numArray;
    if (num3 == 0)
    {
      numArray = new int[num5 + num4];
      _param0.CopyTo((Array) numArray, 0);
    }
    else
    {
      int index1 = 0;
      int num6 = 32 /*0x20*/ - num3;
      int num7 = _param0[0] >>> num6;
      if (num7 != 0)
      {
        numArray = new int[num5 + num4 + 1];
        numArray[index1++] = num7;
      }
      else
        numArray = new int[num5 + num4];
      int num8 = _param0[0];
      for (int index2 = 0; index2 < num5 - 1; ++index2)
      {
        int num9 = _param0[index2 + 1];
        numArray[index1++] = num8 << num3 | num9 >>> num6;
        num8 = num9;
      }
      numArray[index1] = _param0[num5 - 1] << num3;
    }
    return numArray;
label_6:
    num5 = length;
    goto label_3;
label_5:
    num3 = num2;
    goto label_2;
label_4:
    num4 = num1;
    goto label_1;
  }

  private \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003Dz\u00241rj\u0024kbiClSNMGXTUkvSfCgzj\u0024F21UALdg\u003D\u003D(
    int _param1)
  {
    if (this.\u0023\u003DzQvRsjjA\u003D == 0 || this.\u0023\u003DzsIRkzxg\u003D.Length == 0)
      return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzOsmxM1I\u003D;
    if (_param1 == 0)
      return this;
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE1 = new \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(this.\u0023\u003DzQvRsjjA\u003D, \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzX5cyxTQ15yzKEzDH17sWMwqUgAhxXM20ko8apDM\u003D(this.\u0023\u003DzsIRkzxg\u003D, _param1), true);
    if (true)
      goto label_6;
label_5:
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE2;
    if (this.\u0023\u003DzlrX5m0o\u003D != -1)
    {
      \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE3 = j53Wpsqr9vPjC2eXuE2;
      int num = this.\u0023\u003DzlrX5m0o\u003D + _param1;
      if (true)
        j53Wpsqr9vPjC2eXuE3.\u0023\u003DzlrX5m0o\u003D = num;
    }
    return j53Wpsqr9vPjC2eXuE2;
label_6:
    j53Wpsqr9vPjC2eXuE2 = j53Wpsqr9vPjC2eXuE1;
    goto label_5;
  }

  private static void \u0023\u003Dzw7mh9sAsNqeHcTnuzJGBxpBt1YRmgwFoug\u003D\u003D(
    int _param0,
    int[] _param1,
    int _param2)
  {
    int num1 = (_param2 >>> 5) + _param0;
    if (true)
      goto label_5;
label_1:
    int num2 = _param2 & 31 /*0x1F*/;
    if (true)
      goto label_6;
label_2:
    int num3 = _param1.Length - 1;
    if (true)
      goto label_7;
label_3:
    int index1;
    int index2;
    if (index1 != _param0)
    {
      int num4 = index1 - _param0;
      for (int index3 = index2; index3 >= index1; --index3)
        _param1[index3] = _param1[index3 - num4];
      for (int index4 = index1 - 1; index4 >= _param0; --index4)
        _param1[index4] = 0;
    }
    int num5;
    if (num5 == 0)
      return;
    int num6 = 32 /*0x20*/ - num5;
    int num7 = _param1[index2];
    for (int index5 = index2; index5 > index1; --index5)
    {
      int num8 = _param1[index5 - 1];
      _param1[index5] = num7 >>> num5 | num8 << num6;
      num7 = num8;
    }
    _param1[index1] = _param1[index1] >>> num5;
    return;
label_7:
    index2 = num3;
    goto label_3;
label_6:
    num5 = num2;
    goto label_2;
label_5:
    index1 = num1;
    goto label_1;
  }

  private static void \u0023\u003DzrMfKjxJlNY2OfD2v0Awf2hB\u002477m2a5FCAQ\u003D\u003D(
    int _param0,
    int[] _param1)
  {
    int length = _param1.Length;
    if (true)
      goto label_2;
label_1:
    int index;
    int num1 = _param1[index - 1];
    int num2;
    if (true)
      num2 = num1;
    while (--index > _param0)
    {
      int num3 = _param1[index - 1];
      if (true)
        goto label_6;
label_5:
      int num4;
      _param1[index] = num2 >>> 1 | num4 << 31 /*0x1F*/;
      num2 = num4;
      continue;
label_6:
      num4 = num3;
      goto label_5;
    }
    _param1[_param0] = _param1[_param0] >>> 1;
    return;
label_2:
    index = length;
    goto label_1;
  }

  public int \u0023\u003DzjNTGOTRn9z_vLYhJWGVt_C\u0024gkqhS3qpmGA\u003D\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzQvRsjjA\u003D;
  }

  private static int[] \u0023\u003DzvQnToYzojDvBN\u00249oQ4jgPK7WBnV2(
    int _param0,
    int[] _param1,
    int _param2,
    int[] _param3)
  {
    int length1 = _param1.Length;
    if (true)
      goto label_3;
label_1:
    int length2 = _param3.Length;
    if (true)
      goto label_4;
label_2:
    int num1;
    if (true)
      num1 = 0;
    int index;
    int num2;
    do
    {
      long num3 = ((long) _param1[--index] & (long) uint.MaxValue) - ((long) _param3[--num2] & (long) uint.MaxValue) + (long) num1;
      _param1[index] = (int) num3;
      num1 = (int) (num3 >> 63 /*0x3F*/);
    }
    while (num2 > _param2);
    if (num1 != 0)
    {
      while (--_param1[--index] == -1)
        ;
    }
    return _param1;
label_4:
    num2 = length2;
    goto label_2;
label_3:
    index = length1;
    goto label_1;
  }

  public byte[] \u0023\u003DzYceID_Apzbarccx4ufFdIF4Zps3G()
  {
    if (this.\u0023\u003DzQvRsjjA\u003D == 0)
      return Array.Empty<byte>();
    byte[] numArray1 = new byte[\u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzopC65qbyKgh0utCQa_q0c8SJyQxcYTMAMH6\u0024nzjv6g31(this.\u0023\u003DzAjJbjbfVsnq4ZrdywTuyL9vODPi5())];
    if (true)
      goto label_4;
label_3:
    byte[] numArray2;
    this.\u0023\u003DzyCkcAeeGNbVJvnEMwARrT_T1rNNPZ2lwTw\u003D\u003D(numArray2, 0);
    return numArray2;
label_4:
    numArray2 = numArray1;
    goto label_3;
  }

  public int \u0023\u003DzJ05jzCf3crCYZrKHS18wJcjlNnb2eK_RyA\u003D\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzyCkcAeeGNbVJvnEMwARrT_T1rNNPZ2lwTw\u003D\u003D((byte[]) null, 0);
  }

  public int \u0023\u003DzyCkcAeeGNbVJvnEMwARrT_T1rNNPZ2lwTw\u003D\u003D(
    byte[] _param1,
    int _param2)
  {
    if (this.\u0023\u003DzQvRsjjA\u003D == 0)
      return 0;
    int num1 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzopC65qbyKgh0utCQa_q0c8SJyQxcYTMAMH6\u0024nzjv6g31(this.\u0023\u003DzAjJbjbfVsnq4ZrdywTuyL9vODPi5());
    if (true)
      goto label_4;
label_3:
    int num2;
    if (_param1 == null)
      return num2;
    int length = this.\u0023\u003DzsIRkzxg\u003D.Length;
    if (true)
      goto label_9;
label_7:
    int num3 = _param2 + num2;
    if (true)
      goto label_10;
label_8:
    int num4;
    if (num4 > _param1.Length)
      throw new IndexOutOfRangeException();
    int num5;
    while (num5 > 1)
    {
      uint num6 = (uint) this.\u0023\u003DzsIRkzxg\u003D[--num5];
      int num7;
      _param1[num7 = num4 - 1] = (byte) num6;
      int num8;
      _param1[num8 = num7 - 1] = (byte) (num6 >> 8);
      int num9;
      _param1[num9 = num8 - 1] = (byte) (num6 >> 16 /*0x10*/);
      _param1[num4 = num9 - 1] = (byte) (num6 >> 24);
    }
    uint num10;
    for (num10 = (uint) this.\u0023\u003DzsIRkzxg\u003D[0]; num10 > (uint) byte.MaxValue; num10 >>= 8)
      _param1[--num4] = (byte) num10;
    int num11;
    _param1[num11 = num4 - 1] = (byte) num10;
    return num2;
label_10:
    num4 = num3;
    goto label_8;
label_9:
    num5 = length;
    goto label_7;
label_4:
    num2 = num1;
    goto label_3;
  }

  private static \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003Dzrx\u002470FOZNDufe_iMFpccZWDmxetFyA3cuQ\u003D\u003D(
    ulong _param0)
  {
    int num1 = (int) (_param0 >> 32 /*0x20*/);
    if (true)
      goto label_3;
label_1:
    int num2 = (int) _param0;
    if (true)
      goto label_4;
label_2:
    int num3;
    int num4;
    if (num3 != 0)
      return new \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(1, new int[2]
      {
        num3,
        num4
      }, false);
    if (num4 == 0)
      return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzOsmxM1I\u003D;
    return new \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(1, new int[1]
    {
      num4
    }, false);
label_4:
    num4 = num2;
    goto label_2;
label_3:
    num3 = num1;
    goto label_1;
  }

  public static \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003Dz9yr0JLCi3P2UkLBU1eT1iTF5RgCVYUJs0qCAz_o\u003D(
    ulong _param0)
  {
    long num = (long) _param0;
    if (true)
      ;
    return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzrx\u002470FOZNDufe_iMFpccZWDmxetFyA3cuQ\u003D\u003D((ulong) num);
  }

  private static int[] \u0023\u003Dzjk_8v1M25RvSQe4vBqr\u0024NB8\u003D(int[] _param0, int[] _param1)
  {
    int index1;
    if (true)
      index1 = 0;
    while (index1 < _param0.Length && _param0[index1] == 0)
    {
      int num = index1 + 1;
      if (true)
        index1 = num;
    }
    int sourceIndex;
    if (true)
      sourceIndex = 0;
    while (sourceIndex < _param1.Length && _param1[sourceIndex] == 0)
    {
      int num = sourceIndex + 1;
      if (true)
        sourceIndex = num;
    }
    int num1 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz3ceLNBGXSSc_4Kp6KtEwy8w\u003D(index1, _param0, sourceIndex, _param1);
    if (true)
      goto label_12;
label_11:
    int num2;
    if (num2 > 0)
    {
      int num3 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzxUwcAO94JEVbnJx3lUffKPkfDP37(1, sourceIndex, _param1);
      if (true)
        goto label_15;
label_14:
      int num4 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzxUwcAO94JEVbnJx3lUffKPkfDP37(1, index1, _param0);
      int num5;
      int num6 = num4 - num5;
      int index2 = 0;
      int num7 = num5;
      int[] destinationArray;
      if (num6 > 0)
      {
        destinationArray = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzX5cyxTQ15yzKEzDH17sWMwqUgAhxXM20ko8apDM\u003D(_param1, num6);
        num7 += num6;
      }
      else
      {
        int length = _param1.Length - sourceIndex;
        destinationArray = new int[length];
        Array.Copy((Array) _param1, sourceIndex, (Array) destinationArray, 0, length);
      }
label_18:
      if (num7 < num4 || \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz3ceLNBGXSSc_4Kp6KtEwy8w\u003D(index1, _param0, index2, destinationArray) >= 0)
      {
        \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzvQnToYzojDvBN\u00249oQ4jgPK7WBnV2(index1, _param0, index2, destinationArray);
        while (_param0[index1] == 0)
        {
          if (++index1 == _param0.Length)
            return _param0;
        }
        num4 = 32 /*0x20*/ * (_param0.Length - index1 - 1) + \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz5WY5cPzK12Q_Vuq0eXyfSBqstMqf(_param0[index1]);
        if (num4 <= num5)
        {
          if (num4 < num5)
            return _param0;
          num2 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz3ceLNBGXSSc_4Kp6KtEwy8w\u003D(index1, _param0, sourceIndex, _param1);
          if (num2 <= 0)
            goto label_34;
        }
      }
      int num8 = num7 - num4;
      if (num8 == 1 && (uint) (destinationArray[index2] >>> 1) > (uint) _param0[index1])
        ++num8;
      if (num8 < 2)
      {
        \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzrMfKjxJlNY2OfD2v0Awf2hB\u002477m2a5FCAQ\u003D\u003D(index2, destinationArray);
        --num7;
      }
      else
      {
        \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzw7mh9sAsNqeHcTnuzJGBxpBt1YRmgwFoug\u003D\u003D(index2, destinationArray, num8);
        num7 -= num8;
      }
      while (destinationArray[index2] == 0)
        ++index2;
      goto label_18;
label_15:
      num5 = num3;
      goto label_14;
    }
label_34:
    if (num2 == 0)
      Array.Clear((Array) _param0, index1, _param0.Length - index1);
    return _param0;
label_12:
    num2 = num1;
    goto label_11;
  }

  private \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003DzBh7JT2pKputLB8eFCHM1Wm7C97DCBp9EuA\u003D\u003D(
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D _param1)
  {
    if (this.\u0023\u003DzQvRsjjA\u003D == 0)
      return \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003DzOsmxM1I\u003D;
    if (\u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz3ceLNBGXSSc_4Kp6KtEwy8w\u003D(0, this.\u0023\u003DzsIRkzxg\u003D, 0, _param1.\u0023\u003DzsIRkzxg\u003D) < 0)
      return this;
    int[] numArray1 = (int[]) this.\u0023\u003DzsIRkzxg\u003D.Clone();
    if (true)
      goto label_7;
label_5:
    int[] numArray2;
    int[] numArray3 = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dzjk_8v1M25RvSQe4vBqr\u0024NB8\u003D(numArray2, _param1.\u0023\u003DzsIRkzxg\u003D);
    if (true)
      goto label_8;
label_6:
    return new \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(this.\u0023\u003DzQvRsjjA\u003D, numArray2, true);
label_8:
    numArray2 = numArray3;
    goto label_6;
label_7:
    numArray2 = numArray1;
    goto label_5;
  }

  private static int[] \u0023\u003DzwN0ur\u0024dhXu2QYgPgPIkSZkQ\u003D(int[] _param0)
  {
    int[] numArray1 = new int[_param0.Length];
    if (true)
      goto label_3;
label_1:
    int[] src = _param0;
    int[] numArray2;
    int[] dst = numArray2;
    int count = _param0.Length * 4;
    if (true)
      goto label_4;
label_2:
    return numArray2;
label_4:
    Buffer.BlockCopy((Array) src, 0, (Array) dst, 0, count);
    goto label_2;
label_3:
    numArray2 = numArray1;
    goto label_1;
  }
}
