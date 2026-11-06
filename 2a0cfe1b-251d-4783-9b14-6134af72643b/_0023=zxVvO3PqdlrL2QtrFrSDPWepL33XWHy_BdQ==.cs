// Decompiled with JetBrains decompiler
// Type: #=zxVvO3PqdlrL2QtrFrSDPWepL33XWHy_BdQ==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Drawing;
using System.Windows.Media;

#nullable disable
internal static class \u0023\u003DzxVvO3PqdlrL2QtrFrSDPWepL33XWHy_BdQ\u003D\u003D
{
  public static Color \u0023\u003Dz_5EhwHmuKr_8T5j4nQ\u003D\u003D(this Color _param0, float _param1)
  {
    double num1 = (double) Math.Min(1f, Math.Max(0.0f, 1f - _param1));
    if (true)
      goto label_4;
label_1:
    double num2 = 0.3 * (double) _param0.R + 0.6 * (double) _param0.G + 0.1 * (double) _param0.B;
    if (true)
      goto label_5;
label_2:
    float num3;
    double num4;
    double num5 = Math.Max(0.0, Math.Min((double) byte.MaxValue, (double) _param0.R + (double) num3 * (num4 - (double) _param0.R)));
    double num6 = Math.Max(0.0, Math.Min((double) byte.MaxValue, (double) _param0.G + (double) num3 * (num4 - (double) _param0.G)));
    if (true)
      goto label_6;
label_3:
    double num7 = Math.Max(0.0, Math.Min((double) byte.MaxValue, (double) _param0.B + (double) num3 * (num4 - (double) _param0.B)));
    double num8;
    return Color.FromArgb((int) num5, (int) num8, (int) num7);
label_6:
    num8 = num6;
    goto label_3;
label_5:
    num4 = num2;
    goto label_2;
label_4:
    num3 = (float) num1;
    goto label_1;
  }

  public static Color \u0023\u003DzoBDt3XxTf1zd(this Color _param0)
  {
    return Color.FromArgb(_param0.A, _param0.R, _param0.G, _param0.B);
  }

  public static Color \u0023\u003DzA9uh1h_BTvZ1(this Color _param0)
  {
    return Color.FromArgb((int) _param0.A, (int) _param0.R, (int) _param0.G, (int) _param0.B);
  }

  public static Brush \u0023\u003DzbfdUU696UXe_(this Color _param0)
  {
    Color color = _param0;
    if (true)
      ;
    return (Brush) new SolidColorBrush(color.\u0023\u003DzoBDt3XxTf1zd());
  }
}
