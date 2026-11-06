// Decompiled with JetBrains decompiler
// Type: #=qQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
internal static class \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D
{
  public static readonly Type \u0023\u003Dzv_DK75M\u003D;
  public static readonly Type \u0023\u003DzOsmxM1I\u003D;
  public static readonly Type \u0023\u003DzAElFq6M\u003D;
  public static readonly Type \u0023\u003DzhBh6D88\u003D;
  public static readonly Type \u0023\u003DzsIRkzxg\u003D;
  public static readonly Assembly \u0023\u003DzQvRsjjA\u003D;

  static \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D()
  {
    Type type1 = typeof (object);
    if (true)
      goto label_4;
label_1:
    Type type2 = typeof (ValueType);
    if (true)
      goto label_5;
label_2:
    Type type3 = typeof (Enum);
    if (true)
      goto label_6;
label_3:
    \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003DzhBh6D88\u003D = typeof (Nullable<>);
    \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003DzsIRkzxg\u003D = typeof (void);
    \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003DzQvRsjjA\u003D = typeof (\u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D).Assembly;
    return;
label_6:
    \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003DzAElFq6M\u003D = type3;
    goto label_3;
label_5:
    \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003DzOsmxM1I\u003D = type2;
    goto label_2;
label_4:
    \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003Dzv_DK75M\u003D = type1;
    goto label_1;
  }

  public static bool \u0023\u003DzSv3JBjLbqMms3eJ6W3UbsVYH_L8qdACmuKBEzQM\u003D(Type _param0)
  {
    Type type1 = _param0;
    if (true)
      ;
    if (type1.IsGenericType)
    {
      Type type2 = _param0;
      if (true)
        ;
      if (!type2.IsGenericTypeDefinition)
      {
        Type type3 = _param0;
        if (true)
          ;
        return type3.GetGenericTypeDefinition() == \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003DzhBh6D88\u003D;
      }
    }
    return false;
  }

  public static Type \u0023\u003DzDeCrxKsMKplxibJgXxng_c5kE8tehtM0V5BS6Mqe44Au(Type _param0)
  {
    while (_param0.HasElementType)
    {
      Type elementType = _param0.GetElementType();
      if (true)
        _param0 = elementType;
    }
    return _param0;
  }

  public static Type \u0023\u003Dz8Pdf\u0024qlcdmyyc6Ua5W_tbFtCny8H(Type _param0)
  {
    if (_param0.HasElementType && !_param0.IsArray)
    {
      Type elementType = _param0.GetElementType();
      if (true)
        _param0 = elementType;
    }
    return _param0;
  }

  public static Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> \u0023\u003DzGfD1bgsuI4LIPdokwnwfIdA\u003D(
    Type _param0)
  {
    Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack1 = new Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D>();
    if (true)
      goto label_2;
label_1:
    Type type1 = _param0;
    Type type2;
    if (true)
      type2 = type1;
    Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack2;
    while (true)
    {
      \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ1;
      if (type2.IsArray)
      {
        Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack3 = akvUoqoLez8QbsbtwQStack2;
        akvUoqoLez8QbsbtwQ1 = new \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D();
        ref \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D local = ref akvUoqoLez8QbsbtwQ1;
        if (true)
          goto label_7;
label_6:
        akvUoqoLez8QbsbtwQ1.\u0023\u003DzOsmxM1I\u003D = type2.GetArrayRank();
        \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ2 = akvUoqoLez8QbsbtwQ1;
        akvUoqoLez8QbsbtwQStack3.Push(akvUoqoLez8QbsbtwQ2);
        goto label_12;
label_7:
        local.\u0023\u003Dzv_DK75M\u003D = 2;
        goto label_6;
      }
      if (type2.IsByRef)
      {
        Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack4 = akvUoqoLez8QbsbtwQStack2;
        akvUoqoLez8QbsbtwQ1 = new \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D();
        akvUoqoLez8QbsbtwQ1.\u0023\u003Dzv_DK75M\u003D = 1;
        \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ3 = akvUoqoLez8QbsbtwQ1;
        akvUoqoLez8QbsbtwQStack4.Push(akvUoqoLez8QbsbtwQ3);
      }
      else if (type2.IsPointer)
      {
        Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack5 = akvUoqoLez8QbsbtwQStack2;
        akvUoqoLez8QbsbtwQ1 = new \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D();
        akvUoqoLez8QbsbtwQ1.\u0023\u003Dzv_DK75M\u003D = 0;
        \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ4 = akvUoqoLez8QbsbtwQ1;
        akvUoqoLez8QbsbtwQStack5.Push(akvUoqoLez8QbsbtwQ4);
      }
      else
        break;
label_12:
      type2 = type2.GetElementType();
    }
    return akvUoqoLez8QbsbtwQStack2;
label_2:
    akvUoqoLez8QbsbtwQStack2 = akvUoqoLez8QbsbtwQStack1;
    goto label_1;
  }

