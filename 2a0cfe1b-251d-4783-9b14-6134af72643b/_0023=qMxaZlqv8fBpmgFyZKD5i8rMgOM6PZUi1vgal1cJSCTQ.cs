// Decompiled with JetBrains decompiler
// Type: #=qMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

#nullable disable
internal sealed class \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D : 
  \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D,
  IDisposable
{
  private readonly \u0023\u003DqoXlT6ptOyrPv2V8A_bJBFLKBErmbu7Q\u0024jhyg\u0024gjssfM\u003D \u0023\u003Dzv_DK75M\u003D;
  private readonly bool \u0023\u003DzOsmxM1I\u003D;
  private readonly bool \u0023\u003DzAElFq6M\u003D;
  private readonly int \u0023\u003DzhBh6D88\u003D;
  private readonly int \u0023\u003DzsIRkzxg\u003D;
  private \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003Dzv_DK75M\u003D \u0023\u003DzQvRsjjA\u003D;
  private bool \u0023\u003DzlrX5m0o\u003D;
  private readonly object \u0023\u003DzDnwpn_c\u003D;

  public \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D(
    bool _param1,
    \u0023\u003DqoXlT6ptOyrPv2V8A_bJBFLKBErmbu7Q\u0024jhyg\u0024gjssfM\u003D _param2,
    bool _param3 = false)
  {
    object obj = new object();
    if (true)
      goto label_4;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    int num1 = _param1 ? 1 : 0;
    if (true)
      goto label_5;
label_2:
    \u0023\u003DqoXlT6ptOyrPv2V8A_bJBFLKBErmbu7Q\u0024jhyg\u0024gjssfM\u003D ermbu7QJhygGjssfM = _param2;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzAElFq6M\u003D = _param3;
    this.\u0023\u003DzAElFq6M\u003D = true;
    int num2 = _param2.\u0023\u003DzY1IT_eeVzLJDY1EvC1mBzNO0L8Nt6fdqSLYR84A\u003D().\u0023\u003DzAjJbjbfVsnq4ZrdywTuyL9vODPi5();
    this.\u0023\u003DzhBh6D88\u003D = \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003DzmWoHvUi\u0024ezv00CSkOvB8Wm021NhOu1VWaAzVu3Q\u003D(num2, _param1);
    this.\u0023\u003DzsIRkzxg\u003D = \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003DzUEBvYJA_56RARdaomkGLq4w\u003D(num2, _param1);
    return;
label_6:
    this.\u0023\u003Dzv_DK75M\u003D = ermbu7QJhygGjssfM;
    goto label_3;
label_5:
    this.\u0023\u003DzOsmxM1I\u003D = num1 != 0;
    goto label_2;
label_4:
    this.\u0023\u003DzDnwpn_c\u003D = obj;
    goto label_1;
  }

  public bool \u0023\u003DzyVXFEBxLfXY6pdkUOUUG_Pww66hKya_jDpGGunJZXjSu()
  {
    if (true)
      ;
    return this.\u0023\u003DzOsmxM1I\u003D;
  }

  [CompilerGenerated]
  [SpecialName]
  public int \u0023\u003Dz9nPncFm3EG2SxfRwi9oRRCfjr3F03Hf3atqy30osRUxhEaHgDxg5d5wFx4Pf0c3LllaiJl6sUDfjWZqxrQ\u003D\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzhBh6D88\u003D;
  }

  [CompilerGenerated]
  [SpecialName]
  public int \u0023\u003DzyWFI3vSTNmOhc14Xyi1erNdl2kN0y6Px5NBgvJtAFTpmpTrw4hH9aHQTyyz0MFI25KVkC\u0024c\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzsIRkzxg\u003D;
  }

  private static int \u0023\u003DzmWoHvUi\u0024ezv00CSkOvB8Wm021NhOu1VWaAzVu3Q\u003D(
    int _param0,
    bool _param1)
  {
    int num1 = _param1 ? 1 : 0;
    if (true)
      ;
    if (num1 == 0)
    {
      int num2 = _param0;
      if (true)
        ;
      return (num2 + 7) / 8;
    }
    int num3 = _param0;
    if (true)
      ;
    return (num3 - 1) / 8;
  }

  private static int \u0023\u003DzUEBvYJA_56RARdaomkGLq4w\u003D(int _param0, bool _param1)
  {
    int num1 = _param1 ? 1 : 0;
    if (true)
      ;
    if (num1 == 0)
    {
      int num2 = _param0;
      if (true)
        ;
      return (num2 - 1) / 8;
    }
    int num3 = _param0;
    if (true)
      ;
    return (num3 + 7) / 8;
  }

  public int \u0023\u003DzMcp1j9HeFzOJtlfrJ79aMlkKYXTeLciLbkTjBenGOAT6pOmq6v8B9K\u00240TJVdV_I5Pj8GRwllj5snhj4t9wnEJZM\u003D(
    byte[] _param1,
    int _param2,
    int _param3,
    byte[] _param4,
    int _param5,
    RandomNumberGenerator _param6)
  {
    if (true)
      goto label_2;
label_1:
    \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003Dzv_DK75M\u003D zQvRsjjA = this.\u0023\u003DzQvRsjjA\u003D;
    \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003Dzv_DK75M\u003D zvDk75M;
    if (true)
      zvDk75M = zQvRsjjA;
    int num1;
    try
    {
      int num2 = zvDk75M.\u0023\u003DzOsmxM1I\u003D.\u0023\u003DzMcp1j9HeFzOJtlfrJ79aMlkKYXTeLciLbkTjBenGOAT6pOmq6v8B9K\u00240TJVdV_I5Pj8GRwllj5snhj4t9wnEJZM\u003D(_param1, _param2, _param3, _param4, _param5, _param6);
      if (true)
        num1 = num2;
    }
    catch (Exception ex) when (zvDk75M.\u0023\u003Dzv_DK75M\u003D)
    {
      this.\u0023\u003DzLnNB7zMNduDSC8V1WkzuNzw\u003D();
      num1 = this.\u0023\u003DzQvRsjjA\u003D.\u0023\u003DzOsmxM1I\u003D.\u0023\u003DzMcp1j9HeFzOJtlfrJ79aMlkKYXTeLciLbkTjBenGOAT6pOmq6v8B9K\u00240TJVdV_I5Pj8GRwllj5snhj4t9wnEJZM\u003D(_param1, _param2, _param3, _param4, _param5, _param6);
    }
    return num1;
label_2:
    this.\u0023\u003Dzp_Ru6RWsUx362DUxfmIzIbLs\u0024vtT();
    goto label_1;
  }

  private void \u0023\u003DzLnNB7zMNduDSC8V1WkzuNzw\u003D()
  {
    object zDnwpnC = this.\u0023\u003DzDnwpn_c\u003D;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003Dzv_DK75M\u003D zQvRsjjA = this.\u0023\u003DzQvRsjjA\u003D;
      if (!zQvRsjjA.\u0023\u003Dzv_DK75M\u003D)
        return;
      try
      {
        if (zQvRsjjA.\u0023\u003DzOsmxM1I\u003D is IDisposable zOsmxM1I)
          zOsmxM1I.Dispose();
      }
      catch
      {
      }
      this.\u0023\u003DzQvRsjjA\u003D = new \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003Dzv_DK75M\u003D()
      {
        \u0023\u003Dzv_DK75M\u003D = false,
        \u0023\u003DzOsmxM1I\u003D = this.\u0023\u003DzbQCfadXktCqnZeIz1tuRQN2siU4x0WEPsqQ4p7p7FIRaYdFt_r\u0024kBSJiGmseO_wppgLSvzlD5xqglGXyjCtvV6g\u003D(this.\u0023\u003DzOsmxM1I\u003D, this.\u0023\u003Dzv_DK75M\u003D) ?? throw new InvalidOperationException()
      };
      return;
label_6:
      Monitor.Enter(obj2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_2:
    obj1 = zDnwpnC;
    goto label_1;
  }

  private void \u0023\u003Dzp_Ru6RWsUx362DUxfmIzIbLs\u0024vtT()
  {
    if (this.\u0023\u003DzlrX5m0o\u003D)
      return;
    object zDnwpnC = this.\u0023\u003DzDnwpn_c\u003D;
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
      if (this.\u0023\u003DzlrX5m0o\u003D)
        return;
      \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D ag11ryi4o2Vum3dp7WbJp8U;
      if (!this.\u0023\u003DzAElFq6M\u003D && (ag11ryi4o2Vum3dp7WbJp8U = this.\u0023\u003DzGbRyFg2JEXbBn3iY80uxXvze2aISsznHf_cYG12tHIoPYwJ1MwjOmOVklwoCPvtA7A3PONele8EJ188AjlAAU8E38OeB(this.\u0023\u003DzOsmxM1I\u003D, this.\u0023\u003Dzv_DK75M\u003D)) != null)
        this.\u0023\u003DzQvRsjjA\u003D = new \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003Dzv_DK75M\u003D()
        {
          \u0023\u003Dzv_DK75M\u003D = true,
          \u0023\u003DzOsmxM1I\u003D = ag11ryi4o2Vum3dp7WbJp8U
        };
      else
        this.\u0023\u003DzQvRsjjA\u003D = new \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003Dzv_DK75M\u003D()
        {
          \u0023\u003Dzv_DK75M\u003D = false,
          \u0023\u003DzOsmxM1I\u003D = this.\u0023\u003DzbQCfadXktCqnZeIz1tuRQN2siU4x0WEPsqQ4p7p7FIRaYdFt_r\u0024kBSJiGmseO_wppgLSvzlD5xqglGXyjCtvV6g\u003D(this.\u0023\u003DzOsmxM1I\u003D, this.\u0023\u003Dzv_DK75M\u003D) ?? throw new InvalidOperationException()
        };
      this.\u0023\u003DzlrX5m0o\u003D = true;
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
    obj1 = zDnwpnC;
    goto label_2;
  }

  protected virtual \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D \u0023\u003DzbQCfadXktCqnZeIz1tuRQN2siU4x0WEPsqQ4p7p7FIRaYdFt_r\u0024kBSJiGmseO_wppgLSvzlD5xqglGXyjCtvV6g\u003D(
    bool _param1,
    \u0023\u003DqoXlT6ptOyrPv2V8A_bJBFLKBErmbu7Q\u0024jhyg\u0024gjssfM\u003D _param2)
  {
    int num = _param1 ? 1 : 0;
    if (true)
      ;
    \u0023\u003DqoXlT6ptOyrPv2V8A_bJBFLKBErmbu7Q\u0024jhyg\u0024gjssfM\u003D ermbu7QJhygGjssfM = _param2;
    if (true)
      ;
    return (\u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D) new \u0023\u003DqJVEWyF\u0024ph3NDm9HEm4qFW463ojr2Yn1qyj5eHkZNEHw\u003D(num != 0, ermbu7QJhygGjssfM);
  }

  protected virtual \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D \u0023\u003DzGbRyFg2JEXbBn3iY80uxXvze2aISsznHf_cYG12tHIoPYwJ1MwjOmOVklwoCPvtA7A3PONele8EJ188AjlAAU8E38OeB(
    bool _param1,
    \u0023\u003DqoXlT6ptOyrPv2V8A_bJBFLKBErmbu7Q\u0024jhyg\u0024gjssfM\u003D _param2)
  {
    int num = _param1 ? 1 : 0;
    if (true)
      ;
    \u0023\u003DqoXlT6ptOyrPv2V8A_bJBFLKBErmbu7Q\u0024jhyg\u0024gjssfM\u003D ermbu7QJhygGjssfM = _param2;
    if (true)
      ;
    return (\u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D) \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShEJpCB8Y6H_Jfqd55jD8NC0\u003D.\u0023\u003DzXwNGnq5YaMQuALJAj678IXVhnlSdrrRDKTp73YE\u003D(num != 0, ermbu7QJhygGjssfM);
  }

  public void Dispose()
  {
    IDisposable zOsmxM1I = this.\u0023\u003DzQvRsjjA\u003D?.\u0023\u003DzOsmxM1I\u003D as IDisposable;
    if (true)
      goto label_3;
label_1:
    IDisposable disposable;
    if (disposable == null)
      return;
    disposable.Dispose();
    if (false)
      return;
    this.\u0023\u003DzQvRsjjA\u003D = (\u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D.\u0023\u003Dzv_DK75M\u003D) null;
    return;
label_3:
    disposable = zOsmxM1I;
    goto label_1;
  }

  private sealed class \u0023\u003Dzv_DK75M\u003D
  {
    public bool \u0023\u003Dzv_DK75M\u003D;
    public \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D \u0023\u003DzOsmxM1I\u003D;

    public \u0023\u003Dzv_DK75M\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
