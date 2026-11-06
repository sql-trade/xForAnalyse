// Decompiled with JetBrains decompiler
// Type: -.dje_zLMLSGQX98328K4M4JDEHLYJ5N37MMH9DPW5FV2BFFTA33Z2_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Navigation;
using Utils.Common.Logging;

#nullable disable
namespace \u002D;

public sealed class dje_zLMLSGQX98328K4M4JDEHLYJ5N37MMH9DPW5FV2BFFTA33Z2_ejd : 
  UserControl,
  IComponentConnector
{
  private bool \u0023\u003Dz0nsut3xYAJ4_;

  public dje_zLMLSGQX98328K4M4JDEHLYJ5N37MMH9DPW5FV2BFFTA33Z2_ejd()
  {
    if (false)
      return;
    this.InitializeComponent();
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
      dje_zLMLSGQX98328K4M4JDEHLYJ5N37MMH9DPW5FV2BFFTA33Z2_ejd.\u0023\u003DzjWbOaDc\u003D(absoluteUri);
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

  public static string dje_zLNUKHXRJ_ejd
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoHelpString;
    }
  }

  public static string \u0023\u003Dzj\u0024I8iY7_Ey3I()
  {
    return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoHelpString;
  }

  public static string dje_zD66HZ73G_ejd
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoContactString;
    }
  }

  public static string \u0023\u003Dz3F6ShTFEOXtm()
  {
    return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoContactString;
  }

  public static string dje_zZD9UQ4JJDJX9WAQ_ejd
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoWikiString;
    }
  }

  public static string \u0023\u003DzhDZB6n5oE_D2()
  {
    return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoWikiString;
  }

  public static string dje_zWZBJUFQ53V4UQFZ_ejd
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoFreeSessionString;
    }
  }

  public static string \u0023\u003DzanmBNkSQZHscIbaNQQ\u003D\u003D()
  {
    return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoFreeSessionString;
  }

  public static string dje_zWZSA2LBGNSE6LQFCPUGDMAPRLUHQ_ejd
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoOne2OneSessionString;
    }
  }

  public static string \u0023\u003Dzx86_o478jl6Lujg0RurqsIO2dPtT()
  {
    return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ProductInfoOne2OneSessionString;
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
    Uri uri1 = new Uri(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639890), UriKind.Relative);
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
        ((Hyperlink) _param2).RequestNavigate += new RequestNavigateEventHandler(this.\u0023\u003DzaEaZou_\u00241nAQ);
        break;
      case 2:
        ((Hyperlink) _param2).RequestNavigate += new RequestNavigateEventHandler(this.\u0023\u003DzaEaZou_\u00241nAQ);
        break;
      case 3:
        ((Hyperlink) _param2).RequestNavigate += new RequestNavigateEventHandler(this.\u0023\u003DzaEaZou_\u00241nAQ);
        break;
      case 4:
        ((Hyperlink) _param2).RequestNavigate += new RequestNavigateEventHandler(this.\u0023\u003DzaEaZou_\u00241nAQ);
        break;
      default:
        if (false)
          break;
        this.\u0023\u003Dz0nsut3xYAJ4_ = true;
        break;
    }
  }
}
