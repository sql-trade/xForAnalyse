// Decompiled with JetBrains decompiler
// Type: XamlGeneratedNamespace.GeneratedInternalTypeHelper
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Markup;

#nullable disable
namespace XamlGeneratedNamespace;

[DebuggerNonUserCode]
[GeneratedCode("PresentationBuildTasks", "9.0.11.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class GeneratedInternalTypeHelper : InternalTypeHelper
{
  public GeneratedInternalTypeHelper()
  {
    if (true)
      ;
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }

  protected virtual object CreateInstance(Type _param1, CultureInfo _param2)
  {
    Type type = _param1;
    if (true)
      ;
    CultureInfo cultureInfo = _param2;
    if (true)
      ;
    return Activator.CreateInstance(type, (BindingFlags) 564, (Binder) null, (object[]) null, cultureInfo);
  }

  protected virtual object GetPropertyValue(
    PropertyInfo _param1,
    object _param2,
    CultureInfo _param3)
  {
    PropertyInfo propertyInfo = _param1;
    if (true)
      ;
    object obj = _param2;
    if (true)
      ;
    CultureInfo cultureInfo = _param3;
    if (true)
      ;
    return propertyInfo.GetValue(obj, (BindingFlags) 0, (Binder) null, (object[]) null, cultureInfo);
  }

  protected virtual void SetPropertyValue(
    PropertyInfo _param1,
    object _param2,
    object _param3,
    CultureInfo _param4)
  {
    PropertyInfo propertyInfo = _param1;
    if (true)
      ;
    object obj1 = _param2;
    if (true)
      ;
    object obj2 = _param3;
    if (true)
      ;
    CultureInfo cultureInfo = _param4;
    propertyInfo.SetValue(obj1, obj2, (BindingFlags) 0, (Binder) null, (object[]) null, cultureInfo);
  }

  protected override Delegate CreateDelegate(Type _param1, object _param2, string _param3)
  {
    object obj1 = _param2;
    if (true)
      ;
    Type type1 = obj1.GetType();
    string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639379);
    object obj2 = _param2;
    if (true)
      ;
    object[] objArray = new object[2];
    Type type2 = _param1;
    if (true)
      ;
    objArray[0] = (object) type2;
    objArray[1] = (object) _param3;
    return (Delegate) type1.InvokeMember(str, (BindingFlags) 292, (Binder) null, obj2, objArray, (CultureInfo) null);
  }

  protected virtual void AddEventHandler(EventInfo _param1, object _param2, Delegate _param3)
  {
    EventInfo eventInfo = _param1;
    if (true)
      ;
    object obj = _param2;
    if (true)
      ;
    Delegate @delegate = _param3;
    if (true)
      ;
    eventInfo.AddEventHandler(obj, @delegate);
  }
}
