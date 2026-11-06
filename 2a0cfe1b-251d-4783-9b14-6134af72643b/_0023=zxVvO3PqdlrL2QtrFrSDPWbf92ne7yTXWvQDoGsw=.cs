// Decompiled with JetBrains decompiler
// Type: #=zxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using ATAS.Indicators;
using System.Threading;

#nullable disable
internal sealed class \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw\u003D : 
  \u0023\u003Dzw9O91V2E\u0024DwRWFVXOiyD6o\u002471SzUmJrkB7_SBIk\u003D<\u0023\u003DzyRFVFmE2DzABTV6j50Wlc5y_AYMBluLFQw\u003D\u003D>
{
  private readonly IInstrumentInfo \u0023\u003DzF5IqXdKAD2dFECiqiYY4lC4\u003D;
  private readonly IPlatformSettings \u0023\u003Dzc5\u0024ihQ5s4WVc;
  private static readonly object \u0023\u003DzvgiL20o\u003D;
  private \u0023\u003DzyRFVFmE2DzABTV6j50Wlc5y_AYMBluLFQw\u003D\u003D \u0023\u003Dzb01mReLZDLqf;

  public \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw\u003D(
    IInstrumentInfo _param1,
    IPlatformSettings _param2)
    : base(30)
  {
    IInstrumentInfo iinstrumentInfo = _param1;
    if (true)
      goto label_4;
label_1:
    IPlatformSettings iplatformSettings = _param2;
    if (true)
      goto label_5;
label_2:
    \u0023\u003DzyRFVFmE2DzABTV6j50Wlc5y_AYMBluLFQw\u003D\u003D v6j50Wlc5yAymBluLfQw = new \u0023\u003DzyRFVFmE2DzABTV6j50Wlc5y_AYMBluLFQw\u003D\u003D(this.\u0023\u003DzF5IqXdKAD2dFECiqiYY4lC4\u003D.TickSize, this.\u0023\u003Dzc5\u0024ihQ5s4WVc.ValueAreaPercent);
    if (false)
      return;
    this.\u0023\u003Dzb01mReLZDLqf = v6j50Wlc5yAymBluLfQw;
    return;
label_5:
    this.\u0023\u003Dzc5\u0024ihQ5s4WVc = iplatformSettings;
    goto label_2;
label_4:
    this.\u0023\u003DzF5IqXdKAD2dFECiqiYY4lC4\u003D = iinstrumentInfo;
    goto label_1;
  }

  static \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw\u003D()
  {
    object obj = new object();
    if (false)
      return;
    \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw\u003D.\u0023\u003DzvgiL20o\u003D = obj;
  }

  public void \u0023\u003DzXmDGAd0\u003D()
  {
    object zvgiL20o = \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw\u003D.\u0023\u003DzvgiL20o\u003D;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      this.\u0023\u003Dzb01mReLZDLqf.\u0023\u003DzXmDGAd0\u003D(this.\u0023\u003Dzc5\u0024ihQ5s4WVc.ValueAreaPercent);
      this.\u0023\u003Dz4d\u0024gruM\u003D();
      return;
label_6:
      Monitor.Enter(obj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_2:
    obj1 = zvgiL20o;
    goto label_1;
  }

  public void \u0023\u003Dz9FHCPxg\u003D(IndicatorCandle _param1)
  {
    object zvgiL20o = \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw\u003D.\u0023\u003DzvgiL20o\u003D;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      this.\u0023\u003Dzb01mReLZDLqf.\u0023\u003Dz9FHCPxg\u003D(_param1);
      return;
label_6:
      Monitor.Enter(obj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_2:
    obj1 = zvgiL20o;
    goto label_1;
  }

  public void \u0023\u003DzsyynH9ONYfzf()
  {
    object zvgiL20o = \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw\u003D.\u0023\u003DzvgiL20o\u003D;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      this.\u0023\u003Dzdp0ADFc\u003D(this.\u0023\u003Dzb01mReLZDLqf.\u0023\u003Dzg24aHyx0vSBA().\u0023\u003DzEZrIxRMrKBVDNhwpug\u003D\u003D(), new \u0023\u003DzyRFVFmE2DzABTV6j50Wlc5y_AYMBluLFQw\u003D\u003D(this.\u0023\u003Dzb01mReLZDLqf));
      this.\u0023\u003Dzb01mReLZDLqf.\u0023\u003DzXmDGAd0\u003D();
      return;
label_6:
      Monitor.Enter(obj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_2:
    obj1 = zvgiL20o;
    goto label_1;
  }

  public \u0023\u003DzyRFVFmE2DzABTV6j50Wlc5y_AYMBluLFQw\u003D\u003D \u0023\u003Dz0vu6dtlPJQ6j()
  {
    object zvgiL20o = \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWbf92ne7yTXWvQDoGsw\u003D.\u0023\u003DzvgiL20o\u003D;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      return this.\u0023\u003Dzb01mReLZDLqf;
label_6:
      Monitor.Enter(obj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_2:
    obj1 = zvgiL20o;
    goto label_1;
  }
}
