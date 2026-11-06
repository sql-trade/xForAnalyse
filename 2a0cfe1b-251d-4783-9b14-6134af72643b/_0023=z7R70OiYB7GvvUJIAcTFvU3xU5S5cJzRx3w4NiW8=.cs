// Decompiled with JetBrains decompiler
// Type: #=z7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

#nullable enable
internal sealed class \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D
{
  private readonly 
  #nullable disable
  string \u0023\u003DzcNyio6M\u003D;
  private readonly string \u0023\u003DzuLUKjqI\u003D;
  private readonly HttpClient \u0023\u003DzMlKPqFM\u003D;

  public \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D()
  {
    ref readonly string local1 = ref this.\u0023\u003DzcNyio6M\u003D;
    ref readonly string local2 = ref this.\u0023\u003DzuLUKjqI\u003D;
    ref readonly HttpClient local3 = ref this.\u0023\u003DzMlKPqFM\u003D;
    if (true)
      goto label_2;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_2:
    \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D.\u002Ector_1(ref local1, ref local2, ref local3);
    goto label_1;
  }

  public Task<\u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D> \u0023\u003DzD0boGkATCUZN(
    string _param1,
    string _param2,
    string _param3,
    string _param4)
  {
    object[] objArray1 = new object[5];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    objArray2[1] = (object) _param1;
    objArray2[2] = (object) _param2;
    objArray2[3] = (object) _param3;
    objArray2[4] = (object) _param4;
    return (Task<\u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D>) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "m:g<NCi+&:", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private \u0023\u003Dzxg5lHORfHMwe_mFckdRAxnwrYtp2LqPoY8M0k5w\u003D \u0023\u003DzdEq9ltVXEIfVQQeeqw\u003D\u003D(
    string _param1)
  {
    object[] objArray1 = new object[2];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    objArray2[1] = (object) _param1;
    return (\u0023\u003Dzxg5lHORfHMwe_mFckdRAxnwrYtp2LqPoY8M0k5w\u003D) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "8SMpTCi+&b", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private static HttpClient \u0023\u003DzGjIajo8Habm8()
  {
    return (HttpClient) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "6tpCOCi+'8", (object[]) null);
  }

  private static bool \u0023\u003DzrCPUFhEtx21l(
    HttpRequestMessage _param0,
    X509Certificate2 _param1,
    X509Chain _param2,
    SslPolicyErrors _param3)
  {
    object[] objArray1 = new object[4];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) _param0;
    objArray2[1] = (object) _param1;
    objArray2[2] = (object) _param2;
    objArray2[3] = (object) _param3;
    return (bool) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "4)&GFCi+&n", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private static void \u002Ector_1(ref string _param0, ref string _param1, ref HttpClient _param2)
  {
    object[] objArray = new object[3]
    {
      (object) _param0,
      (object) _param1,
      (object) _param2
    };
    dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
    Stream stream = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
    try
    {
      msB6AxnL4LxzaEjd.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream, "LM:L=Ci+&C", objArray);
    }
    finally
    {
      _param0 = (string) objArray[0];
      _param1 = (string) objArray[1];
      _param2 = (HttpClient) objArray[2];
    }
  }

  private static void \u0023\u003DzD0boGkATCUZN(
    ref \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D.\u0023\u003DzNTll09x4Er23nLob1w\u003D\u003D _param0)
  {
    _param0.\u0023\u003Dz9fMS2rZwKwTV.Start<\u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D.\u0023\u003DzNTll09x4Er23nLob1w\u003D\u003D>(ref _param0);
  }

  private static class \u0023\u003Dz2uoTCK0\u003D
  {
    public static Func<
    #nullable enable
    HttpRequestMessage, X509Certificate2?, X509Chain?, SslPolicyErrors, bool> \u0023\u003DzkoGmWitiHp1kWZb96g\u003D\u003D;
  }

  [StructLayout(LayoutKind.Auto)]
  private struct \u0023\u003DzNTll09x4Er23nLob1w\u003D\u003D : IAsyncStateMachine
  {
    public int \u0023\u003DzfoFpodyRBvSE;
    public AsyncTaskMethodBuilder<\u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D> \u0023\u003Dz9fMS2rZwKwTV;
    public 
    #nullable disable
    string \u0023\u003DzhHvbzq0\u003D;
    public string \u0023\u003DzdoOMM0A\u003D;
    public string \u0023\u003Dzo91sdHM\u003D;
    public string \u0023\u003DzN53JeeY\u003D;
    public \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D \u0023\u003DziRnUrnBEE78Y;
    private TaskAwaiter<
    #nullable enable
    HttpResponseMessage> \u0023\u003DzVME5h\u0024kcIEqd;
    private TaskAwaiter<string> \u0023\u003DzHXf6WxPBP1zh;

    void IAsyncStateMachine.MoveNext()
    {
      object[] objArray1 = new object[1];
      if (true)
        goto label_3;
label_1:
      object[] objArray2;
      objArray2[0] = (object) this;
      dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd1 = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
      if (true)
        goto label_4;
label_2:
      Stream stream1 = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
      Stream stream2;
      if (true)
        stream2 = stream1;
      dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd2;
      try
      {
        msB6AxnL4LxzaEjd2.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream2, "5A=kJCi+&O", objArray2);
        return;
      }
      finally
      {
        this = (\u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D.\u0023\u003DzNTll09x4Er23nLob1w\u003D\u003D) objArray2[0];
      }
label_4:
      msB6AxnL4LxzaEjd2 = msB6AxnL4LxzaEjd1;
      goto label_2;
label_3:
      objArray2 = objArray1;
      goto label_1;
    }

    [DebuggerHidden]
    void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _param1)
    {
      ref AsyncTaskMethodBuilder<\u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D> local = ref this.\u0023\u003Dz9fMS2rZwKwTV;
      IAsyncStateMachine asyncStateMachine = _param1;
      if (false)
        return;
      local.SetStateMachine(asyncStateMachine);
    }

    private static void MoveNext(
      ref TaskAwaiter<
      #nullable disable
      HttpResponseMessage> _param0,
      ref \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D.\u0023\u003DzNTll09x4Er23nLob1w\u003D\u003D _param1)
    {
      _param1.\u0023\u003Dz9fMS2rZwKwTV.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D.\u0023\u003DzNTll09x4Er23nLob1w\u003D\u003D>(ref _param0, ref _param1);
    }

    private static void MoveNext_1(
      ref TaskAwaiter<string> _param0,
      ref \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D.\u0023\u003DzNTll09x4Er23nLob1w\u003D\u003D _param1)
    {
      _param1.\u0023\u003Dz9fMS2rZwKwTV.AwaitUnsafeOnCompleted<TaskAwaiter<string>, \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D.\u0023\u003DzNTll09x4Er23nLob1w\u003D\u003D>(ref _param0, ref _param1);
    }
  }
}
