// Decompiled with JetBrains decompiler
// Type: BiasDetermination.BiasDeterminationTool
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using \u002D;
using ATAS.Indicators;
using Newtonsoft.Json;
using OFT.Attributes;
using OFT.Rendering;
using OFT.Rendering.Context;
using OFT.Rendering.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Xml.Serialization;
using Utils.Common.Collections;
using Utils.Common.Logging;

#nullable disable
namespace BiasDetermination;

[HelpLink("https://alphaxtrade.com/")]
[Category("AlphaXtrade")]
[DisplayName("AlphaX Bias PRO")]
[FeatureId("cQ22fevVF140v9LVwiRnMkBQeykuB2dBd82J")]
public sealed class BiasDeterminationTool : 
  Indicator,
  \u0023\u003DzMCqAV2TdtVhLYXKOFbBQU8JKvh4VCrGf0kg244M\u003D
{
  private readonly \u0023\u003DzrkMlj0lxEvO0CDKWztMZ\u0024avNIHTmpwm0Zw\u003D\u003D \u0023\u003DzAk8DXuLJQxXI;
  private readonly \u0023\u003Dzlzeq9JudfmdX647lRjYzftcjOdf_CeYq3neE2O7viSkWB_g4ow\u003D\u003D \u0023\u003DzaU9VydwvgxL3;
  private bool \u0023\u003DzzMb92FFEH_vh;
  private bool \u0023\u003Dz3ryrit9Pys3a;
  private int \u0023\u003DzrntsJjDd8zu4_09kZw\u003D\u003D;
  private ValueDataSeries \u0023\u003DzeRw6V4UvbPA3;
  private ValueDataSeries \u0023\u003DzolHeG3kAGPX4CTXCSg\u003D\u003D;
  private ValueDataSeries \u0023\u003Dz7m1d_eL_Zz9z;
  private static readonly string[] \u0023\u003DzUvPWzec70IrQSNXs5Q\u003D\u003D;
  private static readonly \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D \u0023\u003Dz0\u0024w2l5DkSSx4;
  private \u0023\u003Dze5rhn\u0024p1WDptqCoga8k19y\u0024bDyhrOwz8t2rkWTM\u003D \u0023\u003DzlpvHu6Ch1gwT;
  private static readonly string \u0023\u003Dz0uXcOUtdso6D;
  private static readonly \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI_NXMrsMw099qA\u003D\u003D \u0023\u003DztiC9Dt6K6YJl;
  private readonly DrawingLayout \u0023\u003DztZFKou_fAAK8;
  private TimeSpan \u0023\u003Dz2GUpFqYKS3dJdq_Smg\u003D\u003D;
  private TimeSpan \u0023\u003Dz\u0024UScyt9svQbSsnAbSw\u003D\u003D;
  private bool \u0023\u003Dzh2zNXnfEmHvc;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003Dz\u0024LCGrqJ6quCOWTCCc7U1o\u0024Y\u003D;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003Dzbs70LHE7yL\u0024XcXf2fD6EX4sgW5nH;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003DzsxmJm89DuC3R32R7DQ\u003D\u003D;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003Dz0XfQvkVQvOI3;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003DzeVYZl8X3Ilzct69yAg\u003D\u003D;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003DzotBBwRt0DAWcD5p3KIoV2xg\u003D;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003DzlWfRcjluN_zM;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003Dz8oCaw5UneYX2BfQLDQ\u003D\u003D;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003Dzm\u0024h6QGJjjfkh;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003DzV4nEDlm8ttArRkcvLg\u003D\u003D;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003Dz49qAX37_1mUu;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003Dz5GojB7dBsAB5WvS5WIqJUkHRGa8U;
  private \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D \u0023\u003DzdcEPOavj6wDI_HKjYd9cDcHk5hxD;
  private \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D \u0023\u003DzyW_wT3Pl3K2pY3fa3w\u003D\u003D;
  private \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D \u0023\u003DzZilWa7Zv1THv3bNVdA\u003D\u003D;
  private \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D \u0023\u003Dz3cCfLYpb_YmLLvqj3w\u003D\u003D;
  private \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd> \u0023\u003Dz5zTW9uGzoeh0;
  private string \u0023\u003DzUHm_WqJ0OqxqX7OOcQ\u003D\u003D;
  private \u0023\u003DzV3UiTijiHdXfWmKuCK5R66fEo1E0SDXgIA\u003D\u003D \u0023\u003DzoMQy6R0IJVQElSNFYuCzXdE\u003D;
  private FilterString \u0023\u003DzWI0IB7sHAK5yrlrSSg\u003D\u003D;

  public BiasDeterminationTool()
  {
    \u0023\u003Dzlzeq9JudfmdX647lRjYzftcjOdf_CeYq3neE2O7viSkWB_g4ow\u003D\u003D yq3neE2O7viSkWbG4ow = new \u0023\u003Dzlzeq9JudfmdX647lRjYzftcjOdf_CeYq3neE2O7viSkWB_g4ow\u003D\u003D();
    if (true)
      goto label_11;
label_1:
    if (true)
      goto label_12;
label_2:
    DrawingLayout drawingLayout = new DrawingLayout();
    if (true)
      goto label_13;
label_3:
    TimeSpan timeSpan1 = new TimeSpan(15, 30, 0);
    if (true)
      goto label_14;
label_4:
    TimeSpan timeSpan2 = new TimeSpan(22, 0, 0);
    if (true)
      goto label_15;
label_5:
    if (true)
      goto label_16;
label_6:
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D an7ew7bpg9bqV8JyLdg1 = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 6);
    if (true)
      goto label_17;
label_7:
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D an7ew7bpg9bqV8JyLdg2 = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 10);
    if (true)
      goto label_18;
label_8:
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D an7ew7bpg9bqV8JyLdg3 = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 10);
    if (true)
      goto label_19;
label_9:
    \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D an7ew7bpg9bqV8JyLdg4 = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 10);
    if (true)
      goto label_20;
