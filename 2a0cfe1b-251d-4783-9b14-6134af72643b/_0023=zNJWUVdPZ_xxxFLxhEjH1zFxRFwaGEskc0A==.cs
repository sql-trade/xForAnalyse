// Decompiled with JetBrains decompiler
// Type: #=zNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
internal sealed class \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D
{
  private EventHandler<\u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D> \u0023\u003Dz3ktCCQEF3vEw;
  private readonly string[] \u0023\u003DzUvPWzec70IrQSNXs5Q\u003D\u003D;
  private readonly string \u0023\u003DzXMxptcqXcgZS;
  private readonly string \u0023\u003DzybpidpGigyWc;
  private readonly \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D \u0023\u003Dzes8lVdg\u003D;
  private readonly Thread \u0023\u003DzUCtX2z8\u003D;
  private string \u0023\u003Dz69SObE1jWIpf;
  private bool \u0023\u003DzMaCa1Gn5cby8;
  private string[] \u0023\u003Dz\u0024xnrGqCsljssgkXFmw\u003D\u003D;
  private \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D \u0023\u003DzhBK0evzJDDuF;

  public \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D(
    string[] _param1,
    string _param2)
  {
    ref readonly string local1 = ref this.\u0023\u003DzybpidpGigyWc;
    ref readonly \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D local2 = ref this.\u0023\u003Dzes8lVdg\u003D;
    ref string local3 = ref this.\u0023\u003Dz69SObE1jWIpf;
    ref string[] local4 = ref this.\u0023\u003Dz\u0024xnrGqCsljssgkXFmw\u003D\u003D;
    if (true)
      goto label_3;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    string[] strArray = _param1;
    string str = _param2;
    if (false)
      return;
    this.\u002Ector_2(strArray, str);
    return;
label_3:
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u002Ector_1(ref local1, ref local2, ref local3, ref local4);
    goto label_1;
  }

  public void \u0023\u003DzpU42w8QIdWJm(
    EventHandler<\u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D> _param1)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D h1zFxRfwaGeskc0A1;
    try
    {
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D h1zFxRfwaGeskc0A2 = h1zFxRfwaGeskc0A1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      this.\u0023\u003Dz3ktCCQEF3vEw += _param1;
      int length = this.\u0023\u003Dz3ktCCQEF3vEw.GetInvocationList().Length;
      return;
label_6:
      Monitor.Enter((object) h1zFxRfwaGeskc0A2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) h1zFxRfwaGeskc0A1);
    }
label_2:
    h1zFxRfwaGeskc0A1 = this;
    goto label_1;
  }

  public void \u0023\u003Dz99FqoMv_X9u5(
    EventHandler<\u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D> _param1)
  {
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D h1zFxRfwaGeskc0A1;
    try
    {
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D h1zFxRfwaGeskc0A2 = h1zFxRfwaGeskc0A1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      this.\u0023\u003Dz3ktCCQEF3vEw -= _param1;
      EventHandler<\u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D> z3ktCcqeF3vEw = this.\u0023\u003Dz3ktCCQEF3vEw;
      if (z3ktCcqeF3vEw == null)
        return;
      int length = z3ktCcqeF3vEw.GetInvocationList().Length;
      return;
label_6:
      Monitor.Enter((object) h1zFxRfwaGeskc0A2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) h1zFxRfwaGeskc0A1);
    }
