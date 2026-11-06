// Decompiled with JetBrains decompiler
// Type: #=qeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

#nullable disable
internal static class \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D
{
  private static readonly \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D \u0023\u003Dzv_DK75M\u003D;
  private static readonly byte[] \u0023\u003DzOsmxM1I\u003D;
  private static \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D \u0023\u003DzAElFq6M\u003D;
  private static readonly object \u0023\u003DzhBh6D88\u003D;
  private static bool \u0023\u003DzsIRkzxg\u003D;

  static \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D()
  {
    \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D j53Wpsqr9vPjC2eXuE = \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D.\u0023\u003Dz9yr0JLCi3P2UkLBU1eT1iTF5RgCVYUJs0qCAz_o\u003D(65537UL /*0x010001*/);
    if (true)
      goto label_4;
label_1:
    byte[] numArray = \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzFoSaQ3J7s_unLt6ETyz1h8v0FKjGoZR0_w\u003D\u003D();
    if (true)
      goto label_5;
label_2:
    object obj = new object();
    if (false)
      return;
    \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzhBh6D88\u003D = obj;
    return;
label_5:
    \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzOsmxM1I\u003D = numArray;
    goto label_2;
label_4:
    \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003Dzv_DK75M\u003D = j53Wpsqr9vPjC2eXuE;
    goto label_1;
  }

  private static void \u0023\u003Dzktto5uHnvEpDrZInXIYuhKs\u003D()
  {
    if (\u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzsIRkzxg\u003D)
      return;
    object zhBh6D88 = \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzhBh6D88\u003D;
    if (true)
      goto label_3;
label_2:
    bool flag;
    if (true)
      flag = false;
    object obj1;
    try
    {
      object obj2 = obj1;
      ref bool local = ref flag;
      if (true)
        goto label_8;
label_6:
      if (\u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzsIRkzxg\u003D)
        return;
      \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzAElFq6M\u003D = new \u0023\u003DqMxaZlqv8fBpmgFyZKD5i8rMgOM6PZUi1vgal1cJSCTQ\u003D(true, new \u0023\u003DqoXlT6ptOyrPv2V8A_bJBFLKBErmbu7Q\u0024jhyg\u0024gjssfM\u003D(false, new \u0023\u003Dq9CUcm\u0024312lCAEwI_ln88GWoHLJ53WPsqr9vPjC2eXuE\u003D(1, \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzOsmxM1I\u003D), \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003Dzv_DK75M\u003D));
      \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzsIRkzxg\u003D = true;
      return;
label_8:
      Monitor.Enter(obj2, ref local);
      goto label_6;
    }
    finally
    {
      if (flag)
        Monitor.Exit(obj1);
    }
label_3:
    obj1 = zhBh6D88;
    goto label_2;
  }

  private static byte[] \u0023\u003DzFoSaQ3J7s_unLt6ETyz1h8v0FKjGoZR0_w\u003D\u003D()
  {
    return (byte[]) null;
  }

