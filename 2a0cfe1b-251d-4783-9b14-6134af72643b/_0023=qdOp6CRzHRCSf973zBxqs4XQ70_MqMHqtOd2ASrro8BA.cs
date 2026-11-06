// Decompiled with JetBrains decompiler
// Type: #=qdOp6CRzHRCSf973zBxqs4XQ70_MqMHqtOd2ASrro8BA=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.IO;
using System.Security.Cryptography;

#nullable disable
internal sealed class \u0023\u003DqdOp6CRzHRCSf973zBxqs4XQ70_MqMHqtOd2ASrro8BA\u003D : Stream
{
  private int \u0023\u003Dzv_DK75M\u003D;
  private int \u0023\u003DzOsmxM1I\u003D;
  private int \u0023\u003DzAElFq6M\u003D;
  private Stream \u0023\u003DzhBh6D88\u003D;
  private \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D \u0023\u003DzsIRkzxg\u003D;
  private int \u0023\u003DzQvRsjjA\u003D;
  private bool \u0023\u003DzlrX5m0o\u003D;
  private bool \u0023\u003DzDnwpn_c\u003D;
  private bool \u0023\u003DzZ04UAGU\u003D;
  private byte[] \u0023\u003DzL67ogXM\u003D;
  private int \u0023\u003DzzUCMxbo\u003D;
  private byte[] \u0023\u003DzjsRRUjg\u003D;
  private int \u0023\u003DzgAhCYyk\u003D;
  private int \u0023\u003DzSCTTv\u0024Y\u003D;
  private int \u0023\u003DzNI_tTmU\u003D;
  private bool \u0023\u003DzKviS3BM\u003D;

  public \u0023\u003DqdOp6CRzHRCSf973zBxqs4XQ70_MqMHqtOd2ASrro8BA\u003D(
    Stream _param1,
    \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D _param2)
  {
    if (_param1 == null)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622700));
    if (_param2 == null)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622711));
    Stream stream = _param1;
    if (true)
      goto label_7;
label_5:
    \u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D ag11ryi4o2Vum3dp7WbJp8U = _param2;
    if (true)
      goto label_8;
label_6:
    if (this.\u0023\u003DzhBh6D88\u003D.Length < 4L)
      throw new InvalidOperationException();
    if (false)
      return;
    this.\u0023\u003DzGUD4inr4C4hbZ2jqSixqY80RzxKLThaxf8Nv1uE\u003D();
    return;
label_8:
    this.\u0023\u003DzsIRkzxg\u003D = ag11ryi4o2Vum3dp7WbJp8U;
    goto label_6;