label_10:
    this.\u0023\u003DzeVYZl8X3Ilzct69yAg\u003D\u003D = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 10);
    this.\u0023\u003DzotBBwRt0DAWcD5p3KIoV2xg\u003D = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 12);
    this.\u0023\u003DzlWfRcjluN_zM = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 8);
    this.\u0023\u003Dz8oCaw5UneYX2BfQLDQ\u003D\u003D = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 5);
    this.\u0023\u003Dzm\u0024h6QGJjjfkh = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 10);
    this.\u0023\u003DzV4nEDlm8ttArRkcvLg\u003D\u003D = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 10);
    this.\u0023\u003Dz49qAX37_1mUu = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 8);
    this.\u0023\u003Dz5GojB7dBsAB5WvS5WIqJUkHRGa8U = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 8);
    this.\u0023\u003DzdcEPOavj6wDI_HKjYd9cDcHk5hxD = new \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D(true, 8, true);
    this.\u0023\u003DzUHm_WqJ0OqxqX7OOcQ\u003D\u003D = string.Empty;
    this.\u0023\u003DzoMQy6R0IJVQElSNFYuCzXdE\u003D = new \u0023\u003DzV3UiTijiHdXfWmKuCK5R66fEo1E0SDXgIA\u003D\u003D(BiasDeterminationTool.\u0023\u003DztiC9Dt6K6YJl, BiasDeterminationTool.\u0023\u003DzewGRIik\u003D.\u0023\u003DzDQNiLT2p4Vv2RLSA1g\u003D\u003D ?? (BiasDeterminationTool.\u0023\u003DzewGRIik\u003D.\u0023\u003DzDQNiLT2p4Vv2RLSA1g\u003D\u003D = new Action<string>(BiasDeterminationTool.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D.\u0023\u003Dzc\u00240prL7i7lUVmzAUqSZca5M\u003D)));
    FilterString filterString = new FilterString(false, false);
    ((FilterBase) filterString).Enabled = false;
    ((Filter<string, FilterString>) filterString).Value = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621918);
    this.\u0023\u003DzWI0IB7sHAK5yrlrSSg\u003D\u003D = filterString;
    // ISSUE: explicit constructor call
    base.\u002Ector(true);
    ((BaseIndicator) this).Panel = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621862);
    ((ExtendedIndicator) this).DenyToChangePanel = true;
    ((ExtendedIndicator) this).DrawAbovePrice = true;
    ((ExtendedIndicator) this).ShowDescription = true;
    ((ExtendedIndicator) this).EnableCustomDrawing = true;
    ((ExtendedIndicator) this).SubscribeToDrawingEvents((DrawingLayouts) 10);
    this.\u0023\u003Dz7m1d_eL_Zz9z = (ValueDataSeries) ((BaseIndicator) this).DataSeries[0];
    ((BaseDataSeries<Decimal>) this.\u0023\u003Dz7m1d_eL_Zz9z).Name = \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.ZeroLineName;
    ((BaseDataSeries<Decimal>) this.\u0023\u003Dz7m1d_eL_Zz9z).Id = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621879);
    ((BaseDataSeries<Decimal>) this.\u0023\u003Dz7m1d_eL_Zz9z).DescriptionKey = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621843);
    this.\u0023\u003Dz7m1d_eL_Zz9z.VisualType = (VisualMode) 0;
    this.\u0023\u003Dz7m1d_eL_Zz9z.Width = 2;
    this.\u0023\u003Dz7m1d_eL_Zz9z.LineDashStyle = (LineDashStyle) 0;
    this.\u0023\u003Dz7m1d_eL_Zz9z.ScaleIt = true;
    this.\u0023\u003Dz7m1d_eL_Zz9z.ShowCurrentValue = true;
    this.\u0023\u003Dz7m1d_eL_Zz9z.ShowZeroValue = true;
    this.\u0023\u003Dz7m1d_eL_Zz9z.Digits = 2;
    this.\u0023\u003Dz7m1d_eL_Zz9z.Color = Extensions.Convert(Color.White);
    ((BaseDataSeries<Decimal>) this.\u0023\u003Dz7m1d_eL_Zz9z).IsHidden = true;
    this.\u0023\u003Dz3cCfLYpb_YmLLvqj3w\u003D\u003D = new \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D((\u0023\u003DzMCqAV2TdtVhLYXKOFbBQU8JKvh4VCrGf0kg244M\u003D) this, this.\u0023\u003Dz7m1d_eL_Zz9z);
    this.\u0023\u003DzeRw6V4UvbPA3 = new ValueDataSeries(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622057), \u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1.BiasLineName);
    ((BaseIndicator) this).DataSeries.Add((IDataSeries) this.\u0023\u003DzeRw6V4UvbPA3);
    this.\u0023\u003DzeRw6V4UvbPA3.VisualType = (VisualMode) 0;
    this.\u0023\u003DzeRw6V4UvbPA3.Width = 2;
    this.\u0023\u003DzeRw6V4UvbPA3.LineDashStyle = (LineDashStyle) 0;
    this.\u0023\u003DzeRw6V4UvbPA3.ScaleIt = true;
    this.\u0023\u003DzeRw6V4UvbPA3.ShowCurrentValue = true;
    this.\u0023\u003DzeRw6V4UvbPA3.ShowZeroValue = true;
    this.\u0023\u003DzeRw6V4UvbPA3.Digits = 2;
    this.\u0023\u003DzeRw6V4UvbPA3.Color = Extensions.Convert(Color.Orange);
    ((BaseDataSeries<Decimal>) this.\u0023\u003DzeRw6V4UvbPA3).IsHidden = true;
    this.\u0023\u003DzZilWa7Zv1THv3bNVdA\u003D\u003D = new \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D((\u0023\u003DzMCqAV2TdtVhLYXKOFbBQU8JKvh4VCrGf0kg244M\u003D) this, this.\u0023\u003DzeRw6V4UvbPA3);
    this.\u0023\u003DzolHeG3kAGPX4CTXCSg\u003D\u003D = new ValueDataSeries(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622028));
    ((BaseDataSeries<Decimal>) this.\u0023\u003DzolHeG3kAGPX4CTXCSg\u003D\u003D).Clear();
    this.\u0023\u003DzAk8DXuLJQxXI = new \u0023\u003DzrkMlj0lxEvO0CDKWztMZ\u0024avNIHTmpwm0Zw\u003D\u003D((\u0023\u003DzE_v\u0024046zbn72ktEU17Mqxy0eVP3qAwnk97oIjss\u003D) this.\u0023\u003DzaU9VydwvgxL3);
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzYZIjb8P83fU0ffLX6M0BV9rIE\u0024\u0024uJDqxIiuhJdp\u0024HL8Snw05hQ\u003D\u003D(1, this.\u0023\u003Dz0XfQvkVQvOI3));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzAPRSxqHCuifWRphx8nJLSD6uZPzfp8koGr7PrA6SbJuEuTBs4w\u003D\u003D(2, this.\u0023\u003DzlWfRcjluN_zM));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003Dz6xM7pX4ELU\u0024h6uA3zkArR0Y05jXOk0FzntJwSbjPum2q34XQnA\u003D\u003D(3, this.\u0023\u003Dz49qAX37_1mUu));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzdPmtjFlkxHfDhl05p01NCo52_v41597hU9gLHiVtfIngDZbJTg\u003D\u003D(4, this.\u0023\u003Dz8oCaw5UneYX2BfQLDQ\u003D\u003D));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzT4rLZ00kqhCuw92Ue9jIXpQz9VeYI76LYACBoKjV4LkfLldtHFIhtqA\u003D(5, this.\u0023\u003Dz\u0024LCGrqJ6quCOWTCCc7U1o\u0024Y\u003D));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzxZKZkq2xEMt3WPmcnMWLReqH2V5Fc9M4mwE1nBDte_AVRup3jT_XXVqvXfu4(6, this.\u0023\u003Dz5GojB7dBsAB5WvS5WIqJUkHRGa8U));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzvfZQcDEN5YR6t9Q79QKMDajdUBJ36Oj4GfPGeuorneBIxdYxcIyVy9I\u003D(7, this.\u0023\u003DzsxmJm89DuC3R32R7DQ\u003D\u003D));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzQEUajLITVHf8aKPQUcNs\u0024YanKS\u0024Ktv0nVxGWfeGix0\u0024mFgRyYw\u003D\u003D(8, this.\u0023\u003Dzm\u0024h6QGJjjfkh));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzTzMluAPj\u0024YJZyfKB988Q_kwZ7myZQfL8ddcihyrzBrqAh0bDMw\u003D\u003D(9, this.\u0023\u003DzV4nEDlm8ttArRkcvLg\u003D\u003D));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003Dzw9O91V2E\u0024DwRWFVXOiyD6qVqJuEhbQZeKWIDTv1SrNwmZW28_JSWVYQ\u003D(10, this.\u0023\u003DzotBBwRt0DAWcD5p3KIoV2xg\u003D));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzClT8aRHxyaWrfTKmc4yWedPr2T3sPkrw2YFKUVYCi38B3iSmEJMHMFmAOz4N(11, this.\u0023\u003Dzbs70LHE7yL\u0024XcXf2fD6EX4sgW5nH));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003DzmZNkr2A\u0024wNpd9cmKpJTvuMRfdjG1QEfoDSA415hW\u0024M7tW\u00249BAA\u003D\u003D(12, this.\u0023\u003DzeVYZl8X3Ilzct69yAg\u003D\u003D));
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzAArywKGskC6C\u0024usiGg\u003D\u003D((\u0023\u003Dzmb_g_mTmoDfFlidPIOqDkBqaTMOgDe7bsVskZejlnRQb5Rdc4w\u003D\u003D) new \u0023\u003Dzprl_Lzmo0ezkSGrJTjrL6P0oiDQljZyqyroH61vxrjaQBtRITDksh7KhnXzl(13, this.\u0023\u003DzdcEPOavj6wDI_HKjYd9cDcHk5hxD));
    BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003DzpU42w8QIdWJm(new EventHandler<\u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D>(this.\u0023\u003DzmEUkanuE3gza));
    this.\u0023\u003DzmEUkanuE3gza();
    BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003Dztx9nKMBKNhbc(this.LicenseSettings.LicenseId ?? string.Empty);
    this.\u0023\u003DzlpvHu6Ch1gwT = new \u0023\u003Dze5rhn\u0024p1WDptqCoga8k19y\u0024bDyhrOwz8t2rkWTM\u003D(new Action(this.\u0023\u003Dz_Iu_hii37hOcItgyIOMwjyc\u003D));
    return;
