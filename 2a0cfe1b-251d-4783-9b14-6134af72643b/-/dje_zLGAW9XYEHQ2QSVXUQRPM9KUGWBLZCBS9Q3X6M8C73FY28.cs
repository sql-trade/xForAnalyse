// Decompiled with JetBrains decompiler
// Type: -.dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

#nullable disable
namespace \u002D;

public sealed class dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd : 
  UserControl,
  IComponentConnector
{
  private bool \u0023\u003DzUdTP4sJ5lCS5;
  private dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003Dz5tlanVY\u003D \u0023\u003DzTlpxZtXxD_gP;
  public static readonly DependencyProperty \u0023\u003DzGdUnoWfwO3QQ;
  internal Grid \u0023\u003DzgND9xxvY6MmD;
  internal Canvas \u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D;
  internal Ellipse \u0023\u003Dzl0dgD9aZ3JrQ;
  internal Border \u0023\u003Dz2mwFYTbN_7Eg;
  internal TextBox \u0023\u003DzgrVDlS1yGKr7;
  internal Border \u0023\u003Dz3Oly8VGnXZjO;
  internal Slider \u0023\u003DzpPECIEG4uD7I;
  private bool \u0023\u003Dz0nsut3xYAJ4_;

  public dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd()
  {
    if (true)
      goto label_3;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    if (false)
      return;
    this.InitializeComponent();
    return;
label_3:
    this.\u0023\u003DzTlpxZtXxD_gP = (dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003Dz5tlanVY\u003D) 2;
    goto label_1;
  }

  static dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd()
  {
    DependencyProperty dependencyProperty = DependencyProperty.Register(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638897), typeof (Color), typeof (dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd), new PropertyMetadata((PropertyChangedCallback) null));
    if (false)
      return;
    dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003DzGdUnoWfwO3QQ = dependencyProperty;
  }

  public Color SelectedColor
  {
    get
    {
      if (true)
        ;
      return (Color) this.GetValue(dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003DzGdUnoWfwO3QQ);
    }
    set
    {
      DependencyProperty zGdUnoWfwO3Qq = dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003DzGdUnoWfwO3QQ;
      __Boxed<Color> local = (ValueType) value;
      if (true)
        goto label_4;
label_1:
      if (true)
        goto label_5;
label_2:
      if (true)
        goto label_6;
label_3:
      if (this.\u0023\u003DzTlpxZtXxD_gP == (dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003Dz5tlanVY\u003D) 2 || this.\u0023\u003DzTlpxZtXxD_gP == (dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003Dz5tlanVY\u003D) 0)
      {
        this.\u0023\u003Dzld3aF3NBod5b();
        this.\u0023\u003DzpPECIEG4uD7I.Value = (double) value.A;
      }
      this.\u0023\u003Dzl0dgD9aZ3JrQ.Visibility = this.\u0023\u003DzTlpxZtXxD_gP == (dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003Dz5tlanVY\u003D) 2 ? Visibility.Collapsed : Visibility.Visible;
      this.\u0023\u003DzTlpxZtXxD_gP = (dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003Dz5tlanVY\u003D) 2;
      return;
label_6:
      this.\u0023\u003Dz7x\u00244t8s\u003D();
      goto label_3;
label_5:
      this.\u0023\u003DzGN4b0J6DOmrD();
      goto label_2;
label_4:
      this.SetValue(zGdUnoWfwO3Qq, (object) local);
      goto label_1;
    }
  }

  private void \u0023\u003Dz0I\u0024AmntZ99JxICi9gQ\u003D\u003D(
    object _param1,
    MouseWheelEventArgs _param2)
  {
    int num1 = _param2.Delta / Math.Abs(_param2.Delta);
    if (true)
      goto label_2;
label_1:
    int num2;
    this.\u0023\u003DzpPECIEG4uD7I.Value += (double) num2;
    return;
label_2:
    num2 = num1;
    goto label_1;
  }

  private void \u0023\u003Dz6RLpvreumC5O(
    object _param1,
    RoutedPropertyChangedEventArgs<double> _param2)
  {
    if (true)
      goto label_4;
label_1:
    int a = (int) (byte) this.\u0023\u003DzpPECIEG4uD7I.Value;
    Color selectedColor1 = this.SelectedColor;
    if (true)
      goto label_5;
label_2:
    Color color;
    int r = (int) color.R;
    Color selectedColor2 = this.SelectedColor;
    if (true)
      goto label_6;
label_3:
    int g = (int) color.G;
    color = this.SelectedColor;
    int b = (int) color.B;
    this.SelectedColor = Color.FromArgb((byte) a, (byte) r, (byte) g, (byte) b);
    return;
label_6:
    color = selectedColor2;
    goto label_3;
label_5:
    color = selectedColor1;
    goto label_2;
label_4:
    this.\u0023\u003DzTlpxZtXxD_gP = (dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003Dz5tlanVY\u003D) 1;
    goto label_1;
  }

  private void \u0023\u003DzEOM0eIdy_ClB9iC9Tw\u003D\u003D(object _param1, MouseEventArgs _param2)
  {
    if (!this.\u0023\u003DzUdTP4sJ5lCS5)
      return;
    Point position = _param2.GetPosition((IInputElement) this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D);
    if (true)
      goto label_5;
label_3:
    Point point1;
    if (point1.X < 0.0 || point1.Y < 0.0 || point1.X > this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D.Width - 1.0 || point1.Y > this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D.Height - 1.0)
      return;
    Point point2 = point1;
    if (false)
      return;
    this.\u0023\u003DzGik5tZM\u003D(point2);
    return;
label_5:
    point1 = position;
    goto label_3;
  }

  private void \u0023\u003Dz0oN0uAs14VXO7SxUkg\u003D\u003D(
    object _param1,
    MouseButtonEventArgs _param2)
  {
    int leftButton = (int) _param2.LeftButton;
    if (true)
      goto label_2;
label_1:
    MouseButtonState mouseButtonState;
    if (!mouseButtonState.Equals((object) MouseButtonState.Pressed))
      return;
    if (true)
      goto label_8;
label_5:
    Point position = _param2.GetPosition((IInputElement) this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D);
    if (true)
      goto label_9;
label_6:
    Point point;
    if (point.X < 0.0 || point.Y < 0.0 || point.X > this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D.Width - 1.0 || point.Y > this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D.Height - 1.0)
      return;
    this.\u0023\u003DzGik5tZM\u003D(point);
    return;
label_9:
    point = position;
    goto label_6;
label_8:
    this.\u0023\u003DzUdTP4sJ5lCS5 = true;
    goto label_5;
label_2:
    mouseButtonState = (MouseButtonState) leftButton;
    goto label_1;
  }

  private void \u0023\u003Dz9c9h6pbO_QDOovwy3Q\u003D\u003D(
    object _param1,
    MouseButtonEventArgs _param2)
  {
    if (false)
      return;
    this.\u0023\u003DzUdTP4sJ5lCS5 = false;
  }

  private void \u0023\u003Dzld3aF3NBod5b()
  {
    Color selectedColor1 = this.SelectedColor;
    if (true)
      goto label_4;
label_1:
    Color color;
    int r1 = (int) color.R;
    Color selectedColor2 = this.SelectedColor;
    if (true)
      goto label_5;
label_2:
    int g1 = (int) color.G;
    Color selectedColor3 = this.SelectedColor;
    if (true)
      goto label_6;
label_3:
    int b1 = (int) color.B;
    Color startColor = Color.FromArgb((byte) 0, (byte) r1, (byte) g1, (byte) b1);
    color = this.SelectedColor;
    int r2 = (int) color.R;
    color = this.SelectedColor;
    int g2 = (int) color.G;
    color = this.SelectedColor;
    int b2 = (int) color.B;
    Color endColor = Color.FromArgb(byte.MaxValue, (byte) r2, (byte) g2, (byte) b2);
    Point startPoint = new Point(0.0, 0.0);
    Point endPoint = new Point(1.0, 0.0);
    this.\u0023\u003Dz3Oly8VGnXZjO.Background = (Brush) new LinearGradientBrush(startColor, endColor, startPoint, endPoint);
    return;
label_6:
    color = selectedColor3;
    goto label_3;
label_5:
    color = selectedColor2;
    goto label_2;
label_4:
    color = selectedColor1;
    goto label_1;
  }

  private void \u0023\u003DzGik5tZM\u003D(Point _param1)
  {
    this.\u0023\u003Dzl0dgD9aZ3JrQ.SetValue(Canvas.LeftProperty, (object) (_param1.X - this.\u0023\u003Dzl0dgD9aZ3JrQ.Width / 2.0));
    this.\u0023\u003Dzl0dgD9aZ3JrQ.SetValue(Canvas.TopProperty, (object) (_param1.Y - this.\u0023\u003Dzl0dgD9aZ3JrQ.Width / 2.0));
    this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D.InvalidateVisual();
    if (true)
      goto label_3;
label_1:
    Color color = this.\u0023\u003DzZupTn6\u0024Bm6mi((Visual) this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D, _param1);
    if (false)
      return;
    this.SelectedColor = color;
    return;
label_3:
    this.\u0023\u003DzTlpxZtXxD_gP = (dje_zLGAW9XYEHQ2QSVXUQRPM9KUGWBLZCBS9Q3X6M8C73FY28HZ_ejd.\u0023\u003Dz5tlanVY\u003D) 0;
    goto label_1;
  }

  public Color \u0023\u003DzZupTn6\u0024Bm6mi(Visual _param1, Point _param2)
  {
    Point point1 = this.\u0023\u003DzTf1D\u0024mNgtKca(_param1);
    if (true)
      goto label_5;
label_1:
    Rect descendantBounds = VisualTreeHelper.GetDescendantBounds(_param1);
    if (true)
      goto label_6;
label_2:
    Rect rect1;
    Size size1 = rect1.Size;
    if (true)
      goto label_7;
label_3:
    Size size2;
    Rect rect2 = new Rect(_param2.X / size2.Width, _param2.Y / size2.Height, 1.0 / size2.Width, 1.0 / size2.Height);
    Point point2;
    double num1 = point2.X / 96.0;
    if (true)
      goto label_8;
label_4:
    double num2 = point2.Y / 96.0;
    double num3;
    RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap((int) (num2 + (double) (num2 % 1.0 != 0.0 ? 1 : 0)), (int) (num3 + (double) (num3 % 1.0 != 0.0 ? 1 : 0)), point2.X, point2.Y, PixelFormats.Default);
    DrawingVisual drawingVisual = new DrawingVisual();
    using (DrawingContext drawingContext1 = drawingVisual.RenderOpen())
    {
      DrawingContext drawingContext2 = drawingContext1;
      VisualBrush visualBrush = new VisualBrush();
      visualBrush.Visual = _param1;
      visualBrush.Viewbox = rect2;
      Rect rectangle = new Rect(0.0, 0.0, 1.0, 1.0);
      drawingContext2.DrawRectangle((Brush) visualBrush, (Pen) null, rectangle);
    }
    renderTargetBitmap.Render((Visual) drawingVisual);
    int stride = (renderTargetBitmap.PixelWidth * renderTargetBitmap.Format.BitsPerPixel + 31 /*0x1F*/) / 32 /*0x20*/ * 4;
    byte[] pixels = new byte[stride * renderTargetBitmap.PixelHeight * renderTargetBitmap.PixelWidth];
    renderTargetBitmap.CopyPixels((Array) pixels, stride, 0);
    return Color.FromArgb((byte) this.\u0023\u003DzpPECIEG4uD7I.Value, pixels[2], pixels[1], pixels[0]);
label_8:
    num3 = num1;
    goto label_4;
label_7:
    size2 = size1;
    goto label_3;
label_6:
    rect1 = descendantBounds;
    goto label_2;
label_5:
    point2 = point1;
    goto label_1;
  }

  public Point \u0023\u003DzTf1D\u0024mNgtKca(Visual _param1)
  {
    PresentationSource presentationSource1 = PresentationSource.FromVisual(_param1);
    if (true)
      goto label_2;
label_1:
    PresentationSource presentationSource2;
    if (presentationSource2 == null)
      return new Point(96.0, 96.0);
    Matrix transformToDevice1 = presentationSource2.CompositionTarget.TransformToDevice;
    if (true)
      goto label_6;
label_4:
    Matrix matrix;
    double x = 96.0 * matrix.M11;
    Matrix transformToDevice2 = presentationSource2.CompositionTarget.TransformToDevice;
    if (true)
      goto label_7;
label_5:
    double y = 96.0 * matrix.M22;
    return new Point(x, y);
label_7:
    matrix = transformToDevice2;
    goto label_5;
label_6:
    matrix = transformToDevice1;
    goto label_4;
label_2:
    presentationSource2 = presentationSource1;
    goto label_1;
  }

  private void \u0023\u003DzGN4b0J6DOmrD()
  {
    TextBox zgrVdlS1yGkr7 = this.\u0023\u003DzgrVDlS1yGKr7;
    string format = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638853);
    object[] objArray = new object[4];
    Color selectedColor1 = this.SelectedColor;
    if (true)
      goto label_4;
