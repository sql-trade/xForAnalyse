// Decompiled with JetBrains decompiler
// Type: #=z450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using \u002D;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;

#nullable enable
internal class \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D : 
  \u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D,
  dje_zRCMNH5KWVDSSX9UMQZZ4P59ESRAHB2UTSL4QHPQHTYUJ7YP3QPEJVFY3Y9JNKX4ATQ_ejd
{
  private 
  #nullable disable
  EventHandler \u0023\u003DzPOms2jA\u003D;
  private int \u0023\u003DzCA7vSaRkJjZdAAZsZg\u003D\u003D;
  private readonly string \u0023\u003Dz6p8lo6aWIM9YQmI9MA\u003D\u003D;
  private readonly string \u0023\u003Dzpu1kesfQegFjnKD5Hw\u003D\u003D;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003DzT5VcEg3gaCvnQ1IDTw\u003D\u003D;
  private DateTime \u0023\u003DzC7zykt\u0024EZpZZlObe_1Jz398\u003D;
  private bool \u0023\u003Dz9oLcUiEq1R7VQhuPsKSg_uc\u003D;
  private string \u0023\u003DzDsxwVzPl02hHIflPGA\u003D\u003D;

  public \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D(
    int _param1,
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D _param2)
  {
    string empty1 = string.Empty;
    if (true)
      goto label_4;
label_1:
    string empty2 = string.Empty;
    if (true)
      goto label_5;
label_2:
    DateTime minValue = DateTime.MinValue;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzDsxwVzPl02hHIflPGA\u003D\u003D = string.Empty;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.\u0023\u003DzWW5XEE278aVv(_param1);
    this.Settings = _param2;
    _param2.PropertyChanged += new PropertyChangedEventHandler(this.\u0023\u003DzkkUABA8lA0xtevGnkMtE6Ks\u003D);
    return;
label_6:
    this.\u0023\u003DzC7zykt\u0024EZpZZlObe_1Jz398\u003D = minValue;
    goto label_3;
label_5:
    this.\u0023\u003Dzpu1kesfQegFjnKD5Hw\u003D\u003D = empty2;
    goto label_2;
label_4:
    this.\u0023\u003Dz6p8lo6aWIM9YQmI9MA\u003D\u003D = empty1;
    goto label_1;
  }

  [CompilerGenerated]
  [SpecialName]
  public void \u0023\u003DzM9r_g8ExP\u0024Ho(EventHandler _param1)
  {
    EventHandler zPoms2jA = this.\u0023\u003DzPOms2jA\u003D;
    EventHandler eventHandler1;
    if (true)
      eventHandler1 = zPoms2jA;
    EventHandler comparand;
    do
    {
      EventHandler eventHandler2 = eventHandler1;
      if (true)
        goto label_6;
label_3:
      EventHandler eventHandler3 = comparand + _param1;
      if (true)
        goto label_7;
label_4:
      EventHandler eventHandler4;
      eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.\u0023\u003DzPOms2jA\u003D, eventHandler4, comparand);
      continue;
label_7:
      eventHandler4 = eventHandler3;
      goto label_4;
label_6:
      comparand = eventHandler2;
      goto label_3;
    }
    while (eventHandler1 != comparand);
  }

  [CompilerGenerated]
  [SpecialName]
  public void \u0023\u003Dz1e0o_xCJ9tcu(EventHandler _param1)
  {
    EventHandler zPoms2jA = this.\u0023\u003DzPOms2jA\u003D;
    EventHandler eventHandler1;
    if (true)
      eventHandler1 = zPoms2jA;
    EventHandler comparand;
    do
    {
      EventHandler eventHandler2 = eventHandler1;
      if (true)
        goto label_6;
label_3:
      EventHandler eventHandler3 = comparand - _param1;
      if (true)
        goto label_7;
label_4:
      EventHandler eventHandler4;
      eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.\u0023\u003DzPOms2jA\u003D, eventHandler4, comparand);
      continue;
label_7:
      eventHandler4 = eventHandler3;
      goto label_4;
label_6:
      comparand = eventHandler2;
      goto label_3;
    }
    while (eventHandler1 != comparand);
  }

  [CompilerGenerated]
  [SpecialName]
  public int \u0023\u003DzXO3IRlArVyAI()
  {
    if (true)
      ;
    return this.\u0023\u003DzCA7vSaRkJjZdAAZsZg\u003D\u003D;
  }

  private void \u0023\u003DzWW5XEE278aVv(int _param1)
  {
    int num = _param1;
    if (false)
      return;
    this.\u0023\u003DzCA7vSaRkJjZdAAZsZg\u003D\u003D = num;
  }

  public virtual string Name
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz6p8lo6aWIM9YQmI9MA\u003D\u003D;
    }
  }

  public virtual string Description
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dzpu1kesfQegFjnKD5Hw\u003D\u003D;
    }
  }

  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D Settings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzT5VcEg3gaCvnQ1IDTw\u003D\u003D;
    }
    private set
    {
      \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D an7ew7bpg9bqV8JyLdg = value;
      if (false)
        return;
      this.\u0023\u003DzT5VcEg3gaCvnQ1IDTw\u003D\u003D = an7ew7bpg9bqV8JyLdg;
    }
  }

  public DateTime \u0023\u003DzkVCOOd88Tz_l()
  {
    if (true)
      ;
    return this.\u0023\u003DzC7zykt\u0024EZpZZlObe_1Jz398\u003D;
  }

  private void \u0023\u003DziJRiBQBw1Hjn(DateTime _param1)
  {
    DateTime dateTime = _param1;
    if (false)
      return;
    this.\u0023\u003DzC7zykt\u0024EZpZZlObe_1Jz398\u003D = dateTime;
  }

  public bool \u0023\u003DzAeHI2cZOK2Td()
  {
    if (true)
      ;
    return this.\u0023\u003Dz9oLcUiEq1R7VQhuPsKSg_uc\u003D;
  }

  private void \u0023\u003DzvcHgz8HsgcPR(bool _param1)
  {
    int num = _param1 ? 1 : 0;
    if (false)
      return;
    this.\u0023\u003Dz9oLcUiEq1R7VQhuPsKSg_uc\u003D = num != 0;
  }

  public string \u0023\u003DzU9KY8F88qaLz()
  {
    if (true)
      ;
    return this.\u0023\u003DzDsxwVzPl02hHIflPGA\u003D\u003D;
  }

  protected void \u0023\u003DzZ1Hu3JrmXNEB(string _param1)
  {
    string str = _param1;
    if (false)
      return;
    this.\u0023\u003DzDsxwVzPl02hHIflPGA\u003D\u003D = str;
  }

  protected void \u0023\u003DzIWZbRo5hAmhG()
  {
    if (true)
      ;
    EventHandler zPoms2jA = this.\u0023\u003DzPOms2jA\u003D;
    if (zPoms2jA == null)
    {
      if (false)
        ;
    }
    else
    {
      if (true)
        ;
      zPoms2jA((object) this, EventArgs.Empty);
    }
  }

  protected void \u0023\u003DzB6RV9jZRKpg4(
    dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd _param1)
  {
    \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D.\u0023\u003DzXMvcQNhQL2r38bbbVG9LgxA\u003D ql2r38bbbVg9LgxA1 = new \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D.\u0023\u003DzXMvcQNhQL2r38bbbVG9LgxA\u003D();
    if (true)
      goto label_5;
label_1:
    \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D.\u0023\u003DzXMvcQNhQL2r38bbbVG9LgxA\u003D ql2r38bbbVg9LgxA2;
    \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D.\u0023\u003DzXMvcQNhQL2r38bbbVG9LgxA\u003D ql2r38bbbVg9LgxA3 = ql2r38bbbVg9LgxA2;
    if (true)
      goto label_6;
label_2:
    \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D.\u0023\u003DzXMvcQNhQL2r38bbbVG9LgxA\u003D ql2r38bbbVg9LgxA4 = ql2r38bbbVg9LgxA2;
    int num = (int) _param1;
    if (true)
      goto label_7;
label_3:
    if (this.Settings.CalculatedBias == ql2r38bbbVg9LgxA2.\u0023\u003DzKJitM64\u003D)
      return;
    Application.Current.Dispatcher.Invoke(new Action(ql2r38bbbVg9LgxA2.\u0023\u003Dz\u0024kqPGSapiesP_yjhqw\u003D\u003D));
    this.\u0023\u003DzAeHI2cZOK2Td();
    return;
label_7:
    ql2r38bbbVg9LgxA4.\u0023\u003DzKJitM64\u003D = (dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd) num;
    goto label_3;
label_6:
    ql2r38bbbVg9LgxA3.\u0023\u003DziRnUrnBEE78Y = this;
    goto label_2;
label_5:
    ql2r38bbbVg9LgxA2 = ql2r38bbbVg9LgxA1;
    goto label_1;
  }

  public double \u0023\u003DzgH53fdrbvlWn(int _param1)
  {
    if (!this.Settings.Enabled)
      return 0.0;
    double num1 = 100.0 / (double) _param1 * (double) this.Settings.Weight;
    if (true)
      goto label_5;
label_3:
    int resultingBias = (int) this.Settings.ResultingBias;
    if (true)
      goto label_6;
label_4:
    dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd m5Z3TtvC89DevqEjd;
    double num2;
    if (m5Z3TtvC89DevqEjd == dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Long)
      return num2;
    return m5Z3TtvC89DevqEjd == dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Short ? -num2 : 0.0;
label_6:
    m5Z3TtvC89DevqEjd = (dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd) resultingBias;
    goto label_4;
label_5:
    num2 = num1;
    goto label_3;
  }

  public virtual void \u0023\u003DzXmDGAd0\u003D()
  {
    if (true)
      goto label_3;
label_1:
    if (false)
      return;
    this.\u0023\u003DzB6RV9jZRKpg4(dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Invalid);
    return;
label_3:
    this.\u0023\u003DzvcHgz8HsgcPR(true);
    goto label_1;
  }

  public virtual void \u0023\u003DztdDT\u00245vLese_(
    \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoDnKCVU\u0024U2z414exoz2lh7\u0024lJ1CXpw\u003D\u003D _param1)
  {
    if (false)
      return;
    this.\u0023\u003DzvcHgz8HsgcPR(false);
  }

  public virtual void \u0023\u003DzLfW_9AwsD5WItfo\u00242g\u003D\u003D(
    \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoDnKCVU\u0024U2z414exoz2lh7\u0024lJ1CXpw\u003D\u003D _param1)
  {
    DateTime dateTime = _param1.\u0023\u003DzRk1MUYAcTQ5I();
    if (false)
      return;
    this.\u0023\u003DziJRiBQBw1Hjn(dateTime);
  }

  public virtual void \u0023\u003DzsyynH9ONYfzf()
  {
  }

  private void \u0023\u003DzkkUABA8lA0xtevGnkMtE6Ks\u003D(
    #nullable enable
    object? _param1,
    PropertyChangedEventArgs _param2)
  {
    if (!_param2.PropertyName.Equals(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622296)))
      return;
    this.\u0023\u003DzIWZbRo5hAmhG();
  }

  private sealed class \u0023\u003DzXMvcQNhQL2r38bbbVG9LgxA\u003D
  {
    public 
    #nullable disable
    \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D \u0023\u003DziRnUrnBEE78Y;
    public dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd \u0023\u003DzKJitM64\u003D;

    public \u0023\u003DzXMvcQNhQL2r38bbbVG9LgxA\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal void \u0023\u003Dz\u0024kqPGSapiesP_yjhqw\u003D\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit non-virtual call
      \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D settings = __nonvirtual (this.\u0023\u003DziRnUrnBEE78Y.Settings);
      if (true)
        ;
      int zKjitM64 = (int) this.\u0023\u003DzKJitM64\u003D;
      settings.CalculatedBias = (dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd) zKjitM64;
    }
  }
}
