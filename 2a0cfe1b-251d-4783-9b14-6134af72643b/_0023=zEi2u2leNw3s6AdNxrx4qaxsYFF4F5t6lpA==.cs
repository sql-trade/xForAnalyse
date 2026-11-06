// Decompiled with JetBrains decompiler
// Type: #=zEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using \u002D;
using ATAS.Indicators;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Windows.Controls;
using System.Xml.Serialization;

#nullable disable
[Editor(typeof (dje_zWM26HCWGAK2KKN74MYM77PK3S6GXM4K7QPZWYRC9_ejd), typeof (UserControl))]
public sealed class \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D : 
  NotifyPropertyChangedBase
{
  private readonly Func<bool> \u0023\u003Dzwaf3OjM\u003D;
  private readonly Action<bool> \u0023\u003DzhBR43Qg\u003D;
  private bool \u0023\u003DzEdmOh1w\u003D;
  private bool \u0023\u003DzhV8QlRg\u003D;

  public \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D(
    Func<bool> _param1,
    Action<bool> _param2)
  {
    if (true)
      ;
    Func<bool> func = _param1;
    if (true)
      ;
    Action<bool> action = _param2;
    if (true)
      ;
    // ISSUE: explicit constructor call
    this.\u002Ector(func, action, false);
  }

  public \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D(
    Func<bool> _param1,
    Action<bool> _param2,
    bool _param3)
  {
    Func<bool> func = _param1;
    if (true)
      goto label_4;
label_1:
    Action<bool> action = _param2;
    if (true)
      goto label_5;
label_2:
    int num = _param3 ? 1 : 0;
    if (false)
      return;
    this.Enabled = num != 0;
    return;
label_5:
    this.\u0023\u003DzhBR43Qg\u003D = action;
    goto label_2;
label_4:
    this.\u0023\u003Dzwaf3OjM\u003D = func;
    goto label_1;
  }

  [Browsable(false)]
  public bool Value
  {
    get
    {
      int num = this.\u0023\u003Dzwaf3OjM\u003D() ? 1 : 0;
      if (true)
        goto label_2;
label_1:
      return this.\u0023\u003DzEdmOh1w\u003D;
label_2:
      this.\u0023\u003DzEdmOh1w\u003D = num != 0;
      goto label_1;
    }
    set
    {
      this.\u0023\u003DzhBR43Qg\u003D(value);
      ref bool local = ref this.\u0023\u003DzEdmOh1w\u003D;
      int num = value ? 1 : 0;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623586);
      if (false)
        return;
      this.SetProperty<bool>(ref local, num != 0, str, (Action) null);
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public bool Enabled
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzhV8QlRg\u003D;
    }
    set
    {
      ref bool local = ref this.\u0023\u003DzhV8QlRg\u003D;
      int num = value ? 1 : 0;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623598);
      if (false)
        return;
      this.SetProperty<bool>(ref local, num != 0, str, (Action) null);
    }
  }
}