label_1:
    Color color;
    int a = (int) color.A;
    if (true)
      goto label_5;
label_2:
    byte num;
    objArray[0] = (object) num.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638873));
    Color selectedColor2 = this.SelectedColor;
    if (true)
      goto label_6;
label_3:
    num = color.R;
    objArray[1] = (object) num.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638873));
    color = this.SelectedColor;
    num = color.G;
    objArray[2] = (object) num.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638873));
    color = this.SelectedColor;
    num = color.B;
    objArray[3] = (object) num.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638873));
    string str = string.Format(format, objArray);
    zgrVdlS1yGkr7.Text = str;
    return;
label_6:
    color = selectedColor2;
    goto label_3;
label_5:
    num = (byte) a;
    goto label_2;
label_4:
    color = selectedColor1;
    goto label_1;
  }

  private void \u0023\u003Dz7x\u00244t8s\u003D()
  {
    if (true)
      ;
    Border z2mwFyTbN7Eg = this.\u0023\u003Dz2mwFYTbN_7Eg;
    if (true)
      ;
    SolidColorBrush solidColorBrush = new SolidColorBrush(this.SelectedColor);
    z2mwFyTbN7Eg.Background = (Brush) solidColorBrush;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "9.0.11.0")]
  public void InitializeComponent()
  {
    if (this.\u0023\u003Dz0nsut3xYAJ4_)
      return;
    if (true)
      goto label_5;
label_2:
    Uri uri1 = new Uri(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639080), UriKind.Relative);
    if (true)
      goto label_6;
