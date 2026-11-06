// Decompiled with JetBrains decompiler
// Type: #=zO3Hy635DYfpBgWirlqr4mc_dh0wz
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Windows.Input;

#nullable disable
public sealed class \u0023\u003DzO3Hy635DYfpBgWirlqr4mc_dh0wz : ICommand
{
  private Action \u0023\u003DzusqHGw0\u003D;
  private Func<bool> \u0023\u003DztUO3M9_Ti9lZ;

  public \u0023\u003DzO3Hy635DYfpBgWirlqr4mc_dh0wz(Action _param1, Func<bool> _param2)
  {
    Action action = _param1;
    if (true)
      goto label_3;
label_1:
    Func<bool> func = _param2;
    if (false)
      return;
    this.\u0023\u003DztUO3M9_Ti9lZ = func;
    return;
label_3:
    this.\u0023\u003DzusqHGw0\u003D = action;
    goto label_1;
  }

  public event EventHandler CanExecuteChanged
  {
    add
    {
      EventHandler eventHandler = value;
      if (false)
        return;
      CommandManager.RequerySuggested += eventHandler;
    }
    remove
    {
      EventHandler eventHandler = value;
      if (false)
        return;
      CommandManager.RequerySuggested -= eventHandler;
    }
  }

  public bool CanExecute(object _param1)
  {
    if (true)
      ;
    return this.\u0023\u003DztUO3M9_Ti9lZ();
  }

  public void Execute(object _param1)
  {
    if (true)
      ;
    this.\u0023\u003DzusqHGw0\u003D();
  }
}
