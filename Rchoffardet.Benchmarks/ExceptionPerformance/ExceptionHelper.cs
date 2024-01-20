using System;
using System.Runtime.CompilerServices;

namespace Rchoffardet.Benchmarks.ExceptionPerformance;

public static class ExceptionHelper
{
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn128Calls() => ThrowIn127Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn127Calls() => ThrowIn126Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn126Calls() => ThrowIn125Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn125Calls() => ThrowIn124Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn124Calls() => ThrowIn123Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn123Calls() => ThrowIn122Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn122Calls() => ThrowIn121Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn121Calls() => ThrowIn120Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn120Calls() => ThrowIn119Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn119Calls() => ThrowIn118Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn118Calls() => ThrowIn117Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn117Calls() => ThrowIn116Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn116Calls() => ThrowIn115Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn115Calls() => ThrowIn114Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn114Calls() => ThrowIn113Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn113Calls() => ThrowIn112Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn112Calls() => ThrowIn111Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn111Calls() => ThrowIn110Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn110Calls() => ThrowIn109Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn109Calls() => ThrowIn108Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn108Calls() => ThrowIn107Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn107Calls() => ThrowIn106Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn106Calls() => ThrowIn105Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn105Calls() => ThrowIn104Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn104Calls() => ThrowIn103Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn103Calls() => ThrowIn102Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn102Calls() => ThrowIn101Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn101Calls() => ThrowIn100Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn100Calls() => ThrowIn99Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn99Calls() => ThrowIn98Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn98Calls() => ThrowIn97Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn97Calls() => ThrowIn96Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn96Calls() => ThrowIn95Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn95Calls() => ThrowIn94Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn94Calls() => ThrowIn93Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn93Calls() => ThrowIn92Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn92Calls() => ThrowIn91Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn91Calls() => ThrowIn90Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn90Calls() => ThrowIn89Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn89Calls() => ThrowIn88Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn88Calls() => ThrowIn87Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn87Calls() => ThrowIn86Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn86Calls() => ThrowIn85Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn85Calls() => ThrowIn84Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn84Calls() => ThrowIn83Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn83Calls() => ThrowIn82Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn82Calls() => ThrowIn81Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn81Calls() => ThrowIn80Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn80Calls() => ThrowIn79Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn79Calls() => ThrowIn78Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn78Calls() => ThrowIn77Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn77Calls() => ThrowIn76Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn76Calls() => ThrowIn75Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn75Calls() => ThrowIn74Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn74Calls() => ThrowIn73Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn73Calls() => ThrowIn72Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn72Calls() => ThrowIn71Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn71Calls() => ThrowIn70Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn70Calls() => ThrowIn69Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn69Calls() => ThrowIn68Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn68Calls() => ThrowIn67Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn67Calls() => ThrowIn66Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn66Calls() => ThrowIn65Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn65Calls() => ThrowIn64Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn64Calls() => ThrowIn63Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn63Calls() => ThrowIn62Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn62Calls() => ThrowIn61Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn61Calls() => ThrowIn60Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn60Calls() => ThrowIn59Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn59Calls() => ThrowIn58Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn58Calls() => ThrowIn57Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn57Calls() => ThrowIn56Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn56Calls() => ThrowIn55Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn55Calls() => ThrowIn54Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn54Calls() => ThrowIn53Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn53Calls() => ThrowIn52Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn52Calls() => ThrowIn51Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn51Calls() => ThrowIn50Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn50Calls() => ThrowIn49Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn49Calls() => ThrowIn48Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn48Calls() => ThrowIn47Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn47Calls() => ThrowIn46Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn46Calls() => ThrowIn45Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn45Calls() => ThrowIn44Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn44Calls() => ThrowIn43Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn43Calls() => ThrowIn42Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn42Calls() => ThrowIn41Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn41Calls() => ThrowIn40Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn40Calls() => ThrowIn39Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn39Calls() => ThrowIn38Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn38Calls() => ThrowIn37Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn37Calls() => ThrowIn36Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn36Calls() => ThrowIn35Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn35Calls() => ThrowIn34Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn34Calls() => ThrowIn33Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn33Calls() => ThrowIn32Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn32Calls() => ThrowIn31Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn31Calls() => ThrowIn30Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn30Calls() => ThrowIn29Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn29Calls() => ThrowIn28Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn28Calls() => ThrowIn27Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn27Calls() => ThrowIn26Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn26Calls() => ThrowIn25Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn25Calls() => ThrowIn24Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn24Calls() => ThrowIn23Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn23Calls() => ThrowIn22Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn22Calls() => ThrowIn21Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn21Calls() => ThrowIn20Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn20Calls() => ThrowIn19Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn19Calls() => ThrowIn18Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn18Calls() => ThrowIn17Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn17Calls() => ThrowIn16Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn16Calls() => ThrowIn15Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn15Calls() => ThrowIn14Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn14Calls() => ThrowIn13Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn13Calls() => ThrowIn12Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn12Calls() => ThrowIn11Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn11Calls() => ThrowIn10Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn10Calls() => ThrowIn9Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn9Calls() => ThrowIn8Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn8Calls() => ThrowIn7Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn7Calls() => ThrowIn6Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn6Calls() => ThrowIn5Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn5Calls() => ThrowIn4Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn4Calls() => ThrowIn3Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn3Calls() => ThrowIn2Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn2Calls() => ThrowIn1Call();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1Call() => Throw();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Throw() => throw new InvalidOperationException("Something wrong append.");

    
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn20Calls() => ReturnIn19Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn19Calls() => ReturnIn18Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn18Calls() => ReturnIn17Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn17Calls() => ReturnIn16Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn16Calls() => ReturnIn15Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn15Calls() => ReturnIn14Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn14Calls() => ReturnIn13Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn13Calls() => ReturnIn12Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn12Calls() => ReturnIn11Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn11Calls() => ReturnIn10Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn10Calls() => ReturnIn9Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn9Calls() => ReturnIn8Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn8Calls() => ReturnIn7Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn7Calls() => ReturnIn6Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn6Calls() => ReturnIn5Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn5Calls() => ReturnIn4Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn4Calls() => ReturnIn3Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn3Calls() => ReturnIn2Calls();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn2Calls() => ReturnIn1Call();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ReturnIn1Call() => Return();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Return() => "Something wrong append.";


    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch1CallAndReturnIn20() => ThrowIn1CallAndReturnIn19();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn19() => ThrowIn1CallAndReturnIn18();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn18() => ThrowIn1CallAndReturnIn17();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn17() => ThrowIn1CallAndReturnIn16();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn16() => ThrowIn1CallAndReturnIn15();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn15() => ThrowIn1CallAndReturnIn14();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn14() => ThrowIn1CallAndReturnIn13();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn13() => ThrowIn1CallAndReturnIn12();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn12() => ThrowIn1CallAndReturnIn11();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn11() => ThrowIn1CallAndReturnIn10();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn10() => ThrowIn1CallAndReturnIn9();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn9() => ThrowIn1CallAndReturnIn8();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn8() => ThrowIn1CallAndReturnIn7();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn7() => ThrowIn1CallAndReturnIn6();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn6() => ThrowIn1CallAndReturnIn5();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn5() => ThrowIn1CallAndReturnIn4();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn4() => ThrowIn1CallAndReturnIn3();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn3() => ThrowIn1CallAndReturnIn2();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn2() => ThrowIn1CallAndReturnIn1();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string ThrowIn1CallAndReturnIn1()
    {
        try
        {
            ThrowIn1Call();
            return "";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn10() => Catch10CallAndReturnIn9();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn9() => Catch10CallAndReturnIn8();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn8() => Catch10CallAndReturnIn7();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn7() => Catch10CallAndReturnIn6();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn6() => Catch10CallAndReturnIn5();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn5() => Catch10CallAndReturnIn4();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn4() => Catch10CallAndReturnIn3();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn3() => Catch10CallAndReturnIn2();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn2() => Catch10CallAndReturnIn1();
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch10CallAndReturnIn1()
    {
        try
        {
            ThrowIn10Calls();
            return "";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    
    [MethodImpl(MethodImplOptions.NoInlining)] public static string Catch20CallAndReturnIn1()
    {
        try
        {
            ThrowIn20Calls();
            return "";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}