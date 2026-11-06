// Decompiled with JetBrains decompiler
// Type: #=qqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections.Generic;
using System.Threading;

#nullable disable
internal sealed class \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D
{
  private readonly object \u0023\u003Dzv_DK75M\u003D;
  private \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D[] \u0023\u003DzOsmxM1I\u003D;
  private Dictionary<int, \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D> \u0023\u003DzAElFq6M\u003D;
  private volatile bool \u0023\u003DzhBh6D88\u003D;
  private \u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D \u0023\u003DzsIRkzxg\u003D;
  private Dictionary<int, WeakReference> \u0023\u003DzQvRsjjA\u003D;
  private object \u0023\u003DzlrX5m0o\u003D;
  private int \u0023\u003DzDnwpn_c\u003D;
  private object[] \u0023\u003DzZ04UAGU\u003D;
  private int \u0023\u003DzL67ogXM\u003D;

  public \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D(
    \u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D _param1)
  {
    object obj = new object();
    if (true)
      goto label_3;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    \u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D ej8RogRnR4cNaYl8 = _param1;
    if (false)
      return;
    this.\u0023\u003DzsIRkzxg\u003D = ej8RogRnR4cNaYl8;
    return;
label_3:
    this.\u0023\u003Dzv_DK75M\u003D = obj;
    goto label_1;
  }

  private void \u0023\u003Dzx0NJ2gci1UNxvzJI7XJ6yoEyMUdM8DMtc6uxuifNQwh\u0024()
  {
    if (this.\u0023\u003DzhBh6D88\u003D)
      return;
    object zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    if (true)
      goto label_3;
label_2:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_8;
label_6:
      if (this.\u0023\u003DzhBh6D88\u003D)
        return;
      this.\u0023\u003DzOsmxM1I\u003D = new \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D[this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzZMV\u0024LXT06EaUPuQ4sX6i6U7ggdUA0iVc5g\u003D\u003D()];
      for (int index = 0; index < this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzZMV\u0024LXT06EaUPuQ4sX6i6U7ggdUA0iVc5g\u003D\u003D(); ++index)
        this.\u0023\u003DzOsmxM1I\u003D[index] = new \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D();
      this.\u0023\u003DzAElFq6M\u003D = new Dictionary<int, \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D>();
      this.\u0023\u003DzQvRsjjA\u003D = new Dictionary<int, WeakReference>();
      this.\u0023\u003DzlrX5m0o\u003D = new object();
      this.\u0023\u003DzDnwpn_c\u003D = this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzKJyb99\u0024e5yZ\u0024LV\u00245VVjHNCJ5JBeNWhFx0rsjDHE\u003D();
      this.\u0023\u003DzZ04UAGU\u003D = new object[this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzARnS3D7Pdrx8NGd8YugFT4miNgiJPKPljnL973E\u003D()];
      this.\u0023\u003DzhBh6D88\u003D = true;
      return;
label_8:
      Monitor.Enter(obj2, ref local);
      goto label_6;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_3:
    obj1 = zvDk75M;
    goto label_2;
  }

