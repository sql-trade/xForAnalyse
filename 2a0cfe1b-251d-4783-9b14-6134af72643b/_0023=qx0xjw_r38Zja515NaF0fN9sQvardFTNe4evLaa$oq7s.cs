// Decompiled with JetBrains decompiler
// Type: #=qx0xjw_r38Zja515NaF0fN9sQvardFTNe4evLaa$oq7s=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.IO;

#nullable disable
internal sealed class \u0023\u003Dqx0xjw_r38Zja515NaF0fN9sQvardFTNe4evLaa\u0024oq7s\u003D : Stream
{
  private bool \u0023\u003Dzv_DK75M\u003D;
  private Stream \u0023\u003DzOsmxM1I\u003D;
  private \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D[] \u0023\u003DzAElFq6M\u003D;
  private \u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D \u0023\u003DzhBh6D88\u003D;
  private \u0023\u003DqNg8xGcasstntUwMAs6FO9MSukM5tcArwD4BKmtMjWQo\u003D \u0023\u003DzsIRkzxg\u003D;
  private \u0023\u003DqqAhxA0LYv9rzu6rSR8nkJ_sx217qu42N2yhQDqKp2aQ\u003D \u0023\u003DzQvRsjjA\u003D;
  private bool \u0023\u003DzlrX5m0o\u003D;
  private byte[] \u0023\u003DzDnwpn_c\u003D;
  private int \u0023\u003DzZ04UAGU\u003D;
  private int \u0023\u003DzL67ogXM\u003D;

  public \u0023\u003Dqx0xjw_r38Zja515NaF0fN9sQvardFTNe4evLaa\u0024oq7s\u003D(
    Stream _param1,
    \u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D _param2 = null,
    \u0023\u003DqNg8xGcasstntUwMAs6FO9MSukM5tcArwD4BKmtMjWQo\u003D _param3 = null,
    bool _param4 = false)
  {
    Stream stream = _param1;
    if (true)
      goto label_5;
label_1:
    int num = _param4 ? 1 : 0;
    if (true)
      goto label_6;
label_2:
    \u0023\u003DqNg8xGcasstntUwMAs6FO9MSukM5tcArwD4BKmtMjWQo\u003D m5tcArwD4BkmtMjWqo = _param3;
    if (true)
      goto label_7;
label_3:
    this.\u0023\u003DzhBh6D88\u003D = _param2;
    if (this.\u0023\u003DzhBh6D88\u003D == null)
      this.\u0023\u003DzhBh6D88\u003D = \u0023\u003DqUSML4YR8F0Ew1mAViTHhSvrTDRIEj8RogRNR4cNaYL8\u003D.\u0023\u003DzBYk38emeAp5OLuQsS8rSR0XGuuFNpamB34G3xfs\u003D();
    if (this.\u0023\u003DzhBh6D88\u003D.\u0023\u003Dz2pmBKWm6xAyf5kqOLhpfG58sSa4QILhB1agog7s\u003D() == 0)
      throw new ArgumentException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622394));
    if (this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzZMV\u0024LXT06EaUPuQ4sX6i6U7ggdUA0iVc5g\u003D\u003D() == 0)
      throw new ArgumentException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622394));
    if (!this.\u0023\u003DzOsmxM1I\u003D.CanRead)
      throw new ArgumentException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622700));
    if (this.\u0023\u003DzOsmxM1I\u003D.CanSeek)
      return;
    throw new ArgumentException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622700));
label_7:
    this.\u0023\u003DzsIRkzxg\u003D = m5tcArwD4BkmtMjWqo;
    goto label_3;
label_6:
    this.\u0023\u003Dzv_DK75M\u003D = num != 0;
    goto label_2;
