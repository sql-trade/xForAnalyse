// Decompiled with JetBrains decompiler
// Type: #=qzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Security.Cryptography;

#nullable disable
internal sealed class \u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D : DeriveBytes
{
  private static volatile bool \u0023\u003Dzv_DK75M\u003D;
  private DeriveBytes \u0023\u003DzOsmxM1I\u003D;
  private readonly byte[] \u0023\u003DzAElFq6M\u003D;
  private readonly byte[] \u0023\u003DzhBh6D88\u003D;
  private readonly int \u0023\u003DzsIRkzxg\u003D;

  public \u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D(
    byte[] _param1,
    byte[] _param2,
    int _param3)
  {
    byte[] numArray1 = _param1;
    if (true)
      goto label_5;
label_1:
    byte[] numArray2 = _param2;
    if (true)
      goto label_6;
label_2:
    int num = _param3;
    if (true)
      goto label_7;
label_3:
    if (!\u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D.\u0023\u003Dzv_DK75M\u003D)
    {
      try
      {
        this.\u0023\u003DzOsmxM1I\u003D = (DeriveBytes) new Rfc2898DeriveBytes(_param1, _param2, _param3);
      }
      catch
      {
        \u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D.\u0023\u003Dzv_DK75M\u003D = true;
      }
    }
    if (this.\u0023\u003DzOsmxM1I\u003D != null)
      return;
    this.\u0023\u003DzOsmxM1I\u003D = (DeriveBytes) new \u0023\u003DqWXiM5IgM4IB0l6guG5SIS47oMmxD9T4jAexYk5zwE6Q\u003D(_param1, _param2, _param3);
    return;
label_7:
    this.\u0023\u003DzsIRkzxg\u003D = num;
    goto label_3;
label_6:
    this.\u0023\u003DzhBh6D88\u003D = numArray2;
    goto label_2;
label_5:
    this.\u0023\u003DzAElFq6M\u003D = numArray1;
    goto label_1;
  }

  public override byte[] GetBytes(int _param1)
  {
    if (true)
      goto label_2;
label_1:
    byte[] bytes1;
    if (!\u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D.\u0023\u003Dzv_DK75M\u003D)
    {
      try
      {
        byte[] bytes2 = this.\u0023\u003DzOsmxM1I\u003D.GetBytes(_param1);
        if (true)
          bytes1 = bytes2;
      }
      catch
      {
        \u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D.\u0023\u003Dzv_DK75M\u003D = true;
      }
    }
    if (bytes1 == null)
    {
      \u0023\u003DqWXiM5IgM4IB0l6guG5SIS47oMmxD9T4jAexYk5zwE6Q\u003D d9T4jAexYk5zwE6Q = new \u0023\u003DqWXiM5IgM4IB0l6guG5SIS47oMmxD9T4jAexYk5zwE6Q\u003D(this.\u0023\u003DzAElFq6M\u003D, this.\u0023\u003DzhBh6D88\u003D, this.\u0023\u003DzsIRkzxg\u003D);
      if (true)
        goto label_9;
label_8:
      bytes1 = this.\u0023\u003DzOsmxM1I\u003D.GetBytes(_param1);
      goto label_10;
label_9:
      this.\u0023\u003DzOsmxM1I\u003D = (DeriveBytes) d9T4jAexYk5zwE6Q;
      goto label_8;
    }
label_10:
    return bytes1;
label_2:
    bytes1 = (byte[]) null;
    goto label_1;
  }

  public override void Reset() => throw new NotSupportedException();
}
