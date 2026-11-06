// Decompiled with JetBrains decompiler
// Type: dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

#nullable enable
internal static class dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd
{
  public static void \u0023\u003DzKLKYe4bjOAt1<T>(
    ref T? _param0,
    Func<T> _param1,
    Action _param2,
    Action<Window> _param3,
    Point _param4)
    where T : Window
  {
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzyENPOW6qMg6otmqOE76LkK0\u003D<T> w6qMg6otmqOe76LkK0_1 = new dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzyENPOW6qMg6otmqOE76LkK0\u003D<T>();
    if (true)
      goto label_4;
label_1:
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzyENPOW6qMg6otmqOE76LkK0\u003D<T> w6qMg6otmqOe76LkK0_2;
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzyENPOW6qMg6otmqOE76LkK0\u003D<T> w6qMg6otmqOe76LkK0_3 = w6qMg6otmqOe76LkK0_2;
    Action action = _param2;
    if (true)
      goto label_5;
label_2:
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzyENPOW6qMg6otmqOE76LkK0\u003D<T> w6qMg6otmqOe76LkK0_4 = w6qMg6otmqOe76LkK0_2;
    Point point = _param4;
    if (true)
      goto label_6;
label_3:
    w6qMg6otmqOe76LkK0_2.\u0023\u003DznS2JMmeGAYca = _param3;
    if ((object) _param0 == null)
    {
      dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003Dz5BWmSc_AOhouFcSnqWWlIro\u003D<T> aohouFcSnqWwlIro = new dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003Dz5BWmSc_AOhouFcSnqWWlIro\u003D<T>();
      aohouFcSnqWwlIro.\u0023\u003Dq5BmP\u0024k364M3uN6AYzBdDMP2fRyyikUJ\u0024Iv5E_3j7mcU\u003D = w6qMg6otmqOe76LkK0_2;
      aohouFcSnqWwlIro.\u0023\u003DzAElFq6M\u003D = _param1();
      aohouFcSnqWwlIro.\u0023\u003DzAElFq6M\u003D.Closed += new EventHandler(aohouFcSnqWwlIro.\u0023\u003Dq5BmP\u0024k364M3uN6AYzBdDMP2fRyyikUJ\u0024Iv5E_3j7mcU\u003D.\u0023\u003DzXTVQylPfCZLZCG3Abw\u003D\u003D);
      aohouFcSnqWwlIro.\u0023\u003DzAElFq6M\u003D.Loaded += new RoutedEventHandler(aohouFcSnqWwlIro.\u0023\u003DzusHEz3TaF7y_ZwCJnA\u003D\u003D);
      aohouFcSnqWwlIro.\u0023\u003DzAElFq6M\u003D.LocationChanged += new EventHandler(aohouFcSnqWwlIro.\u0023\u003Dzlj\u0024uQl5763j4UxeyPw\u003D\u003D);
      _param0 = aohouFcSnqWwlIro.\u0023\u003DzAElFq6M\u003D;
      aohouFcSnqWwlIro.\u0023\u003DzAElFq6M\u003D.Show();
      return;
    }
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzXWXbvHv6Fd37((Window) _param0);
    return;
label_6:
    w6qMg6otmqOe76LkK0_4.\u0023\u003DzkNsZp5w\u003D = point;
    goto label_3;
label_5:
    w6qMg6otmqOe76LkK0_3.\u0023\u003DzbqmXk0gvm8Ou = action;
    goto label_2;
label_4:
    w6qMg6otmqOe76LkK0_2 = w6qMg6otmqOe76LkK0_1;
    goto label_1;
  }

  public static void \u0023\u003DzXWXbvHv6Fd37(
  #nullable disable
  Window _param0)
  {
    Window window1 = _param0;
    if (true)
      ;
    if (!window1.IsVisible)
    {
      Window window2 = _param0;
      if (true)
        ;
      window2.Show();
    }
    Window window3 = _param0;
    if (true)
      ;
    if (window3.WindowState == WindowState.Minimized)
      _param0.WindowState = WindowState.Normal;
    _param0.Activate();
    if (!_param0.Topmost)
    {
      _param0.Topmost = true;
      _param0.Topmost = false;
    }
    _param0.Focus();
  }

