// Decompiled with JetBrains decompiler
// Type: #=q04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
internal sealed class \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D : 
  \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D,
  IDisposable
{
  private byte[] \u0023\u003Dzv_DK75M\u003D;
  private int \u0023\u003DzOsmxM1I\u003D;
  private int \u0023\u003DzAElFq6M\u003D;
  private int \u0023\u003DzhBh6D88\u003D;
  private int \u0023\u003DzsIRkzxg\u003D;
  private bool \u0023\u003DzQvRsjjA\u003D;
  private bool \u0023\u003DzlrX5m0o\u003D;
  private bool \u0023\u003DzDnwpn_c\u003D;
  private bool \u0023\u003DzZ04UAGU\u003D;

  public \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D()
  {
    if (true)
      ;
    // ISSUE: explicit constructor call
    this.\u002Ector(0);
  }

  public \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D(int _param1)
  {
    byte[] numArray = _param1 >= 0 ? new byte[_param1] : throw new ArgumentOutOfRangeException();
    if (true)
      goto label_6;
label_3:
    int num = _param1;
    if (true)
      goto label_7;
label_4:
    if (true)
      goto label_8;
label_5:
    this.\u0023\u003DzlrX5m0o\u003D = true;
    this.\u0023\u003DzOsmxM1I\u003D = 0;
    this.\u0023\u003DzDnwpn_c\u003D = true;
    return;
label_8:
    this.\u0023\u003DzQvRsjjA\u003D = true;
    goto label_5;
label_7:
    this.\u0023\u003DzsIRkzxg\u003D = num;
    goto label_4;
label_6:
    this.\u0023\u003Dzv_DK75M\u003D = numArray;
    goto label_3;
  }

  public \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D(byte[] _param1)
  {
    if (true)
      ;
    byte[] numArray = _param1;
    if (true)
      ;
    // ISSUE: explicit constructor call
    this.\u002Ector(numArray, true);
  }

  public \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D(
    byte[] _param1,
    bool _param2)
  {
    byte[] numArray = _param1 != null ? _param1 : throw new ArgumentNullException();
    if (true)
      goto label_6;
label_3:
    int length = _param1.Length;
    if (true)
      goto label_7;
label_4:
    if (true)
      goto label_8;
label_5:
    int num;
    this.\u0023\u003DzhBh6D88\u003D = num;
    this.\u0023\u003DzlrX5m0o\u003D = _param2;
    this.\u0023\u003DzOsmxM1I\u003D = 0;
    this.\u0023\u003DzDnwpn_c\u003D = true;
    return;
label_8:
    this.\u0023\u003DzsIRkzxg\u003D = length;
    goto label_5;
label_7:
    num = length;
    goto label_4;
label_6:
    this.\u0023\u003Dzv_DK75M\u003D = numArray;
    goto label_3;
  }

  public \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    if (true)
      ;
    byte[] numArray = _param1;
    if (true)
      ;
    int num1 = _param2;
    if (true)
      ;
    int num2 = _param3;
    // ISSUE: explicit constructor call
    this.\u002Ector(numArray, num1, num2, true);
  }

  public \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D(
    byte[] _param1,
    int _param2,
    int _param3,
    bool _param4)
  {
    if (_param1 == null)
      throw new ArgumentNullException();
    if (_param2 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param3 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param1.Length - _param2 < _param3)
      throw new ArgumentException();
    byte[] numArray = _param1;
    if (true)
      goto label_12;
label_9:
    int num1 = _param2;
    if (true)
      goto label_13;
label_10:
    if (true)
      goto label_14;
label_11:
    int num2;
    this.\u0023\u003DzOsmxM1I\u003D = num2;
    this.\u0023\u003DzhBh6D88\u003D = this.\u0023\u003DzsIRkzxg\u003D = _param2 + _param3;
    this.\u0023\u003DzlrX5m0o\u003D = _param4;
    this.\u0023\u003DzQvRsjjA\u003D = false;
    this.\u0023\u003DzDnwpn_c\u003D = true;
    return;
label_14:
    this.\u0023\u003DzAElFq6M\u003D = num1;
    goto label_11;
label_13:
    num2 = num1;
    goto label_10;
label_12:
    this.\u0023\u003Dzv_DK75M\u003D = numArray;
    goto label_9;
  }

  [SpecialName]
  public override bool \u0023\u003DzxL4NTUOAh1RIQ_euvW5\u0024luBRrWyehIjrdpysROdU_zhi8f6ALQ6PIO_1oX1KMCNn06OOwnE\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzDnwpn_c\u003D;
  }

  [SpecialName]
  public override bool \u0023\u003DzPkgH6portpv5CYuJmPIg9GuVLpJ10l80hT2UABZn9aUG_L9h4mXIjspJeR2Iva1Idj_lUp\u0024ZU\u00242e()
  {
    if (true)
      ;
    return this.\u0023\u003DzDnwpn_c\u003D;
  }

  [SpecialName]
  public override bool \u0023\u003Dz0Aj17P0JNtsYgICtp4\u0024T0X2ISaW0WBM\u0024o3HPhHUnmwkSshwOwe0Rmlqj_oqgPTJpD\u0024bCBjdyu9aybqr5SiPRn7w\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzlrX5m0o\u003D;
  }

  protected override void \u0023\u003DzEX\u0024CFWZrLupHTunvdo37qferRIgLG2eWQMnCrE0eqRmoOU4Rq8norHMHsK3By\u0024UGpn9tqBCaONYdC2uFf9tZudc\u003D(
    bool _param1)
  {
    if (this.\u0023\u003DzZ04UAGU\u003D)
      return;
    if (_param1)
    {
      if (true)
        goto label_5;
label_3:
      if (true)
        goto label_6;
label_4:
      if (true)
      {
        this.\u0023\u003DzQvRsjjA\u003D = false;
        goto label_8;
      }
      goto label_8;
label_6:
      this.\u0023\u003DzlrX5m0o\u003D = false;
      goto label_4;
label_5:
      this.\u0023\u003DzDnwpn_c\u003D = false;
      goto label_3;
    }
label_8:
    this.\u0023\u003DzZ04UAGU\u003D = true;
  }

  private bool \u0023\u003Dzn1Hka9nqxZaBO71FU8ejDJQXhlboU\u0024n5NQ\u003D\u003D(int _param1)
  {
    if (_param1 < 0)
      throw new IOException();
    if (_param1 <= this.\u0023\u003DzsIRkzxg\u003D)
      return false;
    int num1 = _param1;
    if (true)
      goto label_5;
label_4:
    int num2;
    if (num2 < 256 /*0x0100*/)
    {
      if (true)
        num2 = 256 /*0x0100*/;
    }
    if (num2 < this.\u0023\u003DzsIRkzxg\u003D * 2)
    {
      int num3 = this.\u0023\u003DzsIRkzxg\u003D * 2;
      if (true)
        num2 = num3;
    }
    this.\u0023\u003DzBTwU26QmguPf3SM9F0pUAaV2FWlU(num2);
    return true;
label_5:
    num2 = num1;
    goto label_4;
  }

  public override void \u0023\u003DzCycCfcC5MiH4xd7bsm\u00245mX46pjg1hi_N231YkVk9xusTNRUXS\u0024btiGFjO94UoUwsRfkkeLQXVH7wlbCwEA\u003D\u003D()
  {
  }

  internal byte[] \u0023\u003DzSi4Oxtt49spoOQL0ay5L_Z0\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzv_DK75M\u003D;
  }

  internal void \u0023\u003DzZKcWYFrEQmJhRdyhk9QZIUg\u003D(out int _param1, out int _param2)
  {
    if (true)
      ;
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    ref int local = ref _param1;
    if (true)
      ;
    if (true)
      ;
    int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    local = zOsmxM1I;
    _param2 = this.\u0023\u003DzhBh6D88\u003D;
  }

  internal int \u0023\u003Dz2tEIInL1eLOhU\u0024_8F_Z\u0024gO3U5WrW()
  {
    if (true)
      ;
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (true)
      ;
    return this.\u0023\u003DzAElFq6M\u003D;
  }

  public int \u0023\u003DzR__GdVJ1H2oUyNtad_qaDyoXTbVm(int _param1)
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    int num1 = this.\u0023\u003DzhBh6D88\u003D - this.\u0023\u003DzAElFq6M\u003D;
    if (true)
      goto label_4;