label_5:
    this.\u0023\u003DzOsmxM1I\u003D = stream;
    goto label_1;
  }

  private void \u0023\u003Dz_q5n_VQdkEmPVR\u0024e3vGKhlrzLVB0()
  {
    if (this.\u0023\u003DzlrX5m0o\u003D)
      return;
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D[] l5pWoNvVzgGexRezIArray = new \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D[this.\u0023\u003DzhBh6D88\u003D.\u0023\u003Dz2pmBKWm6xAyf5kqOLhpfG58sSa4QILhB1agog7s\u003D()];
    if (true)
      goto label_4;
label_2:
    int index;
    if (true)
      index = 0;
    while (index < this.\u0023\u003DzhBh6D88\u003D.\u0023\u003Dz2pmBKWm6xAyf5kqOLhpfG58sSa4QILhB1agog7s\u003D())
    {
      this.\u0023\u003DzAElFq6M\u003D[index] = new \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D();
      int num = index + 1;
      if (true)
        index = num;
    }
    if (this.\u0023\u003DzsIRkzxg\u003D != null)
      this.\u0023\u003DzQvRsjjA\u003D = this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzmOcLzigk1Bvc2AcfQY56MWjgu\u00241BIKLPqODpWqg\u003D(this.\u0023\u003DzhBh6D88\u003D);
    this.\u0023\u003DzlrX5m0o\u003D = true;
    return;
label_4:
    this.\u0023\u003DzAElFq6M\u003D = l5pWoNvVzgGexRezIArray;
    goto label_2;
  }

  protected virtual void Dispose(bool _param1)
  {
    try
    {
      if (!_param1 || this.\u0023\u003Dzv_DK75M\u003D)
        return;
      this.\u0023\u003DzOsmxM1I\u003D.Close();
    }
    finally
    {
      int num = _param1 ? 1 : 0;
      if (true)
        goto label_5;
label_4:
label_5:
      base.Dispose(num != 0);
      goto label_4;
    }
  }

  public virtual bool CanRead => true;

  public virtual bool CanSeek => true;

  public virtual bool CanWrite => false;

  public virtual long Length
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzOsmxM1I\u003D.Length;
    }
  }

  public virtual void SetLength(long _param1) => throw new NotSupportedException();

  public virtual void Write(byte[] _param1, int _param2, int _param3)
  {
    throw new NotSupportedException();
  }

  public virtual void Flush()
  {
  }

  public virtual long Position
  {
    get
    {
      if (true)
        ;
      long position = this.\u0023\u003DzOsmxM1I\u003D.Position;
      if (true)
        ;
      int zZ04Uagu = this.\u0023\u003DzZ04UAGU\u003D;
      if (true)
        ;
      int zL67ogXm = this.\u0023\u003DzL67ogXM\u003D;
      long num = (long) (zZ04Uagu - zL67ogXm);
      return position + num;
    }
    set
    {
      if (true)
        ;
      long num = value;
      if (true)
        ;
      base.Seek(num, (SeekOrigin) 0);
      if (false)
        ;
    }
  }

  private int \u0023\u003DzHWf3plM\u0024fnhhbrywpncxDAE\u003D(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    int num1 = this.\u0023\u003DzL67ogXM\u003D - this.\u0023\u003DzZ04UAGU\u003D;
    if (true)
      goto label_2;
label_1:
    int num2;
    if (num2 <= 0)
      return 0;
    if (num2 > _param3)
    {
      int num3 = _param3;
      if (true)
        num2 = num3;
    }
    byte[] zDnwpnC = this.\u0023\u003DzDnwpn_c\u003D;
    int zZ04Uagu = this.\u0023\u003DzZ04UAGU\u003D;
    byte[] dst = _param1;
    int dstOffset = _param2;
    int count = num2;
    if (true)
      goto label_9;
label_8:
    this.\u0023\u003DzZ04UAGU\u003D += num2;
    return num2;
label_9:
    Buffer.BlockCopy((Array) zDnwpnC, zZ04Uagu, (Array) dst, dstOffset, count);
    goto label_8;
label_2:
    num2 = num1;
    goto label_1;
  }

  private void \u0023\u003DzTB6MQFYsBU9IMkTfaF\u0024FnZU\u003D(int _param1)
  {
    int position = (int) this.\u0023\u003DzOsmxM1I\u003D.Position;
    if (true)
      goto label_2;
label_1:
    int num1;
    if ((long) num1 >= this.\u0023\u003DzOsmxM1I\u003D.Length)
      return;
    int num2 = num1 + _param1;
    if (true)
      goto label_6;
label_4:
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D[] zAelFq6M = this.\u0023\u003DzAElFq6M\u003D;
    if (true)
      goto label_7;
label_5:
    int index1;
    if (true)
      index1 = 0;
    int num3;
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D[] l5pWoNvVzgGexRezIArray;
    for (; index1 < l5pWoNvVzgGexRezIArray.Length; ++index1)
    {
      \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI1 = l5pWoNvVzgGexRezIArray[index1];
      if (true)
        goto label_12;
label_10:
      \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI2;
      if (l5pWoNvVzgGexRezI2.\u0023\u003DzOsmxM1I\u003D <= num1 && l5pWoNvVzgGexRezI2.\u0023\u003DzAElFq6M\u003D >= num3)
      {
        byte[] zvDk75M = l5pWoNvVzgGexRezI2.\u0023\u003Dzv_DK75M\u003D;
        if (true)
          goto label_15;
label_14:
        this.\u0023\u003DzL67ogXM\u003D = l5pWoNvVzgGexRezI2.\u0023\u003DzAElFq6M\u003D - l5pWoNvVzgGexRezI2.\u0023\u003DzOsmxM1I\u003D;
        this.\u0023\u003DzZ04UAGU\u003D = num1 - l5pWoNvVzgGexRezI2.\u0023\u003DzOsmxM1I\u003D;
        this.\u0023\u003DzOsmxM1I\u003D.Position = (long) l5pWoNvVzgGexRezI2.\u0023\u003DzAElFq6M\u003D;
        l5pWoNvVzgGexRezI2.\u0023\u003DzhBh6D88\u003D = DateTime.UtcNow;
        return;
label_15:
        this.\u0023\u003DzDnwpn_c\u003D = zvDk75M;
        goto label_14;
      }
      continue;
label_12:
      l5pWoNvVzgGexRezI2 = l5pWoNvVzgGexRezI1;
      goto label_10;
    }
    int index2 = 0;
    DateTime zhBh6D88 = this.\u0023\u003DzAElFq6M\u003D[0].\u0023\u003DzhBh6D88\u003D;
    for (int index3 = 1; index3 < this.\u0023\u003DzAElFq6M\u003D.Length; ++index3)
    {
      if (this.\u0023\u003DzAElFq6M\u003D[index3].\u0023\u003DzhBh6D88\u003D < zhBh6D88)
        index2 = index3;
    }
    \u0023\u003Dqmsg2TM7PTsv3yHUY4_x0QnAfq0L5pWONvVzgGEXRezI\u003D l5pWoNvVzgGexRezI = this.\u0023\u003DzAElFq6M\u003D[index2];
    if (l5pWoNvVzgGexRezI.\u0023\u003Dzv_DK75M\u003D == null)
      l5pWoNvVzgGexRezI.\u0023\u003Dzv_DK75M\u003D = new byte[this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzAl9LUuaVGVBIPfreew2Vefaf7k5xedMiui\u0024u8i1U8d8p()];
    int num4 = num1;
    int num5 = this.\u0023\u003DzA9TRkQPystMt4P9qlclh3WjqSTEY(num1);
    if (num5 < 0)
      num5 = 0;
    int num6 = num5 + this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzAl9LUuaVGVBIPfreew2Vefaf7k5xedMiui\u0024u8i1U8d8p();
    if (this.\u0023\u003DzQvRsjjA\u003D == null || !this.\u0023\u003DzQvRsjjA\u003D.\u0023\u003DzPH5ndEAd1KdZ1sE72Rc_VYQ\u003D(num5, ref l5pWoNvVzgGexRezI))
    {
      l5pWoNvVzgGexRezI.\u0023\u003DzOsmxM1I\u003D = num5;
      l5pWoNvVzgGexRezI.\u0023\u003DzhBh6D88\u003D = DateTime.UtcNow;
      this.\u0023\u003DzDnwpn_c\u003D = l5pWoNvVzgGexRezI.\u0023\u003Dzv_DK75M\u003D;
      this.\u0023\u003DzOsmxM1I\u003D.Position = (long) num5;
      this.\u0023\u003DzL67ogXM\u003D = this.\u0023\u003DzOsmxM1I\u003D.Read(this.\u0023\u003DzDnwpn_c\u003D, 0, num6 - num5);
      this.\u0023\u003DzZ04UAGU\u003D = num4 - num5;
      l5pWoNvVzgGexRezI.\u0023\u003DzAElFq6M\u003D = num5 + this.\u0023\u003DzL67ogXM\u003D;
      if (this.\u0023\u003DzQvRsjjA\u003D == null)
        return;
      this.\u0023\u003DzQvRsjjA\u003D.\u0023\u003Dz_NAG0mj12d1dKp2fVK4Jtpo\u003D(l5pWoNvVzgGexRezI);
      return;
    }
    this.\u0023\u003DzDnwpn_c\u003D = l5pWoNvVzgGexRezI.\u0023\u003Dzv_DK75M\u003D;
    this.\u0023\u003DzL67ogXM\u003D = l5pWoNvVzgGexRezI.\u0023\u003DzAElFq6M\u003D - num5;
    this.\u0023\u003DzOsmxM1I\u003D.Position = (long) l5pWoNvVzgGexRezI.\u0023\u003DzAElFq6M\u003D;
    this.\u0023\u003DzZ04UAGU\u003D = num4 - num5;
    return;
label_7:
    l5pWoNvVzgGexRezIArray = zAelFq6M;
    goto label_5;
label_6:
    num3 = num2;
    goto label_4;
label_2:
    num1 = position;
    goto label_1;
  }

  private int \u0023\u003DzA9TRkQPystMt4P9qlclh3WjqSTEY(int _param1)
  {
    int num1 = _param1;
    if (true)
      ;
    int num2 = _param1;
    if (true)
      ;
    if (true)
      ;
    int num3 = this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzAl9LUuaVGVBIPfreew2Vefaf7k5xedMiui\u0024u8i1U8d8p();
    int num4 = num2 % num3;
    return num1 - num4;
  }

  public virtual int Read(byte[] _param1, int _param2, int _param3)
  {
    if (_param1 == null)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621951));
    if (_param2 < 0)
      throw new ArgumentOutOfRangeException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621900));
    if (_param3 < 0)
      throw new ArgumentOutOfRangeException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621905));
    if (_param1.Length - _param2 < _param3)
      throw new ArgumentException();
    int num1 = _param2;
    if (true)
      goto label_11;
