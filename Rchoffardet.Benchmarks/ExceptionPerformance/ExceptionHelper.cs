using System;
using System.Runtime.CompilerServices;

namespace Rchoffardet.Benchmarks.ExceptionPerformance;

public static class ExceptionHelper
{
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

}