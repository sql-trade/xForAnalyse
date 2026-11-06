// Decompiled with JetBrains decompiler
// Type: #=q5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
internal static class \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D
{
  private static readonly bool \u0023\u003Dzv_DK75M\u003D;
  private static readonly bool \u0023\u003DzOsmxM1I\u003D;

  static \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D()
  {
    OperatingSystem osVersion = Environment.OSVersion;
    if (true)
      goto label_2;
label_1:
    OperatingSystem operatingSystem;
    int num1 = operatingSystem.Platform != 2 ? 0 : (operatingSystem.Version >= new Version(6, 0) ? 1 : 0);
    if (true)
      goto label_4;
label_3:
    if (!\u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D.\u0023\u003DzuoKMpbxuMKq6FfPl1gNcLuzss2VNzCdXUWZklUxP4mH7())
      return;
    try
    {
      int num2 = \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D.\u0023\u003DzZLuxNRTFydgatkNotYUY0MA\u003D(operatingSystem) ? 1 : 0;
      if (false)
        return;
      \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D.\u0023\u003DzOsmxM1I\u003D = num2 != 0;
      return;
    }
    catch
    {
      \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D.\u0023\u003DzOsmxM1I\u003D = false;
      return;
    }
label_4:
    \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D.\u0023\u003Dzv_DK75M\u003D = num1 != 0;
    goto label_3;
label_2:
    operatingSystem = osVersion;
    goto label_1;
  }

  public static bool \u0023\u003DzuoKMpbxuMKq6FfPl1gNcLuzss2VNzCdXUWZklUxP4mH7()
  {
    return \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D.\u0023\u003Dzv_DK75M\u003D;
  }

  public static bool \u0023\u003DzORHhh_R5LODx25aYvewklXXPjYRVvJ_DxldCtiA\u003D()
  {
    return \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9RDqeRsjXNCITX7UWi5zZ1E\u003D.\u0023\u003DzOsmxM1I\u003D;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool \u0023\u003DzZLuxNRTFydgatkNotYUY0MA\u003D(OperatingSystem _param0)
  {
    OperatingSystem operatingSystem1 = _param0;
    if (true)
      ;
    if (operatingSystem1.Platform == 2)
    {
      OperatingSystem operatingSystem2 = _param0;
      if (true)
        ;
      if (operatingSystem2.Version < new Version(6, 2, 9200) && Process.GetCurrentProcess().SessionId == 0)
        return false;
    }
    return true;
  }
}
