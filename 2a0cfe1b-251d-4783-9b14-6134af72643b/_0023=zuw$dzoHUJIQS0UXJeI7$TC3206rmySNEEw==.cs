// Decompiled with JetBrains decompiler
// Type: #=zuw$dzoHUJIQS0UXJeI7$TC3206rmySNEEw==
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
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

#nullable disable
[Editor(typeof (dje_zLCDDFCKTE5BG8B6742Q2E88S82DJDPYCNY22P6DVT2RN3EQ_ejd), typeof (UserControl))]
public sealed class \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D : 
  NotifyPropertyChangedBase
{
  private readonly Func<bool> \u0023\u003Dzwaf3OjM\u003D;
  private readonly Action<bool> \u0023\u003DzhBR43Qg\u003D;
  private bool \u0023\u003DzEdmOh1w\u003D;
  private bool \u0023\u003DzhV8QlRg\u003D;
  private ICommand \u0023\u003DzYthjMcd2PFzB;

  public \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D(
    Func<bool> _param1,
    Action<bool> _param2)
  {
    Func<bool> func = _param1;
    if (true)
      goto label_4;
label_1:
    Action<bool> action = _param2;
    if (true)
      goto label_5;
label_2:
    if (false)
      return;
    this.Enabled = false;
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

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public ICommand ShowHelpCommand
  {
    get
    {
      if (this.\u0023\u003DzYthjMcd2PFzB == null)
      {
        Action action = new Action(this.\u0023\u003DzfEMkZaLzRJFj);
        Func<bool> func1 = \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003DzhDMzgg9selFiKmsrYw\u003D\u003D;
        if (func1 == null)
        {
          Func<bool> func2 = new Func<bool>(\u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D.\u0023\u003DzSfDARWVbMVLqv1R_SfFGxj_RUnyS);
          if (false)
          {
            func1 = func2;
          }
          else
          {
            \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003DzhDMzgg9selFiKmsrYw\u003D\u003D = func2;
            func1 = func2;
          }
        }
        \u0023\u003DzO3Hy635DYfpBgWirlqr4mc_dh0wz bgWirlqr4mcDh0wz = new \u0023\u003DzO3Hy635DYfpBgWirlqr4mc_dh0wz(action, func1);
        if (true)
          this.\u0023\u003DzYthjMcd2PFzB = (ICommand) bgWirlqr4mcDh0wz;
      }
      return this.\u0023\u003DzYthjMcd2PFzB;
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public string HelpTooltip
  {
    get
    {
      return \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623810) + Environment.NewLine + \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623836);
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public BitmapImage ImageSource
  {
    get
    {
      return \u0023\u003DzISbK5nZKgAQb\u0024Ce\u0024sk39WNYd6ZRvMgLAgQ\u003D\u003D.\u0023\u003DzS2yzkCMR1_wb().\u0023\u003DzgpHJ6jmxWRak();
    }
  }

  private void \u0023\u003DzfEMkZaLzRJFj()
  {
    string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623747);
    if (false)
      return;
    \u0023\u003DzbPaOkZsoYiX\u0024znRic8goXIirFUd4n2smZOKAgsQ\u003D.\u0023\u003DzIcPTPIM\u003D(str);
  }

  [Serializable]
  private sealed class \u0023\u003DzewGRIik\u003D
  {
    public static readonly \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D.\u0023\u003DzewGRIik\u003D \u0023\u003DzahaWqVg\u003D;
    public static Func<bool> \u0023\u003DzhDMzgg9selFiKmsrYw\u003D\u003D;

    static \u0023\u003DzewGRIik\u003D()
    {
      \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D.\u0023\u003DzewGRIik\u003D zewGrIik = new \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D.\u0023\u003DzewGRIik\u003D();
      if (false)
        return;
      \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D = zewGrIik;
    }

    public \u0023\u003DzewGRIik\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal bool \u0023\u003DzSfDARWVbMVLqv1R_SfFGxj_RUnyS() => true;
  }
}