label_3:
    int num2;
    if (num2 > _param1)
    {
      int num3 = _param1;
      if (true)
        num2 = num3;
    }
    if (num2 < 0)
    {
      if (true)
        num2 = 0;
    }
    this.\u0023\u003DzAElFq6M\u003D += num2;
    return num2;
label_4:
    num2 = num1;
    goto label_3;
  }

  public int \u0023\u003DzFJsY8pXuC\u0024WG9Ksv8jwNPG9C597a()
  {
    if (true)
      ;
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (true)
      ;
    int zsIrkzxg = this.\u0023\u003DzsIRkzxg\u003D;
    if (true)
      ;
    int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    return zsIrkzxg - zOsmxM1I;
  }

  public void \u0023\u003DzBTwU26QmguPf3SM9F0pUAaV2FWlU(int _param1)
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (_param1 == this.\u0023\u003DzsIRkzxg\u003D)
      return;
    if (!this.\u0023\u003DzQvRsjjA\u003D)
      throw new Exception();
    if (_param1 < this.\u0023\u003DzhBh6D88\u003D)
      throw new ArgumentOutOfRangeException();
    if (_param1 > 0)
    {
      byte[] numArray1 = new byte[_param1];
      if (true)
        goto label_10;
label_9:
      byte[] numArray2;
      if (this.\u0023\u003DzhBh6D88\u003D > 0)
      {
        byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
        byte[] dst = numArray2;
        int zhBh6D88 = this.\u0023\u003DzhBh6D88\u003D;
        if (true)
          Buffer.BlockCopy((Array) zvDk75M, 0, (Array) dst, 0, zhBh6D88);
      }
      byte[] numArray3 = numArray2;
      if (true)
      {
        this.\u0023\u003Dzv_DK75M\u003D = numArray3;
        goto label_17;
      }
      goto label_17;
label_10:
      numArray2 = numArray1;
      goto label_9;
    }
    this.\u0023\u003Dzv_DK75M\u003D = (byte[]) null;
