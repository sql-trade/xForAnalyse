// Decompiled with JetBrains decompiler
// Type: #=zYwOhLkz0_nd$WewrSFVaQ4Tqn_MwSE6V_L_U5TUqu4_LcgF7Kg==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal class \u0023\u003DzYwOhLkz0_nd\u0024WewrSFVaQ4Tqn_MwSE6V_L_U5TUqu4_LcgF7Kg\u003D\u003D
{
  private long[] \u0023\u003Dzwz0Fwus\u003D;
  private \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[] \u0023\u003DzW7nezhQ\u003D;
  private int \u0023\u003Dzc7AOiaQ\u003D;
  private bool \u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D;
  private int \u0023\u003Dz9o5mAUE\u003D;

  public \u0023\u003DzYwOhLkz0_nd\u0024WewrSFVaQ4Tqn_MwSE6V_L_U5TUqu4_LcgF7Kg\u003D\u003D(
    int _param1)
  {
    if (true)
      ;
    int num = _param1;
    if (true)
      ;
    // ISSUE: explicit constructor call
    this.\u002Ector(num, int.MaxValue, false);
  }

  public \u0023\u003DzYwOhLkz0_nd\u0024WewrSFVaQ4Tqn_MwSE6V_L_U5TUqu4_LcgF7Kg\u003D\u003D(
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
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzW7nezhQ\u003D = new \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[_param1];
    return;
label_6:
    this.\u0023\u003Dzwz0Fwus\u003D = numArray;
    goto label_3;
label_5:
    this.\u0023\u003Dz9o5mAUE\u003D = num2;
    goto label_2;
label_4:
    this.\u0023\u003DzR1hI8VYHTCbgZ4KlOA\u003D\u003D = num1 != 0;
    goto label_1;
  }

  public void \u0023\u003Dz4d\u0024gruM\u003D()
  {
    int index;
    if (true)
      index = 0;
    while (index < this.\u0023\u003Dzc7AOiaQ\u003D)
    {
      this.\u0023\u003DzW7nezhQ\u003D[index] = (\u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D) null;
      int num = index + 1;
      if (true)
        index = num;
    }
    if (false)
      return;
    this.\u0023\u003Dzc7AOiaQ\u003D = 0;
  }

  public void \u0023\u003Dzdp0ADFc\u003D(
    long _param1,
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D _param2)
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
    this.\u0023\u003Dzwz0Fwus\u003D[this.\u0023\u003Dzc7AOiaQ\u003D] = _param1;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[] zW7nezhQ = this.\u0023\u003DzW7nezhQ\u003D;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (true)
      goto label_10;
label_9:
    int num;
    this.\u0023\u003Dzc7AOiaQ\u003D = num + 1;
    int index = num;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D voaVubE9Md3v1Pus = _param2;
    zW7nezhQ[index] = voaVubE9Md3v1Pus;
    return;
label_10:
    num = zc7AoiaQ;
    goto label_9;
  }

  public void \u0023\u003DzXhyaZ5c\u003D()
  {
    int length = Math.Max(this.\u0023\u003Dzwz0Fwus\u003D.Length, 9);
    long[] numArray1 = new long[length];
    if (true)
      goto label_5;
label_1:
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[] voaVubE9Md3v1PusArray1 = new \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[length];
    if (true)
      goto label_6;
label_2:
    if (true)
      goto label_7;
label_3:
    if (true)
      goto label_8;
label_4:
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D voaVubE9Md3v1Pus1 = (\u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D) null;
    long[] numArray2;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[] voaVubE9Md3v1PusArray2;
    int index1;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D voaVubE9Md3v1Pus2;
    for (int index2 = 0; index2 < this.\u0023\u003Dzc7AOiaQ\u003D; ++index2)
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D voaVubE9Md3v1Pus3 = this.\u0023\u003DzW7nezhQ\u003D[index2];
      if (index2 % 4 == 0 && index2 != 0)
      {
        if (voaVubE9Md3v1Pus3.\u0023\u003Dzuz8_9j8\u003D == \u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D.Bid)
        {
          if (voaVubE9Md3v1Pus1 != null)
            voaVubE9Md3v1Pus1.\u0023\u003Dz0xLYDF0\u003D(voaVubE9Md3v1Pus3.\u0023\u003DzkP4rPcQ\u003D);
          else
            voaVubE9Md3v1Pus1 = voaVubE9Md3v1Pus3;
        }
        else if (voaVubE9Md3v1Pus2 != null)
          voaVubE9Md3v1Pus2.\u0023\u003Dz0xLYDF0\u003D(voaVubE9Md3v1Pus3.\u0023\u003DzkP4rPcQ\u003D);
        else
          voaVubE9Md3v1Pus2 = voaVubE9Md3v1Pus3;
      }
      else
      {
        if (voaVubE9Md3v1Pus1 != null && voaVubE9Md3v1Pus3.\u0023\u003Dzuz8_9j8\u003D == \u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D.Bid)
        {
          voaVubE9Md3v1Pus3.\u0023\u003Dz0xLYDF0\u003D(voaVubE9Md3v1Pus1.\u0023\u003DzkP4rPcQ\u003D);
          voaVubE9Md3v1Pus1 = (\u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D) null;
        }
        else if (voaVubE9Md3v1Pus2 != null && voaVubE9Md3v1Pus3.\u0023\u003Dzuz8_9j8\u003D != \u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D.Bid)
        {
          voaVubE9Md3v1Pus3.\u0023\u003Dz0xLYDF0\u003D(voaVubE9Md3v1Pus2.\u0023\u003DzkP4rPcQ\u003D);
          voaVubE9Md3v1Pus2 = (\u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D) null;
        }
        numArray2[index1] = this.\u0023\u003Dzwz0Fwus\u003D[index2];
        voaVubE9Md3v1PusArray2[index1++] = voaVubE9Md3v1Pus3;
      }
    }
    if (voaVubE9Md3v1Pus1 != null)
    {
      numArray2[index1] = numArray2[index1 - 1] + 1L;
      voaVubE9Md3v1PusArray2[index1++] = voaVubE9Md3v1Pus1;
    }
    if (voaVubE9Md3v1Pus2 != null)
    {
      numArray2[index1] = numArray2[index1 - 1] + 1L;
      voaVubE9Md3v1PusArray2[index1++] = voaVubE9Md3v1Pus2;
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray2;
    this.\u0023\u003DzW7nezhQ\u003D = voaVubE9Md3v1PusArray2;
    this.\u0023\u003Dzc7AOiaQ\u003D = index1;
    return;
label_8:
    voaVubE9Md3v1Pus2 = (\u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D) null;
    goto label_4;
label_7:
    index1 = 0;
    goto label_3;
label_6:
    voaVubE9Md3v1PusArray2 = voaVubE9Md3v1PusArray1;
    goto label_2;
label_5:
    numArray2 = numArray1;
    goto label_1;
  }

  public void \u0023\u003DzYWVxyvY\u003D()
  {
    long[] numArray1 = new long[this.\u0023\u003Dzc7AOiaQ\u003D];
    if (true)
      goto label_3;
label_1:
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[] voaVubE9Md3v1PusArray1 = new \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[this.\u0023\u003Dzc7AOiaQ\u003D];
    if (true)
      goto label_4;
label_2:
    int index;
    if (true)
      index = 0;
    long[] numArray2;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[] voaVubE9Md3v1PusArray2;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      numArray2[index] = this.\u0023\u003Dzwz0Fwus\u003D[index];
      voaVubE9Md3v1PusArray2[index] = this.\u0023\u003DzW7nezhQ\u003D[index];
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray2;
    this.\u0023\u003DzW7nezhQ\u003D = voaVubE9Md3v1PusArray2;
    return;
label_4:
    voaVubE9Md3v1PusArray2 = voaVubE9Md3v1PusArray1;
    goto label_2;
label_3:
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
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[] voaVubE9Md3v1PusArray1 = new \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[length];
    if (true)
      goto label_4;
label_2:
    int index;
    if (true)
      index = 0;
    long[] numArray2;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D[] voaVubE9Md3v1PusArray2;
    for (; index < this.\u0023\u003Dzc7AOiaQ\u003D; ++index)
    {
      numArray2[index] = this.\u0023\u003Dzwz0Fwus\u003D[index];
      voaVubE9Md3v1PusArray2[index] = this.\u0023\u003DzW7nezhQ\u003D[index];
    }
    this.\u0023\u003Dzwz0Fwus\u003D = numArray2;
    this.\u0023\u003DzW7nezhQ\u003D = voaVubE9Md3v1PusArray2;
    return;
label_4:
    voaVubE9Md3v1PusArray2 = voaVubE9Md3v1PusArray1;
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

  public int \u0023\u003DzKyxPlKE\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzwz0Fwus\u003D.Length;
  }

  public \u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D \u0023\u003DzrqIE4Co\u003D(
    int _param1)
  {
    int num = _param1;
    if (true)
      ;
    if (true)
      ;
    int zc7AoiaQ = this.\u0023\u003Dzc7AOiaQ\u003D;
    if (num >= zc7AoiaQ)
      return (\u0023\u003DznUYq76l5YVG1oavp1Dpx2mjVOaVUbE9Md3v1Pus\u003D) null;
    if (true)
      ;
    return this.\u0023\u003DzW7nezhQ\u003D[_param1];
  }

  public long \u0023\u003DzMdH1w9A\u003D(int _param1)
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
