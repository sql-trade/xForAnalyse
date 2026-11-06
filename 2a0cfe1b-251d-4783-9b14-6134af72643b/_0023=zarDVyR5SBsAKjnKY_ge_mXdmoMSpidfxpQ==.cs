// Decompiled with JetBrains decompiler
// Type: #=zarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using ATAS.Indicators;
using System;
using System.Collections.Generic;
using System.Threading;

#nullable disable
public abstract class \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D : 
  NotifyPropertyChangedBase,
  IDisposable
{
  public bool \u0023\u003Dz48T2_fM\u003D;
  private readonly List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> \u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D;
  protected readonly \u0023\u003DzMCqAV2TdtVhLYXKOFbBQU8JKvh4VCrGf0kg244M\u003D \u0023\u003DzjS6aQ4BvkaBU;

  public \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D(
    \u0023\u003DzMCqAV2TdtVhLYXKOFbBQU8JKvh4VCrGf0kg244M\u003D _param1)
  {
    if (true)
      goto label_4;
label_1:
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> weakReferenceList = new List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>>();
    if (true)
      goto label_5;
label_2:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    \u0023\u003DzMCqAV2TdtVhLYXKOFbBQU8JKvh4VCrGf0kg244M\u003D jkvh4VcrGf0kg244M = _param1;
    if (false)
      return;
    this.\u0023\u003DzjS6aQ4BvkaBU = jkvh4VcrGf0kg244M;
    return;
label_5:
    this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D = weakReferenceList;
    goto label_2;
label_4:
    this.\u0023\u003Dz48T2_fM\u003D = true;
    goto label_1;
  }

  public void \u0023\u003DzxucRCgc\u003D(
    \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D _param1)
  {
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> vhs2Jkw60QmR7Zxw = this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> weakReferenceList1;
    try
    {
      List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> weakReferenceList2 = weakReferenceList1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D.RemoveAll(\u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003Dz_Bfedy1EoNNzL_\u0024qDQ\u003D\u003D ?? (\u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003Dz_Bfedy1EoNNzL_\u0024qDQ\u003D\u003D = new Predicate<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>>(\u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D.\u0023\u003DzWWg0Kf6iLTUN_kT2uA\u003D\u003D)));
      this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D.Add(new WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>(_param1));
      return;
label_6:
      Monitor.Enter((object) weakReferenceList2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) weakReferenceList1);
    }
label_2:
    weakReferenceList1 = vhs2Jkw60QmR7Zxw;
    goto label_1;
  }

  public void \u0023\u003DzhIha7X8\u003D(
    \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D _param1)
  {
    \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzLzngZmfGugTcZ8pkLg\u003D\u003D lzngZmfGugTcZ8pkLg1 = new \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzLzngZmfGugTcZ8pkLg\u003D\u003D();
    if (true)
      goto label_4;
label_1:
    \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzLzngZmfGugTcZ8pkLg\u003D\u003D lzngZmfGugTcZ8pkLg2;
    \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzLzngZmfGugTcZ8pkLg\u003D\u003D lzngZmfGugTcZ8pkLg3 = lzngZmfGugTcZ8pkLg2;
    \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D durnhFx1AvrL0vTlzw = _param1;
    if (true)
      goto label_5;
label_2:
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> vhs2Jkw60QmR7Zxw = this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D;
    if (true)
      goto label_6;
label_3:
    bool lockTaken = false;
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> weakReferenceList;
    try
    {
      Monitor.Enter((object) weakReferenceList, ref lockTaken);
      this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D.RemoveAll(new Predicate<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>>(lzngZmfGugTcZ8pkLg2.\u0023\u003DzGeeHR5pveNyclswO9w\u003D\u003D));
      return;
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit((object) weakReferenceList);
    }
label_6:
    weakReferenceList = vhs2Jkw60QmR7Zxw;
    goto label_3;
label_5:
    lzngZmfGugTcZ8pkLg3.\u0023\u003DzdZuQgn8\u003D = durnhFx1AvrL0vTlzw;
    goto label_2;
label_4:
    lzngZmfGugTcZ8pkLg2 = lzngZmfGugTcZ8pkLg1;
    goto label_1;
  }

  public void Dispose()
  {
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> vhs2Jkw60QmR7Zxw = this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> weakReferenceList1;
    try
    {
      List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> weakReferenceList2 = weakReferenceList1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D.Clear();
      return;
label_6:
      Monitor.Enter((object) weakReferenceList2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) weakReferenceList1);
    }