label_17:
    this.\u0023\u003DzsIRkzxg\u003D = _param1;
  }

  [SpecialName]
  public override long \u0023\u003DzCnOd1f_jT0Wlc0dynqgYPXtof7eW4ms4NUhJp68YLLklnM3YdDd\u0024DEJ0tsOBL\u00246yqUDCkD\u00246AgWYOOlyIvZJ6xA\u003D()
  {
    if (true)
      ;
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (true)
      ;
    int zhBh6D88 = this.\u0023\u003DzhBh6D88\u003D;
    if (true)
      ;
    int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    return (long) (zhBh6D88 - zOsmxM1I);
  }

  [SpecialName]
  public override long \u0023\u003DzUWjiMzrscdbNirxNE8qbXmJSKC4FCr5qTpPyMVNfz9c7y77twKxesGSMoR\u0024DTE5oOTEZ2NE\u003D()
  {
    if (true)
      ;
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (true)
      ;
    int zAelFq6M = this.\u0023\u003DzAElFq6M\u003D;
    if (true)
      ;
    int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    return (long) (zAelFq6M - zOsmxM1I);
  }

  [SpecialName]
  public override void \u0023\u003DzoqGGSxv50nBf7J_lcpaCyXazKs2ZNgFtR4W8C38H\u0024EKh3gfPvmMpqKkYi8sNKdHliMRA94E\u003D(
    long _param1)
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (_param1 < 0L)
      throw new ArgumentOutOfRangeException();
    if (_param1 > (long) int.MaxValue)
      throw new ArgumentOutOfRangeException();
    int num = this.\u0023\u003DzOsmxM1I\u003D + (int) _param1;
    if (false)
      return;
    this.\u0023\u003DzAElFq6M\u003D = num;
  }

  public override int \u0023\u003Dzqi6bFCsg6IizkjY7gWIf9OnVpfyNfJgDHA7otxFYU\u0024\u0024PMTpQ2pm_sS0kK0AkdjN7zZiVkMr_EWVy\u0024THZuQ\u003D\u003D(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (_param1 == null)
      throw new ArgumentNullException();
    if (_param2 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param3 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param1.Length - _param2 < _param3)
      throw new ArgumentException();
    int num1 = this.\u0023\u003DzhBh6D88\u003D - this.\u0023\u003DzAElFq6M\u003D;
    if (true)
      goto label_12;
label_11:
    int count;
    if (count > _param3)
    {
      int num2 = _param3;
      if (true)
        count = num2;
    }
    if (count <= 0)
      return 0;
    if (count <= 8)
    {
      int num3 = count;
      int num4;
      if (true)
        num4 = num3;
      while (--num4 >= 0)
        _param1[_param2 + num4] = this.\u0023\u003Dzv_DK75M\u003D[this.\u0023\u003DzAElFq6M\u003D + num4];
    }
    else
      Buffer.BlockCopy((Array) this.\u0023\u003Dzv_DK75M\u003D, this.\u0023\u003DzAElFq6M\u003D, (Array) _param1, _param2, count);
    this.\u0023\u003DzAElFq6M\u003D += count;
    return count;
label_12:
    count = num1;
    goto label_11;
  }

  public override int \u0023\u003Dz5K7bWXXu3efUrOkp4vR2Y3ozKwY5IT529k0H61hWMt4zETG75r2w_lB9KUDLpXL5UsLDFYbjZtI6GQNGi9HaAPdbvCHG()
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (this.\u0023\u003DzAElFq6M\u003D >= this.\u0023\u003DzhBh6D88\u003D)
      return -1;
    byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    int zAelFq6M = this.\u0023\u003DzAElFq6M\u003D;
    if (true)
      goto label_7;
