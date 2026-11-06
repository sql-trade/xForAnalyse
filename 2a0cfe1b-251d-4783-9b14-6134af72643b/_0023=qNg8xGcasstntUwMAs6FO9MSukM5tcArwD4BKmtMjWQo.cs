// Decompiled with JetBrains decompiler
// Type: #=qNg8xGcasstntUwMAs6FO9MSukM5tcArwD4BKmtMjWQo=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections.Generic;
using System.Threading;

#nullable disable
internal sealed class \u0023\u003DqNg8xGcasstntUwMAs6FO9MSukM5tcArwD4BKmtMjWQo\u003D
{
  private object \u0023\u003Dzv_DK75M\u003D;
  private Dictionary<\u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D, \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D> \u0023\u003DzOsmxM1I\u003D;

  public \u0023\u003DqNg8xGcasstntUwMAs6FO9MSukM5tcArwD4BKmtMjWQo\u003D()
  {
    object obj = new object();
    if (true)
      goto label_2;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_2:
    this.\u0023\u003Dzv_DK75M\u003D = obj;
    goto label_1;
  }

  internal \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D \u0023\u003DzmOcLzigk1Bvc2AcfQY56MWjgu\u00241BIKLPqODpWqg\u003D(
    \u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D _param1)
  {
    if (_param1 == null)
      throw new ArgumentNullException();
    object zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    if (true)
      goto label_4;
label_3:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_8;
label_7:
      if (this.\u0023\u003DzOsmxM1I\u003D == null)
        this.\u0023\u003DzOsmxM1I\u003D = new Dictionary<\u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D, \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D>();
      \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D sx217qu42N2yhQdqKp2aQ;
      if (!this.\u0023\u003DzOsmxM1I\u003D.TryGetValue(_param1, out sx217qu42N2yhQdqKp2aQ))
      {
        sx217qu42N2yhQdqKp2aQ = new \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D(_param1);
        this.\u0023\u003DzOsmxM1I\u003D[_param1] = sx217qu42N2yhQdqKp2aQ;
      }
      return sx217qu42N2yhQdqKp2aQ;
label_8:
      Monitor.Enter(obj2, ref local);
      goto label_7;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_4:
    obj1 = zvDk75M;
    goto label_3;
  }
}