  public static Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> \u0023\u003DzIz9paBR5FM2\u0024_IgEG9zUrmY\u003D(
    string _param0)
  {
    string str1 = _param0;
    if (true)
      goto label_2;
label_1:
    Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack1 = new Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D>();
    Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack2;
    if (true)
      akvUoqoLez8QbsbtwQStack2 = akvUoqoLez8QbsbtwQStack1;
    string str2;
    while (true)
    {
      string str3;
      do
      {
        \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ1;
        while (!str2.EndsWith(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622615), StringComparison.Ordinal))
        {
          if (str2.EndsWith(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622623), StringComparison.Ordinal))
          {
            Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack3 = akvUoqoLez8QbsbtwQStack2;
            akvUoqoLez8QbsbtwQ1 = new \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D();
            akvUoqoLez8QbsbtwQ1.\u0023\u003Dzv_DK75M\u003D = 0;
            \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ2 = akvUoqoLez8QbsbtwQ1;
            akvUoqoLez8QbsbtwQStack3.Push(akvUoqoLez8QbsbtwQ2);
            str2 = str2.Substring(0, str2.Length - 1);
          }
          else if (str2.EndsWith(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622823), StringComparison.Ordinal))
          {
            Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack4 = akvUoqoLez8QbsbtwQStack2;
            akvUoqoLez8QbsbtwQ1 = new \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D();
            akvUoqoLez8QbsbtwQ1.\u0023\u003Dzv_DK75M\u003D = 2;
            akvUoqoLez8QbsbtwQ1.\u0023\u003DzOsmxM1I\u003D = 1;
            \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ3 = akvUoqoLez8QbsbtwQ1;
            akvUoqoLez8QbsbtwQStack4.Push(akvUoqoLez8QbsbtwQ3);
            str2 = str2.Substring(0, str2.Length - 2);
          }
          else
          {
            if (!str2.EndsWith(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622830), StringComparison.Ordinal))
              return akvUoqoLez8QbsbtwQStack2;
            int num = 1;
            int length = -1;
            for (int index = str2.Length - 2; index >= 0; --index)
            {
              switch (str2[index])
              {
                case ',':
                  ++num;
                  break;
                case '[':
                  length = index;
                  index = -1;
                  break;
                default:
                  throw new InvalidOperationException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622837));
              }
            }
            str2 = length >= 0 ? str2.Substring(0, length) : throw new InvalidOperationException(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622791));
            Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack5 = akvUoqoLez8QbsbtwQStack2;
            akvUoqoLez8QbsbtwQ1 = new \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D();
            akvUoqoLez8QbsbtwQ1.\u0023\u003Dzv_DK75M\u003D = 2;
            akvUoqoLez8QbsbtwQ1.\u0023\u003DzOsmxM1I\u003D = num;
            \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ4 = akvUoqoLez8QbsbtwQ1;
            akvUoqoLez8QbsbtwQStack5.Push(akvUoqoLez8QbsbtwQ4);
          }
        }
        Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> akvUoqoLez8QbsbtwQStack6 = akvUoqoLez8QbsbtwQStack2;
        akvUoqoLez8QbsbtwQ1 = new \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D();
        ref \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D local = ref akvUoqoLez8QbsbtwQ1;
        if (true)
          goto label_7;
label_6:
        \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ5 = akvUoqoLez8QbsbtwQ1;
        akvUoqoLez8QbsbtwQStack6.Push(akvUoqoLez8QbsbtwQ5);
        str3 = str2.Substring(0, str2.Length - 1);
        continue;
