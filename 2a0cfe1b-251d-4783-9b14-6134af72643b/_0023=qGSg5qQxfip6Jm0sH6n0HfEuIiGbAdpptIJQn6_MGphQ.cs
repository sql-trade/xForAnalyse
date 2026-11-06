// Decompiled with JetBrains decompiler
// Type: #=qGSg5qQxfip6Jm0sH6n0HfEuIiGbAdpptIJQn6_MGphQ=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
internal sealed class \u0023\u003DqGSg5qQxfip6Jm0sH6n0HfEuIiGbAdpptIJQn6_MGphQ\u003D : 
  \u0023\u003Dqa3\u0024M2r29rJJmkWg\u0024S4IU1GNRt7p6rEShFlpDkHlfaJw\u003D,
  IDisposable
{
  private List<byte> \u0023\u003Dzv_DK75M\u003D;

  public \u0023\u003DqGSg5qQxfip6Jm0sH6n0HfEuIiGbAdpptIJQn6_MGphQ\u003D()
  {
    List<byte> byteList = new List<byte>();
    if (true)
      goto label_2;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_2:
    this.\u0023\u003Dzv_DK75M\u003D = byteList;
    goto label_1;
  }

  [SpecialName]
  public int \u0023\u003DzD3wqiur66yePsI5LXrfF6wbzvqSVfO03BLVhryH6irfF_1ER0cZBYy1GHn3w0x8j5EHyW1v2Tw\u0024MS7qe53eh8QYyGHnc()
  {
    if (true)
      ;
    return this.\u0023\u003Dzv_DK75M\u003D.Count;
  }

  public void \u0023\u003Dzmcvk\u00243gporyrCXVJ1g7Upt5nYXAOauQWfTR\u0024\u0024\u00244hw6EVDgNuwpkbL9EUq2rfi8hkniViu_0\u003D()
  {
    if (true)
      ;
    this.\u0023\u003Dzv_DK75M\u003D.Clear();
  }

  public \u0023\u003Dqa3\u0024M2r29rJJmkWg\u0024S4IU1GNRt7p6rEShFlpDkHlfaJw\u003D \u0023\u003DzMf0vp\u0024NNn_Jn9nL9qMnYmfHqaM6W\u0024sJSypJcMxdTbcBQZaLEsx4_4WAWUutN23QwFP15A5tjCohDgAAyTw\u003D\u003D()
  {
    return (\u0023\u003Dqa3\u0024M2r29rJJmkWg\u0024S4IU1GNRt7p6rEShFlpDkHlfaJw\u003D) new \u0023\u003DqGSg5qQxfip6Jm0sH6n0HfEuIiGbAdpptIJQn6_MGphQ\u003D();
  }

  public void Dispose()
  {
    if (true)
      goto label_3;
label_1:
    if (false)
      return;
    this.\u0023\u003Dzv_DK75M\u003D = (List<byte>) null;
    return;
label_3:
    this.\u0023\u003Dzmcvk\u00243gporyrCXVJ1g7Upt5nYXAOauQWfTR\u0024\u0024\u00244hw6EVDgNuwpkbL9EUq2rfi8hkniViu_0\u003D();
    goto label_1;
  }

  public void \u0023\u003DzrRwyRoSV2Fmoi7TvlFJaJEUTctpGWWjeoRfjZHcyTTq0nwC4iCHjKzegaPgcWiPkpaSD2rV2577E(
    int _param1,
    out byte _param2)
  {
    ref byte local = ref _param2;
    if (true)
      ;
    if (true)
      ;
    if (true)
      ;
    int num = (int) this.\u0023\u003Dz4vwsPNoEkOHvEUhiiPv7KrMdiak19yGPsraWLUk\u003D(this.\u0023\u003Dzv_DK75M\u003D[_param1], _param1);
    local = (byte) num;
  }

  public void \u0023\u003DzBm660h32VqCqwtwwIun06\u0024ONT\u0024\u0024q_wdPa4yt_Uvm2LG\u0024SrQPMzVzuTXHV\u002459Ahpo3paa2TonrxYUOc\u0024oNyFo5tY\u003D(
    int _param1,
    ref byte _param2)
  {
    int count = this.\u0023\u003Dzv_DK75M\u003D.Count;
    int num1;
    if (true)
      num1 = count;
    while (num1 <= _param1)
    {
      if (num1 == _param1)
      {
        this.\u0023\u003Dzv_DK75M\u003D.Add(this.\u0023\u003DzUsFlMo87YgoNL6w9yOSTTGu7l2k5_h6sCflDerh2tDZA(_param2, num1));
        return;
      }
      this.\u0023\u003Dzv_DK75M\u003D.Add(this.\u0023\u003DzUsFlMo87YgoNL6w9yOSTTGu7l2k5_h6sCflDerh2tDZA((byte) 0, num1));
      int num2 = num1 + 1;
      if (true)
        num1 = num2;
    }
    this.\u0023\u003Dzv_DK75M\u003D[_param1] = this.\u0023\u003DzUsFlMo87YgoNL6w9yOSTTGu7l2k5_h6sCflDerh2tDZA(_param2, _param1);
  }

  private byte \u0023\u003Dz4vwsPNoEkOHvEUhiiPv7KrMdiak19yGPsraWLUk\u003D(byte _param1, int _param2)
  {
    throw new NotImplementedException();
  }

  private byte \u0023\u003DzUsFlMo87YgoNL6w9yOSTTGu7l2k5_h6sCflDerh2tDZA(byte _param1, int _param2)
  {
    throw new NotImplementedException();
  }
}
