// Decompiled with JetBrains decompiler
// Type: -.dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd
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

public sealed class dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd : 
  RadioButton,
  IComponentConnector
{
  public static readonly DependencyProperty \u0023\u003DzHi8lZtCk7uPd;
  public static readonly DependencyProperty \u0023\u003Dz2fD0wqHgcLS5;
  private bool \u0023\u003Dz0nsut3xYAJ4_;

  public dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd()
  {
    if (false)
      return;
    this.InitializeComponent();
  }

  static dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd()
  {
    DependencyProperty dependencyProperty1 = DependencyProperty.Register(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638278), typeof (ImageSource), typeof (dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd), new PropertyMetadata((PropertyChangedCallback) null));
    if (true)
      goto label_3;
label_1:
    DependencyProperty dependencyProperty2 = DependencyProperty.Register(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638299), typeof (DataTemplate), typeof (dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd), new PropertyMetadata((PropertyChangedCallback) null));
    if (false)
      return;
    dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd.\u0023\u003Dz2fD0wqHgcLS5 = dependencyProperty2;
    return;
label_3:
    dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd.\u0023\u003DzHi8lZtCk7uPd = dependencyProperty1;
    goto label_1;
  }

  public ImageSource PreviewImage
  {
    get
    {
      if (true)
        ;
      return (ImageSource) this.GetValue(dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd.\u0023\u003DzHi8lZtCk7uPd);
    }
    set
    {
      DependencyProperty zHi8lZtCk7uPd = dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd.\u0023\u003DzHi8lZtCk7uPd;
      ImageSource imageSource = value;
      if (false)
        return;
      this.SetValue(zHi8lZtCk7uPd, (object) imageSource);
    }
  }

  public DataTemplate PreviewTemplate
  {
    get
    {
      if (true)
        ;
      return (DataTemplate) this.GetValue(dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd.\u0023\u003Dz2fD0wqHgcLS5);
    }
    set
    {
      DependencyProperty z2fD0wqHgcLs5 = dje_zTVJ5M4YFM23MGGPU73KRKQ6PSLYQ6W8XYP4HQ65MAGVMLHQ_ejd.\u0023\u003Dz2fD0wqHgcLS5;
      DataTemplate dataTemplate = value;
      if (false)
        return;
      this.SetValue(z2fD0wqHgcLs5, (object) dataTemplate);
    }
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
    Uri uri1 = new Uri(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638253), UriKind.Relative);
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
    if (false)
      return;
    this.\u0023\u003Dz0nsut3xYAJ4_ = true;
  }
}
