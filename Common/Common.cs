#nullable enable
#pragma warning disable 660, 1591, 661, 8600, 8602, 8618
#pragma warning disable CA1050 // Declare types in namespaces
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0824 // Constructor is marked external

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE1006 // Naming Styles
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable ConvertToConstant.Global
// ReSharper disable InconsistentNaming
// ReSharper disable AccessToModifiedClosure
// ReSharper disable UnassignedGetOnlyAutoProperty
// ReSharper disable ClassCannotBeInstantiated
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable CheckNamespace
// ReSharper disable InvalidXmlDocComment
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

/// @CSharpLua.Ignore
public static partial class _G
{
    /// @CSharpLua.Template = CLIENT
    public static readonly bool CLIENT =
#if CLIENT
            true
#else
            false
#endif
        ;

    /// @CSharpLua.Template = SERVER
    public static readonly bool SERVER =
#if SERVER
            true
#else
            false
#endif
        ;

    /// @CSharpLua.Template = NULL
    public static readonly BaseEntity NULL;

    internal static extern dynamic REMOVEME_Internal_Return_Hack_REMOVEME();

    /// @CSharpLua.Template = _G.Angle()
    [Pure]
    public static extern Angle Angle();

#if STARFALL
    /// @CSharpLua.Template = _G.Angle({0})
#else
    /// @CSharpLua.Template = _G.Angle({0}, {0}, {0})
#endif
    [Pure]
    public static extern Angle Angle(double pyr);

#if STARFALL
    /// @CSharpLua.Template = _G.Angle({0}, {1})
#else
    /// @CSharpLua.Template = _G.Angle({0}, {1}, 0)
#endif
    [Pure]
    public static extern Angle Angle(double p, double y);

    /// @CSharpLua.Template = _G.Angle({0}, {1}, {2})
    [Pure]
    public static extern Angle Angle(double p, double y, double r);

    /// @CSharpLua.Template = _G.Vector()
    [Pure]
    public static extern Vector Vector();

#if STARFALL
    /// @CSharpLua.Template = _G.Vector({0})
#else
    /// @CSharpLua.Template = _G.Vector({0}, {0}, {0})
#endif
    [Pure]
    public static extern Vector Vector(double xyz);

#if STARFALL
    /// @CSharpLua.Template = _G.Vector({0}, {1})
#else
    /// @CSharpLua.Template = _G.Vector({0}, {1}, 0)
#endif
    [Pure]
    public static extern Vector Vector(double x, double y);

    /// @CSharpLua.Template = _G.Vector({0}, {1}, {2})
    [Pure]
    public static extern Vector Vector(double x, double y, double z);

    /// @CSharpLua.Template = _G.Color({0}, {1}, {2})
    public static extern Color Color(byte red, byte green, byte blue);

    /// @CSharpLua.Template = _G.Color({0}, {1}, {2}, {3})
    public static extern Color Color(byte red, byte green, byte blue, byte alpha);

    /// @CSharpLua.Template = _G.Color({0})
    public static extern Color Color(System.Drawing.Color color);

#if STARFALL
    /// @CSharpLua.Template = holograms.create({0}, {1}, {2})
    public static extern Hologram Hologram(Vector pos, Angle ang, string model);

    /// @CSharpLua.Template = holograms.create({0}, {1}, {2}, {3})
    public static extern Hologram Hologram(Vector pos, Angle ang, string model, Vector scale);
#endif

    /// @CSharpLua.Template = _G.assert({0})
    public static extern void Assert(bool condition);

    /// @CSharpLua.Template = _G.assert({0}, {1})
    public static extern void Assert(bool condition, string errorMessage);

    /// @CSharpLua.Template = _G.error({0}, {1})
    [DoesNotReturn]
    public static extern void Error(string message, uint errorLevel = 1);

    /// @CSharpLua.Template = _G.print({*0})
    public static extern void print(params object?[]? args);

    /// @CSharpLua.Template = _G.print(string.format({0}, {*1}))
    public static extern void printf(string format, params object?[]? args);

    /// @CSharpLua.Template = _G.tonumber({0})
    [Pure]
    public static extern double? tonumber(object? value);

    /// @CSharpLua.Template = _G.tonumber({0}, {1})
    [Pure]
    public static extern double? tonumber(object? value, int radix);

    /// @CSharpLua.Template = _G.tostring({0})
    [Pure]
    public static extern string tostring(object? value);

    /// @CSharpLua.Template = _G.type({0})
    [Pure]
    public static extern string type(object? value);

    /// @CSharpLua.Template = System.Tuple(_G.pcall({0}, {*1}))
    public static extern (bool, object?[]?) pcall<TDelegate>(TDelegate func, params object?[]? args) where TDelegate : Delegate;

    // TODO: requiredir, dodir, dofile

    ////#if STARFALL
    ////  /// @CSharpLua.Template = _G.require({0})
    ////  public static extern void include(string path);

    ////  /// @CSharpLua.Template = _G.require({0})
    ////  public static extern T require<T>(string path);
    ////#else
    ////  /// @CSharpLua.Template = _G.require({0})
    ////  public static extern void require(string path);
    ////#endif

    ///// @CSharpLua.Template = _G.getmetatable({0})
    //public static extern dynamic getmetatable(dynamic table);

    ///// @CSharpLua.Template = _G.setmetatable({0}, {1})
    //public static extern dynamic setmetatable(dynamic table, dynamic? metatable = null);

    ///// @CSharpLua.Template = _G.getfenv({0})
    //public static extern dynamic getfenv(long index = 1);

    ///// @CSharpLua.Template = _G.getfenv({0})
    //public static extern dynamic getfenv<TDelegate>(TDelegate func) where TDelegate : Delegate;

    ///// @CSharpLua.Template = _G.select({0})
    //[Pure]
    //public static extern ulong select(string count = "#");

    ///// @CSharpLua.Template = _G.select({0}, {*1})
    //[Pure]
    //public static extern object? select(ulong index, params object?[]? args);
    ////public static extern T? select<T>(ulong index, params object?[]? args);

    ///// @CSharpLua.Template = _G.unpack({0})
    //[Pure]
    //public static extern object?[]? unpack(dynamic table);

    ///// @CSharpLua.Template = _G.unpack({0}, {1}, {2})
    //[Pure]
    //public static extern object?[]? unpack(dynamic table, double startIndex, double endIndex);

    ///// @CSharpLua.Template = _G.next({0}, {1})
    //[Pure]
    //public static extern (TKey, TValue)? next<TKey, TValue>(dynamic table, TKey key);

    ///// @CSharpLua.Template = _G.next({0}, {1})
    //[Pure]
    //public static extern (int, TValue)? next<TValue>(dynamic table, int index);

    ///// @CSharpLua.Template = _G.next({0}, {1})
    //[Pure]
    //public static extern (string, TValue)? next<TValue>(dynamic table, string index);

    ///// @CSharpLua.Template = _G.rawget({0}, {1})
    //[Pure]
    //public static extern TValue? rawget<TKey, TValue>(dynamic table, TKey key);

    ///// @CSharpLua.Template = _G.rawget({0}, {1})
    //[Pure]
    //public static extern TValue? rawget<TValue>(dynamic table, int index);

    ///// @CSharpLua.Template = _G.rawget({0}, {1})
    //[Pure]
    //public static extern TValue? rawget<TValue>(dynamic table, string index);

    ///// @CSharpLua.Template = _G.rawset({0}, {1}, {2})
    //public static extern void rawset<TKey, TValue>(dynamic table, TKey key, TValue? value);

    ///// @CSharpLua.Template = _G.rawset({0}, {1}, {2})
    //public static extern void rawset<TValue>(dynamic table, int index, TValue? value);

    ///// @CSharpLua.Template = _G.rawset({0}, {1}, {2})
    //public static extern void rawset<TValue>(dynamic table, string index, TValue? value);

#if STARFALL
    /// @CSharpLua.Template = _G.isValid({0})
#else
    /// @CSharpLua.Template = _G.IsValid({0})
#endif
    [Pure]
    public static extern bool IsValid(object value);

#if !STARFALL
    /// @CSharpLua.Template = _G.Msg({0})
    public static extern void Message(string message);

    //[MethodImpl(MethodImplOptions.AggressiveInlining)]
    //public static void Msg(string message) => Message(message);
#endif

#if STARFALL
    /// @CSharpLua.Template = _G.printTable({0})
#else
    /// @CSharpLua.Template = _G.PrintTable({0})
#endif
    public static extern void PrintTable(dynamic table);

#if STARFALL
    /// @CSharpLua.NoField
    public static extern BasePlayer Owner { get; }

    /// @CSharpLua.NoField
    public static extern BaseEntity Chip { get; }

    /// @CSharpLua.Template = _G.owner()
    [Pure]
    public static extern BasePlayer GetOwner();

    /// @CSharpLua.Template = _G.chip()
    [Pure]
    public static extern BaseEntity GetChip();
#endif

#if STARFALL
    /// @CSharpLua.Template = _G.entity({0})
#else
    /// @CSharpLua.Template = _G.Entity({0})
#endif
    [Pure]
    public static extern BaseEntity Entity(int entIndex);

#if STARFALL
    /// @CSharpLua.Template = _G.player({0})
#else
    /// @CSharpLua.Template = _G.Player({0})
#endif
    [Pure]
    public static extern BasePlayer Player(int userId);

#if CLIENT
#if STARFALL
    /// @CSharpLua.Template = _G.player()
#else
    /// @CSharpLua.Template = _G.LocalPlayer()
#endif
    [Pure]
    public static extern BasePlayer LocalPlayer();

#if STARFALL
    /// @CSharpLua.Template = _G.eyePos()
#else
    /// @CSharpLua.Template = _G.EyePos()
#endif
    [Pure]
    public static extern Vector EyePos();

#if STARFALL
    /// @CSharpLua.Template = _G.eyeAngles()
#else
    /// @CSharpLua.Template = _G.EyeAngles()
#endif
    [Pure]
    public static extern Angle EyeAngles();

#if STARFALL
    /// @CSharpLua.Template = _G.eyeVector()
#else
    /// @CSharpLua.Template = _G.EyeVector()
#endif
    [Pure]
    public static extern Vector EyeVector();
#endif

#if STARFALL
    /// @CSharpLua.Template = timer.curtime()
#else
    /// @CSharpLua.Template = _G.CurTime()
#endif
    [Pure]
    public static extern double CurTime();

#if STARFALL
    /// @CSharpLua.Template = timer.frametime()
#else
    /// @CSharpLua.Template = _G.FrameTime()
#endif
    [Pure]
    public static extern double FrameTime();

#if STARFALL
    /// @CSharpLua.Template = timer.realtime()
#else
    /// @CSharpLua.Template = _G.RealTime()
#endif
    [Pure]
    public static extern double RealTime();

#if STARFALL
    /// @CSharpLua.Template = timer.systime()
#else
    /// @CSharpLua.Template = _G.SysTime()
#endif
    [Pure]
    public static extern double SysTime();

#if STARFALL
    /// @CSharpLua.Template = _G.loadstring({0})
    [Pure]
    public static extern Delegate CompileString(string code);
#endif

#if STARFALL
    /// @CSharpLua.Template = _G.loadstring({0}, {1})
#else
    /// @CSharpLua.Template = _G.CompileString({0}, {1})
#endif
    [Pure]
    public static extern Delegate CompileString(string code, string chunkName);

#if STARFALL
    /// @CSharpLua.Template = _G.loadstring({0})
    [Pure]
    public static extern TDelegate CompileString<TDelegate>(string code) where TDelegate : Delegate;
#endif

#if STARFALL
    /// @CSharpLua.Template = _G.loadstring({0}, {1})
#else
    /// @CSharpLua.Template = _G.CompileString({0}, {1})
#endif
    [Pure]
    public static extern TDelegate CompileString<TDelegate>(string code, string chunkName) where TDelegate : Delegate;

#if STARFALL
    /// @CSharpLua.Template = _G.concmd({0})
    public static extern void ConCmd(string command);
#else
#if CLIENT
    /// @CSharpLua.Template = LocalPlayer():ConCommand({0})
    public static extern void ConCmd(string command);

    /// @CSharpLua.Template = _G.RunConsoleCommand({0})
    public static extern void RunConsoleCommand(string command);

    /// @CSharpLua.Template = _G.RunConsoleCommand({0}, {*1})
    public static extern void RunConsoleCommand(string command, params string?[]? args);
#endif
#endif

#if CLIENT
#if STARFALL
    /// @CSharpLua.Template = light.create({0}, {1}, {2}, {3})
    [Pure]
    public static extern DLight DynamicLight(Vector pos, double size, double brightness, Color color);
#else
    /// @CSharpLua.Template = _G.DynamicLight({0}, {1})
    [Pure]
    public static extern DLight DynamicLight(uint index, bool elight = false);
#endif
#endif
}

public sealed class Angle
{
    public double p { get; set; }

    public double y { get; set; }

    public double r { get; set; }

    private extern Angle();

    public double this[int index]
    {
        get
        {
            return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
            /*
            [[
              return this[index]
            ]]
            */
        }
        set
        {
            /*
            [[
              this[index] = value
            ]]
            */
        }
    }

