// Decompiled with JetBrains decompiler
// Type: #=zQEUajLITVHf8aKPQUcNs$YanKS$Ktv0nVxGWfeGix0$mFgRyYw==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using \u002D;
using System;

#nullable disable
internal sealed class \u0023\u003DzQEUajLITVHf8aKPQUcNs\u0024YanKS\u0024Ktv0nVxGWfeGix0\u0024mFgRyYw\u003D\u003D : 
  \u0023\u003Dz450Sy_YFWll_apdnEPXkR6UI5DmCEfznRN0W7_5lrhccdr8D3Q\u003D\u003D
{
  private static readonly Decimal \u0023\u003Dzj3tBY0JixwwabwshiQ\u003D\u003D;
  private Decimal \u0023\u003DzSRJh2lryjR7KQ_mO9MOnH0PQfM0Q;
  private int \u0023\u003Dz2QBvteTZgMhl;

  public \u0023\u003DzQEUajLITVHf8aKPQUcNs\u0024YanKS\u0024Ktv0nVxGWfeGix0\u0024mFgRyYw\u003D\u003D(
    int _param1,
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D _param2)
  {
    if (true)
      goto label_2;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector(_param1, _param2);
    return;
label_2:
    this.\u0023\u003Dz2QBvteTZgMhl = -1;
    goto label_1;
  }

  static \u0023\u003DzQEUajLITVHf8aKPQUcNs\u0024YanKS\u0024Ktv0nVxGWfeGix0\u0024mFgRyYw\u003D\u003D()
  {
    if (false)
      return;
    \u0023\u003DzQEUajLITVHf8aKPQUcNs\u0024YanKS\u0024Ktv0nVxGWfeGix0\u0024mFgRyYw\u003D\u003D.\u0023\u003Dzj3tBY0JixwwabwshiQ\u003D\u003D = 500M;
  }

  public override string Name
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.SessionDeltaPropertyName;
    }
  }

  public override string Description
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.SessionDeltaDescription;
    }
  }

  public override void \u0023\u003DzXmDGAd0\u003D()
  {
    if (true)
      goto label_2;
label_1:
    this.\u0023\u003DzSRJh2lryjR7KQ_mO9MOnH0PQfM0Q = 0M;
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
    int z2QbvteTzgMhl = this.\u0023\u003Dz2QBvteTZgMhl;
    DateTime dateTime1 = _param1.\u0023\u003DzRk1MUYAcTQ5I();
    if (true)
      goto label_5;
label_2:
    DateTime dateTime2;
    int day = dateTime2.Day;
    if (z2QbvteTzgMhl != day)
    {
      DateTime dateTime3 = _param1.\u0023\u003DzRk1MUYAcTQ5I();
      if (true)
        goto label_8;
label_7:
      this.\u0023\u003Dz2QBvteTZgMhl = dateTime2.Day;
      this.\u0023\u003DzSRJh2lryjR7KQ_mO9MOnH0PQfM0Q = 0M;
      goto label_9;
label_8:
      dateTime2 = dateTime3;
      goto label_7;
    }
label_9:
    dateTime2 = _param1.\u0023\u003DzRk1MUYAcTQ5I();
    if (dateTime2.TimeOfDay < _param1.\u0023\u003DzkAhXqroKpfPeT50NeA\u003D\u003D())
      return;
    dateTime2 = _param1.\u0023\u003DzRk1MUYAcTQ5I();
    if (dateTime2.TimeOfDay > _param1.\u0023\u003Dzzom3Iot4nWtW9y_y3Q\u003D\u003D())
      return;
    this.\u0023\u003DzSRJh2lryjR7KQ_mO9MOnH0PQfM0Q += _param1.\u0023\u003DzgP1G3EaflTLvnKKQEA\u003D\u003D().Delta;
    this.\u0023\u003DzguQFmTA\u003D();
    return;
label_5:
    dateTime2 = dateTime1;
    goto label_2;
label_4:
    base.\u0023\u003DzLfW_9AwsD5WItfo\u00242g\u003D\u003D(u2z414exoz2lh7LJ1Cxpw);
    goto label_1;
  }

  public override void \u0023\u003DzsyynH9ONYfzf()
  {
    if (true)
      goto label_3;
label_1:
    if (true)
      goto label_4;
label_2:
    this.\u0023\u003DzSRJh2lryjR7KQ_mO9MOnH0PQfM0Q = 0M;
    return;
label_4:
    this.\u0023\u003DzB6RV9jZRKpg4(dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Invalid);
    goto label_2;
label_3:
    base.\u0023\u003DzsyynH9ONYfzf();
    goto label_1;
  }

  private void \u0023\u003DzguQFmTA\u003D()
  {
    if (this.\u0023\u003DzSRJh2lryjR7KQ_mO9MOnH0PQfM0Q > \u0023\u003DzQEUajLITVHf8aKPQUcNs\u0024YanKS\u0024Ktv0nVxGWfeGix0\u0024mFgRyYw\u003D\u003D.\u0023\u003Dzj3tBY0JixwwabwshiQ\u003D\u003D)
    {
      if (false)
        return;
      this.\u0023\u003DzB6RV9jZRKpg4(dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Long);
    }
    else if (this.\u0023\u003DzSRJh2lryjR7KQ_mO9MOnH0PQfM0Q < -\u0023\u003DzQEUajLITVHf8aKPQUcNs\u0024YanKS\u0024Ktv0nVxGWfeGix0\u0024mFgRyYw\u003D\u003D.\u0023\u003Dzj3tBY0JixwwabwshiQ\u003D\u003D)
    {
      if (false)
        return;
      this.\u0023\u003DzB6RV9jZRKpg4(dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Short);
    }
    else
    {
      if (false)
        return;
      this.\u0023\u003DzB6RV9jZRKpg4(dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Neutral);
    }
  }
}