label_20:
    this.\u0023\u003Dz0XfQvkVQvOI3 = an7ew7bpg9bqV8JyLdg4;
    goto label_10;
label_19:
    this.\u0023\u003DzsxmJm89DuC3R32R7DQ\u003D\u003D = an7ew7bpg9bqV8JyLdg3;
    goto label_9;
label_18:
    this.\u0023\u003Dzbs70LHE7yL\u0024XcXf2fD6EX4sgW5nH = an7ew7bpg9bqV8JyLdg2;
    goto label_8;
label_17:
    this.\u0023\u003Dz\u0024LCGrqJ6quCOWTCCc7U1o\u0024Y\u003D = an7ew7bpg9bqV8JyLdg1;
    goto label_7;
label_16:
    this.\u0023\u003Dzh2zNXnfEmHvc = true;
    goto label_6;
label_15:
    this.\u0023\u003Dz\u0024UScyt9svQbSsnAbSw\u003D\u003D = timeSpan2;
    goto label_5;
label_14:
    this.\u0023\u003Dz2GUpFqYKS3dJdq_Smg\u003D\u003D = timeSpan1;
    goto label_4;
label_13:
    this.\u0023\u003DztZFKou_fAAK8 = drawingLayout;
    goto label_3;
label_12:
    this.\u0023\u003DzrntsJjDd8zu4_09kZw\u003D\u003D = -1;
    goto label_2;
label_11:
    this.\u0023\u003DzaU9VydwvgxL3 = yq3neE2O7viSkWbG4ow;
    goto label_1;
  }

  static BiasDeterminationTool()
  {
    string[] strArray = new string[1]
    {
      \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621993)
    };
    if (true)
      goto label_4;
label_1:
    \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D h1zFxRfwaGeskc0A = new \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D(BiasDeterminationTool.\u0023\u003DzUvPWzec70IrQSNXs5Q\u003D\u003D, string.Empty);
    if (true)
      goto label_5;
label_2:
    string str = Path.Combine(Environment.GetFolderPath((Environment.SpecialFolder) 40, (Environment.SpecialFolderOption) 16384 /*0x4000*/), \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622006), \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772621963));
    if (true)
      goto label_6;
label_3:
    BiasDeterminationTool.\u0023\u003DztiC9Dt6K6YJl = new \u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI_NXMrsMw099qA\u003D\u003D(BiasDeterminationTool.\u0023\u003Dz0uXcOUtdso6D, \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622186));
    return;
label_6:
    BiasDeterminationTool.\u0023\u003Dz0uXcOUtdso6D = str;
    goto label_3;
label_5:
    BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4 = h1zFxRfwaGeskc0A;
    goto label_2;
label_4:
    BiasDeterminationTool.\u0023\u003DzUvPWzec70IrQSNXs5Q\u003D\u003D = strArray;
    goto label_1;
  }

  private void \u0023\u003DzmEUkanuE3gza(
    object _param1,
    \u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D _param2)
  {
    if (false)
      return;
    this.\u0023\u003DzmEUkanuE3gza();
  }

  private void \u0023\u003DzmEUkanuE3gza()
  {
    Application.Current.Dispatcher.Invoke(new Action(this.\u0023\u003DzjlCJru3nMpR3qctv_jAexEE\u003D));
    if (BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003Dz4mPOAEaJQC2J() == (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) 0 || BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003Dz4mPOAEaJQC2J() == (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) 1 || BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003Dz4mPOAEaJQC2J() == (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) 7)
      return;
    int num1 = new \u0023\u003DzEbog_7aS8NJtfAPF\u0024h7hqIC5fj6oryKwzQ\u003D\u003D(BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4, this.InstrumentInfo).\u0023\u003DzFKPDuGGr479x(new \u0023\u003DzG_d_Dtu9n97STGzJ53t4x0joAJZ0iZrxUJI4_Mw\u003D(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622151))) ? 1 : 0;
    if (true)
      goto label_5;
