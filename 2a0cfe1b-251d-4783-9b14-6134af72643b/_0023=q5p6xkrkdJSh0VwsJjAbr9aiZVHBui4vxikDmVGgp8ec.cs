// Decompiled with JetBrains decompiler
// Type: #=q5p6xkrkdJSh0VwsJjAbr9aiZVHBui4vxikDmVGgp8ec=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal sealed class \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9aiZVHBui4vxikDmVGgp8ec\u003D : 
  \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D
{
  public \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9aiZVHBui4vxikDmVGgp8ec\u003D(
    byte[] _param1,
    long _param2)
  {
    if (true)
      ;
    byte[] numArray = _param1;
    if (true)
      ;
    long num = _param2;
    if (true)
      ;
    // ISSUE: explicit constructor call
    base.\u002Ector(numArray, num);
  }

  public byte[] \u0023\u003DzOnG6D1MTVGo5h2Alls65N_8Ack5Y(
    \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D _param1,
    \u0023\u003DqYSCiWJBCeP8dOGjUVqPyDS5gbRfYCm4zWAifUegB0hg\u003D _param2)
  {
    byte[] numArray1 = new byte[4];
    if (true)
      goto label_4;
label_1:
    \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D ebfggaxStyQ4bNbAoc = _param1;
    byte[] src1;
    byte[] numArray2 = src1;
    int? nullable = new int?(src1.Length);
    if (true)
      goto label_5;
label_2:
    int num1 = \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D.\u0023\u003DzjepY5\u0024\u0024wJbfzmfAKvuwsA8uqX9YgeRr1gw\u003D\u003D(this.\u0023\u003DzlaYkqTYyBZgDijeqAwBzuzL86O\u0024Ape2vuN4f1bW7djL2(src1, false), 0);
    if (true)
      goto label_6;
label_3:
    int length1;
    int length2 = \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D.\u0023\u003DzjIrjoIy0NBFzUIKxW6DsTHU\u003D(length1);
    int num2 = length2 - 4;
    byte[] dst1 = new byte[length2];
    \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9aiZVHBui4vxikDmVGgp8ec\u003D.\u0023\u003DzbCBBM1VsrGgD5K6ZXA\u003D\u003D(_param1, dst1, 4, new int?(num2));
    Buffer.BlockCopy((Array) src1, 0, (Array) dst1, 0, 4);
    byte[] src2 = this.\u0023\u003DzlaYkqTYyBZgDijeqAwBzuzL86O\u0024Ape2vuN4f1bW7djL2(dst1, false);
    byte[] numArray3 = new byte[length1];
    byte[] dst2 = numArray3;
    int count = length1;
    Buffer.BlockCopy((Array) src2, 4, (Array) dst2, 0, count);
    return numArray3;
label_6:
    length1 = num1;
    goto label_3;
label_5:
    \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9aiZVHBui4vxikDmVGgp8ec\u003D.\u0023\u003DzbCBBM1VsrGgD5K6ZXA\u003D\u003D(ebfggaxStyQ4bNbAoc, numArray2, 0, nullable);
    goto label_2;
label_4:
    src1 = numArray1;
    goto label_1;
  }

  public byte[] \u0023\u003DzmHZNpzBF4QCpI\u0024rNLrhtWDWubU0F(byte[] _param1)
  {
    byte[] src = this.\u0023\u003DzlaYkqTYyBZgDijeqAwBzuzL86O\u0024Ape2vuN4f1bW7djL2(_param1, false);
    int num = \u0023\u003Dql9DS\u00246e\u0024ODyjV3Zk1RjZxVD5zLXvxZJx_RBJVhZYoYc\u003D.\u0023\u003DzjepY5\u0024\u0024wJbfzmfAKvuwsA8uqX9YgeRr1gw\u003D\u003D(src, 0);
    if (true)
      goto label_4;
label_1:
    int length;
    byte[] numArray1 = new byte[length];
    if (true)
      goto label_5;
label_2:
    byte[] numArray2;
    byte[] dst = numArray2;
    int count = length;
    if (true)
      goto label_6;
label_3:
    return numArray2;
label_6:
    Buffer.BlockCopy((Array) src, 4, (Array) dst, 0, count);
    goto label_3;
label_5:
    numArray2 = numArray1;
    goto label_2;
label_4:
    length = num;
    goto label_1;
  }

  private static void \u0023\u003DzbCBBM1VsrGgD5K6ZXA\u003D\u003D(
    \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D _param0,
    byte[] _param1,
    int _param2,
    int? _param3)
  {
    int? nullable1 = _param3;
    if (true)
      goto label_2;
label_1:
    int? nullable2;
    int num1 = nullable2 ?? _param1.Length - _param2;
    int num2;
    if (true)
      num2 = num1;
    int num3;
    for (; (num3 = _param0.\u0023\u003Dzqi6bFCsg6IizkjY7gWIf9OnVpfyNfJgDHA7otxFYU\u0024\u0024PMTpQ2pm_sS0kK0AkdjN7zZiVkMr_EWVy\u0024THZuQ\u003D\u003D(_param1, _param2, num2)) > 0; num2 -= num3)
    {
      int num4 = _param2 + num3;
      if (false)
        continue;
      _param2 = num4;
    }
    return;
label_2:
    nullable2 = nullable1;
    goto label_1;
  }
}
