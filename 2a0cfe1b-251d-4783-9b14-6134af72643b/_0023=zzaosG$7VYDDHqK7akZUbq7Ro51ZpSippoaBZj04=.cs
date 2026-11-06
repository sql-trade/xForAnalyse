// Decompiled with JetBrains decompiler
// Type: #=zzaosG$7VYDDHqK7akZUbq7Ro51ZpSippoaBZj04=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using ATAS.Indicators;
using System;
using System.Runtime.CompilerServices;

#nullable disable
public sealed class \u0023\u003DzzaosG\u00247VYDDHqK7akZUbq7Ro51ZpSippoaBZj04\u003D : 
  \u0023\u003DzjCCLwkyZdbHIOi_\u0024Jqu0R2ucAy5Ie5WsrQ\u003D\u003D
{
  public readonly \u0023\u003DzmPJjdUwf8H55Zoml9k8GsZw_9ltXV04esRhh\u00244M\u003D \u0023\u003DzigU4oWM\u003D;
  public readonly string \u0023\u003DzTlJD9uyeE9bI;
  public readonly string \u0023\u003Dzo9Ks5J1cgzXn4M6oECjl1X8\u003D;

  public \u0023\u003DzzaosG\u00247VYDDHqK7akZUbq7Ro51ZpSippoaBZj04\u003D(
    string _param1,
    string _param2,
    Decimal _param3,
    Decimal _param4,
    long _param5,
    \u0023\u003DzmPJjdUwf8H55Zoml9k8GsZw_9ltXV04esRhh\u00244M\u003D _param6)
    : base(_param5, _param3, _param4)
  {
    string str1 = _param1;
    if (true)
      goto label_4;
label_1:
    string str2 = _param2;
    if (true)
      goto label_5;
label_2:
    int num = (int) _param6;
    if (false)
      return;
    this.\u0023\u003DzigU4oWM\u003D = (\u0023\u003DzmPJjdUwf8H55Zoml9k8GsZw_9ltXV04esRhh\u00244M\u003D) num;
    return;
label_5:
    this.\u0023\u003DzTlJD9uyeE9bI = str2;
    goto label_2;
label_4:
    this.\u0023\u003Dzo9Ks5J1cgzXn4M6oECjl1X8\u003D = str1;
    goto label_1;
  }

  public override string \u0023\u003DztZxTG34\u003D()
  {
    return \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623651);
  }

  public override string ToString()
  {
    DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 6);
    ref DefaultInterpolatedStringHandler local1 = ref interpolatedStringHandler;
    long zqCs9Mm = this.\u0023\u003Dzq_cs9MM\u003D;
    if (true)
      goto label_4;
label_1:
    ref DefaultInterpolatedStringHandler local2 = ref interpolatedStringHandler;
    string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623663);
    if (true)
      goto label_5;
label_2:
    ref DefaultInterpolatedStringHandler local3 = ref interpolatedStringHandler;
    string j1cgzXn4M6oEcjl1X8 = this.\u0023\u003Dzo9Ks5J1cgzXn4M6oECjl1X8\u003D;
    if (true)
      goto label_6;
label_3:
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623627));
    interpolatedStringHandler.AppendFormatted(this.\u0023\u003DzTlJD9uyeE9bI);
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623646));
    interpolatedStringHandler.AppendFormatted<Decimal>(this.\u0023\u003DzkI8q_\u0024JoQBV\u0024);
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623735));
    interpolatedStringHandler.AppendFormatted<Decimal>(this.\u0023\u003DzVw4mpME\u003D);
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623854));
    interpolatedStringHandler.AppendFormatted<\u0023\u003DzmPJjdUwf8H55Zoml9k8GsZw_9ltXV04esRhh\u00244M\u003D>(this.\u0023\u003DzigU4oWM\u003D);
    return interpolatedStringHandler.ToStringAndClear();
label_6:
    local3.AppendFormatted(j1cgzXn4M6oEcjl1X8);
    goto label_3;
label_5:
    local2.AppendLiteral(str);
    goto label_2;
label_4:
    local1.AppendFormatted<long>(zqCs9Mm);
    goto label_1;
  }

  public static \u0023\u003DzzaosG\u00247VYDDHqK7akZUbq7Ro51ZpSippoaBZj04\u003D \u0023\u003DzGVyeUcs\u003D(
    MarketDataArg _param0)
  {
    long? aggressorExchangeOrderId = _param0.AggressorExchangeOrderId;
    if (true)
      goto label_4;
label_1:
    long? nullable;
    long valueOrDefault = nullable.GetValueOrDefault();
    if (true)
      goto label_5;
label_2:
    long num1;
    string str1 = num1.ToString();
    long? exchangeOrderId = _param0.ExchangeOrderId;
    if (true)
      goto label_6;
label_3:
    string str2 = nullable.GetValueOrDefault().ToString();
    Decimal price = _param0.Price;
    Decimal volume = _param0.Volume;
    long num2 = _param0.Time.\u0023\u003DzEZrIxRMrKBVDNhwpug\u003D\u003D();
    int num3 = _param0.Direction == 1 ? 0 : 1;
    return new \u0023\u003DzzaosG\u00247VYDDHqK7akZUbq7Ro51ZpSippoaBZj04\u003D(str1, str2, price, volume, num2, (\u0023\u003DzmPJjdUwf8H55Zoml9k8GsZw_9ltXV04esRhh\u00244M\u003D) num3);
label_6:
    nullable = exchangeOrderId;
    goto label_3;
label_5:
    num1 = valueOrDefault;
    goto label_2;
label_4:
    nullable = aggressorExchangeOrderId;
    goto label_1;
  }
}
