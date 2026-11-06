// Decompiled with JetBrains decompiler
// Type: #=zJMV3IjfNvFGgsbo$5Sl69zPFUO_SWaAKog==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using Utils.Common.Logging;

#nullable disable
internal sealed class \u0023\u003DzJMV3IjfNvFGgsbo\u00245Sl69zPFUO_SWaAKog\u003D\u003D
{
  private readonly string \u0023\u003Dz8WzPr60\u003D;
  private readonly string \u0023\u003DzCa5C0eE\u003D;
  private readonly Dictionary<string, string> \u0023\u003DzwGXlnqU\u003D;

  public \u0023\u003DzJMV3IjfNvFGgsbo\u00245Sl69zPFUO_SWaAKog\u003D\u003D(
    string _param1,
    string _param2)
  {
    string str1 = _param1;
    if (true)
      goto label_4;
label_1:
    string str2 = _param2;
    if (true)
      goto label_5;
label_2:
    Dictionary<string, string> dictionary = this.\u0023\u003DzIFO9COE\u003D();
    if (false)
      return;
    this.\u0023\u003DzwGXlnqU\u003D = dictionary;
    return;
label_5:
    this.\u0023\u003DzCa5C0eE\u003D = str2;
    goto label_2;
label_4:
    this.\u0023\u003Dz8WzPr60\u003D = str1;
    goto label_1;
  }

