// Decompiled with JetBrains decompiler
// Type: #=qymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.IO;
using System.Text;

#nullable disable
internal sealed class \u0023\u003Dqymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po\u003D : IDisposable
{
  private \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D \u0023\u003Dzv_DK75M\u003D;
  private byte[] \u0023\u003DzOsmxM1I\u003D;
  private Decoder \u0023\u003DzAElFq6M\u003D;
  private byte[] \u0023\u003DzhBh6D88\u003D;
  private char[] \u0023\u003DzsIRkzxg\u003D;
  private char[] \u0023\u003DzQvRsjjA\u003D;
  private int \u0023\u003DzlrX5m0o\u003D;
  private bool \u0023\u003DzDnwpn_c\u003D;
  private bool \u0023\u003DzZ04UAGU\u003D;
  private byte[] \u0023\u003DzL67ogXM\u003D;
  private MemoryStream \u0023\u003DzzUCMxbo\u003D;
  private BinaryReader \u0023\u003DzjsRRUjg\u003D;

  public \u0023\u003Dqymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po\u003D(
    \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D _param1)
  {
    if (true)
      ;
    \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D ebfggaxStyQ4bNbAoc = _param1;
    if (true)
      ;
    UTF8Encoding utF8Encoding = new UTF8Encoding();
    // ISSUE: explicit constructor call
    this.\u002Ector(ebfggaxStyQ4bNbAoc, (Encoding) utF8Encoding);
  }

  private \u0023\u003Dqymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po\u003D(
    \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D _param1,
    Encoding _param2)
  {
    if (_param1 == null)
      throw new ArgumentNullException();
    if (_param2 == null)
      throw new ArgumentNullException();
    \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D ebfggaxStyQ4bNbAoc = _param1.\u0023\u003DzxL4NTUOAh1RIQ_euvW5\u0024luBRrWyehIjrdpysROdU_zhi8f6ALQ6PIO_1oX1KMCNn06OOwnE\u003D() ? _param1 : throw new ArgumentException();
    if (true)
      goto label_10;
label_7:
    Decoder decoder = _param2.GetDecoder();
    if (true)
      goto label_11;
label_8:
    int maxCharCount = _param2.GetMaxCharCount(128 /*0x80*/);
    if (true)
      goto label_12;
label_9:
    int length = _param2.GetMaxByteCount(1);
    if (length < 16 /*0x10*/)
      length = 16 /*0x10*/;
    this.\u0023\u003DzOsmxM1I\u003D = new byte[length];
    this.\u0023\u003DzQvRsjjA\u003D = (char[]) null;
    this.\u0023\u003DzhBh6D88\u003D = (byte[]) null;
    this.\u0023\u003DzDnwpn_c\u003D = _param2 is UnicodeEncoding;
    this.\u0023\u003DzZ04UAGU\u003D = this.\u0023\u003Dzv_DK75M\u003D is \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D;
    return;
label_12:
    this.\u0023\u003DzlrX5m0o\u003D = maxCharCount;
    goto label_9;
label_11:
    this.\u0023\u003DzAElFq6M\u003D = decoder;
    goto label_8;
label_10:
    this.\u0023\u003Dzv_DK75M\u003D = ebfggaxStyQ4bNbAoc;
    goto label_7;
  }

