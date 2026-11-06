// Decompiled with JetBrains decompiler
// Type: -.dje_zAYG7KEKSQSJWJ3VVSCKTT6YLYE7EARVU5ZDEBLD258NQA2Z_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Navigation;
using Utils.Common.Logging;

#nullable disable
namespace \u002D;

public sealed class dje_zAYG7KEKSQSJWJ3VVSCKTT6YLYE7EARVU5ZDEBLD258NQA2Z_ejd : 
  UserControl,
  IComponentConnector
{
  private bool \u0023\u003DzSV8TOZ8VqrT1;
  internal dje_zAYG7KEKSQSJWJ3VVSCKTT6YLYE7EARVU5ZDEBLD258NQA2Z_ejd \u0023\u003Dzzjgf4MM\u003D;
  internal StackPanel \u0023\u003DzShNUJeRq01r6;
  internal Image \u0023\u003Dz3xO0vZdzhFed;
  internal Popup \u0023\u003DzYHgPqac\u003D;
  private bool \u0023\u003Dz0nsut3xYAJ4_;

  public dje_zAYG7KEKSQSJWJ3VVSCKTT6YLYE7EARVU5ZDEBLD258NQA2Z_ejd()
  {
    if (true)
      goto label_2;
label_1:
    this.\u0023\u003Dz3xO0vZdzhFed.Source = (ImageSource) \u0023\u003DzISbK5nZKgAQb\u0024Ce\u0024sk39WNYd6ZRvMgLAgQ\u003D\u003D.\u0023\u003DzJAqwOM5t6C7p\u0024AVwsYelSvM\u003D().\u0023\u003DzJjJrRUyxbrlS();
    return;
label_2:
    this.InitializeComponent();
    goto label_1;
  }

  public static string \u0023\u003DzYMDFgOPHq5M5()
  {
    Version version1 = Assembly.GetExecutingAssembly().GetName().Version;
    if (true)
      goto label_4;
label_1:
    DateTime dateTime1 = new DateTime(2000, 1, 1);
    if (true)
      goto label_5;
label_2:
    DateTime dateTime2;
    Version version2;
    DateTime dateTime3 = dateTime2.AddDays((double) version2.Build);
    if (true)
      goto label_6;
label_3:
    DateTime dateTime4 = dateTime2.AddSeconds((double) (version2.Revision * 2));
    DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 5);
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639787));
    interpolatedStringHandler.AppendFormatted<int>(version2.Major);
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772624534));
    interpolatedStringHandler.AppendFormatted<int>(version2.Minor);
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772624534));
    interpolatedStringHandler.AppendFormatted<int>(0);
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639795));
    interpolatedStringHandler.AppendFormatted(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639803));
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639747));
    interpolatedStringHandler.AppendFormatted(dateTime4.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639754), (IFormatProvider) CultureInfo.CurrentUICulture));
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772624742));
    return interpolatedStringHandler.ToStringAndClear();
label_6:
    dateTime2 = dateTime3;
    goto label_3;
label_5:
    dateTime2 = dateTime1;
    goto label_2;
label_4:
    version2 = version1;
    goto label_1;
  }

  public static string dje_zVZTQ72AL_ejd
  {
    get
    {
      Version version1 = Assembly.GetExecutingAssembly().GetName().Version;
      if (true)
        goto label_4;
label_1:
      DateTime dateTime1 = new DateTime(2000, 1, 1);
      if (true)
        goto label_5;
label_2:
      DateTime dateTime2;
      Version version2;
      DateTime dateTime3 = dateTime2.AddDays((double) version2.Build);
      if (true)
        goto label_6;
label_3:
      DateTime dateTime4 = dateTime2.AddSeconds((double) (version2.Revision * 2));
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 5);
      interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639787));
      interpolatedStringHandler.AppendFormatted<int>(version2.Major);
      interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772624534));
      interpolatedStringHandler.AppendFormatted<int>(version2.Minor);
      interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772624534));
      interpolatedStringHandler.AppendFormatted<int>(0);
      interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639795));
      interpolatedStringHandler.AppendFormatted(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639803));
      interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639747));
      interpolatedStringHandler.AppendFormatted(dateTime4.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639754), (IFormatProvider) CultureInfo.CurrentUICulture));
      interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772624742));
      return interpolatedStringHandler.ToStringAndClear();
label_6:
      dateTime2 = dateTime3;
      goto label_3;
label_5:
      dateTime2 = dateTime1;
      goto label_2;