label_3:
    bool flag;
    if (flag == this.\u0023\u003Dz3ryrit9Pys3a)
      return;
    int num2 = flag ? 1 : 0;
    if (true)
      goto label_9;
label_7:
    int num3 = flag ? 1 : 0;
    if (false)
      return;
    this.\u0023\u003DzawBht2N43wHq(num3 != 0);
    return;
label_9:
    this.\u0023\u003Dz3ryrit9Pys3a = num2 != 0;
    goto label_7;
label_5:
    flag = num1 != 0;
    goto label_3;
  }

  private void \u0023\u003DzawBht2N43wHq(bool _param1)
  {
    BiasDeterminationTool.\u0023\u003Dz2beqDExUz2HguAHSVORb9mE\u003D uz2HguAhsvoRb9mE1 = new BiasDeterminationTool.\u0023\u003Dz2beqDExUz2HguAHSVORb9mE\u003D();
    if (true)
      goto label_4;
label_1:
    BiasDeterminationTool.\u0023\u003Dz2beqDExUz2HguAHSVORb9mE\u003D uz2HguAhsvoRb9mE2;
    BiasDeterminationTool.\u0023\u003Dz2beqDExUz2HguAHSVORb9mE\u003D uz2HguAhsvoRb9mE3 = uz2HguAhsvoRb9mE2;
    if (true)
      goto label_5;
label_2:
    BiasDeterminationTool.\u0023\u003Dz2beqDExUz2HguAHSVORb9mE\u003D uz2HguAhsvoRb9mE4 = uz2HguAhsvoRb9mE2;
    int num = _param1 ? 1 : 0;
    if (true)
      goto label_6;
label_3:
    if (!uz2HguAhsvoRb9mE2.\u0023\u003DzmOO4VHM\u003D)
    {
      Application.Current.Dispatcher.Invoke(new Action(uz2HguAhsvoRb9mE2.\u0023\u003Dz47tIWrbAd0GaLVKPhwrmDlg\u003D));
      this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzXmDGAd0\u003D();
    }
    Application.Current.Dispatcher.Invoke(new Action(uz2HguAhsvoRb9mE2.\u0023\u003Dzd_hgM8srrIdI0p02SngfR4Q\u003D));
    this.\u0023\u003DzpY3MKhM0xxlX();
    return;
label_6:
    uz2HguAhsvoRb9mE4.\u0023\u003DzmOO4VHM\u003D = num != 0;
    goto label_3;
label_5:
    uz2HguAhsvoRb9mE3.\u0023\u003DziRnUrnBEE78Y = this;
    goto label_2;
label_4:
    uz2HguAhsvoRb9mE2 = uz2HguAhsvoRb9mE1;
    goto label_1;
  }

  public bool \u0023\u003DzFKPDuGGr479x()
  {
    if (true)
      ;
    return this.\u0023\u003Dz3ryrit9Pys3a;
  }

  public void \u0023\u003DztKUwtct4EoGo()
  {
    if (false)
      return;
    ((ExtendedIndicator) this).RedrawChart((RedrawArg) null);
  }

  protected virtual void OnSourceChanged()
  {
    if (true)
      goto label_3;
label_1:
    if (false)
      return;
    this.\u0023\u003DzpY3MKhM0xxlX();
    return;
label_3:
    ((BaseIndicator) this).OnSourceChanged();
    goto label_1;
  }

  protected virtual void OnDispose()
  {
    BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003Dz99FqoMv_X9u5(new EventHandler<\u0023\u003DzroHoGoiF08fA9zSrm43TYrtAEpJJjasMosonZ9o\u003D>(this.\u0023\u003DzmEUkanuE3gza));
    this.ExternalWindow.\u0023\u003Dz1PYRF8Q\u003D();
    this.\u0023\u003DzlpvHu6Ch1gwT.\u0023\u003DzkAFM460\u003D();
    if (false)
      return;
    ((BaseIndicator) this).OnDispose();
  }

  protected virtual void OnInitialize()
  {
    if (true)
      goto label_2;
label_1:
    if (this.ChartInfo == null)
    {
      if (false)
        return;
      ((BaseIndicator) this).OnInitialize();
      return;
    }
    if (!this.ChartInfo.TimeFrame.ToLower().Equals(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622132)) || !this.ChartInfo.ChartType.ToLower().Equals(\u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622139)))
    {
      string str = \u0023\u003Dzy0JMHjGyrz2wOpXkEUE\u002439QH3Y0y.\u0023\u003DzwjXIadY\u003D(-1772622091);
      object[] objArray = Array.Empty<object>();
      if (true)
        goto label_9;
label_8:
      ((BaseIndicator) this).OnInitialize();
      return;
label_9:
      LoggerHelper.LogError((object) this, str, objArray);
      goto label_8;
    }
    this.\u0023\u003DzzMb92FFEH_vh = true;
    this.\u0023\u003DzrntsJjDd8zu4_09kZw\u003D\u003D = -1;
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzZF1lDKI\u003D(this.InstrumentInfo, this.PlatformSettings);
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzXmDGAd0\u003D();
    this.\u0023\u003DzrntsJjDd8zu4_09kZw\u003D\u003D = -1;
    ((BaseIndicator) this).OnInitialize();
    Task.Run(new Action(this.\u0023\u003DzF9M189q1TZxXZ2REb8gFPFY\u003D));
    if (!this.ExternalWindow.IsOpen)
      return;
    this.ExternalWindow.\u0023\u003DzMBf7m1s\u003D();
    return;