  public \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D \u0023\u003DzFLWVCRVO8UNizpVDlRlh9s1gbK0QpeOIUg\u003D\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dzv_DK75M\u003D;
  }

  public void \u0023\u003DzpuNyO9MISQeN4v73A\u0024QLQwJYSRXJ28g9nA\u003D\u003D()
  {
    if (false)
      return;
    this.\u0023\u003DzOH8FXqVqzuWv6Gzk\u002436xxaCDgvCECLMPpQ\u003D\u003D(true);
  }

  private void \u0023\u003DzOH8FXqVqzuWv6Gzk\u002436xxaCDgvCECLMPpQ\u003D\u003D(bool _param1)
  {
    if (_param1)
    {
      \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
      if (true)
        goto label_4;
label_2:
      if (true)
        goto label_5;
label_3:
      \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D ebfggaxStyQ4bNbAoc;
      if (ebfggaxStyQ4bNbAoc != null)
      {
        ebfggaxStyQ4bNbAoc.\u0023\u003DzpnFNAVe9Oez_JL1Lp7ZnpETC6eVtZJ01RuhxhhI\u0024sCSQ2oHxQNt\u0024P2lfnotIPN9jx_GvOBFVkBspyRSZOIzKJ1I\u003D();
        goto label_7;
      }
      goto label_7;
label_5:
      this.\u0023\u003Dzv_DK75M\u003D = (\u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D) null;
      goto label_3;
label_4:
      ebfggaxStyQ4bNbAoc = zvDk75M;
      goto label_2;
    }
label_7:
    if (true)
      goto label_9;
label_8:
    this.\u0023\u003DzOsmxM1I\u003D = (byte[]) null;
    this.\u0023\u003DzAElFq6M\u003D = (Decoder) null;
    this.\u0023\u003DzhBh6D88\u003D = (byte[]) null;
    this.\u0023\u003DzsIRkzxg\u003D = (char[]) null;
    this.\u0023\u003DzQvRsjjA\u003D = (char[]) null;
    return;
label_9:
    this.\u0023\u003Dzv_DK75M\u003D = (\u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D) null;
    goto label_8;
  }

  void IDisposable.\u0023\u003DzaHH2Is\u0024GpSTK91uD_IcqE6jFZf6_K498sJCSSb6yX4f9BX5EzZQjHvj8QEtdG7QPYQXvTQkLWckW()
  {
    if (false)
      return;
    this.\u0023\u003DzOH8FXqVqzuWv6Gzk\u002436xxaCDgvCECLMPpQ\u003D\u003D(true);
  }

  public int \u0023\u003DzIiYRQJNV\u0024p5pnqCsEtFNL5I\u003D()
  {
    if (true)
      goto label_2;
label_1:
    if (!this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzPkgH6portpv5CYuJmPIg9GuVLpJ10l80hT2UABZn9aUG_L9h4mXIjspJeR2Iva1Idj_lUp\u0024ZU\u00242e())
      return -1;
    long num1 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzUWjiMzrscdbNirxNE8qbXmJSKC4FCr5qTpPyMVNfz9c7y77twKxesGSMoR\u0024DTE5oOTEZ2NE\u003D();
    if (true)
      goto label_6;
label_5:
    int num2 = this.\u0023\u003Dzh\u0024Hj7iP9ghFTZ_4YTGeTsFX4QRExeCxFVw\u003D\u003D();
    long num3;
    this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzoqGGSxv50nBf7J_lcpaCyXazKs2ZNgFtR4W8C38H\u0024EKh3gfPvmMpqKkYi8sNKdHliMRA94E\u003D(num3);
    return num2;
label_6:
    num3 = num1;
    goto label_5;
label_2:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_1;
  }

  public int \u0023\u003Dzh\u0024Hj7iP9ghFTZ_4YTGeTsFX4QRExeCxFVw\u003D\u003D()
  {
    if (true)
      goto label_2;
label_1:
    return this.\u0023\u003DzAABdBar4u41W\u0024hzhdUzYuOY\u003D();
label_2:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_1;
  }

  public bool \u0023\u003Dzkge7nzmLoeCFFrJLraOv4Mw\u003D()
  {
    if (true)
      goto label_2;
label_1:
    return this.\u0023\u003DzOsmxM1I\u003D[0] > (byte) 0;
label_2:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(1);
    goto label_1;
  }

  public byte \u0023\u003DzRAdGV4IRmSd66qO6xTfpLXOa_2YauXN9OGMlr4w\u003D()
  {
    if (true)
      goto label_2;
label_1:
    int num = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dz5K7bWXXu3efUrOkp4vR2Y3ozKwY5IT529k0H61hWMt4zETG75r2w_lB9KUDLpXL5UsLDFYbjZtI6GQNGi9HaAPdbvCHG();
    return num != -1 ? (byte) num : throw new Exception();
label_2:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_1;
  }

  public sbyte \u0023\u003DzC3754l4apw59kffGzy4icuU\u003D()
  {
    if (true)
      goto label_2;
label_1:
    return (sbyte) this.\u0023\u003DzOsmxM1I\u003D[0];
label_2:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(1);
    goto label_1;
  }

  public char \u0023\u003Dzm7Z8DizhSeP9abCuhg\u003D\u003D()
  {
    if (true)
      ;
    int num = this.\u0023\u003Dzh\u0024Hj7iP9ghFTZ_4YTGeTsFX4QRExeCxFVw\u003D\u003D();
    return num != -1 ? (char) num : throw new Exception();
  }

  private static Decimal \u0023\u003Dz5mN9\u0024m2g6wYMjYLc\u0024ceYQFA7FcIwmuggNRoxwRXia5ca(
    int _param0,
    int _param1,
    int _param2,
    int _param3)
  {
    int num1 = (_param3 & int.MinValue) != 0 ? 1 : 0;
    if (true)
      goto label_3;
label_1:
    int num2 = (int) (byte) (_param3 >> 16 /*0x10*/);
    if (true)
      goto label_4;
label_2:
    bool isNegative;
    byte scale;
    return new Decimal(_param0, _param1, _param2, isNegative, scale);
label_4:
    scale = (byte) num2;
    goto label_2;
label_3:
    isNegative = num1 != 0;
    goto label_1;
  }

  internal static Decimal \u0023\u003Dz_wr3TCofPdhgFC7emWjlctJSrBmA8fRpJw\u003D\u003D(byte[] _param0)
  {
    int num1 = (int) _param0[0] | (int) _param0[1] << 8 | (int) _param0[2] << 16 /*0x10*/ | (int) _param0[3] << 24;
    int num2 = (int) _param0[4] | (int) _param0[5] << 8 | (int) _param0[6] << 16 /*0x10*/ | (int) _param0[7] << 24;
    if (true)
      goto label_4;
label_1:
    int num3 = (int) _param0[8] | (int) _param0[9] << 8 | (int) _param0[10] << 16 /*0x10*/ | (int) _param0[11] << 24;
    if (true)
      goto label_5;
label_2:
    int num4 = (int) _param0[12] | (int) _param0[13] << 8 | (int) _param0[14] << 16 /*0x10*/ | (int) _param0[15] << 24;
    if (true)
      goto label_6;
label_3:
    int num5;
    int num6 = num5;
    int num7;
    int num8 = num7;
    int num9;
    int num10 = num9;
    return \u0023\u003Dqymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po\u003D.\u0023\u003Dz5mN9\u0024m2g6wYMjYLc\u0024ceYQFA7FcIwmuggNRoxwRXia5ca(num1, num6, num8, num10);
label_6:
    num9 = num4;
    goto label_3;
label_5:
    num7 = num3;
    goto label_2;
label_4:
    num5 = num2;
    goto label_1;
  }

  public string \u0023\u003Dz4Si4UNAugk6t_r\u0024nFQBOnWjx4XyzkUuIPjxVUgI\u003D()
  {
    if (true)
      goto label_4;
label_1:
    if (true)
      goto label_5;
label_2:
    int num1 = this.\u0023\u003DzW1OuVAxcUj8WkZ2Lmok6_\u0024nnAuel();
    if (true)
      goto label_6;
label_3:
    int capacity;
    if (capacity < 0)
      throw new IOException();
    if (capacity == 0)
      return string.Empty;
    if (this.\u0023\u003DzhBh6D88\u003D == null)
      this.\u0023\u003DzhBh6D88\u003D = new byte[128 /*0x80*/];
    if (this.\u0023\u003DzQvRsjjA\u003D == null)
      this.\u0023\u003DzQvRsjjA\u003D = new char[this.\u0023\u003DzlrX5m0o\u003D];
    StringBuilder stringBuilder = (StringBuilder) null;
    int num2;
    do
    {
      int num3 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzqi6bFCsg6IizkjY7gWIf9OnVpfyNfJgDHA7otxFYU\u0024\u0024PMTpQ2pm_sS0kK0AkdjN7zZiVkMr_EWVy\u0024THZuQ\u003D\u003D(this.\u0023\u003DzhBh6D88\u003D, 0, capacity - num2 > 128 /*0x80*/ ? 128 /*0x80*/ : capacity - num2);
      if (num3 == 0)
        throw new Exception();
      int chars = this.\u0023\u003DzAElFq6M\u003D.GetChars(this.\u0023\u003DzhBh6D88\u003D, 0, num3, this.\u0023\u003DzQvRsjjA\u003D, 0);
      if (num2 == 0 && num3 == capacity)
        return new string(this.\u0023\u003DzQvRsjjA\u003D, 0, chars);
      if (stringBuilder == null)
        stringBuilder = new StringBuilder(capacity);
      stringBuilder.Append(this.\u0023\u003DzQvRsjjA\u003D, 0, chars);
      num2 += num3;
    }
    while (num2 < capacity);
    return stringBuilder.ToString();
label_6:
    capacity = num1;
    goto label_3;
label_5:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_2;
label_4:
    num2 = 0;
    goto label_1;
  }

  public int \u0023\u003DzfzxLXz17aDUDSAVtd1huE\u0024AI07irwXlVLg\u003D\u003D(
    char[] _param1,
    int _param2,
    int _param3)
  {
    if (_param1 == null)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622748), \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621921));
    if (_param2 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param3 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param1.Length - _param2 < _param3)
      throw new ArgumentException();
    if (true)
      goto label_10;