label_2:
    h1zFxRfwaGeskc0A1 = this;
    goto label_1;
  }

  public \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D \u0023\u003Dz4mPOAEaJQC2J()
  {
    if (true)
      ;
    if (true)
      ;
    // ISSUE: method pointer
    return this.\u0023\u003DzLPEK_sw\u003D<\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D>(new Func<\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D>((object) this, __methodptr(\u0023\u003Dz8XMcc\u0024FUvU5_PPjPET7H40g\u003D)));
  }

  private void \u0023\u003Dz7uC6ZRjJ_\u0024vI(
    \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D _param1)
  {
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzNP9ibR9OkMwpnXz9YZMAqsY\u003D okMwpnXz9YzmAqsY1 = new \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzNP9ibR9OkMwpnXz9YZMAqsY\u003D();
    if (true)
      goto label_4;
label_1:
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzNP9ibR9OkMwpnXz9YZMAqsY\u003D okMwpnXz9YzmAqsY2;
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzNP9ibR9OkMwpnXz9YZMAqsY\u003D okMwpnXz9YzmAqsY3 = okMwpnXz9YzmAqsY2;
    if (true)
      goto label_5;
label_2:
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzNP9ibR9OkMwpnXz9YZMAqsY\u003D okMwpnXz9YzmAqsY4 = okMwpnXz9YzmAqsY2;
    int num1 = (int) _param1;
    if (true)
      goto label_6;
label_3:
    int num2 = (int) this.\u0023\u003DzLPEK_sw\u003D<\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D>(new Func<\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D>(okMwpnXz9YzmAqsY2.\u0023\u003Dz9EK2p1UuAuMZbW9Ygw\u003D\u003D));
    return;
label_6:
    okMwpnXz9YzmAqsY4.\u0023\u003DzKJitM64\u003D = (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) num1;
    goto label_3;
label_5:
    okMwpnXz9YzmAqsY3.\u0023\u003DziRnUrnBEE78Y = this;
    goto label_2;
label_4:
    okMwpnXz9YzmAqsY2 = okMwpnXz9YzmAqsY1;
    goto label_1;
  }

  public string[] \u0023\u003Dzvi7s7jEsSbf2()
  {
    if (true)
      ;
    if (true)
      ;
    // ISSUE: method pointer
    return this.\u0023\u003DzLPEK_sw\u003D<string[]>(new Func<string[]>((object) this, __methodptr(\u0023\u003DzcEi29ft5\u0024nhHifgC2yhztFc\u003D)));
  }

  private void \u0023\u003Dz0bsRTKzWMIit(string[] _param1)
  {
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzcXw3qhkGDS2Hy0lJ8NB8ouY\u003D gdS2Hy0lJ8Nb8ouY1 = new \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzcXw3qhkGDS2Hy0lJ8NB8ouY\u003D();
    if (true)
      goto label_4;
label_1:
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzcXw3qhkGDS2Hy0lJ8NB8ouY\u003D gdS2Hy0lJ8Nb8ouY2;
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzcXw3qhkGDS2Hy0lJ8NB8ouY\u003D gdS2Hy0lJ8Nb8ouY3 = gdS2Hy0lJ8Nb8ouY2;
    if (true)
      goto label_5;
label_2:
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzcXw3qhkGDS2Hy0lJ8NB8ouY\u003D gdS2Hy0lJ8Nb8ouY4 = gdS2Hy0lJ8Nb8ouY2;
    string[] strArray = _param1;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzLPEK_sw\u003D<string[]>(new Func<string[]>(gdS2Hy0lJ8Nb8ouY2.\u0023\u003DzNBdfNfQ_RnBRncqX9QfCc6k\u003D));
    return;
label_6:
    gdS2Hy0lJ8Nb8ouY4.\u0023\u003DzKJitM64\u003D = strArray;
    goto label_3;
label_5:
    gdS2Hy0lJ8Nb8ouY3.\u0023\u003DziRnUrnBEE78Y = this;
    goto label_2;
label_4:
    gdS2Hy0lJ8Nb8ouY2 = gdS2Hy0lJ8Nb8ouY1;
    goto label_1;
  }

  private void \u0023\u003Dz9VhvCZbRrJNc()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_3;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
    Stream stream = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
    object[] objArray3 = objArray2;
    if (false)
      return;
    msB6AxnL4LxzaEjd.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream, "g1b;;Ci+&m", objArray3);
    return;
label_3:
    objArray2 = objArray1;
    goto label_1;
  }

  private static bool \u0023\u003DzBU2kLsOf9WsA(string _param0)
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) _param0;
    return (bool) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "7VQUQCi+')", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D[] \u0023\u003Dzx9IjvjUfbqY1(
    string _param1)
  {
    object[] objArray1 = new object[2];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    objArray2[1] = (object) _param1;
    return (\u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D[]) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "k%SRGCi+&e", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private void \u0023\u003DzkSxMXO8jlfGP()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_3;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
    Stream stream = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
    object[] objArray3 = objArray2;
    if (false)
      return;
    msB6AxnL4LxzaEjd.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream, "o4_rTCi+&W", objArray3);
    return;
label_3:
    objArray2 = objArray1;
    goto label_1;
  }

  private void \u0023\u003DzTiStBksvOn9l()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_3;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
    Stream stream = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
    object[] objArray3 = objArray2;
    if (false)
      return;
    msB6AxnL4LxzaEjd.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream, "B5)*rCi+'2", objArray3);
    return;