label_7:
    this.\u0023\u003DzhBh6D88\u003D = stream;
    goto label_5;
  }

  private void \u0023\u003DzGUD4inr4C4hbZ2jqSixqY80RzxKLThaxf8Nv1uE\u003D()
  {
    int num1 = this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003Dz9nPncFm3EG2SxfRwi9oRRCfjr3F03Hf3atqy30osRUxhEaHgDxg5d5wFx4Pf0c3LllaiJl6sUDfjWZqxrQ\u003D\u003D();
    if (true)
      goto label_4;
label_1:
    byte[] numArray = new byte[this.\u0023\u003DzzUCMxbo\u003D];
    if (true)
      goto label_5;
label_2:
    int num2 = this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzyWFI3vSTNmOhc14Xyi1erNdl2kN0y6Px5NBgvJtAFTpmpTrw4hH9aHQTyyz0MFI25KVkC\u0024c\u003D();
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzjsRRUjg\u003D = new byte[this.\u0023\u003DzNI_tTmU\u003D];
    return;
label_6:
    this.\u0023\u003DzNI_tTmU\u003D = num2;
    goto label_3;
label_5:
    this.\u0023\u003DzL67ogXM\u003D = numArray;
    goto label_2;
label_4:
    this.\u0023\u003DzzUCMxbo\u003D = num1;
    goto label_1;
  }

  public virtual bool CanRead => true;

  public virtual bool CanSeek => true;

  public virtual bool CanWrite => false;

  public virtual long Length
  {
    get
    {
      if (true)
        goto label_2;
label_1:
      return (long) this.\u0023\u003Dzv_DK75M\u003D;
label_2:
      this.\u0023\u003DzP_GUyk2kJvFmgyv09alC592ECWEOL7wsbZUL9H8\u003D();
      goto label_1;
    }
  }

  public virtual long Position
  {
    get
    {
      if (true)
        ;
      int zQvRsjjA = this.\u0023\u003DzQvRsjjA\u003D;
      if (true)
        ;
      int zNiTTmU = this.\u0023\u003DzNI_tTmU\u003D;
      int num = zQvRsjjA * zNiTTmU;
      if (true)
        ;
      int zSctTvY = this.\u0023\u003DzSCTTv\u0024Y\u003D;
      return (long) (num + zSctTvY);
    }
    set
    {
      int num1 = (int) value / this.\u0023\u003DzNI_tTmU\u003D;
      if (true)
        goto label_4;
label_1:
      int num2 = (int) value % this.\u0023\u003DzNI_tTmU\u003D;
      if (true)
        goto label_5;
label_2:
      int num3;
      if (this.\u0023\u003DzQvRsjjA\u003D == num3)
        return;
      int num4 = num3;
      if (true)
        goto label_8;
label_7:
      this.\u0023\u003DzZ04UAGU\u003D = true;
      this.\u0023\u003DzlrX5m0o\u003D = false;
      return;
label_8:
      this.\u0023\u003DzQvRsjjA\u003D = num4;
      goto label_7;
label_5:
      this.\u0023\u003DzSCTTv\u0024Y\u003D = num2;
      goto label_2;
label_4:
      num3 = num1;
      goto label_1;
    }
  }

  public virtual long Seek(long _param1, SeekOrigin _param2)
  {
    SeekOrigin seekOrigin = _param2;
    if (true)
      ;
    switch ((int) seekOrigin)
    {
      case 0:
        if (true)
          ;
        long num = _param1;
        if (true)
          ;
        base.Position = num;
        break;
      case 1:
        base.Position += _param1;
        break;
      case 2:
        base.Position = base.Length + _param1;
        break;
    }
    return base.Position;
  }

  public virtual void SetLength(long _param1) => throw new NotSupportedException();

  public virtual int Read(byte[] _param1, int _param2, int _param3)
  {
    if (_param2 < 0)
      throw new ArgumentOutOfRangeException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622663));
    if (_param3 < 0)
      throw new ArgumentOutOfRangeException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622676));
    if (_param1.Length - _param2 < _param3)
      throw new ArgumentException();
    if (_param3 == 0)
      return 0;
    int num1 = _param3;
    if (true)
      goto label_11;
label_9:
    int num2 = _param2;
    if (true)
      goto label_12;
label_10:
    int count1;
    int dstOffset;
    if (this.\u0023\u003DzSCTTv\u0024Y\u003D < this.\u0023\u003DzNI_tTmU\u003D)
    {
      if (true)
        goto label_16;
label_14:
      int num3 = this.\u0023\u003DzgAhCYyk\u003D - this.\u0023\u003DzSCTTv\u0024Y\u003D;
      if (true)
        goto label_17;
label_15:
      int count2;
      if (count2 <= _param3)
      {
        Buffer.BlockCopy((Array) this.\u0023\u003DzjsRRUjg\u003D, this.\u0023\u003DzSCTTv\u0024Y\u003D, (Array) _param1, _param2, count2);
        this.\u0023\u003DzSCTTv\u0024Y\u003D = this.\u0023\u003DzgAhCYyk\u003D;
        if (this.\u0023\u003DzDnwpn_c\u003D)
          return count2;
        count1 -= count2;
        dstOffset += count2;
        goto label_22;
      }
      Buffer.BlockCopy((Array) this.\u0023\u003DzjsRRUjg\u003D, this.\u0023\u003DzSCTTv\u0024Y\u003D, (Array) _param1, _param2, _param3);
      this.\u0023\u003DzSCTTv\u0024Y\u003D += _param3;
      return _param3;
label_17:
      count2 = num3;
      goto label_15;
label_16:
      this.\u0023\u003Dz75x8L3_MlresY99VuNyY9gqiukxTOCMZatx4nHg\u003D();
      goto label_14;
    }
label_22:
    if (this.\u0023\u003DzDnwpn_c\u003D)
      return _param3 - count1;
    while (count1 > 0)
    {
      this.\u0023\u003Dzd1iIbwn1ZBhrKAl\u0024JcG6XA3V_sdMkjQ_oloE4LfzmPEz();
      if (this.\u0023\u003DzDnwpn_c\u003D)
        return _param3 - count1;
      int zgAhCyyk = this.\u0023\u003DzgAhCYyk\u003D;
      if (count1 >= zgAhCyyk)
      {
        Buffer.BlockCopy((Array) this.\u0023\u003DzjsRRUjg\u003D, 0, (Array) _param1, dstOffset, zgAhCyyk);
        dstOffset += zgAhCyyk;
        count1 -= zgAhCyyk;
        this.\u0023\u003DzSCTTv\u0024Y\u003D = zgAhCyyk;
      }
      else
      {
        Buffer.BlockCopy((Array) this.\u0023\u003DzjsRRUjg\u003D, 0, (Array) _param1, dstOffset, count1);
        this.\u0023\u003DzSCTTv\u0024Y\u003D = count1;
        return _param3;
      }
    }
    return _param3;
