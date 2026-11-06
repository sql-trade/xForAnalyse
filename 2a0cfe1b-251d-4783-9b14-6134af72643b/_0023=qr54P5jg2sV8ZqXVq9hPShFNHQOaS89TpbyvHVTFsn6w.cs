// Decompiled with JetBrains decompiler
// Type: #=qr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Security.Cryptography;

#nullable disable
internal sealed class \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D : 
  SymmetricAlgorithm
{
  private readonly SymmetricAlgorithm[] \u0023\u003Dzv_DK75M\u003D;
  private readonly int \u0023\u003DzOsmxM1I\u003D;

  public \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D(
    params SymmetricAlgorithm[] _param1)
  {
    SymmetricAlgorithm[] symmetricAlgorithmArray = (SymmetricAlgorithm[]) _param1.Clone();
    if (true)
      goto label_2;
label_1:
    SymmetricAlgorithm[] array = _param1;
    Comparison<SymmetricAlgorithm> comparison1 = \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzOsmxM1I\u003D;
    if (comparison1 == null)
    {
      Comparison<SymmetricAlgorithm> comparison2 = new Comparison<SymmetricAlgorithm>(\u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dz21csaDLGHYjeNPhCW79A1WQ\u003D);
      if (false)
      {
        comparison1 = comparison2;
      }
      else
      {
        \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzOsmxM1I\u003D = comparison2;
        comparison1 = comparison2;
      }
    }
    if (true)
      goto label_8;
label_7:
    this.\u0023\u003Dzv_DK75M\u003D = _param1;
    int num = 0;
    foreach (SymmetricAlgorithm symmetricAlgorithm in _param1)
    {
      num += symmetricAlgorithm.KeySize;
      symmetricAlgorithm.Mode = CipherMode.ECB;
      symmetricAlgorithm.Padding = PaddingMode.None;
    }
    this.BlockSizeValue = _param1[_param1.Length - 1].BlockSize;
    this.LegalBlockSizesValue = new KeySizes[1]
    {
      new KeySizes(this.BlockSizeValue, this.BlockSizeValue, 0)
    };
    this.KeySizeValue = num;
    this.LegalKeySizesValue = new KeySizes[1]
    {
      new KeySizes(num, num, 0)
    };
    this.\u0023\u003DzOsmxM1I\u003D = _param1[0].BlockSize;
    this.Mode = CipherMode.ECB;
    this.Padding = PaddingMode.None;
    return;
label_8:
    Array.Sort<SymmetricAlgorithm>(array, comparison1);
    goto label_7;
label_2:
    _param1 = symmetricAlgorithmArray;
    goto label_1;
  }

  public int \u0023\u003DzhQBjdhNAm\u0024ANwsONYjZY2Pg\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzOsmxM1I\u003D;
  }

  public override byte[] IV
  {
    get
    {
      if (true)
        ;
      return base.IV;
    }
    set
    {
      byte[] numArray = (byte[]) value.Clone();
      if (false)
        return;
      this.IVValue = numArray;
    }
  }

  public override ICryptoTransform CreateDecryptor(byte[] _param1, byte[] _param2)
  {
    if (true)
      ;
    byte[] numArray1 = _param1;
    if (true)
      ;
    byte[] numArray2 = _param2;
    if (true)
      ;
    return this.\u0023\u003DzCc8VgJXOaf8\u00245hCH7zaOT2fTWfdqEfZOZEx1w7g\u003D(numArray1, numArray2, false);
  }

  public override ICryptoTransform CreateEncryptor(byte[] _param1, byte[] _param2)
  {
    if (true)
      ;
    byte[] numArray1 = _param1;
    if (true)
      ;
    byte[] numArray2 = _param2;
    if (true)
      ;
    return this.\u0023\u003DzCc8VgJXOaf8\u00245hCH7zaOT2fTWfdqEfZOZEx1w7g\u003D(numArray1, numArray2, true);
  }

  private ICryptoTransform \u0023\u003DzCc8VgJXOaf8\u00245hCH7zaOT2fTWfdqEfZOZEx1w7g\u003D(
    byte[] _param1,
    byte[] _param2,
    bool _param3)
  {
    byte[] numArray1 = _param1;
    if (true)
      ;
    int num = numArray1.Length * 8;
    if (true)
      ;
    int keySize = this.KeySize;
    if (num != keySize)
      throw new ArgumentException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622801), \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622761));
    byte[] numArray2 = _param2;
    if (true)
      ;
    if (numArray2.Length * 8 != this.\u0023\u003DzhQBjdhNAm\u0024ANwsONYjZY2Pg\u003D())
      throw new ArgumentException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622774), \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622735));
    return (ICryptoTransform) new \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003DzOsmxM1I\u003D(this.\u0023\u003Dzv_DK75M\u003D, _param1, _param2, _param3);
  }

  public override void GenerateIV() => throw new NotSupportedException();

  public override void GenerateKey() => throw new NotSupportedException();

  private sealed class \u0023\u003DzOsmxM1I\u003D : ICryptoTransform, IDisposable
  {
    private readonly byte[] \u0023\u003Dzv_DK75M\u003D;
    private readonly byte[] \u0023\u003DzOsmxM1I\u003D;
    private readonly SymmetricAlgorithm[] \u0023\u003DzAElFq6M\u003D;
    private ICryptoTransform[] \u0023\u003DzhBh6D88\u003D;
    private readonly bool \u0023\u003DzsIRkzxg\u003D;
    private readonly int \u0023\u003DzQvRsjjA\u003D;

    public \u0023\u003DzOsmxM1I\u003D(
      SymmetricAlgorithm[] _param1,
      byte[] _param2,
      byte[] _param3,
      bool _param4)
    {
      byte[] numArray1 = _param2;
      if (true)
        goto label_4;
label_1:
      byte[] numArray2 = _param3;
      if (true)
        goto label_5;
label_2:
      SymmetricAlgorithm[] symmetricAlgorithmArray = _param1;
      if (true)
        goto label_6;
label_3:
      this.\u0023\u003DzsIRkzxg\u003D = _param4;
      this.\u0023\u003DzQvRsjjA\u003D = _param1[_param1.Length - 1].BlockSize / 8;
      return;
label_6:
      this.\u0023\u003DzAElFq6M\u003D = symmetricAlgorithmArray;
      goto label_3;
label_5:
      this.\u0023\u003DzOsmxM1I\u003D = numArray2;
      goto label_2;
label_4:
      this.\u0023\u003Dzv_DK75M\u003D = numArray1;
      goto label_1;
    }

    public int InputBlockSize
    {
      get
      {
        if (true)
          ;
        return this.\u0023\u003DzQvRsjjA\u003D;
      }
    }

    public int OutputBlockSize
    {
      get
      {
        if (true)
          ;
        return this.\u0023\u003DzQvRsjjA\u003D;
      }
    }

    public bool CanTransformMultipleBlocks => true;

    public bool CanReuseTransform => true;

    public void Dispose()
    {
      if (this.\u0023\u003DzhBh6D88\u003D == null)
        return;
      ICryptoTransform[] zhBh6D88 = this.\u0023\u003DzhBh6D88\u003D;
      if (true)
        goto label_3;
label_2:
      int index;
      if (true)
        index = 0;
      ICryptoTransform[] cryptoTransformArray;
      for (; index < cryptoTransformArray.Length; ++index)
      {
        ICryptoTransform cryptoTransform1 = cryptoTransformArray[index];
        if (true)
          goto label_8;
label_6:
        ICryptoTransform cryptoTransform2;
        if (cryptoTransform2 != null)
        {
          cryptoTransform2.Dispose();
          continue;
        }
        continue;
label_8:
        cryptoTransform2 = cryptoTransform1;
        goto label_6;
      }
      this.\u0023\u003DzhBh6D88\u003D = (ICryptoTransform[]) null;
      return;
label_3:
      cryptoTransformArray = zhBh6D88;
      goto label_2;
    }

    private void \u0023\u003DzX33bK6h_Rrb7QDnHlquatJmY9nBAnxHY5Q\u003D\u003D()
    {
      SymmetricAlgorithm[] zAelFq6M = this.\u0023\u003DzAElFq6M\u003D;
      if (true)
        goto label_4;
label_1:
      SymmetricAlgorithm[] symmetricAlgorithmArray;
      int length1 = symmetricAlgorithmArray.Length;
      if (true)
        goto label_5;
label_2:
      if (this.\u0023\u003DzhBh6D88\u003D != null)
        return;
      int length2;
      ICryptoTransform[] cryptoTransformArray1 = new ICryptoTransform[length2];
      if (true)
        goto label_8;
label_7:
      int srcOffset = 0;
      ICryptoTransform[] cryptoTransformArray2;
      for (int index = 0; index < length2; ++index)
      {
        SymmetricAlgorithm symmetricAlgorithm = symmetricAlgorithmArray[index];
        int count = symmetricAlgorithm.KeySize / 8;
        byte[] numArray = new byte[count];
        Buffer.BlockCopy((Array) this.\u0023\u003Dzv_DK75M\u003D, srcOffset, (Array) numArray, 0, count);
        srcOffset += count;
        byte[] rgbIV = new byte[symmetricAlgorithm.BlockSize / 8];
        ICryptoTransform cryptoTransform = this.\u0023\u003DzsIRkzxg\u003D ? symmetricAlgorithm.CreateEncryptor(numArray, rgbIV) : symmetricAlgorithm.CreateDecryptor(numArray, rgbIV);
        cryptoTransformArray2[index] = cryptoTransform;
      }
      this.\u0023\u003DzhBh6D88\u003D = cryptoTransformArray2;
      return;
label_8:
      cryptoTransformArray2 = cryptoTransformArray1;
      goto label_7;
label_5:
      length2 = length1;
      goto label_2;
label_4:
      symmetricAlgorithmArray = zAelFq6M;
      goto label_1;
    }

    public byte[] TransformFinalBlock(byte[] _param1, int _param2, int _param3)
    {
      byte[] numArray1 = new byte[_param3];
      if (true)
        goto label_2;
label_1:
      byte[] numArray2;
      this.TransformBlock(_param1, _param2, _param3, numArray2, 0);
      return numArray2;
label_2:
      numArray2 = numArray1;
      goto label_1;
    }

    public int TransformBlock(
      byte[] _param1,
      int _param2,
      int _param3,
      byte[] _param4,
      int _param5)
    {
      byte[] src = _param1;
      int srcOffset = _param2;
      byte[] dst = _param4;
      int dstOffset = _param5;
      int count = _param3;
      if (true)
        goto label_3;
label_1:
      if (true)
        goto label_4;
label_2:
      if (this.\u0023\u003DzsIRkzxg\u003D)
      {
        byte[] numArray = _param4;
        int num1 = _param5;
        int num2 = _param3;
        if (true)
          this.\u0023\u003Dz\u0024zVryGiTVa7RVWDW2Y\u00245nxA\u003D(numArray, num1, num2);
      }
      else
        this.\u0023\u003Dzm_PWQG\u0024VcwFktd5LQCT2vjzdFpAZj5wU4oVmBag\u003D(_param4, _param5, _param3);
      return _param3;
label_4:
      this.\u0023\u003DzX33bK6h_Rrb7QDnHlquatJmY9nBAnxHY5Q\u003D\u003D();
      goto label_2;
label_3:
      Buffer.BlockCopy((Array) src, srcOffset, (Array) dst, dstOffset, count);
      goto label_1;
    }

    private void \u0023\u003Dz\u0024zVryGiTVa7RVWDW2Y\u00245nxA\u003D(
      byte[] _param1,
      int _param2,
      int _param3)
    {
      byte[] numArray = new byte[this.\u0023\u003DzOsmxM1I\u003D.Length];
      if (true)
        goto label_4;
label_1:
      byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
      byte[] dst1;
      byte[] dst2 = dst1;
      int length = dst1.Length;
      if (true)
        goto label_5;
label_2:
      if (true)
        goto label_6;
label_3:
      int num1;
      foreach (ICryptoTransform cryptoTransform in this.\u0023\u003DzhBh6D88\u003D)
      {
        int inputBlockSize = cryptoTransform.InputBlockSize;
        int num2 = _param3 - num1 & ~(inputBlockSize - 1);
        int num3 = num1 + num2;
        for (int index = num1; index < num3; index += inputBlockSize)
        {
          int num4 = index + _param2;
          \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003DzOsmxM1I\u003D.\u0023\u003Dzi2naWvZ1MpOk8MiedoPNQaE\u003D(_param1, num4, dst1, 0, inputBlockSize);
          cryptoTransform.TransformBlock(_param1, num4, inputBlockSize, _param1, num4);
          Buffer.BlockCopy((Array) _param1, num4, (Array) dst1, 0, inputBlockSize);
        }
        num1 = num3;
        if (num3 == _param3)
          break;
      }
      return;
label_6:
      num1 = 0;
      goto label_3;
label_5:
      Buffer.BlockCopy((Array) zOsmxM1I, 0, (Array) dst2, 0, length);
      goto label_2;
label_4:
      dst1 = numArray;
      goto label_1;
    }

    private void \u0023\u003Dzm_PWQG\u0024VcwFktd5LQCT2vjzdFpAZj5wU4oVmBag\u003D(
      byte[] _param1,
      int _param2,
      int _param3)
    {
      byte[] numArray1 = new byte[this.\u0023\u003DzOsmxM1I\u003D.Length];
      if (true)
        goto label_4;
label_1:
      byte[] zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
      byte[] dst1;
      byte[] dst2 = dst1;
      int length = dst1.Length;
      if (true)
        goto label_5;
label_2:
      byte[] numArray2 = new byte[dst1.Length];
      if (true)
        goto label_6;
label_3:
      int num1 = 0;
      byte[] numArray3;
      foreach (ICryptoTransform cryptoTransform in this.\u0023\u003DzhBh6D88\u003D)
      {
        int inputBlockSize = cryptoTransform.InputBlockSize;
        int num2 = _param3 - num1 & ~(inputBlockSize - 1);
        int num3 = num1 + num2;
        for (int index = num1; index < num3; index += inputBlockSize)
        {
          int num4 = index + _param2;
          Buffer.BlockCopy((Array) _param1, num4, (Array) numArray3, 0, inputBlockSize);
          cryptoTransform.TransformBlock(_param1, num4, inputBlockSize, _param1, num4);
          \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003DzOsmxM1I\u003D.\u0023\u003Dzi2naWvZ1MpOk8MiedoPNQaE\u003D(_param1, num4, dst1, 0, inputBlockSize);
          Buffer.BlockCopy((Array) numArray3, 0, (Array) dst1, 0, inputBlockSize);
        }
        num1 = num3;
        if (num3 == _param3)
          break;
      }
      return;
label_6:
      numArray3 = numArray2;
      goto label_3;
label_5:
      Buffer.BlockCopy((Array) zOsmxM1I, 0, (Array) dst2, 0, length);
      goto label_2;
label_4:
      dst1 = numArray1;
      goto label_1;
    }

    private static void \u0023\u003Dzi2naWvZ1MpOk8MiedoPNQaE\u003D(
      byte[] _param0,
      int _param1,
      byte[] _param2,
      int _param3,
      int _param4)
    {
      int num1;
      if (true)
        num1 = 0;
      while (num1 < _param4)
      {
        _param0[_param1 + num1] ^= _param2[_param3 + num1];
        int num2 = num1 + 1;
        if (true)
          num1 = num2;
      }
    }
  }

  [Serializable]
  private sealed class \u0023\u003Dzv_DK75M\u003D
  {
    public static readonly \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003Dzv_DK75M\u003D \u0023\u003Dzv_DK75M\u003D;
    public static Comparison<SymmetricAlgorithm> \u0023\u003DzOsmxM1I\u003D;

    static \u0023\u003Dzv_DK75M\u003D()
    {
      \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003Dzv_DK75M\u003D zvDk75M = new \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003Dzv_DK75M\u003D();
      if (false)
        return;
      \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzv_DK75M\u003D = zvDk75M;
    }

    public \u0023\u003Dzv_DK75M\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal int \u0023\u003Dz21csaDLGHYjeNPhCW79A1WQ\u003D(
      SymmetricAlgorithm _param1,
      SymmetricAlgorithm _param2)
    {
      int blockSize = _param2.BlockSize;
      if (true)
        goto label_2;
label_1:
      int num;
      return num.CompareTo(_param1.BlockSize);
label_2:
      num = blockSize;
      goto label_1;
    }
  }
}
