// Decompiled with JetBrains decompiler
// Type: #=ql9DS$6e$ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System.Security.Cryptography;

#nullable disable
internal abstract class \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D
{
  private readonly SymmetricAlgorithm[] \u0023\u003Dzv_DK75M\u003D;

  public \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D(
    byte[] _param1,
    long _param2)
  {
    if (true)
      ;
    byte[] numArray1 = _param1;
    if (true)
      ;
    long num = _param2;
    if (true)
      ;
    byte[] numArray2 = \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D.\u0023\u003Dzdy6S9pU_yZcx9LONwvRpUyeFi\u00241sM1lSIw\u003D\u003D(num);
    // ISSUE: explicit constructor call
    this.\u002Ector(numArray1, numArray2);
  }

  public \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D(
    byte[] _param1,
    byte[] _param2)
  {
    \u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D gjpCzpxFf3hGaitGg1 = new \u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D(_param1, _param2, 1);
    if (true)
      goto label_3;
label_1:
    SymmetricAlgorithm[] symmetricAlgorithmArray1 = new SymmetricAlgorithm[5];
    if (true)
      goto label_4;
label_2:
    int index;
    if (true)
      index = 0;
    \u0023\u003Dqzho0MGHqMTqniG2LFw5PlbQqpsGJPCzpxFf3hGAITGg\u003D gjpCzpxFf3hGaitGg2;
    SymmetricAlgorithm[] symmetricAlgorithmArray2;
    for (; index < 5; ++index)
    {
      \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D s89TpbyvHvtFsn6w = new \u0023\u003Dqr54P5jg2sV8ZqXVq9hPShFNHQOaS89TpbyvHVTFsn6w\u003D(new SymmetricAlgorithm[1]
      {
        (SymmetricAlgorithm) new \u0023\u003DqWmPnWNn5_OYQH4vZ7aF4Kh76wmOmyCfUkjDC8wN0G6w\u003D()
      });
      s89TpbyvHvtFsn6w.Key = gjpCzpxFf3hGaitGg2.GetBytes(s89TpbyvHvtFsn6w.KeySize / 8);
      s89TpbyvHvtFsn6w.IV = gjpCzpxFf3hGaitGg2.GetBytes(s89TpbyvHvtFsn6w.\u0023\u003DzhQBjdhNAm\u0024ANwsONYjZY2Pg\u003D() / 8);
      symmetricAlgorithmArray2[index] = (SymmetricAlgorithm) s89TpbyvHvtFsn6w;
    }
    this.\u0023\u003Dzv_DK75M\u003D = symmetricAlgorithmArray2;
    return;
label_4:
    symmetricAlgorithmArray2 = symmetricAlgorithmArray1;
    goto label_2;
label_3:
    gjpCzpxFf3hGaitGg2 = gjpCzpxFf3hGaitGg1;
    goto label_1;
  }

  protected static int \u0023\u003DzTHXHKX3GtC_gNMftx5YUycUqyCDtox8dvg\u003D\u003D(int _param0)
  {
    int num = _param0;
    if (true)
      ;
    return (num + 3) / 4 * 4;
  }

  public static int \u0023\u003DzjIrjoIy0NBFzUIKxW6DsTHU\u003D(int _param0)
  {
    int num = _param0;
    if (true)
      ;
    return \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D.\u0023\u003DzTHXHKX3GtC_gNMftx5YUycUqyCDtox8dvg\u003D\u003D(num + 4);
  }

  protected static byte[] \u0023\u003Dzdy6S9pU_yZcx9LONwvRpUyeFi\u00241sM1lSIw\u003D\u003D(
    long _param0)
  {
    byte[] numArray1 = new byte[8];
    if (true)
      goto label_3;
label_1:
    long num = _param0;
    byte[] numArray2;
    byte[] numArray3 = numArray2;
    if (true)
      goto label_4;
label_2:
    return numArray2;
label_4:
    \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D.\u0023\u003DzyQAAJSkSV_kUr05XKQ\u003D\u003D(num, numArray3, 0);
    goto label_2;
label_3:
    numArray2 = numArray1;
    goto label_1;
  }

