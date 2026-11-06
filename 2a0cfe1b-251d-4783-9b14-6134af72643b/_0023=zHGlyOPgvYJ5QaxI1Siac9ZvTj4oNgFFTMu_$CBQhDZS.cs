// Decompiled with JetBrains decompiler
// Type: #=zHGlyOPgvYJ5QaxI1Siac9ZvTj4oNgFFTMu_$CBQhDZSJ
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal sealed class \u0023\u003DzHGlyOPgvYJ5QaxI1Siac9ZvTj4oNgFFTMu_\u0024CBQhDZSJ
{
  private long[] \u0023\u003Dzwz0Fwus\u003D;
  private int[] \u0023\u003DzuIup1TrKMPzG;
  private int[] \u0023\u003Dz8pTpcxJeLDjh;
  private int \u0023\u003Dzc7AOiaQ\u003D;
  private readonly bool \u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D;
  private readonly int \u0023\u003Dz9o5mAUE\u003D;
  private readonly int \u0023\u003DzA6o588rjGzrl2AuQog\u003D\u003D;

  public \u0023\u003DzHGlyOPgvYJ5QaxI1Siac9ZvTj4oNgFFTMu_\u0024CBQhDZSJ(int _param1)
  {
    if (true)
      ;
    int num1 = _param1;
    if (true)
      ;
    int num2 = _param1;
    if (true)
      ;
    // ISSUE: explicit constructor call
    this.\u002Ector(num1, int.MaxValue, num2, false);
  }

  public \u0023\u003DzHGlyOPgvYJ5QaxI1Siac9ZvTj4oNgFFTMu_\u0024CBQhDZSJ(
    int _param1,
    int _param2,
    int _param3,
    bool _param4)
  {
    int num1 = _param4 ? 1 : 0;
    if (true)
      goto label_4;
label_1:
    int num2 = Math.Max(_param2, _param1);
    if (true)
      goto label_5;
label_2:
    int num3 = _param3;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003Dzwz0Fwus\u003D = new long[_param1];
    this.\u0023\u003DzuIup1TrKMPzG = new int[_param1];
    this.\u0023\u003Dz8pTpcxJeLDjh = new int[_param1];
    return;
label_6:
    this.\u0023\u003DzA6o588rjGzrl2AuQog\u003D\u003D = num3;
    goto label_3;
label_5:
    this.\u0023\u003Dz9o5mAUE\u003D = num2;
    goto label_2;
label_4:
    this.\u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D = num1 != 0;
    goto label_1;
  }

  public void \u0023\u003DzPaioaKs\u003D(long _param1, int _param2, int _param3)
  {
    if (this.\u0023\u003Dzc7AOiaQ\u003D == this.\u0023\u003Dzwz0Fwus\u003D.Length)
    {
      if (this.\u0023\u003Dz9o5mAUE\u003D > this.\u0023\u003Dzwz0Fwus\u003D.Length)
      {
        if (true)
          this.\u0023\u003DzO7Q4ezA\u003D();
      }
      else
      {
        if (!this.\u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D)
          return;
        if (true)
          this.\u0023\u003DzDBsRjVxM7DcQ();
      }
    }
    this.\u0023\u003Dzwz0Fwus\u003D[this.\u0023\u003Dzc7AOiaQ\u003D] = _param1;
    this.\u0023\u003DzuIup1TrKMPzG[this.\u0023\u003Dzc7AOiaQ\u003D] = _param2;
    int[] z8pTpcxJeLdjh = this.\u0023\u003Dz8pTpcxJeLDjh;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (true)
      goto label_10;
label_9:
    int num1;
    this.\u0023\u003Dzc7AOiaQ\u003D = num1 + 1;
    int index = num1;
    int num2 = _param3;
    z8pTpcxJeLdjh[index] = num2;
    return;
label_10:
    num1 = zc7AoiaQ;
    goto label_9;
  }

  public void \u0023\u003DzDBsRjVxM7DcQ()
  {
    long[] numArray1 = new long[this.\u0023\u003Dzwz0Fwus\u003D.Length];
    if (true)
      goto label_4;
label_1:
    int[] numArray2 = new int[this.\u0023\u003Dzwz0Fwus\u003D.Length];
    if (true)
      goto label_5;
label_2:
    int[] numArray3 = new int[this.\u0023\u003Dzwz0Fwus\u003D.Length];
    if (true)
      goto label_6;
label_3:
    int index1 = 0;
    long[] numArray4;
    int[] numArray5;
    int[] numArray6;
    for (int index2 = 0; index2 < this.\u0023\u003Dzc7AOiaQ\u003D; ++index2)
    {
      if (index2 % 4 != 0 || index2 == 0)
      {
        numArray4[index1] = this.\u0023\u003Dzwz0Fwus\u003D[index2];
        numArray5[index1] = this.\u0023\u003DzuIup1TrKMPzG[index2];
        numArray6[index1++] = this.\u0023\u003Dz8pTpcxJeLDjh[index2];
      }
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray4;
    this.\u0023\u003DzuIup1TrKMPzG = numArray5;
    this.\u0023\u003Dz8pTpcxJeLDjh = numArray6;
    this.\u0023\u003Dzc7AOiaQ\u003D = index1;
    return;
label_6:
    numArray6 = numArray3;
    goto label_3;
label_5:
    numArray5 = numArray2;
    goto label_2;
label_4:
    numArray4 = numArray1;
    goto label_1;
  }

  public void \u0023\u003DznmATs1w\u003D()
  {
    if (this.\u0023\u003Dzc7AOiaQ\u003D >= this.\u0023\u003Dzwz0Fwus\u003D.Length)
      return;
    long[] numArray1 = new long[this.\u0023\u003Dzc7AOiaQ\u003D];
    if (true)
      goto label_5;
label_2:
    int[] numArray2 = new int[this.\u0023\u003Dzc7AOiaQ\u003D];
    if (true)
      goto label_6;
label_3:
    int[] numArray3 = new int[this.\u0023\u003Dzc7AOiaQ\u003D];
    if (true)
      goto label_7;
label_4:
    long[] numArray4;
    int[] numArray5;
    int[] numArray6;
    for (int index = 0; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      numArray4[index] = this.\u0023\u003Dzwz0Fwus\u003D[index];
      numArray5[index] = this.\u0023\u003DzuIup1TrKMPzG[index];
      numArray6[index] = this.\u0023\u003Dz8pTpcxJeLDjh[index];
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray4;
    this.\u0023\u003DzuIup1TrKMPzG = numArray5;
    this.\u0023\u003Dz8pTpcxJeLDjh = numArray6;
    return;
label_7:
    numArray6 = numArray3;
    goto label_4;
label_6:
    numArray5 = numArray2;
    goto label_3;
label_5:
    numArray4 = numArray1;
    goto label_2;
  }

  public void \u0023\u003DzSkNBvBAz9_8vHylcHw\u003D\u003D()
  {
    int length = this.\u0023\u003Dzc7AOiaQ\u003D - this.\u0023\u003Dzc7AOiaQ\u003D / 4 + 1;
    long[] numArray1 = new long[length];
    if (true)
      goto label_4;
label_1:
    int[] numArray2 = new int[length];
    if (true)
      goto label_5;
label_2:
    int[] numArray3 = new int[length];
    if (true)
      goto label_6;
label_3:
    int index1 = 0;
    long[] numArray4;
    int[] numArray5;
    int[] numArray6;
    for (int index2 = 0; index2 < this.\u0023\u003Dzc7AOiaQ\u003D; ++index2)
    {
      if (index2 % 4 != 0 || index2 == 0)
      {
        numArray4[index1] = this.\u0023\u003Dzwz0Fwus\u003D[index2];
        numArray5[index1] = this.\u0023\u003DzuIup1TrKMPzG[index2];
        numArray6[index1++] = this.\u0023\u003Dz8pTpcxJeLDjh[index2];
      }
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray4;
    this.\u0023\u003DzuIup1TrKMPzG = numArray5;
    this.\u0023\u003Dz8pTpcxJeLDjh = numArray6;
    this.\u0023\u003Dzc7AOiaQ\u003D = index1;
    return;
label_6:
    numArray6 = numArray3;
    goto label_3;
label_5:
    numArray5 = numArray2;
    goto label_2;
label_4:
    numArray4 = numArray1;
    goto label_1;
  }

  public void \u0023\u003DzO7Q4ezA\u003D()
  {
    int length = Math.Max(Math.Min(this.\u0023\u003Dzwz0Fwus\u003D.Length + this.\u0023\u003Dzwz0Fwus\u003D.Length / 2, this.\u0023\u003Dz9o5mAUE\u003D), this.\u0023\u003DzA6o588rjGzrl2AuQog\u003D\u003D);
    long[] numArray1 = new long[length];
    if (true)
      goto label_4;
label_1:
    int[] numArray2 = new int[length];
    if (true)
      goto label_5;
label_2:
    int[] numArray3 = new int[length];
    if (true)
      goto label_6;
label_3:
    long[] numArray4;
    int[] numArray5;
    int[] numArray6;
    for (int index = 0; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      numArray4[index] = this.\u0023\u003Dzwz0Fwus\u003D[index];
      numArray5[index] = this.\u0023\u003DzuIup1TrKMPzG[index];
      numArray6[index] = this.\u0023\u003Dz8pTpcxJeLDjh[index];
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray4;
    this.\u0023\u003DzuIup1TrKMPzG = numArray5;
    this.\u0023\u003Dz8pTpcxJeLDjh = numArray6;
    return;
label_6:
    numArray6 = numArray3;
    goto label_3;
label_5:
    numArray5 = numArray2;
    goto label_2;
label_4:
    numArray4 = numArray1;
    goto label_1;
  }

  public int \u0023\u003DzCWDd\u0024XU\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzc7AOiaQ\u003D;
  }

  public int \u0023\u003DzYoETc2U\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzwz0Fwus\u003D.Length;
  }

  public int \u0023\u003DzApjiOkuqXk9m(int _param1)
  {
    int num = _param1;
    if (true)
      ;
    if (true)
      ;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (num >= zc7AoiaQ)
      return 0;
    if (true)
      ;
    return this.\u0023\u003DzuIup1TrKMPzG[_param1];
  }

  public int \u0023\u003Dzeov4cDS7Ic7j(int _param1)
  {
    int num = _param1;
    if (true)
      ;
    if (true)
      ;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (num >= zc7AoiaQ)
      return 0;
    if (true)
      ;
    return this.\u0023\u003Dz8pTpcxJeLDjh[_param1];
  }

  public long \u0023\u003Dzv1XJAuc\u003D(int _param1)
  {
    int num = _param1;
    if (true)
      ;
    if (true)
      ;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (num >= zc7AoiaQ)
      return 0;
    if (true)
      ;
    return this.\u0023\u003Dzwz0Fwus\u003D[_param1];
  }

  public int \u0023\u003Dze0rJsp0LZB1Y(long _param1)
  {
    if (this.\u0023\u003Dzc7AOiaQ\u003D == 0 || _param1 > this.\u0023\u003Dzwz0Fwus\u003D[this.\u0023\u003Dzc7AOiaQ\u003D - 1])
      return -1;
    if (_param1 < this.\u0023\u003Dzwz0Fwus\u003D[0])
      return 0;
    int num1 = this.\u0023\u003Dzc7AOiaQ\u003D / 2;
    if (true)
      goto label_7;
label_5:
    int num2;
    int num3 = num2;
    if (true)
      goto label_8;
label_6:
    int num4 = this.\u0023\u003Dzc7AOiaQ\u003D - 1;
    int num5;
    if (true)
      num5 = num4;
    int index;
    while (_param1 != this.\u0023\u003Dzwz0Fwus\u003D[index])
    {
      num2 /= 2;
      if (num2 != 0)
      {
        if (_param1 < this.\u0023\u003Dzwz0Fwus\u003D[index])
          index -= num2;
        else
          index += num2;
      }
      else
        break;
    }
    while (_param1 <= this.\u0023\u003Dzwz0Fwus\u003D[index] && index > 0)
      --index;
    while (_param1 > this.\u0023\u003Dzwz0Fwus\u003D[index] && index < num5)
      ++index;
    return index;
label_8:
    index = num3;
    goto label_6;
label_7:
    num2 = num1;
    goto label_5;
  }

  public int \u0023\u003DzGaF0uoHHM9CG(long _param1)
  {
    if (this.\u0023\u003Dzc7AOiaQ\u003D == 0 || _param1 < this.\u0023\u003Dzwz0Fwus\u003D[0])
      return -1;
    if (_param1 > this.\u0023\u003Dzwz0Fwus\u003D[this.\u0023\u003Dzc7AOiaQ\u003D - 1])
      return this.\u0023\u003Dzc7AOiaQ\u003D - 1;
    int num1 = this.\u0023\u003Dzc7AOiaQ\u003D / 2;
    if (true)
      goto label_7;
label_5:
    int num2;
    int num3 = num2;
    if (true)
      goto label_8;
label_6:
    int num4 = this.\u0023\u003Dzc7AOiaQ\u003D - 1;
    int num5;
    if (true)
      num5 = num4;
    int index;
    while (_param1 != this.\u0023\u003Dzwz0Fwus\u003D[index])
    {
      num2 /= 2;
      if (num2 != 0)
      {
        if (_param1 < this.\u0023\u003Dzwz0Fwus\u003D[index])
          index -= num2;
        else
          index += num2;
      }
      else
        break;
    }
    while (_param1 >= this.\u0023\u003Dzwz0Fwus\u003D[index] && index < num5)
      ++index;
    while (_param1 < this.\u0023\u003Dzwz0Fwus\u003D[index] && index > 0)
      --index;
    return index;
label_8:
    index = num3;
    goto label_6;
label_7:
    num2 = num1;
    goto label_5;
  }

  public int \u0023\u003DzoXC0rpG8WzrczW\u0024sfg\u003D\u003D(long _param1)
  {
    if (true)
      goto label_2;
label_1:
    int index;
    if (true)
      index = 0;
    int num1;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D && this.\u0023\u003Dzwz0Fwus\u003D[index] <= _param1; ++index)
    {
      int num2 = num1 + Math.Max(0, this.\u0023\u003Dz8pTpcxJeLDjh[index]);
      if (false)
        continue;
      num1 = num2;
    }
    return num1;
label_2:
    num1 = 0;
    goto label_1;
  }

  public int \u0023\u003Dz\u00243YFRyPQoPp9day1MA\u003D\u003D()
  {
    if (true)
      goto label_2;
label_1:
    int index;
    if (true)
      index = 0;
    int num1;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      int num2 = this.\u0023\u003Dz8pTpcxJeLDjh[index];
      if (true)
        goto label_6;
label_5:
      int num3;
      if (num3 > 0)
      {
        num1 += this.\u0023\u003DzuIup1TrKMPzG[index] * num3;
        continue;
      }
      continue;
label_6:
      num3 = num2;
      goto label_5;
    }
    return num1;
label_2:
    num1 = 0;
    goto label_1;
  }
}
