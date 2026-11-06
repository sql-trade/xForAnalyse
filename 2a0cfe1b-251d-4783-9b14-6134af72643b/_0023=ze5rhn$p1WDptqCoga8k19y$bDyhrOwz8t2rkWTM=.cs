// Decompiled with JetBrains decompiler
// Type: #=ze5rhn$p1WDptqCoga8k19y$bDyhrOwz8t2rkWTM=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Globalization;
using System.Threading;
using System.Windows;

#nullable disable
internal sealed class \u0023\u003Dze5rhn\u0024p1WDptqCoga8k19y\u0024bDyhrOwz8t2rkWTM\u003D
{
  private Thread \u0023\u003DzUCtX2z8\u003D;
  private string \u0023\u003Dz\u0024pK4B_7REy74;
  private Action \u0023\u003Dzt_Naz6MiEGkHHkFR3w\u003D\u003D;
  private bool \u0023\u003Dz4SJnM26DLHF\u0024;

  public \u0023\u003Dze5rhn\u0024p1WDptqCoga8k19y\u0024bDyhrOwz8t2rkWTM\u003D(Action _param1)
  {
    Action action = _param1;
    if (true)
      goto label_4;
label_1:
    string lowerInvariant = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLowerInvariant();
    if (true)
      goto label_5;
label_2:
    Thread thread = new Thread(new ThreadStart(this.\u0023\u003DzS66FwMwUvCgVBQ2cKg\u003D\u003D));
    thread.IsBackground = true;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzUCtX2z8\u003D.Start();
    return;
label_6:
    this.\u0023\u003DzUCtX2z8\u003D = thread;
    goto label_3;
label_5:
    this.\u0023\u003Dz\u0024pK4B_7REy74 = lowerInvariant;
    goto label_2;
label_4:
    this.\u0023\u003Dzt_Naz6MiEGkHHkFR3w\u003D\u003D = action;
    goto label_1;
  }

  public void \u0023\u003DzkAFM460\u003D()
  {
    if (true)
      this.\u0023\u003Dz4SJnM26DLHF\u0024 = true;
    try
    {
      this.\u0023\u003DzUCtX2z8\u003D.Interrupt();
    }
    catch (Exception ex)
    {
    }
  }

  private void \u0023\u003Dzl2ArZSCE19E0()
  {
    while (!this.\u0023\u003Dz4SJnM26DLHF\u0024)
    {
      try
      {
        \u0023\u003Dze5rhn\u0024p1WDptqCoga8k19y\u0024bDyhrOwz8t2rkWTM\u003D.\u0023\u003DzNTSpJ51m2ZPP0ez4Gg\u003D\u003D spJ51m2ZpP0ez4Gg1 = new \u0023\u003Dze5rhn\u0024p1WDptqCoga8k19y\u0024bDyhrOwz8t2rkWTM\u003D.\u0023\u003DzNTSpJ51m2ZPP0ez4Gg\u003D\u003D();
        if (true)
          goto label_4;
label_2:
        TimeSpan timeout = TimeSpan.FromSeconds(10.0);
        if (true)
          goto label_5;
label_3:
        \u0023\u003Dze5rhn\u0024p1WDptqCoga8k19y\u0024bDyhrOwz8t2rkWTM\u003D.\u0023\u003DzNTSpJ51m2ZPP0ez4Gg\u003D\u003D spJ51m2ZpP0ez4Gg2;
        if (!this.\u0023\u003Dz4SJnM26DLHF\u0024)
        {
          \u0023\u003Dze5rhn\u0024p1WDptqCoga8k19y\u0024bDyhrOwz8t2rkWTM\u003D.\u0023\u003DzNTSpJ51m2ZPP0ez4Gg\u003D\u003D spJ51m2ZpP0ez4Gg3 = spJ51m2ZpP0ez4Gg2;
          string zPK4B7Rey74 = this.\u0023\u003Dz\u0024pK4B_7REy74;
          if (true)
            goto label_9;
label_7:
          int num = (int) Application.Current.Dispatcher.BeginInvoke((Delegate) new Action(spJ51m2ZpP0ez4Gg2.\u0023\u003DzGZKVUkKUkWOy\u0024oynFfxZpwc\u003D)).Wait();
          if (spJ51m2ZpP0ez4Gg2.\u0023\u003Dzy3QD1unvmA91.Equals(this.\u0023\u003Dz\u0024pK4B_7REy74))
            break;
          this.\u0023\u003Dz\u0024pK4B_7REy74 = spJ51m2ZpP0ez4Gg2.\u0023\u003Dzy3QD1unvmA91;
          this.\u0023\u003Dzt_Naz6MiEGkHHkFR3w\u003D\u003D();
          continue;
label_9:
          spJ51m2ZpP0ez4Gg3.\u0023\u003Dzy3QD1unvmA91 = zPK4B7Rey74;
          goto label_7;
        }
        continue;
label_5:
        Thread.Sleep(timeout);
        goto label_3;
label_4:
        spJ51m2ZpP0ez4Gg2 = spJ51m2ZpP0ez4Gg1;
        goto label_2;
      }
      catch (Exception ex)
      {
      }
    }
  }

  private void \u0023\u003DzS66FwMwUvCgVBQ2cKg\u003D\u003D()
  {
    if (false)
      return;
    this.\u0023\u003Dzl2ArZSCE19E0();
  }

  private sealed class \u0023\u003DzNTSpJ51m2ZPP0ez4Gg\u003D\u003D
  {
    public string \u0023\u003Dzy3QD1unvmA91;

    public \u0023\u003DzNTSpJ51m2ZPP0ez4Gg\u003D\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal void \u0023\u003DzGZKVUkKUkWOy\u0024oynFfxZpwc\u003D()
    {
      string lowerInvariant = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLowerInvariant();
      if (false)
        return;
      this.\u0023\u003Dzy3QD1unvmA91 = lowerInvariant;
    }
  }
}
