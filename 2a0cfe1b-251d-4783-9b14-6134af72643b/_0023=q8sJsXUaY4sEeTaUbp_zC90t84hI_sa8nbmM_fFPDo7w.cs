// Decompiled with JetBrains decompiler
// Type: #=q8sJsXUaY4sEeTaUbp_zC90t84hI_sa8nbmM_fFPDo7w=
// Assembly: AlphaX-BiasDetermination, Version=1.1.9471.26094, Culture=neutral, PublicKeyToken=null
// MVID: 9C2C7F3E-FD8B-4CF6-D2F5-05DF247E07E7
// Assembly location: C:\xtra\Indicators_initial\2a0cfe1b-251d-4783-9b14-6134af72643b.dll

using System;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
internal sealed class \u0023\u003Dq8sJsXUaY4sEeTaUbp_zC90t84hI_sa8nbmM_fFPDo7w\u003D : 
  \u0023\u003DqUVQzOv8ro\u00247pv5iwVxjsg\u0024AhEBfggaxSTyQ4bNB\u0024aoc\u003D
{
  private readonly int \u0023\u003Dzv_DK75M\u003D;
  private readonly Stream \u0023\u003DzOsmxM1I\u003D;

  public \u0023\u003Dq8sJsXUaY4sEeTaUbp_zC90t84hI_sa8nbmM_fFPDo7w\u003D(Stream _param1, int _param2)
  {
    Stream stream = _param1;
    if (true)
      goto label_3;
label_1:
    int num = _param2 ^ -559030707;
    if (false)
      return;
    this.\u0023\u003Dzv_DK75M\u003D = num;
    return;
label_3:
    this.\u0023\u003DzOsmxM1I\u003D = stream;
    goto label_1;
  }

  public Stream \u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003DzOsmxM1I\u003D;
  }

  [SpecialName]
  public override bool \u0023\u003DzxL4NTUOAh1RIQ_euvW5\u0024luBRrWyehIjrdpysROdU_zhi8f6ALQ6PIO_1oX1KMCNn06OOwnE\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().CanRead;
  }

  [SpecialName]
  public override bool \u0023\u003DzPkgH6portpv5CYuJmPIg9GuVLpJ10l80hT2UABZn9aUG_L9h4mXIjspJeR2Iva1Idj_lUp\u0024ZU\u00242e()
  {
    if (true)
      ;
    return this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().CanSeek;
  }

  [SpecialName]
  public override bool \u0023\u003Dz0Aj17P0JNtsYgICtp4\u0024T0X2ISaW0WBM\u0024o3HPhHUnmwkSshwOwe0Rmlqj_oqgPTJpD\u0024bCBjdyu9aybqr5SiPRn7w\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().CanWrite;
  }

  public override void \u0023\u003DzCycCfcC5MiH4xd7bsm\u00245mX46pjg1hi_N231YkVk9xusTNRUXS\u0024btiGFjO94UoUwsRfkkeLQXVH7wlbCwEA\u003D\u003D()
  {
    if (true)
      ;
    this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().Flush();
  }

  [SpecialName]
  public override long \u0023\u003DzCnOd1f_jT0Wlc0dynqgYPXtof7eW4ms4NUhJp68YLLklnM3YdDd\u0024DEJ0tsOBL\u00246yqUDCkD\u00246AgWYOOlyIvZJ6xA\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().Length;
  }

  [SpecialName]
  public override long \u0023\u003DzUWjiMzrscdbNirxNE8qbXmJSKC4FCr5qTpPyMVNfz9c7y77twKxesGSMoR\u0024DTE5oOTEZ2NE\u003D()
  {
    if (true)
      ;
    return this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().Position;
  }

  [SpecialName]
  public override void \u0023\u003DzoqGGSxv50nBf7J_lcpaCyXazKs2ZNgFtR4W8C38H\u0024EKh3gfPvmMpqKkYi8sNKdHliMRA94E\u003D(
    long _param1)
  {
    if (true)
      ;
    Stream stream = this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D();
    long num = _param1;
    if (true)
      ;
    stream.Position = num;
  }

  private byte \u0023\u003DzcY2f4ckHEMqJIcnpCWKy\u0024dijmrFtfczG\u0024plZL_U\u003D(
    byte _param1,
    uint _param2)
  {
    int num1 = (int) (byte) ((uint) this.\u0023\u003Dzv_DK75M\u003D ^ _param2);
    if (true)
      goto label_2;
label_1:
    byte num2;
    return (byte) ((uint) _param1 ^ (uint) num2);
label_2:
    num2 = (byte) num1;
    goto label_1;
  }

  public override void \u0023\u003DzxL4NTUOAh1RIQ_euvW5\u0024luBRrWyehIjrdpysROdU_zhbJ9fXnx\u0024yzYWpA\u0024iJycmVAwUeJeFsmW3bRTZBPV1IhNE\u003D(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    int num1 = (int) (uint) this.\u0023\u003DzUWjiMzrscdbNirxNE8qbXmJSKC4FCr5qTpPyMVNfz9c7y77twKxesGSMoR\u0024DTE5oOTEZ2NE\u003D();
    if (true)
      goto label_3;
label_1:
    byte[] numArray1 = new byte[_param3];
    if (true)
      goto label_4;
label_2:
    uint index;
    if (true)
      index = 0U;
    uint num2;
    byte[] numArray2;
    for (; (long) index < (long) _param3; ++index)
      numArray2[(int) index] = this.\u0023\u003DzcY2f4ckHEMqJIcnpCWKy\u0024dijmrFtfczG\u0024plZL_U\u003D(_param1[(long) index + (long) _param2], num2 + index);
    this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().Write(numArray2, 0, _param3);
    return;
label_4:
    numArray2 = numArray1;
    goto label_2;
label_3:
    num2 = (uint) num1;
    goto label_1;
  }

  public override int \u0023\u003Dzqi6bFCsg6IizkjY7gWIf9OnVpfyNfJgDHA7otxFYU\u0024\u0024PMTpQ2pm_sS0kK0AkdjN7zZiVkMr_EWVy\u0024THZuQ\u003D\u003D(
    byte[] _param1,
    int _param2,
    int _param3)
  {
    int num1 = (int) (uint) this.\u0023\u003DzUWjiMzrscdbNirxNE8qbXmJSKC4FCr5qTpPyMVNfz9c7y77twKxesGSMoR\u0024DTE5oOTEZ2NE\u003D();
    if (true)
      goto label_4;
label_1:
    int num2 = this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().Read(_param1, _param2, _param3);
    if (true)
      goto label_5;
label_2:
    int num3;
    int num4 = _param2 + num3;
    if (true)
      goto label_6;
label_3:
    uint num5;
    int num6;
    for (int index = _param2; index < num6; ++index)
      _param1[index] = this.\u0023\u003DzcY2f4ckHEMqJIcnpCWKy\u0024dijmrFtfczG\u0024plZL_U\u003D(_param1[index], num5++);
    return num3;
label_6:
    num6 = num4;
    goto label_3;
label_5:
    num3 = num2;
    goto label_2;
label_4:
    num5 = (uint) num1;
    goto label_1;
  }

  public override long \u0023\u003Dz5aRdfNAj4ntK5EbmqU4JtTQpm5iZUznQIpuVF\u0024YazKWC9R4AjFQtOLojJpnJTa462QE\u0024yNmuV0KnXwsUUg\u003D\u003D(
    long _param1,
    int _param2)
  {
    SeekOrigin seekOrigin;
    switch (_param2)
    {
      case 0:
        if (true)
        {
          seekOrigin = (SeekOrigin) 0;
          break;
        }
        break;
      case 1:
        if (true)
        {
          seekOrigin = (SeekOrigin) 1;
          break;
        }
        break;
      case 2:
        if (true)
        {
          seekOrigin = (SeekOrigin) 2;
          break;
        }
        break;
      default:
        throw new ArgumentException();
    }
    return this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D().Seek(_param1, seekOrigin);
  }

  public override void \u0023\u003DzuZhcyhJQQK1hFvnDVYuiDXyninywWeF4lTiLta0leC4G\u0024KietLhZU1uIwmoJdQtmp6LiYMa127CTJODYnB2FPaeMstlN(
    long _param1)
  {
    if (true)
      ;
    Stream stream = this.\u0023\u003Dz3EZQ9VksxU5W2aAOrsrfTeiMLFiH3O9pxWSJEGg\u003D();
    long num = _param1;
    if (true)
      ;
    stream.SetLength(num);
  }
}