label_2:
    this.\u0023\u003DzzMb92FFEH_vh = false;
    goto label_1;
  }

  protected virtual void OnNewTrade(MarketDataArg _param1)
  {
    MarketDataArg marketDataArg = _param1;
    if (true)
      goto label_2;
label_1:
    this.\u0023\u003DzAk8DXuLJQxXI.\u0023\u003Dz83cfHpyvGQxz(_param1);
    return;
label_2:
    ((ExtendedIndicator) this).OnNewTrade(marketDataArg);
    goto label_1;
  }

  protected virtual void MarketDepthChanged(MarketDataArg _param1)
  {
    MarketDataArg marketDataArg = _param1;
    if (true)
      goto label_2;
label_1:
    this.\u0023\u003DzAk8DXuLJQxXI.\u0023\u003Dz\u0024aAN3fFJMoIH(_param1, true);
    return;
label_2:
    ((ExtendedIndicator) this).MarketDepthChanged(marketDataArg);
    goto label_1;
  }

  private \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoDnKCVU\u0024U2z414exoz2lh7\u0024lJ1CXpw\u003D\u003D \u0023\u003DzwzD2L5Bw\u0024gPd(
    int _param1,
    bool _param2)
  {
    if (_param1 < 1)
      return (\u0023\u003DzcBPX3poEnAp0d2L2_ZuRoDnKCVU\u0024U2z414exoz2lh7\u0024lJ1CXpw\u003D\u003D) null;
    IndicatorCandle candle = ((ExtendedIndicator) this).GetCandle(_param1);
    if (true)
      goto label_6;
label_3:
    \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoDnKCVU\u0024U2z414exoz2lh7\u0024lJ1CXpw\u003D\u003D u2z414exoz2lh7LJ1Cxpw = new \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoDnKCVU\u0024U2z414exoz2lh7\u0024lJ1CXpw\u003D\u003D();
    IndicatorCandle indicatorCandle;
    u2z414exoz2lh7LJ1Cxpw.\u0023\u003DzUTwwEOhCtrzsfydiwQ\u003D\u003D(indicatorCandle);
    u2z414exoz2lh7LJ1Cxpw.\u0023\u003Dz7FmtU2qNKv4L2gAn8w\u003D\u003D(((ExtendedIndicator) this).GetCandle(Math.Max(_param1 - 1, 0)));
    u2z414exoz2lh7LJ1Cxpw.\u0023\u003DznaQbyZYpU9kaN84mLg\u003D\u003D(this.\u0023\u003DzrntsJjDd8zu4_09kZw\u003D\u003D != _param1);
    u2z414exoz2lh7LJ1Cxpw.\u0023\u003DznlCuh5Va2zet(this.IsNewSession(_param1));
    DateTime lastTime = indicatorCandle.LastTime;
    if (true)
      goto label_7;
label_4:
    DateTime dateTime;
    ref DateTime local = ref dateTime;
    IInstrumentInfo instrumentInfo = this.InstrumentInfo;
    double num1 = instrumentInfo != null ? (double) instrumentInfo.TimeZone : 0.0;
    u2z414exoz2lh7LJ1Cxpw.\u0023\u003Dz1H6IAeLgnmvd(local.AddHours(num1));
    u2z414exoz2lh7LJ1Cxpw.\u0023\u003DzgWe7j_IfNunCC94UUg\u003D\u003D(this.\u0023\u003Dz2GUpFqYKS3dJdq_Smg\u003D\u003D);
    u2z414exoz2lh7LJ1Cxpw.\u0023\u003DzCW2_c\u00245XpQcHbOTQ_A\u003D\u003D(this.\u0023\u003Dz\u0024UScyt9svQbSsnAbSw\u003D\u003D);
    if (!_param2)
      return u2z414exoz2lh7LJ1Cxpw;
    int num2 = _param1;
    if (false)
      return u2z414exoz2lh7LJ1Cxpw;
    this.\u0023\u003DzrntsJjDd8zu4_09kZw\u003D\u003D = num2;
    return u2z414exoz2lh7LJ1Cxpw;
label_7:
    dateTime = lastTime;
    goto label_4;
label_6:
    indicatorCandle = candle;
    goto label_3;
  }

  protected virtual void OnCalculate(int _param1, Decimal _param2)
  {
    int num = _param1;
    if (true)
      ;
    if (num == 0)
      return;
    if (true)
      ;
    if (!this.\u0023\u003DzzMb92FFEH_vh)
      return;
    if (true)
      ;
    if (!this.\u0023\u003DzFKPDuGGr479x())
      return;
    this.\u0023\u003DzAk8DXuLJQxXI.\u0023\u003DztzMV18E\u003D(this.\u0023\u003DzwzD2L5Bw\u0024gPd(_param1, true));
    ((BaseDataSeries<Decimal>) this.\u0023\u003DzeRw6V4UvbPA3)[_param1] = Convert.ToDecimal(this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003Dzt1v8TLSrxyw5().Bias);
  }

  internal void \u0023\u003DzpY3MKhM0xxlX()
  {
    if (true)
      ;
    if (!this.\u0023\u003DzFKPDuGGr479x())
      return;
    if (true)
      ;
    if (!this.\u0023\u003DzzMb92FFEH_vh)
      return;
    Dispatcher dispatcher = Application.Current.Dispatcher;
    if (true)
      ;
    // ISSUE: method pointer
    Action callback = new Action((object) this, __methodptr(\u0023\u003Dzd9KBbqUkwEyGECz3FFmsMlQ\u003D));
    dispatcher.Invoke(callback);
  }

  protected virtual void OnRecalculate()
  {
    this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003DzXmDGAd0\u003D();
    if (true)
      goto label_3;
label_1:
    if (false)
      return;
    ((BaseIndicator) this).OnRecalculate();
    return;
label_3:
    this.\u0023\u003DzrntsJjDd8zu4_09kZw\u003D\u003D = -1;
    goto label_1;
  }

  protected virtual void OnFinishRecalculate()
  {
    if (true)
      goto label_3;
label_1:
    if (!this.\u0023\u003DzzMb92FFEH_vh || !this.\u0023\u003DzFKPDuGGr479x() || ((BaseIndicator) this).CurrentBar < 2)
      return;
    this.\u0023\u003DzAk8DXuLJQxXI.\u0023\u003DztdDT\u00245vLese_(this.\u0023\u003DzwzD2L5Bw\u0024gPd(((BaseIndicator) this).CurrentBar - 1, false));
    return;
label_3:
    ((BaseIndicator) this).OnFinishRecalculate();
    goto label_1;
  }

  protected virtual void OnRender(RenderContext _param1, DrawingLayouts _param2)
  {
    RenderContext renderContext1 = _param1;
    DrawingLayouts drawingLayouts = _param2;
    if (true)
      goto label_2;
label_1:
    if (BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003Dz4mPOAEaJQC2J() == (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) 0 || BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003Dz4mPOAEaJQC2J() == (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) 1 || BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4.\u0023\u003Dz4mPOAEaJQC2J() == (\u0023\u003DzPpddU6LXPrXnCx\u0024kirUkI9hya9h9S0586g\u003D\u003D) 7 || this.ChartInfo == null || this.ChartInfo.PriceChartContainer == null)
      return;
    if (_param2 == 2)
    {
      DrawingLayout ztZfKouFAaK8 = this.\u0023\u003DztZFKou_fAAK8;
      RenderContext renderContext2 = _param1;
      Rectangle region1 = ((IContainer) this.ChartInfo.PriceChartContainer).Region;
      if (true)
        goto label_7;
label_5:
      Rectangle rectangle;
      int width = rectangle.Width;
      Rectangle region2 = ((IContainer) this.ChartInfo.PriceChartContainer).Region;
      if (true)
        goto label_8;
label_6:
      int height = rectangle.Height;
      ztZfKouFAaK8.SetSizeAndCheckIsNeedToRedraw(renderContext2, width, height);
      lock (this.\u0023\u003DztZFKou_fAAK8)
      {
        RenderContext renderContext3 = (RenderContext) null;
        try
        {
          renderContext3 = this.\u0023\u003DztZFKou_fAAK8.BeginRender(_param1);
          renderContext3.Clear(Color.Transparent);
          if (renderContext3 == null)
            return;
          renderContext3.SetTextRenderingHint((RenderTextRenderingHint) 1);
          renderContext3.SetSmoothingMode((RenderSmoothingModes) 2);
          this.\u0023\u003DzQ\u0024qWz1pGOJUr(renderContext3);
          return;
        }
        catch (Exception ex)
        {
          return;
        }
        finally
        {
          this.\u0023\u003DztZFKou_fAAK8.EndRender(renderContext3);
        }
      }
label_8:
      rectangle = region2;
      goto label_6;
label_7:
      rectangle = region1;
      goto label_5;
    }
    if (_param2 != 8)
      return;
    lock (this.\u0023\u003DztZFKou_fAAK8)
    {
      _param1.DrawLayout(this.\u0023\u003DztZFKou_fAAK8, new System.Drawing.Point());
      return;
    }
label_2:
    ((ExtendedIndicator) this).OnRender(renderContext1, drawingLayouts);
    goto label_1;
  }

  public void \u0023\u003DzQ\u0024qWz1pGOJUr(RenderContext _param1)
  {
    Bitmap bitmap1 = \u0023\u003Dzm00fAu0pxQgoMO7HbdmrZXuqJRuIAszQ5SBNStuUFsWt.\u0023\u003DzLyo6GOt7zaOa(\u0023\u003DzISbK5nZKgAQb\u0024Ce\u0024sk39WNYd6ZRvMgLAgQ\u003D\u003D.\u0023\u003DzJAqwOM5t6C7p\u0024AVwsYelSvM\u003D(), 150, int.MaxValue);
    if (true)
      goto label_4;
label_1:
    Rectangle region = ((IContainer) this.ChartInfo.PriceChartContainer).Region;
    if (true)
      goto label_5;
label_2:
    Rectangle rectangle;
    Bitmap bitmap2;
    int num = rectangle.Height - ((Image) bitmap2).Height - 20;
    if (true)
      goto label_6;
label_3:
    int y;
    _param1.DrawStaticImage((Image) bitmap2, new Rectangle(10, y, ((Image) bitmap2).Width, ((Image) bitmap2).Height));
    return;
label_6:
    y = num;
    goto label_3;
label_5:
    rectangle = region;
    goto label_2;
label_4:
    bitmap2 = bitmap1;
    goto label_1;
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "GeneralGroupName", Name = "ProductInfoName", Description = "IndicatorDescription", Order = 1)]
  [Editor(typeof (dje_zAYG7KEKSQSJWJ3VVSCKTT6YLYE7EARVU5ZDEBLD258NQA2Z_ejd), typeof (UserControl))]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public string ProductInfo
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzUHm_WqJ0OqxqX7OOcQ\u003D\u003D;
    }
    set
    {
      string str = value;
      if (false)
        return;
      this.\u0023\u003DzUHm_WqJ0OqxqX7OOcQ\u003D\u003D = str;
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "GeneralGroupName", Name = "LicenseIdPropertyName", Order = 2)]
  [Editor(typeof (dje_zUEPDJN2NDLSV25T5T2BN4MK595N5A3ACY6CBASFQ26ZHYVA_ejd), typeof (UserControl))]
  [RefreshProperties(RefreshProperties.All)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public \u0023\u003DzV3UiTijiHdXfWmKuCK5R66fEo1E0SDXgIA\u003D\u003D LicenseSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzoMQy6R0IJVQElSNFYuCzXdE\u003D;
    }
    set
    {
      \u0023\u003DzV3UiTijiHdXfWmKuCK5R66fEo1E0SDXgIA\u003D\u003D ck5R66fEo1E0SdXgIa = value;
      if (false)
        return;
      this.\u0023\u003DzoMQy6R0IJVQElSNFYuCzXdE\u003D = ck5R66fEo1E0SdXgIa;
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "GeneralGroupName", Name = "LicenseStatusPropertyName", Order = 3)]
  [IgnoreDataMember]
  [XmlIgnore]
  [JsonIgnore]
  [JsonIgnore]
  public FilterString LicenseStatus
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzWI0IB7sHAK5yrlrSSg\u003D\u003D;
    }
    set
    {
      FilterString filterString = value;
      if (false)
        return;
      this.\u0023\u003DzWI0IB7sHAK5yrlrSSg\u003D\u003D = filterString;
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "RTHSessionStartTimePropertyName", Description = "RTHSessionStartTimeDescription", Order = 11)]
  public TimeSpan RTHSessionStartTime
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz2GUpFqYKS3dJdq_Smg\u003D\u003D;
    }
    set
    {
      TimeSpan timeSpan = value;
      if (true)
        goto label_3;
label_1:
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
      return;
label_3:
      this.\u0023\u003Dz2GUpFqYKS3dJdq_Smg\u003D\u003D = timeSpan;
      goto label_1;
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "RTHSessionEndTimePropertyName", Description = "RTHSessionEndTimeDescription", Order = 12)]
  public TimeSpan RTHSessionEndTime
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz\u0024UScyt9svQbSsnAbSw\u003D\u003D;
    }
    set
    {
      TimeSpan timeSpan = value;
      if (true)
        goto label_3;
label_1:
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
      return;
label_3:
      this.\u0023\u003Dz\u0024UScyt9svQbSsnAbSw\u003D\u003D = timeSpan;
      goto label_1;
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "DailyCandlePropertyName", Description = "DailyCandleDescription", Order = 17)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D DailyCandleSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz\u0024LCGrqJ6quCOWTCCc7U1o\u0024Y\u003D;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003Dz\u0024LCGrqJ6quCOWTCCc7U1o\u0024Y\u003D.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "HistoricPriceActionPropertyName", Description = "HistoricPriceActionDescription", Order = 23)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D HistoricPriceActionSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dzbs70LHE7yL\u0024XcXf2fD6EX4sgW5nH;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003Dzbs70LHE7yL\u0024XcXf2fD6EX4sgW5nH.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "IBHighLowPropertyName", Description = "IBHighLowDescription", Order = 19)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D InitialBalanceHighLowSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzsxmJm89DuC3R32R7DQ\u003D\u003D;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003DzsxmJm89DuC3R32R7DQ\u003D\u003D.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "InitialMovePropertyName", Description = "InitialMoveDescription", Order = 13)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D InitialMoveSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz0XfQvkVQvOI3;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003Dz0XfQvkVQvOI3.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "InitialMoveExtendedPropertyName", Description = "InitialMoveExtendedDescription", Order = 24)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D InitialMoveExtendedSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzeVYZl8X3Ilzct69yAg\u003D\u003D;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003DzeVYZl8X3Ilzct69yAg\u003D\u003D.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "LiquidityPropertyName", Description = "LiquidityDescription", Order = 22)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D LiquiditySettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzotBBwRt0DAWcD5p3KIoV2xg\u003D;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003DzotBBwRt0DAWcD5p3KIoV2xg\u003D.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "POCPropertyName", Description = "POCDescription", Order = 14)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D POCSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzlWfRcjluN_zM;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003DzlWfRcjluN_zM.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "PVWAPPropertyName", Description = "PVWAPDescription", Order = 16 /*0x10*/)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D PVWAPSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz8oCaw5UneYX2BfQLDQ\u003D\u003D;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003Dz8oCaw5UneYX2BfQLDQ\u003D\u003D.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "SessionDeltaPropertyName", Description = "SessionDeltaDescription", Order = 20)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D SessionDeltaSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dzm\u0024h6QGJjjfkh;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003Dzm\u0024h6QGJjjfkh.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "ValueAreaShiftPropertyName", Description = "ValueAreaShiftDescription", Order = 21)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D ValueAreaShiftSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzV4nEDlm8ttArRkcvLg\u003D\u003D;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003DzV4nEDlm8ttArRkcvLg\u003D\u003D.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "VWAPPropertyName", Description = "VWAPDescription", Order = 15)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D VWAPSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz49qAX37_1mUu;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003Dz49qAX37_1mUu.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "YesterdayHighLowPropertyName", Description = "YesterdayHighLowDescription", Order = 18)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D YesterdayHighLowSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz5GojB7dBsAB5WvS5WIqJUkHRGa8U;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003Dz5GojB7dBsAB5WvS5WIqJUkHRGa8U.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "KeyLevelRejectionPropertyName", Description = "KeyLevelRejectionDescription", Order = 25)]
  public \u0023\u003Dz3q_V_Fn__FW\u0024gXZav1DBAn7ew7bpg9bqV8JYLdg\u003D KeyLevelRejectionSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzdcEPOavj6wDI_HKjYd9cDcHk5hxD;
    }
    set
    {
      if (value == null)
        return;
      this.\u0023\u003DzdcEPOavj6wDI_HKjYd9cDcHk5hxD.\u0023\u003DzzqCSRrs\u003D(value);
      if (false)
        return;
      this.\u0023\u003DzpY3MKhM0xxlX();
    }
  }

  private void \u0023\u003DzhLasHrl_2o3j()
  {
    if (this.\u0023\u003Dz5zTW9uGzoeh0 != null)
      return;
    \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd> dpx2tUkbTvFDWkULiX3M = new \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd>(new Func<dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd>(this.\u0023\u003Dzl9t4EBLfrk5D0vS\u0024xnrF_yo\u003D));
    if (false)
      return;
    this.\u0023\u003Dz5zTW9uGzoeh0 = dpx2tUkbTvFDWkULiX3M;
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasSettingsGroupName", Name = "ExternalWindowPropertyName", Order = 26)]
  public \u0023\u003DznUYq76l5YVG1oavp1Dpx2tUKBTvF_dWk_uLIX3M\u003D<dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd> ExternalWindow
  {
    get
    {
      if (true)
        goto label_2;
label_1:
      return this.\u0023\u003Dz5zTW9uGzoeh0;
label_2:
      this.\u0023\u003DzhLasHrl_2o3j();
      goto label_1;
    }
    set
    {
      if (true)
        goto label_2;
label_1:
      this.\u0023\u003Dz5zTW9uGzoeh0.IsOpen = value.IsOpen;
      return;
label_2:
      this.\u0023\u003DzhLasHrl_2o3j();
      goto label_1;
    }
  }

  private void \u0023\u003DzfeclT6jQC\u0024aTJ0OKuw\u003D\u003D()
  {
    if (this.\u0023\u003DzyW_wT3Pl3K2pY3fa3w\u003D\u003D != null)
      return;
    \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D i7Tc3206rmySneEw = new \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D(new Func<bool>(this.\u0023\u003Dz\u0024rMPXV1QGskhyUnAh56THwpohj_4), new Action<bool>(this.\u0023\u003DznmT0VdQpzGoPrY4CRaH6PIjQSxBU));
    if (false)
      return;
    this.\u0023\u003DzyW_wT3Pl3K2pY3fa3w\u003D\u003D = i7Tc3206rmySneEw;
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasLineGroupName", Name = "EnablePropertyName", Order = 51)]
  public \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D BiasLineEnableDisable
  {
    get
    {
      if (true)
        goto label_2;
label_1:
      return this.\u0023\u003DzyW_wT3Pl3K2pY3fa3w\u003D\u003D;
label_2:
      this.\u0023\u003DzfeclT6jQC\u0024aTJ0OKuw\u003D\u003D();
      goto label_1;
    }
    set
    {
      if (true)
        goto label_2;
label_1:
      this.\u0023\u003DzyW_wT3Pl3K2pY3fa3w\u003D\u003D.Enabled = value.Enabled;
      this.\u0023\u003DzyW_wT3Pl3K2pY3fa3w\u003D\u003D.Value = value.Value;
      return;
label_2:
      this.\u0023\u003DzfeclT6jQC\u0024aTJ0OKuw\u003D\u003D();
      goto label_1;
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasLineGroupName", Name = "LineStylePropertyName", Order = 52)]
  public \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D BiasLineSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003DzZilWa7Zv1THv3bNVdA\u003D\u003D;
    }
    set
    {
      if (true)
        ;
      \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D zilWa7Zv1Thv3bNvdA = this.\u0023\u003DzZilWa7Zv1THv3bNVdA\u003D\u003D;
      \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D ivGtucVwnGlEtVmro = value;
      if (true)
        ;
      zilWa7Zv1Thv3bNvdA.\u0023\u003DzzqCSRrs\u003D(ivGtucVwnGlEtVmro);
    }
  }

  [Display(ResourceType = typeof (\u0023\u003DzV\u0024zgkePC\u0024RPTKeDtxD9_9m_evi02PkQIL7pDCEUjliP1), GroupName = "BiasLineGroupName", Name = "ZeroLineName", Order = 53)]
  public \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D ZeroLineSettings
  {
    get
    {
      if (true)
        ;
      return this.\u0023\u003Dz3cCfLYpb_YmLLvqj3w\u003D\u003D;
    }
    set
    {
      if (true)
        ;
      \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D z3cCfLypbYmLlvqj3w = this.\u0023\u003Dz3cCfLYpb_YmLLvqj3w\u003D\u003D;
      \u0023\u003DzcBPX3poEnAp0d2L2_ZuRoIvGTUC_VWnGlETVmro\u003D ivGtucVwnGlEtVmro = value;
      if (true)
        ;
      z3cCfLypbYmLlvqj3w.\u0023\u003DzzqCSRrs\u003D(ivGtucVwnGlEtVmro);
    }
  }

  private void \u0023\u003Dz_Iu_hii37hOcItgyIOMwjyc\u003D()
  {
    if (true)
      ;
    this.ExternalWindow.\u0023\u003DzK7ksNZI\u003D();
  }

  private void \u0023\u003DzjlCJru3nMpR3qctv_jAexEE\u003D()
  {
    if (true)
      ;
    ((Filter<string, FilterString>) this.LicenseStatus).Value = \u0023\u003DzpRf2M10eCsOCEFfQ4vbbomQ_FcYAiDN7Hw\u003D\u003D.\u0023\u003DzYXcq\u0024dTsx01_(BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4);
  }

  private void \u0023\u003DzF9M189q1TZxXZ2REb8gFPFY\u003D()
  {
    IMarketDepthInfoProvider marketDepthInfo = this.MarketDepthInfo;
    if (marketDepthInfo == null)
      return;
    IEnumerable<MarketDataArg> marketDepthSnapshot = marketDepthInfo.GetMarketDepthSnapshot();
    Action<MarketDataArg> action = new Action<MarketDataArg>(this.\u0023\u003DzgPa7i5tJyVW6XB6hwlJRfJw\u003D);
    if (false)
      return;
    CollectionExtensions.ForEach<MarketDataArg>(marketDepthSnapshot, action, false);
  }

  private void \u0023\u003DzgPa7i5tJyVW6XB6hwlJRfJw\u003D(MarketDataArg _param1)
  {
    if (true)
      ;
    \u0023\u003DzrkMlj0lxEvO0CDKWztMZ\u0024avNIHTmpwm0Zw\u003D\u003D zAk8DxuLjQxXi = this.\u0023\u003DzAk8DXuLJQxXI;
    MarketDataArg marketDataArg = _param1;
    if (true)
      ;
    zAk8DxuLjQxXi.\u0023\u003Dz\u0024aAN3fFJMoIH(marketDataArg, false);
  }

  private void \u0023\u003Dzd9KBbqUkwEyGECz3FFmsMlQ\u003D()
  {
    if (true)
      ;
    ((BaseIndicator) this).RecalculateValues();
  }

  private dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd \u0023\u003Dzl9t4EBLfrk5D0vS\u0024xnrF_yo\u003D()
  {
    if (true)
      ;
    string instrument = this.InstrumentInfo.Instrument;
    if (true)
      ;
    \u0023\u003DzB5Spk1ELCsBWQIfVzTEl8PSP9Xjx7ywK3SKCe\u0024UVEFqLKPpNtBs1rwU\u003D uveFqLkPpNtBs1rwU = this.\u0023\u003DzaU9VydwvgxL3.\u0023\u003Dzt1v8TLSrxyw5();
    return new dje_zCUAVRFX969UUFDM2LG6RHUFPLLBDE6KL5JU9FACVXNQJALQ_ejd(instrument, uveFqLkPpNtBs1rwU);
  }

  private bool \u0023\u003Dz\u0024rMPXV1QGskhyUnAh56THwpohj_4()
  {
    if (true)
      ;
    return this.\u0023\u003Dzh2zNXnfEmHvc;
  }

  private void \u0023\u003DznmT0VdQpzGoPrY4CRaH6PIjQSxBU(bool _param1)
  {
    if (_param1 == this.\u0023\u003Dzh2zNXnfEmHvc)
      return;
    int num = _param1 ? 1 : 0;
    if (true)
      goto label_4;
label_2:
    this.\u0023\u003DzeRw6V4UvbPA3.VisualType = _param1 ? (VisualMode) 0 : (VisualMode) 10;
    this.\u0023\u003Dz7m1d_eL_Zz9z.VisualType = _param1 ? (VisualMode) 0 : (VisualMode) 10;
    if (false)
      return;
    ((ExtendedIndicator) this).RedrawChart((RedrawArg) null);
    return;
label_4:
    this.\u0023\u003Dzh2zNXnfEmHvc = num != 0;
    goto label_2;
  }

  private sealed class \u0023\u003Dz2beqDExUz2HguAHSVORb9mE\u003D
  {
    public BiasDeterminationTool \u0023\u003DziRnUrnBEE78Y;
    public bool \u0023\u003DzmOO4VHM\u003D;

    public \u0023\u003Dz2beqDExUz2HguAHSVORb9mE\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal void \u0023\u003Dz47tIWrbAd0GaLVKPhwrmDlg\u003D()
    {
      if (true)
        ;
      this.\u0023\u003DziRnUrnBEE78Y.BiasLineEnableDisable.Value = false;
    }

    internal void \u0023\u003Dzd_hgM8srrIdI0p02SngfR4Q\u003D()
    {
      if (true)
        ;
      \u0023\u003Dzuw\u0024dzoHUJIQS0UXJeI7\u0024TC3206rmySNEEw\u003D\u003D lineEnableDisable = this.\u0023\u003DziRnUrnBEE78Y.BiasLineEnableDisable;
      if (true)
        ;
      int num = this.\u0023\u003DzmOO4VHM\u003D ? 1 : 0;
      lineEnableDisable.Enabled = num != 0;
    }
  }

  [Serializable]
  private sealed class \u0023\u003DzewGRIik\u003D
  {
    public static readonly BiasDeterminationTool.\u0023\u003DzewGRIik\u003D \u0023\u003DzahaWqVg\u003D;
    public static Action<string> \u0023\u003DzDQNiLT2p4Vv2RLSA1g\u003D\u003D;

    static \u0023\u003DzewGRIik\u003D()
    {
      BiasDeterminationTool.\u0023\u003DzewGRIik\u003D zewGrIik = new BiasDeterminationTool.\u0023\u003DzewGRIik\u003D();
      if (false)
        return;
      BiasDeterminationTool.\u0023\u003DzewGRIik\u003D.\u0023\u003DzahaWqVg\u003D = zewGrIik;
    }

    public \u0023\u003DzewGRIik\u003D()
    {
      if (true)
        ;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    internal void \u0023\u003Dzc\u00240prL7i7lUVmzAUqSZca5M\u003D(string _param1)
    {
      \u0023\u003DzNJWUVdPZ_xxxFLxhEjH1zFxRFwaGEskc0A\u003D\u003D z0W2l5DkSsx4 = BiasDeterminationTool.\u0023\u003Dz0\u0024w2l5DkSSx4;
      string str = _param1;
      if (true)
        ;
      z0W2l5DkSsx4.\u0023\u003Dztx9nKMBKNhbc(str);
    }
  }
}
