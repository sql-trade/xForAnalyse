// Decompiled with JetBrains decompiler
// Type: #=z3q_V_Fn__FW$gXZav1DBAn7ew7bpg9bqV8JYLdg=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using \u002D;
using ATAS.Indicators;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

#nullable disable
[Editor(typeof (dje_zG426HU5Y8N752U5TZBUUJVF6MWT4V73ZENJRRWJARDSY96Z_ejd), typeof (UserControl))]
public sealed class \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D : 
  NotifyPropertyChangedBase
{
  private bool \u0023\u003DzhV8QlRg\u003D;
  private int \u0023\u003DzFTGD2wI\u003D;
  private \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D \u0023\u003DzoU\u0024IhTtWRhPI;
  private bool \u0023\u003DzrPsCH_P41fof;
  private bool \u0023\u003Dzn9aU5RCmsnb7;
  private dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd \u0023\u003DzkMJEDqLgOVCL7WPi6Wr1_DM\u003D;
  private dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd \u0023\u003Dz1Td_jiWFiOFD;

  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(
    bool _param1,
    int _param2,
    bool _param3 = false)
  {
    int num1 = _param1 ? 1 : 0;
    if (true)
      goto label_4;
label_1:
    int num2 = _param2;
    if (true)
      goto label_5;
label_2:
    int num3 = _param3 ? 1 : 0;
    if (true)
      goto label_6;
label_3:
    this.\u0023\u003Dzn9aU5RCmsnb7 = _param3;
    this.\u0023\u003Dz1Td_jiWFiOFD = dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Long;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    return;
label_6:
    this.\u0023\u003DzrPsCH_P41fof = num3 != 0;
    goto label_3;
label_5:
    this.\u0023\u003DzFTGD2wI\u003D = num2;
    goto label_2;
label_4:
    this.\u0023\u003DzhV8QlRg\u003D = num1 != 0;
    goto label_1;
  }

  [Browsable(false)]
  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), Name = "EnablePropertyName")]
  public bool Enabled
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzhV8QlRg\u003D;
    }
    set
    {
      if (this.\u0023\u003DzhV8QlRg\u003D == value)
        return;
      ref bool local = ref this.\u0023\u003DzhV8QlRg\u003D;
      int num = value ? 1 : 0;
      string str1 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772623598);
      if (true)
        goto label_4;
label_2:
      string str2 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622296);
      if (false)
        return;
      this.RaisePropertyChanged(str2);
      return;
label_4:
      this.SetProperty<bool>(ref local, num != 0, str1, (Action) null);
      goto label_2;
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), Name = "WeightPropertyName")]
  public int Weight
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzFTGD2wI\u003D;
    }
    set
    {
      if (this.\u0023\u003DzFTGD2wI\u003D == value)
        return;
      ref int local = ref this.\u0023\u003DzFTGD2wI\u003D;
      int num = value;
      string str1 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621728);
      if (true)
        goto label_4;
label_2:
      string str2 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622296);
      if (false)
        return;
      this.RaisePropertyChanged(str2);
      return;
label_4:
      this.SetProperty<int>(ref local, num, str1, (Action) null);
      goto label_2;
    }
  }

  [Browsable(false)]
  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), Name = "ManualOverridePropertyName")]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D ManualOverrideFilter
  {
    get
    {
      if (this.\u0023\u003DzoU\u0024IhTtWRhPI == null)
      {
        \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D nxrx4qaxsYfF4F5t6lpA = new \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D(new Func<bool>(this.\u0023\u003DzGGuL0dmjO8oNAfHE9CxyKtAKkqOh), new Action<bool>(this.\u0023\u003Dz4syq58gT6IqKAIkLRVcFAw_L443V), !this.\u0023\u003Dzn9aU5RCmsnb7);
        if (true)
          this.\u0023\u003DzoU\u0024IhTtWRhPI = nxrx4qaxsYfF4F5t6lpA;
      }
      return this.\u0023\u003DzoU\u0024IhTtWRhPI;
    }
    set
    {
      if (true)
        ;
      if (this.\u0023\u003DzoU\u0024IhTtWRhPI == null)
        return;
      if (true)
        ;
      \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D zoUIhTtWrhPi = this.\u0023\u003DzoU\u0024IhTtWRhPI;
      \u0023\u003DzEi2u2leNw3s6AdNxrx4qaxsYFF4F5t6lpA\u003D\u003D nxrx4qaxsYfF4F5t6lpA = value;
      if (true)
        ;
      int num = nxrx4qaxsYfF4F5t6lpA.Enabled ? 1 : 0;
      zoUIhTtWrhPi.Enabled = num != 0;
      this.\u0023\u003DzoU\u0024IhTtWRhPI.Value = value.Value;
    }
  }

  [Browsable(false)]
  public bool ManualOverride
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzrPsCH_P41fof;
    }
    set
    {
      if (this.\u0023\u003DzrPsCH_P41fof == value || this.\u0023\u003Dzn9aU5RCmsnb7 && !value)
        return;
      ref bool local = ref this.\u0023\u003DzrPsCH_P41fof;
      int num = value ? 1 : 0;
      string str1 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638754);
      if (true)
        goto label_4;
label_2:
      string str2 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622296);
      if (false)
        return;
      this.RaisePropertyChanged(str2);
      return;
