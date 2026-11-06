// Decompiled with JetBrains decompiler
// Type: #=zSDMx8UAFbbtHgpM8wsrFbSyepbVu7Z69og==
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
[Editor(typeof (dje_zTP7UYPKKB9EQZ4ABLVAWD4ZWJF348R3VN8Y9U9XK_ejd), typeof (UserControl))]
public sealed class \u0023\u003DzSDMx8UAFbbtHgpM8wsrFbSyepbVu7Z69og\u003D\u003D : 
  NotifyPropertyChangedBase
{
  private readonly Func<int> \u0023\u003Dzwaf3OjM\u003D;
  private readonly Action<int> \u0023\u003DzhBR43Qg\u003D;
  private int \u0023\u003DzEdmOh1w\u003D;
  private bool \u0023\u003DzhV8QlRg\u003D;
  private int \u0023\u003Dzmi_gHEQ\u003D;
  private int \u0023\u003DzWO1c0lw\u003D;
  private int \u0023\u003DzoBM0iLeDZAIQ;
  private int \u0023\u003Dz5qyW9DCpMz8T;
  private int \u0023\u003Dzu8Omp2PhCKid;

  public \u0023\u003DzSDMx8UAFbbtHgpM8wsrFbSyepbVu7Z69og\u003D\u003D(
    Func<int> _param1,
    Action<int> _param2,
    int _param3,
    int _param4,
    int _param5,
    int _param6,
    int _param7)
  {
    if (true)
      ;
    Func<int> func = _param1;
    if (true)
      ;
    Action<int> action = _param2;
    if (true)
      ;
    int num1 = _param3;
    int num2 = _param4;
    int num3 = _param5;
    int num4 = _param6;
    int num5 = _param7;
    // ISSUE: explicit constructor call
    this.\u002Ector(func, action, num1, num2, num3, num4, num5, false);
  }

  public \u0023\u003DzSDMx8UAFbbtHgpM8wsrFbSyepbVu7Z69og\u003D\u003D(
    Func<int> _param1,
    Action<int> _param2,
    int _param3,
    int _param4,
    int _param5,
    int _param6,
    int _param7,
    bool _param8)
  {
    if (true)
      goto label_4;
label_1:
    if (true)
      goto label_5;
label_2:
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003Dzu8Omp2PhCKid = 5;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.\u0023\u003Dzwaf3OjM\u003D = _param1;
    this.\u0023\u003DzhBR43Qg\u003D = _param2;
    this.Enabled = _param8;
    this.Maximum = _param4;
    this.Minimum = _param3;
    this.SmallChange = _param5;
    this.LargeChange = _param6;
    this.TickFrequency = _param7;
    return;
label_6:
    this.\u0023\u003Dz5qyW9DCpMz8T = 5;
    goto label_3;
label_5:
    this.\u0023\u003DzoBM0iLeDZAIQ = 1;
    goto label_2;
label_4:
    this.\u0023\u003DzWO1c0lw\u003D = 100;
    goto label_1;
  }

  [Browsable(false)]
  public int Value
  {
    get
    {
      int num = this.\u0023\u003Dzwaf3OjM\u003D();
      if (true)
        goto label_2;
label_1:
      return this.\u0023\u003DzEdmOh1w\u003D;
label_2:
      this.\u0023\u003DzEdmOh1w\u003D = num;
      goto label_1;
    }
    set
    {
      this.\u0023\u003DzhBR43Qg\u003D(value);
      ref int local = ref this.\u0023\u003DzEdmOh1w\u003D;
      int num = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623586);
      if (false)
        return;
      this.SetProperty<int>(ref local, num, str, (Action) null);
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public int Minimum
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dzmi_gHEQ\u003D;
    }
    set
    {
      ref int local = ref this.\u0023\u003Dzmi_gHEQ\u003D;
      int num = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639301);
      if (false)
        return;
      this.SetProperty<int>(ref local, num, str, (Action) null);
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public int Maximum
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzWO1c0lw\u003D;
    }
    set
    {
      ref int local = ref this.\u0023\u003DzWO1c0lw\u003D;
      int num = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639319);
      if (false)
        return;
      this.SetProperty<int>(ref local, num, str, (Action) null);
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public int LargeChange
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz5qyW9DCpMz8T;
    }
    set
    {
      ref int local = ref this.\u0023\u003Dz5qyW9DCpMz8T;
      int num = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639265);
      if (false)
        return;
      this.SetProperty<int>(ref local, num, str, (Action) null);
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public int SmallChange
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzoBM0iLeDZAIQ;
    }
    set
    {
      ref int local = ref this.\u0023\u003DzoBM0iLeDZAIQ;
      int num = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639287);
      if (false)
        return;
      this.SetProperty<int>(ref local, num, str, (Action) null);
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public int TickFrequency
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dzu8Omp2PhCKid;
    }
    set
    {
      ref int local = ref this.\u0023\u003Dzu8Omp2PhCKid;
      int num = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639237);
      if (false)
        return;
      this.SetProperty<int>(ref local, num, str, (Action) null);
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