label_5:
    int num1;
    int num2 = num1 + 1;
    if (true)
      goto label_8;
label_6:
    int index = num1;
    return (int) zvDk75M[index];
label_8:
    this.\u0023\u003DzAElFq6M\u003D = num2;
    goto label_6;
label_7:
    num1 = zAelFq6M;
    goto label_5;
  }

  public override long \u0023\u003Dz5aRdfNAj4ntK5EbmqU4JtTQpm5iZUznQIpuVF\u0024YazKWC9R4AjFQtOLojJpnJTa462QE\u0024yNmuV0KnXwsUUg\u003D\u003D(
    long _param1,
    int _param2)
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (_param1 > (long) int.MaxValue)
      throw new ArgumentOutOfRangeException();
    switch (_param2)
    {
      case 0:
        if (_param1 < 0L)
          throw new IOException();
        int num1 = this.\u0023\u003DzOsmxM1I\u003D + (int) _param1;
        if (true)
        {
          this.\u0023\u003DzAElFq6M\u003D = num1;
          break;
        }
        break;
      case 1:
        if (_param1 + (long) this.\u0023\u003DzAElFq6M\u003D < (long) this.\u0023\u003DzOsmxM1I\u003D)
          throw new IOException();
        int num2 = this.\u0023\u003DzAElFq6M\u003D + (int) _param1;
        if (true)
        {
          this.\u0023\u003DzAElFq6M\u003D = num2;
          break;
        }
        break;
      case 2:
        if ((long) this.\u0023\u003DzhBh6D88\u003D + _param1 < (long) this.\u0023\u003DzOsmxM1I\u003D)
          throw new IOException();
        int num3 = this.\u0023\u003DzhBh6D88\u003D + (int) _param1;
        if (true)
        {
          this.\u0023\u003DzAElFq6M\u003D = num3;
          break;
        }
        break;
      default:
        throw new ArgumentException();
    }
    return (long) this.\u0023\u003DzAElFq6M\u003D;
  }

  public override void \u0023\u003DzuZhcyhJQQK1hFvnDVYuiDXyninywWeF4lTiLta0leC4G\u0024KietLhZU1uIwmoJdQtmp6LiYMa127CTJODYnB2FPaeMstlN(
    long _param1)
  {
    if (!this.\u0023\u003DzlrX5m0o\u003D)
      throw new Exception();
    if (_param1 > (long) int.MaxValue)
      throw new ArgumentOutOfRangeException();
    if (_param1 < 0L || _param1 > (long) (int.MaxValue - this.\u0023\u003DzOsmxM1I\u003D))
      throw new ArgumentOutOfRangeException();
    int num1 = this.\u0023\u003DzOsmxM1I\u003D + (int) _param1;
    if (true)
      goto label_8;
label_7:
    int num2;
    if (!this.\u0023\u003Dzn1Hka9nqxZaBO71FU8ejDJQXhlboU\u0024n5NQ\u003D\u003D(num2) && num2 > this.\u0023\u003DzhBh6D88\u003D)
    {
      byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
      int zhBh6D88 = this.\u0023\u003DzhBh6D88\u003D;
      int length = num2 - this.\u0023\u003DzhBh6D88\u003D;
      if (true)
        Array.Clear((Array) zvDk75M, zhBh6D88, length);
    }
    int num3 = num2;
    if (true)
      goto label_14;
label_12:
    if (this.\u0023\u003DzAElFq6M\u003D <= num2)
      return;
    this.\u0023\u003DzAElFq6M\u003D = num2;
    return;
label_14:
    this.\u0023\u003DzhBh6D88\u003D = num3;
    goto label_12;
label_8:
    num2 = num1;
    goto label_7;
  }

  public byte[] \u0023\u003DzbRwFdyoMJLoohjEoK_BxGpmlTsnqY75sKykbEeU\u003D()
  {
    byte[] numArray1 = new byte[this.\u0023\u003DzhBh6D88\u003D - this.\u0023\u003DzOsmxM1I\u003D];
    if (true)
      goto label_3;
label_1:
    byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    byte[] numArray2;
    byte[] dst = numArray2;
    int count = this.\u0023\u003DzhBh6D88\u003D - this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_4;
label_2:
    return numArray2;
label_4:
    Buffer.BlockCopy((Array) zvDk75M, zOsmxM1I, (Array) dst, 0, count);
    goto label_2;
label_3:
    numArray2 = numArray1;
    goto label_1;
  }

  public override void \u0023\u003DzxL4NTUOAh1RIQ_euvW5\u0024luBRrWyehIjrdpysROdU_zhbJ9fXnx\u0024yzYWpA\u0024iJycmVAwUeJeFsmW3bRTZBPV1IhNE\u003D(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (!this.\u0023\u003DzlrX5m0o\u003D)
      throw new Exception();
    if (_param1 == null)
      throw new ArgumentNullException();
    if (_param2 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param3 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param1.Length - _param2 < _param3)
      throw new ArgumentException();
    int num1 = this.\u0023\u003DzAElFq6M\u003D + _param3;
    if (true)
      goto label_14;
label_13:
    int num2;
    if (num2 < 0)
      throw new IOException();
    if (num2 > this.\u0023\u003DzhBh6D88\u003D)
    {
      int num3 = this.\u0023\u003DzAElFq6M\u003D > this.\u0023\u003DzhBh6D88\u003D ? 1 : 0;
      if (true)
        goto label_19;
label_18:
      bool flag;
      if (num2 > this.\u0023\u003DzsIRkzxg\u003D && this.\u0023\u003Dzn1Hka9nqxZaBO71FU8ejDJQXhlboU\u0024n5NQ\u003D\u003D(num2))
      {
        if (true)
          flag = false;
      }
      if (flag)
        Array.Clear((Array) this.\u0023\u003Dzv_DK75M\u003D, this.\u0023\u003DzhBh6D88\u003D, num2 - this.\u0023\u003DzhBh6D88\u003D);
      this.\u0023\u003DzhBh6D88\u003D = num2;
      goto label_25;
label_19:
      flag = num3 != 0;
      goto label_18;
    }
label_25:
    if (_param3 <= 8)
    {
      int num4 = _param3;
      while (--num4 >= 0)
        this.\u0023\u003Dzv_DK75M\u003D[this.\u0023\u003DzAElFq6M\u003D + num4] = _param1[_param2 + num4];
    }
    else
      Buffer.BlockCopy((Array) _param1, _param2, (Array) this.\u0023\u003Dzv_DK75M\u003D, this.\u0023\u003DzAElFq6M\u003D, _param3);
    this.\u0023\u003DzAElFq6M\u003D = num2;
    return;
label_14:
    num2 = num1;
    goto label_13;
  }

  public override void \u0023\u003DzLOS57NkRybXM2f87dX07agSYafm_TzFT1rWtNY8QVyuPTpPqxE2O_P56lT_vbWX\u00248fSa4IKSdl1hyv935VH4Ueo\u003D(
    byte _param1)
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    if (!this.\u0023\u003DzlrX5m0o\u003D)
      throw new Exception();
    if (this.\u0023\u003DzAElFq6M\u003D >= this.\u0023\u003DzhBh6D88\u003D)
    {
      int num1 = this.\u0023\u003DzAElFq6M\u003D + 1;
      if (true)
        goto label_8;
label_6:
      int num2 = this.\u0023\u003DzAElFq6M\u003D > this.\u0023\u003DzhBh6D88\u003D ? 1 : 0;
      if (true)
        goto label_9;
label_7:
      int num3;
      bool flag;
      if (num3 >= this.\u0023\u003DzsIRkzxg\u003D && this.\u0023\u003Dzn1Hka9nqxZaBO71FU8ejDJQXhlboU\u0024n5NQ\u003D\u003D(num3))
      {
        if (true)
          flag = false;
      }
      if (flag)
        Array.Clear((Array) this.\u0023\u003Dzv_DK75M\u003D, this.\u0023\u003DzhBh6D88\u003D, this.\u0023\u003DzAElFq6M\u003D - this.\u0023\u003DzhBh6D88\u003D);
      this.\u0023\u003DzhBh6D88\u003D = num3;
      goto label_15;
label_9:
      flag = num2 != 0;
      goto label_7;
label_8:
      num3 = num1;
      goto label_6;
    }
