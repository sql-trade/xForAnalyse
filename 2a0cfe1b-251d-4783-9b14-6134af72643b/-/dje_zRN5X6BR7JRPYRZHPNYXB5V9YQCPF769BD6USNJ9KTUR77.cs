// Decompiled with JetBrains decompiler
// Type: -.dje_zRN5X6BR7JRPYRZHPNYXB5V9YQCPF769BD6USNJ9KTUR77V2_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

#nullable disable
namespace \u002D;

public sealed class dje_zRN5X6BR7JRPYRZHPNYXB5V9YQCPF769BD6USNJ9KTUR77V2_ejd : IValueConverter
{
  public dje_zRN5X6BR7JRPYRZHPNYXB5V9YQCPF769BD6USNJ9KTUR77V2_ejd()
  {
    if (true)
      ;
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }

  public object Convert(object _param1, Type _param2, object _param3, CultureInfo _param4)
  {
    if (!(_param1 is Color color))
      return Binding.DoNothing;
    if (true)
      ;
    string format = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638853);
    object[] objArray = new object[4];
    int a = (int) color.A;
    if (true)
      goto label_5;
label_3:
    byte num1;
    objArray[0] = (object) num1.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638873));
    int r = (int) color.R;
    if (true)
      goto label_6;
label_4:
    objArray[1] = (object) num1.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638873));
    byte num2 = color.G;
    objArray[2] = (object) num2.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638873));
    num2 = color.B;
    objArray[3] = (object) num2.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638873));
    return (object) string.Format(format, objArray);
label_6:
    num1 = (byte) r;
    goto label_4;
label_5:
    num1 = (byte) a;
    goto label_3;
  }

  public object ConvertBack(object _param1, Type _param2, object _param3, CultureInfo _param4)
  {
    return Binding.DoNothing;
  }
}
