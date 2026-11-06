// Decompiled with JetBrains decompiler
// Type: #=z6xM7pX4ELU$h6uA3zkArR0Y05jXOk0FzntJwSbjPum2q34XQnA==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using \u002D;
using ATAS.Indicators;
using System;

#nullable disable
internal sealed class \u0023\u003Dz6xM7pX4ELU\u0024h6uA3zkArR0Y05jXOk0FzntJwSbjPum2q34XQnA\u003D\u003D : 
  \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D
{
  private static readonly Decimal \u0023\u003Dzj3tBY0JixwwabwshiQ\u003D\u003D;
  private Decimal \u0023\u003Dzk_WnRxYupf8P;
  private Decimal \u0023\u003DzUFvRVygyJ0rz;
  private Decimal \u0023\u003DzlVml6rosSyoXR2SqmQ\u003D\u003D;

  public \u0023\u003Dz6xM7pX4ELU\u0024h6uA3zkArR0Y05jXOk0FzntJwSbjPum2q34XQnA\u003D\u003D(
    int _param1,
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D _param2)
  {
    if (true)
      ;
    int num = _param1;
    if (true)
      ;
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D an7ew7bpg9bqV8JyLdg = _param2;
    if (true)
      ;
    // ISSUE: explicit constructor call
    base.\u002Ector(num, an7ew7bpg9bqV8JyLdg);
  }

  static \u0023\u003Dz6xM7pX4ELU\u0024h6uA3zkArR0Y05jXOk0FzntJwSbjPum2q34XQnA\u003D\u003D()
  {
    if (false)
      return;
    \u0023\u003Dz6xM7pX4ELU\u0024h6uA3zkArR0Y05jXOk0FzntJwSbjPum2q34XQnA\u003D\u003D.\u0023\u003Dzj3tBY0JixwwabwshiQ\u003D\u003D = 0.05M;
  }

  public override string Name
  {
    get => \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.VWAPPropertyName;
  }

  public override string Description
  {
    get => \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.VWAPDescription;
  }

  public override void \u0023\u003DzXmDGAd0\u003D()
  {
    if (true)
      goto label_2;
label_1:
    this.\u0023\u003Dzk_WnRxYupf8P = 0M;
    this.\u0023\u003DzlVml6rosSyoXR2SqmQ\u003D\u003D = 0M;
    this.\u0023\u003DzUFvRVygyJ0rz = 0M;
    return;
label_2:
    base.\u0023\u003DzXmDGAd0\u003D();
    goto label_1;
  }

  public override void \u0023\u003DzLfW_9AwsD5WItfo\u00242g\u003D\u003D(
    \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoDnKCVU\u0024U2z414exoz2lh7\u0024lJ1CXpw\u003D\u003D _param1)
  {
    \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoDnKCVU\u0024U2z414exoz2lh7\u0024lJ1CXpw\u003D\u003D u2z414exoz2lh7LJ1Cxpw = _param1;
    if (true)
      goto label_4;
label_1:
    IndicatorCandle indicatorCandle1 = _param1.\u0023\u003DzgP1G3EaflTLvnKKQEA\u003D\u003D();
    if (true)
      goto label_5;
label_2:
    IndicatorCandle indicatorCandle2;
    Decimal volume = indicatorCandle2.Volume;
    if (true)
      goto label_6;
label_3:
    Decimal open = indicatorCandle2.Open;
    Decimal num;
    if (_param1.\u0023\u003DzpKvx17bx29VI())
    {
      this.\u0023\u003DzUFvRVygyJ0rz = num;
      this.\u0023\u003DzlVml6rosSyoXR2SqmQ\u003D\u003D = open * num;
    }
    else
    {
      this.\u0023\u003DzUFvRVygyJ0rz += num;
      this.\u0023\u003DzlVml6rosSyoXR2SqmQ\u003D\u003D += open * num;
    }
    this.\u0023\u003Dzk_WnRxYupf8P = this.\u0023\u003DzUFvRVygyJ0rz == 0M ? 0M : this.\u0023\u003DzlVml6rosSyoXR2SqmQ\u003D\u003D / this.\u0023\u003DzUFvRVygyJ0rz;
    this.\u0023\u003DzguQFmTA\u003D(indicatorCandle2.Close);
    return;
label_6:
    num = volume;
    goto label_3;
label_5:
    indicatorCandle2 = indicatorCandle1;
    goto label_2;
label_4:
    base.\u0023\u003DzLfW_9AwsD5WItfo\u00242g\u003D\u003D(u2z414exoz2lh7LJ1Cxpw);
    goto label_1;
  }

  private void \u0023\u003DzguQFmTA\u003D(Decimal _param1)
  {
    if (this.\u0023\u003Dzk_WnRxYupf8P == 0M)
      return;
    if (_param1 < this.\u0023\u003Dzk_WnRxYupf8P - this.\u0023\u003Dzk_WnRxYupf8P * \u0023\u003Dz6xM7pX4ELU\u0024h6uA3zkArR0Y05jXOk0FzntJwSbjPum2q34XQnA\u003D\u003D.\u0023\u003Dzj3tBY0JixwwabwshiQ\u003D\u003D / 100.0M)
    {
      if (false)
        return;
      this.\u0023\u003DzB6RV9jZRKpg4(dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Short);
    }
    else if (_param1 > this.\u0023\u003Dzk_WnRxYupf8P + this.\u0023\u003Dzk_WnRxYupf8P * \u0023\u003Dz6xM7pX4ELU\u0024h6uA3zkArR0Y05jXOk0FzntJwSbjPum2q34XQnA\u003D\u003D.\u0023\u003Dzj3tBY0JixwwabwshiQ\u003D\u003D / 100.0M)
    {
      if (false)
        return;
      this.\u0023\u003DzB6RV9jZRKpg4(dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Long);
    }
    else
    {
      if (false)
        return;
      this.\u0023\u003DzB6RV9jZRKpg4(dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Neutral);
    }
  }
}