  public void \u0023\u003Dz_NAG0mj12d1dKp2fVK4Jtpo\u003D(
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D _param1)
  {
    if (true)
      goto label_3;
label_1:
    object zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    if (true)
      goto label_4;
label_2:
    bool lockTaken;
    if (true)
      lockTaken = false;
    object obj;
    try
    {
      Monitor.Enter(obj, ref lockTaken);
      \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI1;
      if (this.\u0023\u003DzAElFq6M\u003D.TryGetValue(_param1.\u0023\u003DzOsmxM1I\u003D, out l5pWoNvVzgGexRezI1) && l5pWoNvVzgGexRezI1 != null)
      {
        l5pWoNvVzgGexRezI1.\u0023\u003DzhBh6D88\u003D = _param1.\u0023\u003DzhBh6D88\u003D;
        return;
      }
      int index1 = 0;
      DateTime zhBh6D88 = this.\u0023\u003DzOsmxM1I\u003D[0].\u0023\u003DzhBh6D88\u003D;
      for (int index2 = 1; index2 < this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzZMV\u0024LXT06EaUPuQ4sX6i6U7ggdUA0iVc5g\u003D\u003D(); ++index2)
      {
        if (this.\u0023\u003DzOsmxM1I\u003D[index2].\u0023\u003DzhBh6D88\u003D < zhBh6D88)
          index1 = index2;
      }
      \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI2 = this.\u0023\u003DzOsmxM1I\u003D[index1];
      if (l5pWoNvVzgGexRezI2.\u0023\u003Dzv_DK75M\u003D == null)
        l5pWoNvVzgGexRezI2.\u0023\u003Dzv_DK75M\u003D = new byte[this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzAl9LUuaVGVBIPfreew2Vefaf7k5xedMiui\u0024u8i1U8d8p()];
      else
        this.\u0023\u003DzAElFq6M\u003D[l5pWoNvVzgGexRezI2.\u0023\u003DzOsmxM1I\u003D] = (\u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D) null;
      this.\u0023\u003DzjRxWYwvUUGs1_g\u0024_6l2svAo7ERl2(_param1, l5pWoNvVzgGexRezI2);
      this.\u0023\u003DzAElFq6M\u003D[l5pWoNvVzgGexRezI2.\u0023\u003DzOsmxM1I\u003D] = l5pWoNvVzgGexRezI2;
      if (this.\u0023\u003DzAElFq6M\u003D.Count <= this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzZMV\u0024LXT06EaUPuQ4sX6i6U7ggdUA0iVc5g\u003D\u003D() * 2)
        return;
      this.\u0023\u003Dz7ItT6jidlsnoIPkTWjAA80ac1CYF();
      return;
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit(obj);
    }
label_4:
    obj = zvDk75M;
    goto label_2;
label_3:
    this.\u0023\u003Dzx0NJ2gci1UNxvzJI7XJ6yoEyMUdM8DMtc6uxuifNQwh\u0024();
    goto label_1;
  }

  private void \u0023\u003Dz7ItT6jidlsnoIPkTWjAA80ac1CYF()
  {
    Dictionary<int, \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D> zAelFq6M = this.\u0023\u003DzAElFq6M\u003D;
    if (true)
      goto label_3;
label_1:
    List<int> intList1 = new List<int>();
    if (true)
      goto label_4;
label_2:
    Dictionary<int, \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D> dictionary;
    Dictionary<int, \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D>.Enumerator enumerator1 = dictionary.GetEnumerator();
    Dictionary<int, \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D>.Enumerator enumerator2;
    if (true)
      enumerator2 = enumerator1;
    List<int> intList2;
    try
    {
      while (enumerator2.MoveNext())
      {
        KeyValuePair<int, \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D> current = enumerator2.Current;
        if (current.Value == null)
          intList2.Add(current.Key);
      }
    }
    finally
    {
      enumerator2.Dispose();
    }
    using (List<int>.Enumerator enumerator3 = intList2.GetEnumerator())
    {
      while (enumerator3.MoveNext())
      {
        int current = enumerator3.Current;
        dictionary.Remove(current);
      }
      return;
    }
label_4:
    intList2 = intList1;
    goto label_2;
label_3:
    dictionary = zAelFq6M;
    goto label_1;
  }

  public bool \u0023\u003DzPH5ndEAd1KdZ1sE72Rc_VYQ\u003D(
    int _param1,
    ref \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D _param2)
  {
    if (!this.\u0023\u003DzhBh6D88\u003D)
      return false;
    object zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    if (true)
      goto label_4;
label_3:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_8;
label_7:
      \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI;
      if (this.\u0023\u003DzAElFq6M\u003D.TryGetValue(_param1, out l5pWoNvVzgGexRezI))
      {
        if (l5pWoNvVzgGexRezI != null)
        {
          this.\u0023\u003DzjRxWYwvUUGs1_g\u0024_6l2svAo7ERl2(l5pWoNvVzgGexRezI, _param2);
          return true;
        }
        goto label_14;
      }
      goto label_14;
label_8:
      Monitor.Enter(obj2, ref local);
      goto label_7;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_14:
    return false;
label_4:
    obj1 = zvDk75M;
    goto label_3;
  }

