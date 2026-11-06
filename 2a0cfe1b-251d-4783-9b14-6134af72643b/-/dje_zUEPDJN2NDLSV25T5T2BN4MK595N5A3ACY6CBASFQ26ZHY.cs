// Decompiled with JetBrains decompiler
// Type: -.dje_zUEPDJN2NDLSV25T5T2BN4MK595N5A3ACY6CBASFQ26ZHYVA_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

#nullable disable
namespace \u002D;

public sealed class dje_zUEPDJN2NDLSV25T5T2BN4MK595N5A3ACY6CBASFQ26ZHYVA_ejd : 
  UserControl,
  IComponentConnector
{
  internal TextBox \u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D;
  internal PasswordBox \u0023\u003Dz9A8hCYZOg_Tl;
  private bool \u0023\u003Dz0nsut3xYAJ4_;

  public dje_zUEPDJN2NDLSV25T5T2BN4MK595N5A3ACY6CBASFQ26ZHYVA_ejd()
  {
    if (true)
      goto label_3;
label_1:
    if (false)
      return;
    this.\u0023\u003DzI5s4\u0024gs\u003D();
    return;
label_3:
    this.InitializeComponent();
    goto label_1;
  }

  private void \u0023\u003Dzyaew7qan_rU1A14valObL30LRC6V(object _param1, RoutedEventArgs _param2)
  {
    if (false)
      return;
    this.\u0023\u003DzI5s4\u0024gs\u003D();
  }

  private void \u0023\u003Dzsc_TEjHNZ09zfhPULg\u003D\u003D(object _param1, RoutedEventArgs _param2)
  {
    if (false)
      return;
    this.\u0023\u003DzCOAuLDA\u003D();
  }

  private void \u0023\u003DzCOAuLDA\u003D()
  {
    if (true)
      ;
    this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.Visibility = Visibility.Visible;
    if (true)
      ;
    this.\u0023\u003Dz9A8hCYZOg_Tl.Visibility = Visibility.Collapsed;
    if (true)
      ;
    this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.Focus();
    this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.Select(this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.Text.Length, 0);
  }

  private void \u0023\u003DzI5s4\u0024gs\u003D()
  {
    if (true)
      ;
    this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.Visibility = Visibility.Collapsed;
    if (true)
      ;
    this.\u0023\u003Dz9A8hCYZOg_Tl.Visibility = Visibility.Visible;
  }

  private void \u0023\u003Dz07IV7ghItEAD3mAIAGFkH1_wpE3R(object _param1, KeyEventArgs _param2)
  {
    if (!((IEnumerable<Key>) new Key[2]
    {
      Key.Return,
      Key.Escape
    }).Contains<Key>(_param2.Key))
      return;
    this.\u0023\u003DzI5s4\u0024gs\u003D();
  }

  private void \u0023\u003DzTikTuNaL2uEyI8wJ1mv6mPo\u003D(
    object _param1,
    TextChangedEventArgs _param2)
  {
    if (true)
      ;
    PasswordBox z9A8hCyzOgTl = this.\u0023\u003Dz9A8hCYZOg_Tl;
    if (true)
      ;
    string text = this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.Text;
    z9A8hCyzOgTl.Password = text;
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
    Uri uri1 = new Uri(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638404), UriKind.Relative);
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
        TextBox textBox = (TextBox) _param2;
        if (true)
          goto label_3;
label_2:
        this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.LostFocus += new RoutedEventHandler(this.\u0023\u003Dzyaew7qan_rU1A14valObL30LRC6V);
        this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.PreviewKeyDown += new KeyEventHandler(this.\u0023\u003Dz07IV7ghItEAD3mAIAGFkH1_wpE3R);
        this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D.TextChanged += new TextChangedEventHandler(this.\u0023\u003DzTikTuNaL2uEyI8wJ1mv6mPo\u003D);
        break;
label_3:
        this.\u0023\u003DzMDIo9zSy6Q1hZaZV3Q\u003D\u003D = textBox;
        goto label_2;
      case 2:
        PasswordBox passwordBox = (PasswordBox) _param2;
        if (true)
          goto label_6;
label_5:
        this.\u0023\u003Dz9A8hCYZOg_Tl.GotFocus += new RoutedEventHandler(this.\u0023\u003Dzsc_TEjHNZ09zfhPULg\u003D\u003D);
        break;
label_6:
        this.\u0023\u003Dz9A8hCYZOg_Tl = passwordBox;
        goto label_5;
      default:
        if (false)
          break;
        this.\u0023\u003Dz0nsut3xYAJ4_ = true;
        break;
    }
  }
}