  public static bool \u0023\u003DzVV6II6VSXVsYaOlhne9e87b0NP5Z6MnNKk7QQB6yt7f3(
    object _param0,
    byte[] _param1,
    ulong _param2,
    int _param3)
  {
    if (_param1 == null)
      return false;
    if (\u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003Dzflm\u0024lh6Y1XlaB_8Ac8KgyjfBJ1cQgLFJrpoukhE\u003D(_param0))
    {
      switch (_param3)
      {
        case 0:
          bool flag;
          if (true)
            flag = false;
          return flag;
        case 1:
          throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772625209));
        case 2:
          throw new NullReferenceException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772625209));
        default:
          throw new ArgumentOutOfRangeException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772625157));
      }
    }
    else
    {
      if (true)
        goto label_13;
label_11:
      byte[] numArray1 = \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DzI48lJhIqAO2gLoOo5g\u003D\u003D(_param0, _param2, (\u0023\u003Dq5CHgop3KNxs5rDSXzj\u00247AG11ryi4o2Vum3dp7WBJp8U\u003D) \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003DzAElFq6M\u003D, (RandomNumberGenerator) null);
      if (true)
        goto label_14;
label_12:
      byte[] numArray2;
      return \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003Dz1Si8Xvz8muIouNOeaaQhWfYGagYdPXG_n1Yvzfo\u003D(_param1, numArray2);
label_14:
      numArray2 = numArray1;
      goto label_12;
label_13:
      \u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003Dzktto5uHnvEpDrZInXIYuhKs\u003D();
      goto label_11;
    }
  }

  private static bool \u0023\u003Dz1Si8Xvz8muIouNOeaaQhWfYGagYdPXG_n1Yvzfo\u003D(
    byte[] _param0,
    byte[] _param1)
  {
    if (_param0.Length != _param1.Length)
      return false;
    int index;
    if (true)
      index = 0;
    while (index < _param0.Length)
    {
      if ((int) _param0[index] != (int) _param1[index])
        return false;
      int num = index + 1;
      if (true)
        index = num;
    }
    return true;
  }

  public static byte[] \u0023\u003Dzi0__cO4EBRYMii\u0024s1Ptcj_\u0024AcD4RgJrsbzQejIQ\u003D(
    object[] _param0,
    byte[] _param1,
    ulong _param2)
  {
    if (_param0 == null)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772625182));
    if (_param1 == null)
      throw new ArgumentNullException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772625387));
    MemoryStream memoryStream1 = new MemoryStream();
    MemoryStream memoryStream2;
    if (true)
      memoryStream2 = memoryStream1;
    byte[] array;
    try
    {
      object[] objArray1 = _param0;
      if (true)
        goto label_8;
label_7:
      int index;
      if (true)
        index = 0;
      object[] objArray2;
      for (; index < objArray2.Length; ++index)
      {
        byte[] numArray = \u0023\u003DqVtWYh6fExQY\u0024YwB78aZ\u0024shpEENCRE2idZyN6SqPCB3o\u003D.\u0023\u003DzmvXCRPJmAdrn6w7e7xhrD5gRKcjf(objArray2[index]);
        ((Stream) memoryStream2).Write(numArray, 0, numArray.Length);
      }
      array = memoryStream2.ToArray();
      goto label_16;
label_8:
      objArray2 = objArray1;
      goto label_7;
    }
    finally
    {
      ((IDisposable) memoryStream2)?.Dispose();
    }
label_16:
    return new \u0023\u003Dq5p6xkrkdJSh0VwsJjAbr9aiZVHBui4vxikDmVGgp8ec\u003D(array, (long) _param2).\u0023\u003DzmHZNpzBF4QCpI\u0024rNLrhtWDWubU0F(_param1);
  }

  internal static bool \u0023\u003Dzflm\u0024lh6Y1XlaB_8Ac8KgyjfBJ1cQgLFJrpoukhE\u003D(
    object _param0)
  {
    if (_param0 == null)
      return true;
    if (!(_param0 is string))
    {
      IEnumerable enumerable1 = _param0 as IEnumerable;
      if (true)
        goto label_5;
label_4:
      IEnumerable enumerable2;
      if (enumerable2 != null)
      {
        IEnumerator enumerator1 = enumerable2.GetEnumerator();
        IEnumerator enumerator2;
        if (true)
          enumerator2 = enumerator1;
        bool flag;
        try
        {
          do
          {
            if (!enumerator2.MoveNext())
              goto label_16;
          }
          while (!\u0023\u003DqeWdSIazehmG4estJ1wQeLJn2XArqeYDvYUlhqt7KXYs\u003D.\u0023\u003Dzflm\u0024lh6Y1XlaB_8Ac8KgyjfBJ1cQgLFJrpoukhE\u003D(enumerator2.Current));
          if (true)
            flag = true;
        }
        finally
        {
          if (enumerator2 is IDisposable disposable)
            disposable.Dispose();
        }
        return flag;
      }
      goto label_16;
label_5:
      enumerable2 = enumerable1;
      goto label_4;
    }
label_16:
    return false;
  }
}