  private Dictionary<string, string> \u0023\u003DzIFO9COE\u003D()
  {
    Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
    Dictionary<string, string> dictionary2;
    if (true)
      dictionary2 = dictionary1;
    try
    {
      if (File.Exists(this.\u0023\u003Dz8WzPr60\u003D))
      {
        JsonElement rootElement = JsonDocument.Parse(File.ReadAllText(this.\u0023\u003Dz8WzPr60\u003D, Encoding.UTF8), new JsonDocumentOptions()).RootElement;
        if (true)
          goto label_6;
label_4:
        JsonElement jsonElement1;
        JsonElement.ObjectEnumerator objectEnumerator1 = ((JsonElement) ref jsonElement1).EnumerateObject();
        if (true)
          goto label_7;
label_5:
        JsonElement.ObjectEnumerator objectEnumerator2;
        using (JsonElement.ObjectEnumerator enumerator = ((JsonElement.ObjectEnumerator) ref objectEnumerator2).GetEnumerator())
        {
          while (((JsonElement.ObjectEnumerator) ref enumerator).MoveNext())
          {
            JsonProperty current = ((JsonElement.ObjectEnumerator) ref enumerator).Current;
            Dictionary<string, string> dictionary3 = dictionary2;
            string name = ((JsonProperty) ref current).Name;
            JsonElement jsonElement2 = ((JsonProperty) ref current).Value;
            string str = ((JsonElement) ref jsonElement2).GetString();
            dictionary3[name] = str;
          }
          goto label_13;
        }
label_7:
        objectEnumerator2 = objectEnumerator1;
        goto label_5;
label_6:
        jsonElement1 = rootElement;
        goto label_4;
      }
    }
    catch (Exception ex)
    {
      LoggerHelper.LogError((object) this, \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772640244) + ex.Message, Array.Empty<object>());
    }
label_13:
    return dictionary2;
  }

  private void \u0023\u003DzNIMyQcY\u003D()
  {
    JsonObject jsonObject1 = new JsonObject(new JsonNodeOptions?());
    if (true)
      goto label_2;
label_1:
    Dictionary<string, string>.Enumerator enumerator1 = this.\u0023\u003DzwGXlnqU\u003D.GetEnumerator();
    Dictionary<string, string>.Enumerator enumerator2;
    if (true)
      enumerator2 = enumerator1;
    JsonObject jsonObject2;
    try
    {
      while (enumerator2.MoveNext())
      {
        KeyValuePair<string, string> current = enumerator2.Current;
        if (true)
          goto label_7;
label_6:
        KeyValuePair<string, string> keyValuePair;
        ((JsonNode) jsonObject2)[keyValuePair.Key] = JsonNode.op_Implicit(keyValuePair.Value);
        continue;
label_7:
        keyValuePair = current;
        goto label_6;
      }
    }
    finally
    {
      enumerator2.Dispose();
    }
    string jsonString = ((JsonNode) jsonObject2).ToJsonString(new JsonSerializerOptions()
    {
      WriteIndented = true
    });
    string directoryName = Path.GetDirectoryName(this.\u0023\u003Dz8WzPr60\u003D);
    if (!Directory.Exists(directoryName))
      Directory.CreateDirectory(directoryName);
    File.WriteAllText(this.\u0023\u003Dz8WzPr60\u003D, jsonString, Encoding.UTF8);
    return;
label_2:
    jsonObject2 = jsonObject1;
    goto label_1;
  }

  public string \u0023\u003DzQ8zTQZ8\u003D(string _param1, string _param2)
  {
    Dictionary<string, string> zwGxlnqU = this.\u0023\u003DzwGXlnqU\u003D;
    if (true)
      goto label_2;
label_1:
    bool flag;
    if (true)
      flag = false;
    Dictionary<string, string> dictionary1;
    try
    {
      Dictionary<string, string> dictionary2 = dictionary1;
      ref bool local = ref flag;
      if (true)
        goto label_6;
label_5:
      string str;
      return this.\u0023\u003DzwGXlnqU\u003D.TryGetValue(_param1, out str) ? str : _param2;
label_6:
      Monitor.Enter((object) dictionary2, ref local);
      goto label_5;
    }
    finally
    {
      if (flag)
        Monitor.Exit((object) dictionary1);
    }
label_2:
    dictionary1 = zwGxlnqU;
    goto label_1;
  }

  public void \u0023\u003DzcR3SkHM\u003D(string _param1, string _param2)
  {
    try
    {
      Dictionary<string, string> zwGxlnqU = this.\u0023\u003DzwGXlnqU\u003D;
      if (true)
        goto label_2;
label_1:
      bool flag;
      if (true)
        flag = false;
      Dictionary<string, string> dictionary1;
      try
      {
        Dictionary<string, string> dictionary2 = dictionary1;
        ref bool local = ref flag;
        if (true)
          goto label_6;
label_5:
        this.\u0023\u003DzwGXlnqU\u003D[_param1] = _param2;
        this.\u0023\u003DzNIMyQcY\u003D();
        return;
label_6:
        Monitor.Enter((object) dictionary2, ref local);
        goto label_5;
      }
      finally
      {
        if (flag)
          Monitor.Exit((object) dictionary1);
      }
label_2:
      dictionary1 = zwGxlnqU;
      goto label_1;
    }
    catch (Exception ex)
    {
      LoggerHelper.LogError((object) this, \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772640163) + _param1 + \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772640132) + ex.Message, ex, true);
    }
  }

  public string \u0023\u003Dzgao13cxyiT2jANT\u0024xA\u003D\u003D(string _param1, string _param2)
  {
    string str1;
    try
    {
      string str2 = this.\u0023\u003DzQ8zTQZ8\u003D(_param1, (string) null);
      if (true)
        goto label_2;
label_1:
      string str3;
      if (str3 == null)
      {
        string str4 = _param2;
        if (true)
        {
          str1 = str4;
          goto label_8;
        }
        goto label_8;
      }
      string str5 = this.\u0023\u003Dz\u00249CQ1lI\u003D(str3);
      if (true)
      {
        str1 = str5;
        goto label_8;
      }
      goto label_8;
label_2:
      str3 = str2;
      goto label_1;
    }
    catch (Exception ex)
    {
      LoggerHelper.LogError((object) this, \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772640153) + _param1 + \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772640132) + ex.Message, ex, true);
      str1 = _param2;
    }
