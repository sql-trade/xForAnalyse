// Decompiled with JetBrains decompiler
// Type: -.dje_zMMAU385Y9K4M9G6H9F6P8N8LU4GMZNN5W7KKQ74SHHS6S3DPJKR2W_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

#nullable disable
namespace \u002D;

public sealed class dje_zMMAU385Y9K4M9G6H9F6P8N8LU4GMZNN5W7KKQ74SHHS6S3DPJKR2W_ejd : IValueConverter
{
  private Brush \u0023\u003DzXXuyoICAeXdNngFMlQ\u003D\u003D;
  private Brush \u0023\u003DzZ8vHZzCmWxOY5w1_fw\u003D\u003D;
  private Brush \u0023\u003DzNQHa4XLrhjE9MN7EXQ\u003D\u003D;

  public dje_zMMAU385Y9K4M9G6H9F6P8N8LU4GMZNN5W7KKQ74SHHS6S3DPJKR2W_ejd()
  {
    SolidColorBrush green = Brushes.Green;
    if (true)
      goto label_4;
label_1:
    SolidColorBrush red = Brushes.Red;
    if (true)
      goto label_5;
label_2:
    SolidColorBrush white = Brushes.White;
    if (true)
      goto label_6;
label_3:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_6:
    this.\u0023\u003DzNQHa4XLrhjE9MN7EXQ\u003D\u003D = (Brush) white;
    goto label_3;
label_5:
    this.\u0023\u003DzZ8vHZzCmWxOY5w1_fw\u003D\u003D = (Brush) red;
    goto label_2;
label_4:
    this.\u0023\u003DzXXuyoICAeXdNngFMlQ\u003D\u003D = (Brush) green;
    goto label_1;
  }

  public Brush dje_zCCQ7JHQJ_ejd
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzXXuyoICAeXdNngFMlQ\u003D\u003D;
    }
    set
    {
      Brush brush = value;
      if (false)
        return;
      this.\u0023\u003DzXXuyoICAeXdNngFMlQ\u003D\u003D = brush;
    }
  }

  public Brush \u0023\u003DzXmijHYTp8UWl()
  {
    if (true)
      ;
    return this.\u0023\u003DzXXuyoICAeXdNngFMlQ\u003D\u003D;
  }

  public void \u0023\u003Dz3sThkS3XHMSr(Brush _param1)
  {
    Brush brush = _param1;
    if (false)
      return;
    this.\u0023\u003DzXXuyoICAeXdNngFMlQ\u003D\u003D = brush;
  }

  public Brush dje_z4CGKYF9L_ejd
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzZ8vHZzCmWxOY5w1_fw\u003D\u003D;
    }
    set
    {
      Brush brush = value;
      if (false)
        return;
      this.\u0023\u003DzZ8vHZzCmWxOY5w1_fw\u003D\u003D = brush;
    }
  }

  public Brush \u0023\u003DzDhBUJZU7WpsN()
  {
    if (true)
      ;
    return this.\u0023\u003DzZ8vHZzCmWxOY5w1_fw\u003D\u003D;
  }

  public void \u0023\u003DzGHJ8hQNRd0Ez(Brush _param1)
  {
    Brush brush = _param1;
    if (false)
      return;
    this.\u0023\u003DzZ8vHZzCmWxOY5w1_fw\u003D\u003D = brush;
  }

  public Brush dje_z8XEMRE5D_ejd
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzNQHa4XLrhjE9MN7EXQ\u003D\u003D;
    }
    set
    {
      Brush brush = value;
      if (false)
        return;
      this.\u0023\u003DzNQHa4XLrhjE9MN7EXQ\u003D\u003D = brush;
    }
  }

  public Brush \u0023\u003Dz3qqgUCTChJ_Z()
  {
    if (true)
      ;
    return this.\u0023\u003DzNQHa4XLrhjE9MN7EXQ\u003D\u003D;
  }

  public void \u0023\u003DzLiIdI5Z_d_fB(Brush _param1)
  {
    Brush brush = _param1;
    if (false)
      return;
    this.\u0023\u003DzNQHa4XLrhjE9MN7EXQ\u003D\u003D = brush;
  }

  public object Convert(object _param1, Type _param2, object _param3, CultureInfo _param4)
  {
    int num1;
    if (_param1 != null)
    {
      IConvertible convertible1 = _param1 as IConvertible;
      if (true)
        goto label_3;
label_2:
      IConvertible convertible2;
      if (convertible2 != null)
      {
        int int32 = System.Convert.ToInt32((object) convertible2, (IFormatProvider) _param4);
        if (true)
        {
          num1 = int32;
          goto label_9;
        }
        goto label_9;
      }
      num1 = 0;
      goto label_9;
label_3:
      convertible2 = convertible1;
      goto label_2;
    }
    if (true)
      num1 = 0;
label_9:
    int num2 = num1;
    if (num2 > 0)
      return (object) this.\u0023\u003DzXmijHYTp8UWl();
    return num2 < 0 ? (object) this.\u0023\u003DzDhBUJZU7WpsN() : (object) this.\u0023\u003Dz3qqgUCTChJ_Z();
  }

  public object ConvertBack(object _param1, Type _param2, object _param3, CultureInfo _param4)
  {
    throw new NotImplementedException();
  }
}
