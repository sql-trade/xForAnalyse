// Decompiled with JetBrains decompiler
// Type: #=zlOYJm9WuZE7f7ffjXIOC8YKrFs2OfEoGXb2iq2Y=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal static class \u0023\u003DzlOYJm9WuZE7f7ffjXIOC8YKrFs2OfEoGXb2iq2Y\u003D
{
  public static string \u0023\u003DzhbTBd6500\u0024nI(this DateTime _param0)
  {
    return _param0.ToString(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622906));
  }

  public static long \u0023\u003DzEZrIxRMrKBVDNhwpug\u003D\u003D(this DateTime _param0)
  {
    TimeSpan timeSpan1 = _param0 - DateTime.UnixEpoch;
    if (true)
      goto label_2;
label_1:
    TimeSpan timeSpan2;
    return timeSpan2.Ticks * 100L;
label_2:
    timeSpan2 = timeSpan1;
    goto label_1;
  }
}
