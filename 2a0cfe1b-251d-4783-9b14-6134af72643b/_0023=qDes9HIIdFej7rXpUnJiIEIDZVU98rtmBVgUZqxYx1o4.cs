// Decompiled with JetBrains decompiler
// Type: #=qDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal sealed class \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D
{
  private byte[] \u0023\u003Dzv_DK75M\u003D;
  private int \u0023\u003DzOsmxM1I\u003D;
  private long \u0023\u003DzAElFq6M\u003D;
  private uint \u0023\u003DzhBh6D88\u003D;
  private uint \u0023\u003DzsIRkzxg\u003D;
  private uint \u0023\u003DzQvRsjjA\u003D;
  private uint \u0023\u003DzlrX5m0o\u003D;
  private uint \u0023\u003DzDnwpn_c\u003D;
  private uint[] \u0023\u003DzZ04UAGU\u003D;
  private int \u0023\u003DzL67ogXM\u003D;

  public \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D()
  {
    uint[] numArray1 = new uint[80 /*0x50*/];
    if (true)
      goto label_4;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    byte[] numArray2 = new byte[4];
    if (true)
      goto label_5;
label_2:
    if (false)
      return;
    this.\u0023\u003DzdZHnrLlFzE95CgTAW9pGSzNNoSAwhzEEAQ\u003D\u003D();
    return;
label_5:
    this.\u0023\u003Dzv_DK75M\u003D = numArray2;
    goto label_2;
label_4:
    this.\u0023\u003DzZ04UAGU\u003D = numArray1;
    goto label_1;
  }

  public \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D(
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D _param1)
  {
    uint[] numArray = new uint[80 /*0x50*/];
    if (true)
      goto label_3;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D u98rtmBvgUzqxYx1o4 = _param1;
    if (false)
      return;
    this.\u0023\u003DzagOdl2LU0UaT3\u0024F6OR6ee_owjOD3(u98rtmBvgUzqxYx1o4);
    return;
label_3:
    this.\u0023\u003DzZ04UAGU\u003D = numArray;
    goto label_1;
  }

  public void \u0023\u003DzksdZUGp_PcPs\u0024xk2rXFJ2YQ\u003D(byte _param1)
  {
    byte[] zvDk75M1 = this.\u0023\u003Dzv_DK75M\u003D;
    int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_3;
label_1:
    int num1;
    int num2 = num1 + 1;
    if (true)
      goto label_4;
label_2:
    int index = num1;
    int num3 = (int) _param1;
    zvDk75M1[index] = (byte) num3;
    if (this.\u0023\u003DzOsmxM1I\u003D == this.\u0023\u003Dzv_DK75M\u003D.Length)
    {
      byte[] zvDk75M2 = this.\u0023\u003Dzv_DK75M\u003D;
      if (true)
        goto label_7;
label_6:
      this.\u0023\u003DzOsmxM1I\u003D = 0;
      goto label_8;
label_7:
      this.\u0023\u003Dz0LeBWrCMWjUJC3UnamgrhFQ\u003D(zvDk75M2, 0);
      goto label_6;
    }
label_8:
    ++this.\u0023\u003DzAElFq6M\u003D;
    return;
label_4:
    this.\u0023\u003DzOsmxM1I\u003D = num2;
    goto label_2;
label_3:
    num1 = zOsmxM1I;
    goto label_1;
  }

  public void \u0023\u003DzKzDkx\u0024\u0024Q208f\u0024YRcUyJpP5CGH4DQ7OYulokx6_c\u003D(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    int num1 = Math.Max(0, _param3);
    if (true)
      goto label_3;
label_1:
    if (true)
      goto label_4;
label_2:
    int num2;
    if (this.\u0023\u003DzOsmxM1I\u003D != 0)
    {
      while (num2 < _param3)
      {
        byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
        int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
        if (true)
          goto label_7;
label_6:
        int num3;
        this.\u0023\u003DzOsmxM1I\u003D = num3 + 1;
        int index = num3;
        int num4 = (int) _param1[_param2 + num2++];
        zvDk75M[index] = (byte) num4;
        if (this.\u0023\u003DzOsmxM1I\u003D == 4)
        {
          this.\u0023\u003Dz0LeBWrCMWjUJC3UnamgrhFQ\u003D(this.\u0023\u003Dzv_DK75M\u003D, 0);
          this.\u0023\u003DzOsmxM1I\u003D = 0;
          break;
        }
        continue;
label_7:
        num3 = zOsmxM1I;
        goto label_6;
      }
    }
    for (int index = (_param3 - num2 & -4) + num2; num2 < index; num2 += 4)
      this.\u0023\u003Dz0LeBWrCMWjUJC3UnamgrhFQ\u003D(_param1, _param2 + num2);
    while (num2 < _param3)
      this.\u0023\u003Dzv_DK75M\u003D[this.\u0023\u003DzOsmxM1I\u003D++] = _param1[_param2 + num2++];
    this.\u0023\u003DzAElFq6M\u003D += (long) _param3;
    return;
label_4:
    num2 = 0;
    goto label_2;
label_3:
    _param3 = num1;
    goto label_1;
  }

  public void \u0023\u003Dzm__MMX5d4J\u0024MlOQ5ycMyQPeOJ9Aogj2j0EoUdVw\u003D()
  {
    long num1 = this.\u0023\u003DzAElFq6M\u003D << 3;
    if (true)
      goto label_2;
label_1:
    if (true)
      this.\u0023\u003DzksdZUGp_PcPs\u0024xk2rXFJ2YQ\u003D((byte) 128 /*0x80*/);
    while (this.\u0023\u003DzOsmxM1I\u003D != 0)
    {
      if (true)
        this.\u0023\u003DzksdZUGp_PcPs\u0024xk2rXFJ2YQ\u003D((byte) 0);
    }
    long num2;
    this.\u0023\u003Dz94MyrkKqTcbGBX3V0A\u003D\u003D(num2);
    this.\u0023\u003DzDUF7OWVZ1hrk_higidY1WKf6BKMeY2_FzMTdGCE\u003D();
    return;
label_2:
    num2 = num1;
    goto label_1;
  }

  public int \u0023\u003Dzu\u0024usJZOoqCSGzcgTHlebzfs\u003D() => 64 /*0x40*/;

  private void \u0023\u003DzagOdl2LU0UaT3\u0024F6OR6ee_owjOD3(
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D _param1)
  {
    byte[] numArray = new byte[_param1.\u0023\u003Dzv_DK75M\u003D.Length];
    if (true)
      goto label_4;
label_1:
    byte[] zvDk75M1 = _param1.\u0023\u003Dzv_DK75M\u003D;
    byte[] zvDk75M2 = this.\u0023\u003Dzv_DK75M\u003D;
    int length = _param1.\u0023\u003Dzv_DK75M\u003D.Length;
    if (true)
      goto label_5;
label_2:
    int zOsmxM1I = _param1.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzAElFq6M\u003D = _param1.\u0023\u003DzAElFq6M\u003D;
    this.\u0023\u003DzhBh6D88\u003D = _param1.\u0023\u003DzhBh6D88\u003D;
    this.\u0023\u003DzsIRkzxg\u003D = _param1.\u0023\u003DzsIRkzxg\u003D;
    this.\u0023\u003DzQvRsjjA\u003D = _param1.\u0023\u003DzQvRsjjA\u003D;
    this.\u0023\u003DzlrX5m0o\u003D = _param1.\u0023\u003DzlrX5m0o\u003D;
    this.\u0023\u003DzDnwpn_c\u003D = _param1.\u0023\u003DzDnwpn_c\u003D;
    Array.Copy((Array) _param1.\u0023\u003DzZ04UAGU\u003D, 0, (Array) this.\u0023\u003DzZ04UAGU\u003D, 0, _param1.\u0023\u003DzZ04UAGU\u003D.Length);
    this.\u0023\u003DzL67ogXM\u003D = _param1.\u0023\u003DzL67ogXM\u003D;
    return;
label_6:
    this.\u0023\u003DzOsmxM1I\u003D = zOsmxM1I;
    goto label_3;
label_5:
    Buffer.BlockCopy((Array) zvDk75M1, 0, (Array) zvDk75M2, 0, length);
    goto label_2;
label_4:
    this.\u0023\u003Dzv_DK75M\u003D = numArray;
    goto label_1;
  }

  public int \u0023\u003Dzb9JlAlLthil6EoOIi5VUflw\u003D() => 20;

  public void \u0023\u003Dz0LeBWrCMWjUJC3UnamgrhFQ\u003D(byte[] _param1, int _param2)
  {
    this.\u0023\u003DzZ04UAGU\u003D[this.\u0023\u003DzL67ogXM\u003D] = \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz4DlBbGdqm_gvShdEgEVfYNx7dp4n(_param1, _param2);
    int num1 = this.\u0023\u003DzL67ogXM\u003D + 1;
    if (true)
      goto label_4;
label_1:
    int num2;
    int num3 = num2;
    if (true)
      goto label_5;
label_2:
    if (num2 != 16 /*0x10*/)
      return;
    this.\u0023\u003DzDUF7OWVZ1hrk_higidY1WKf6BKMeY2_FzMTdGCE\u003D();
    return;
label_5:
    this.\u0023\u003DzL67ogXM\u003D = num3;
    goto label_2;
label_4:
    num2 = num1;
    goto label_1;
  }

  public void \u0023\u003Dz94MyrkKqTcbGBX3V0A\u003D\u003D(long _param1)
  {
    if (this.\u0023\u003DzL67ogXM\u003D > 14)
      this.\u0023\u003DzDUF7OWVZ1hrk_higidY1WKf6BKMeY2_FzMTdGCE\u003D();
    this.\u0023\u003DzZ04UAGU\u003D[14] = (uint) (_param1 >>> 32 /*0x20*/);
    this.\u0023\u003DzZ04UAGU\u003D[15] = (uint) _param1;
  }

  public int \u0023\u003DzYmAvpM\u0024sOXOfd5rvq2hEVgQ_UbBuUlp3UfE1L9xjm3yi(
    byte[] _param1,
    int _param2)
  {
    if (true)
      goto label_4;
label_1:
    int zhBh6D88 = (int) this.\u0023\u003DzhBh6D88\u003D;
    byte[] numArray1 = _param1;
    int num1 = _param2;
    if (true)
      goto label_5;
label_2:
    int zsIrkzxg = (int) this.\u0023\u003DzsIRkzxg\u003D;
    byte[] numArray2 = _param1;
    int num2 = _param2 + 4;
    if (true)
      goto label_6;
label_3:
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzfJnvchZkR6tmqkHPok_y92KGiV_4myB4RDtzpX7Setd\u0024(this.\u0023\u003DzQvRsjjA\u003D, _param1, _param2 + 8);
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzfJnvchZkR6tmqkHPok_y92KGiV_4myB4RDtzpX7Setd\u0024(this.\u0023\u003DzlrX5m0o\u003D, _param1, _param2 + 12);
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzfJnvchZkR6tmqkHPok_y92KGiV_4myB4RDtzpX7Setd\u0024(this.\u0023\u003DzDnwpn_c\u003D, _param1, _param2 + 16 /*0x10*/);
    this.\u0023\u003DzdZHnrLlFzE95CgTAW9pGSzNNoSAwhzEEAQ\u003D\u003D();
    return 20;
label_6:
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzfJnvchZkR6tmqkHPok_y92KGiV_4myB4RDtzpX7Setd\u0024((uint) zsIrkzxg, numArray2, num2);
    goto label_3;
label_5:
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzfJnvchZkR6tmqkHPok_y92KGiV_4myB4RDtzpX7Setd\u0024((uint) zhBh6D88, numArray1, num1);
    goto label_2;
label_4:
    this.\u0023\u003Dzm__MMX5d4J\u0024MlOQ5ycMyQPeOJ9Aogj2j0EoUdVw\u003D();
    goto label_1;
  }

  public void \u0023\u003DzdZHnrLlFzE95CgTAW9pGSzNNoSAwhzEEAQ\u003D\u003D()
  {
    if (true)
      goto label_4;
label_1:
    if (true)
      goto label_5;
label_2:
    byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    int length = this.\u0023\u003Dzv_DK75M\u003D.Length;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzhBh6D88\u003D = 1732584193U;
    this.\u0023\u003DzsIRkzxg\u003D = 4023233417U;
    this.\u0023\u003DzQvRsjjA\u003D = 2562383102U;
    this.\u0023\u003DzlrX5m0o\u003D = 271733878U;
    this.\u0023\u003DzDnwpn_c\u003D = 3285377520U;
    this.\u0023\u003DzL67ogXM\u003D = 0;
    Array.Clear((Array) this.\u0023\u003DzZ04UAGU\u003D, 0, this.\u0023\u003DzZ04UAGU\u003D.Length);
    return;
label_6:
    Array.Clear((Array) zvDk75M, 0, length);
    goto label_3;
label_5:
    this.\u0023\u003DzOsmxM1I\u003D = 0;
    goto label_2;
label_4:
    this.\u0023\u003DzAElFq6M\u003D = 0L;
    goto label_1;
  }

  private static uint \u0023\u003Dz\u0024N5wc5b57cj2eu6KeCgJHQ6MWhAQ(
    uint _param0,
    uint _param1,
    uint _param2)
  {
    int num1 = (int) _param0;
    if (true)
      ;
    int num2 = (int) _param1;
    if (true)
      ;
    int num3 = num1 & num2;
    int num4 = (int) _param0;
    if (true)
      ;
    int num5 = ~num4 & (int) _param2;
    return (uint) (num3 | num5);
  }

  private static uint \u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(
    uint _param0,
    uint _param1,
    uint _param2)
  {
    int num1 = (int) _param0;
    if (true)
      ;
    int num2 = (int) _param1;
    if (true)
      ;
    int num3 = num1 ^ num2;
    int num4 = (int) _param2;
    if (true)
      ;
    return (uint) (num3 ^ num4);
  }

  private static uint \u0023\u003DzixCnxqklB1z5zG8K_pxJlNF7jE_yU8gZ4x4dIME\u003D(
    uint _param0,
    uint _param1,
    uint _param2)
  {
    int num1 = (int) _param0;
    if (true)
      ;
    int num2 = (int) _param1;
    if (true)
      ;
    int num3 = num1 & num2;
    int num4 = (int) _param0;
    if (true)
      ;
    int num5 = (int) _param2;
    int num6 = num4 & num5;
    return (uint) (num3 | num6 | (int) _param1 & (int) _param2);
  }

  private void \u0023\u003DzDUF7OWVZ1hrk_higidY1WKf6BKMeY2_FzMTdGCE\u003D()
  {
    int index1;
    if (true)
      index1 = 16 /*0x10*/;
    while (index1 < 80 /*0x50*/)
    {
      int num1 = (int) this.\u0023\u003DzZ04UAGU\u003D[index1 - 3] ^ (int) this.\u0023\u003DzZ04UAGU\u003D[index1 - 8] ^ (int) this.\u0023\u003DzZ04UAGU\u003D[index1 - 14] ^ (int) this.\u0023\u003DzZ04UAGU\u003D[index1 - 16 /*0x10*/];
      if (true)
        goto label_4;
label_3:
      uint num2;
      this.\u0023\u003DzZ04UAGU\u003D[index1] = num2 << 1 | num2 >> 31 /*0x1F*/;
      int num3 = index1 + 1;
      if (true)
      {
        index1 = num3;
        continue;
      }
      continue;
label_4:
      num2 = (uint) num1;
      goto label_3;
    }
    int zhBh6D88 = (int) this.\u0023\u003DzhBh6D88\u003D;
    if (true)
      goto label_14;
label_8:
    int zsIrkzxg = (int) this.\u0023\u003DzsIRkzxg\u003D;
    if (true)
      goto label_15;
label_9:
    int zQvRsjjA = (int) this.\u0023\u003DzQvRsjjA\u003D;
    if (true)
      goto label_16;
label_10:
    int zlrX5m0o = (int) this.\u0023\u003DzlrX5m0o\u003D;
    if (true)
      goto label_17;
label_11:
    int zDnwpnC = (int) this.\u0023\u003DzDnwpn_c\u003D;
    if (true)
      goto label_18;
label_12:
    if (true)
      goto label_19;
label_13:
    int num4;
    if (true)
      num4 = 0;
    uint num5;
    uint num6;
    uint num7;
    uint num8;
    uint num9;
    int num10;
    for (; num4 < 4; ++num4)
    {
      int num11 = (int) num9;
      int num12 = ((int) num5 << 5 | (int) (num5 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz\u0024N5wc5b57cj2eu6KeCgJHQ6MWhAQ(num6, num7, num8);
      uint[] zZ04Uagu1 = this.\u0023\u003DzZ04UAGU\u003D;
      int index2 = num10;
      int num13 = index2 + 1;
      int num14 = (int) zZ04Uagu1[index2];
      int num15 = num12 + num14 + 1518500249;
      uint num16 = (uint) (num11 + num15);
      uint num17 = num6 << 30 | num6 >> 2;
      int num18 = (int) num8;
      int num19 = ((int) num16 << 5 | (int) (num16 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz\u0024N5wc5b57cj2eu6KeCgJHQ6MWhAQ(num5, num17, num7);
      uint[] zZ04Uagu2 = this.\u0023\u003DzZ04UAGU\u003D;
      int index3 = num13;
      int num20 = index3 + 1;
      int num21 = (int) zZ04Uagu2[index3];
      int num22 = num19 + num21 + 1518500249;
      uint num23 = (uint) (num18 + num22);
      uint num24 = num5 << 30 | num5 >> 2;
      int num25 = (int) num7;
      int num26 = ((int) num23 << 5 | (int) (num23 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz\u0024N5wc5b57cj2eu6KeCgJHQ6MWhAQ(num16, num24, num17);
      uint[] zZ04Uagu3 = this.\u0023\u003DzZ04UAGU\u003D;
      int index4 = num20;
      int num27 = index4 + 1;
      int num28 = (int) zZ04Uagu3[index4];
      int num29 = num26 + num28 + 1518500249;
      uint num30 = (uint) (num25 + num29);
      num9 = num16 << 30 | num16 >> 2;
      int num31 = (int) num17;
      int num32 = ((int) num30 << 5 | (int) (num30 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz\u0024N5wc5b57cj2eu6KeCgJHQ6MWhAQ(num23, num9, num24);
      uint[] zZ04Uagu4 = this.\u0023\u003DzZ04UAGU\u003D;
      int index5 = num27;
      int num33 = index5 + 1;
      int num34 = (int) zZ04Uagu4[index5];
      int num35 = num32 + num34 + 1518500249;
      num6 = (uint) (num31 + num35);
      num8 = num23 << 30 | num23 >> 2;
      int num36 = (int) num24;
      int num37 = ((int) num6 << 5 | (int) (num6 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz\u0024N5wc5b57cj2eu6KeCgJHQ6MWhAQ(num30, num8, num9);
      uint[] zZ04Uagu5 = this.\u0023\u003DzZ04UAGU\u003D;
      int index6 = num33;
      num10 = index6 + 1;
      int num38 = (int) zZ04Uagu5[index6];
      int num39 = num37 + num38 + 1518500249;
      num5 = (uint) (num36 + num39);
      num7 = num30 << 30 | num30 >> 2;
    }
    for (int index7 = 0; index7 < 4; ++index7)
    {
      int num40 = (int) num9;
      int num41 = ((int) num5 << 5 | (int) (num5 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num6, num7, num8);
      uint[] zZ04Uagu6 = this.\u0023\u003DzZ04UAGU\u003D;
      int index8 = num10;
      int num42 = index8 + 1;
      int num43 = (int) zZ04Uagu6[index8];
      int num44 = num41 + num43 + 1859775393;
      uint num45 = (uint) (num40 + num44);
      uint num46 = num6 << 30 | num6 >> 2;
      int num47 = (int) num8;
      int num48 = ((int) num45 << 5 | (int) (num45 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num5, num46, num7);
      uint[] zZ04Uagu7 = this.\u0023\u003DzZ04UAGU\u003D;
      int index9 = num42;
      int num49 = index9 + 1;
      int num50 = (int) zZ04Uagu7[index9];
      int num51 = num48 + num50 + 1859775393;
      uint num52 = (uint) (num47 + num51);
      uint num53 = num5 << 30 | num5 >> 2;
      int num54 = (int) num7;
      int num55 = ((int) num52 << 5 | (int) (num52 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num45, num53, num46);
      uint[] zZ04Uagu8 = this.\u0023\u003DzZ04UAGU\u003D;
      int index10 = num49;
      int num56 = index10 + 1;
      int num57 = (int) zZ04Uagu8[index10];
      int num58 = num55 + num57 + 1859775393;
      uint num59 = (uint) (num54 + num58);
      num9 = num45 << 30 | num45 >> 2;
      int num60 = (int) num46;
      int num61 = ((int) num59 << 5 | (int) (num59 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num52, num9, num53);
      uint[] zZ04Uagu9 = this.\u0023\u003DzZ04UAGU\u003D;
      int index11 = num56;
      int num62 = index11 + 1;
      int num63 = (int) zZ04Uagu9[index11];
      int num64 = num61 + num63 + 1859775393;
      num6 = (uint) (num60 + num64);
      num8 = num52 << 30 | num52 >> 2;
      int num65 = (int) num53;
      int num66 = ((int) num6 << 5 | (int) (num6 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num59, num8, num9);
      uint[] zZ04Uagu10 = this.\u0023\u003DzZ04UAGU\u003D;
      int index12 = num62;
      num10 = index12 + 1;
      int num67 = (int) zZ04Uagu10[index12];
      int num68 = num66 + num67 + 1859775393;
      num5 = (uint) (num65 + num68);
      num7 = num59 << 30 | num59 >> 2;
    }
    for (int index13 = 0; index13 < 4; ++index13)
    {
      int num69 = (int) num9;
      int num70 = ((int) num5 << 5 | (int) (num5 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzixCnxqklB1z5zG8K_pxJlNF7jE_yU8gZ4x4dIME\u003D(num6, num7, num8);
      uint[] zZ04Uagu11 = this.\u0023\u003DzZ04UAGU\u003D;
      int index14 = num10;
      int num71 = index14 + 1;
      int num72 = (int) zZ04Uagu11[index14];
      int num73 = num70 + num72 - 1894007588;
      uint num74 = (uint) (num69 + num73);
      uint num75 = num6 << 30 | num6 >> 2;
      int num76 = (int) num8;
      int num77 = ((int) num74 << 5 | (int) (num74 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzixCnxqklB1z5zG8K_pxJlNF7jE_yU8gZ4x4dIME\u003D(num5, num75, num7);
      uint[] zZ04Uagu12 = this.\u0023\u003DzZ04UAGU\u003D;
      int index15 = num71;
      int num78 = index15 + 1;
      int num79 = (int) zZ04Uagu12[index15];
      int num80 = num77 + num79 - 1894007588;
      uint num81 = (uint) (num76 + num80);
      uint num82 = num5 << 30 | num5 >> 2;
      int num83 = (int) num7;
      int num84 = ((int) num81 << 5 | (int) (num81 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzixCnxqklB1z5zG8K_pxJlNF7jE_yU8gZ4x4dIME\u003D(num74, num82, num75);
      uint[] zZ04Uagu13 = this.\u0023\u003DzZ04UAGU\u003D;
      int index16 = num78;
      int num85 = index16 + 1;
      int num86 = (int) zZ04Uagu13[index16];
      int num87 = num84 + num86 - 1894007588;
      uint num88 = (uint) (num83 + num87);
      num9 = num74 << 30 | num74 >> 2;
      int num89 = (int) num75;
      int num90 = ((int) num88 << 5 | (int) (num88 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzixCnxqklB1z5zG8K_pxJlNF7jE_yU8gZ4x4dIME\u003D(num81, num9, num82);
      uint[] zZ04Uagu14 = this.\u0023\u003DzZ04UAGU\u003D;
      int index17 = num85;
      int num91 = index17 + 1;
      int num92 = (int) zZ04Uagu14[index17];
      int num93 = num90 + num92 - 1894007588;
      num6 = (uint) (num89 + num93);
      num8 = num81 << 30 | num81 >> 2;
      int num94 = (int) num82;
      int num95 = ((int) num6 << 5 | (int) (num6 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003DzixCnxqklB1z5zG8K_pxJlNF7jE_yU8gZ4x4dIME\u003D(num88, num8, num9);
      uint[] zZ04Uagu15 = this.\u0023\u003DzZ04UAGU\u003D;
      int index18 = num91;
      num10 = index18 + 1;
      int num96 = (int) zZ04Uagu15[index18];
      int num97 = num95 + num96 - 1894007588;
      num5 = (uint) (num94 + num97);
      num7 = num88 << 30 | num88 >> 2;
    }
    for (int index19 = 0; index19 < 4; ++index19)
    {
      int num98 = (int) num9;
      int num99 = ((int) num5 << 5 | (int) (num5 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num6, num7, num8);
      uint[] zZ04Uagu16 = this.\u0023\u003DzZ04UAGU\u003D;
      int index20 = num10;
      int num100 = index20 + 1;
      int num101 = (int) zZ04Uagu16[index20];
      int num102 = num99 + num101 - 899497514;
      uint num103 = (uint) (num98 + num102);
      uint num104 = num6 << 30 | num6 >> 2;
      int num105 = (int) num8;
      int num106 = ((int) num103 << 5 | (int) (num103 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num5, num104, num7);
      uint[] zZ04Uagu17 = this.\u0023\u003DzZ04UAGU\u003D;
      int index21 = num100;
      int num107 = index21 + 1;
      int num108 = (int) zZ04Uagu17[index21];
      int num109 = num106 + num108 - 899497514;
      uint num110 = (uint) (num105 + num109);
      uint num111 = num5 << 30 | num5 >> 2;
      int num112 = (int) num7;
      int num113 = ((int) num110 << 5 | (int) (num110 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num103, num111, num104);
      uint[] zZ04Uagu18 = this.\u0023\u003DzZ04UAGU\u003D;
      int index22 = num107;
      int num114 = index22 + 1;
      int num115 = (int) zZ04Uagu18[index22];
      int num116 = num113 + num115 - 899497514;
      uint num117 = (uint) (num112 + num116);
      num9 = num103 << 30 | num103 >> 2;
      int num118 = (int) num104;
      int num119 = ((int) num117 << 5 | (int) (num117 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num110, num9, num111);
      uint[] zZ04Uagu19 = this.\u0023\u003DzZ04UAGU\u003D;
      int index23 = num114;
      int num120 = index23 + 1;
      int num121 = (int) zZ04Uagu19[index23];
      int num122 = num119 + num121 - 899497514;
      num6 = (uint) (num118 + num122);
      num8 = num110 << 30 | num110 >> 2;
      int num123 = (int) num111;
      int num124 = ((int) num6 << 5 | (int) (num6 >> 27)) + (int) \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D.\u0023\u003Dz56LOJxi\u0024jD2X83smvus0ShvU2vjKZv8zC\u0024h7feIwQct4(num117, num8, num9);
      uint[] zZ04Uagu20 = this.\u0023\u003DzZ04UAGU\u003D;
      int index24 = num120;
      num10 = index24 + 1;
      int num125 = (int) zZ04Uagu20[index24];
      int num126 = num124 + num125 - 899497514;
      num5 = (uint) (num123 + num126);
      num7 = num117 << 30 | num117 >> 2;
    }
    this.\u0023\u003DzhBh6D88\u003D += num5;
    this.\u0023\u003DzsIRkzxg\u003D += num6;
    this.\u0023\u003DzQvRsjjA\u003D += num7;
    this.\u0023\u003DzlrX5m0o\u003D += num8;
    this.\u0023\u003DzDnwpn_c\u003D += num9;
    this.\u0023\u003DzL67ogXM\u003D = 0;
    Array.Clear((Array) this.\u0023\u003DzZ04UAGU\u003D, 0, 16 /*0x10*/);
    return;
label_19:
    num10 = 0;
    goto label_13;
label_18:
    num9 = (uint) zDnwpnC;
    goto label_12;
label_17:
    num8 = (uint) zlrX5m0o;
    goto label_11;
label_16:
    num7 = (uint) zQvRsjjA;
    goto label_10;
label_15:
    num6 = (uint) zsIrkzxg;
    goto label_9;
label_14:
    num5 = (uint) zhBh6D88;
    goto label_8;
  }

  private static void \u0023\u003DzfJnvchZkR6tmqkHPok_y92KGiV_4myB4RDtzpX7Setd\u0024(
    uint _param0,
    byte[] _param1,
    int _param2)
  {
    byte[] numArray = _param1;
    if (true)
      ;
    int index = _param2;
    if (true)
      ;
    int num1 = (int) _param0;
    if (true)
      ;
    int num2 = (int) (byte) (num1 >>> 24);
    numArray[index] = (byte) num2;
    _param1[_param2 + 1] = (byte) (_param0 >> 16 /*0x10*/);
    _param1[_param2 + 2] = (byte) (_param0 >> 8);
    _param1[_param2 + 3] = (byte) _param0;
  }

  private static uint \u0023\u003Dz4DlBbGdqm_gvShdEgEVfYNx7dp4n(byte[] _param0, int _param1)
  {
    byte[] numArray1 = _param0;
    if (true)
      ;
    int index1 = _param1;
    if (true)
      ;
    int num1 = (int) numArray1[index1] << 24;
    byte[] numArray2 = _param0;
    if (true)
      ;
    int index2 = _param1 + 1;
    int num2 = (int) numArray2[index2] << 16 /*0x10*/;
    return (uint) (num1 | num2 | (int) _param0[_param1 + 2] << 8) | (uint) _param0[_param1 + 3];
  }

  public \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D \u0023\u003DzPUK2qsbf53jwWk3vW0sKxK\u0024ss8NK3MSLMA\u003D\u003D()
  {
    if (true)
      ;
    return new \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D(this);
  }

  public void \u0023\u003Dzf7cxpekjGqnzOpZCajCtROPkyockVplrUg\u003D\u003D(
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D _param1)
  {
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D u98rtmBvgUzqxYx1o4 = _param1;
    if (false)
      return;
    this.\u0023\u003DzagOdl2LU0UaT3\u0024F6OR6ee_owjOD3(u98rtmBvgUzqxYx1o4);
  }
}