  private void \u0023\u003DzjRxWYwvUUGs1_g\u0024_6l2svAo7ERl2(
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D _param1,
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D _param2)
  {
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI1 = _param1;
    DateTime utcNow = DateTime.UtcNow;
    if (true)
      goto label_4;
label_1:
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI2 = _param2;
    int zOsmxM1I = _param1.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_5;
label_2:
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI3 = _param2;
    int zAelFq6M = _param1.\u0023\u003DzAElFq6M\u003D;
    if (true)
      goto label_6;
label_3:
    _param2.\u0023\u003DzhBh6D88\u003D = _param1.\u0023\u003DzhBh6D88\u003D;
    Buffer.BlockCopy((Array) _param1.\u0023\u003Dzv_DK75M\u003D, 0, (Array) _param2.\u0023\u003Dzv_DK75M\u003D, 0, this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzAl9LUuaVGVBIPfreew2Vefaf7k5xedMiui\u0024u8i1U8d8p());
    return;
label_6:
    l5pWoNvVzgGexRezI3.\u0023\u003DzAElFq6M\u003D = zAelFq6M;
    goto label_3;
label_5:
    l5pWoNvVzgGexRezI2.\u0023\u003DzOsmxM1I\u003D = zOsmxM1I;
    goto label_2;
label_4:
    l5pWoNvVzgGexRezI1.\u0023\u003DzhBh6D88\u003D = utcNow;
    goto label_1;
  }

  private void \u0023\u003DzlKrIksuanhOXsyGcBC6ESt5KEFlZ(object _param1)
  {
    int index;
    if (true)
      index = 0;
    while (index < this.\u0023\u003DzZ04UAGU\u003D.Length)
    {
      if (this.\u0023\u003DzZ04UAGU\u003D[index] == _param1)
        return;
      int num = index + 1;
      if (true)
        index = num;
    }
    this.\u0023\u003DzZ04UAGU\u003D[this.\u0023\u003DzL67ogXM\u003D] = _param1;
    int num1 = this.\u0023\u003DzL67ogXM\u003D + 1;
    if (true)
      goto label_10;
label_8:
    if (this.\u0023\u003DzL67ogXM\u003D != this.\u0023\u003DzZ04UAGU\u003D.Length)
      return;
    this.\u0023\u003DzL67ogXM\u003D = 0;
    return;
label_10:
    this.\u0023\u003DzL67ogXM\u003D = num1;
    goto label_8;
  }

  private void \u0023\u003DzW1GfCy3UzvNXR4iVrVuiATHEzm3bswvwyA\u003D\u003D()
  {
    if (this.\u0023\u003DzQvRsjjA\u003D.Count < this.\u0023\u003DzDnwpn_c\u003D)
      return;
    Dictionary<int, WeakReference> dictionary1 = new Dictionary<int, WeakReference>();
    if (true)
      goto label_3;
label_2:
    Dictionary<int, WeakReference>.Enumerator enumerator1 = this.\u0023\u003DzQvRsjjA\u003D.GetEnumerator();
    Dictionary<int, WeakReference>.Enumerator enumerator2;
    if (true)
      enumerator2 = enumerator1;
    Dictionary<int, WeakReference> dictionary2;
    try
    {
      while (enumerator2.MoveNext())
      {
        KeyValuePair<int, WeakReference> current = enumerator2.Current;
        if (true)
          goto label_8;
label_7:
        KeyValuePair<int, WeakReference> keyValuePair;
        if (keyValuePair.Value.IsAlive)
        {
          dictionary2.Add(keyValuePair.Key, keyValuePair.Value);
          continue;
        }
        continue;
label_8:
        keyValuePair = current;
        goto label_7;
      }
    }
    finally
    {
      enumerator2.Dispose();
    }
    this.\u0023\u003DzQvRsjjA\u003D = dictionary2;
    this.\u0023\u003DzDnwpn_c\u003D = Math.Max(dictionary2.Count * 2, 10);
    return;
label_3:
    dictionary2 = dictionary1;
    goto label_2;
  }