label_12:
    dstOffset = num2;
    goto label_10;
label_11:
    count1 = num1;
    goto label_9;
  }

  private void \u0023\u003Dz75x8L3_MlresY99VuNyY9gqiukxTOCMZatx4nHg\u003D()
  {
    if (true)
      goto label_2;
label_1:
    if (this.\u0023\u003DzlrX5m0o\u003D)
      return;
    if (true)
      goto label_7;
label_4:
    if (true)
      goto label_8;
label_5:
    int zQvRsjjA = this.\u0023\u003DzQvRsjjA\u003D;
    if (this.\u0023\u003DzZ04UAGU\u003D)
    {
      this.\u0023\u003DzhBh6D88\u003D.Position = (long) (4 + zQvRsjjA * this.\u0023\u003DzzUCMxbo\u003D);
      this.\u0023\u003DzZ04UAGU\u003D = false;
    }
    this.\u0023\u003DzMqCI3_Bkn2tAcH7xuPgQ67u5G7IQhU9Bug\u003D\u003D(zQvRsjjA);
    return;
label_8:
    this.\u0023\u003DzDnwpn_c\u003D = false;
    goto label_5;
label_7:
    this.\u0023\u003DzlrX5m0o\u003D = true;
    goto label_4;
label_2:
    this.\u0023\u003DzP_GUyk2kJvFmgyv09alC592ECWEOL7wsbZUL9H8\u003D();
    goto label_1;
  }

  private void \u0023\u003Dzd1iIbwn1ZBhrKAl\u0024JcG6XA3V_sdMkjQ_oloE4LfzmPEz()
  {
    int num1 = this.\u0023\u003DzQvRsjjA\u003D + 1;
    if (true)
      goto label_2;
label_1:
    int num2;
    if (this.\u0023\u003DzMqCI3_Bkn2tAcH7xuPgQ67u5G7IQhU9Bug\u003D\u003D(num2))
    {
      int num3 = num2;
      if (true)
        goto label_5;
label_4:
      if (true)
      {
        this.\u0023\u003DzSCTTv\u0024Y\u003D = 0;
        goto label_7;
      }
      goto label_7;
label_5:
      this.\u0023\u003DzQvRsjjA\u003D = num3;
      goto label_4;
    }
label_7:
    this.\u0023\u003DzlrX5m0o\u003D = true;
    return;
label_2:
    num2 = num1;
    goto label_1;
  }

  private bool \u0023\u003DzMqCI3_Bkn2tAcH7xuPgQ67u5G7IQhU9Bug\u003D\u003D(int _param1)
  {
    int num1;
    if (true)
      num1 = 0;
    int num2;
    for (; num1 < this.\u0023\u003DzzUCMxbo\u003D; num1 += num2)
    {
      int num3 = this.\u0023\u003DzhBh6D88\u003D.Read(this.\u0023\u003DzL67ogXM\u003D, num1, this.\u0023\u003DzzUCMxbo\u003D - num1);
      if (true)
        goto label_4;
label_3:
      if (num2 == 0)
      {
        if (num1 != 0)
          throw new InvalidOperationException();
        if (true)
          goto label_9;
label_8:
        return false;
label_9:
        this.\u0023\u003DzDnwpn_c\u003D = true;
        goto label_8;
      }
      continue;
label_4:
      num2 = num3;
      goto label_3;
    }
    this.\u0023\u003DzgAhCYyk\u003D = this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzMcp1j9HeFzOJtlfrJ79aMlkKYXTeLciLbkTjBenGOAT6pOmq6v8B9K\u00240TJVdV_I5Pj8GRwllj5snhj4t9wnEJZM\u003D(this.\u0023\u003DzL67ogXM\u003D, 0, this.\u0023\u003DzzUCMxbo\u003D, this.\u0023\u003DzjsRRUjg\u003D, 0, (RandomNumberGenerator) null);
    if (_param1 == this.\u0023\u003DzOsmxM1I\u003D)
      this.\u0023\u003DzgAhCYyk\u003D = this.\u0023\u003DzAElFq6M\u003D;
    return true;
  }

  private void \u0023\u003DzP_GUyk2kJvFmgyv09alC592ECWEOL7wsbZUL9H8\u003D()
  {
    if (this.\u0023\u003DzKviS3BM\u003D)
      return;
    if (this.\u0023\u003DzhBh6D88\u003D.Position != 0L)
    {
      this.\u0023\u003DzhBh6D88\u003D.Position = 0L;
      if (true)
        this.\u0023\u003DzZ04UAGU\u003D = true;
    }
    \u0023\u003DqO5nG5aMfMNDP1dXblTVHOrp1OX1yF7uFi4sTHJGAJIA\u003D ox1yF7uFi4sThjgajia1 = \u0023\u003DqdOp6CRzHRCSf973zBxqs4XQ70_MqMHqtOd2ASrro8BA\u003D.\u0023\u003DzshHNA6jADb9eqPeHyVODo5s\u003D(this.\u0023\u003DzhBh6D88\u003D);
    if (true)
      goto label_7;
label_5:
    \u0023\u003DqO5nG5aMfMNDP1dXblTVHOrp1OX1yF7uFi4sTHJGAJIA\u003D ox1yF7uFi4sThjgajia2;
    int zvDk75M = ox1yF7uFi4sThjgajia2.\u0023\u003Dzv_DK75M\u003D;
    if (true)
      goto label_8;
label_6:
    this.\u0023\u003DzOsmxM1I\u003D = this.\u0023\u003Dzv_DK75M\u003D / this.\u0023\u003DzNI_tTmU\u003D;
    this.\u0023\u003DzAElFq6M\u003D = this.\u0023\u003Dzv_DK75M\u003D % this.\u0023\u003DzNI_tTmU\u003D;
    this.\u0023\u003DzKviS3BM\u003D = true;
    return;
label_8:
    this.\u0023\u003Dzv_DK75M\u003D = zvDk75M;
    goto label_6;
label_7:
    ox1yF7uFi4sThjgajia2 = ox1yF7uFi4sThjgajia1;
    goto label_5;
  }

  private static \u0023\u003DqO5nG5aMfMNDP1dXblTVHOrp1OX1yF7uFi4sTHJGAJIA\u003D \u0023\u003DzshHNA6jADb9eqPeHyVODo5s\u003D(
    Stream _param0)
  {
    \u0023\u003Dq8sJsXUaY4sEeTaUbp_zC90t84hI_sa8nbmM_fFPDo7w\u003D c90t84hISa8nbmMFFpDo7w1 = new \u0023\u003Dq8sJsXUaY4sEeTaUbp_zC90t84hI_sa8nbmM_fFPDo7w\u003D(_param0, 0);
    \u0023\u003Dq8sJsXUaY4sEeTaUbp_zC90t84hI_sa8nbmM_fFPDo7w\u003D c90t84hISa8nbmMFFpDo7w2;
    if (true)
      c90t84hISa8nbmMFFpDo7w2 = c90t84hISa8nbmMFFpDo7w1;
    \u0023\u003DqO5nG5aMfMNDP1dXblTVHOrp1OX1yF7uFi4sTHJGAJIA\u003D ox1yF7uFi4sThjgajia1;
    try
    {
      \u0023\u003Dqymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po\u003D ontITk0sgmJml7Po1 = new \u0023\u003Dqymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po\u003D((\u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D) c90t84hISa8nbmMFFpDo7w2);
      \u0023\u003Dqymjs7edcMk5hP2sF3Dtg62R0AhONt_iTK0sgmJml7Po\u003D ontITk0sgmJml7Po2;
      if (true)
        ontITk0sgmJml7Po2 = ontITk0sgmJml7Po1;
      try
      {
        \u0023\u003DqO5nG5aMfMNDP1dXblTVHOrp1OX1yF7uFi4sTHJGAJIA\u003D ox1yF7uFi4sThjgajia2 = new \u0023\u003DqO5nG5aMfMNDP1dXblTVHOrp1OX1yF7uFi4sTHJGAJIA\u003D(ontITk0sgmJml7Po2.\u0023\u003DzphrsiBpUym_kQb6xfSa4vwy3o5maP2F6NA\u003D\u003D());
        if (true)
          ox1yF7uFi4sThjgajia1 = ox1yF7uFi4sThjgajia2;
      }
      finally
      {
        ((IDisposable) ontITk0sgmJml7Po2).Dispose();
      }
    }
    finally
    {
      c90t84hISa8nbmMFFpDo7w2.Dispose();
    }
    return ox1yF7uFi4sThjgajia1;
  }

  public virtual void Flush()
  {
  }

  public virtual void Write(byte[] _param1, int _param2, int _param3)
  {
    throw new NotSupportedException();
  }
}