  protected static void \u0023\u003DzyQAAJSkSV_kUr05XKQ\u003D\u003D(
    long _param0,
    byte[] _param1,
    int _param2)
  {
    byte[] numArray = _param1;
    if (true)
      ;
    int index = _param2;
    if (true)
      ;
    long num1 = _param0;
    if (true)
      ;
    int num2 = (int) (byte) num1;
    numArray[index] = (byte) num2;
    _param1[_param2 + 1] = (byte) (_param0 >> 8);
    _param1[_param2 + 2] = (byte) (_param0 >> 16 /*0x10*/);
    _param1[_param2 + 3] = (byte) (_param0 >> 24);
    _param1[_param2 + 4] = (byte) (_param0 >> 32 /*0x20*/);
    _param1[_param2 + 5] = (byte) (_param0 >> 40);
    _param1[_param2 + 6] = (byte) (_param0 >> 48 /*0x30*/);
    _param1[_param2 + 7] = (byte) (_param0 >> 56);
  }

  protected static int \u0023\u003DzjepY5\u0024\u0024wJbfzmfAKvuwsA8uqX9YgeRr1gw\u003D\u003D(
    byte[] _param0,
    int _param1)
  {
    byte[] numArray1 = _param0;
    if (true)
      ;
    int index1 = _param1;
    if (true)
      ;
    int num1 = (int) numArray1[index1];
    byte[] numArray2 = _param0;
    if (true)
      ;
    int index2 = _param1 + 1;
    int num2 = (int) numArray2[index2] << 8;
    return num1 | num2 | (int) _param0[_param1 + 2] << 16 /*0x10*/ | (int) _param0[_param1 + 3] << 24;
  }

  protected static void \u0023\u003DzSiZ_eBcNg0qyDqBYysrUbsRIRpsp4YkUxg\u003D\u003D(
    int _param0,
    byte[] _param1,
    int _param2)
  {
    byte[] numArray = _param1;
    if (true)
      ;
    int index = _param2;
    if (true)
      ;
    int num1 = _param0;
    if (true)
      ;
    int num2 = (int) (byte) num1;
    numArray[index] = (byte) num2;
    _param1[_param2 + 1] = (byte) (_param0 >> 8);
    _param1[_param2 + 2] = (byte) (_param0 >> 16 /*0x10*/);
    _param1[_param2 + 3] = (byte) (_param0 >> 24);
  }

  protected byte[] \u0023\u003DzlaYkqTYyBZgDijeqAwBzuzL86O\u0024Ape2vuN4f1bW7djL2(
    byte[] _param1,
    bool _param2)
  {
    if (_param2)
    {
      SymmetricAlgorithm[] zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
      if (true)
        goto label_3;
label_2:
      int index;
      if (true)
        index = 0;
      SymmetricAlgorithm[] symmetricAlgorithmArray;
      for (; index < symmetricAlgorithmArray.Length; ++index)
      {
        SymmetricAlgorithm symmetricAlgorithm1 = symmetricAlgorithmArray[index];
        if (true)
          goto label_7;
label_6:
        SymmetricAlgorithm symmetricAlgorithm2;
        if (_param2)
        {
          using (ICryptoTransform encryptor = symmetricAlgorithm2.CreateEncryptor())
            _param1 = encryptor.TransformFinalBlock(_param1, 0, _param1.Length);
        }
        else
        {
          using (ICryptoTransform decryptor = symmetricAlgorithm2.CreateDecryptor())
            _param1 = decryptor.TransformFinalBlock(_param1, 0, _param1.Length);
        }
        _param2 = !_param2;
        continue;
label_7:
        symmetricAlgorithm2 = symmetricAlgorithm1;
        goto label_6;
      }
      goto label_34;
label_3:
      symmetricAlgorithmArray = zvDk75M;
      goto label_2;
    }
    for (int index = 4; index >= 0; --index)
    {
      SymmetricAlgorithm symmetricAlgorithm = this.\u0023\u003Dzv_DK75M\u003D[index];
      if (_param2)
      {
        using (ICryptoTransform encryptor = symmetricAlgorithm.CreateEncryptor())
          _param1 = encryptor.TransformFinalBlock(_param1, 0, _param1.Length);
      }
      else
      {
        using (ICryptoTransform decryptor = symmetricAlgorithm.CreateDecryptor())
          _param1 = decryptor.TransformFinalBlock(_param1, 0, _param1.Length);
      }
      _param2 = !_param2;
    }
label_34:
    return _param1;
  }
}
