// Decompiled with JetBrains decompiler
// Type: -.dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

#nullable disable
namespace \u002D;

public sealed class dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd : 
  UserControl,
  IComponentConnector
{
  public static readonly DependencyProperty \u0023\u003DzGdUnoWfwO3QQ;
  private bool \u0023\u003DzSV8TOZ8VqrT1;
  internal dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd \u0023\u003Dzzjgf4MM\u003D;
  internal Popup \u0023\u003DzYHgPqac\u003D;
  private bool \u0023\u003Dz0nsut3xYAJ4_;

  public dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd()
  {
    if (false)
      return;
    this.InitializeComponent();
  }

  static dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd()
  {
    DependencyProperty dependencyProperty = DependencyProperty.Register(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638897), typeof (Color), typeof (dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd), (PropertyMetadata) new FrameworkPropertyMetadata()
    {
      BindsTwoWayByDefault = true
    });
    if (false)
      return;
    dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd.\u0023\u003DzGdUnoWfwO3QQ = dependencyProperty;
  }

  public Color SelectedColor
  {
    get
    {
      if (true)
        ;
      return (Color) this.GetValue(dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd.\u0023\u003DzGdUnoWfwO3QQ);
    }
    set
    {
      DependencyProperty zGdUnoWfwO3Qq = dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd.\u0023\u003DzGdUnoWfwO3QQ;
      __Boxed<Color> local = (ValueType) value;
      if (false)
        return;
      this.SetValue(zGdUnoWfwO3Qq, (object) local);
    }
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

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "9.0.11.0")]
  public void InitializeComponent()
  {
    if (this.\u0023\u003Dz0nsut3xYAJ4_)
      return;
    if (true)
      goto label_5;
label_2:
    Uri uri1 = new Uri(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638613), UriKind.Relative);
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
        dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd prM6C274YlrdkaEjd = (dje_z2LY88C74WWPJ6EQ4HMHY2NRTC3DUZG389PRM6C274YLRDKA_ejd) _param2;
        if (true)
          goto label_3;
label_2:
        this.\u0023\u003Dzzjgf4MM\u003D.MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        this.\u0023\u003Dzzjgf4MM\u003D.PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
label_3:
        this.\u0023\u003Dzzjgf4MM\u003D = prM6C274YlrdkaEjd;
        goto label_2;
      case 2:
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        ((UIElement) _param2).PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
      case 3:
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        ((UIElement) _param2).PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
      case 4:
        ((UIElement) _param2).MouseUp += new MouseButtonEventHandler(this.\u0023\u003DzCfmUj_eudRj3);
        ((UIElement) _param2).PreviewMouseDown += new MouseButtonEventHandler(this.\u0023\u003DzDnOlBzV2DW4N);
        break;
      case 5:
        Popup popup = (Popup) _param2;
        if (false)
          break;
        this.\u0023\u003DzYHgPqac\u003D = popup;
        break;
      default:
        if (false)
          break;
        this.\u0023\u003Dz0nsut3xYAJ4_ = true;
        break;
    }
  }
}
