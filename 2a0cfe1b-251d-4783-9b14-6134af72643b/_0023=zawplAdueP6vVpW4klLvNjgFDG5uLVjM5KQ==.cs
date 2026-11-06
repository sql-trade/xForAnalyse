// Decompiled with JetBrains decompiler
// Type: #=zawplAdueP6vVpW4klLvNjgFDG5uLVjM5KQ==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Threading;

#nullable disable
internal static class \u0023\u003DzawplAdueP6vVpW4klLvNjgFDG5uLVjM5KQ\u003D\u003D
{
  internal static T \u0023\u003DzLPEK_sw\u003D<T>(this object _param0, Func<T> _param1)
  {
    object obj1 = _param0;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    object obj2;
    try
    {
      object obj3 = obj2;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      return _param1();
label_6:
      Monitor.Enter(obj3, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj2);
    }
label_2:
    obj2 = obj1;
    goto label_1;
  }

  internal static void \u0023\u003DzLPEK_sw\u003D(this object _param0, Action _param1)
  {
    object obj1 = _param0;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    object obj2;
    try
    {
      object obj3 = obj2;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      _param1();
      return;
label_6:
      Monitor.Enter(obj3, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj2);
    }
label_2:
    obj2 = obj1;
    goto label_1;
  }
}
