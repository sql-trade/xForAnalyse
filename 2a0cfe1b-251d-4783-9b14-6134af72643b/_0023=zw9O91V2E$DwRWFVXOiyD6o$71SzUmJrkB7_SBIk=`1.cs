// Decompiled with JetBrains decompiler
// Type: #=zw9O91V2E$DwRWFVXOiyD6o$71SzUmJrkB7_SBIk=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal class \u0023\u003Dzw9O91V2E\u0024DwRWFVXOiyD6o\u002471SzUmJrkB7_SBIk\u003D<\u0023\u003Dz4UEwosY\u003D>
  where \u0023\u003Dz4UEwosY\u003D : IComparable<\u0023\u003Dz4UEwosY\u003D>
{
  private long[] \u0023\u003Dzwz0Fwus\u003D;
  private \u0023\u003Dz4UEwosY\u003D[] \u0023\u003DzW7nezhQ\u003D;
  private int \u0023\u003Dzc7AOiaQ\u003D;
  private readonly bool \u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D;
  private readonly int \u0023\u003Dz9o5mAUE\u003D;
  private readonly bool \u0023\u003Dz6T8XzWNuEfB\u0024;

  public \u0023\u003Dzw9O91V2E\u0024DwRWFVXOiyD6o\u002471SzUmJrkB7_SBIk\u003D(int _param1)
  {
    if (true)
      ;
    int num = _param1;
    if (true)
      ;
    // ISSUE: explicit constructor call
    this.\u002Ector(num, int.MaxValue, false, false);
  }

  public \u0023\u003Dzw9O91V2E\u0024DwRWFVXOiyD6o\u002471SzUmJrkB7_SBIk\u003D(
    int _param1,
    int _param2,
    bool _param3,
    bool _param4)
  {
    int num1 = _param3 ? 1 : 0;
    if (true)
      goto label_4;
label_1:
    int num2 = _param4 ? 1 : 0;
    if (true)
      goto label_5;
label_2:
    int num3 = Math.Max(_param2, _param1);
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003Dzwz0Fwus\u003D = new long[_param1];
    this.\u0023\u003DzW7nezhQ\u003D = new \u0023\u003Dz4UEwosY\u003D[_param1];
    return;
label_6:
    this.\u0023\u003Dz9o5mAUE\u003D = num3;
    goto label_3;
label_5:
    this.\u0023\u003Dz6T8XzWNuEfB\u0024 = num2 != 0;
    goto label_2;
label_4:
    this.\u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D = num1 != 0;
    goto label_1;
  }

  public void \u0023\u003Dzdp0ADFc\u003D(long _param1, \u0023\u003Dz4UEwosY\u003D _param2)
  {
    if (this.\u0023\u003Dzc7AOiaQ\u003D == this.\u0023\u003Dzwz0Fwus\u003D.Length)
    {
      if (this.\u0023\u003Dz9o5mAUE\u003D > this.\u0023\u003Dzwz0Fwus\u003D.Length)
      {
        if (true)
          this.\u0023\u003DzKjninEY\u003D();
      }
      else
      {
        if (!this.\u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D)
          return;
        if (true)
          this.\u0023\u003DzXhyaZ5c\u003D();
      }
    }
    if (this.\u0023\u003Dz6T8XzWNuEfB\u0024 && this.\u0023\u003Dzc7AOiaQ\u003D >= 2)
    {
      ref \u0023\u003Dz4UEwosY\u003D local1 = ref _param2;
      \u0023\u003Dz4UEwosY\u003D z4UewosY1 = default (\u0023\u003Dz4UEwosY\u003D);
      if ((object) z4UewosY1 == null)
      {
        \u0023\u003Dz4UEwosY\u003D z4UewosY2 = local1;
        if (true)
          goto label_12;
label_11:
        local1 = ref z4UewosY1;
        goto label_13;
label_12:
        z4UewosY1 = z4UewosY2;
        goto label_11;
      }
label_13:
      \u0023\u003Dz4UEwosY\u003D other1 = this.\u0023\u003DzW7nezhQ\u003D[this.\u0023\u003Dzc7AOiaQ\u003D - 1];
      if (local1.CompareTo(other1) == 0)
      {
        ref \u0023\u003Dz4UEwosY\u003D local2 = ref _param2;
        z4UewosY1 = default (\u0023\u003Dz4UEwosY\u003D);
        if ((object) z4UewosY1 == null)
        {
          z4UewosY1 = local2;
          local2 = ref z4UewosY1;
        }
        \u0023\u003Dz4UEwosY\u003D other2 = this.\u0023\u003DzW7nezhQ\u003D[this.\u0023\u003Dzc7AOiaQ\u003D - 2];
        if (local2.CompareTo(other2) == 0)
        {
          this.\u0023\u003Dzwz0Fwus\u003D[this.\u0023\u003Dzc7AOiaQ\u003D - 1] = _param1;
          return;
        }
      }
    }
    this.\u0023\u003Dzwz0Fwus\u003D[this.\u0023\u003Dzc7AOiaQ\u003D] = _param1;
    this.\u0023\u003DzW7nezhQ\u003D[this.\u0023\u003Dzc7AOiaQ\u003D++] = _param2;
  }

  public bool \u0023\u003Dzx7\u0024U\u00249I\u003D(long _param1)
  {
    int num1 = this.\u0023\u003Dz6lC17UCIKr4D(_param1);
    if (true)
      goto label_2;
label_1:
    int num2;
    return num2 != -1 && this.\u0023\u003DzMdH1w9A\u003D(num2) == _param1;
label_2:
    num2 = num1;
    goto label_1;
  }

  public void \u0023\u003Dznle1EHQkRhSZ(long _param1, \u0023\u003Dz4UEwosY\u003D _param2)
  {
    long num1 = _param1;
    \u0023\u003Dz4UEwosY\u003D z4UewosY1 = _param2;
    if (true)
      goto label_3;
label_1:
    if (this.\u0023\u003Dzc7AOiaQ\u003D == 1)
      return;
    int num2 = this.\u0023\u003Dzc7AOiaQ\u003D - 1;
    int index;
    if (true)
      index = num2;
    for (; index > 0 && this.\u0023\u003Dzwz0Fwus\u003D[index - 1] > this.\u0023\u003Dzwz0Fwus\u003D[index]; --index)
    {
      long zwz0Fwu = this.\u0023\u003Dzwz0Fwus\u003D[index - 1];
      if (true)
        goto label_9;
label_8:
      \u0023\u003Dz4UEwosY\u003D z4UewosY2 = this.\u0023\u003DzW7nezhQ\u003D[index - 1];
      this.\u0023\u003Dzwz0Fwus\u003D[index - 1] = this.\u0023\u003Dzwz0Fwus\u003D[index];
      this.\u0023\u003DzW7nezhQ\u003D[index - 1] = this.\u0023\u003DzW7nezhQ\u003D[index];
      long num3;
      this.\u0023\u003Dzwz0Fwus\u003D[index] = num3;
      this.\u0023\u003DzW7nezhQ\u003D[index] = z4UewosY2;
      continue;
label_9:
      num3 = zwz0Fwu;
      goto label_8;
    }
    return;
label_3:
    this.\u0023\u003Dzdp0ADFc\u003D(num1, z4UewosY1);
    goto label_1;
  }

  public void \u0023\u003DzJf0NEUA\u003D(Func<\u0023\u003Dz4UEwosY\u003D, bool> _param1)
  {
    if (true)
      goto label_2;
label_1:
    int index1;
    if (true)
      index1 = 0;
    int index2;
    for (; index1 < this.\u0023\u003Dzc7AOiaQ\u003D; ++index1)
    {
      if (!_param1(this.\u0023\u003DzW7nezhQ\u003D[index1]))
      {
        if (index2 == index1)
        {
          int num = index2 + 1;
          if (true)
            index2 = num;
        }
        else
        {
          this.\u0023\u003Dzwz0Fwus\u003D[index2] = this.\u0023\u003Dzwz0Fwus\u003D[index1];
          this.\u0023\u003DzW7nezhQ\u003D[index2++] = this.\u0023\u003DzW7nezhQ\u003D[index1];
        }
      }
    }
    this.\u0023\u003Dzc7AOiaQ\u003D = index2;
    return;
label_2:
    index2 = 0;
    goto label_1;
  }

  public void \u0023\u003DzXhyaZ5c\u003D()
  {
    long[] numArray1 = new long[this.\u0023\u003Dzwz0Fwus\u003D.Length];
    if (true)
      goto label_4;
label_1:
    \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray1 = new \u0023\u003Dz4UEwosY\u003D[this.\u0023\u003Dzwz0Fwus\u003D.Length];
    if (true)
      goto label_5;
label_2:
    if (true)
      goto label_6;
label_3:
    long[] numArray2;
    \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray2;
    int index1;
    for (int index2 = 0; index2 < this.\u0023\u003Dzc7AOiaQ\u003D; ++index2)
    {
      if (index2 % 4 != 0 || index2 == 0)
      {
        numArray2[index1] = this.\u0023\u003Dzwz0Fwus\u003D[index2];
        z4UewosYArray2[index1] = this.\u0023\u003DzW7nezhQ\u003D[index2];
      }
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray2;
    this.\u0023\u003DzW7nezhQ\u003D = z4UewosYArray2;
    this.\u0023\u003Dzc7AOiaQ\u003D = index1;
    return;
label_6:
    index1 = 0;
    goto label_3;
label_5:
    z4UewosYArray2 = z4UewosYArray1;
    goto label_2;
label_4:
    numArray2 = numArray1;
    goto label_1;
  }

  public void \u0023\u003DzYWVxyvY\u003D()
  {
    if (this.\u0023\u003Dzc7AOiaQ\u003D >= this.\u0023\u003Dzwz0Fwus\u003D.Length)
      return;
    long[] numArray1 = new long[this.\u0023\u003Dzc7AOiaQ\u003D];
    if (true)
      goto label_5;
label_2:
    \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray1 = new \u0023\u003Dz4UEwosY\u003D[this.\u0023\u003Dzc7AOiaQ\u003D];
    if (true)
      goto label_6;
label_3:
    int index;
    if (true)
      index = 0;
    long[] numArray2;
    \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray2;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      numArray2[index] = this.\u0023\u003Dzwz0Fwus\u003D[index];
      z4UewosYArray2[index] = this.\u0023\u003DzW7nezhQ\u003D[index];
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray2;
    this.\u0023\u003DzW7nezhQ\u003D = z4UewosYArray2;
    return;
label_6:
    z4UewosYArray2 = z4UewosYArray1;
    goto label_3;
label_5:
    numArray2 = numArray1;
    goto label_2;
  }

  public void \u0023\u003Dz\u0024TjcaEC2oIvl()
  {
    int length = this.\u0023\u003Dzc7AOiaQ\u003D - this.\u0023\u003Dzc7AOiaQ\u003D / 4 + 1;
    long[] numArray1 = new long[length];
    if (true)
      goto label_4;
label_1:
    \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray1 = new \u0023\u003Dz4UEwosY\u003D[length];
    if (true)
      goto label_5;
label_2:
    if (true)
      goto label_6;
label_3:
    long[] numArray2;
    \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray2;
    int index1;
    for (int index2 = 0; index2 < this.\u0023\u003Dzc7AOiaQ\u003D; ++index2)
    {
      if (index2 % 4 != 0 || index2 == 0)
      {
        numArray2[index1] = this.\u0023\u003Dzwz0Fwus\u003D[index2];
        z4UewosYArray2[index1] = this.\u0023\u003DzW7nezhQ\u003D[index2];
      }
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray2;
    this.\u0023\u003DzW7nezhQ\u003D = z4UewosYArray2;
    this.\u0023\u003Dzc7AOiaQ\u003D = index1;
    return;
label_6:
    index1 = 0;
    goto label_3;
label_5:
    z4UewosYArray2 = z4UewosYArray1;
    goto label_2;
label_4:
    numArray2 = numArray1;
    goto label_1;
  }

  public void \u0023\u003DzKjninEY\u003D()
  {
    int length = Math.Min(this.\u0023\u003Dzwz0Fwus\u003D.Length + this.\u0023\u003Dzwz0Fwus\u003D.Length / 2, this.\u0023\u003Dz9o5mAUE\u003D);
    long[] numArray1 = new long[length];
    if (true)
      goto label_3;
label_1:
    \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray1 = new \u0023\u003Dz4UEwosY\u003D[length];
    if (true)
      goto label_4;
label_2:
    int index;
    if (true)
      index = 0;
    long[] numArray2;
    \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray2;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      numArray2[index] = this.\u0023\u003Dzwz0Fwus\u003D[index];
      z4UewosYArray2[index] = this.\u0023\u003DzW7nezhQ\u003D[index];
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray2;
    this.\u0023\u003DzW7nezhQ\u003D = z4UewosYArray2;
    return;
label_4:
    z4UewosYArray2 = z4UewosYArray1;
    goto label_2;
label_3:
    numArray2 = numArray1;
    goto label_1;
  }

  public int \u0023\u003DzL8dTma0\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzc7AOiaQ\u003D;
  }

  public void \u0023\u003Dz4d\u0024gruM\u003D()
  {
    if (false)
      return;
    this.\u0023\u003Dzc7AOiaQ\u003D = 0;
  }

  public int \u0023\u003DzKyxPlKE\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzwz0Fwus\u003D.Length;
  }

  public void \u0023\u003DzY0AKHT4\u003D(Action<long, \u0023\u003Dz4UEwosY\u003D> _param1)
  {
    int index;
    if (true)
      index = 0;
    while (index < this.\u0023\u003Dzc7AOiaQ\u003D)
    {
      _param1(this.\u0023\u003Dzwz0Fwus\u003D[index], this.\u0023\u003DzW7nezhQ\u003D[index]);
      int num = index + 1;
      if (true)
        index = num;
    }
  }

  public \u0023\u003Dz4UEwosY\u003D \u0023\u003DzrqIE4Co\u003D(
    int _param1,
    \u0023\u003Dz4UEwosY\u003D _param2)
  {
    int num1 = _param1;
    if (true)
      ;
    if (true)
      ;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (num1 < zc7AoiaQ)
    {
      int num2 = _param1;
      if (true)
        ;
      if (num2 >= 0)
        return this.\u0023\u003DzW7nezhQ\u003D[_param1];
    }
    return _param2;
  }

  public long \u0023\u003DzMdH1w9A\u003D(int _param1)
  {
    int num1 = _param1;
    if (true)
      ;
    if (true)
      ;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (num1 < zc7AoiaQ)
    {
      int num2 = _param1;
      if (true)
        ;
      if (num2 >= 0)
        return this.\u0023\u003Dzwz0Fwus\u003D[_param1];
    }
    return 0;
  }

  public int \u0023\u003Dz6lC17UCIKr4D(long _param1)
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

  public int \u0023\u003DzC5KEjmQazKLB(long _param1)
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
}