label_9:
    return this.\u0023\u003DznpGaLpg9wndUqyR4MCWqF8QFsLGm(_param1, _param2, _param3);
label_10:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_9;
  }

  private int \u0023\u003DznpGaLpg9wndUqyR4MCWqF8QFsLGm(char[] _param1, int _param2, int _param3)
  {
    if (true)
      goto label_4;
label_1:
    if (true)
      goto label_5;
label_2:
    int num1 = _param3;
    if (true)
      goto label_6;
label_3:
    if (this.\u0023\u003DzhBh6D88\u003D == null)
      this.\u0023\u003DzhBh6D88\u003D = new byte[128 /*0x80*/];
    int num2;
    while (num2 > 0)
    {
      int num3 = num2;
      if (this.\u0023\u003DzDnwpn_c\u003D)
        num3 <<= 1;
      if (num3 > 128 /*0x80*/)
        num3 = 128 /*0x80*/;
      int chars;
      if (this.\u0023\u003DzZ04UAGU\u003D)
      {
        \u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D zvDk75M = (\u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D) this.\u0023\u003Dzv_DK75M\u003D;
        int num4 = zvDk75M.\u0023\u003Dz2tEIInL1eLOhU\u0024_8F_Z\u0024gO3U5WrW();
        int num5 = zvDk75M.\u0023\u003DzR__GdVJ1H2oUyNtad_qaDyoXTbVm(num3);
        if (num5 == 0)
          return _param3 - num2;
        chars = this.\u0023\u003DzAElFq6M\u003D.GetChars(zvDk75M.\u0023\u003DzSi4Oxtt49spoOQL0ay5L_Z0\u003D(), num4, num5, _param1, _param2);
      }
      else
      {
        int num6 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzqi6bFCsg6IizkjY7gWIf9OnVpfyNfJgDHA7otxFYU\u0024\u0024PMTpQ2pm_sS0kK0AkdjN7zZiVkMr_EWVy\u0024THZuQ\u003D\u003D(this.\u0023\u003DzhBh6D88\u003D, 0, num3);
        if (num6 == 0)
          return _param3 - num2;
        chars = this.\u0023\u003DzAElFq6M\u003D.GetChars(this.\u0023\u003DzhBh6D88\u003D, 0, num6, _param1, _param2);
      }
      num2 -= chars;
      _param2 += chars;
    }
    return _param3;
label_6:
    num2 = num1;
    goto label_3;
label_5:
    goto label_2;
label_4:
    goto label_1;
  }

  private int \u0023\u003DzAABdBar4u41W\u0024hzhdUzYuOY\u003D()
  {
    if (true)
      goto label_4;
label_1:
    if (true)
      goto label_5;
label_2:
    if (true)
      goto label_6;
label_3:
    long num1 = 0;
    if (this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzPkgH6portpv5CYuJmPIg9GuVLpJ10l80hT2UABZn9aUG_L9h4mXIjspJeR2Iva1Idj_lUp\u0024ZU\u00242e())
      num1 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzUWjiMzrscdbNirxNE8qbXmJSKC4FCr5qTpPyMVNfz9c7y77twKxesGSMoR\u0024DTE5oOTEZ2NE\u003D();
    if (this.\u0023\u003DzhBh6D88\u003D == null)
      this.\u0023\u003DzhBh6D88\u003D = new byte[128 /*0x80*/];
    if (this.\u0023\u003DzsIRkzxg\u003D == null)
      this.\u0023\u003DzsIRkzxg\u003D = new char[1];
    int num2;
    while (num2 == 0)
    {
      int num3 = this.\u0023\u003DzDnwpn_c\u003D ? 2 : 1;
      int num4 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dz5K7bWXXu3efUrOkp4vR2Y3ozKwY5IT529k0H61hWMt4zETG75r2w_lB9KUDLpXL5UsLDFYbjZtI6GQNGi9HaAPdbvCHG();
      this.\u0023\u003DzhBh6D88\u003D[0] = (byte) num4;
      if (num4 == -1)
        num3 = 0;
      if (num3 == 2)
      {
        int num5 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dz5K7bWXXu3efUrOkp4vR2Y3ozKwY5IT529k0H61hWMt4zETG75r2w_lB9KUDLpXL5UsLDFYbjZtI6GQNGi9HaAPdbvCHG();
        this.\u0023\u003DzhBh6D88\u003D[1] = (byte) num5;
        if (num5 == -1)
          num3 = 1;
      }
      if (num3 == 0)
        return -1;
      try
      {
        num2 = this.\u0023\u003DzAElFq6M\u003D.GetChars(this.\u0023\u003DzhBh6D88\u003D, 0, num3, this.\u0023\u003DzsIRkzxg\u003D, 0);
      }
      catch
      {
        if (this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzPkgH6portpv5CYuJmPIg9GuVLpJ10l80hT2UABZn9aUG_L9h4mXIjspJeR2Iva1Idj_lUp\u0024ZU\u00242e())
          this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dz5aRdfNAj4ntK5EbmqU4JtTQpm5iZUznQIpuVF\u0024YazKWC9R4AjFQtOLojJpnJTa462QE\u0024yNmuV0KnXwsUUg\u003D\u003D(num1 - this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzUWjiMzrscdbNirxNE8qbXmJSKC4FCr5qTpPyMVNfz9c7y77twKxesGSMoR\u0024DTE5oOTEZ2NE\u003D(), 1);
        throw;
      }
    }
    return num2 == 0 ? -1 : (int) this.\u0023\u003DzsIRkzxg\u003D[0];
label_6:
    goto label_3;
label_5:
    goto label_2;
label_4:
    num2 = 0;
    goto label_1;
  }

  public char[] \u0023\u003DzBN8sejB3biHTYW6e\u0024IOkbvLPLMcJ5jZ2gw\u003D\u003D(int _param1)
  {
    if (true)
      goto label_2;
label_1:
    char[] chArray = _param1 >= 0 ? new char[_param1] : throw new ArgumentOutOfRangeException();
    if (true)
      goto label_7;
label_5:
    char[] src;
    int num = this.\u0023\u003DznpGaLpg9wndUqyR4MCWqF8QFsLGm(src, 0, _param1);
    if (true)
      goto label_8;
label_6:
    int length;
    if (length != _param1)
    {
      char[] dst = new char[length];
      Buffer.BlockCopy((Array) src, 0, (Array) dst, 0, 2 * length);
      src = dst;
    }
    return src;
label_8:
    length = num;
    goto label_6;
label_7:
    src = chArray;
    goto label_5;
label_2:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_1;
  }

  public int \u0023\u003DzvLhrxe8OLYmBrK7JRV2n_fCq443Uo5nZyw\u003D\u003D(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    if (_param1 == null)
      throw new ArgumentNullException();
    if (_param2 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param3 < 0)
      throw new ArgumentOutOfRangeException();
    if (_param1.Length - _param2 < _param3)
      throw new ArgumentException();
    if (true)
      goto label_10;
label_9:
    return this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzqi6bFCsg6IizkjY7gWIf9OnVpfyNfJgDHA7otxFYU\u0024\u0024PMTpQ2pm_sS0kK0AkdjN7zZiVkMr_EWVy\u0024THZuQ\u003D\u003D(_param1, _param2, _param3);
label_10:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_9;
  }

  private void \u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7()
  {
    if (true)
      ;
    if (this.\u0023\u003Dzv_DK75M\u003D == null)
      throw new Exception();
  }

  public byte[] \u0023\u003DzqnOzsctFZKRW_7jsEEU6yAPttm2aFUwZHw\u003D\u003D(int _param1)
  {
    if (_param1 < 0)
      throw new ArgumentOutOfRangeException();
    if (true)
      goto label_5;
label_3:
    byte[] numArray = new byte[_param1];
    if (true)
      goto label_6;
label_4:
    int count;
    if (true)
      count = 0;
    byte[] src;
    do
    {
      int num = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzqi6bFCsg6IizkjY7gWIf9OnVpfyNfJgDHA7otxFYU\u0024\u0024PMTpQ2pm_sS0kK0AkdjN7zZiVkMr_EWVy\u0024THZuQ\u003D\u003D(src, count, _param1);
      if (num != 0)
      {
        count += num;
        _param1 -= num;
      }
      else
        break;
    }
    while (_param1 > 0);
    if (count != src.Length)
    {
      byte[] dst = new byte[count];
      Buffer.BlockCopy((Array) src, 0, (Array) dst, 0, count);
      src = dst;
    }
    return src;
label_6:
    src = numArray;
    goto label_4;
label_5:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_3;
  }

  private void \u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(int _param1)
  {
    if (true)
      goto label_5;
label_1:
    if (true)
      goto label_6;
label_2:
    if (true)
      goto label_7;
label_3:
    if (_param1 == 1)
    {
      int num = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dz5K7bWXXu3efUrOkp4vR2Y3ozKwY5IT529k0H61hWMt4zETG75r2w_lB9KUDLpXL5UsLDFYbjZtI6GQNGi9HaAPdbvCHG();
      this.\u0023\u003DzOsmxM1I\u003D[0] = num != -1 ? (byte) num : throw new Exception();
      return;
    }
    int num1;
    do
    {
      int num2 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzqi6bFCsg6IizkjY7gWIf9OnVpfyNfJgDHA7otxFYU\u0024\u0024PMTpQ2pm_sS0kK0AkdjN7zZiVkMr_EWVy\u0024THZuQ\u003D\u003D(this.\u0023\u003DzOsmxM1I\u003D, num1, _param1 - num1);
      if (num2 == 0)
        throw new Exception();
      num1 += num2;
    }
    while (num1 < _param1);
    return;
label_7:
    goto label_3;
label_6:
    num1 = 0;
    goto label_2;
label_5:
    this.\u0023\u003DzjMVQefsvqV5WC6AIPA1ncFfTjCqoKNeHitAjrZ__zGl7();
    goto label_1;
  }

  internal int \u0023\u003DzW1OuVAxcUj8WkZ2Lmok6_\u0024nnAuel()
  {
    if (true)
      goto label_2;
label_1:
    int num1;
    if (true)
      num1 = 0;
    int num2;
    while (num1 != 35)
    {
      int num3 = (int) this.\u0023\u003DzRAdGV4IRmSd66qO6xTfpLXOa_2YauXN9OGMlr4w\u003D();
      if (true)
        goto label_8;
label_7:
      byte num4;
      num2 |= ((int) num4 & (int) sbyte.MaxValue) << num1;
      num1 += 7;
      if (((int) num4 & 128 /*0x80*/) == 0)
        return num2;
      continue;
label_8:
      num4 = (byte) num3;
      goto label_7;
    }
    throw new FormatException();
label_2:
    num2 = 0;
    goto label_1;
  }

  public int \u0023\u003DzphrsiBpUym_kQb6xfSa4vwy3o5maP2F6NA\u003D\u003D()
  {
    if (this.\u0023\u003DzZ04UAGU\u003D)
      return ((\u0023\u003Dq04ZNUv9myDxvIni5fNhwucXAhfDHu8aa9Z1b3JwHwzI\u003D) this.\u0023\u003Dzv_DK75M\u003D).\u0023\u003Dzu1VaczWT3KF9kRBsR0etYMIzRWSI1TYZE_UEJFYtSizo();
    if (true)
      goto label_4;
label_3:
    return (int) this.\u0023\u003DzOsmxM1I\u003D[0] | (int) this.\u0023\u003DzOsmxM1I\u003D[3] << 24 | (int) this.\u0023\u003DzOsmxM1I\u003D[1] << 16 /*0x10*/ | (int) this.\u0023\u003DzOsmxM1I\u003D[2] << 8;
label_4:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(4);
    goto label_3;
  }

  public uint \u0023\u003DzWe1IEfITIwDH74HaohQnuEAezPAW\u0024CdmirLmEtY\u003D()
  {
    if (true)
      goto label_2;
label_1:
    return (uint) ((int) this.\u0023\u003DzOsmxM1I\u003D[3] << 16 /*0x10*/ | (int) this.\u0023\u003DzOsmxM1I\u003D[1] | (int) this.\u0023\u003DzOsmxM1I\u003D[0] << 8 | (int) this.\u0023\u003DzOsmxM1I\u003D[2] << 24);
label_2:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(4);
    goto label_1;
  }

  public long \u0023\u003Dzb3l5waL5gC9L0nviyBJN4cjZoMMnmnbNEBqQpfWKrZA5()
  {
    if (true)
      goto label_3;
label_1:
    byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_4;
label_2:
    byte[] numArray;
    return (long) (uint) ((int) numArray[7] << 8 | (int) numArray[2] << 24 | (int) numArray[0] | (int) numArray[1] << 16 /*0x10*/) | (long) ((int) numArray[5] << 24 | (int) numArray[6] << 16 /*0x10*/ | (int) numArray[4] | (int) numArray[3] << 8) << 32 /*0x20*/;
label_4:
    numArray = zOsmxM1I;
    goto label_2;
label_3:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(8);
    goto label_1;
  }

  public ulong \u0023\u003DzupTKwywQD3eCKUFCHATiZVQljTxNxYEipxmWOqYwLZft()
  {
    if (true)
      goto label_3;
label_1:
    byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_4;
label_2:
    byte[] numArray;
    return (ulong) ((uint) ((int) numArray[2] << 16 /*0x10*/ | (int) numArray[5] << 24 | (int) numArray[4] << 8) | (uint) numArray[6]) | (ulong) ((int) numArray[1] << 16 /*0x10*/ | (int) numArray[0] | (int) numArray[7] << 24 | (int) numArray[3] << 8) << 32 /*0x20*/;
label_4:
    numArray = zOsmxM1I;
    goto label_2;
label_3:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(8);
    goto label_1;
  }

  public short \u0023\u003Dz__M6PUksX2dom8vefpdTzjU\u003D()
  {
    if (true)
      goto label_3;
label_1:
    byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_4;
label_2:
    byte[] numArray;
    return (short) ((int) numArray[0] << 8 | (int) numArray[1]);
label_4:
    numArray = zOsmxM1I;
    goto label_2;
label_3:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(2);
    goto label_1;
  }

  public ushort \u0023\u003DzQTISujkPa6k316nRAt0TKnpLPuQF8G1pcfSX_kgMKXJq()
  {
    if (true)
      goto label_3;
label_1:
    byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_4;
label_2:
    byte[] numArray;
    return (ushort) ((uint) numArray[1] | (uint) numArray[0] << 8);
label_4:
    numArray = zOsmxM1I;
    goto label_2;
label_3:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(2);
    goto label_1;
  }

  private byte[] \u0023\u003DzxKOTDKEg72cNktHfWnfLr5hJMOzz()
  {
    byte[] zL67ogXm = this.\u0023\u003DzL67ogXM\u003D;
    if (true)
      goto label_2;
label_1:
    byte[] numArray1;
    if (numArray1 == null)
    {
      byte[] numArray2 = new byte[16 /*0x10*/];
      if (true)
        goto label_5;
label_4:
      if (true)
      {
        this.\u0023\u003DzL67ogXM\u003D = numArray2;
        goto label_7;
      }
      goto label_7;
label_5:
      numArray1 = numArray2;
      goto label_4;
    }
label_7:
    return numArray1;
label_2:
    numArray1 = zL67ogXm;
    goto label_1;
  }

  public float \u0023\u003Dzyvu63dNrVu98\u0024M5PccNKDiIZAdylf7\u0024jXPrniJgRFDYY()
  {
    if (true)
      goto label_4;
label_1:
    byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_5;
label_2:
    byte[] numArray1 = this.\u0023\u003DzxKOTDKEg72cNktHfWnfLr5hJMOzz();
    if (true)
      goto label_6;
label_3:
    byte[] numArray2;
    byte[] numArray3;
    numArray2[1] = numArray3[1];
    numArray2[3] = numArray3[0];
    numArray2[2] = numArray3[2];
    numArray2[0] = numArray3[3];
    return this.\u0023\u003DzlcJRDHBdElsMeyoSbO5OnXLSGUVVIYofKQ\u003D\u003D(numArray2).ReadSingle();
label_6:
    numArray2 = numArray1;
    goto label_3;
label_5:
    numArray3 = zOsmxM1I;
    goto label_2;
label_4:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(4);
    goto label_1;
  }

  public double \u0023\u003Dz62LUMZ99maKmgXaJssqi4\u00247izING()
  {
    if (true)
      goto label_4;
label_1:
    byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_5;
label_2:
    byte[] numArray1 = this.\u0023\u003DzxKOTDKEg72cNktHfWnfLr5hJMOzz();
    if (true)
      goto label_6;
label_3:
    byte[] numArray2;
    byte[] numArray3;
    numArray2[5] = numArray3[1];
    numArray2[2] = numArray3[4];
    numArray2[0] = numArray3[2];
    numArray2[3] = numArray3[3];
    numArray2[7] = numArray3[0];
    numArray2[4] = numArray3[6];
    numArray2[1] = numArray3[5];
    numArray2[6] = numArray3[7];
    return this.\u0023\u003DzlcJRDHBdElsMeyoSbO5OnXLSGUVVIYofKQ\u003D\u003D(numArray2).ReadDouble();
label_6:
    numArray2 = numArray1;
    goto label_3;
label_5:
    numArray3 = zOsmxM1I;
    goto label_2;
label_4:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(8);
    goto label_1;
  }

  public Decimal \u0023\u003DzsyqBbL6CAGIaXXgAXM03_4MefoGtV5f3w5G6i00rizAN()
  {
    if (true)
      goto label_3;
label_1:
    byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_4;
label_2:
    byte[] numArray1 = this.\u0023\u003DzxKOTDKEg72cNktHfWnfLr5hJMOzz();
    byte[] numArray2;
    numArray1[14] = numArray2[11];
    numArray1[5] = numArray2[12];
    numArray1[7] = numArray2[9];
    numArray1[6] = numArray2[1];
    numArray1[10] = numArray2[8];
    numArray1[11] = numArray2[10];
    numArray1[8] = numArray2[3];
    numArray1[0] = numArray2[14];
    numArray1[4] = numArray2[15];
    numArray1[3] = numArray2[13];
    numArray1[1] = numArray2[2];
    numArray1[2] = numArray2[6];
    numArray1[15] = numArray2[7];
    numArray1[9] = numArray2[4];
    numArray1[12] = numArray2[0];
    numArray1[13] = numArray2[5];
    return \u0023\u003Dqymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po\u003D.\u0023\u003Dz_wr3TCofPdhgFC7emWjlctJSrBmA8fRpJw\u003D\u003D(numArray1);
label_4:
    numArray2 = zOsmxM1I;
    goto label_2;
label_3:
    this.\u0023\u003Dz31zFeEVTyoL3efDL4hm6b1ESAzPwguUbqw\u003D\u003D(16 /*0x10*/);
    goto label_1;
  }

  private BinaryReader \u0023\u003DzlcJRDHBdElsMeyoSbO5OnXLSGUVVIYofKQ\u003D\u003D(byte[] _param1)
  {
    MemoryStream zzUcMxbo = this.\u0023\u003DzzUCMxbo\u003D;
    if (true)
      goto label_3;
label_1:
    BinaryReader zjsRrUjg = this.\u0023\u003DzjsRRUjg\u003D;
    if (true)
      goto label_4;
label_2:
    MemoryStream memoryStream1;
    BinaryReader binaryReader;
    if (memoryStream1 == null)
    {
      MemoryStream memoryStream2 = new MemoryStream(8);
      if (true)
        goto label_7;
label_6:
      this.\u0023\u003DzzUCMxbo\u003D = memoryStream2;
      this.\u0023\u003DzjsRRUjg\u003D = binaryReader = new BinaryReader((Stream) memoryStream1);
      goto label_9;
label_7:
      memoryStream1 = memoryStream2;
      goto label_6;
    }
    binaryReader.BaseStream.Position = 0L;
label_9:
    ((Stream) memoryStream1).Write(_param1, 0, _param1.Length);
    ((Stream) memoryStream1).Position = 0L;
    return binaryReader;
label_4:
    binaryReader = zjsRrUjg;
    goto label_2;
label_3:
    memoryStream1 = zzUcMxbo;
    goto label_1;
  }
}
