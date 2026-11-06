// Decompiled with JetBrains decompiler
// Type: #=znUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Threading;

#nullable disable
internal sealed class \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj
{
  private Decimal[] \u0023\u003DzZzeariM\u003D;
  private long[] \u0023\u003DzhgTF1CEx7IqG;
  private int \u0023\u003DzyGbEBmE\u003D;
  private int \u0023\u003DzBsigxhA\u003D;
  private Decimal \u0023\u003Dz8ZaVXKVOOegWSTZ9qg\u003D\u003D;

  public \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj()
  {
    if (true)
      goto label_3;
label_1:
    if (true)
      goto label_4;
label_2:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_4:
    this.\u0023\u003DzBsigxhA\u003D = -1;
    goto label_2;
label_3:
    this.\u0023\u003DzyGbEBmE\u003D = -1;
    goto label_1;
  }

  public void \u0023\u003DzzqCSRrs\u003D(
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj _param1)
  {
    Decimal[] zZzeariM = _param1.\u0023\u003DzZzeariM\u003D;
    if (true)
      goto label_4;
label_1:
    long[] zhgTf1Cex7IqG = _param1.\u0023\u003DzhgTF1CEx7IqG;
    if (true)
      goto label_5;
label_2:
    int zyGbEbmE = _param1.\u0023\u003DzyGbEBmE\u003D;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzBsigxhA\u003D = _param1.\u0023\u003DzBsigxhA\u003D;
    this.\u0023\u003Dz8ZaVXKVOOegWSTZ9qg\u003D\u003D = _param1.\u0023\u003Dz8ZaVXKVOOegWSTZ9qg\u003D\u003D;
    return;
label_6:
    this.\u0023\u003DzyGbEBmE\u003D = zyGbEbmE;
    goto label_3;
label_5:
    this.\u0023\u003DzhgTF1CEx7IqG = zhgTf1Cex7IqG;
    goto label_2;
label_4:
    this.\u0023\u003DzZzeariM\u003D = zZzeariM;
    goto label_1;
  }

