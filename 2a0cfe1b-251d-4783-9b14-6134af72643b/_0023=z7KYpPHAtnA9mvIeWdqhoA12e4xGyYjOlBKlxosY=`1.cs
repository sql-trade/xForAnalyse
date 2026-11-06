// Decompiled with JetBrains decompiler
// Type: #=z7KYpPHAtnA9mvIeWdqhoA12e4xGyYjOlBKlxosY=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
internal sealed class \u0023\u003Dz7KYpPHAtnA9mvIeWdqhoA12e4xGyYjOlBKlxosY\u003D<\u0023\u003Dz4UEwosY\u003D>
{
  private readonly int \u0023\u003DzYScMhFz\u0024sLwz;
  private List<\u0023\u003Dz4UEwosY\u003D[]> \u0023\u003DzW7nezhQ\u003D;
  private readonly \u0023\u003Dz4UEwosY\u003D \u0023\u003DzMLInbxSWPbQ3;

  public \u0023\u003Dz7KYpPHAtnA9mvIeWdqhoA12e4xGyYjOlBKlxosY\u003D(
    int _param1,
    \u0023\u003Dz4UEwosY\u003D _param2)
  {
    if (true)
      goto label_4;
label_1:
    List<\u0023\u003Dz4UEwosY\u003D[]> z4UewosYArrayList = new List<\u0023\u003Dz4UEwosY\u003D[]>();
    if (true)
      goto label_5;
label_2:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    \u0023\u003Dz4UEwosY\u003D z4UewosY = _param2;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzM7_m0WprFPXz(_param1);
    return;
label_6:
    this.\u0023\u003DzMLInbxSWPbQ3 = z4UewosY;
    goto label_3;
label_5:
    this.\u0023\u003DzW7nezhQ\u003D = z4UewosYArrayList;
    goto label_2;
label_4:
    this.\u0023\u003DzYScMhFz\u0024sLwz = 100;
    goto label_1;
  }

  private void \u0023\u003DzM7_m0WprFPXz(int _param1)
  {
    while (this.\u0023\u003DzW7nezhQ\u003D.Count * this.\u0023\u003DzYScMhFz\u0024sLwz <= _param1)
    {
      \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray1 = new \u0023\u003Dz4UEwosY\u003D[this.\u0023\u003DzYScMhFz\u0024sLwz];
      if (true)
        goto label_4;
label_2:
      int index;
      if (true)
        index = 0;
      \u0023\u003Dz4UEwosY\u003D[] z4UewosYArray2;
      while (index < this.\u0023\u003DzYScMhFz\u0024sLwz)
      {
        z4UewosYArray2[index] = this.\u0023\u003DzMLInbxSWPbQ3;
        int num = index + 1;
        if (true)
          index = num;
      }
      this.\u0023\u003DzW7nezhQ\u003D.Add(z4UewosYArray2);
      continue;
label_4:
      z4UewosYArray2 = z4UewosYArray1;
      goto label_2;
    }
  }

  [IndexerName("#=zJaGUfoA=")]
  public \u0023\u003Dz4UEwosY\u003D this[int _param1]
  {
    get
    {
      int num = _param1;
      if (true)
        goto label_2;
label_1:
      return this.\u0023\u003DzW7nezhQ\u003D[_param1 / this.\u0023\u003DzYScMhFz\u0024sLwz][_param1 % this.\u0023\u003DzYScMhFz\u0024sLwz];
label_2:
      this.\u0023\u003DzM7_m0WprFPXz(num);
      goto label_1;
    }
    set
    {
      int num = _param1;
      if (true)
        goto label_2;
label_1:
      this.\u0023\u003DzW7nezhQ\u003D[_param1 / this.\u0023\u003DzYScMhFz\u0024sLwz][_param1 % this.\u0023\u003DzYScMhFz\u0024sLwz] = value;
      return;
label_2:
      this.\u0023\u003DzM7_m0WprFPXz(num);
      goto label_1;
    }
  }

  public \u0023\u003Dz4UEwosY\u003D \u0023\u003Dzck4aaec\u003D(int _param1)
  {
    int num = _param1;
    if (true)
      goto label_2;
label_1:
    return this.\u0023\u003DzW7nezhQ\u003D[_param1 / this.\u0023\u003DzYScMhFz\u0024sLwz][_param1 % this.\u0023\u003DzYScMhFz\u0024sLwz];
label_2:
    this.\u0023\u003DzM7_m0WprFPXz(num);
    goto label_1;
  }

  public void \u0023\u003DzR2hIsOM\u003D(int _param1, \u0023\u003Dz4UEwosY\u003D _param2)
  {
    int num = _param1;
    if (true)
      goto label_2;
label_1:
    this.\u0023\u003DzW7nezhQ\u003D[_param1 / this.\u0023\u003DzYScMhFz\u0024sLwz][_param1 % this.\u0023\u003DzYScMhFz\u0024sLwz] = _param2;
    return;
label_2:
    this.\u0023\u003DzM7_m0WprFPXz(num);
    goto label_1;
  }
}