label_3:
    Uri uri2;
    Uri resourceLocator = uri2;
    if (false)
      return;
    Application.LoadComponent((object) this, resourceLocator);
    return;
label_6:
    uri2 = uri1;
    goto label_3;
label_5:
    this.\u0023\u003Dz0nsut3xYAJ4_ = true;
    goto label_2;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "9.0.11.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.\u0023\u003Dz5M3OBa3OHovhbcSbVfningIbw_Dz(int _param1, object _param2)
  {
    switch (_param1)
    {
      case 1:
        ((UIElement) _param2).MouseWheel += new MouseWheelEventHandler(this.\u0023\u003Dz0I\u0024AmntZ99JxICi9gQ\u003D\u003D);
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003Dz9c9h6pbO_QDOovwy3Q\u003D\u003D);
        break;
      case 2:
        Grid grid = (Grid) _param2;
        if (true)
          goto label_4;
label_3:
        this.\u0023\u003DzgND9xxvY6MmD.MouseDown += new MouseButtonEventHandler(this.\u0023\u003Dz0oN0uAs14VXO7SxUkg\u003D\u003D);
        this.\u0023\u003DzgND9xxvY6MmD.MouseUp += new MouseButtonEventHandler(this.\u0023\u003Dz9c9h6pbO_QDOovwy3Q\u003D\u003D);
        break;
label_4:
        this.\u0023\u003DzgND9xxvY6MmD = grid;
        goto label_3;
      case 3:
        Canvas canvas = (Canvas) _param2;
        if (true)
          goto label_7;
label_6:
        this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D.MouseDown += new MouseButtonEventHandler(this.\u0023\u003Dz0oN0uAs14VXO7SxUkg\u003D\u003D);
        this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D.MouseUp += new MouseButtonEventHandler(this.\u0023\u003Dz9c9h6pbO_QDOovwy3Q\u003D\u003D);
        this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D.MouseMove += new MouseEventHandler(this.\u0023\u003DzEOM0eIdy_ClB9iC9Tw\u003D\u003D);
        break;
label_7:
        this.\u0023\u003Dz_VHHHFxU1v1tlAhyxw\u003D\u003D = canvas;
        goto label_6;
      case 4:
        ((UIElement) _param2).MouseDown += new MouseButtonEventHandler(this.\u0023\u003Dz0oN0uAs14VXO7SxUkg\u003D\u003D);
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003Dz9c9h6pbO_QDOovwy3Q\u003D\u003D);
        ((UIElement) _param2).MouseMove += new MouseEventHandler(this.\u0023\u003DzEOM0eIdy_ClB9iC9Tw\u003D\u003D);
        break;
      case 5:
        Ellipse ellipse = (Ellipse) _param2;
        if (false)
          break;
        this.\u0023\u003Dzl0dgD9aZ3JrQ = ellipse;
        break;
      case 6:
        ((UIElement) _param2).MouseDown += new MouseButtonEventHandler(this.\u0023\u003Dz0oN0uAs14VXO7SxUkg\u003D\u003D);
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003Dz9c9h6pbO_QDOovwy3Q\u003D\u003D);
        break;
      case 7:
        Border border = (Border) _param2;
        if (true)
          goto label_15;
