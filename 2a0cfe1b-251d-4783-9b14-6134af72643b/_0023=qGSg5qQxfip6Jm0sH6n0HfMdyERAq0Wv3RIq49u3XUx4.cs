// Decompiled with JetBrains decompiler
// Type: #=qGSg5qQxfip6Jm0sH6n0HfMdyERAq0Wv3RIq49u3XUx4=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;

#nullable disable
internal static class \u0023\u003DqGSg5qQxfip6Jm0sH6n0HfMdyERAq0Wv3RIq49u3XUx4\u003D
{
  public static bool \u0023\u003DzNZks6LNYqd\u0024a9QBLctarPJeDRqRG(
    Type _param0,
    Type _param1,
    out int _param2)
  {
    _param2 = 0;
    if (_param0 == _param1)
    {
      _param2 = 1;
      return true;
    }
    if (_param0 == (Type) null || _param1 == (Type) null)
      return false;
    if (_param0.IsByRef)
      return _param1.IsByRef && \u0023\u003DqGSg5qQxfip6Jm0sH6n0HfMdyERAq0Wv3RIq49u3XUx4\u003D.\u0023\u003DzNZks6LNYqd\u0024a9QBLctarPJeDRqRG(_param0.GetElementType(), _param1.GetElementType(), out _param2);
    if (_param1.IsByRef)
      return false;
    if (_param0.IsPointer)
      return _param1.IsPointer && \u0023\u003DqGSg5qQxfip6Jm0sH6n0HfMdyERAq0Wv3RIq49u3XUx4\u003D.\u0023\u003DzNZks6LNYqd\u0024a9QBLctarPJeDRqRG(_param0.GetElementType(), _param1.GetElementType(), out _param2);
    if (_param1.IsPointer)
      return false;
    if (_param0.IsArray)
      return _param1.IsArray && _param0.GetArrayRank() == _param1.GetArrayRank() && \u0023\u003DqGSg5qQxfip6Jm0sH6n0HfMdyERAq0Wv3RIq49u3XUx4\u003D.\u0023\u003DzNZks6LNYqd\u0024a9QBLctarPJeDRqRG(_param0.GetElementType(), _param1.GetElementType(), out _param2);
    if (_param1.IsArray || _param0.IsGenericType != _param1.IsGenericType)
      return false;
    if (_param0.IsGenericType)
    {
      Type type1 = _param0.IsGenericTypeDefinition ? _param0 : _param0.GetGenericTypeDefinition();
      Type type2 = _param1.IsGenericTypeDefinition ? _param1 : _param1.GetGenericTypeDefinition();
      if (true)
        goto label_25;
label_24:
      Type type3;
      Type type4 = type3;
      if (type1 != type4)
        return false;
      Type[] genericArguments1 = _param0.GetGenericArguments();
      if (true)
        goto label_30;
label_28:
      Type[] genericArguments2 = _param1.GetGenericArguments();
      if (true)
        goto label_31;
label_29:
      Type[] typeArray1;
      Type[] typeArray2;
      if (typeArray1.Length != typeArray2.Length)
        return false;
      int index;
      if (true)
        index = 0;
      while (index < typeArray1.Length)
      {
        int num1;
        if (\u0023\u003DqGSg5qQxfip6Jm0sH6n0HfMdyERAq0Wv3RIq49u3XUx4\u003D.\u0023\u003DzNZks6LNYqd\u0024a9QBLctarPJeDRqRG(typeArray1[index], typeArray2[index], out num1))
          _param2 += num1;
        int num2 = index + 1;
        if (true)
          index = num2;
      }
      goto label_42;
label_31:
      typeArray2 = genericArguments2;
      goto label_29;
label_30:
      typeArray1 = genericArguments1;
      goto label_28;
label_25:
      type3 = type2;
      goto label_24;
    }
    if (_param0 != _param1)
      return false;
label_42:
    ++_param2;
    return true;
  }
}
