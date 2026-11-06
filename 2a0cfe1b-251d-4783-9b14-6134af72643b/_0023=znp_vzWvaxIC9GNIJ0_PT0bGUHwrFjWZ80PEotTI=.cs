// Decompiled with JetBrains decompiler
// Type: #=znp_vzWvaxIC9GNIJ0_PT0bGUHwrFjWZ80PEotTI=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using ATAS.Indicators;
using System;
using System.Runtime.CompilerServices;

#nullable disable
public sealed class \u0023\u003Dznp_vzWvaxIC9GNIJ0_PT0bGUHwrFjWZ80PEotTI\u003D : 
  \u0023\u003DzjCCLwkyZdbHIOi_\u0024Jqu0R2ucAy5Ie5WsrQ\u003D\u003D
{
  public readonly \u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D \u0023\u003Dzuz8_9j8\u003D;
  private readonly bool \u0023\u003DzhUGe6mfZG3HVQN7Mf_rB280\u003D;

  public \u0023\u003Dznp_vzWvaxIC9GNIJ0_PT0bGUHwrFjWZ80PEotTI\u003D(
    Decimal _param1,
    Decimal _param2,
    long _param3,
    \u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D _param4,
    bool _param5)
    : base(_param3, _param1, _param2)
  {
    int num1 = (int) _param4;
    if (true)
      goto label_3;
label_1:
    int num2 = _param5 ? 1 : 0;
    if (false)
      return;
    this.\u0023\u003DzhUGe6mfZG3HVQN7Mf_rB280\u003D = num2 != 0;
    return;
label_3:
    this.\u0023\u003Dzuz8_9j8\u003D = (\u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D) num1;
    goto label_1;
  }

  public override bool \u0023\u003DzHWoxZFXhh6oTWjBQtzRoL18\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzhUGe6mfZG3HVQN7Mf_rB280\u003D;
  }

  public override string \u0023\u003DztZxTG34\u003D()
  {
    return \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623507);
  }

  public override string ToString()
  {
    DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 4);
    ref DefaultInterpolatedStringHandler local1 = ref interpolatedStringHandler;
    long zqCs9Mm = this.\u0023\u003Dzq_cs9MM\u003D;
    if (true)
      goto label_4;
label_1:
    ref DefaultInterpolatedStringHandler local2 = ref interpolatedStringHandler;
    string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623519);
    if (true)
      goto label_5;
label_2:
    ref DefaultInterpolatedStringHandler local3 = ref interpolatedStringHandler;
    Decimal zkI8qJoQbv = this.\u0023\u003DzkI8q_\u0024JoQBV\u0024;
    if (true)
      goto label_6;
label_3:
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623735));
    interpolatedStringHandler.AppendFormatted<Decimal>(this.\u0023\u003DzVw4mpME\u003D);
    interpolatedStringHandler.AppendLiteral(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623688));
    interpolatedStringHandler.AppendFormatted<\u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D>(this.\u0023\u003Dzuz8_9j8\u003D);
    return interpolatedStringHandler.ToStringAndClear();
label_6:
    local3.AppendFormatted<Decimal>(zkI8qJoQbv);
    goto label_3;
label_5:
    local2.AppendLiteral(str);
    goto label_2;
label_4:
    local1.AppendFormatted<long>(zqCs9Mm);
    goto label_1;
  }

  public static \u0023\u003Dznp_vzWvaxIC9GNIJ0_PT0bGUHwrFjWZ80PEotTI\u003D \u0023\u003DzGVyeUcs\u003D(
    MarketDataArg _param0,
    bool _param1)
  {
    if (_param0.DataType == 2)
      return (\u0023\u003Dznp_vzWvaxIC9GNIJ0_PT0bGUHwrFjWZ80PEotTI\u003D) null;
    int num = _param0.IsAsk ? 0 : 1;
    if (true)
      goto label_4;
label_3:
    \u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D l9n5UlsNxT8YoRaCnDQ;
    return new \u0023\u003Dznp_vzWvaxIC9GNIJ0_PT0bGUHwrFjWZ80PEotTI\u003D(_param0.Price, _param0.Volume, _param0.Time.\u0023\u003DzEZrIxRMrKBVDNhwpug\u003D\u003D(), l9n5UlsNxT8YoRaCnDQ, _param1);
label_4:
    l9n5UlsNxT8YoRaCnDQ = (\u0023\u003DzM9Pocwt800d27L9n5ULsNxT8Yo\u0024RACn\u0024dQ\u003D\u003D) num;
    goto label_3;
  }
}
