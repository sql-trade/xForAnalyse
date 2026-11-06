// Decompiled with JetBrains decompiler
// Type: #=qOKic1dIva_mXQIeeW0N6cngkbUYGKzZKSAvdqBjrQlk=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

#nullable disable
internal sealed class \u0023\u003DqOKic1dIva_mXQIeeW0N6cngkbUYGKzZKSAvdqBjrQlk\u003D : 
  \u0023\u003Dqa3\u0024M2r29rJJmkWg\u0024S4IU1GNRt7p6rEShFlpDkHlfaJw\u003D,
  IDisposable
{
  private SecureString \u0023\u003Dzv_DK75M\u003D;

  public \u0023\u003DqOKic1dIva_mXQIeeW0N6cngkbUYGKzZKSAvdqBjrQlk\u003D()
  {
    SecureString secureString = new SecureString();
    if (true)
      goto label_2;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_2:
    this.\u0023\u003Dzv_DK75M\u003D = secureString;
    goto label_1;
  }

  [SpecialName]
  public int \u0023\u003DzD3wqiur66yePsI5LXrfF6wbzvqSVfO03BLVhryH6irfF_1ER0cZBYy1GHn3w0x8j5EHyW1v2Tw\u0024MS7qe53eh8QYyGHnc()
  {
    if (true)
      ;
    return this.\u0023\u003Dzv_DK75M\u003D.Length;
  }

  public \u0023\u003Dqa3\u0024M2r29rJJmkWg\u0024S4IU1GNRt7p6rEShFlpDkHlfaJw\u003D \u0023\u003DzMf0vp\u0024NNn_Jn9nL9qMnYmfHqaM6W\u0024sJSypJcMxdTbcBQZaLEsx4_4WAWUutN23QwFP15A5tjCohDgAAyTw\u003D\u003D()
  {
    return (\u0023\u003Dqa3\u0024M2r29rJJmkWg\u0024S4IU1GNRt7p6rEShFlpDkHlfaJw\u003D) new \u0023\u003DqOKic1dIva_mXQIeeW0N6cngkbUYGKzZKSAvdqBjrQlk\u003D();
  }

  public void \u0023\u003DzrRwyRoSV2Fmoi7TvlFJaJEUTctpGWWjeoRfjZHcyTTq0nwC4iCHjKzegaPgcWiPkpaSD2rV2577E(
    int _param1,
    out byte _param2)
  {
    if (_param1 < 0 || _param1 >= this.\u0023\u003DzD3wqiur66yePsI5LXrfF6wbzvqSVfO03BLVhryH6irfF_1ER0cZBYy1GHn3w0x8j5EHyW1v2Tw\u0024MS7qe53eh8QYyGHnc())
      throw new ArgumentOutOfRangeException();
    IntPtr zero = IntPtr.Zero;
    if (true)
      goto label_4;
label_3:
    char ch;
    if (true)
      ch = char.MinValue;
    IntPtr num;
    try
    {
      IntPtr globalAllocUnicode = Marshal.SecureStringToGlobalAllocUnicode(this.\u0023\u003Dzv_DK75M\u003D);
      if (true)
        goto label_8;
label_7:
      ch = (char) Marshal.ReadInt16(num, _param1 * 2);
      _param2 = \u0023\u003DqOKic1dIva_mXQIeeW0N6cngkbUYGKzZKSAvdqBjrQlk\u003D.\u0023\u003DzQwHNM3ya6PWEeQ0uZ2YjwS915O91hxx62g\u003D\u003D(ch, _param1);
      return;
label_8:
      num = globalAllocUnicode;
      goto label_7;
    }
    finally
    {
      \u0023\u003DqtQ_N8FE87Hwb70J\u00247SYyhh7fP9fObE_mRNanx7UPjbY\u003D.\u0023\u003DzonWiLKqkaT77vJjmHKnUZP\u0024d_nIYOEcYEJZVbzU\u003D(ref ch);
      if (num != IntPtr.Zero)
        Marshal.ZeroFreeGlobalAllocUnicode(num);
    }
label_4:
    num = zero;
    goto label_3;
  }

  public void \u0023\u003DzBm660h32VqCqwtwwIun06\u0024ONT\u0024\u0024q_wdPa4yt_Uvm2LG\u0024SrQPMzVzuTXHV\u002459Ahpo3paa2TonrxYUOc\u0024oNyFo5tY\u003D(
    int _param1,
    ref byte _param2)
  {
    int length = this.\u0023\u003Dzv_DK75M\u003D.Length;
    int num1;
    if (true)
      num1 = length;
    while (num1 <= _param1)
    {
      if (num1 == _param1)
      {
        this.\u0023\u003Dzv_DK75M\u003D.AppendChar(\u0023\u003DqOKic1dIva_mXQIeeW0N6cngkbUYGKzZKSAvdqBjrQlk\u003D.\u0023\u003Dz\u0024h4h4XXh6RrlrQOp4qZOq\u0024O0BCo1Yj2t7nXRKfq4k1ah(_param2, num1));
        return;
      }
      this.\u0023\u003Dzv_DK75M\u003D.AppendChar(\u0023\u003DqOKic1dIva_mXQIeeW0N6cngkbUYGKzZKSAvdqBjrQlk\u003D.\u0023\u003Dz\u0024h4h4XXh6RrlrQOp4qZOq\u0024O0BCo1Yj2t7nXRKfq4k1ah((byte) 0, num1));
      int num2 = num1 + 1;
      if (true)
        num1 = num2;
    }
    this.\u0023\u003Dzv_DK75M\u003D.SetAt(_param1, \u0023\u003DqOKic1dIva_mXQIeeW0N6cngkbUYGKzZKSAvdqBjrQlk\u003D.\u0023\u003Dz\u0024h4h4XXh6RrlrQOp4qZOq\u0024O0BCo1Yj2t7nXRKfq4k1ah(_param2, _param1));
  }

  private static char \u0023\u003Dz\u0024h4h4XXh6RrlrQOp4qZOq\u0024O0BCo1Yj2t7nXRKfq4k1ah(
    byte _param0,
    int _param1)
  {
    int num = (int) _param0;
    if (true)
      ;
    return (char) (num + 1);
  }

  private static byte \u0023\u003DzQwHNM3ya6PWEeQ0uZ2YjwS915O91hxx62g\u003D\u003D(
    char _param0,
    int _param1)
  {
    int num = (int) _param0;
    if (true)
      ;
    return (byte) (num - 1);
  }

  public void \u0023\u003Dzmcvk\u00243gporyrCXVJ1g7Upt5nYXAOauQWfTR\u0024\u0024\u00244hw6EVDgNuwpkbL9EUq2rfi8hkniViu_0\u003D()
  {
    if (true)
      ;
    this.\u0023\u003Dzv_DK75M\u003D.Clear();
  }

  public void Dispose()
  {
    this.\u0023\u003Dzv_DK75M\u003D.Dispose();
    if (false)
      return;
    this.\u0023\u003Dzv_DK75M\u003D = (SecureString) null;
  }
}