label_4:
      this.SetProperty<bool>(ref local, num != 0, str1, (Action) null);
      goto label_2;
    }
  }

  [Browsable(false)]
  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), Name = "ManualBiasValuePropertyName")]
  public dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd ManualBias
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz1Td_jiWFiOFD;
    }
    set
    {
      if (this.\u0023\u003Dz1Td_jiWFiOFD == value)
        return;
      ref dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd local = ref this.\u0023\u003Dz1Td_jiWFiOFD;
      int num = (int) value;
      string str1 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638773);
      if (true)
        goto label_4;
label_2:
      string str2 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622296);
      if (false)
        return;
      this.RaisePropertyChanged(str2);
      return;
label_4:
      this.SetProperty<dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd>(ref local, (dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd) num, str1, (Action) null);
      goto label_2;
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd CalculatedBias
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzkMJEDqLgOVCL7WPi6Wr1_DM\u003D;
    }
    set
    {
      if (this.\u0023\u003DzkMJEDqLgOVCL7WPi6Wr1_DM\u003D == value)
        return;
      ref dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd local = ref this.\u0023\u003DzkMJEDqLgOVCL7WPi6Wr1_DM\u003D;
      int num = (int) value;
      string str1 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772638732);
      if (true)
        goto label_4;
label_2:
      string str2 = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622296);
      if (false)
        return;
      this.RaisePropertyChanged(str2);
      return;
label_4:
      this.SetProperty<dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd>(ref local, (dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd) num, str1, (Action) null);
      goto label_2;
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd ResultingBias
  {
    get
    {
      if (true)
        ;
      if (this.\u0023\u003DzrPsCH_P41fof)
      {
        if (true)
          ;
        return this.\u0023\u003Dz1Td_jiWFiOFD;
      }
      if (true)
        ;
      return this.\u0023\u003DzkMJEDqLgOVCL7WPi6Wr1_DM\u003D;
    }
  }

  [Browsable(false)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public BitmapImage ImageSource
  {
    get
    {
      return \u0023\u003DzISbK5nZKgAQb\u0024Ce\u0024sk39WNYd6ZRvMgLAgQ\u003D\u003D.\u0023\u003DzxKH4rRzEkB6S().\u0023\u003DzgpHJ6jmxWRak();
    }
  }

  public void \u0023\u003DzzqCSRrs\u003D(
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D _param1)
  {
    int num1 = _param1.Enabled ? 1 : 0;
    if (true)
      goto label_3;
label_1:
    int weight = _param1.Weight;
    if (true)
      goto label_4;
label_2:
    int num2 = this.\u0023\u003Dzn9aU5RCmsnb7 ? 1 : (_param1.ManualOverride ? 1 : 0);
    if (true)
      goto label_6;
label_5:
    this.ManualBias = _param1.ManualBias;
    return;
label_6:
    this.ManualOverride = num2 != 0;
    goto label_5;
label_4:
    this.Weight = weight;
    goto label_2;
label_3:
    this.Enabled = num1 != 0;
    goto label_1;
  }

  public void \u0023\u003Dz8bYhdIYOdvFN()
  {
    int num = !this.Enabled ? 1 : 0;
    if (false)
      return;
    this.Enabled = num != 0;
  }

  public void \u0023\u003DzphoOdsgRFdUW()
  {
    if (!this.ManualOverride)
    {
      if (false)
        return;
      this.ManualOverride = true;
    }
    else
    {
      if (this.ManualBias == dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Invalid)
      {
        if (true)
          this.ManualBias = dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Long;
      }
      int z1TdJiWfiOfd = (int) this.\u0023\u003Dz1Td_jiWFiOFD;
      if (true)
        goto label_10;
label_9:
      dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd m5Z3TtvC89DevqEjd;
      switch (m5Z3TtvC89DevqEjd)
      {
        case dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Long:
          this.ManualBias = dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Short;
          return;
        case dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Short:
          this.ManualBias = dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Neutral;
          return;
        case dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Neutral:
          this.ManualBias = dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd.Long;
          this.ManualOverride = false;
          return;
        default:
          return;
      }
label_10:
      m5Z3TtvC89DevqEjd = (dje_zVUY7NAEX4ZX4TLNGLYWPCM6R6WAC9WVFARDZFV36ZVMHWNM5Z3TTVC89DEVQ_ejd) z1TdJiWfiOfd;
      goto label_9;
    }
  }

  [Browsable(false)]
  public string WeightName
  {
    get => \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.WeightPropertyName;
  }

  [Browsable(false)]
  public string EnableDisableDescription
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.EnableDisableDescription;
    }
  }

  [Browsable(false)]
  public string WeightValueDescription
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.WeightValueDescription;
    }
  }

  [Browsable(false)]
  public string ResultingBiasManualModeDescription
  {
    get
    {
      return \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ResultingBiasManualModeDescription;
    }
  }

  private bool \u0023\u003DzGGuL0dmjO8oNAfHE9CxyKtAKkqOh()
  {
    if (true)
      ;
    return this.ManualOverride;
  }

  private void \u0023\u003Dz4syq58gT6IqKAIkLRVcFAw_L443V(bool _param1)
  {
    int num = _param1 ? 1 : 0;
    if (false)
      return;
    this.ManualOverride = num != 0;
  }
}