  [DllImport("user32.dll", EntryPoint = "MonitorFromWindow")]
  private static extern IntPtr dje_zE2F9BWJ9727S85Q_ejd(
    IntPtr dje_zZKZDDQWK_ejd,
    uint dje_zX2A9HWAT_ejd);

  [DllImport("user32.dll", EntryPoint = "GetMonitorInfo")]
  private static extern bool dje_zF8BJ3VSLUYA522Z_ejd(
    IntPtr dje_zR4YHJQ5X_ejd,
    ref dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zR2UPS7TPPVHKBBYPX23TX_ejd dje_zMXRGV7HH9V9EWMA_ejd);

  public static void \u0023\u003DzQUSnaFzeFU4H(Window _param0)
  {
    IntPtr dje_zR4YHJQ5X_ejd = dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zE2F9BWJ9727S85Q_ejd(new WindowInteropHelper(_param0).Handle, 2U);
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zR2UPS7TPPVHKBBYPX23TX_ejd tppvhkbbypX23TxEjd = new dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zR2UPS7TPPVHKBBYPX23TX_ejd();
    ref dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zR2UPS7TPPVHKBBYPX23TX_ejd local1 = ref tppvhkbbypX23TxEjd;
    int num1 = Marshal.SizeOf(typeof (dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zR2UPS7TPPVHKBBYPX23TX_ejd));
    if (true)
      goto label_4;
label_1:
    ref dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zR2UPS7TPPVHKBBYPX23TX_ejd local2 = ref tppvhkbbypX23TxEjd;
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zF8BJ3VSLUYA522Z_ejd(dje_zR4YHJQ5X_ejd, ref local2);
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zE9WJSW3G_ejd l8HzuppJ7JgmqEjd = tppvhkbbypX23TxEjd.dje_zYEL8HZUPPJ7JGMQ_ejd;
    if (true)
      goto label_5;
label_2:
    dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zE9WJSW3G_ejd djeZE9WjsW3GEjd;
    int num2 = djeZE9WjsW3GEjd.dje_zYK6XLMFA_ejd - djeZE9WjsW3GEjd.dje_zSYQ6UXZJ_ejd;
    if (true)
      goto label_6;
label_3:
    int num3 = djeZE9WjsW3GEjd.dje_zS8E2XUW4_ejd - djeZE9WjsW3GEjd.dje_zHVYPJ7ZR_ejd;
    int num4;
    _param0.Left = (double) djeZE9WjsW3GEjd.dje_zSYQ6UXZJ_ejd + ((double) num4 - _param0.Width) / 2.0;
    _param0.Top = (double) djeZE9WjsW3GEjd.dje_zHVYPJ7ZR_ejd + ((double) num3 - _param0.Height) / 2.0;
    return;
label_6:
    num4 = num2;
    goto label_3;
label_5:
    djeZE9WjsW3GEjd = l8HzuppJ7JgmqEjd;
    goto label_2;
label_4:
    local1.dje_zEU4B655V_ejd = num1;
    goto label_1;
  }

