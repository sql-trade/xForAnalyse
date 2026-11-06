// Decompiled with JetBrains decompiler
// Type: #=qzho0MGHqMTqniG2LFw5Plfk700q0Y$RZWtkXcjU3Grk=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

#nullable disable
internal struct \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D
{
  private int \u0023\u003Dzv_DK75M\u003D;
  private readonly byte \u0023\u003DzOsmxM1I\u003D;

  public \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D(
    int _param1,
    byte _param2)
  {
    int num1 = _param1;
    if (true)
      goto label_3;
label_1:
    int num2 = (int) _param2;
    if (false)
      return;
    this.\u0023\u003DzOsmxM1I\u003D = (byte) num2;
    return;
label_3:
    this.\u0023\u003DzB11JJulodYJlYfWQ3rjqHjhNlsbE(num1);
    goto label_1;
  }

  public readonly int \u0023\u003DzGNCfRzfWOWBOof9OvPdgTKIQ77_BEj\u0024da8pRIZFOVuYQ()
  {
    if (true)
      ;
    return this.\u0023\u003Dzv_DK75M\u003D;
  }

  public void \u0023\u003DzB11JJulodYJlYfWQ3rjqHjhNlsbE(int _param1)
  {
    int num = _param1;
    if (false)
      return;
    this.\u0023\u003Dzv_DK75M\u003D = num;
  }

  public readonly byte \u0023\u003DzKRaVoy_TONJlAwY2C0ThGEvemKrQMpBufgGk9YYxK7kT()
  {
    if (true)
      ;
    return this.\u0023\u003DzOsmxM1I\u003D;
  }

  public override bool Equals(object _param1)
  {
    if (!(_param1 is \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D plfk700q0YRzWtkXcjU3Grk))
      return false;
    if (true)
      ;
    return this.\u0023\u003Dz4q1IPueGhJse0Y44a7mjPHg\u003D(plfk700q0YRzWtkXcjU3Grk);
  }

  public bool \u0023\u003Dz4q1IPueGhJse0Y44a7mjPHg\u003D(
    \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D _param1)
  {
    int num1 = _param1.\u0023\u003DzGNCfRzfWOWBOof9OvPdgTKIQ77_BEj\u0024da8pRIZFOVuYQ();
    if (true)
      ;
    int num2 = this.\u0023\u003DzGNCfRzfWOWBOof9OvPdgTKIQ77_BEj\u0024da8pRIZFOVuYQ();
    return num1 == num2;
  }

  public static bool operator ==(
    \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D _param0,
    \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D _param1)
  {
    ref \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D local = ref _param0;
    \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D plfk700q0YRzWtkXcjU3Grk = _param1;
    if (true)
      ;
    return local.\u0023\u003Dz4q1IPueGhJse0Y44a7mjPHg\u003D(plfk700q0YRzWtkXcjU3Grk);
  }

  public static bool operator !=(
    \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D _param0,
    \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D _param1)
  {
    \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D plfk700q0YRzWtkXcjU3Grk1 = _param0;
    if (true)
      ;
    \u0023\u003Dqzho0MGHqMTqniG2LFw5Plfk700q0Y\u0024RZWtkXcjU3Grk\u003D plfk700q0YRzWtkXcjU3Grk2 = _param1;
    if (true)
      ;
    return !(plfk700q0YRzWtkXcjU3Grk1 == plfk700q0YRzWtkXcjU3Grk2);
  }

  public override int GetHashCode()
  {
    int num1 = this.\u0023\u003DzGNCfRzfWOWBOof9OvPdgTKIQ77_BEj\u0024da8pRIZFOVuYQ();
    if (true)
      goto label_2;
label_1:
    int num2;
    return num2.GetHashCode();
label_2:
    num2 = num1;
    goto label_1;
  }

  public override string ToString()
  {
    int num1 = this.\u0023\u003DzGNCfRzfWOWBOof9OvPdgTKIQ77_BEj\u0024da8pRIZFOVuYQ();
    if (true)
      goto label_2;
label_1:
    int num2;
    return num2.ToString();
label_2:
    num2 = num1;
    goto label_1;
  }
}