label_7:
        local.\u0023\u003Dzv_DK75M\u003D = 1;
        goto label_6;
      }
      while (false);
      str2 = str3;
    }
label_2:
    str2 = str1;
    goto label_1;
  }

  public static Type \u0023\u003Dz8K\u0024fx2DIefdzn2AUyIi5aTQ\u003D(
    Type _param0,
    Stack<\u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D> _param1)
  {
    Type type1 = _param0;
    Type type2;
    if (true)
      type2 = type1;
    while (_param1.Count > 0)
    {
      \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ1 = _param1.Pop();
      if (true)
        goto label_5;
label_3:
      \u0023\u003Dq\u0024UGLAs2torssIzQTr0rJrBnJvAkvUOqoLEz8QbsbtwQ\u003D akvUoqoLez8QbsbtwQ2;
      int zvDk75M = akvUoqoLez8QbsbtwQ2.\u0023\u003Dzv_DK75M\u003D;
      if (true)
        goto label_6;
label_4:
      int num;
      switch (num)
      {
        case 0:
          type2 = type2.MakePointerType();
          continue;
        case 1:
          type2 = type2.MakeByRefType();
          continue;
        case 2:
          type2 = akvUoqoLez8QbsbtwQ2.\u0023\u003DzOsmxM1I\u003D != 1 ? type2.MakeArrayType(akvUoqoLez8QbsbtwQ2.\u0023\u003DzOsmxM1I\u003D) : type2.MakeArrayType();
          continue;
        default:
          continue;
      }
label_6:
      num = zvDk75M;
      goto label_4;
label_5:
      akvUoqoLez8QbsbtwQ2 = akvUoqoLez8QbsbtwQ1;
      goto label_3;
    }
    return type2;
  }

  public static int \u0023\u003DzMUMxEexmmUz0VQkAnnAbFZ0WrkD5HzGrZg\u003D\u003D(Type _param0)
  {
    Dictionary<Type, int> zvDk75M = \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzv_DK75M\u003D;
    Type key = _param0;
    if (true)
      ;
    int num1;
    ref int local = ref num1;
    if (zvDk75M.TryGetValue(key, out local))
    {
      int num2 = num1;
      return false ? num2 : num2;
    }
    Type type = _param0;
    if (true)
      ;
    if (type.IsArray)
      return 9;
    if (!_param0.IsValueType)
      return 4;
    if (_param0.IsSubclassOf(\u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003DzAElFq6M\u003D))
      return 19;
    return \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003DzSv3JBjLbqMms3eJ6W3UbsVYH_L8qdACmuKBEzQM\u003D(_param0) ? 5 : 25;
  }

  private static class \u0023\u003Dzv_DK75M\u003D
  {
    public static readonly Dictionary<Type, int> \u0023\u003Dzv_DK75M\u003D;

    static \u0023\u003Dzv_DK75M\u003D()
    {
      Dictionary<Type, int> dictionary = new Dictionary<Type, int>();
      dictionary.Add(typeof (object), 7);
      dictionary.Add(typeof (byte), 12);
      dictionary.Add(typeof (sbyte), 17);
      dictionary.Add(typeof (short), 26);
      dictionary.Add(typeof (int), 1);
      dictionary.Add(typeof (long), 13);
      dictionary.Add(typeof (ushort), 16 /*0x10*/);
      dictionary.Add(typeof (uint), 3);
      dictionary.Add(typeof (ulong), 14);
      dictionary.Add(typeof (IntPtr), 0);
      dictionary.Add(typeof (UIntPtr), 20);
      dictionary.Add(typeof (float), 22);
      dictionary.Add(typeof (double), 8);
      dictionary.Add(typeof (bool), 15);
      dictionary.Add(typeof (char), 6);
      dictionary.Add(typeof (string), 10);
      if (false)
        return;
      \u0023\u003DqQSbeOH50Nx3EsvopeffklxMRTh1s_8NXDCIB0p0UdH0\u003D.\u0023\u003Dzv_DK75M\u003D.\u0023\u003Dzv_DK75M\u003D = dictionary;
    }
  }
}
