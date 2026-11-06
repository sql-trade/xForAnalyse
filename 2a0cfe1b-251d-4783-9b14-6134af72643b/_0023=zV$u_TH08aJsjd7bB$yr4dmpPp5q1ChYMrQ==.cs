// Decompiled with JetBrains decompiler
// Type: #=zV$u_TH08aJsjd7bB$yr4dmpPp5q1ChYMrQ==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal sealed class \u0023\u003DzV\u0024u_TH08aJsjd7bB\u0024yr4dmpPp5q1ChYMrQ\u003D\u003D : 
  IComparable<\u0023\u003DzV\u0024u_TH08aJsjd7bB\u0024yr4dmpPp5q1ChYMrQ\u003D\u003D>
{
  internal long \u0023\u003Dzrh0NNbo\u003D;
  internal long \u0023\u003DzkKIKaNA\u003D;
  internal int \u0023\u003Dz0wnXexsCbW8u;

  public \u0023\u003DzV\u0024u_TH08aJsjd7bB\u0024yr4dmpPp5q1ChYMrQ\u003D\u003D()
  {
    if (true)
      ;
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }

  public int CompareTo(
    \u0023\u003DzV\u0024u_TH08aJsjd7bB\u0024yr4dmpPp5q1ChYMrQ\u003D\u003D _param1)
  {
    if (true)
      ;
    long zrh0Nnbo1 = this.\u0023\u003Dzrh0NNbo\u003D;
    \u0023\u003DzV\u0024u_TH08aJsjd7bB\u0024yr4dmpPp5q1ChYMrQ\u003D\u003D yr4dmpPp5q1ChYmrQ = _param1;
    if (true)
      ;
    long zrh0Nnbo2 = yr4dmpPp5q1ChYmrQ.\u0023\u003Dzrh0NNbo\u003D;
    if (zrh0Nnbo1 < zrh0Nnbo2)
      return -1;
    if (true)
      ;
    return this.\u0023\u003Dzrh0NNbo\u003D > _param1.\u0023\u003Dzrh0NNbo\u003D ? 1 : 0;
  }

  public bool \u0023\u003DzygIQ0P0Jenh2()
  {
    if (true)
      ;
    return this.\u0023\u003Dz0wnXexsCbW8u == -1;
  }

  public static \u0023\u003DzV\u0024u_TH08aJsjd7bB\u0024yr4dmpPp5q1ChYMrQ\u003D\u003D \u0023\u003DzRuTZ5OE\u003D()
  {
    \u0023\u003DzV\u0024u_TH08aJsjd7bB\u0024yr4dmpPp5q1ChYMrQ\u003D\u003D yr4dmpPp5q1ChYmrQ = new \u0023\u003DzV\u0024u_TH08aJsjd7bB\u0024yr4dmpPp5q1ChYMrQ\u003D\u003D();
    if (true)
      goto label_4;
label_1:
    if (true)
      goto label_5;
label_2:
    if (false)
      return yr4dmpPp5q1ChYmrQ;
    yr4dmpPp5q1ChYmrQ.\u0023\u003Dz0wnXexsCbW8u = -1;
    return yr4dmpPp5q1ChYmrQ;
label_5:
    yr4dmpPp5q1ChYmrQ.\u0023\u003DzkKIKaNA\u003D = 0L;
    goto label_2;
label_4:
    yr4dmpPp5q1ChYmrQ.\u0023\u003Dzrh0NNbo\u003D = 0L;
    goto label_1;
  }
}
