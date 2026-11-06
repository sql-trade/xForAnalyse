// Decompiled with JetBrains decompiler
// Type: #=znUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using \u002D;
using ATAS.Indicators;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using System.Xml.Serialization;

#nullable enable
[Editor(typeof (dje_z8V9QFVH4LRDM2GK2H2ZFRGYU45Z4SHVM7DZUMHM3YXDMM6Q_ejd), typeof (UserControl))]
public sealed class \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<\u0023\u003Dz4UEwosY\u003D> : 
  NotifyPropertyChangedBase
  where \u0023\u003Dz4UEwosY\u003D : 
  #nullable disable
  Window
{
  private Window \u0023\u003DzAmAokZ8\u003D;
  private Func<\u0023\u003Dz4UEwosY\u003D> \u0023\u003Dz8cfsuTc\u003D;
  private ICommand \u0023\u003DzVmIyRTSb0JiM;
  private bool \u0023\u003Dznh2ICH3Xubjd;
  private Point \u0023\u003DztQRxbWM\u003D;
  private bool \u0023\u003DzenA3jabeuNYT;

  public \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D(
    Func<\u0023\u003Dz4UEwosY\u003D> _param1)
  {
    Func<\u0023\u003Dz4UEwosY\u003D> func = _param1;
    if (true)
      goto label_3;
label_1:
    Point point = new Point(double.NaN, double.NaN);
    if (true)
      goto label_4;
label_2:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_4:
    this.\u0023\u003DztQRxbWM\u003D = point;
    goto label_2;
label_3:
    this.\u0023\u003Dz8cfsuTc\u003D = func;
    goto label_1;
  }

  [Browsable(false)]
  public bool IsOpen
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dznh2ICH3Xubjd;
    }
    set
    {
      if (this.\u0023\u003Dznh2ICH3Xubjd == value)
        return;
      ref bool local = ref this.\u0023\u003Dznh2ICH3Xubjd;
      int num = value ? 1 : 0;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638698);
      if (false)
        return;
      this.SetProperty<bool>(ref local, num != 0, str, (Action) null);
    }
  }

  [Browsable(false)]
  public Point Location
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DztQRxbWM\u003D;
    }
    set
    {
      if (this.\u0023\u003DztQRxbWM\u003D.X == value.X && this.\u0023\u003DztQRxbWM\u003D.Y == value.Y)
        return;
      ref Point local = ref this.\u0023\u003DztQRxbWM\u003D;
      Point point = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638709);
      if (false)
        return;
      this.SetProperty<Point>(ref local, point, str, (Action) null);
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public ICommand OpenWindowCommand
  {
    get
    {
      if (this.\u0023\u003DzVmIyRTSb0JiM == null)
      {
        Action action = new Action(this.\u0023\u003DzMBf7m1s\u003D);
        Func<bool> func1 = \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<\u0023\u003Dz4UEwosY\u003D>.\u0023\u003DzewGRIik\u003D.\u0023\u003DzQRmt9ShrvIfrUytovA\u003D\u003D;
        if (func1 == null)
        {
          Func<bool> func2 = new Func<bool>(\u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<\u0023\u003Dz4UEwosY\u003D>.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D.\u0023\u003DzNDeeKdHuX8TZ8CLsyFk8PeE\u003D);
          if (false)
          {
            func1 = func2;
          }
          else
          {
            \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<\u0023\u003Dz4UEwosY\u003D>.\u0023\u003DzewGRIik\u003D.\u0023\u003DzQRmt9ShrvIfrUytovA\u003D\u003D = func2;
            func1 = func2;
          }
        }
        \u0023\u003DzO3Hy635DYfpBgWirlqr4mc_dh0wz bgWirlqr4mcDh0wz = new \u0023\u003DzO3Hy635DYfpBgWirlqr4mc_dh0wz(action, func1);
        if (true)
          this.\u0023\u003DzVmIyRTSb0JiM = (ICommand) bgWirlqr4mcDh0wz;
      }
      return this.\u0023\u003DzVmIyRTSb0JiM;
    }
  }

  public void \u0023\u003DzMBf7m1s\u003D()
  {
    if (true)
      goto label_2;
label_1:
    Application.Current.Dispatcher.BeginInvoke((Delegate) new Action(this.\u0023\u003DzgmsTWv2Jao7B3IxL4gIb1O0\u003D));
    return;
label_2:
    this.IsOpen = true;
    goto label_1;
  }

  public void \u0023\u003Dz1PYRF8Q\u003D()
  {
    if (true)
      goto label_2;
label_1:
    Application.Current.Dispatcher.BeginInvoke((Delegate) new Action(this.\u0023\u003Dzra2iGrS0COdWnIJ\u0024ASmEsik\u003D));
    return;
label_2:
    this.\u0023\u003DzenA3jabeuNYT = true;
    goto label_1;
  }

  public void \u0023\u003DzK7ksNZI\u003D()
  {
    Dispatcher dispatcher = Application.Current.Dispatcher;
    if (true)
      ;
    // ISSUE: method pointer
    Action method = new Action((object) this, __methodptr(\u0023\u003DzCWGImK7jCdh2cPFqVa8KdME\u003D));
    object[] objArray = Array.Empty<object>();
    dispatcher.BeginInvoke((Delegate) method, objArray);
    if (false)
      ;
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public string OpenWindowText
  {
    get => \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.OpenWindowText;
  }

  private void \u0023\u003DzgmsTWv2Jao7B3IxL4gIb1O0\u003D()
  {
    ref Window local = ref this.\u0023\u003DzAmAokZ8\u003D;
    Func<\u0023\u003Dz4UEwosY\u003D> z8cfsuTc = this.\u0023\u003Dz8cfsuTc\u003D;
    Action action1 = new Action(this.\u0023\u003DzG5ah92RRrerYkFV7Fz6qwsQ\u003D);
    Action<Window> action2 = new Action<Window>(this.\u0023\u003DzhGL6X9DxwouMuPFBOuDwIzA\u003D);
    Point location = this.Location;
    if (false)
      return;
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzKLKYe4bjOAt1<Window>(ref local, (Func<Window>) z8cfsuTc, action1, action2, location);
  }

  private void \u0023\u003DzG5ah92RRrerYkFV7Fz6qwsQ\u003D()
  {
    if (true)
      goto label_4;
label_1:
    if (true)
      goto label_5;
label_2:
    if (this.\u0023\u003DzenA3jabeuNYT)
      return;
    Point point = new Point(double.NaN, double.NaN);
    if (false)
      return;
    this.Location = point;
    return;
label_5:
    this.IsOpen = false;
    goto label_2;
label_4:
    this.\u0023\u003DzAmAokZ8\u003D = (Window) null;
    goto label_1;
  }

  private void \u0023\u003DzhGL6X9DxwouMuPFBOuDwIzA\u003D(
  #nullable enable
  Window _param1)
  {
    Point point = new Point(_param1.Left, _param1.Top);
    if (false)
      return;
    this.Location = point;
  }

  private void \u0023\u003Dzra2iGrS0COdWnIJ\u0024ASmEsik\u003D()
  {
    this.\u0023\u003DzAmAokZ8\u003D?.Close();
    if (false)
      return;
    this.\u0023\u003DzAmAokZ8\u003D = (Window) null;
  }

  private void \u0023\u003DzCWGImK7jCdh2cPFqVa8KdME\u003D()
  {
    if (true)
      ;
    if (this.\u0023\u003DzAmAokZ8\u003D == null)
      return;
    if (true)
      ;
    this.\u0023\u003DzAmAokZ8\u003D.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentUICulture.IetfLanguageTag);
  }

  [Serializable]
  private sealed class \u0023\u003DzewGRIik\u003D
  {
    public static readonly 
    #nullable disable
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<\u0023\u003Dz4UEwosY\u003D>.\u0023\u003DzewGRIik\u003D \u0023\u003DzahaWqVg\u003D;
    public static Func<bool> \u0023\u003DzQRmt9ShrvIfrUytovA\u003D\u003D;

    static \u0023\u003DzewGRIik\u003D()
    {
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<\u0023\u003Dz4UEwosY\u003D>.\u0023\u003DzewGRIik\u003D zewGrIik = new \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<\u0023\u003Dz4UEwosY\u003D>.\u0023\u003DzewGRIik\u003D();
      if (false)
        return;
      \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<\u0023\u003Dz4UEwosY\u003D>.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D = zewGrIik;
    }

    public \u0023\u003DzewGRIik\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal bool \u0023\u003DzNDeeKdHuX8TZ8CLsyFk8PeE\u003D() => true;
  }
}
