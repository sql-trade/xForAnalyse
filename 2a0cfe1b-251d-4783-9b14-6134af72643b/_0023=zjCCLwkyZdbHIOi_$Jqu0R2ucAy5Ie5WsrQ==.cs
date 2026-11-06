// Decompiled with JetBrains decompiler
// Type: #=zjCCLwkyZdbHIOi_$Jqu0R2ucAy5Ie5WsrQ==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
public class \u0023\u003DzjCCLwkyZdbHIOi_\u0024Jqu0R2ucAy5Ie5WsrQ\u003D\u003D : 
  IComparable<\u0023\u003DzjCCLwkyZdbHIOi_\u0024Jqu0R2ucAy5Ie5WsrQ\u003D\u003D>
{
  public readonly long \u0023\u003Dzq_cs9MM\u003D;
  public readonly Decimal \u0023\u003DzkI8q_\u0024JoQBV\u0024;
  public readonly Decimal \u0023\u003DzVw4mpME\u003D;

  public \u0023\u003DzjCCLwkyZdbHIOi_\u0024Jqu0R2ucAy5Ie5WsrQ\u003D\u003D(
    long _param1,
    Decimal _param2,
    Decimal _param3)
  {
    long num1 = _param1;
    if (true)
      goto label_4;
label_1:
    Decimal num2 = _param2;
    if (true)
      goto label_5;
label_2:
    Decimal num3 = _param3;
    if (false)
      return;
    this.\u0023\u003DzVw4mpME\u003D = num3;
    return;
label_5:
    this.\u0023\u003DzkI8q_\u0024JoQBV\u0024 = num2;
    goto label_2;
label_4:
    this.\u0023\u003Dzq_cs9MM\u003D = num1;
    goto label_1;
  }

  public virtual bool \u0023\u003DzHWoxZFXhh6oTWjBQtzRoL18\u003D() => true;

  public virtual string \u0023\u003DztZxTG34\u003D()
  {
    return \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623697);
  }

  public int CompareTo(
    \u0023\u003DzjCCLwkyZdbHIOi_\u0024Jqu0R2ucAy5Ie5WsrQ\u003D\u003D _param1)
  {
    if (true)
      ;
    ref readonly long local = ref this.\u0023\u003Dzq_cs9MM\u003D;
    \u0023\u003DzjCCLwkyZdbHIOi_\u0024Jqu0R2ucAy5Ie5WsrQ\u003D\u003D jqu0R2ucAy5Ie5WsrQ = _param1;
    if (true)
      ;
    long zqCs9Mm = jqu0R2ucAy5Ie5WsrQ.\u0023\u003Dzq_cs9MM\u003D;
    return local.CompareTo(zqCs9Mm);
  }
}
