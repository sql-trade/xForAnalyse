// Decompiled with JetBrains decompiler
// Type: -.dje_z28QZC7TDY7L57PS4RPCTYCD42CJZFMDYR6XLALKFQEDW4EJQ7U2V5_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Globalization;
using System.Windows.Data;

#nullable disable
namespace \u002D;

internal sealed class dje_z28QZC7TDY7L57PS4RPCTYCD42CJZFMDYR6XLALKFQEDW4EJQ7U2V5_ejd : 
  IValueConverter
{
  public dje_z28QZC7TDY7L57PS4RPCTYCD42CJZFMDYR6XLALKFQEDW4EJQ7U2V5_ejd()
  {
    if (true)
      ;
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }

  public object Convert(object _param1, Type _param2, object _param3, CultureInfo _param4)
  {
    object obj1 = _param1;
    if (true)
      ;
    object obj2 = _param3;
    if (true)
      ;
    return (object) obj1.Equals(obj2);
  }

  public object ConvertBack(object _param1, Type _param2, object _param3, CultureInfo _param4)
  {
    object obj1 = _param1;
    if (true)
      ;
    // ISSUE: variable of a boxed type
    __Boxed<bool> local = (ValueType) true;
    if (!obj1.Equals((object) local))
      return Binding.DoNothing;
    object obj2 = _param3;
    return false ? obj2 : obj2;
  }
}