label_2:
    weakReferenceList1 = vhs2Jkw60QmR7Zxw;
    goto label_1;
  }

  public void \u0023\u003Dz7zjwazo1Tj3Q(
    \u0023\u003DzSDMx8UAFbbtHgpM8wsrFba2aUlzlI8oqQi40SKM\u003D _param1)
  {
    \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzVwRRWQDFDlRVby6rnw\u003D\u003D rrwqdfDlRvby6rnw1 = new \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzVwRRWQDFDlRVby6rnw\u003D\u003D();
    if (true)
      goto label_4;
label_1:
    \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzVwRRWQDFDlRVby6rnw\u003D\u003D rrwqdfDlRvby6rnw2;
    \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzVwRRWQDFDlRVby6rnw\u003D\u003D rrwqdfDlRvby6rnw3 = rrwqdfDlRvby6rnw2;
    int num = (int) _param1;
    if (true)
      goto label_5;
label_2:
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> vhs2Jkw60QmR7Zxw = this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D;
    if (true)
      goto label_6;
label_3:
    bool lockTaken = false;
    List<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> weakReferenceList;
    try
    {
      Monitor.Enter((object) weakReferenceList, ref lockTaken);
      this.\u0023\u003Dz3lVHs2JKw60QMR7ZXw\u003D\u003D.RemoveAll(new Predicate<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>>(rrwqdfDlRvby6rnw2.\u0023\u003DzvF9VeWCD6PmLNrn3Pw\u003D\u003D));
      return;
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit((object) weakReferenceList);
    }
label_6:
    weakReferenceList = vhs2Jkw60QmR7Zxw;
    goto label_3;
label_5:
    rrwqdfDlRvby6rnw3.\u0023\u003DzN2SkM5I\u003D = (\u0023\u003DzSDMx8UAFbbtHgpM8wsrFba2aUlzlI8oqQi40SKM\u003D) num;
    goto label_2;
label_4:
    rrwqdfDlRvby6rnw2 = rrwqdfDlRvby6rnw1;
    goto label_1;
  }

  internal static bool \u0023\u003DqV9IaI2Z_u8LBB1rBZz\u00247XrNCZgMqB0TdQTgphX4CjQreSXkmmaFj2WweF3j54xBA(
    WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D> _param0,
    \u0023\u003DzSDMx8UAFbbtHgpM8wsrFba2aUlzlI8oqQi40SKM\u003D _param1)
  {
    WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D> weakReference = _param0;
    if (true)
      ;
    \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D durnhFx1AvrL0vTlzw1;
    ref \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D local = ref durnhFx1AvrL0vTlzw1;
    if (!weakReference.TryGetTarget(out local))
      return true;
    \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D durnhFx1AvrL0vTlzw2 = durnhFx1AvrL0vTlzw1;
    if (true)
      ;
    int num = (int) _param1;
    if (true)
      ;
    durnhFx1AvrL0vTlzw2.\u0023\u003Dz7zjwazo1Tj3Q((\u0023\u003DzSDMx8UAFbbtHgpM8wsrFba2aUlzlI8oqQi40SKM\u003D) num);
    return false;
  }

  private sealed class \u0023\u003DzLzngZmfGugTcZ8pkLg\u003D\u003D
  {
    public \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D \u0023\u003DzdZuQgn8\u003D;

    public \u0023\u003DzLzngZmfGugTcZ8pkLg\u003D\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal bool \u0023\u003DzGeeHR5pveNyclswO9w\u003D\u003D(
      WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D> _param1)
    {
      WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D> weakReference = _param1;
      if (true)
        ;
      \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D durnhFx1AvrL0vTlzw1;
      ref \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D local = ref durnhFx1AvrL0vTlzw1;
      if (!weakReference.TryGetTarget(out local))
        return true;
      \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D durnhFx1AvrL0vTlzw2 = durnhFx1AvrL0vTlzw1;
      if (true)
        ;
      if (true)
        ;
      \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D zdZuQgn8 = this.\u0023\u003DzdZuQgn8\u003D;
      return durnhFx1AvrL0vTlzw2 == zdZuQgn8;
    }
  }

  private sealed class \u0023\u003DzVwRRWQDFDlRVby6rnw\u003D\u003D
  {
    public \u0023\u003DzSDMx8UAFbbtHgpM8wsrFba2aUlzlI8oqQi40SKM\u003D \u0023\u003DzN2SkM5I\u003D;

    public \u0023\u003DzVwRRWQDFDlRVby6rnw\u003D\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal bool \u0023\u003DzvF9VeWCD6PmLNrn3Pw\u003D\u003D(
      WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D> _param1)
    {
      WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D> weakReference = _param1;
      if (true)
        ;
      if (true)
        ;
      int zN2SkM5I = (int) this.\u0023\u003DzN2SkM5I\u003D;
      return \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DqV9IaI2Z_u8LBB1rBZz\u00247XrNCZgMqB0TdQTgphX4CjQreSXkmmaFj2WweF3j54xBA(weakReference, (\u0023\u003DzSDMx8UAFbbtHgpM8wsrFba2aUlzlI8oqQi40SKM\u003D) zN2SkM5I);
    }
  }

  [Serializable]
  private sealed class \u0023\u003DzewGRIik\u003D
  {
    public static readonly \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzewGRIik\u003D \u0023\u003DzahaWqVg\u003D;
    public static Predicate<WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D>> \u0023\u003Dz_Bfedy1EoNNzL_\u0024qDQ\u003D\u003D;

    static \u0023\u003DzewGRIik\u003D()
    {
      \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzewGRIik\u003D zewGrIik = new \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzewGRIik\u003D();
      if (false)
        return;
      \u0023\u003DzarDVyR5SBsAKjnKY_ge_mXdmoMSpidfxpQ\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D = zewGrIik;
    }

    public \u0023\u003DzewGRIik\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal bool \u0023\u003DzWWg0Kf6iLTUN_kT2uA\u003D\u003D(
      WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D> _param1)
    {
      WeakReference<\u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D> weakReference = _param1;
      if (true)
        ;
      \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D durnhFx1AvrL0vTlzw;
      ref \u0023\u003Dztb0IYRJHnhJZrpiyS0KTIDurnhFX1AvrL0vTLzw\u003D local = ref durnhFx1AvrL0vTlzw;
      return !weakReference.TryGetTarget(out local);
    }
  }
}