label_8:
    return str1;
  }

  public void \u0023\u003DzluGnRp9rXIXZJpFvzg\u003D\u003D(string _param1, string _param2)
  {
    string str1 = _param1;
    string str2 = this.\u0023\u003Dzv6l4\u0024uc\u003D(_param2);
    if (false)
      return;
    this.\u0023\u003DzcR3SkHM\u003D(str1, str2);
  }

  private string \u0023\u003Dzv6l4\u0024uc\u003D(string _param1)
  {
    byte[] bytes1 = Encoding.UTF8.GetBytes(_param1);
    if (true)
      goto label_4;
label_1:
    byte[] bytes2 = Encoding.UTF8.GetBytes(this.\u0023\u003DzCa5C0eE\u003D);
    if (true)
      goto label_5;
label_2:
    byte[] numArray1;
    byte[] hash = ((HashAlgorithm) SHA256.Create()).ComputeHash(numArray1);
    if (true)
      goto label_6;
label_3:
    byte[] numArray2 = new byte[16 /*0x10*/];
    byte[] numArray3;
    byte[] numArray4;
    using (Aes aes = Aes.Create())
    {
      ((SymmetricAlgorithm) aes).KeySize = 256 /*0x0100*/;
      ((SymmetricAlgorithm) aes).BlockSize = 128 /*0x80*/;
      ((SymmetricAlgorithm) aes).Key = numArray4;
      ((SymmetricAlgorithm) aes).IV = numArray2;
      ((SymmetricAlgorithm) aes).Mode = (CipherMode) 1;
      ((SymmetricAlgorithm) aes).Padding = (PaddingMode) 2;
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, ((SymmetricAlgorithm) aes).CreateEncryptor(), (CryptoStreamMode) 1))
        {
          ((Stream) cryptoStream).Write(ReadOnlySpan<byte>.op_Implicit(numArray3));
          ((Stream) cryptoStream).Close();
        }
        return Convert.ToBase64String(memoryStream.ToArray());
      }
    }
label_6:
    numArray4 = hash;
    goto label_3;
label_5:
    numArray1 = bytes2;
    goto label_2;
label_4:
    numArray3 = bytes1;
    goto label_1;
  }

  private string \u0023\u003Dz\u00249CQ1lI\u003D(string _param1)
  {
    byte[] numArray1 = Convert.FromBase64String(_param1);
    if (true)
      goto label_4;
label_1:
    byte[] bytes = Encoding.UTF8.GetBytes(this.\u0023\u003DzCa5C0eE\u003D);
    if (true)
      goto label_5;
label_2:
    byte[] numArray2;
    byte[] hash = ((HashAlgorithm) SHA256.Create()).ComputeHash(numArray2);
    if (true)
      goto label_6;
label_3:
    byte[] numArray3 = new byte[16 /*0x10*/];
    byte[] numArray4;
    byte[] numArray5;
    using (Aes aes = Aes.Create())
    {
      ((SymmetricAlgorithm) aes).KeySize = 256 /*0x0100*/;
      ((SymmetricAlgorithm) aes).BlockSize = 128 /*0x80*/;
      ((SymmetricAlgorithm) aes).Key = numArray5;
      ((SymmetricAlgorithm) aes).IV = numArray3;
      ((SymmetricAlgorithm) aes).Mode = (CipherMode) 1;
      ((SymmetricAlgorithm) aes).Padding = (PaddingMode) 2;
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, ((SymmetricAlgorithm) aes).CreateDecryptor(), (CryptoStreamMode) 1))
        {
          ((Stream) cryptoStream).Write(ReadOnlySpan<byte>.op_Implicit(numArray4));
          ((Stream) cryptoStream).Close();
        }
        return Encoding.UTF8.GetString(memoryStream.ToArray());
      }
    }
label_6:
    numArray5 = hash;
    goto label_3;
label_5:
    numArray2 = bytes;
    goto label_2;
label_4:
    numArray4 = numArray1;
    goto label_1;
  }
}
