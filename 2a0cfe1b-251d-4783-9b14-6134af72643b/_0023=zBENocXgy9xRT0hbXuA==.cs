// Decompiled with JetBrains decompiler
// Type: #=zBENocXgy9xRT0hbXuA==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public sealed class \u0023\u003DzBENocXgy9xRT0hbXuA\u003D\u003D : List<Decimal>
{
  private readonly int \u0023\u003Dz6TXpgFsx5nSj;
  private Decimal \u0023\u003Dzs5NQJu6TnYlm;

  public \u0023\u003DzBENocXgy9xRT0hbXuA\u003D\u003D(int _param1)
  {
    if (true)
      goto label_4;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    int num = _param1;
    if (true)
      goto label_5;
label_2:
    if (false)
      return;
    this.Clear();
    return;
label_5:
    this.\u0023\u003Dz6TXpgFsx5nSj = num;
    goto label_2;
label_4:
    this.\u0023\u003Dzs5NQJu6TnYlm = Decimal.MaxValue;
    goto label_1;
  }

  public void \u0023\u003DzBNgHZs9ctdp4(Decimal _param1)
  {
    if (this.Count < this.\u0023\u003Dz6TXpgFsx5nSj)
    {
      Decimal num1 = _param1;
      if (true)
        goto label_4;
label_2:
      Decimal num2 = Math.Min(this.\u0023\u003Dzs5NQJu6TnYlm, _param1);
      if (false)
        return;
      this.\u0023\u003Dzs5NQJu6TnYlm = num2;
      return;
label_4:
      this.Add(num1);
      goto label_2;
    }
    if (_param1 < this.\u0023\u003Dzs5NQJu6TnYlm)
      return;
    Decimal num = _param1;
    if (false)
      return;
    this.Add(num);
  }

  public Decimal \u0023\u003DzGkvHwH8\u003D()
  {
    if (true)
      goto label_2;
label_1:
    if (this.Count > this.\u0023\u003Dz6TXpgFsx5nSj)
    {
      int z6TxpgFsx5nSj = this.\u0023\u003Dz6TXpgFsx5nSj;
      int count = this.Count - this.\u0023\u003Dz6TXpgFsx5nSj;
      if (true)
        this.RemoveRange(z6TxpgFsx5nSj, count);
    }
    return this.Sum();
label_2:
    this.Sort();
    goto label_1;
  }
}
