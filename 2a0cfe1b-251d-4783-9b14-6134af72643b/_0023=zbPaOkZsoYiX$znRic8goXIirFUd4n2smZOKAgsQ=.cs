// Decompiled with JetBrains decompiler
// Type: #=zbPaOkZsoYiX$znRic8goXIirFUd4n2smZOKAgsQ=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System.Diagnostics;
using System.Runtime.InteropServices;

#nullable disable
internal sealed class \u0023\u003DzbPaOkZsoYiX\u0024znRic8goXIirFUd4n2smZOKAgsQ\u003D
{
  public \u0023\u003DzbPaOkZsoYiX\u0024znRic8goXIirFUd4n2smZOKAgsQ\u003D()
  {
    if (true)
      ;
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }

  internal static void \u0023\u003DzIcPTPIM\u003D(string _param0)
  {
    try
    {
      Process.Start(_param0);
    }
    catch
    {
      if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
      {
        string str = _param0.Replace(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622615), \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639406));
        if (true)
          goto label_4;
label_3:
        Process.Start(new ProcessStartInfo(_param0)
        {
          UseShellExecute = true
        });
        return;
label_4:
        _param0 = str;
        goto label_3;
      }
      if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        Process.Start(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639413), _param0);
      else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        Process.Start(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772639366), _param0);
      else
        throw;
    }
  }
}
