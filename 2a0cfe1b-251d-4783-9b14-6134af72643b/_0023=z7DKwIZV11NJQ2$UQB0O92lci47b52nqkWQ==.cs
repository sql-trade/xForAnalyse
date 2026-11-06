// Decompiled with JetBrains decompiler
// Type: #=z7DKwIZV11NJQ2$UQB0O92lci47b52nqkWQ==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

#nullable disable
internal static class \u0023\u003Dz7DKwIZV11NJQ2\u0024UQB0O92lci47b52nqkWQ\u003D\u003D
{
  internal static void \u0023\u003Dz_IUy4n6cXM7A(this Graphics _param0, Color _param1)
  {
    Graphics graphics1 = _param0;
    if (true)
      ;
    graphics1.SmoothingMode = (SmoothingMode) 4;
    Graphics graphics2 = _param0;
    if (true)
      ;
    graphics2.TextRenderingHint = (TextRenderingHint) 3;
    Graphics graphics3 = _param0;
    if (true)
      ;
    graphics3.InterpolationMode = (InterpolationMode) 7;
    _param0.PixelOffsetMode = (PixelOffsetMode) 2;
    _param0.Clear(_param1);
  }

  internal static void \u0023\u003Dzzcua7coVpoE3(this Graphics _param0, Color _param1)
  {
    Graphics graphics1 = _param0;
    if (true)
      ;
    graphics1.TextRenderingHint = (TextRenderingHint) 3;
    Graphics graphics2 = _param0;
    if (true)
      ;
    graphics2.SmoothingMode = (SmoothingMode) 2;
    Graphics graphics3 = _param0;
    if (true)
      ;
    graphics3.InterpolationMode = (InterpolationMode) 7;
    _param0.PixelOffsetMode = (PixelOffsetMode) 2;
    _param0.Clear(_param1);
  }

  internal static void \u0023\u003DzlCvmkmBEytCZ(this Graphics _param0, Color _param1)
  {
    Graphics graphics1 = _param0;
    if (true)
      ;
    graphics1.SmoothingMode = (SmoothingMode) 4;
    Graphics graphics2 = _param0;
    if (true)
      ;
    graphics2.TextRenderingHint = (TextRenderingHint) 5;
    Graphics graphics3 = _param0;
    if (true)
      ;
    graphics3.InterpolationMode = (InterpolationMode) 7;
    _param0.PixelOffsetMode = (PixelOffsetMode) 2;
    _param0.Clear(_param1);
  }

  internal static void \u0023\u003Dzcf9FHdDvlcSr(
    this Graphics _param0,
    int _param1,
    int _param2,
    int _param3)
  {
    Graphics graphics = _param0;
    if (true)
      ;
    int num1 = _param1;
    if (true)
      ;
    double num2 = (double) -num1;
    int num3 = _param2;
    if (true)
      ;
    double num4 = (double) -num3;
    graphics.TranslateTransform((float) num2, (float) num4);
    _param0.RotateTransform(90f, (MatrixOrder) 1);
    _param0.TranslateTransform((float) (_param1 + _param3), (float) _param2, (MatrixOrder) 1);
  }