label_3:
    objArray2 = objArray1;
    goto label_1;
  }

  private string \u0023\u003Dz1pKPw3qdCc88()
  {
    if (true)
      ;
    if (true)
      ;
    // ISSUE: method pointer
    return this.\u0023\u003DzLPEK_sw\u003D<string>(new Func<string>((object) this, __methodptr(\u0023\u003DzE57zj0fwJKkmyIR\u0024is_45ec\u003D)));
  }

  private void \u0023\u003DzrWeHWZ8PnN8Q(string _param1)
  {
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzbEBWqedNPNrUDKlPw7jg8gg\u003D npNrUdKlPw7jg8gg1 = new \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzbEBWqedNPNrUDKlPw7jg8gg\u003D();
    if (true)
      goto label_4;
label_1:
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzbEBWqedNPNrUDKlPw7jg8gg\u003D npNrUdKlPw7jg8gg2;
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzbEBWqedNPNrUDKlPw7jg8gg\u003D npNrUdKlPw7jg8gg3 = npNrUdKlPw7jg8gg2;
    if (true)
      goto label_5;
label_2:
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzbEBWqedNPNrUDKlPw7jg8gg\u003D npNrUdKlPw7jg8gg4 = npNrUdKlPw7jg8gg2;
    string str = _param1;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzLPEK_sw\u003D(new Action(npNrUdKlPw7jg8gg2.\u0023\u003DzwMLVB\u0024SOtnuURf_Rmw\u003D\u003D));
    return;
label_6:
    npNrUdKlPw7jg8gg4.\u0023\u003DzKJitM64\u003D = str;
    goto label_3;
label_5:
    npNrUdKlPw7jg8gg3.\u0023\u003DziRnUrnBEE78Y = this;
    goto label_2;
label_4:
    npNrUdKlPw7jg8gg2 = npNrUdKlPw7jg8gg1;
    goto label_1;
  }

  public void \u0023\u003Dztx9nKMBKNhbc(string _param1)
  {
    object[] objArray1 = new object[2];
    if (true)
      goto label_3;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    objArray2[1] = (object) _param1;
    dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
    Stream stream = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
    object[] objArray3 = objArray2;
    if (false)
      return;
    msB6AxnL4LxzaEjd.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream, "s(Q4`Ci+')", objArray3);
    return;
label_3:
    objArray2 = objArray1;
    goto label_1;
  }

  private void \u0023\u003DzRQQ4HTb_QJYUQI2U9Bafg5I\u003D()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_3;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
    Stream stream = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
    object[] objArray3 = objArray2;
    if (false)
      return;
    msB6AxnL4LxzaEjd.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream, ")ej&&Ci+'2", objArray3);
    return;
label_3:
    objArray2 = objArray1;
    goto label_1;
  }

  private \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D \u0023\u003Dz8XMcc\u0024FUvU5_PPjPET7H40g\u003D()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    return (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), ",ACn.Ci+'7", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private string[] \u0023\u003DzcEi29ft5\u0024nhHifgC2yhztFc\u003D()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    return (string[]) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "1MLT>Ci+'$", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private void \u0023\u003Dz2PUofvz8TxMyFeuYzP5YnYw\u003D()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_3;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
    Stream stream = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
    object[] objArray3 = objArray2;
    if (false)
      return;
    msB6AxnL4LxzaEjd.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream, "H>.,0Ci+'!", objArray3);
    return;
label_3:
    objArray2 = objArray1;
    goto label_1;
  }

  private EventHandler<\u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D> \u0023\u003Dzq9j0cPGSW1s80oyxyAw6qfM\u003D()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    return (EventHandler<\u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D>) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "PA+cICi+'(", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private string \u0023\u003DzE57zj0fwJKkmyIR\u0024is_45ec\u003D()
  {
    object[] objArray1 = new object[1];
    if (true)
      goto label_2;
label_1:
    object[] objArray2;
    objArray2[0] = (object) this;
    return (string) \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzOc7KLH2uc\u0024JwCN7n5o0PjYY\u003D(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), "f4eu8Ci+&d", objArray2);