  public void \u0023\u003DzmFX9kqr2K7yZOiZHGfpsPlu8\u00242PFYA\u0024qN7LIdNg\u003D(
    int _param1,
    byte[] _param2,
    int _param3,
    int _param4,
    bool _param5)
  {
    if (true)
      goto label_3;
label_1:
    object zlrX5m0o = this.\u0023\u003DzlrX5m0o\u003D;
    if (true)
      goto label_4;
label_2:
    bool lockTaken;
    if (true)
      lockTaken = false;
    object obj;
    try
    {
      Monitor.Enter(obj, ref lockTaken);
      WeakReference weakReference;
      if (this.\u0023\u003DzQvRsjjA\u003D.TryGetValue(_param1, out weakReference) && weakReference.Target is \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D.\u0023\u003Dzv_DK75M\u003D target)
      {
        if (target.\u0023\u003Dzv_DK75M\u003D.Length < _param4)
          target.\u0023\u003DztNKGUAKxo2p50zXtfxaOKXK0zJ\u0024YRecN9y3g75M\u003D(_param2, _param3, _param4, _param5);
      }
      else
      {
        this.\u0023\u003DzW1GfCy3UzvNXR4iVrVuiATHEzm3bswvwyA\u003D\u003D();
        target = new \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D.\u0023\u003Dzv_DK75M\u003D(_param2, _param3, _param4, _param5);
        this.\u0023\u003DzQvRsjjA\u003D[_param1] = new WeakReference((object) target);
      }
      this.\u0023\u003DzlKrIksuanhOXsyGcBC6ESt5KEFlZ((object) target);
      return;
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit(obj);
    }
label_4:
    obj = zlrX5m0o;
    goto label_2;
label_3:
    this.\u0023\u003Dzx0NJ2gci1UNxvzJI7XJ6yoEyMUdM8DMtc6uxuifNQwh\u0024();
    goto label_1;
  }

  public bool \u0023\u003DzpXvNuF8OVTuYuhS8NQ\u003D\u003D(
    int _param1,
    byte[] _param2,
    int _param3,
    int _param4,
    out int _param5)
  {
    _param5 = 0;
    if (!this.\u0023\u003DzhBh6D88\u003D)
      return false;
    object zlrX5m0o = this.\u0023\u003DzlrX5m0o\u003D;
    if (true)
      goto label_4;
label_3:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_8;
label_7:
      WeakReference weakReference;
      if (!this.\u0023\u003DzQvRsjjA\u003D.TryGetValue(_param1, out weakReference) || !(weakReference.Target is \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D.\u0023\u003Dzv_DK75M\u003D target))
        return false;
      int length = target.\u0023\u003Dzv_DK75M\u003D.Length;
      _param5 = _param4;
      if (length < _param4)
      {
        if (!target.\u0023\u003DzOsmxM1I\u003D)
          return false;
        _param5 = length;
      }
      Buffer.BlockCopy((Array) target.\u0023\u003Dzv_DK75M\u003D, 0, (Array) _param2, _param3, _param5);
      this.\u0023\u003DzlKrIksuanhOXsyGcBC6ESt5KEFlZ((object) target);
      return true;
label_8:
      Monitor.Enter(obj2, ref local);
      goto label_7;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_4:
    obj1 = zlrX5m0o;
    goto label_3;
  }

  private sealed class \u0023\u003Dzv_DK75M\u003D
  {
    public byte[] \u0023\u003Dzv_DK75M\u003D;
    public bool \u0023\u003DzOsmxM1I\u003D;

    public \u0023\u003Dzv_DK75M\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public \u0023\u003Dzv_DK75M\u003D(byte[] _param1, int _param2, int _param3, bool _param4)
    {
      byte[] numArray = _param1;
      int num1 = _param2;
      int num2 = _param3;
      int num3 = _param4 ? 1 : 0;
      if (false)
        return;
      this.\u0023\u003DztNKGUAKxo2p50zXtfxaOKXK0zJ\u0024YRecN9y3g75M\u003D(numArray, num1, num2, num3 != 0);
    }

    public void \u0023\u003DztNKGUAKxo2p50zXtfxaOKXK0zJ\u0024YRecN9y3g75M\u003D(
      byte[] _param1,
      int _param2,
      int _param3,
      bool _param4)
    {
      byte[] numArray = new byte[_param3];
      if (true)
        goto label_4;
label_1:
      byte[] src = _param1;
      int srcOffset = _param2;
      byte[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
      int count = _param3;
      if (true)
        goto label_5;
label_2:
      int num = _param4 ? 1 : 0;
      if (false)
        return;
      this.\u0023\u003DzOsmxM1I\u003D = num != 0;
      return;
label_5:
      Buffer.BlockCopy((Array) src, srcOffset, (Array) zvDk75M, 0, count);
      goto label_2;
label_4:
      this.\u0023\u003Dzv_DK75M\u003D = numArray;
      goto label_1;
    }
  }
}