label_9:
    int num2 = this.\u0023\u003DzHWf3plM\u0024fnhhbrywpncxDAE\u003D(_param1, _param2, _param3);
    if (true)
      goto label_12;
label_10:
    int num3;
    if (num3 == _param3)
      return num3;
    int num4 = num3;
    if (true)
      goto label_16;
label_15:
    if (num3 > 0)
    {
      int num5 = _param3 - num3;
      if (true)
        goto label_19;
label_18:
      _param2 += num3;
      goto label_20;
label_19:
      _param3 = num5;
      goto label_18;
    }
label_20:
    this.\u0023\u003DzZ04UAGU\u003D = this.\u0023\u003DzL67ogXM\u003D = 0;
    this.\u0023\u003Dz_q5n_VQdkEmPVR\u0024e3vGKhlrzLVB0();
    int num6;
    int num7;
    if (_param3 >= this.\u0023\u003DzhBh6D88\u003D.\u0023\u003DzAl9LUuaVGVBIPfreew2Vefaf7k5xedMiui\u0024u8i1U8d8p())
    {
      if (this.\u0023\u003DzQvRsjjA\u003D == null)
        return this.\u0023\u003DzOsmxM1I\u003D.Read(_param1, _param2, _param3) + num7;
      int num8 = (int) this.\u0023\u003DzOsmxM1I\u003D.Position - num7;
      int num9;
      if (this.\u0023\u003DzQvRsjjA\u003D.\u0023\u003DzpXvNuF8OVTuYuhS8NQ\u003D\u003D(num8, _param1, num6, _param3 + num7, out num9))
      {
        this.\u0023\u003DzOsmxM1I\u003D.Seek((long) (num9 - num7), (SeekOrigin) 1);
        return num9;
      }
      num9 = this.\u0023\u003DzOsmxM1I\u003D.Read(_param1, _param2, _param3);
      if (num9 != 0)
        this.\u0023\u003DzQvRsjjA\u003D.\u0023\u003DzmFX9kqr2K7yZOiZHGfpsPlu8\u00242PFYA\u0024qN7LIdNg\u003D(num8, _param1, num6, num9 + num7, num9 < _param3);
      return num9 + num7;
    }
    this.\u0023\u003DzTB6MQFYsBU9IMkTfaF\u0024FnZU\u003D(_param3);
    return this.\u0023\u003DzHWf3plM\u0024fnhhbrywpncxDAE\u003D(_param1, _param2, _param3) + num7;