  public void \u0023\u003DzEIuP_yE\u003D()
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      this.\u0023\u003DzZzeariM\u003D = (Decimal[]) null;
      this.\u0023\u003DzhgTF1CEx7IqG = (long[]) null;
      this.\u0023\u003DzyGbEBmE\u003D = -1;
      this.\u0023\u003DzBsigxhA\u003D = -1;
      this.\u0023\u003Dz8ZaVXKVOOegWSTZ9qg\u003D\u003D = 0M;
      return;
label_6:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public int \u0023\u003DzryycxJ6KkUeujlsb5g\u003D\u003D(int _param1)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      if (this.\u0023\u003DzZzeariM\u003D == null)
        return int.MinValue;
      for (int index = Math.Max(0, Math.Min(_param1 - this.\u0023\u003DzyGbEBmE\u003D, this.\u0023\u003DzZzeariM\u003D.Length - 1)); index < this.\u0023\u003DzZzeariM\u003D.Length; ++index)
      {
        if (this.\u0023\u003DzZzeariM\u003D[index] != 0M)
          return index + this.\u0023\u003DzyGbEBmE\u003D;
      }
      return int.MinValue;
label_6:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public int \u0023\u003DzIivJlGshYVfo7QMn6A\u003D\u003D(int _param1)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      if (this.\u0023\u003DzZzeariM\u003D == null)
        return int.MinValue;
      for (int index = Math.Max(0, Math.Min(_param1 - this.\u0023\u003DzyGbEBmE\u003D, this.\u0023\u003DzZzeariM\u003D.Length - 1)); index >= 0; --index)
      {
        if (this.\u0023\u003DzZzeariM\u003D[index] != 0M)
          return index + this.\u0023\u003DzyGbEBmE\u003D;
      }
      return int.MinValue;
label_6:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public Decimal \u0023\u003DzrqIE4Co\u003D(int _param1)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      return this.\u0023\u003DzZzeariM\u003D == null || _param1 < this.\u0023\u003DzyGbEBmE\u003D || _param1 > this.\u0023\u003DzBsigxhA\u003D ? 0M : this.\u0023\u003DzZzeariM\u003D[_param1 - this.\u0023\u003DzyGbEBmE\u003D];
label_6:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public double \u0023\u003DzB8NjpGBXMWDE(int _param1, int _param2)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      if (this.\u0023\u003DzZzeariM\u003D == null || _param1 > this.\u0023\u003DzBsigxhA\u003D || _param2 < this.\u0023\u003DzyGbEBmE\u003D)
        return 0.0;
      Decimal num1 = 0M;
      int num2 = 0;
      int num3 = Math.Min(Math.Max(this.\u0023\u003DzyGbEBmE\u003D, _param1), this.\u0023\u003DzBsigxhA\u003D) - this.\u0023\u003DzyGbEBmE\u003D;
      int num4 = Math.Min(Math.Max(this.\u0023\u003DzyGbEBmE\u003D, _param2), this.\u0023\u003DzBsigxhA\u003D) - this.\u0023\u003DzyGbEBmE\u003D;
      for (int index = num3; index <= num4; ++index)
      {
        num1 += this.\u0023\u003DzZzeariM\u003D[index];
        ++num2;
      }
      return num2 == 0 ? 0.0 : (double) num1 / (double) num2;
label_6:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public Decimal \u0023\u003DzGkvHwH8\u003D(int _param1, int _param2)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      if (this.\u0023\u003DzZzeariM\u003D == null)
        return 0.0M;
      if (_param1 > this.\u0023\u003DzBsigxhA\u003D || _param2 < this.\u0023\u003DzyGbEBmE\u003D)
        return 0.0M;
      Decimal num1 = 0M;
      int num2 = Math.Min(Math.Max(this.\u0023\u003DzyGbEBmE\u003D, _param1), this.\u0023\u003DzBsigxhA\u003D) - this.\u0023\u003DzyGbEBmE\u003D;
      int num3 = Math.Min(Math.Max(this.\u0023\u003DzyGbEBmE\u003D, _param2), this.\u0023\u003DzBsigxhA\u003D) - this.\u0023\u003DzyGbEBmE\u003D;
      for (int index = num2; index <= num3; ++index)
        num1 += this.\u0023\u003DzZzeariM\u003D[index];
      return num1;
label_6:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public void \u0023\u003DznHIptOvInAHx(
    \u0023\u003DzBENocXgy9xRT0hbXuA\u003D\u003D _param1,
    int _param2,
    int _param3)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_7;
label_5:
      if (this.\u0023\u003DzZzeariM\u003D == null || _param2 > this.\u0023\u003DzBsigxhA\u003D || _param3 < this.\u0023\u003DzyGbEBmE\u003D)
        return;
      int num1 = Math.Min(Math.Max(this.\u0023\u003DzyGbEBmE\u003D, _param2), this.\u0023\u003DzBsigxhA\u003D) - this.\u0023\u003DzyGbEBmE\u003D;
      int num2 = Math.Min(Math.Max(this.\u0023\u003DzyGbEBmE\u003D, _param3), this.\u0023\u003DzBsigxhA\u003D) - this.\u0023\u003DzyGbEBmE\u003D;
      for (int index = num1; index <= num2; ++index)
        _param1.\u0023\u003DzBNgHZs9ctdp4(this.\u0023\u003DzZzeariM\u003D[index]);
      return;
label_7:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public (int, Decimal) \u0023\u003DzVU40Z_Q7xZQQ()
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      if (this.\u0023\u003DzZzeariM\u003D == null)
        return (int.MinValue, Decimal.MinValue);
      Decimal num1 = 0.0M;
      Decimal num2 = 0.0M;
      int num3 = 0;
      for (int index = 0; index < this.\u0023\u003DzZzeariM\u003D.Length; ++index)
      {
        num2 += this.\u0023\u003DzZzeariM\u003D[index];
        if (this.\u0023\u003DzZzeariM\u003D[index] > num1)
        {
          num1 = this.\u0023\u003DzZzeariM\u003D[index];
          num3 = index;
        }
      }
      return (num3 + this.\u0023\u003DzyGbEBmE\u003D, num2);
label_6:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public bool \u0023\u003DzXuYgVAc\u003D(int _param1, Decimal _param2, long _param3, bool _param4)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj1;
    try
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2sh4VI1Frbu4VLeQRT86HPQj frbu4VleQrT86HpQj2 = frbu4VleQrT86HpQj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      if (this.\u0023\u003DzZzeariM\u003D == null)
      {
        Decimal[] numArray = new Decimal[1];
        if (true)
          goto label_9;
label_8:
        this.\u0023\u003DzhgTF1CEx7IqG = new long[1];
        this.\u0023\u003DzyGbEBmE\u003D = _param1;
        this.\u0023\u003DzBsigxhA\u003D = _param1;
        goto label_10;
label_9:
        this.\u0023\u003DzZzeariM\u003D = numArray;
        goto label_8;
      }
label_10:
      if (_param1 > this.\u0023\u003DzBsigxhA\u003D)
      {
        this.\u0023\u003DzBsigxhA\u003D = _param1 + Math.Min(1000, int.MaxValue - _param1 - 1);
        this.\u0023\u003DzKjninEY\u003D(this.\u0023\u003DzBsigxhA\u003D - this.\u0023\u003DzyGbEBmE\u003D + 1, 0);
      }
      if (_param1 < this.\u0023\u003DzyGbEBmE\u003D)
      {
        this.\u0023\u003DzyGbEBmE\u003D = Math.Max(_param1 - 1000, 0);
        this.\u0023\u003DzKjninEY\u003D(this.\u0023\u003DzBsigxhA\u003D - this.\u0023\u003DzyGbEBmE\u003D + 1, this.\u0023\u003DzBsigxhA\u003D - this.\u0023\u003DzyGbEBmE\u003D + 1 - this.\u0023\u003DzZzeariM\u003D.Length);
      }
      if (_param1 - this.\u0023\u003DzyGbEBmE\u003D < 0 || _param1 - this.\u0023\u003DzyGbEBmE\u003D > this.\u0023\u003DzZzeariM\u003D.Length || this.\u0023\u003DzhgTF1CEx7IqG[_param1 - this.\u0023\u003DzyGbEBmE\u003D] > _param3)
        return false;
      this.\u0023\u003Dz8ZaVXKVOOegWSTZ9qg\u003D\u003D = this.\u0023\u003DzZzeariM\u003D[_param1 - this.\u0023\u003DzyGbEBmE\u003D];
      this.\u0023\u003DzZzeariM\u003D[_param1 - this.\u0023\u003DzyGbEBmE\u003D] = _param4 ? _param2 + this.\u0023\u003Dz8ZaVXKVOOegWSTZ9qg\u003D\u003D : _param2;
      this.\u0023\u003DzhgTF1CEx7IqG[_param1 - this.\u0023\u003DzyGbEBmE\u003D] = _param3;
      return true;
label_6:
      Monitor.Enter((object) frbu4VleQrT86HpQj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) frbu4VleQrT86HpQj1);
    }
