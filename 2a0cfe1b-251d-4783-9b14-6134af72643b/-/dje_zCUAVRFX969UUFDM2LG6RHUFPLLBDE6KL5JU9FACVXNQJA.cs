// Decompiled with JetBrains decompiler
// Type: -.dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

#nullable disable
namespace \u002D;

public sealed class dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd : 
  Window,
  IComponentConnector
{
  internal Image \u0023\u003Dz3xO0vZdzhFed;
  private bool \u0023\u003Dz0nsut3xYAJ4_;

  public dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd(
    string _param1,
    \u0023\u003DzB5Spk1ELCsBWQIfVzTEl8PSP9Xjx7ywK3SKCe\u0024UVEFqLKPpNtBs1rwU\u003D _param2)
  {
    if (true)
      goto label_4;
label_1:
    string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639190) + _param1;
    if (true)
      goto label_5;
label_2:
    \u0023\u003DzB5Spk1ELCsBWQIfVzTEl8PSP9Xjx7ywK3SKCe\u0024UVEFqLKPpNtBs1rwU\u003D uveFqLkPpNtBs1rwU = _param2;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003Dz3xO0vZdzhFed.Source = (ImageSource) \u0023\u003DzISbK5nZKgAQb\u0024Ce\u0024sk39WNYd6ZRvMgLAgQ\u003D\u003D.\u0023\u003DzJAqwOM5t6C7p\u0024AVwsYelSvM\u003D().\u0023\u003DzJjJrRUyxbrlS();
    return;
label_6:
    this.DataContext = (object) uveFqLkPpNtBs1rwU;
    goto label_3;
label_5:
    this.Title = str;
    goto label_2;
label_4:
    this.InitializeComponent();
    goto label_1;
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
    Uri uri1 = new Uri(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639149), UriKind.Relative);
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
    if (_param1 == 1)
    {
      Image image = (Image) _param2;
      if (false)
        return;
      this.\u0023\u003Dz3xO0vZdzhFed = image;
    }
    else
    {
      if (false)
        return;
      this.\u0023\u003Dz0nsut3xYAJ4_ = true;
    }
  }
}
