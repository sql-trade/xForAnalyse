// Decompiled with JetBrains decompiler
// Type: #=qmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal sealed class \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D
{
  public byte[] \u0023\u003Dzv_DK75M\u003D;
  public int \u0023\u003DzOsmxM1I\u003D;
  public int \u0023\u003DzAElFq6M\u003D;
  public DateTime \u0023\u003DzhBh6D88\u003D;

  public \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D()
  {
    DateTime utcNow = DateTime.UtcNow;
    if (true)
      goto label_3;
label_1:
    DateTime dateTime1;
    DateTime dateTime2 = dateTime1.AddTicks(1L);
    if (true)
      goto label_4;
label_2:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_4:
    this.\u0023\u003DzhBh6D88\u003D = dateTime2;
    goto label_2;
label_3:
    dateTime1 = utcNow;
    goto label_1;
  }
}