label_16:
    num7 = num4;
    goto label_15;
label_12:
    num3 = num2;
    goto label_10;
label_11:
    num6 = num1;
    goto label_9;
  }

  public virtual long Seek(long _param1, SeekOrigin _param2)
  {
    if (this.\u0023\u003DzL67ogXM\u003D - this.\u0023\u003DzZ04UAGU\u003D > 0 && _param2 == 1)
    {
      long num = _param1 - (long) (this.\u0023\u003DzL67ogXM\u003D - this.\u0023\u003DzZ04UAGU\u003D);
      if (true)
        _param1 = num;
    }
    long position = base.Position;
    if (true)
      goto label_6;
label_4:
    long num1 = this.\u0023\u003DzOsmxM1I\u003D.Seek(_param1, _param2);
    if (true)
      goto label_7;
label_5:
    long num2;
    long num3;
    this.\u0023\u003DzZ04UAGU\u003D = (int) (num2 - (num3 - (long) this.\u0023\u003DzZ04UAGU\u003D));
    if (0 <= this.\u0023\u003DzZ04UAGU\u003D && this.\u0023\u003DzZ04UAGU\u003D < this.\u0023\u003DzL67ogXM\u003D)
      this.\u0023\u003DzOsmxM1I\u003D.Seek((long) (this.\u0023\u003DzL67ogXM\u003D - this.\u0023\u003DzZ04UAGU\u003D), (SeekOrigin) 1);
    else
      this.\u0023\u003DzZ04UAGU\u003D = this.\u0023\u003DzL67ogXM\u003D = 0;
    return num2;
label_7:
    num2 = num1;
    goto label_5;
label_6:
    num3 = position;
    goto label_4;
  }
}
