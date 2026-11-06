// Decompiled with JetBrains decompiler
// Type: #=qdYMMamnBL0CHpfa_3irMrVA15ixPRrrNPonpzCanFfY=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Reflection;
using System.Security;

#nullable disable
internal static class \u0023\u003DqdYMMamnBL0CHpfa_3irMrVA15ixPRrrNPonpzCanFfY\u003D
{
  private static readonly bool \u0023\u003Dzv_DK75M\u003D;

  static \u0023\u003DqdYMMamnBL0CHpfa_3irMrVA15ixPRrrNPonpzCanFfY\u003D()
  {
    int num = \u0023\u003DqdYMMamnBL0CHpfa_3irMrVA15ixPRrrNPonpzCanFfY\u003D.\u0023\u003Dzuz5LKDU8z\u0024uDOuk_jf8E0b2R8uJW() ? 1 : 0;
    if (false)
      return;
    \u0023\u003DqdYMMamnBL0CHpfa_3irMrVA15ixPRrrNPonpzCanFfY\u003D.\u0023\u003Dzv_DK75M\u003D = num != 0;
  }

  private static bool \u0023\u003Dzuz5LKDU8z\u0024uDOuk_jf8E0b2R8uJW()
  {
    bool flag1;
    try
    {
      if (Environment.Version.Major < 4)
      {
        if (true)
          flag1 = false;
      }
      else
      {
        Assembly assembly1 = typeof (dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd).Assembly;
        Assembly assembly2 = typeof (SecurityCriticalAttribute).Assembly;
        if (true)
          goto label_6;
label_4:
        if (true)
          goto label_7;
label_5:
        Assembly assembly3;
        bool flag2;
        foreach (object customAttribute in assembly1.GetCustomAttributes(false))
        {
          if (customAttribute is AllowPartiallyTrustedCallersAttribute)
          {
            flag2 = true;
          }
          else
          {
            Type type = customAttribute.GetType();
            if (Assembly.op_Equality(type.Assembly, assembly3) && \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772624488).Equals(type.FullName, StringComparison.Ordinal) && (byte) type.GetProperty(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772624467)).GetValue(customAttribute, (object[]) null) != (byte) 2)
            {
              flag1 = false;
              goto label_16;
            }
          }
        }
        flag1 = flag2;
        goto label_16;
label_7:
        flag2 = false;
        goto label_5;
label_6:
        assembly3 = assembly2;
        goto label_4;
      }
    }
    catch
    {
      flag1 = false;
    }
label_16:
    return flag1;
  }

  public static bool \u0023\u003DzTAGQeyCF3QjZrNy_V29\u0024m5fZPhf2()
  {
    return \u0023\u003DqdYMMamnBL0CHpfa_3irMrVA15ixPRrrNPonpzCanFfY\u003D.\u0023\u003Dzv_DK75M\u003D;
  }
}
