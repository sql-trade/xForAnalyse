// Decompiled with JetBrains decompiler
// Type: #=zV3UiTijiHdXfWmKuCK5R66fEo1E0SDXgIA==
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Xml.Serialization;

#nullable disable
public sealed class \u0023\u003DzV3UiTijiHdXfWmKuCK5R66fEo1E0SDXgIA\u003D\u003D : 
  INotifyPropertyChanged
{
  private readonly \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI_NXMrsMw099qA\u003D\u003D \u0023\u003DziVpUCyM\u003D;
  private readonly Action<string> \u0023\u003DzvwexYRvY_bsfhZ6UCA\u003D\u003D;
  private PropertyChangedEventHandler \u0023\u003Dzdlcw_M8\u003D;

  internal \u0023\u003DzV3UiTijiHdXfWmKuCK5R66fEo1E0SDXgIA\u003D\u003D(
    \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI_NXMrsMw099qA\u003D\u003D _param1,
    Action<string> _param2)
  {
    \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI_NXMrsMw099qA\u003D\u003D kirUkINxMrsMw099qA = _param1;
    if (true)
      goto label_3;
label_1:
    Action<string> action = _param2;
    if (false)
      return;
    this.\u0023\u003DzvwexYRvY_bsfhZ6UCA\u003D\u003D = action;
    return;
label_3:
    this.\u0023\u003DziVpUCyM\u003D = kirUkINxMrsMw099qA;
    goto label_1;
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public string LicenseId
  {
    get
    {
      string licenseId1 = this.\u0023\u003DziVpUCyM\u003D.LicenseId;
      if (true)
        goto label_2;
label_1:
      string licenseId2;
      this.\u0023\u003DzvwexYRvY_bsfhZ6UCA\u003D\u003D(licenseId2);
      return licenseId2;
label_2:
      licenseId2 = licenseId1;
      goto label_1;
    }
    set
    {
      string str1 = value ?? string.Empty;
      if (true)
        goto label_3;
label_1:
      string str2;
      this.\u0023\u003DziVpUCyM\u003D.LicenseId = str2;
      this.\u0023\u003DzvwexYRvY_bsfhZ6UCA\u003D\u003D(str2);
      string str3 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772640228);
      if (false)
        return;
      this.\u0023\u003DzyE3ia882gPHX(str3);
      return;
label_3:
      str2 = str1;
      goto label_1;
    }
  }

  public event PropertyChangedEventHandler PropertyChanged
  {
    add
    {
      PropertyChangedEventHandler zdlcwM8 = this.\u0023\u003Dzdlcw_M8\u003D;
      PropertyChangedEventHandler changedEventHandler1;
      if (true)
        changedEventHandler1 = zdlcwM8;
      PropertyChangedEventHandler comparand;
      do
      {
        PropertyChangedEventHandler changedEventHandler2 = changedEventHandler1;
        if (true)
          goto label_6;
label_3:
        PropertyChangedEventHandler changedEventHandler3 = comparand + value;
        if (true)
          goto label_7;
label_4:
        PropertyChangedEventHandler changedEventHandler4;
        changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.\u0023\u003Dzdlcw_M8\u003D, changedEventHandler4, comparand);
        continue;
label_7:
        changedEventHandler4 = changedEventHandler3;
        goto label_4;
label_6:
        comparand = changedEventHandler2;
        goto label_3;
      }
      while (changedEventHandler1 != comparand);
    }
    remove
    {
      PropertyChangedEventHandler zdlcwM8 = this.\u0023\u003Dzdlcw_M8\u003D;
      PropertyChangedEventHandler changedEventHandler1;
      if (true)
        changedEventHandler1 = zdlcwM8;
      PropertyChangedEventHandler comparand;
      do
      {
        PropertyChangedEventHandler changedEventHandler2 = changedEventHandler1;
        if (true)
          goto label_6;
label_3:
        PropertyChangedEventHandler changedEventHandler3 = comparand - value;
        if (true)
          goto label_7;
label_4:
        PropertyChangedEventHandler changedEventHandler4;
        changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.\u0023\u003Dzdlcw_M8\u003D, changedEventHandler4, comparand);
        continue;
label_7:
        changedEventHandler4 = changedEventHandler3;
        goto label_4;
label_6:
        comparand = changedEventHandler2;
        goto label_3;
      }
      while (changedEventHandler1 != comparand);
    }
  }

  private void \u0023\u003DzyE3ia882gPHX(string _param1)
  {
    if (true)
      ;
    PropertyChangedEventHandler zdlcwM8 = this.\u0023\u003Dzdlcw_M8\u003D;
    if (zdlcwM8 == null)
    {
      if (false)
        ;
    }
    else
    {
      if (true)
        ;
      zdlcwM8((object) this, new PropertyChangedEventArgs(_param1));
    }
  }
}
