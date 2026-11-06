// Decompiled with JetBrains decompiler
// Type: #=zcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using \u002D;
using ATAS.Indicators;
using Newtonsoft.Json;
using OFT.Rendering.Settings;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

#nullable disable
[Editor(typeof (dje_zH4K7A9UJ9BJ4ZJ5CPSZ4HCVT88M5HFCUYKATXAJG9R6CJ82_ejd), typeof (UserControl))]
public sealed class \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D : 
  \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D
{
  private readonly ValueDataSeries \u0023\u003DzP0vG76K29gJ0;

  public \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D(
    \u0023\u003DzMCqAV2TdtVhLYXKOFbBQU8JKvh4VCrGf0kg244M\u003D _param1,
    ValueDataSeries _param2)
    : base(_param1)
  {
    ValueDataSeries valueDataSeries = _param2;
    if (false)
      return;
    this.\u0023\u003DzP0vG76K29gJ0 = valueDataSeries;
  }

  [Browsable(false)]
  public Color Color
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzP0vG76K29gJ0.Color;
    }
    set
    {
      this.\u0023\u003DzP0vG76K29gJ0.Color = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639355);
      if (true)
        goto label_2;
label_1:
      this.\u0023\u003DzjS6aQ4BvkaBU.\u0023\u003DztKUwtct4EoGo();
      return;
label_2:
      this.RaisePropertyChanged(str);
      goto label_1;
    }
  }

  [Browsable(false)]
  public int Width
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzP0vG76K29gJ0.Width;
    }
    set
    {
      this.\u0023\u003DzP0vG76K29gJ0.Width = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639355);
      if (true)
        goto label_2;
label_1:
      this.\u0023\u003DzjS6aQ4BvkaBU.\u0023\u003DztKUwtct4EoGo();
      return;
label_2:
      this.RaisePropertyChanged(str);
      goto label_1;
    }
  }

  [Browsable(false)]
  public LineDashStyle Style
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzP0vG76K29gJ0.LineDashStyle;
    }
    set
    {
      this.\u0023\u003DzP0vG76K29gJ0.LineDashStyle = value;
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639355);
      if (true)
        goto label_2;
label_1:
      this.\u0023\u003DzjS6aQ4BvkaBU.\u0023\u003DztKUwtct4EoGo();
      return;
label_2:
      this.RaisePropertyChanged(str);
      goto label_1;
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public bool SettingsEnabled
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzjS6aQ4BvkaBU.\u0023\u003DzFKPDuGGr479x();
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public BitmapImage Preview
  {
    get
    {
      Bitmap bitmap1 = new Bitmap(120, 18);
      if (true)
        goto label_2;
label_1:
      Bitmap bitmap2;
      Graphics graphics1 = Graphics.FromImage((Image) bitmap2);
      Graphics graphics2;
      if (true)
        graphics2 = graphics1;
      try
      {
        Graphics graphics3 = graphics2;
        Color transparent = Color.Transparent;
        if (true)
          goto label_6;
label_5:
        using (Pen pen = new Pen(this.Color.\u0023\u003DzA9uh1h_BTvZ1(), (float) this.Width))
        {
          pen.DashStyle = this.Style.\u0023\u003Dz_vGGc3lReK3o();
          graphics2.DrawLine(pen, 4f, 9f, (float) (((Image) bitmap2).Width - 4), 9f);
          return bitmap2.\u0023\u003DzgpHJ6jmxWRak();
        }
label_6:
        graphics3.\u0023\u003Dz_IUy4n6cXM7A(transparent);
        goto label_5;
      }
      finally
      {
        ((IDisposable) graphics2)?.Dispose();
      }
label_2:
      bitmap2 = bitmap1;
      goto label_1;
    }
  }

  public void \u0023\u003DzzqCSRrs\u003D(
    \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D _param1)
  {
    Color color = _param1.Color;
    if (true)
      goto label_4;
label_1:
    int width = _param1.Width;
    if (true)
      goto label_5;
label_2:
    LineDashStyle style = _param1.Style;
    if (false)
      return;
    this.Style = style;
    return;
label_5:
    this.Width = width;
    goto label_2;
label_4:
    this.Color = color;
    goto label_1;
  }
}