label_14:
        this.\u0023\u003Dz2mwFYTbN_7Eg.MouseDown += new MouseButtonEventHandler(this.\u0023\u003Dz0oN0uAs14VXO7SxUkg\u003D\u003D);
        this.\u0023\u003Dz2mwFYTbN_7Eg.MouseUp += new MouseButtonEventHandler(this.\u0023\u003Dz9c9h6pbO_QDOovwy3Q\u003D\u003D);
        break;
label_15:
        this.\u0023\u003Dz2mwFYTbN_7Eg = border;
        goto label_14;
      case 8:
        this.\u0023\u003DzgrVDlS1yGKr7 = (TextBox) _param2;
        break;
      case 9:
        this.\u0023\u003Dz3Oly8VGnXZjO = (Border) _param2;
        this.\u0023\u003Dz3Oly8VGnXZjO.MouseWheel += new MouseWheelEventHandler(this.\u0023\u003Dz0I\u0024AmntZ99JxICi9gQ\u003D\u003D);
        break;
      case 10:
        this.\u0023\u003DzpPECIEG4uD7I = (Slider) _param2;
        this.\u0023\u003DzpPECIEG4uD7I.ValueChanged += new RoutedPropertyChangedEventHandler<double>(this.\u0023\u003Dz6RLpvreumC5O);
        break;
      default:
        this.\u0023\u003Dz0nsut3xYAJ4_ = true;
        break;
    }
  }

  private enum \u0023\u003Dz5tlanVY\u003D
  {
  }
}