    public static bool operator ==(Angle? left, Angle? right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left == right
        ]]
        */
    }

    public static bool operator !=(Angle? left, Angle? right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left ~= right
        ]]
        */
    }

    public static Angle operator +(Angle left, Angle right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left + right
        ]]
        */
    }

    public static Angle operator -(Angle left, Angle right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left - right
        ]]
        */
    }

    public static Angle operator *(Angle left, Angle right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left * right
        ]]
        */
    }

    public static Angle operator *(Angle left, double right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left * right
        ]]
        */
    }

    public static Angle operator *(double left, Angle right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left * right
        ]]
        */
    }

    public static Angle operator /(Angle left, Angle right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static Angle operator /(Angle left, double right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static Angle operator /(double left, Angle right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static bool operator !(Angle angle)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return not angle
        ]]
        */
    }

    public static Angle operator -(Angle angle)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return -angle
        ]]
        */
    }
}

public sealed class Vector
{
    public double x { get; set; }

    public double y { get; set; }

    public double z { get; set; }

    private extern Vector();

    public double this[int index]
    {
        get
        {
            return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
            /*
            [[
              return this[index]
            ]]
            */
        }
        set
        {
            /*
            [[
              this[index] = value
            ]]
            */
        }
    }

    public static bool operator ==(Vector? left, Vector? right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left == right
        ]]
        */
    }

    public static bool operator !=(Vector? left, Vector? right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left ~= right
        ]]
        */
    }

    public static Vector operator +(Vector left, Vector right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left + right
        ]]
        */
    }

    public static Vector operator -(Vector left, Vector right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left - right
        ]]
        */
    }

    public static Vector operator *(Vector left, Vector right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left * right
        ]]
        */
    }

    public static Vector operator *(Vector left, double right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left * right
        ]]
        */
    }

    public static Vector operator *(double left, Vector right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left * right
        ]]
        */
    }

    public static Vector operator /(Vector left, Vector right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static Vector operator /(Vector left, double right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static Vector operator /(double left, Vector right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static bool operator !(Vector vector)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return not vector
        ]]
        */
    }

    public static Vector operator -(Vector vector)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return -vector
        ]]
        */
    }
}

public sealed class Color
{
    private extern Color();

    public byte r { get; set; }

    public byte g { get; set; }

    public byte b { get; set; }

    public byte a { get; set; }
}

public abstract partial class EventBase
{
    protected EventBase(string eventName, Delegate func, bool captureThis)
    {
        EventName = eventName;
        Function = func;
        CaptureThis = captureThis;
        IsActive = false;
    }

    public string EventName { get; }

    public Delegate Function { get; }

    public bool CaptureThis { get; }

    public bool IsActive { get; private set; }

    private string ID => $"{EventName}.Listener_{strlib.format("%p", Function)}";

    public void Activate(int order = default)
    {
        if (IsActive)
        {
            return;
        }

        // TODO: order/priority support
        if (CaptureThis)
        {
            hook.Add(EventName, ID, this);
        }
        else
        {
            hook.Add(EventName, ID, Function);
        }

        IsActive = true;
    }

    public void Deactivate()
    {
        if (!IsActive)
        {
            return;
        }

        hook.Remove(EventName, ID);
        IsActive = false;
    }
}

public sealed partial class Tick : EventBase
{
    private const string ID =
#if STARFALL
            "tick"
#else
            "Tick"
#endif
        ;

    public Tick(Action func) : base(ID, func, false)
    {
    }