label_15:
    this.\u0023\u003Dzv_DK75M\u003D[this.\u0023\u003DzAElFq6M\u003D++] = _param1;
  }

  public void \u0023\u003DzFyvzaF1x\u0024f6mfbMU7UUWo4M\u003D(Stream _param1)
  {
    if (true)
      ;
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    Stream stream1 = _param1;
    if (true)
      ;
    if (stream1 == null)
      throw new ArgumentNullException();
    Stream stream2 = _param1;
    if (true)
      ;
    byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    int num = this.\u0023\u003DzhBh6D88\u003D - this.\u0023\u003DzOsmxM1I\u003D;
    stream2.Write(zvDk75M, zOsmxM1I, num);
  }

  internal int \u0023\u003Dzu1VaczWT3KF9kRBsR0etYMIzRWSI1TYZE_UEJFYtSizo()
  {
    if (!this.\u0023\u003DzDnwpn_c\u003D)
      throw new Exception();
    int num1 = this.\u0023\u003DzAElFq6M\u003D + 4;
    if (true)
      goto label_6;
label_3:
    if (true)
      goto label_7;
label_4:
    int num2;
    int num3 = num2;
    if (true)
      goto label_8;
label_5:
    int num4;
    if (num4 > this.\u0023\u003DzhBh6D88\u003D)
    {
      this.\u0023\u003DzAElFq6M\u003D = this.\u0023\u003DzhBh6D88\u003D;
      throw new Exception();
    }
    return (int) this.\u0023\u003Dzv_DK75M\u003D[num4 - 1] << 24 | (int) this.\u0023\u003Dzv_DK75M\u003D[num4 - 2] << 8 | (int) this.\u0023\u003Dzv_DK75M\u003D[num4 - 3] << 16 /*0x10*/ | (int) this.\u0023\u003Dzv_DK75M\u003D[num4 - 4];
label_8:
    num4 = num3;
    goto label_5;
label_7:
    this.\u0023\u003DzAElFq6M\u003D = num1;
    goto label_4;
label_6:
    num2 = num1;
    goto label_3;
  }
}
