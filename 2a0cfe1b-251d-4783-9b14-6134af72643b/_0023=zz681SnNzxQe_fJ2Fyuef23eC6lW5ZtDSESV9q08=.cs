// Decompiled with JetBrains decompiler
// Type: #=zz681SnNzxQe_fJ2Fyuef23eC6lW5ZtDSESV9q08=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;

#nullable disable
public sealed class \u0023\u003Dzz681SnNzxQe_fJ2Fyuef23eC6lW5ZtDSESV9q08\u003D : EnumConverter
{
  public \u0023\u003Dzz681SnNzxQe_fJ2Fyuef23eC6lW5ZtDSESV9q08\u003D(Type _param1)
  {
    if (true)
      ;
    Type type = _param1;
    if (true)
      ;
    // ISSUE: explicit constructor call
    base.\u002Ector(type);
  }

  public virtual object ConvertTo(
    ITypeDescriptorContext _param1,
    CultureInfo _param2,
    object _param3,
    Type _param4)
  {
    if (!(_param4 == typeof (string)))
      return base.ConvertTo(_param1, _param2, _param3, _param4);
    if (_param3 != null)
    {
      FieldInfo field = _param3.GetType().GetField(_param3.ToString());
      if (true)
        goto label_4;
label_3:
      FieldInfo fieldInfo;
      if (FieldInfo.op_Inequality(fieldInfo, (FieldInfo) null))
      {
        \u0023\u003Dzz681SnNzxQe_fJ2Fyuef23eC6lW5ZtDSESV9q08\u003D.\u0023\u003DzR2ncjDki5x9RruFfrg\u003D\u003D r2ncjDki5x9RruFfrg1 = new \u0023\u003Dzz681SnNzxQe_fJ2Fyuef23eC6lW5ZtDSESV9q08\u003D.\u0023\u003DzR2ncjDki5x9RruFfrg\u003D\u003D();
        if (true)
          goto label_8;
label_6:
        \u0023\u003Dzz681SnNzxQe_fJ2Fyuef23eC6lW5ZtDSESV9q08\u003D.\u0023\u003DzR2ncjDki5x9RruFfrg\u003D\u003D r2ncjDki5x9RruFfrg2;
        \u0023\u003Dzz681SnNzxQe_fJ2Fyuef23eC6lW5ZtDSESV9q08\u003D.\u0023\u003DzR2ncjDki5x9RruFfrg\u003D\u003D r2ncjDki5x9RruFfrg3 = r2ncjDki5x9RruFfrg2;
        DisplayAttribute[] customAttributes = (DisplayAttribute[]) ((MemberInfo) fieldInfo).GetCustomAttributes(typeof (DisplayAttribute), false);
        if (true)
          goto label_9;
label_7:
        if (r2ncjDki5x9RruFfrg2.\u0023\u003Dzqqx2ixA\u003D.Length == 0 || string.IsNullOrEmpty(r2ncjDki5x9RruFfrg2.\u0023\u003Dzqqx2ixA\u003D[0].Name))
          return (object) _param3.ToString();
        if (r2ncjDki5x9RruFfrg2.\u0023\u003Dzqqx2ixA\u003D[0].ResourceType == (Type) null)
          return (object) r2ncjDki5x9RruFfrg2.\u0023\u003Dzqqx2ixA\u003D[0].Name;
        try
        {
          string str = ((IEnumerable<PropertyInfo>) r2ncjDki5x9RruFfrg2.\u0023\u003Dzqqx2ixA\u003D[0].ResourceType.GetProperties()).Where<PropertyInfo>(new Func<PropertyInfo, bool>(r2ncjDki5x9RruFfrg2.\u0023\u003DzhrVtfAzXVIE5A\u0024YXUg\u003D\u003D)).First<PropertyInfo>().GetValue(_param1.Instance).ToString();
          return string.IsNullOrEmpty(str) ? (object) r2ncjDki5x9RruFfrg2.\u0023\u003Dzqqx2ixA\u003D[0].Name : (object) str;
        }
        catch
        {
        }
        return (object) r2ncjDki5x9RruFfrg2.\u0023\u003Dzqqx2ixA\u003D[0].Name;
label_9:
        r2ncjDki5x9RruFfrg3.\u0023\u003Dzqqx2ixA\u003D = customAttributes;
        goto label_7;
label_8:
        r2ncjDki5x9RruFfrg2 = r2ncjDki5x9RruFfrg1;
        goto label_6;
      }
      goto label_18;
label_4:
      fieldInfo = field;
      goto label_3;
    }
label_18:
    return (object) string.Empty;
  }

  private sealed class \u0023\u003DzR2ncjDki5x9RruFfrg\u003D\u003D
  {
    public DisplayAttribute[] \u0023\u003Dzqqx2ixA\u003D;

    public \u0023\u003DzR2ncjDki5x9RruFfrg\u003D\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal bool \u0023\u003DzhrVtfAzXVIE5A\u0024YXUg\u003D\u003D(PropertyInfo _param1)
    {
      PropertyInfo propertyInfo = _param1;
      if (true)
        ;
      string name1 = ((MemberInfo) propertyInfo).Name;
      if (true)
        ;
      string name2 = this.\u0023\u003Dzqqx2ixA\u003D[0].Name;
      return name1 == name2;
    }
  }
}