    public Tick(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class Think : EventBase
{
    private const string ID =
#if STARFALL
            "think"
#else
            "Think"
#endif
        ;

    public Think(Action func) : base(ID, func, false)
    {
    }

    public Think(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

#if STARFALL
public sealed partial class ComponentLinked : EventBase
{
    private const string ID = "ComponentLinked";

    public ComponentLinked(Action<BaseEntity> func) : base(ID, func, false)
    {
    }

    public ComponentLinked(Action<EventBase, BaseEntity> func) : base(ID, func, true)
    {
    }
}

public sealed partial class ComponentUnlinked : EventBase
{
    private const string ID = "ComponentUnlinked";

    public ComponentUnlinked(Action<BaseEntity> func) : base(ID, func, false)
    {
    }

    public ComponentUnlinked(Action<EventBase, BaseEntity> func) : base(ID, func, true)
    {
    }
}

public sealed partial class EntityRemoved : EventBase
{
    private const string ID = "EntityRemoved";

    public EntityRemoved(Action<BaseEntity> func) : base(ID, func, false)
    {
    }

    public EntityRemoved(Action<EventBase, BaseEntity> func) : base(ID, func, true)
    {
    }
}

public sealed partial class EntityCreated : EventBase
{
    private const string ID = "OnEntityCreated";

    public EntityCreated(Action<BaseEntity> func) : base(ID, func, false)
    {
    }

    public EntityCreated(Action<EventBase, BaseEntity> func) : base(ID, func, true)
    {
    }
}

//public sealed partial class KeyPress : EventBase {
//  private const string ID = "KeyPress";

//  public KeyPress(Action<BasePlayer, IN> func) : base(ID, func, false) { }

//  public KeyPress(Action<EventBase, BasePlayer, IN> func) : base(ID, func, true) { }
//}

//public sealed partial class KeyRelease : EventBase {
//  private const string ID = "KeyRelease";

//  public KeyRelease(Action<BasePlayer, IN> func) : base(ID, func, false) { }

//  public KeyRelease(Action<EventBase, BasePlayer, IN> func) : base(ID, func, true) { }
//}

public sealed partial class Net : EventBase
{
    private const string ID = "net";

    public Net(Action<string> func) : base(ID, func, false)
    {
    }

    public Net(Action<EventBase, string> func) : base(ID, func, true)
    {
    }

    public Net(Action<string, int> func) : base(ID, func, false)
    {
    }

    public Net(Action<EventBase, string, int> func) : base(ID, func, true)
    {
    }

#if SERVER
    public Net(Action<string, int, BasePlayer> func) : base(ID, func, false)
    {
    }

    public Net(Action<EventBase, string, int, BasePlayer> func) : base(ID, func, true)
    {
    }
#endif
}

//  public sealed partial class Remote : EventBase {
//    private const string ID = "remote";

//    public Remote(Action<BaseEntity, BasePlayer, object?[]?> func) : base(ID, func, false) { }

//    public Remote(Action<EventBase, BaseEntity, BasePlayer, object?[]?> func) : base(ID, func, true) { }
//  }

//  public sealed partial class Remote<TOut> : EventBase {
//    private const string ID = "remote";

//    public Remote(Func<BaseEntity, BasePlayer, object?[]?, TOut> func) : base(ID, func, false) { }

//    public Remote(Func<EventBase, BaseEntity, BasePlayer, object?[]?, TOut> func) : base(ID, func, true) { }
//  }

public sealed partial class PhysgunDrop : EventBase
{
    private const string ID = "PhysgunDrop";

    public PhysgunDrop(Action<BasePlayer, BaseEntity> func) : base(ID, func, false)
    {
    }

    public PhysgunDrop(Action<EventBase, BasePlayer, BaseEntity> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PhysgunPickup : EventBase
{
    private const string ID = "PhysgunPickup";

    public PhysgunPickup(Action<BasePlayer, BaseEntity> func) : base(ID, func, false)
    {
    }

    public PhysgunPickup(Action<EventBase, BasePlayer, BaseEntity> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerNoClip : EventBase
{
    private const string ID = "PlayerNoClip";

    public PlayerNoClip(Action<BasePlayer, bool> func) : base(ID, func, false)
    {
    }

    public PlayerNoClip(Action<EventBase, BasePlayer, bool> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerSwitchWeapon : EventBase
{
    private const string ID = "PlayerSwitchWeapon";

    public PlayerSwitchWeapon(Action<BasePlayer, Weapon, Weapon> func) : base(ID, func, false)
    {
    }

    public PlayerSwitchWeapon(Action<EventBase, BasePlayer, Weapon, Weapon> func) : base(ID, func, true)
    {
    }

    public PlayerSwitchWeapon(Func<BasePlayer, Weapon, Weapon, bool> func) : base(ID, func, false)
    {
    }

    public PlayerSwitchWeapon(Func<EventBase, BasePlayer, Weapon, Weapon, bool> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PropBreak : EventBase
{
    private const string ID = "PropBreak";

    public PropBreak(Action<BasePlayer, BaseEntity> func) : base(ID, func, false)
    {
    }

    public PropBreak(Action<EventBase, BasePlayer, BaseEntity> func) : base(ID, func, true)
    {
    }
}

#if CLIENT
public sealed partial class StarfallUsed : EventBase
{
    private const string ID = "starfallUsed";

    public StarfallUsed(Action<BasePlayer, BaseEntity> func) : base(ID, func, false)
    {
    }

    public StarfallUsed(Action<EventBase, BasePlayer, BaseEntity> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PermissionRequest : EventBase
{
    private const string ID = "permissionrequest";

    public PermissionRequest(Action func) : base(ID, func, false)
    {
    }

    public PermissionRequest(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class HudConnected : EventBase
{
    private const string ID = "hudconnected";

    public HudConnected(Action func) : base(ID, func, false)
    {
    }

    public HudConnected(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class HudDisconnected : EventBase
{
    private const string ID = "huddisconnected";

    public HudDisconnected(Action func) : base(ID, func, false)
    {
    }

    public HudDisconnected(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class HudShouldDraw : EventBase
{
    private const string ID = "hudshoulddraw";

    public HudShouldDraw(Action<string> func) : base(ID, func, false)
    {
    }

    public HudShouldDraw(Action<EventBase, string> func) : base(ID, func, true)
    {
    }

    public HudShouldDraw(Func<string, bool> func) : base(ID, func, false)
    {
    }

    public HudShouldDraw(Func<EventBase, string, bool> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PreDrawHUD : EventBase
{
    private const string ID = "predrawhud";

    public PreDrawHUD(Action func) : base(ID, func, false)
    {
    }

    public PreDrawHUD(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class DrawHUD : EventBase
{
    private const string ID = "drawhud";

    public DrawHUD(Action func) : base(ID, func, false)
    {
    }

    public DrawHUD(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PostDrawHUD : EventBase
{
    private const string ID = "postdrawhud";

    public PostDrawHUD(Action func) : base(ID, func, false)
    {
    }

    public PostDrawHUD(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class RenderScreen : EventBase
{
    private const string ID = "render";

    public RenderScreen(Action func) : base(ID, func, false)
    {
    }

    public RenderScreen(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class RenderOffscreen : EventBase
{
    private const string ID = "renderoffscreen";

    public RenderOffscreen(Action func) : base(ID, func, false)
    {
    }

    public RenderOffscreen(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class RenderScene : EventBase
{
    private const string ID = "renderscene";

    public RenderScene(Action<Vector, Angle, double> func) : base(ID, func, false)
    {
    }

    public RenderScene(Action<EventBase, Vector, Angle, double> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PreDrawOpaqueRenderables : EventBase
{
    private const string ID = "predrawopaquerenderables";

    public PreDrawOpaqueRenderables(Action func) : base(ID, func, false)
    {
    }

    public PreDrawOpaqueRenderables(Action<EventBase> func) : base(ID, func, true)
    {
    }

    public PreDrawOpaqueRenderables(Action<bool, bool> func) : base(ID, func, false)
    {
    }

    public PreDrawOpaqueRenderables(Action<EventBase, bool, bool> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PostDrawOpaqueRenderables : EventBase
{
    private const string ID = "postdrawopaquerenderables";

    public PostDrawOpaqueRenderables(Action func) : base(ID, func, false)
    {
    }

    public PostDrawOpaqueRenderables(Action<EventBase> func) : base(ID, func, true)
    {
    }

    public PostDrawOpaqueRenderables(Action<bool, bool> func) : base(ID, func, false)
    {
    }

    public PostDrawOpaqueRenderables(Action<EventBase, bool, bool> func) : base(ID, func, true)
    {
    }
}

public sealed partial class CalcView : EventBase
{
    private const string ID = "calcview";

    public CalcView(Action<Vector, Angle, double, double, double> func) : base(ID, func, false)
    {
    }

    public CalcView(Action<EventBase, Vector, Angle, double, double, double> func) : base(ID, func, true)
    {
    }
}

//public sealed partial class PlayerButtonDown : EventBase {
//  private const string ID = "inputPressed";

//  public PlayerButtonDown(Action<BUTTON_CODE> func) : base(ID, func, false) { }

//  public PlayerButtonDown(Action<EventBase, BUTTON_CODE> func) : base(ID, func, true) { }
//}

//public sealed partial class PlayerButtonUp : EventBase {
//  private const string ID = "inputReleased";

//  public PlayerButtonUp(Action<BUTTON_CODE> func) : base(ID, func, false) { }

//  public PlayerButtonUp(Action<EventBase, BUTTON_CODE> func) : base(ID, func, true) { }
//}

public sealed partial class MouseMoved : EventBase
{
    private const string ID = "mousemoved";

    public MouseMoved(Action<int, int> func) : base(ID, func, false)
    {
    }

    public MouseMoved(Action<EventBase, int, int> func) : base(ID, func, true)
    {
    }
}

public sealed partial class MouseWheeled : EventBase
{
    private const string ID = "mouseWheeled";

    public MouseWheeled(Action<int> func) : base(ID, func, false)
    {
    }

    public MouseWheeled(Action<EventBase, int> func) : base(ID, func, true)
    {
    }
}

public sealed partial class FinishChat : EventBase
{
    private const string ID = "FinishChat";

    public FinishChat(Action func) : base(ID, func, false)
    {
    }

    public FinishChat(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

//public sealed partial class PlayerChat : EventBase {
//  private const string ID = "PlayerChat";

//  public PlayerChat(Action<BasePlayer, string> func) : base(ID, func, false) { }

//  public PlayerChat(Action<EventBase, BasePlayer, string> func) : base(ID, func, true) { }

//  public PlayerChat(Action<BasePlayer, string, bool> func) : base(ID, func, false) { }

//  public PlayerChat(Action<EventBase, BasePlayer, string, bool> func) : base(ID, func, true) { }

//  public PlayerChat(Action<BasePlayer, string, bool, bool> func) : base(ID, func, false) { }

//  public PlayerChat(Action<EventBase, BasePlayer, string, bool, bool> func) : base(ID, func, true) { }
//}
#endif

#if SERVER
public sealed partial class ClientInitialized : EventBase
{
    private const string ID = "ClientInitialized";

    public ClientInitialized(Action<BasePlayer> func) : base(ID, func, false)
    {
    }

    public ClientInitialized(Action<EventBase, BasePlayer> func) : base(ID, func, true)
    {
    }
}

public sealed partial class InputChanged : EventBase
{
    private const string ID = "input";

    public InputChanged(Action<string, object?> func) : base(ID, func, false)
    {
    }

    public InputChanged(Action<EventBase, string, object?> func) : base(ID, func, true)
    {
    }
}

public sealed partial class Removed : EventBase
{
    private const string ID = "Removed";

    public Removed(Action func) : base(ID, func, false)
    {
    }

    public Removed(Action<EventBase> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerDeath : EventBase
{
    private const string ID = "PlayerDeath";

    public PlayerDeath(Action<BasePlayer, BaseEntity, BaseEntity> func) : base(ID, func, false)
    {
    }

    public PlayerDeath(Action<EventBase, BasePlayer, BaseEntity, BaseEntity> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerDisconnected : EventBase
{
    private const string ID = "PlayerDisconnected";

    public PlayerDisconnected(Action<BasePlayer> func) : base(ID, func, false)
    {
    }

    public PlayerDisconnected(Action<EventBase, BasePlayer> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerInitialSpawn : EventBase
{
    private const string ID = "PlayerInitialSpawn";

    public PlayerInitialSpawn(Action<BasePlayer> func) : base(ID, func, false)
    {
    }

    public PlayerInitialSpawn(Action<EventBase, BasePlayer> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerSpawn : EventBase
{
    private const string ID = "PlayerSpawn";

    public PlayerSpawn(Action<BasePlayer> func) : base(ID, func, false)
    {
    }

    public PlayerSpawn(Action<EventBase, BasePlayer> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerEnteredVehicle : EventBase
{
    private const string ID = "PlayerEnteredVehicle";

    public PlayerEnteredVehicle(Action<BasePlayer, Vehicle> func) : base(ID, func, false)
    {
    }

    public PlayerEnteredVehicle(Action<EventBase, BasePlayer, Vehicle> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerLeaveVehicle : EventBase
{
    private const string ID = "PlayerLeaveVehicle";

    public PlayerLeaveVehicle(Action<BasePlayer, Vehicle> func) : base(ID, func, false)
    {
    }

    public PlayerLeaveVehicle(Action<EventBase, BasePlayer, Vehicle> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerHurt : EventBase
{
    private const string ID = "PlayerHurt";

    public PlayerHurt(Action<BasePlayer, BaseEntity> func) : base(ID, func, false)
    {
    }

    public PlayerHurt(Action<EventBase, BasePlayer, BaseEntity> func) : base(ID, func, true)
    {
    }

    public PlayerHurt(Action<BasePlayer, BaseEntity, int, int> func) : base(ID, func, false)
    {
    }

    public PlayerHurt(Action<EventBase, BasePlayer, BaseEntity, int, int> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerSay : EventBase
{
    private const string ID = "PlayerSay";

    public PlayerSay(Action<BasePlayer, string> func) : base(ID, func, false)
    {
    }

    public PlayerSay(Action<EventBase, BasePlayer, string> func) : base(ID, func, true)
    {
    }

    public PlayerSay(Action<BasePlayer, string, bool> func) : base(ID, func, false)
    {
    }

    public PlayerSay(Action<EventBase, BasePlayer, string, bool> func) : base(ID, func, true)
    {
    }

    public PlayerSay(Func<BasePlayer, string, string?> func) : base(ID, func, false)
    {
    }

    public PlayerSay(Func<EventBase, BasePlayer, string, string?> func) : base(ID, func, true)
    {
    }

    public PlayerSay(Func<BasePlayer, string, bool, string?> func) : base(ID, func, false)
    {
    }

    public PlayerSay(Func<EventBase, BasePlayer, string, bool, string?> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerSpray : EventBase
{
    private const string ID = "PlayerSpray";

    public PlayerSpray(Action<BasePlayer> func) : base(ID, func, false)
    {
    }

    public PlayerSpray(Action<EventBase, BasePlayer> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerSwitchFlashlight : EventBase
{
    private const string ID = "PlayerSwitchFlashlight";

    public PlayerSwitchFlashlight(Action<BasePlayer, bool> func) : base(ID, func, false)
    {
    }

    public PlayerSwitchFlashlight(Action<EventBase, BasePlayer, bool> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerUse : EventBase
{
    private const string ID = "PlayerUse";

    public PlayerUse(Action<BasePlayer, BaseEntity> func) : base(ID, func, false)
    {
    }

    public PlayerUse(Action<EventBase, BasePlayer, BaseEntity> func) : base(ID, func, true)
    {
    }
}

//public sealed partial class PhysgunFreeze : EventBase {
//  private const string ID = "OnPhysgunFreeze";

//  public PhysgunFreeze(Action<BaseEntity, PhysObj, BaseEntity, BasePlayer> func) : base(ID, func, false) { }

//  public PhysgunFreeze(Action<EventBase, BaseEntity, PhysObj, BaseEntity, BasePlayer> func) : base(ID, func, true) { }
//}

public sealed partial class PhysgunReload : EventBase
{
    private const string ID = "OnPhysgunReload";

    public PhysgunReload(Action<Weapon, BasePlayer> func) : base(ID, func, false)
    {
    }

    public PhysgunReload(Action<EventBase, Weapon, BasePlayer> func) : base(ID, func, true)
    {
    }
}
#endif
#endif

public abstract class Realm
{
    public virtual void Main()
    {
    }
}

/// @CSharpLua.Ignore
public static partial class CoreExLib
{
    #region StarfallCompat

    /// @CSharpLua.Template = _G.__String({0})
    [Pure]
    public static extern string str(this string value);

    #endregion

    /// @CSharpLua.Template = {0}[{1}]
    [Pure]
    public static extern T get<T>(this Array array, dynamic index);

    /// @CSharpLua.Template = {0}[{1}]
    [Pure]
    public static extern T get<T>(this T[] array, dynamic index);

    /// @CSharpLua.Template = {0}[{1}]
    [Pure]
    public static extern T get<T>(this IEnumerable<T> array, dynamic index);

    /// @CSharpLua.Template = {0}[{1}]
    [Pure]
    public static extern dynamic get(this Array array, dynamic index);

    /// @CSharpLua.Template = {0}[{1}]
    [Pure]
    public static extern dynamic get(this object array, dynamic index);

    /// @CSharpLua.Template = {0}[{1}] = {2}
    public static extern void set<T>(this Array array, dynamic index, T value);

    /// @CSharpLua.Template = {0}[{1}] = {2}
    public static extern void set<T>(this T[] array, dynamic index, T value);

    /// @CSharpLua.Template = {0}[{1}] = {2}
    public static extern void set<T>(this IEnumerable<T> array, dynamic index, T value);

    /// @CSharpLua.Template = {0}[{1}] = {2}
    public static extern void set(this Array array, dynamic index, dynamic value);

    /// @CSharpLua.Template = {0}[{1}] = {2}
    public static extern void set(this object array, dynamic index, dynamic value);

    /// @CSharpLua.Template = __CoreExLib.ForEach({0}, {1})
    public static extern void each<T>(this Array array, Action<T> body);

    /// @CSharpLua.Template = __CoreExLib.ForEach({0}, {1})
    public static extern void each<T>(this T[] array, Action<T> body);

    /// @CSharpLua.Template = __CoreExLib.ForEach({0}, {1})
    public static extern void each<T>(this IEnumerable<T> array, Action<T> body);

    /// @CSharpLua.Template = __CoreExLib.ForEachI({0}, {1})
    public static extern void each<T>(this Array array, Action<dynamic, T> body);

    /// @CSharpLua.Template = __CoreExLib.ForEachI({0}, {1})
    public static extern void each<T>(this T[] array, Action<dynamic, T> body);

    /// @CSharpLua.Template = __CoreExLib.ForEachI({0}, {1})
    public static extern void each<T>(this IEnumerable<T> array, Action<dynamic, T> body);

    /// @CSharpLua.Template = __CoreExLib.ForEach_Func({0}, {1})
    public static extern void each<T>(this Array array, Func<T, bool> body);

    /// @CSharpLua.Template = __CoreExLib.ForEach_Func({0}, {1})
    public static extern void each<T>(this T[] array, Func<T, bool> body);

    /// @CSharpLua.Template = __CoreExLib.ForEach_Func({0}, {1})
    public static extern void each<T>(this IEnumerable<T> array, Func<T, bool> body);

    /// @CSharpLua.Template = __CoreExLib.ForEachI_Func({0}, {1})
    public static extern void each<T>(this Array array, Func<dynamic, T, bool> body);

    /// @CSharpLua.Template = __CoreExLib.ForEachI_Func({0}, {1})
    public static extern void each<T>(this T[] array, Func<dynamic, T, bool> body);

    /// @CSharpLua.Template = __CoreExLib.ForEachI_Func({0}, {1})
    public static extern void each<T>(this IEnumerable<T> array, Func<dynamic, T, bool> body);
}


#if CLIENT
/// @CSharpLua.Ignore
public sealed class DLight
{
#if STARFALL
    /// @CSharpLua.Template = light.create({0}, {1}, {2}, {3})
    public extern DLight(Vector pos, double size, double brightness, Color color);
#else
    /// @CSharpLua.Template = _G.DynamicLight({0}, {1})
    public extern DLight(uint index, bool elight = false);
#endif

    public double brightness { get; set; }

    public uint decay { get; set; }

    public double dietime { get; set; }

    public Vector dir { get; set; }

    public double innerangle { get; set; }

    public double outerangle { get; set; }

    //public double key { get; set; }

    public double minlight { get; set; }

    public bool noworld { get; set; }

    public bool nomodel { get; set; }

    public Vector pos { get; set; }

    public double size { get; set; }

    public byte style { get; set; }

    public byte r { get; set; }

    public byte g { get; set; }

    public byte b { get; set; }
}

/// @CSharpLua.Ignore
public sealed class CamData
{
    // TODO

    /// @CSharpLua.Template = CamData_ctor1({0}, {1}, {2}, {3}, {4}, {5}, {6})
    public extern CamData(Vector origin, Angle angles, double fov, double zNear, double zFar, bool drawViewer = false, CamData_Ortho? ortho = default);

    /// @CSharpLua.Template = CamData_ctor2({0}, {1}, {2}, {3}, {4})
    public extern CamData(Vector origin, Angle angles, double fov, double zNear, double zFar);

    /// @CSharpLua.Template = CamData_ctor3({0}, {1}, {2}, {3}, {4}, {5})
    public extern CamData(Vector origin, Angle angles, double fov, double zNear, double zFar, bool drawViewer);

    /// @CSharpLua.Template = CamData_ctor4({0}, {1}, {2}, {3}, {4}, {5})
    public extern CamData(Vector origin, Angle angles, double fov, double zNear, double zFar, CamData_Ortho ortho);

    /// @CSharpLua.Template = CamData_ctor5({0}, {1}, {2}, {3}, {4}, {5}, {6})
    public extern CamData(Vector origin, Angle angles, double fov, double zNear, double zFar, CamData_Ortho ortho, bool drawViewer);

    public Vector origin { get; set; }

    public Angle angles { get; set; }

    public double fov { get; set; }

    public double znear { get; set; }

    public double zfar { get; set; }

    public bool drawviewer { get; set; }

    public CamData_Ortho? ortho { get; set; }
}

/// @CSharpLua.Ignore
public sealed class CamData_Ortho
{
    // TODO

    /// @CSharpLua.Template = CamData_Ortho_ctor({0}, {1}, {2}, {3})
    public extern CamData_Ortho(double left, double right, double top, double bottom);

    public double left { get; set; }

    public double right { get; set; }

    public double top { get; set; }

    public double bottom { get; set; }
}
#endif

/// @CSharpLua.Ignore
public sealed class Debug_GetInfo
{
    private extern Debug_GetInfo();

    public long? currentline { get; }

#if !STARFALL
    public Delegate? func { get; }
#endif

    public long? lastlinedefined { get; }

    public long? linedefined { get; }

    public string? name { get; }

    public string? namewhat { get; }

    public ulong? nparams { get; }

    public ulong? nups { get; }

    public string? short_src { get; }

    public string? source { get; }

    public string? what { get; }
}

/// @CSharpLua.Ignore
public static partial class debug
{
#if STARFALL
    /// @CSharpLua.Template = _G.debugGetInfo({0}, {1})
#else
    /// @CSharpLua.Template = debug.getinfo({0}, {1})
#endif
    [Pure]
    public static extern Debug_GetInfo? GetInfo<TDelegate>(TDelegate func, string flags = "flnSu") where TDelegate : Delegate;

#if STARFALL
    /// @CSharpLua.Template = _G.debugGetInfo({0}, {1})
#else
    /// @CSharpLua.Template = debug.getinfo({0}, {1})
#endif
    [Pure]
    public static extern Debug_GetInfo? GetInfo(ulong index, string flags = "flnSu");

#if STARFALL
    /// @CSharpLua.Template = System.Tuple(_G.debugGetLocal({0}, {1}))
#else
    /// @CSharpLua.Template = System.Tuple(debug.getlocal({0}, {1}))
#endif
    [Pure]
    public static extern (string?, TLocal?) GetLocal<TDelegate, TLocal>(TDelegate func, long index) where TDelegate : Delegate;

#if STARFALL
    /// @CSharpLua.Template = System.Tuple(_G.debugGetLocal({0}, {1}))
#else
    /// @CSharpLua.Template = System.Tuple(debug.getlocal({0}, {1}))
#endif
    [Pure]
    public static extern (string?, TLocal?) GetLocal<TLocal>(ulong level, long index);
}

/// @CSharpLua.Ignore
public partial class BaseEntity
{
#if STARFALL
    /// @CSharpLua.Template = _G.entity({0})
#else
    /// @CSharpLua.Template = _G.Entity({0})
#endif
    public extern BaseEntity(int entIndex);

    [Pure]
#if STARFALL
    public extern bool isValid();
#else
    public extern bool IsValid();
#endif

#if SERVER
    [Pure]
#if STARFALL
    public extern bool isValidPhys();
#else
    public extern bool IsValidPhys();
#endif
#endif

    [Pure]
#if STARFALL
    public extern bool isPlayer();
#else
    public extern bool IsPlayer();
#endif

    [Pure]
#if STARFALL
    public extern bool isVehicle();
#else
    public extern bool IsVehicle();
#endif

    [Pure]
#if STARFALL
    public extern bool isWeapon();
#else
    public extern bool IsWeapon();
#endif

    [Pure]
#if STARFALL
    public extern bool isOnFire();
#else
    public extern bool IsOnFire();
#endif

    [Pure]
#if STARFALL
    public extern bool isOnGround();
#else
    public extern bool IsOnGround();
#endif

#if SERVER
    [Pure]
#if STARFALL
    public extern bool isPlayerHolding();
#else
    public extern bool IsPlayerHolding();
#endif

    [Pure]
#if STARFALL
    public extern BaseEntity isWeldedTo();
#else
    public extern BaseEntity IsWeldedTo();
#endif
#endif

    [Pure]
#if STARFALL
    public extern int entIndex();
#else
    public extern int EntIndex();
#endif

    [Pure]
#if STARFALL
    public extern BaseEntity entOwner();
#else
    public extern BaseEntity GetOwner();
#endif

#if STARFALL
    /// @CSharpLua.NoField
    public extern BasePlayer Owner { get; }
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int Health
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern int getHealth();
#else
    [Pure]
    public extern int GetHealth();
#if SERVER
    public extern void SetHealth(int health);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int MaxHealth
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern int getMaxHealth();
#else
    [Pure]
    public extern int GetMaxHealth();
#if SERVER
    public extern void SetMaxHealth(int maxHealth);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Color Color
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern Color getColor();
#if SERVER
    public extern void setColor(Color color);
#endif
#else
    [Pure]
    public extern Color GetColor();
#if SERVER
    public extern void SetColor(Color color);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Vector Pos
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern Vector getPos();
#if SERVER
    public extern void setPos(Vector pos);
#endif
#else
    [Pure]
    public extern Vector GetPos();
#if SERVER
    public extern void SetPos(Vector pos);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Angle Angles
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern Angle getAngles();
#if SERVER
    public extern void setAngles(Angle angles);
#endif
#else
    [Pure]
    public extern Angle GetAngles();
#if SERVER
    public extern void SetAngles(Angle angles);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public virtual Vector EyePos { get; }
#else
    [Pure]
#if STARFALL
    public extern virtual Vector getEyePos();
#else
    public extern virtual Vector EyePos();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public virtual Angle EyeAngles { get; }
#else
    [Pure]
#if STARFALL
    public extern virtual Angle getEyeAngles();
#else
    public extern virtual Angle EyeAngles();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Vector Velocity
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern Vector getVelocity();
#if SERVER
    public extern void setVelocity(Vector velocity);
#endif
#else
    [Pure]
    public extern Vector GetVelocity();
#if SERVER
    public extern void SetVelocity(Vector velocity);
#endif
#endif
#endif

#if STARFALL && SERVER
    public extern void unparent();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public virtual BaseEntity? Parent
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern virtual BaseEntity? getParent();
#if SERVER
    public extern virtual void setParent(BaseEntity? parent);
#endif
#else
    [Pure]
    public extern virtual BaseEntity? GetParent();
#if SERVER
    public extern virtual void SetParent(BaseEntity? parent);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public string Material
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern string getMaterial();
#if SERVER
    public extern void setMaterial(string material);
#endif
#else
    [Pure]
    public extern string GetMaterial();
#if SERVER
    public extern void SetMaterial(string material);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Vector Forward { get; }
#else
    [Pure]
#if STARFALL
    public extern Vector getForward();
#else
    public extern Vector GetForward();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Vector Right { get; }
#else
    [Pure]
#if STARFALL
    public extern Vector getRight();
#else
    public extern Vector GetRight();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public double CreationTime { get; }
#else
    [Pure]
#if STARFALL
    public extern double getCreationTime();
#else
    public extern double GetCreationTime();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public COLLISION_GROUP CollisionGroup
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern COLLISION_GROUP getCollisionGroup();
#if SERVER
    public extern void setCollisionGroup(COLLISION_GROUP collisionGroup);
#endif
#else
    [Pure]
    public extern COLLISION_GROUP GetCollisionGroup();
#if SERVER
    public extern void SetCollisionGroup(COLLISION_GROUP collisionGroup);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public bool Persistent
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern bool getPersistent();
#if SERVER
    public extern void setPersistent(bool persistent);
#endif
#else
    [Pure]
    public extern bool GetPersistent();
#if SERVER
    public extern void SetPersistent(bool persistent);
#endif
#endif
#endif

#if STARFALL
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public BaseEntity[] LinkedComponents { get; }
#else
    [Pure]
    public extern BaseEntity[] getLinkedComponents();
#endif
#endif

#if STARFALL && SERVER
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Wirelink Wirelink { get; }
#else
    [Pure]
    public extern Wirelink getWirelink();
#endif
#endif

    [Pure]
    public extern (Vector, Vector) GetHitBoxBounds(int hitbox, int group = 0);

    [Pure]
    public extern int GetHitBoxCount(int group);

    // TODO
}

/// @CSharpLua.Ignore
public partial class BasePlayer : BaseEntity
{
#if STARFALL
    /// @CSharpLua.Template = _G.player({0})
#else
    /// @CSharpLua.Template = _G.Player({0})
#endif
    public extern BasePlayer(int userId);

    [Pure]
#if STARFALL
    public extern bool isAlive();
#else
    public extern bool Alive();
#endif

    [Pure]
#if STARFALL
    public extern bool isBot();
#else
    public extern bool IsBot();
#endif

    [Pure]
#if STARFALL
    public extern bool isNPC();
#else
    public extern bool IsNPC();
#endif

    [Pure]
#if STARFALL
    public extern bool isConnected();
#else
    public extern bool IsConnected();
#endif

    [Pure]
#if STARFALL
    public extern bool isAdmin();
#else
    public extern bool IsAdmin();
#endif

    [Pure]
#if STARFALL
    public extern bool isSuperAdmin();
#else
    public extern bool IsSuperAdmin();
#endif

    [Pure]
#if STARFALL
    public extern bool isCrouching();
#else
    public extern bool Crouching();
#endif

    [Pure]
#if STARFALL
    public extern bool isSprinting();
#else
    public extern bool IsSprinting();
#endif

    [Pure]
#if STARFALL
    public extern bool isFrozen();
#else
    public extern bool IsFrozen();
#endif

#if STARFALL
    [Pure]
    public extern bool isNoclipped();
#endif

    [Pure]
#if STARFALL
    public extern bool isFlashlightOn();
#else
    public extern bool FlashlightIsOn();
#endif

    [Pure]
#if STARFALL
    public extern bool isTyping();
#else
    public extern bool IsTyping();
#endif

    [Pure]
#if STARFALL
    public extern bool isUserGroup(string group);
#else
    public extern bool IsUserGroup(string group);
#endif

    [Pure]
#if STARFALL
    public extern bool inVehicle();
#else
    public extern bool InVehicle();
#endif

    [Pure]
#if STARFALL
    public extern bool hasGodMode();
#else
    public extern bool HasGodMode();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int Armor
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern int getArmor();
#else
    [Pure]
    public extern int GetArmor();
#if SERVER
    public extern void SetArmor(int armor);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int MaxArmor
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern int getMaxArmor();
#else
    [Pure]
    public extern int GetMaxArmor();
#if SERVER
    public extern void SetMaxArmor(int maxArmor);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int Team
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern int getTeam();
#else
    [Pure]
    public extern int GetTeam();
#if SERVER
    public extern void SetTeam(int team);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int Deaths
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern int getDeaths();
#else
    [Pure]
    public extern int GetDeaths();
#if SERVER
    public extern void SetDeaths(int deaths);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int Frags
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern int getFrags();
#else
    [Pure]
    public extern int GetFrags();
#if SERVER
    public extern void SetFrags(int frags);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Weapon ActiveWeapon
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern Weapon getActiveWeapon();
#else
    [Pure]
    public extern Weapon GetActiveWeapon();
#if SERVER
    public extern void SetActiveWeapon(Weapon activeWeapon);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Vector AimVector { get; }
#else
    [Pure]
#if STARFALL
    public extern Vector getAimVector();
#else
    public extern Vector GetAimVector();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public double FOV
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern double getFOV();
#else
    [Pure]
    public extern double GetFOV();
#if SERVER
    public extern void SetFOV(double fov);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public double JumpPower
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern double getJumpPower();
#else
    [Pure]
    public extern Double GetJumpPower();
#if SERVER
    public extern void SetJumpPower(double jumpPower);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public double MaxSpeed
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern double getMaxSpeed();
#else
    [Pure]
    public extern double GetMaxSpeed();
#if SERVER
    public extern void SetMaxSpeed(double maxSpeed);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public double RunSpeed
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern double getRunSpeed();
#else
    [Pure]
    public extern double GetRunSpeed();
#if SERVER
    public extern void SetRunSpeed(double runSpeed);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Vector ShootPos { get; }
#else
    [Pure]
#if STARFALL
    public extern Vector getShootPos();
#else
    public extern Vector GetShootPos();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Vehicle Vehicle { get; }
#else
    [Pure]
#if STARFALL
    public extern Vehicle getVehicle();
#else
    public extern Vehicle GetVehicle();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int Ping { get; }
#else
    [Pure]
#if STARFALL
    public extern int getPing();
#else
    public extern int Ping();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int UserID { get; }
#else
    [Pure]
#if STARFALL
    public extern int getUserID();
#else
    public extern int UserID();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public string SteamID { get; }
#else
    [Pure]
#if STARFALL
    public extern string getSteamID();
#else
    public extern string SteamID();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public string SteamID64 { get; }
#else
    [Pure]
#if STARFALL
    public extern string getSteamID64();
#else
    public extern string SteamID64();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public string Name { get; }
#else
    [Pure]
#if STARFALL
    public extern string getName();
#else
    public extern string Name();

    public extern string Nick();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public TraceResult EyeTrace { get; }
#else
    [Pure]
#if STARFALL
    public extern TraceResult getEyeTrace();
#else
    public extern TraceResult GetEyeTrace();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public BaseEntity ViewEntity
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern BaseEntity getViewEntity();
#else
    [Pure]
    public extern BaseEntity GetViewEntity();
#if SERVER
    public extern void SetViewEntity(BaseEntity viewEntity);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public BaseEntity ViewModel { get; }
#else
    [Pure]
#if STARFALL
    public extern BaseEntity getViewModel();
#else
    public extern BaseEntity GetViewModel();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Weapon[] Weapons { get; }
#else
    [Pure]
#if STARFALL
    public extern Weapon[] getWeapons();
#else
    public extern Weapon[] GetWeapons();
#endif
#endif

    [Pure]
#if STARFALL
    public extern Weapon getWeapon(string className);
#else
    public extern Weapon GetWeapon(string className);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public BaseEntity GroundEntity
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern BaseEntity getGroundEntity();
#else
    [Pure]
    public extern BaseEntity GetGroundEntity();
#if SERVER
    public extern void SetGroundEntity(BaseEntity groundEntity);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public int AmmoCount { get; }
#else
    [Pure]
#if STARFALL
    public extern int getAmmoCount();
#else
    public extern int AmmoCount();
#endif
#endif

    [Pure]
#if STARFALL
    public extern bool keyDown(IN_KEY key);
#else
    public extern bool KeyDown(IN_KEY key);
#endif

#if CLIENT

    [Pure]
#if STARFALL
    public extern bool isMuted();
#else
    public extern bool IsMuted();
#endif

    [Pure]
#if STARFALL
    public extern bool isSpeaking();
#else
    public extern bool IsSpeaking();
#endif

    [Pure]
#if STARFALL
    public extern double voiceVolume();
#else
    public extern double VoiceVolume();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public string FriendStatus { get; }
#else
    [Pure]
#if STARFALL
    public extern string getFriendStatus();
#else
    public extern string GetFriendStatus();
#endif
#endif

#endif
}

#if SERVER
/// @CSharpLua.Ignore
public partial class NPC : BaseEntity
{
#if STARFALL
    /// @CSharpLua.Template = _G.entity({0})
#else
    /// @CSharpLua.Template = _G.Entity({0})
#endif
    public extern NPC(int entIndex);
}
#endif

/// @CSharpLua.Ignore
public partial class PhysObj
{
    // Mostly useless on client.
    // TODO
}

/// @CSharpLua.Ignore
public partial class Vehicle : BaseEntity
{
#if STARFALL
    /// @CSharpLua.Template = _G.entity({0})
#else
    /// @CSharpLua.Template = _G.Entity({0})
#endif
    public extern Vehicle(int entIndex);
}

/// @CSharpLua.Ignore
public partial class Weapon : BaseEntity
{
#if STARFALL
    /// @CSharpLua.Template = _G.entity({0})
#else
    /// @CSharpLua.Template = _G.Entity({0})
#endif
    public extern Weapon(int entIndex);
}

#if STARFALL && SERVER
/// @CSharpLua.Ignore
public partial class Wirelink
{
    /// @CSharpLua.Template = wire.getWirelink({0})
    public extern Wirelink(BaseEntity entity);

    public extern BaseEntity entity();

    public extern bool isValid();

    public extern bool isWired(string inputName);

    public extern BaseEntity getWiredTo(string inputName);

    public extern string getWiredToName(string inputName);

    public extern string inputType(string inputName);

    public extern string outputType(string outputName);

    public extern dynamic inputs();

    public extern dynamic outputs();
}

/// @CSharpLua.Ignore
public static partial class wire
{
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern Wirelink Self { get; }
#else
    /// @CSharpLua.Template = wire.self()
    [Pure]
    public static extern Wirelink Self();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern dynamic Ports { get; }
#else
    /// @CSharpLua.Template = wire.ports
    [Pure]
    public static extern dynamic Ports();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern string ServerUUID { get; }
#else
    /// @CSharpLua.Template = wire.serverUUID()
    [Pure]
    public static extern string ServerUUID();
#endif

    /// @CSharpLua.Template = wire.getWirelink({0})
    [Pure]
    public static extern Wirelink GetWirelink(BaseEntity entity);

    /// @CSharpLua.Template = wire.create({0}, {1}, {2}, {3})
    public static extern void Create(BaseEntity entityWithInput, BaseEntity entityWithOutput, string inputName, string outputName);

    /// @CSharpLua.Template = wire.create({0}, {1}, {2}, {3}, {4}, {5}, {6})
    public static extern void Create(BaseEntity entityWithInput, BaseEntity entityWithOutput, string inputName, string outputName, double width, Color? color = default, string? material = default);

    /// @CSharpLua.Template = wire.delete({0}, {1})
    public static extern void Delete(BaseEntity entityWithInput, string inputName);

    /// @CSharpLua.Template = wire.getInputs({0})
    [Pure]
    public static extern (string[], string[]) GetInputs(BaseEntity entity);

    /// @CSharpLua.Template = wire.getOutputs({0})
    [Pure]
    public static extern (string[], string[]) GetOutputs(BaseEntity entity);

    /// @CSharpLua.Template = wire.addInput({0}, {1})
    public static extern bool AddInput(string inputName, string inputType);

    /// @CSharpLua.Template = wire.addOutput({0}, {1})
    public static extern bool AddOutput(string outputName, string outputType);

    /// @CSharpLua.Template = wire.removeInput({0})
    public static extern bool RemoveInput(string inputName);

    /// @CSharpLua.Template = wire.removeOutput({0})
    public static extern bool RemoveOutput(string outputName);

    /// @CSharpLua.Template = wire.getInputType({0})
    [Pure]
    public static extern string? GetInputType(string inputName);

    /// @CSharpLua.Template = wire.getOutputType({0})
    [Pure]
    public static extern string? GetOutputType(string outputName);

    /// @CSharpLua.Template = wire.setInputType({0}, {1})
    public static extern bool SetInputType(string inputName, string inputType);

    /// @CSharpLua.Template = wire.setOutputType({0}, {1})
    public static extern bool SetOutputType(string outputName, string outputType);

    /// @CSharpLua.Template = wire.getInput({0})
    [Pure]
    public static extern T GetInput<T>(string inputName);

    /// @CSharpLua.Template = wire.getOutput({0})
    [Pure]
    public static extern T GetOutput<T>(string outputName);

    /// @CSharpLua.Template = wire.setOutput({0}, {1})
    public static extern void SetOutput<T>(string outputName, T value);
}

/// @CSharpLua.Ignore
public static partial class prop
{
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool PropClean { get; set; }
#else
    /// @CSharpLua.Template = prop.getPropClean()
    [Pure]
    public static extern bool GetPropClean();

    /// @CSharpLua.Template = prop.setPropClean({0})
    public static extern void SetPropClean(bool propClean);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool PropUndo { get; set; }
#else
    /// @CSharpLua.Template = prop.getPropUndo()
    [Pure]
    public static extern bool GetPropUndo();

    /// @CSharpLua.Template = prop.setPropUndo({0})
    public static extern void SetPropUndo(bool propUndo);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool CanSpawn { get; }
#else
    /// @CSharpLua.Template = prop.canSpawn()
    [Pure]
    public static extern bool CanSpawn();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern int PropsLeft { get; }
#else
    /// @CSharpLua.Template = prop.propsLeft()
    [Pure]
    public static extern int PropsLeft();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern int SpawnRate { get; }
#else
    /// @CSharpLua.Template = prop.spawnRate()
    [Pure]
    public static extern int SpawnRate();
#endif

    /// @CSharpLua.Template = prop.create({0}, {1}, {2}, {3})
    [Pure]
    public static extern BaseEntity Create(Vector pos, Angle angles, string model, bool frozen = false);

    /// @CSharpLua.Template = prop.createComponent({0}, {1}, {2}, {3}, {4})
    [Pure]
    public static extern BaseEntity CreateComponent(Vector pos, Angle angles, string className, string model, bool frozen = false);

    /// @CSharpLua.Template = prop.createComponent({0}, {1}, 'starfall_hud', {2}, {3})
    [Pure]
    public static extern BaseEntity CreateHUD(Vector pos, Angle angles, string model, bool frozen = false);

    /// @CSharpLua.Template = prop.createComponent({0}, {1}, 'starfall_screen', {2}, {3})
    [Pure]
    public static extern BaseEntity CreateScreen(Vector pos, Angle angles, string model, bool frozen = false);

    /// @CSharpLua.Template = prop.createCustom({0}, {1}, {2}, {3})
    [Pure]
    public static extern BaseEntity CreateCustom(Vector pos, Angle angles, dynamic verticles, bool frozen = false);

    /// @CSharpLua.Template = prop.createRagdoll({0}, {1})
    [Pure]
    public static extern BaseEntity CreateRagdoll(string model, bool frozen = false);

    /// @CSharpLua.Template = prop.createSent({0}, {1}, {2}, {3})
    [Pure]
    public static extern BaseEntity CreateSent(Vector pos, Angle angles, bool frozen = false, dynamic? data = null);

    /// @CSharpLua.Template = prop.createSent({0}, {1}, {3}, {2})
    [Pure]
    public static extern BaseEntity CreateSent(Vector pos, Angle angles, dynamic? data, bool frozen = false);
}
#endif

#if STARFALL
/// @CSharpLua.Ignore
public static partial class holograms
{
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool CanSpawn { get; }

    /// @CSharpLua.NoField
    public static extern int HologramsLeft { get; }
#else
    /// @CSharpLua.Template = holograms.canSpawn()
    [Pure]
    public static extern bool CanSpawn();

    /// @CSharpLua.Template = holograms.hologramsLeft()
    [Pure]
    public static extern int HologramsLeft();
#endif

    /// @CSharpLua.Template = holograms.removeAll()
    public static extern void RemoveAll();
}

/// @CSharpLua.Ignore
public sealed partial class Hologram : BaseEntity
{
    /// @CSharpLua.Template = holograms.create({0}, {1}, {2})
    public extern Hologram(Vector pos, Angle ang, string model);

    /// @CSharpLua.Template = holograms.create({0}, {1}, {2}, {3})
    public extern Hologram(Vector pos, Angle ang, string model, Vector scale);
}
#endif

/// @CSharpLua.Ignore
public static partial class ents
{
#if STARFALL
    /// @CSharpLua.Template = find.all()
#else
    /// @CSharpLua.Template = ents.GetAll()
#endif
    [Pure]
    public static extern BaseEntity[] GetAll();
}

/// @CSharpLua.Ignore
public static partial class player
{
#if STARFALL
    /// @CSharpLua.Template = find.allPlayers()
#else
    /// @CSharpLua.Template = player.GetAll()
#endif
    [Pure]
    public static extern BasePlayer[] GetAll();
}

/// @CSharpLua.Ignore
public static partial class strlib
{
    /// @CSharpLua.Template = string.format({0}, {*1})
    [Pure]
    public static extern string format(string format, params object[] args);
}

/// @CSharpLua.Ignore
public static partial class math
{
    /// @CSharpLua.Template = math.abs({0})
    public static extern double abs(double number);

    /// @CSharpLua.Template = math.random()
    public static extern double random();

    /// @CSharpLua.Template = math.random({0})
    public static extern int random(int max);

    /// @CSharpLua.Template = math.random({0}, {1})
    public static extern int random(int min, int max);

#if STARFALL
    /// @CSharpLua.Template = math.rand({0}, {1})
#else
    /// @CSharpLua.Template = math.Rand({0}, {1})
#endif
    public static extern double Rand(double min, double max);

#if !STARFALL
    /// @CSharpLua.Template = math.randomseed({0})
    public static extern void RandomSeed(double seed);
#endif
}

/// @CSharpLua.Ignore
public static partial class bit
{
}

/// @CSharpLua.Ignore
public static partial class StringStream
{
}

/// @CSharpLua.Ignore
public static partial class file
{
#if (STARFALL && CLIENT) || !STARFALL
    // TODO
#endif
}

/// @CSharpLua.Ignore
public static partial class http
{
    // TODO: Make instance class?
    // TODO: Async/Await (promises)?
}

/// @CSharpLua.Ignore
public static partial class input
{
}

/// @CSharpLua.Ignore
public static partial class render
{
}

/// @CSharpLua.Ignore
public static partial class surface
{
}

/// @CSharpLua.Ignore
public static partial class team
{
}

#if SERVER
/// @CSharpLua.Ignore
public static partial class constraint
{
}
#endif

/// @CSharpLua.Ignore
public static partial class util
{
    // Line/Hull tracing, JSON, FastLZ compression, Base64 encoding/decoding, CRC32 hash...

#if STARFALL
    /// @CSharpLua.Template = trace.trace({0}, {1}, {2}, {3}, {4}, {5})
    [Pure]
    public static extern TraceResult? TraceLine(Vector start, Vector endpos, BaseEntity? filter = null, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = trace.traceHull({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})
    [Pure]
    public static extern TraceResult? TraceHull(Vector start, Vector endpos, Vector maxs, Vector mins, BaseEntity? filter = null, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);
#endif

    ////#if STARFALL
    ////  /// @CSharpLua.Template = trace.trace({0})
    ////#else
    ////  /// @CSharpLua.Template = util.TraceLine({0})
    ////#endif
    ////  [Pure]
    ////  public static extern TraceResult? TraceLine(Trace traceData);

    ////#if STARFALL
    ////  /// @CSharpLua.Template = trace.traceHull({0})
    ////#else
    ////  /// @CSharpLua.Template = util.TraceHull({0})
    ////#endif
    ////  [Pure]
    ////  public static extern TraceResult? TraceHull(HullTrace traceData);
}

/////// @CSharpLua.Ignore
////public sealed class Trace {
////#if STARFALL
////  public Trace(Vector start, Vector endpos, BaseEntity? filter = null, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null) {
////    this.start = start;
////    this.endpos = endpos;
////    this.filter = filter;
////    this.mask = mask;
////    this.collisiongroup = collisiongroup;
////    this.ignoreworld = ignoreworld;
////  }
////#else
////  public Trace(Vector start, Vector endpos, BaseEntity? filter = null, MASK? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, dynamic? output = null) {
////    /*
////    [[
////      return {["start"]=start, ["endpos"]=endpos, ["filter"]=filter, ["mask"]=mask, ["collisiongroup"]=collisiongroup, ["ignoreworld"]=ignoreworld, ["output"]=output}
////    ]]
////    */
////  }
////#endif

////  public Vector start { get; set; }

////  public Vector endpos { get; set; }

////  // BaseEntity / BaseEntity[] / Func<BaseEntity, bool> / Action<BaseEntity> / null
////  public dynamic filter { get; set; }

////  // MASK / CONTENTS (combination)
////  public uint? mask { get; set; }

////  public COLLISION_GROUP? collisiongroup { get; set; }

////  public bool? ignoreworld { get; set; }

////#if !STARFALL
////  public dynamic output { get; set; }
////#endif

////  public dynamic ToTuple() {
////    return (start, endpos, filter, mask, collisiongroup, ignoreworld);
////  }
////}

/////// @CSharpLua.Ignore
////public sealed class HullTrace {
////#if STARFALL
////  public HullTrace(Vector start, Vector endpos, Vector maxs, Vector mins, BaseEntity? filter = null, MASK? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null) {
////    /*
////     [[
////      return start, endpos, maxs, mins, filter, mask, collisiongroup, ignoreworld
////     ]]
////    */
////  }
////#else
////  public HullTrace(Vector start, Vector endpos, Vector maxs, Vector mins, BaseEntity? filter = null, MASK? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, dynamic? output = null) {
////    /*
////     [[
////      return {["start"]=start, ["endpos"]=endpos, ["maxs"]=maxs, ["mins"]=mins, ["filter"]=filter, ["mask"]=mask, ["collisiongroup"]=collisiongroup, ["ignoreworld"]=ignoreworld, ["output"]=output}
////     ]]
////    */
////  }
////#endif

////  public Vector start { get; set; }

////  public Vector endpos { get; set; }

////  public Vector maxs { get; set; }

////  public Vector mins { get; set; }

////  // BaseEntity / BaseEntity[] / Func<BaseEntity, bool> / Action<BaseEntity> / null
////  public dynamic filter { get; set; }

////  // MASK / CONTENTS (combination)
////  public uint mask { get; set; }

////  public COLLISION_GROUP collisiongroup { get; set; }

////  public bool ignoreworld { get; set; }

////#if !STARFALL
////  public dynamic output { get; set; }
////#endif
////}

/// @CSharpLua.Ignore
public sealed class TraceResult
{
    private extern TraceResult();

    public BaseEntity Entity { get; }

    public double Fraction { get; }

    public double FractionLeftSolid { get; }

    public bool Hit { get; }

    public int HitBox { get; }

    public HITGROUP HitGroup { get; }

    public bool HitNoDraw { get; }

    public bool HitNonWorld { get; }

    public Vector HitNormal { get; }

    public Vector HitPos { get; }

    public bool HitSky { get; }

    public string HitTexture { get; }

    public bool HitWorld { get; }

    public MAT MatType { get; }

    public Vector Normal { get; }

    public int PhysicsBone { get; }

    public Vector StartPos { get; }

    public int /*byte*/ SurfaceProps { get; }

    public bool StartSolid { get; }

    public bool AllSolid { get; }

    public SURF SurfaceFlags { get; }

    public DISPSURF DispFlags { get; }

    public CONTENTS Contents { get; }
}

/// @CSharpLua.Ignore
public static partial class sound
{
    // SF: "sounds"

#if STARFALL
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool CanCreate { get; }

    /// @CSharpLua.NoField
    public static extern int SoundsLeft { get; }
#else
    /// @CSharpLua.Template = sounds.canCreate()
    [Pure]
    public static extern bool CanCreate();

    /// @CSharpLua.Template = sounds.soundsLeft()
    [Pure]
    public static extern int SoundsLeft();
#endif
#endif

#if STARFALL
    /// @CSharpLua.Template = sounds.Create({0}, {1})
#else
    /// @CSharpLua.Template = _G.CreateSound({0}, {1})
#endif
    [Pure]
    public static extern Sound Create(BaseEntity entity, string path);

#if SERVER
#if STARFALL
    /// @CSharpLua.Template = sounds.Create({0}, {1}, {2})
#else
    /// @CSharpLua.Template = _G.CreateSound({0}, {1}, {2})
#endif
    [Pure]
    public static extern Sound Create(BaseEntity entity, string path, bool noFilter);
#endif

    public static extern void PlayFile(string filePath, string flags, Action<IGModAudioChannel, int, string> callback);
}

#if CLIENT
/// @CSharpLua.Ignore
public static partial class bass
{
#if STARFALL
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool CanCreate { get; }

    /// @CSharpLua.NoField
    public static extern int SoundsLeft { get; }
#else
    /// @CSharpLua.Template = bass.canCreate()
    [Pure]
    public static extern bool CanCreate();

    /// @CSharpLua.Template = bass.soundsLeft()
    [Pure]
    public static extern int SoundsLeft();
#endif
#endif

#if STARFALL
    /// @CSharpLua.Template = bass.loadURL({0}, {1}, {2})
#else
    /// @CSharpLua.Template = sound.PlayURL({0}, {1}, {2})
#endif
    /// <summary>
    ///   <para>Allows you to play external sound files, as well as online radio streams.</para>
    ///   <para>For offline file playback, see <see cref="sound.PlayFile"/>.</para>
    /// </summary>
    /// <param name="url">The URL of the sound to play.</param>
    /// <param name="flags">
    ///   Flags for the sound. Can be one or more of following, separated by a space (<c>" "</c>):
    ///   <list type="bullet">
    ///     <item>
    ///       <term>3d</term>
    ///       <description>Makes the sound 3D, so you can set its position.</description>
    ///     </item>
    ///     <item>
    ///       <term>mono</term>
    ///       <description>Forces the sound to have only one channel.</description>
    ///     </item>
    ///     <item>
    ///       <term>noplay</term>
    ///       <description>Forces the sound not to play as soon as this function is called.</description>
    ///     </item>
    ///     <item>
    ///       <term>noblock</term>
    ///       <description>Disables streaming in blocks. It is more resource-intensive, but it is required for <seealso cref="IGModAudioChannel.setTime"/>.</description>
    ///     </item>
    ///   </list>
    ///   <para>If you don't want to use any of the above, you can just leave it as <c>""</c>.</para>
    /// </param>
    /// <param name="callback">Callback function that is called as soon as the the stream is loaded.</param>
    /// <remarks>
    ///   <para><a href="https://wiki.facepunch.com/gmod/sound.PlayURL">GMod docs</a></para>
    ///   <para><a href="https://github.com/thegrb93/StarfallEx/search?q=bass_library+loadURL">Starfall definition</a></para>
    /// </remarks>
    public static extern void PlayURL(string url, string flags, AudioPlayCallback1 callback);

#if STARFALL
    /// @CSharpLua.Template = bass.loadURL({0}, {1}, {2})
#else
    /// @CSharpLua.Template = sound.PlayURL({0}, {1}, {2})
#endif
    /// <summary>
    ///   <para>Allows you to play external sound files, as well as online radio streams.</para>
    ///   <para>For offline file playback, see <see cref="sound.PlayFile"/>.</para>
    /// </summary>
    /// <param name="url">The URL of the sound to play.</param>
    /// <param name="flags">
    ///   Flags for the sound. Can be one or more of following, separated by a space (<c>" "</c>):
    ///   <list type="bullet">
    ///     <item>
    ///       <term>3d</term>
    ///       <description>Makes the sound 3D, so you can set its position.</description>
    ///     </item>
    ///     <item>
    ///       <term>mono</term>
    ///       <description>Forces the sound to have only one channel.</description>
    ///     </item>
    ///     <item>
    ///       <term>noplay</term>
    ///       <description>Forces the sound not to play as soon as this function is called.</description>
    ///     </item>
    ///     <item>
    ///       <term>noblock</term>
    ///       <description>Disables streaming in blocks. It is more resource-intensive, but it is required for <seealso cref="IGModAudioChannel.setTime"/>.</description>
    ///     </item>
    ///   </list>
    ///   <para>If you don't want to use any of the above, you can just leave it as <c>""</c>.</para>
    /// </param>
    /// <param name="callback">Callback function that is called as soon as the the stream is loaded.</param>
    /// <remarks>
    ///   <para><a href="https://wiki.facepunch.com/gmod/sound.PlayURL">GMod docs</a></para>
    ///   <para><a href="https://github.com/thegrb93/StarfallEx/search?q=bass_library+loadURL">Starfall definition</a></para>
    /// </remarks>
    public static extern void PlayURL(string url, string flags, AudioPlayCallback2 callback);

#if STARFALL
    /// @CSharpLua.Template = bass.loadURL({0}, {1}, {2})
#else
    /// @CSharpLua.Template = sound.PlayURL({0}, {1}, {2})
#endif
    /// <summary>
    ///   <para>Allows you to play external sound files, as well as online radio streams.</para>
    ///   <para>For offline file playback, see <see cref="sound.PlayFile"/>.</para>
    /// </summary>
    /// <param name="url">The URL of the sound to play.</param>
    /// <param name="flags">
    ///   Flags for the sound. Can be one or more of following, separated by a space (<c>" "</c>):
    ///   <list type="bullet">
    ///     <item>
    ///       <term>3d</term>
    ///       <description>Makes the sound 3D, so you can set its position.</description>
    ///     </item>
    ///     <item>
    ///       <term>mono</term>
    ///       <description>Forces the sound to have only one channel.</description>
    ///     </item>
    ///     <item>
    ///       <term>noplay</term>
    ///       <description>Forces the sound not to play as soon as this function is called.</description>
    ///     </item>
    ///     <item>
    ///       <term>noblock</term>
    ///       <description>Disables streaming in blocks. It is more resource-intensive, but it is required for <seealso cref="IGModAudioChannel.setTime"/>.</description>
    ///     </item>
    ///   </list>
    ///   <para>If you don't want to use any of the above, you can just leave it as <c>""</c>.</para>
    /// </param>
    /// <param name="callback">Callback function that is called as soon as the the stream is loaded.</param>
    /// <remarks>
    ///   <para><a href="https://wiki.facepunch.com/gmod/sound.PlayURL">GMod docs</a></para>
    ///   <para><a href="https://github.com/thegrb93/StarfallEx/search?q=bass_library+loadURL">Starfall definition</a></para>
    /// </remarks>
    public static extern void PlayURL(string url, string flags, AudioPlayCallback3 callback);
}
#endif

/// <param name="channel">The sound channel.</param>
public delegate void AudioPlayCallback1(IGModAudioChannel channel);

/// <param name="channel">The sound channel.</param>
/// <param name="errorCode">ID of an error, if an error has occured.</param>
#if STARFALL
public delegate void AudioPlayCallback2(IGModAudioChannel channel, BASS_ERROR errorCode);
#else
public delegate void AudioPlayCallback2(IGModAudioChannel channel, BASS_ERROR? errorCode);
#endif

/// <param name="channel">The sound channel.</param>
/// <param name="errorCode">ID of an error, if an error has occured.</param>
/// <param name="errorName">Name of an error, if an error has occured.</param>
#if STARFALL
public delegate void AudioPlayCallback3(IGModAudioChannel channel, BASS_ERROR errorCode, string errorName);
#else
public delegate void AudioPlayCallback3(IGModAudioChannel channel, BASS_ERROR? errorCode, string? errorName);
#endif

/// @CSharpLua.Ignore
public interface IGModAudioChannel
{
    // SF: "Bass"

    [Pure]
#if STARFALL
    double getAverageBitRate(); // TODO
#else
    double GetAverageBitRate();
#endif

    [Pure]
#if STARFALL
    double getBitsPerSample(); // TODO
#else
    double GetBitsPerSample();
#endif

    [Pure]
#if STARFALL
    string getFileName(); // TODO
#else
    string GetFileName();
#endif

    [Pure]
#if STARFALL
    dynamic getFFT(FFT size);
#else
    double FFT(dynamic tbl, FFT size);
#endif

    [Pure]
#if STARFALL
    double getLength();
#else
    double GetLength();
#endif

    [Pure]
#if STARFALL
    (double, double) getLevels();
#else
    (double, double) GetLevel();
#endif

    [Pure]
#if STARFALL
    double getSamplingRate(); // TODO
#else
    double GetSamplingRate();
#endif

    [Pure]
#if STARFALL
    GMOD_CHANNEL getState(); // TODO
#else
    GMOD_CHANNEL GetState();
#endif

    [Pure]
#if STARFALL
    dynamic getTagsHTTP(); // TODO
#else
    dynamic GetTagsHTTP();
#endif

    [Pure]
#if STARFALL
    dynamic getTagsID3(); // TODO
#else
    dynamic GetTagsID3();
#endif

    [Pure]
#if STARFALL
    dynamic getTagsMeta(); // TODO
#else
    dynamic GetTagsMeta();
#endif

    [Pure]
#if STARFALL
    dynamic getTagsOGG(); // TODO
#else
    dynamic GetTagsOGG();
#endif

    [Pure]
#if STARFALL
    dynamic getTagsVendor(); // TODO
#else
    dynamic GetTagsVendor();
#endif

#if !STARFALL
    [Pure]
    bool Get3DEnabled();

    void Set3DEnabled(bool enable);
#endif

    [Pure]
#if STARFALL
    (double, double, double) get3DCone(); // TODO
#else
    (double, double, double) Get3DCone();
#endif

#if STARFALL
    void set3DCone(double innerAngle, double outerAngle, double outerVolume); // TODO
#else
    void Set3DCone(double innerAngle, double outerAngle, double outerVolume);
#endif

    [Pure]
#if STARFALL
    (double, double) get3DFadeDistance();
#else
    (double, double) Get3DFadeDistance();
#endif

#if STARFALL
    void set3DFadeDistance(double min, double max);
#else
    void Set3DFadeDistance(double min, double max);
#endif

    [Pure]
#if STARFALL
    double getPan(); // TODO
#else
    double GetPan();
#endif

#if STARFALL
    void setPan(double pan); // TODO
#else
    void SetPan(double pan);
#endif

    [Pure]
#if STARFALL
    double getPitch(); // TODO
#else
    double GetPlaybackRate();
#endif

#if STARFALL
    void setPitch(double pitch);
#else
    void SetPlaybackRate(double rate);
#endif

    [Pure]
#if STARFALL
    Vector getPos(); // TODO
#else
    Vector GetPos(); // TODO: @GMod why not return dir as well (maybe make a separate method?)
#endif

#if STARFALL
    void setPos(Vector pos); // TODO: dir argument
#else
    void SetPos(Vector pos);

    void SetPos(Vector pos, Vector dir); // TODO: @GMod better make a separate method for changing dir
#endif

    [Pure]
#if STARFALL
    double getTime();
#else
    double GetTime();
#endif

#if STARFALL
    void setTime(double time);
#else
    void SetTime(double time);
#endif

    [Pure]
#if STARFALL
    double getVolume(); // TODO
#else
    double GetVolume();
#endif

#if STARFALL
    void setVolume(double volume);
#else
    void SetVolume(double volume);
#endif

    [Pure]
#if STARFALL
    bool isLooping(); // TODO
#else
    bool IsLooping();
#endif

#if STARFALL
    void setLooping(bool enable);
#else
    void EnableLooping(bool enable);
#endif

    [Pure]
#if STARFALL
    bool is3D(); // TODO
#else
    bool Is3D();
#endif

    [Pure]
#if STARFALL
    bool isBlockStreamed(); // TODO
#else
    bool IsBlockStreamed();
#endif

    [Pure]
#if STARFALL
    bool isOnline();
#else
    bool IsOnline();
#endif

    [Pure]
#if STARFALL
    bool isValid();
#else
    bool IsValid();
#endif

#if STARFALL
    void pause();
#else
    void Pause();
#endif

#if STARFALL
    void play();
#else
    void Play();
#endif

#if STARFALL
    void stop();
#else
    void Stop();
#endif

#if STARFALL
    void destroy();
#endif
}

//public sealed class GModAudioChannel : IGModAudioChannel { }

public sealed class Sound
{
}

/// @CSharpLua.Ignore
public static partial class net
{
    // TODO: Make instance class?

#if STARFALL
    /// @CSharpLua.Template = net.start({0})
#else
    /// @CSharpLua.Template = net.Start({0})
#endif
    /// <summary>
    ///   Begins a new net message via reliable channel.
    /// </summary>
    /// <param name="messageName">The name of the message to send.</param>
    /// <returns>Returns <c>true</c> if the message has been started successfully; otherwise, <c>false</c>.</returns>
    /// <remarks>
    ///   <para><a href="https://wiki.facepunch.com/gmod/net.Start">GMod docs</a></para>
    ///   <para><a href="https://github.com/thegrb93/StarfallEx/search?q=net_library+start">Starfall definition</a></para>
    /// </remarks>
    public static extern bool Start(string messageName);

#if STARFALL
    /// @CSharpLua.Template = net.start({0}, {1})
#else
    /// @CSharpLua.Template = net.Start({0}, {2})
#endif
    /// <summary>
    ///   Begins a new net message.
    /// </summary>
    /// <param name="messageName">The name of the message to send.</param>
    /// <param name="unreliable">[Default: <c>false</c>] If set to <c>true</c>, the message is not guaranteed to reach its destination.</param>
    /// <returns>Returns <c>true</c> if the message has been started successfully; otherwise, <c>false</c>.</returns>
    /// <remarks>
    ///   <para><a href="https://wiki.facepunch.com/gmod/net.Start">GMod docs</a></para>
    ///   <para><a href="https://github.com/thegrb93/StarfallEx/search?q=net_library+start">Starfall definition</a></para>
    /// </remarks>
    public static extern bool Start(string messageName, bool unreliable);

#if SERVER
#if STARFALL
    /// @CSharpLua.Template = net.send({0})
#else
    /// @CSharpLua.Template = net.Send({0})
#endif
    public static extern void Send(BasePlayer ply);

#if STARFALL
    /// @CSharpLua.Template = net.send({0})
#else
    /// @CSharpLua.Template = net.Send({0})
#endif
    public static extern void Send(dynamic playersTable);
#endif

#if CLIENT
    /// @CSharpLua.Template = net.SendToServer()
    public static extern void SendToServer();
#endif

#if STARFALL
    /// @CSharpLua.Template = net.receive({0}, {1})
#else
    /// @CSharpLua.Template = net.Receive({0}, {1})
#endif
    public static extern void Receive(string messageName, Action callback);

#if STARFALL
    /// @CSharpLua.Template = net.receive({0}, {1})
#else
    /// @CSharpLua.Template = net.Receive({0}, {1})
#endif
    public static extern void Receive(string messageName, Action<int> callback);

#if SERVER
#if STARFALL
    /// @CSharpLua.Template = net.receive({0}, {1})
#else
    /// @CSharpLua.Template = net.Receive({0}, {1})
#endif
    public static extern void Receive(string messageName, Action<int, BasePlayer> callback);
#endif
}

/// @CSharpLua.Ignore
public static partial class coroutine
{
    // TODO: Make instance class?
}

public sealed class Thread
{
}

/// @CSharpLua.Ignore
public static partial class timer
{
#if STARFALL
    /// @CSharpLua.Template = timer.adjust({0}, {1})
#else
    /// @CSharpLua.Template = timer.Adjust({0}, {1})
#endif
    [Pure]
    public static extern bool Adjust(string identifier, double delay);

#if STARFALL
    /// @CSharpLua.Template = timer.adjust({0}, {1}, {2})
#else
    /// @CSharpLua.Template = timer.Adjust({0}, {1}, {2})
#endif
    [Pure]
    public static extern bool Adjust(string identifier, double delay, ulong repetitions);

#if STARFALL
    /// @CSharpLua.Template = timer.adjust({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = timer.Adjust({0}, {1}, {2}, {3})
#endif
    [Pure]
    public static extern bool Adjust(string identifier, double delay, ulong? repetitions, Action callback);

#if STARFALL
    /// @CSharpLua.Template = timer.create({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = timer.Create({0}, {1}, {2}, {3})
#endif
    public static extern void Create(string identifier, double delay, ulong repetitions, Action callback);

#if STARFALL
    /// @CSharpLua.Template = timer.simple({0}, {1})
#else
    /// @CSharpLua.Template = timer.Simple({0}, {1})
#endif
    public static extern void Simple(double delay, Action callback);

#if STARFALL
    /// @CSharpLua.Template = timer.exists({0})
#else
    /// @CSharpLua.Template = timer.Exists({0})
#endif
    [Pure]
    public static extern bool Exists(string identifier);

#if STARFALL
    /// @CSharpLua.Template = timer.pause({0})
#else
    /// @CSharpLua.Template = timer.Pause({0})
#endif
    [Pure]
    public static extern bool Pause(string identifier);

#if STARFALL
    /// @CSharpLua.Template = timer.unpause({0})
#else
    /// @CSharpLua.Template = timer.UnPause({0})
#endif
    [Pure]
    public static extern bool Unpause(string identifier);

#if STARFALL
    /// @CSharpLua.Template = timer.remove({0})
#else
    /// @CSharpLua.Template = timer.Remove({0})
#endif
    public static extern void Remove(string identifier);

#if STARFALL
    /// @CSharpLua.Template = timer.start({0})
#else
    /// @CSharpLua.Template = timer.Start({0})
#endif
    [Pure]
    public static extern bool Start(string identifier);

#if STARFALL
    /// @CSharpLua.Template = timer.stop({0})
#else
    /// @CSharpLua.Template = timer.Stop({0})
#endif
    [Pure]
    public static extern bool Stop(string identifier);

#if STARFALL
    /// @CSharpLua.Template = timer.repsleft({0})
    [Pure]
    public static extern ulong? RepsLeft(string identifier);
#else
    /// @CSharpLua.Template = timer.RepsLeft({0})
    [Pure]
    public static extern ulong RepsLeft(string identifier);
#endif

#if STARFALL
    /// @CSharpLua.Template = timer.timeleft({0})
#else
    /// @CSharpLua.Template = timer.TimeLeft({0})
#endif
    [Pure]
    public static extern double TimeLeft(string identifier);

#if STARFALL
    /// @CSharpLua.Template = timer.toggle({0})
#else
    /// @CSharpLua.Template = timer.Toggle({0})
#endif
    [Pure]
    public static extern bool Toggle(string identifier);

#if STARFALL
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static int TimersLeft { get; }
#else
    /// @CSharpLua.Template = timer.getTimersLeft()
    [Pure]
    public static extern int GetTimersLeft();
#endif

    /// @CSharpLua.NoField
    public static extern bool CanCreate { get; }
#endif
}

public interface ITimer : IDisposable
{
    string Identifier { get; }

    Action Callback { get; set; }

    double Delay { get; set; }

    ulong Repetitions { get; set; }

    bool IsValid { get; }

    bool IsPaused { get; }

    bool Start();

    bool Stop();

    bool Pause();

    bool Toggle();

    bool Resume();
}

public sealed class Timer : ITimer
{
    private readonly string _identifier;
    private Action _callback;
    private double _delay;
    private ulong _repetitions;
    private bool _disposed;

    public Timer(Action callback, double delay, ulong repetitions = 1)
    {
#if STARFALL
        _G.Assert(timer.CanCreate, "cannot create a timer");
#endif
        _G.Assert(delay >= 0, $"bad argument #2 to `{nameof(Timer)}` ({nameof(delay)} cannot be negative)");
        _callback = callback;
        _delay = delay;
        _repetitions = repetitions;
        _identifier = strlib.format("Timer.%s_%p", _G.SysTime(), _callback);
        timer.Create(_identifier, _delay, _repetitions, _callback);
    }

    public string Identifier => _identifier;

    public Action Callback
    {
        get => _callback;
        set
        {
            CheckDisposed();
            if (value == _callback)
            {
                return;
            }

            _callback = value;
            _G.Assert(timer.Adjust(_identifier, _delay, 1, _callback), "failed to adjust timer's function");
        }
    }

    public double Delay
    {
        get => _delay;
        set
        {
            CheckDisposed();
            if (Math.Abs(value - _delay) < 0.01)
            {
                return;
            } // Do not update if the delta is too small.

            _G.Assert(value >= 0, "delay cannot be negative");
            _delay = value;
            _G.Assert(timer.Adjust(Identifier, _delay), "failed to adjust timer's delay");
        }
    }

    public ulong Repetitions
    {
#if STARFALL
        get => timer.RepsLeft(Identifier) ?? default; // stuped starfail.
#else
        get => timer.RepsLeft(Identifier);
#endif
        set
        {
            CheckDisposed();
            if (value == Repetitions)
            {
                return;
            }

            _repetitions = value;
            _G.Assert(timer.Adjust(Identifier, _delay, _repetitions), "failed to adjust timer's repetitions");
        }
    }

    public bool IsValid => !_disposed && timer.Exists(Identifier);

    public bool IsPaused => timer.TimeLeft(Identifier) < 0;

    public bool Start()
    {
        CheckDisposed();
        return timer.Start(Identifier);
    }

    public bool Stop()
    {
        CheckDisposed();
        return timer.Stop(Identifier);
    }

    public bool Pause()
    {
        CheckDisposed();
        return timer.Pause(Identifier);
    }

    public bool Resume()
    {
        CheckDisposed();
        return timer.Unpause(Identifier);
    }

    public bool Toggle()
    {
        CheckDisposed();
        return timer.Toggle(Identifier);
    }

    private void CheckDisposed()
    {
        _G.Assert(!_disposed, "ObjectDisposedException");
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        timer.Remove(Identifier);
        _disposed = true;
    }
}

/// @CSharpLua.Ignore
public static partial class hook
{
#if STARFALL
    /// @CSharpLua.Template = hook.add({0}, {1}, {2})
#else
    /// @CSharpLua.Template = hook.Add({0}, {1}, {2})
#endif
    public static extern void Add<T>(string eventName, string id, T func) where T : Delegate;

#if STARFALL
    /// @CSharpLua.Template = hook.add({0}, {1}, {2})
#else
    /// @CSharpLua.Template = hook.Add({0}, {1}, {2})
#endif
    public static extern void Add(string eventName, string id, EventBase eventBase);

#if STARFALL
    /// @CSharpLua.Template = hook.remove({0}, {1})
#else
    /// @CSharpLua.Template = hook.Remove({0}, {1})
#endif
    public static extern void Remove(string eventName, string id);
}

#if !STARFALL
/// @CSharpLua.Ignore
public static partial class concommand
{
    /// @CSharpLua.Template = concommand.Add({0}, {1}, {2}, {3}, {4})
    public static extern void Add(string name, Action<BasePlayer, string, string[], string> callback, Func<string, string, string[]>? autoComplete = default, string? helpText = default, FCVAR flags = default);

    /// @CSharpLua.Template = concommand.Remove({0})
    public static extern void Remove(string name);
}

/// @CSharpLua.Ignore
[Flags]
public enum FCVAR
{
    NONE = 0
}
#endif

/// @CSharpLua.Ignore
[Flags]
public enum IN_KEY
{
    /// <summary>+alt1 bound key</summary>
    ALT1 = 16384,

    /// <summary>+alt2 bound key</summary>
    ALT2 = 32768,

    /// <summary>+attack bound key ( Default: Left Mouse Button )</summary>
    ATTACK = 1,

    /// <summary>+attack2 bound key ( Default: Right Mouse Button )</summary>
    ATTACK2 = 2048,

    /// <summary>+back bound key ( Default: S )</summary>
    BACK = 16,

    /// <summary>+duck bound key ( Default: CTRL )</summary>
    DUCK = 4,

    /// <summary>+forward bound key ( Default: W )</summary>
    FORWARD = 8,

    /// <summary>+jump bound key ( Default: Space )</summary>
    JUMP = 2,

    /// <summary>+left bound key ( Look left )</summary>
    LEFT = 128,

    /// <summary>+moveleft bound key ( Default: A )</summary>
    MOVELEFT = 512,

    /// <summary>+moveright bound key ( Default: D )</summary>
    MOVERIGHT = 1024,

    /// <summary>+reload bound key ( Default: R )</summary>
    RELOAD = 8192,

    /// <summary>+right bound key ( Look right )</summary>
    RIGHT = 256,

    /// <summary>+showscores bound key ( Default: Tab )</summary>
    SCORE = 65536,

    /// <summary>+speed bound key ( Default: Shift )</summary>
    SPEED = 131072,

    /// <summary>+use bound key ( Default: E )</summary>
    USE = 32,

    /// <summary>+walk bound key ( Slow walk )</summary>
    WALK = 262144,

    /// <summary>+zoom bound key ( Suit Zoom )</summary>
    ZOOM = 524288,

    /// <summary>+grenade1 bound key</summary>
    GRENADE1 = 8388608,

    /// <summary>+grenade2 bound key</summary>
    GRENADE2 = 16777216,

    /// <summary>For use in weapons. Set in the physgun when scrolling an object away from you.</summary>
    WEAPON1 = 1048576,

    /// <summary>For use in weapons. Set in the physgun when scrolling an object towards you.</summary>
    WEAPON2 = 2097152,
    BULLRUSH = 4194304,
    CANCEL = 64,
    RUN = 4096
}

/// @CSharpLua.Ignore
public enum BUTTON_CODE
{
    INVALID = -1,
    NONE = 0,
    LAST = 171,
    COUNT = 172
}

/// @CSharpLua.Ignore
public enum COLLISION_GROUP
{
    NONE = 0, // Normal
    DEBRIS = 1, // Collides with nothing but world and static stuff
    DEBRIS_TRIGGER = 2, // Same as debris, but hits triggers. Useful for an item that can be shot, but doesn't collide.
    INTERACTIVE_DEBRIS = 3, // Collides with everything except other interactive debris or debris
    INTERACTIVE = 4, // Collides with everything except interactive debris or debris
    PLAYER = 5,
    BREAKABLE_GLASS = 6, // NPCs can see straight through an Entity with this applied.
    VEHICLE = 7,
    PLAYER_MOVEMENT = 8, // For HL2, same as Collision_Group_Player, for TF2, this filters out other players and CBaseObjects
    NPC = 9,
    IN_VEHICLE = 10, // Doesn't collide with anything, no traces
    WEAPON = 11, // Doesn't collide with players and vehicles
    VEHICLE_CLIP = 12, // Only collides with vehicles
    PROJECTILE = 13,
    DOOR_BLOCKER = 14, // Blocks entities not permitted to get near moving doors
    PASSABLE_DOOR = 15, // Lets the Player through, nothing else.
    DISSOLVING = 16, // Things that are dissolving are in this group
    PUSHAWAY = 17, // Nonsolid on client and server, pushaway in player code
    NPC_ACTOR = 18,
    NPC_SCRIPTED = 19,
    WORLD = 20, // Doesn't collide with players/props
    LAST_SHARED = 21 // Amount of COLLISION_GROUP_ enumerations
}

/// @CSharpLua.Ignore
public enum HITGROUP
{
    GENERIC = 0, // 1:1 damage. Melee weapons and fall damage typically hit this hitgroup. This hitgroup is not present on default player models.
    HEAD = 1, // Head
    CHEST = 2, // Chest
    STOMACH = 3, // Stomach
    LEFTARM = 4, // Left arm
    RIGHTARM = 5, // Right arm
    LEFTLEG = 6, // Left leg
    RIGHTLEG = 7, // Right leg
    GEAR = 10 // Gear. Supposed to be belt area.
}

/// @CSharpLua.Ignore
public enum MAT
{
    ANTLION = 65, // Antlions
    BLOODYFLESH = 66, // Similar to MAT_FLESH, only used by "bloodyflesh" surface property, has different impact sound
    CONCRETE = 67, // Concrete
    DIRT = 68, // Dirt
    EGGSHELL = 69, // The egg sacs in the antlion tunnels in HL2: EP2
    FLESH = 70, // Flesh
    GRATE = 71, // Grates, chainlink fences
    ALIENFLESH = 72, // Alien flesh - headcrabs and vortigaunts
    CLIP = 73, // Unused
    SNOW = 74, // Snow
    PLASTIC = 76, // Plastic
    METAL = 77, // Metal
    SAND = 78, // Sand
    FOLIAGE = 79, // Plants, only used by the "foliage" surface property
    COMPUTER = 80, // Electronics, only used by "computer" surface property
    SLOSH = 83, // Water, slime
    TILE = 84, // Floor tiles
    GRASS = 85, // Grass
    VENT = 86, // Metallic vents
    WOOD = 87, // Wood
    DEFAULT = 88, // Skybox or nodraw texture
    GLASS = 89, // Glass
    WARPSHIELD = 90 // "wierd-looking jello effect for advisor shield."
}

/// @CSharpLua.Ignore
[Flags]
public enum SURF
{
    LIGHT = 1, // Value will hold the light strength
    SKY2D = 2, // The surface is a 2D skybox
    SKY = 4, // This surface is a skybox, equivalent to HitSky in Structures/TraceResult
    WARP = 8, // This surface is animated water
    TRANS = 16, // This surface is translucent
    NOPORTAL = 32, // This surface cannot have portals placed on, used by Portal's gun
    TRIGGER = 64, // This surface is a trigger
    NODRAW = 128, // This surface is an invisible entity, equivalent to HitNoDraw in Structures/TraceResult
    HINT = 256, // Make a primary bsp splitter
    SKIP = 512, // This surface can be ignored by impact effects
    NOLIGHT = 1024, // This surface has no lights calculated
    BUMPLIGHT = 2048, // Calculate three lightmaps for the surface for bumpmapping
    NOSHADOWS = 4096, // No shadows are cast on this surface
    NODECALS = 8192, // No decals are applied to this surface
    NOCHOP = 16384, // Don't subdivide patches on this surface
    HITBOX = 32768 // This surface is part of an entity's hitbox
}

/// @CSharpLua.Ignore
[Flags]
public enum DISPSURF
{
    SURFACE = 1,
    WALKABLE = 2,
    BUILDABLE = 4,
    SURFPROP1 = 8,
    SURFPROP2 = 16
}

/// @CSharpLua.Ignore
[Flags]
public enum CONTENTS : uint
{
    EMPTY = 0, // Things that are not solid
    SOLID = 1, // Things that are solid
    WINDOW = 2, // Glass
    AUX = 4,
    GRATE = 8, // Bullets go through, solids don't
    SLIME = 16,
    WATER = 32, // Hits world but not skybox
    BLOCKLOS = 64, // Things that block line of sight
    OPAQUE = 128, // Things that block light
    TESTFOGVOLUME = 256,
    TEAM4 = 512,
    TEAM3 = 1024,
    TEAM1 = 2048,
    TEAM2 = 4096,
    IGNORE_NODRAW_OPAQUE = 8192,
    MOVEABLE = 16384,
    AREAPORTAL = 32768,
    PLAYERCLIP = 65536,
    MONSTERCLIP = 131072,
    CURRENT_0 = 262144,
    CURRENT_180 = 1048576,
    CURRENT_270 = 2097152,
    CURRENT_90 = 524288,
    CURRENT_DOWN = 8388608,
    CURRENT_UP = 4194304,
    DEBRIS = 67108864,
    DETAIL = 134217728,
    HITBOX = 1073741824, // Hitbox
    LADDER = 536870912, // Ladder
    MONSTER = 33554432, // NPCs
    ORIGIN = 16777216,
    TRANSLUCENT = 268435456, // Hits world but not skybox
    LAST_VISIBLE_CONTENTS = 128, // Last visible contents enumeration
    ALL_VISIBLE_CONTENTS = 255 // Sum of all the visible contents enumerations
}

/// @CSharpLua.Ignore
[Flags]
public enum MASK : uint
{
    BLOCKLOS = 16449, // Anything that blocks line of sight for AI
    BLOCKLOS_AND_NPCS = 33570881, // Anything that blocks line of sight for AI or NPCs
    CURRENT = 16515072, // Water that is moving (may not work)
    DEADSOLID = 65547, // Anything that blocks corpse movement
    NPCSOLID = 33701899, // Anything that blocks NPC movement
    NPCSOLID_BRUSHONLY = 147467, // Anything that blocks NPC movement, except other NPCs
    NPCWORLDSTATIC = 131083, // The world entity
    OPAQUE = 16513, // Anything that blocks lighting
    OPAQUE_AND_NPCS = 33570945, // Anything that blocks lighting, including NPCs
    PLAYERSOLID = 33636363, // Anything that blocks player movement
    PLAYERSOLID_BRUSHONLY = 81931, // World + Brushes + Player Clips
    SHOT = 1174421507, // Anything that stops a bullet (including hitboxes)
    SHOT_HULL = 100679691, // Anything that stops a bullet (excluding hitboxes)
    SHOT_PORTAL = 33570819, // Solids except for grates
    SOLID = 33570827, // Anything that is (normally) solid
    SOLID_BRUSHONLY = 16395, // World + Brushes
    SPLITAREAPORTAL = 48, // Things that split area portals
    VISIBLE = 24705, // Anything that blocks line of sight for players
    VISIBLE_AND_NPCS = 33579137, // Anything that blocks line of sight for players, including NPCs
    WATER = 16432, // Anything that has water-like physics
    ALL = 4294967295 // Anything that is not empty space
}

/// @CSharpLua.Ignore
public enum GMOD_CHANNEL
{
    STOPPED = 0, // The channel is stopped
    PLAYING = 1, // The channel is playing
    PAUSED = 2, // The channel is paused
    STALLED = 3 // The channel is buffering
}

/// @CSharpLua.Ignore
public enum FFT
{
    SIZE_256 = 0, // 128 levels
    SIZE_512 = 1, // 256 levels
    SIZE_1024 = 2, // 512 levels
    SIZE_2048 = 3, // 1024 levels
    SIZE_4096 = 4, // 2048 levels
    SIZE_8192 = 5, // 4096 levels
    SIZE_16384 = 6, // 8192 levels
    SIZE_32768 = 7 // 16384 levels
}

/// @CSharpLua.Ignore
public enum BASS_ERROR
{
    UNKNOWN = -1,
    OK = 0,
    MEM = 1,
    FILEOPEN = 2,
    DRIVER = 3,
    BUFLOST = 4,
    HANDLE = 5,
    FORMAT = 6,
    POSITION = 7,
    INIT = 8,
    START = 9,
    SSL = 10,
    ALREADY = 14,
    NOTAUDIO = 17,
    NOCHAN = 18,
    ILLTYPE = 19,
    ILLPARAM = 20,
    NO3D = 21,
    NOEAX = 22,
    DEVICE = 23,
    NOPLAY = 24,
    FREQ = 25,
    NOTFILE = 27,
    NOHW = 29,
    EMPTY = 31,
    NONET = 32,
    CREATE = 33,
    NOFX = 34,
    NOTAVAIL = 37,
    DECODE = 38,
    DX = 39,
    TIMEOUT = 40,
    FILEFORM = 41,
    SPEAKER = 42,
    VERSION = 43,
    CODEC = 44,
    ENDED = 45,
    BUSY = 46,
    UNSTREAMABLE = 47
}