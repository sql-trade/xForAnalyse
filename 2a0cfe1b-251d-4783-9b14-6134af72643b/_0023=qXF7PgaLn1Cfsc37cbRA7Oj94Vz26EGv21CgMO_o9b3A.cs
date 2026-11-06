// Decompiled with JetBrains decompiler
// Type: #=qXF7PgaLn1Cfsc37cbRA7Oj94Vz26EGv21CgMO_o9b3A=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

#nullable disable
internal static class \u0023\u003DqXF7PgaLn1Cfsc37cbRA7Oj94Vz26EGv21CgMO_o9b3A\u003D
{
  public static bool \u0023\u003DzM4LOvHgfWCsqQz728bvVjemBOZ_e(int[] _param0, int[] _param1)
  {
    if (_param0 == _param1)
      return true;
    if (_param0 == null || _param1 == null || _param0.Length != _param1.Length)
      return false;
    int index;
    if (true)
      index = 0;
    while (index < _param0.Length)
    {
      if (_param0[index] != _param1[index])
        return false;
      int num = index + 1;
      if (true)
        index = num;
    }
    return true;
  }
}