  private sealed class \u0023\u003Dz5BWmSc_AOhouFcSnqWWlIro\u003D<\u0023\u003Dz4UEwosY\u003D> where \u0023\u003Dz4UEwosY\u003D : 
  #nullable enable
  Window
  {
    public 
    #nullable disable
    \u0023\u003Dz4UEwosY\u003D \u0023\u003DzAElFq6M\u003D;
    public dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzyENPOW6qMg6otmqOE76LkK0\u003D<\u0023\u003Dz4UEwosY\u003D> \u0023\u003Dq5BmP\u0024k364M3uN6AYzBdDMP2fRyyikUJ\u0024Iv5E_3j7mcU\u003D;

    public \u0023\u003Dz5BWmSc_AOhouFcSnqWWlIro\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal void \u0023\u003DzusHEz3TaF7y_ZwCJnA\u003D\u003D(
      object _param1,
      RoutedEventArgs _param2)
    {
      this.\u0023\u003DzAElFq6M\u003D.WindowStartupLocation = WindowStartupLocation.Manual;
      if (double.IsNaN(this.\u0023\u003Dq5BmP\u0024k364M3uN6AYzBdDMP2fRyyikUJ\u0024Iv5E_3j7mcU\u003D.\u0023\u003DzkNsZp5w\u003D.X) || double.IsNaN(this.\u0023\u003Dq5BmP\u0024k364M3uN6AYzBdDMP2fRyyikUJ\u0024Iv5E_3j7mcU\u003D.\u0023\u003DzkNsZp5w\u003D.Y))
      {
        // ISSUE: variable of a boxed type
        __Boxed<\u0023\u003Dz4UEwosY\u003D> zAelFq6M = (object) this.\u0023\u003DzAElFq6M\u003D;
        if (false)
          return;
        dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.\u0023\u003DzQUSnaFzeFU4H((Window) zAelFq6M);
      }
      else
      {
        this.\u0023\u003DzAElFq6M\u003D.Left = this.\u0023\u003Dq5BmP\u0024k364M3uN6AYzBdDMP2fRyyikUJ\u0024Iv5E_3j7mcU\u003D.\u0023\u003DzkNsZp5w\u003D.X;
        this.\u0023\u003DzAElFq6M\u003D.Top = this.\u0023\u003Dq5BmP\u0024k364M3uN6AYzBdDMP2fRyyikUJ\u0024Iv5E_3j7mcU\u003D.\u0023\u003DzkNsZp5w\u003D.Y;
      }
    }

    internal void \u0023\u003Dzlj\u0024uQl5763j4UxeyPw\u003D\u003D(
      #nullable enable
      object? _param1,
      EventArgs _param2)
    {
      if (true)
        ;
      Action<Window> znS2JmmeGaYca = this.\u0023\u003Dq5BmP\u0024k364M3uN6AYzBdDMP2fRyyikUJ\u0024Iv5E_3j7mcU\u003D.\u0023\u003DznS2JMmeGAYca;
      if (true)
        ;
      // ISSUE: variable of a boxed type
      __Boxed<\u0023\u003Dz4UEwosY\u003D> zAelFq6M = (object) this.\u0023\u003DzAElFq6M\u003D;
      znS2JmmeGaYca((Window) zAelFq6M);
    }
  }

  private sealed class \u0023\u003DzyENPOW6qMg6otmqOE76LkK0\u003D<\u0023\u003Dz4UEwosY\u003D> where \u0023\u003Dz4UEwosY\u003D : Window
  {
    public 
    #nullable disable
    Action \u0023\u003DzbqmXk0gvm8Ou;
    public Point \u0023\u003DzkNsZp5w\u003D;
    public Action<
    #nullable enable
    Window> \u0023\u003DznS2JMmeGAYca;

    public \u0023\u003DzyENPOW6qMg6otmqOE76LkK0\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal void \u0023\u003DzXTVQylPfCZLZCG3Abw\u003D\u003D(object? _param1, EventArgs _param2)
    {
      if (true)
        ;
      this.\u0023\u003DzbqmXk0gvm8Ou();
    }
  }

  private struct dje_zE9WJSW3G_ejd
  {
    public int dje_zSYQ6UXZJ_ejd;
    public int dje_zHVYPJ7ZR_ejd;
    public int dje_zYK6XLMFA_ejd;
    public int dje_zS8E2XUW4_ejd;
  }

  private struct dje_zR2UPS7TPPVHKBBYPX23TX_ejd
  {
    public int dje_zEU4B655V_ejd;
    public dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zE9WJSW3G_ejd dje_zFCSWSKFR9WPM56A_ejd;
    public dje_z46ZCNQR8LK5NMC7YV2DEJ9NJVYHPL2B7U2RQ8236AFTH92Q_ejd.dje_zE9WJSW3G_ejd dje_zYEL8HZUPPJ7JGMQ_ejd;
    public int dje_zX2A9HWAT_ejd;
  }
}
