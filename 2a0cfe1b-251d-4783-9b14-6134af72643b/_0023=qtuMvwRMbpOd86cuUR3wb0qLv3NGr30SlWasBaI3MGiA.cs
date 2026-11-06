// Decompiled with JetBrains decompiler
// Type: #=qtuMvwRMbpOd86cuUR3wb0qLv3NGr30SlWasBaI3MGiA=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal sealed class \u0023\u003DqtuMvwRMbpOd86cuUR3wb0qLv3NGr30SlWasBaI3MGiA\u003D
{
  private readonly \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D \u0023\u003Dzv_DK75M\u003D;
  private readonly int \u0023\u003DzOsmxM1I\u003D;
  private readonly int \u0023\u003DzAElFq6M\u003D;
  private \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D \u0023\u003DzhBh6D88\u003D;
  private \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D \u0023\u003DzsIRkzxg\u003D;
  private readonly byte[] \u0023\u003DzQvRsjjA\u003D;
  private readonly byte[] \u0023\u003DzlrX5m0o\u003D;

  public \u0023\u003DqtuMvwRMbpOd86cuUR3wb0qLv3NGr30SlWasBaI3MGiA\u003D()
  {
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D u98rtmBvgUzqxYx1o4 = new \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D();
    if (true)
      goto label_4;
label_1:
    // ISSUE: explicit constructor call
    base.\u002Ector();
    int num1 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzb9JlAlLthil6EoOIi5VUflw\u003D();
    if (true)
      goto label_5;
label_2:
    int num2 = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzu\u0024usJZOoqCSGzcgTHlebzfs\u003D();
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003DzQvRsjjA\u003D = new byte[this.\u0023\u003DzAElFq6M\u003D];
    this.\u0023\u003DzlrX5m0o\u003D = new byte[this.\u0023\u003DzAElFq6M\u003D + this.\u0023\u003DzOsmxM1I\u003D];
    return;
label_6:
    this.\u0023\u003DzAElFq6M\u003D = num2;
    goto label_3;
label_5:
    this.\u0023\u003DzOsmxM1I\u003D = num1;
    goto label_2;
label_4:
    this.\u0023\u003Dzv_DK75M\u003D = u98rtmBvgUzqxYx1o4;
    goto label_1;
  }

  public void \u0023\u003Dz4Gdf\u0024uJft_R0pJCXrf2gjApLe8et(byte[] _param1)
  {
    this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzdZHnrLlFzE95CgTAW9pGSzNNoSAwhzEEAQ\u003D\u003D();
    int length1 = _param1.Length;
    if (true)
      goto label_2;
label_1:
    int index;
    if (index > this.\u0023\u003DzAElFq6M\u003D)
    {
      this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzKzDkx\u0024\u0024Q208f\u0024YRcUyJpP5CGH4DQ7OYulokx6_c\u003D(_param1, 0, index);
      this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzYmAvpM\u0024sOXOfd5rvq2hEVgQ_UbBuUlp3UfE1L9xjm3yi(this.\u0023\u003DzQvRsjjA\u003D, 0);
      int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
      if (true)
        index = zOsmxM1I;
    }
    else
    {
      byte[] sourceArray = _param1;
      byte[] zQvRsjjA = this.\u0023\u003DzQvRsjjA\u003D;
      int length2 = index;
      if (true)
        Array.Copy((Array) sourceArray, 0, (Array) zQvRsjjA, 0, length2);
    }
    Array.Clear((Array) this.\u0023\u003DzQvRsjjA\u003D, index, this.\u0023\u003DzAElFq6M\u003D - index);
    Array.Copy((Array) this.\u0023\u003DzQvRsjjA\u003D, 0, (Array) this.\u0023\u003DzlrX5m0o\u003D, 0, this.\u0023\u003DzAElFq6M\u003D);
    \u0023\u003DqtuMvwRMbpOd86cuUR3wb0qLv3NGr30SlWasBaI3MGiA\u003D.\u0023\u003DzRIXBsDk7jETrkZ0_mNOSnDQ\u003D(this.\u0023\u003DzQvRsjjA\u003D, this.\u0023\u003DzAElFq6M\u003D, (byte) 54);
    \u0023\u003DqtuMvwRMbpOd86cuUR3wb0qLv3NGr30SlWasBaI3MGiA\u003D.\u0023\u003DzRIXBsDk7jETrkZ0_mNOSnDQ\u003D(this.\u0023\u003DzlrX5m0o\u003D, this.\u0023\u003DzAElFq6M\u003D, (byte) 92);
    this.\u0023\u003DzsIRkzxg\u003D = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzPUK2qsbf53jwWk3vW0sKxK\u0024ss8NK3MSLMA\u003D\u003D();
    this.\u0023\u003DzsIRkzxg\u003D.\u0023\u003DzKzDkx\u0024\u0024Q208f\u0024YRcUyJpP5CGH4DQ7OYulokx6_c\u003D(this.\u0023\u003DzlrX5m0o\u003D, 0, this.\u0023\u003DzAElFq6M\u003D);
    this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzKzDkx\u0024\u0024Q208f\u0024YRcUyJpP5CGH4DQ7OYulokx6_c\u003D(this.\u0023\u003DzQvRsjjA\u003D, 0, this.\u0023\u003DzQvRsjjA\u003D.Length);
    this.\u0023\u003DzhBh6D88\u003D = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzPUK2qsbf53jwWk3vW0sKxK\u0024ss8NK3MSLMA\u003D\u003D();
    return;
label_2:
    index = length1;
    goto label_1;
  }

  public int \u0023\u003DzvcVxlbN816e0irqPkH\u0024YopevsRSs6xDh5Q\u003D\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzOsmxM1I\u003D;
  }

  public void \u0023\u003DzQPVSGA1hoxsL_1m5_\u0024KM1eNmEApd(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    if (true)
      ;
    \u0023\u003DqDes9HIIdFej7rXpUnJiIEIDZVU98rtmBVgUZqxYx1o4\u003D zvDk75M = this.\u0023\u003Dzv_DK75M\u003D;
    byte[] numArray = _param1;
    if (true)
      ;
    int num1 = _param2;
    if (true)
      ;
    int num2 = _param3;
    zvDk75M.\u0023\u003DzKzDkx\u0024\u0024Q208f\u0024YRcUyJpP5CGH4DQ7OYulokx6_c\u003D(numArray, num1, num2);
  }

  public int \u0023\u003DzOAd27jmHdLwiFLQfvJRwgUrXlnuPZehBY7L842U\u003D(byte[] _param1, int _param2)
  {
    this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzYmAvpM\u0024sOXOfd5rvq2hEVgQ_UbBuUlp3UfE1L9xjm3yi(this.\u0023\u003DzlrX5m0o\u003D, this.\u0023\u003DzAElFq6M\u003D);
    this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzf7cxpekjGqnzOpZCajCtROPkyockVplrUg\u003D\u003D(this.\u0023\u003DzsIRkzxg\u003D);
    this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzKzDkx\u0024\u0024Q208f\u0024YRcUyJpP5CGH4DQ7OYulokx6_c\u003D(this.\u0023\u003DzlrX5m0o\u003D, this.\u0023\u003DzAElFq6M\u003D, this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzb9JlAlLthil6EoOIi5VUflw\u003D());
    int num = this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003DzYmAvpM\u0024sOXOfd5rvq2hEVgQ_UbBuUlp3UfE1L9xjm3yi(_param1, _param2);
    byte[] zlrX5m0o = this.\u0023\u003DzlrX5m0o\u003D;
    int zAelFq6M = this.\u0023\u003DzAElFq6M\u003D;
    int zOsmxM1I = this.\u0023\u003DzOsmxM1I\u003D;
    if (true)
      goto label_2;
label_1:
    this.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzf7cxpekjGqnzOpZCajCtROPkyockVplrUg\u003D\u003D(this.\u0023\u003DzhBh6D88\u003D);
    return num;
label_2:
    Array.Clear((Array) zlrX5m0o, zAelFq6M, zOsmxM1I);
    goto label_1;
  }

  private static void \u0023\u003DzRIXBsDk7jETrkZ0_mNOSnDQ\u003D(
    byte[] _param0,
    int _param1,
    byte _param2)
  {
    int index;
    if (true)
      index = 0;
    while (index < _param1)
    {
      _param0[index] ^= _param2;
      int num = index + 1;
      if (true)
        index = num;
    }
  }
}