  private static GraphicsPath \u0023\u003Dz4LQx9iXoHlMw(
    RectangleF _param0,
    float _param1,
    \u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D _param2)
  {
    GraphicsPath graphicsPath1 = new GraphicsPath();
    if (true)
      goto label_2;
label_1:
    GraphicsPath graphicsPath2;
    if ((double) _param1 <= 0.0 || _param2 == (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 0)
    {
      graphicsPath2.AddRectangle(_param0);
      graphicsPath2.CloseFigure();
      return graphicsPath2;
    }
    if ((double) _param1 >= (double) Math.Min(_param0.Width, _param0.Height) / 2.0)
      return \u0023\u003Dz7DKwIZV11NJQ2\u0024UQB0O92lci47b52nqkWQ\u003D\u003D.\u0023\u003DzN9LSgQvXYnJhZw\u0024frQ\u003D\u003D(_param0);
    double num1 = (double) _param1 * 2.0;
    if (true)
      goto label_8;
label_7:
    float num2;
    SizeF size = new SizeF(num2, num2);
    RectangleF rectangleF = new RectangleF(_param0.Location, size);
    if (((\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 1 & _param2) == (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 1)
    {
      graphicsPath2.AddArc(rectangleF, 180f, 90f);
    }
    else
    {
      graphicsPath2.AddLine(rectangleF.X, rectangleF.Y + rectangleF.Height, rectangleF.X, rectangleF.Y);
      graphicsPath2.AddLine(rectangleF.X, rectangleF.Y, rectangleF.X + rectangleF.Width, rectangleF.Y);
    }
    ref RectangleF local1 = ref rectangleF;
    double num3 = (double) _param0.Right - (double) num2;
    if (true)
      goto label_13;
label_12:
    if (((\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 2 & _param2) == (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 2)
    {
      graphicsPath2.AddArc(rectangleF, 270f, 90f);
    }
    else
    {
      graphicsPath2.AddLine(rectangleF.X, rectangleF.Y, rectangleF.X + rectangleF.Width, rectangleF.Y);
      graphicsPath2.AddLine(rectangleF.X + rectangleF.Width, rectangleF.Y + rectangleF.Height, rectangleF.X + rectangleF.Width, rectangleF.Y);
    }
    ref RectangleF local2 = ref rectangleF;
    double num4 = (double) _param0.Bottom - (double) num2;
    if (true)
      goto label_18;
label_17:
    if (((\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 8 & _param2) == (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 8)
    {
      graphicsPath2.AddArc(rectangleF, 0.0f, 90f);
    }
    else
    {
      graphicsPath2.AddLine(rectangleF.X + rectangleF.Width, rectangleF.Y, rectangleF.X + rectangleF.Width, rectangleF.Y + rectangleF.Height);
      graphicsPath2.AddLine(rectangleF.X, rectangleF.Y + rectangleF.Height, rectangleF.X + rectangleF.Width, rectangleF.Y + rectangleF.Height);
    }
    ref RectangleF local3 = ref rectangleF;
    double left = (double) _param0.Left;
    if (true)
      goto label_23;
label_22:
    if (((\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 4 & _param2) == (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 4)
    {
      graphicsPath2.AddArc(rectangleF, 90f, 90f);
    }
    else
    {
      graphicsPath2.AddLine(rectangleF.X + rectangleF.Width, rectangleF.Y + rectangleF.Height, rectangleF.X, rectangleF.Y + rectangleF.Height);
      graphicsPath2.AddLine(rectangleF.X, rectangleF.Y + rectangleF.Height, rectangleF.X, rectangleF.Y);
    }
    graphicsPath2.CloseFigure();
    return graphicsPath2;
label_23:
    local3.X = (float) left;
    goto label_22;
label_18:
    local2.Y = (float) num4;
    goto label_17;
label_13:
    local1.X = (float) num3;
    goto label_12;
label_8:
    num2 = (float) num1;
    goto label_7;
label_2:
    graphicsPath2 = graphicsPath1;
    goto label_1;
  }

  private static GraphicsPath \u0023\u003DzN9LSgQvXYnJhZw\u0024frQ\u003D\u003D(RectangleF _param0)
  {
    GraphicsPath graphicsPath1 = new GraphicsPath();
    GraphicsPath graphicsPath2;
    if (true)
      graphicsPath2 = graphicsPath1;
    try
    {
      if ((double) _param0.Width > (double) _param0.Height)
      {
        double height = (double) _param0.Height;
        if (true)
          goto label_6;
label_4:
        float num;
        SizeF size = new SizeF(num, num);
        RectangleF rectangleF1 = new RectangleF(_param0.Location, size);
        if (true)
          goto label_7;
label_5:
        RectangleF rectangleF2;
        graphicsPath2.AddArc(rectangleF2, 90f, 180f);
        rectangleF2.X = _param0.Right - num;
        graphicsPath2.AddArc(rectangleF2, 270f, 180f);
        goto label_13;
label_7:
        rectangleF2 = rectangleF1;
        goto label_5;
label_6:
        num = (float) height;
        goto label_4;
      }
      if ((double) _param0.Width < (double) _param0.Height)
      {
        float width = _param0.Width;
        SizeF size = new SizeF(width, width);
        RectangleF rectangleF = new RectangleF(_param0.Location, size);
        graphicsPath2.AddArc(rectangleF, 180f, 180f);
        rectangleF.Y = _param0.Bottom - width;
        graphicsPath2.AddArc(rectangleF, 0.0f, 180f);
      }
      else
        graphicsPath2.AddEllipse(_param0);
    }
    catch
    {
      graphicsPath2.AddEllipse(_param0);
    }
    finally
    {
      graphicsPath2.CloseFigure();
    }
label_13:
    return graphicsPath2;
  }

  public static void \u0023\u003Dzt10w2ixmkRpS(
    this Graphics _param0,
    Pen _param1,
    float _param2,
    float _param3,
    float _param4,
    float _param5,
    float _param6,
    \u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D _param7)
  {
    GraphicsPath graphicsPath1 = \u0023\u003Dz7DKwIZV11NJQ2\u0024UQB0O92lci47b52nqkWQ\u003D\u003D.\u0023\u003Dz4LQx9iXoHlMw(new RectangleF(_param2, _param3, _param4, _param5), _param6, _param7);
    if (true)
      goto label_3;
label_1:
    SmoothingMode smoothingMode1 = _param0.SmoothingMode;
    if (true)
      goto label_4;
label_2:
    _param0.SmoothingMode = (SmoothingMode) 4;
    GraphicsPath graphicsPath2;
    _param0.DrawPath(_param1, graphicsPath2);
    SmoothingMode smoothingMode2;
    _param0.SmoothingMode = smoothingMode2;
    return;
label_4:
    smoothingMode2 = smoothingMode1;
    goto label_2;
label_3:
    graphicsPath2 = graphicsPath1;
    goto label_1;
  }

  public static void \u0023\u003Dzt10w2ixmkRpS(
    this Graphics _param0,
    Pen _param1,
    float _param2,
    float _param3,
    float _param4,
    float _param5,
    float _param6)
  {
    Graphics graphics = _param0;
    Pen pen = _param1;
    double num1 = (double) _param2;
    double num2 = (double) _param3;
    double num3 = (double) _param4;
    double num4 = (double) _param5;
    double num5 = (double) _param6;
    if (false)
      return;
    graphics.\u0023\u003Dzt10w2ixmkRpS(pen, (float) num1, (float) num2, (float) num3, (float) num4, (float) num5, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 15);
  }

  public static void \u0023\u003Dzt10w2ixmkRpS(
    this Graphics _param0,
    Pen _param1,
    int _param2,
    int _param3,
    int _param4,
    int _param5,
    int _param6)
  {
    Graphics graphics = _param0;
    Pen pen = _param1;
    double single1 = (double) Convert.ToSingle(_param2);
    double single2 = (double) Convert.ToSingle(_param3);
    double single3 = (double) Convert.ToSingle(_param4);
    double single4 = (double) Convert.ToSingle(_param5);
    double single5 = (double) Convert.ToSingle(_param6);
    if (false)
      return;
    graphics.\u0023\u003Dzt10w2ixmkRpS(pen, (float) single1, (float) single2, (float) single3, (float) single4, (float) single5);
  }

  public static void \u0023\u003Dzt10w2ixmkRpS(
    this Graphics _param0,
    Pen _param1,
    Rectangle _param2,
    int _param3,
    \u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D _param4)
  {
    Graphics graphics = _param0;
    Pen pen = _param1;
    double x = (double) _param2.X;
    double y = (double) _param2.Y;
    double width = (double) _param2.Width;
    double height = (double) _param2.Height;
    double num1 = (double) _param3;
    int num2 = (int) _param4;
    if (false)
      return;
    graphics.\u0023\u003Dzt10w2ixmkRpS(pen, (float) x, (float) y, (float) width, (float) height, (float) num1, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) num2);
  }

  public static void \u0023\u003Dzt10w2ixmkRpS(
    this Graphics _param0,
    Pen _param1,
    Rectangle _param2,
    int _param3)
  {
    Graphics graphics = _param0;
    Pen pen = _param1;
    double x = (double) _param2.X;
    double y = (double) _param2.Y;
    double width = (double) _param2.Width;
    double height = (double) _param2.Height;
    double num = (double) _param3;
    if (false)
      return;
    graphics.\u0023\u003Dzt10w2ixmkRpS(pen, (float) x, (float) y, (float) width, (float) height, (float) num, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 15);
  }

  public static void \u0023\u003Dzt10w2ixmkRpS(
    this Graphics _param0,
    Pen _param1,
    RectangleF _param2,
    int _param3,
    \u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D _param4)
  {
    Graphics graphics = _param0;
    Pen pen = _param1;
    double x = (double) _param2.X;
    double y = (double) _param2.Y;
    double width = (double) _param2.Width;
    double height = (double) _param2.Height;
    double num1 = (double) _param3;
    int num2 = (int) _param4;
    if (false)
      return;
    graphics.\u0023\u003Dzt10w2ixmkRpS(pen, (float) x, (float) y, (float) width, (float) height, (float) num1, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) num2);
  }

  public static void \u0023\u003Dzt10w2ixmkRpS(
    this Graphics _param0,
    Pen _param1,
    RectangleF _param2,
    int _param3)
  {
    Graphics graphics = _param0;
    Pen pen = _param1;
    double x = (double) _param2.X;
    double y = (double) _param2.Y;
    double width = (double) _param2.Width;
    double height = (double) _param2.Height;
    double num = (double) _param3;
    if (false)
      return;
    graphics.\u0023\u003Dzt10w2ixmkRpS(pen, (float) x, (float) y, (float) width, (float) height, (float) num, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 15);
  }

  public static void \u0023\u003Dz49zVF7BlXxrR(
    this Graphics _param0,
    Brush _param1,
    float _param2,
    float _param3,
    float _param4,
    float _param5,
    float _param6,
    \u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D _param7)
  {
    GraphicsPath graphicsPath1 = \u0023\u003Dz7DKwIZV11NJQ2\u0024UQB0O92lci47b52nqkWQ\u003D\u003D.\u0023\u003Dz4LQx9iXoHlMw(new RectangleF(_param2, _param3, _param4, _param5), _param6, _param7);
    if (true)
      goto label_3;
label_1:
    SmoothingMode smoothingMode1 = _param0.SmoothingMode;
    if (true)
      goto label_4;
label_2:
    _param0.SmoothingMode = (SmoothingMode) 4;
    GraphicsPath graphicsPath2;
    _param0.FillPath(_param1, graphicsPath2);
    SmoothingMode smoothingMode2;
    _param0.SmoothingMode = smoothingMode2;
    return;
label_4:
    smoothingMode2 = smoothingMode1;
    goto label_2;
label_3:
    graphicsPath2 = graphicsPath1;
    goto label_1;
  }

  public static void \u0023\u003Dz49zVF7BlXxrR(
    this Graphics _param0,
    Brush _param1,
    float _param2,
    float _param3,
    float _param4,
    float _param5,
    float _param6)
  {
    Graphics graphics = _param0;
    Brush brush = _param1;
    double num1 = (double) _param2;
    double num2 = (double) _param3;
    double num3 = (double) _param4;
    double num4 = (double) _param5;
    double num5 = (double) _param6;
    if (false)
      return;
    graphics.\u0023\u003Dz49zVF7BlXxrR(brush, (float) num1, (float) num2, (float) num3, (float) num4, (float) num5, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 15);
  }

  public static void \u0023\u003Dz49zVF7BlXxrR(
    this Graphics _param0,
    Brush _param1,
    int _param2,
    int _param3,
    int _param4,
    int _param5,
    int _param6)
  {
    Graphics graphics = _param0;
    Brush brush = _param1;
    double single1 = (double) Convert.ToSingle(_param2);
    double single2 = (double) Convert.ToSingle(_param3);
    double single3 = (double) Convert.ToSingle(_param4);
    double single4 = (double) Convert.ToSingle(_param5);
    double single5 = (double) Convert.ToSingle(_param6);
    if (false)
      return;
    graphics.\u0023\u003Dz49zVF7BlXxrR(brush, (float) single1, (float) single2, (float) single3, (float) single4, (float) single5);
  }

  public static void \u0023\u003Dz49zVF7BlXxrR(
    this Graphics _param0,
    Brush _param1,
    Rectangle _param2,
    int _param3,
    \u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D _param4)
  {
    Graphics graphics = _param0;
    Brush brush = _param1;
    double x = (double) _param2.X;
    double y = (double) _param2.Y;
    double width = (double) _param2.Width;
    double height = (double) _param2.Height;
    double num1 = (double) _param3;
    int num2 = (int) _param4;
    if (false)
      return;
    graphics.\u0023\u003Dz49zVF7BlXxrR(brush, (float) x, (float) y, (float) width, (float) height, (float) num1, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) num2);
  }

  public static void \u0023\u003Dz49zVF7BlXxrR(
    this Graphics _param0,
    Brush _param1,
    Rectangle _param2,
    int _param3)
  {
    Graphics graphics = _param0;
    Brush brush = _param1;
    double x = (double) _param2.X;
    double y = (double) _param2.Y;
    double width = (double) _param2.Width;
    double height = (double) _param2.Height;
    double num = (double) _param3;
    if (false)
      return;
    graphics.\u0023\u003Dz49zVF7BlXxrR(brush, (float) x, (float) y, (float) width, (float) height, (float) num, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 15);
  }

  public static void \u0023\u003Dz49zVF7BlXxrR(
    this Graphics _param0,
    Brush _param1,
    RectangleF _param2,
    int _param3,
    \u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D _param4)
  {
    Graphics graphics = _param0;
    Brush brush = _param1;
    double x = (double) _param2.X;
    double y = (double) _param2.Y;
    double width = (double) _param2.Width;
    double height = (double) _param2.Height;
    double num1 = (double) _param3;
    int num2 = (int) _param4;
    if (false)
      return;
    graphics.\u0023\u003Dz49zVF7BlXxrR(brush, (float) x, (float) y, (float) width, (float) height, (float) num1, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) num2);
  }

  public static void \u0023\u003Dz49zVF7BlXxrR(
    this Graphics _param0,
    Brush _param1,
    RectangleF _param2,
    int _param3)
  {
    Graphics graphics = _param0;
    Brush brush = _param1;
    double x = (double) _param2.X;
    double y = (double) _param2.Y;
    double width = (double) _param2.Width;
    double height = (double) _param2.Height;
    double num = (double) _param3;
    if (false)
      return;
    graphics.\u0023\u003Dz49zVF7BlXxrR(brush, (float) x, (float) y, (float) width, (float) height, (float) num, (\u0023\u003DzFJ1693eWMWnZMr45Y\u0024qwayBtWUXjad5uSK0rqSs\u003D) 15);
  }
}