label_2:
    objArray2 = objArray1;
    goto label_1;
  }

  private static void \u002Ector_1(
    ref string _param0,
    ref \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D _param1,
    ref string _param2,
    ref string[] _param3)
  {
    object[] objArray = new object[4]
    {
      (object) _param0,
      (object) _param1,
      (object) _param2,
      (object) _param3
    };
    dje_qBAS48JAJSH8GHR93KRTKC5RSAPXXXNWUCAHW3C2MSB6AXNL4LXZA_ejd msB6AxnL4LxzaEjd = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd();
    Stream stream = \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D();
    try
    {
      msB6AxnL4LxzaEjd.\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(stream, "7ql^RCi+&@", objArray);
    }
    finally
    {
      _param0 = (string) objArray[0];
      _param1 = (\u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D) objArray[1];
      _param2 = (string) objArray[2];
      _param3 = (string[]) objArray[3];
    }
  }

  private void \u002Ector_2(string[] _param1, string _param2)
  {
    object[] objArray = new object[3]
    {
      (object) this,
      (object) _param1,
      (object) _param2
    };
    \u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.dje_zDXBXBXHWRMUEAPVBYUPCGNMHUR4KXLNCE9P8DUDSUETC8RQSXUHWWVMUQKUQ_ejd().\u0023\u003DzKbKZcUwCXchPMjg2_ao9pX6zaZPq(\u0023\u003DzL16I\u0024G1qSKYZ7dsLAinfktf9Ok2LOhzvUVbOITNjJROtMQfqmg\u003D\u003D.\u0023\u003DztTrxtm5Zm2C_n762dHv8IfIJFkNj7HoMdDMhqVJUnUWK9mcj0Q\u003D\u003D(), ">A7hfCi+&>", objArray);
  }

  private sealed class \u0023\u003DzF9Ox_K2vSCx3MXa6XaeyeaU\u003D
  {
    public \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D \u0023\u003DziRnUrnBEE78Y;
    public string \u0023\u003Dzz0fBeTA\u003D;

    public \u0023\u003DzF9Ox_K2vSCx3MXa6XaeyeaU\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal Task<\u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D> \u0023\u003Dz0t8u2V6g9LOt9FZOhA\u003D\u003D(
      string _param1)
    {
      if (true)
        ;
      \u0023\u003Dz7R70OiYB7GvvUJIAcTFvU3xU5S5cJzRx3w4NiW8\u003D zes8lVdg = this.\u0023\u003DziRnUrnBEE78Y.\u0023\u003Dzes8lVdg\u003D;
      if (true)
        ;
      string zz0fBeTa = this.\u0023\u003Dzz0fBeTA\u003D;
      string str = _param1;
      if (true)
        ;
      string zXmxptcqXcgZs = this.\u0023\u003DziRnUrnBEE78Y.\u0023\u003DzXMxptcqXcgZS;
      string zybpidpGigyWc = this.\u0023\u003DziRnUrnBEE78Y.\u0023\u003DzybpidpGigyWc;
      return zes8lVdg.\u0023\u003DzD0boGkATCUZN(zz0fBeTa, str, zXmxptcqXcgZs, zybpidpGigyWc);
    }
  }

  private sealed class \u0023\u003DzNP9ibR9OkMwpnXz9YZMAqsY\u003D
  {
    public \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D \u0023\u003DziRnUrnBEE78Y;
    public \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D \u0023\u003DzKJitM64\u003D;

    public \u0023\u003DzNP9ibR9OkMwpnXz9YZMAqsY\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D \u0023\u003Dz9EK2p1UuAuMZbW9Ygw\u003D\u003D()
    {
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D ziRnUrnBeE78Y = this.\u0023\u003DziRnUrnBEE78Y;
      int zKjitM64 = (int) this.\u0023\u003DzKJitM64\u003D;
      if (true)
        goto label_3;
label_1:
      if (true)
        goto label_4;
label_2:
      \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D ukI9hya9h9S0586g;
      return ukI9hya9h9S0586g;
label_4:
      ziRnUrnBeE78Y.\u0023\u003DzhBK0evzJDDuF = (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) zKjitM64;
      goto label_2;
label_3:
      ukI9hya9h9S0586g = (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) zKjitM64;
      goto label_1;
    }
  }

  private sealed class \u0023\u003DzbEBWqedNPNrUDKlPw7jg8gg\u003D
  {
    public \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D \u0023\u003DziRnUrnBEE78Y;
    public string \u0023\u003DzKJitM64\u003D;

    public \u0023\u003DzbEBWqedNPNrUDKlPw7jg8gg\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal void \u0023\u003DzwMLVB\u0024SOtnuURf_Rmw\u003D\u003D()
    {
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D ziRnUrnBeE78Y1 = this.\u0023\u003DziRnUrnBEE78Y;
      string zKjitM64 = this.\u0023\u003DzKJitM64\u003D;
      if (true)
        goto label_3;
label_1:
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D ziRnUrnBeE78Y2 = this.\u0023\u003DziRnUrnBEE78Y;
      if (false)
        return;
      ziRnUrnBeE78Y2.\u0023\u003DzMaCa1Gn5cby8 = true;
      return;
label_3:
      ziRnUrnBeE78Y1.\u0023\u003Dz69SObE1jWIpf = zKjitM64;
      goto label_1;
    }
  }

  private sealed class \u0023\u003DzcXw3qhkGDS2Hy0lJ8NB8ouY\u003D
  {
    public \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D \u0023\u003DziRnUrnBEE78Y;
    public string[] \u0023\u003DzKJitM64\u003D;

    public \u0023\u003DzcXw3qhkGDS2Hy0lJ8NB8ouY\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal string[] \u0023\u003DzNBdfNfQ_RnBRncqX9QfCc6k\u003D()
    {
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D ziRnUrnBeE78Y = this.\u0023\u003DziRnUrnBEE78Y;
      string[] zKjitM64 = this.\u0023\u003DzKJitM64\u003D;
      if (true)
        goto label_3;
label_1:
      if (true)
        goto label_4;
label_2:
      string[] strArray;
      return strArray;
label_4:
      ziRnUrnBeE78Y.\u0023\u003Dz\u0024xnrGqCsljssgkXFmw\u003D\u003D = zKjitM64;
      goto label_2;
label_3:
      strArray = zKjitM64;
      goto label_1;
    }
  }

  [Serializable]
  private sealed class \u0023\u003DzewGRIik\u003D
  {
    public static readonly \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzewGRIik\u003D \u0023\u003DzahaWqVg\u003D;
    public static Func<string, \u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D, \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D> \u0023\u003DznOpS9oPifPE3Mlss2g\u003D\u003D;
    public static Func<\u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D, bool> \u0023\u003DzLHQ7z0ECtxmxYNyczA\u003D\u003D;
    public static Func<\u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D, string> \u0023\u003DzQQeNaX5IxHBf0xOQVw\u003D\u003D;
    public static Func<\u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D, bool> \u0023\u003DzfsgciRQ1c6KRff7dfg\u003D\u003D;

    static \u0023\u003DzewGRIik\u003D()
    {
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzewGRIik\u003D zewGrIik = new \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzewGRIik\u003D();
      if (false)
        return;
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D = zewGrIik;
    }

    public \u0023\u003DzewGRIik\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D \u0023\u003DzbhIvkUehu6sCM4QepadvLOs\u003D(
      string _param1,
      \u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D _param2)
    {
      string str = _param1;
      if (true)
        ;
      int num = (int) _param2;
      if (true)
        ;
      return new \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D(str, (\u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D) num);
    }

    internal bool \u0023\u003Dz14q8q9_IV7Ecg17g2KiNxeo\u003D(
      \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D _param1)
    {
      \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D ytianD6uLrzOoXwTsxN0 = _param1;
      if (true)
        ;
      return ytianD6uLrzOoXwTsxN0.\u0023\u003Dz4mPOAEaJQC2J() == (\u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D) 0;
    }

    internal string \u0023\u003DzvCx_pyzyX81QkClkHUK5tn4\u003D(
      \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D _param1)
    {
      \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D ytianD6uLrzOoXwTsxN0 = _param1;
      if (true)
        ;
      return ytianD6uLrzOoXwTsxN0.\u0023\u003DzBhvJWfxhyPf2();
    }

    internal bool \u0023\u003DzEsSooneC5nSJX5g5RAxRQqA\u003D(
      \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D _param1)
    {
      \u0023\u003DzQ5xZN\u0024hIg8acMzd2h5YTIAND6uLRzOOXwTsxN_0\u003D ytianD6uLrzOoXwTsxN0 = _param1;
      if (true)
        ;
      return ytianD6uLrzOoXwTsxN0.\u0023\u003Dz4mPOAEaJQC2J() != (\u0023\u003Dzi8QCTc98BGtHy20_mpeHrhrgUF5pnEaIXA\u003D\u003D) 1;
    }
  }
}
