#nullable enable
#pragma warning disable 660, 1591, 661, 8600, 8602, 8618
#pragma warning disable CA1050 // Declare types in namespaces
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0824 // Constructor is marked external

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE1006 // Naming Styles
// ReSharper disable All

using System;

/// @CSharpLua.Ignore
internal static class GarrysMod { /* Reserved */ }

/// @CSharpLua.Ignore
public partial class BasePlayer
{
#if SERVER && !FEATURE_PROPERTIES
    public extern virtual void SetEyeAngles(Angle eyeAngles);
#endif
}

/// @CSharpLua.Ignore
public static partial class concommand
{
    /// @CSharpLua.Template = concommand.Add({0}, {1}, {2}, {3}, {4})
    public static extern void Add(string name, Action<BasePlayer, string, string[], string> callback, Func<string, string, string[]>? autoComplete = default, string? helpText = default, FCVAR flags = default);

    /// @CSharpLua.Template = concommand.Remove({0})
    public static extern void Remove(string name);
}
