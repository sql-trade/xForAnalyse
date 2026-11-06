// Decompiled with JetBrains decompiler
// Type: -.dje_zG426HU5Y8N752U5TZBUUJVF6MWT4V73ZENJRRWJARDSY96Z_ejd
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

#nullable disable
namespace \u002D;

public sealed class dje_zG426HU5Y8N752U5TZBUUJVF6MWT4V73ZENJRRWJARDSY96Z_ejd : 
  UserControl,
  IComponentConnector
{
  private bool \u0023\u003Dz0nsut3xYAJ4_;

  public dje_zG426HU5Y8N752U5TZBUUJVF6MWT4V73ZENJRRWJARDSY96Z_ejd()
  {
    if (false)
      return;
    this.InitializeComponent();
  }

  private void \u0023\u003DzkFkiuuP0B0gea2GXO3QdxOU\u003D(
    object _param1,
    MouseButtonEventArgs _param2)
  {
    if (true)
      ;
    if (this.DataContext == null)
      return;
    if (true)
      ;
    if (!(this.DataContext is \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D))
      return;
    if (true)
      ;
    ((\u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D) this.DataContext).\u0023\u003Dz8bYhdIYOdvFN();
  }

  private void \u0023\u003DzCTMcoNNNsng3xoHC6A\u003D\u003D(
    object _param1,
    MouseButtonEventArgs _param2)
  {
    if (true)
      ;
    if (this.DataContext == null)
      return;
    if (true)
      ;
    if (!(this.DataContext is \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D))
      return;
    if (true)
      ;
    ((\u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D) this.DataContext).\u0023\u003DzphoOdsgRFdUW();
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
    Uri uri1 = new Uri(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638751), UriKind.Relative);
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
        ((UIElement) _param2).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(this.\u0023\u003DzkFkiuuP0B0gea2GXO3QdxOU\u003D);
        break;
      case 2:
        ((UIElement) _param2).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(this.\u0023\u003DzkFkiuuP0B0gea2GXO3QdxOU\u003D);
        break;
      case 3:
        ((UIElement) _param2).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(this.\u0023\u003DzkFkiuuP0B0gea2GXO3QdxOU\u003D);
        break;
      case 4:
        ((UIElement) _param2).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(this.\u0023\u003DzCTMcoNNNsng3xoHC6A\u003D\u003D);
        break;
      case 5:
        ((UIElement) _param2).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(this.\u0023\u003DzCTMcoNNNsng3xoHC6A\u003D\u003D);
        break;
      default:
        if (false)
          break;
        this.\u0023\u003Dz0nsut3xYAJ4_ = true;
        break;
    }
  }
}