label_2:
    frbu4VleQrT86HpQj1 = this;
    goto label_1;
  }

  public Decimal \u0023\u003Dz4AyfnT7SvfAfdrGklw\u003D\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dz8ZaVXKVOOegWSTZ9qg\u003D\u003D;
  }

  private void \u0023\u003DzKjninEY\u003D(int _param1, int _param2)
  {
    Decimal[] numArray1 = new Decimal[_param1];
    if (true)
      goto label_4;
label_1:
    long[] numArray2 = new long[_param1];
    if (true)
      goto label_5;
label_2:
    if (true)
      goto label_6;
label_3:
    int index1 = 0;
    Decimal[] numArray3;
    long[] numArray4;
    int index2;
    for (; index2 < numArray3.Length; ++index2)
    {
      if (index2 >= _param2 && index1 < this.\u0023\u003DzZzeariM\u003D.Length)
      {
        numArray3[index2] = this.\u0023\u003DzZzeariM\u003D[index1];
        numArray4[index2] = this.\u0023\u003DzhgTF1CEx7IqG[index1++];
      }
      else
      {
        numArray3[index2] = 0M;
        numArray4[index2] = 0L;
      }
    }
    this.\u0023\u003DzZzeariM\u003D = numArray3;
    this.\u0023\u003DzhgTF1CEx7IqG = numArray4;
    return;
label_6:
    index2 = 0;
    goto label_3;
label_5:
    numArray4 = numArray2;
    goto label_2;
label_4:
    numArray3 = numArray1;
    goto label_1;
  }
}
