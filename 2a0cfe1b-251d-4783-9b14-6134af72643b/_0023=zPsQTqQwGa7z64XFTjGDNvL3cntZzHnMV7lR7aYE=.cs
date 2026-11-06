// Decompiled with JetBrains decompiler
// Type: #=zPsQTqQwGa7z64XFTjGDNvL3cntZzHnMV7lR7aYE=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal sealed class \u0023\u003DzPsQTqQwGa7z64XFTjGDNvL3cntZzHnMV7lR7aYE\u003D
{
  private long[] \u0023\u003DzW7nezhQ\u003D;
  private int \u0023\u003Dzc7AOiaQ\u003D;
  private readonly bool \u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D;
  private readonly int \u0023\u003Dz9o5mAUE\u003D;

  public \u0023\u003DzPsQTqQwGa7z64XFTjGDNvL3cntZzHnMV7lR7aYE\u003D(int _param1)
  {
    if (true)
      ;
    int num = _param1;
    if (true)
      ;
    // ISSUE: explicit constructor call
    this.\u002Ector(num, int.MaxValue, false);
  }

  public \u0023\u003DzPsQTqQwGa7z64XFTjGDNvL3cntZzHnMV7lR7aYE\u003D(
    int _param1,
    int _param2,
    bool _param3)
  {
    int num1 = _param3 ? 1 : 0;
    if (true)
      goto label_4;
label_1:
    int num2 = Math.Max(_param2, _param1);
    if (true)
      goto label_5;
label_2:
    long[] numArray = new long[_param1];
    if (false)
      return;
    this.\u0023\u003DzW7nezhQ\u003D = numArray;
    return;
label_5:
    this.\u0023\u003Dz9o5mAUE\u003D = num2;
    goto label_2;
label_4:
    this.\u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D = num1 != 0;
    goto label_1;
  }

  public void \u0023\u003DzEIuP_yE\u003D()
  {
    if (false)
      return;
    this.\u0023\u003Dzc7AOiaQ\u003D = 0;
  }

  public void \u0023\u003DzPaioaKs\u003D(long _param1)
  {
    if (this.\u0023\u003Dzc7AOiaQ\u003D == this.\u0023\u003DzW7nezhQ\u003D.Length)
    {
      if (this.\u0023\u003Dz9o5mAUE\u003D > this.\u0023\u003DzW7nezhQ\u003D.Length)
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
    long[] zW7nezhQ = this.\u0023\u003DzW7nezhQ\u003D;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (true)
      goto label_10;
label_9:
    int num1;
    this.\u0023\u003Dzc7AOiaQ\u003D = num1 + 1;
    int index = num1;
    long num2 = _param1;
    zW7nezhQ[index] = num2;
    return;
label_10:
    num1 = zc7AoiaQ;
    goto label_9;
  }

  public void \u0023\u003DzDBsRjVxM7DcQ()
  {
    long[] numArray1 = new long[this.\u0023\u003DzW7nezhQ\u003D.Length];
    if (true)
      goto label_3;
label_1:
    if (true)
      goto label_4;
label_2:
    int index;
    if (true)
      index = 0;
    long[] numArray2;
    int num;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      if (index % 4 != 0 || index == 0)
        numArray2[num++] = this.\u0023\u003DzW7nezhQ\u003D[index];
    }
    this.\u0023\u003DzW7nezhQ\u003D = numArray2;
    this.\u0023\u003Dzc7AOiaQ\u003D = num;
    return;
label_4:
    num = 0;
    goto label_2;
label_3:
    numArray2 = numArray1;
    goto label_1;
  }

  public void \u0023\u003DznmATs1w\u003D()
  {
    if (false)
      return;
    this.\u0023\u003DznmATs1w\u003D(0);
  }

  public void \u0023\u003DznmATs1w\u003D(int _param1)
  {
    int num = Math.Max(_param1, Math.Max(this.\u0023\u003Dzc7AOiaQ\u003D, 1));
    if (true)
      goto label_2;
label_1:
    int length;
    if (length >= this.\u0023\u003DzW7nezhQ\u003D.Length)
      return;
    long[] numArray1 = new long[length];
    if (true)
      goto label_6;
label_4:
    int index;
    if (true)
      index = 0;
    long[] numArray2;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
      numArray2[index] = this.\u0023\u003DzW7nezhQ\u003D[index];
    this.\u0023\u003DzW7nezhQ\u003D = numArray2;
    return;
label_6:
    numArray2 = numArray1;
    goto label_4;
label_2:
    length = num;
    goto label_1;
  }

  public void \u0023\u003DzSkNBvBAz9_8vHylcHw\u003D\u003D()
  {
    long[] numArray1 = new long[this.\u0023\u003Dzc7AOiaQ\u003D - this.\u0023\u003Dzc7AOiaQ\u003D / 4 + 1];
    if (true)
      goto label_3;
label_1:
    if (true)
      goto label_4;
label_2:
    int index;
    if (true)
      index = 0;
    long[] numArray2;
    int num;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      if (index % 4 != 0 || index == 0)
        numArray2[num++] = this.\u0023\u003DzW7nezhQ\u003D[index];
    }
    this.\u0023\u003DzW7nezhQ\u003D = numArray2;
    this.\u0023\u003Dzc7AOiaQ\u003D = num;
    return;
label_4:
    num = 0;
    goto label_2;
label_3:
    numArray2 = numArray1;
    goto label_1;
  }

  public void \u0023\u003DzO7Q4ezA\u003D()
  {
    long[] numArray1 = new long[Math.Min(this.\u0023\u003DzW7nezhQ\u003D.Length + this.\u0023\u003DzW7nezhQ\u003D.Length / 2, this.\u0023\u003Dz9o5mAUE\u003D)];
    if (true)
      goto label_2;
label_1:
    int index;
    if (true)
      index = 0;
    long[] numArray2;
    while (index < this.\u0023\u003Dzc7AOiaQ\u003D)
    {
      numArray2[index] = this.\u0023\u003DzW7nezhQ\u003D[index];
      int num = index + 1;
      if (true)
        index = num;
    }
    this.\u0023\u003DzW7nezhQ\u003D = numArray2;
    return;
label_2:
    numArray2 = numArray1;
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
    return this.\u0023\u003DzW7nezhQ\u003D.Length;
  }

  public long \u0023\u003Dz9BG4JC4\u003D(int _param1)
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
    return this.\u0023\u003DzW7nezhQ\u003D[_param1];
  }
}