label_4:
      version2 = version1;
      goto label_1;
    }
  }

  public static string dje_zVPGPQBP4_ejd
  {
    get
    {
      Version version1 = Assembly.GetExecutingAssembly().GetName().Version;
      if (true)
        goto label_4;
label_1:
      DateTime dateTime1 = new DateTime(2000, 1, 1);
      if (true)
        goto label_5;
label_2:
      DateTime dateTime2;
      Version version2;
      DateTime dateTime3 = dateTime2.AddDays((double) version2.Build);
      if (true)
        goto label_6;
label_3:
      return $"{dateTime2.AddSeconds((double) (version2.Revision * 2))}";
label_6:
      dateTime2 = dateTime3;
      goto label_3;
label_5:
      dateTime2 = dateTime1;
      goto label_2;
label_4:
      version2 = version1;
      goto label_1;
    }
  }

  public static string \u0023\u003DzU3P_ZMjbA612()
  {
    Version version1 = Assembly.GetExecutingAssembly().GetName().Version;
    if (true)
      goto label_4;
label_1:
    DateTime dateTime1 = new DateTime(2000, 1, 1);
    if (true)
      goto label_5;
label_2:
    DateTime dateTime2;
    Version version2;
    DateTime dateTime3 = dateTime2.AddDays((double) version2.Build);
    if (true)
      goto label_6;
label_3:
    return $"{dateTime2.AddSeconds((double) (version2.Revision * 2))}";
label_6:
    dateTime2 = dateTime3;
    goto label_3;
label_5:
    dateTime2 = dateTime1;
    goto label_2;
label_4:
    version2 = version1;
    goto label_1;
  }

  public static string dje_zXXF2YNXA58QVZDA_ejd
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoProductWebsiteString;
    }
  }

  public static string \u0023\u003DzugBSZXb6V6Uj()
  {
    return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoProductWebsiteString;
  }

  private void \u0023\u003DzCfmUj_eudRj3(object _param1, MouseButtonEventArgs _param2)
  {
    if (true)
      ;
    if (this.\u0023\u003DzSV8TOZ8VqrT1)
      return;
    if (true)
      ;
    this.\u0023\u003DzYHgPqac\u003D.IsOpen = true;
    if (true)
      ;
    this.\u0023\u003DzYHgPqac\u003D.Focus();
  }

  private void \u0023\u003DzDnOlBzV2DW4N(object _param1, MouseButtonEventArgs _param2)
  {
    int num = this.\u0023\u003DzYHgPqac\u003D.IsOpen ? 1 : 0;
    if (false)
      return;
    this.\u0023\u003DzSV8TOZ8VqrT1 = num != 0;
  }

  private void \u0023\u003DzaEaZou_\u00241nAQ(object _param1, RequestNavigateEventArgs _param2)
  {
    try
    {
      string absoluteUri = _param2.Uri.AbsoluteUri;
      if (true)
        goto label_2;
label_1:
      _param2.Handled = true;
      return;
label_2:
      dje_zAYG7KEKSQSJWJ3VVSCKTT6YLYE7EARVU5ZDEBLD258NQA2Z_ejd.\u0023\u003DzjWbOaDc\u003D(absoluteUri);
      goto label_1;
    }
    catch (Exception ex)
    {
      if (true)
        goto label_6;
label_4:
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639975) + _param2.Uri.AbsoluteUri + \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623360);
      Exception exception1;
      Exception exception2 = exception1;
      if (false)
        return;
      LoggerHelper.LogError((object) this, str, exception2, true);
      return;
label_6:
      exception1 = ex;
      goto label_4;
    }
  }

  private static void \u0023\u003DzjWbOaDc\u003D(string _param0)
  {
    string fileName = _param0;
    if (true)
      ;
    Process.Start(new ProcessStartInfo(fileName)
    {
      UseShellExecute = true
    });
    if (false)
      ;
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
    Uri uri1 = new Uri(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639940), UriKind.Relative);
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
  internal Delegate \u0023\u003Dz937dwgpWZtpS(Type _param1, string _param2)
  {
    Type type = _param1;
    if (true)
      ;
    if (true)
      ;
    string method = _param2;
    if (true)
      ;
    return Delegate.CreateDelegate(type, (object) this, method);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "9.0.11.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.\u0023\u003Dz5M3OBa3OHovhbcSbVfningIbw_Dz(int _param1, object _param2)
  {
    switch (_param1)
    {
      case 1:
        dje_zAYG7KEKSQSJWJ3VVSCKTT6YLYE7EARVU5ZDEBLD258NQA2Z_ejd zdeblD258NqA2ZEjd = (dje_zAYG7KEKSQSJWJ3VVSCKTT6YLYE7EARVU5ZDEBLD258NQA2Z_ejd) _param2;
        if (true)
          goto label_3;
label_2:
        this.\u0023\u003Dzzjgf4MM\u003D.MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        this.\u0023\u003Dzzjgf4MM\u003D.PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
label_3:
        this.\u0023\u003Dzzjgf4MM\u003D = zdeblD258NqA2ZEjd;
        goto label_2;
      case 2:
        StackPanel stackPanel = (StackPanel) _param2;
        if (true)
          goto label_6;
label_5:
        this.\u0023\u003DzShNUJeRq01r6.MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        this.\u0023\u003DzShNUJeRq01r6.PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
label_6:
        this.\u0023\u003DzShNUJeRq01r6 = stackPanel;
        goto label_5;
      case 3:
        Image image = (Image) _param2;
        if (true)
          goto label_9;
label_8:
        this.\u0023\u003Dz3xO0vZdzhFed.MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        this.\u0023\u003Dz3xO0vZdzhFed.PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
label_9:
        this.\u0023\u003Dz3xO0vZdzhFed = image;
        goto label_8;
      case 4:
        this.\u0023\u003DzYHgPqac\u003D = (Popup) _param2;
        break;
      case 5:
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        ((UIElement) _param2).PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
      case 6:
        ((Hyperlink) _param2).RequestNavigate += new RequestNavigateEventHandler(this.\u0023\u003DzaEaZou_\u00241nAQ);
        break;
      case 7:
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        ((UIElement) _param2).PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
      case 8:
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        ((UIElement) _param2).PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
      default:
        this.\u0023\u003Dz0nsut3xYAJ4_ = true;
        break;
    }
  }
}
