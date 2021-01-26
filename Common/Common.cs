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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

/// @CSharpLua.Ignore
internal static class dnGLua { /* Reserved */ }

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

    public static extern dynamic REMOVEME_Internal_Return_Hack_REMOVEME();

    /// @CSharpLua.Template = reinterpret_cast({0})
    [Pure]
    public static extern TTo reinterpret_cast<TFrom, TTo>(TFrom value);

    /// @CSharpLua.Template = _G.__Angle()
    [Pure]
    public static extern Angle Angle();

    /// @CSharpLua.Template = _G.__Angle({0})
    [Pure]
    public static extern Angle Angle(Angle angle); // TODO: SF

#if STARFALL
    /// @CSharpLua.Template = _G.__Angle({0})
#else
    /// @CSharpLua.Template = _G.__Angle({0}, {0}, {0})
#endif
    [Pure]
    public static extern Angle Angle(float pyr);

#if STARFALL
    /// @CSharpLua.Template = _G.__Angle({0}, {1})
#else
    /// @CSharpLua.Template = _G.__Angle({0}, {1}, 0)
#endif
    [Pure]
    public static extern Angle Angle(float p, float y);

    /// @CSharpLua.Template = _G.__Angle({0}, {1}, {2})
    [Pure]
    public static extern Angle Angle(float p, float y, float r);

    /// @CSharpLua.Template = _G.__Vector()
    [Pure]
    public static extern Vector Vector();

    /// @CSharpLua.Template = _G.__Vector({0})
    [Pure]
    public static extern Vector Vector(Vector vector); // TODO: SF

#if STARFALL
    /// @CSharpLua.Template = _G.__Vector({0})
#else
    /// @CSharpLua.Template = _G.__Vector({0}, {0}, {0})
#endif
    [Pure]
    public static extern Vector Vector(float xyz);

#if STARFALL
    /// @CSharpLua.Template = _G.__Vector({0}, {1})
#else
    /// @CSharpLua.Template = _G.__Vector({0}, {1}, 0)
#endif
    [Pure]
    public static extern Vector Vector(float x, float y);

    /// @CSharpLua.Template = _G.__Vector({0}, {1}, {2})
    [Pure]
    public static extern Vector Vector(float x, float y, float z);

    /// @CSharpLua.Template = _G.Matrix()
    [Pure]
    public static extern VMatrix Matrix();

    ///// @CSharpLua.Template = _G.Matrix({0})
    //[Pure]
    //public static extern VMatrix Matrix(dynamic table);

    /// @CSharpLua.Template = _G.Matrix({0})
    [Pure]
    public static extern VMatrix Matrix(VMatrix matrix); // TODO: SF

    /// @CSharpLua.Template = _G.Matrix({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15})
    [Pure]
    public static extern VMatrix Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44);

    /// @CSharpLua.Template = _G.Color({0}, {1}, {2})
    [Pure]
    public static extern Color Color(byte red, byte green, byte blue);

    /// @CSharpLua.Template = _G.Color({0}, {1}, {2}, {3})
    [Pure]
    public static extern Color Color(byte red, byte green, byte blue, byte alpha);

    ///// @CSharpLua.Template = _G.Color({0})
    //[Pure]
    //public static extern Color Color(System.Drawing.Color color); // TODO

#if CLIENT
    /// @CSharpLua.Template = _G.__VertexCreate({0}, {1})
    [Pure]
    public static extern Vertex Vertex(float x, float y);

    /// @CSharpLua.Template = _G.__VertexCreate({0}, {1}, {2}, {3})
    [Pure]
    public static extern Vertex Vertex(float x, float y, float u, float v);
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

    ////#if STARFALL
    ////  /// @CSharpLua.Template = _G.include({0})
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
    //public static extern ulong? select(string count = "#");

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
    public static extern bool IsValid(object? value);

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

    /// @CSharpLua.Template = _G.ScrW()
    [Pure]
    public static extern int ScrW();

    /// @CSharpLua.Template = _G.ScrH()
    [Pure]
    public static extern int ScrH();
#endif
}

public sealed class Angle
{
    public float p, y, r;

    /// @CSharpLua.Template = _G.__Angle()
    public extern Angle();

#if STARFALL
    /// @CSharpLua.Template = _G.__Angle({0})
#else
    /// @CSharpLua.Template = _G.__Angle({0}, {0}, {0})
#endif
    public extern Angle(float pyr);

#if STARFALL
    /// @CSharpLua.Template = _G.__Angle({0}, {1})
#else
    /// @CSharpLua.Template = _G.__Angle({0}, {1}, 0)
#endif
    public extern Angle(float p, float y);

    /// @CSharpLua.Template = _G.__Angle({0}, {1}, {2})
    public extern Angle(float p, float y, float r);

    public float this[int index]
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

    public static Angle operator *(Angle left, float right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left * right
        ]]
        */
    }

    public static Angle operator *(float left, Angle right)
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

    public static Angle operator /(Angle left, float right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static Angle operator /(float left, Angle right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static bool operator !(Angle? angle)
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
    public float x, y, z;

    /// @CSharpLua.Template = _G.__Vector()
    public extern Vector();

#if STARFALL
    /// @CSharpLua.Template = _G.__Vector({0})
#else
    /// @CSharpLua.Template = _G.__Vector({0}, {0}, {0})
#endif
    public extern Vector(float xyz);

#if STARFALL
    /// @CSharpLua.Template = _G.__Vector({0}, {1})
#else
    /// @CSharpLua.Template = _G.__Vector({0}, {1}, 0)
#endif
    public extern Vector(float x, float y);

    /// @CSharpLua.Template = _G.__Vector({0}, {1}, {2})
    public extern Vector(float x, float y, float z);

    public float this[int index]
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

    public static Vector operator *(Vector left, float right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left * right
        ]]
        */
    }

    public static Vector operator *(float left, Vector right)
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

    public static Vector operator /(Vector left, float right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static Vector operator /(float left, Vector right)
    {
        return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
        /*
        [[
          return left / right
        ]]
        */
    }

    public static bool operator !(Vector? vector)
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

/// @CSharpLua.Ignore
public sealed partial class VMatrix
{
    /// @CSharpLua.Template = _G.Matrix()
    public extern VMatrix();

    /// @CSharpLua.Template = _G.Matrix({0})
    public extern VMatrix(VMatrix matrix);

    /// @CSharpLua.Template = _G.Matrix({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15})
    public extern VMatrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44);
}

/// @CSharpLua.Ignore
public sealed partial class Color
{
    public byte r, g, b, a;

    private extern Color();

    /// @CSharpLua.Template = _G.Color({0}, {1}, {2})
    public extern Color(byte r, byte g, byte b);

    /// @CSharpLua.Template = _G.Color({0}, {1}, {2}, {3})
    public extern Color(byte r, byte g, byte b, byte a /*= 0xFF*/);
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

public sealed partial class KeyPress : EventBase
{
    private const string ID = "KeyPress";

    public KeyPress(Action<BasePlayer, IN_KEY> func) : base(ID, func, false) { }

    public KeyPress(Action<EventBase, BasePlayer, IN_KEY> func) : base(ID, func, true) { }
}

public sealed partial class KeyRelease : EventBase
{
    private const string ID = "KeyRelease";

    public KeyRelease(Action<BasePlayer, IN_KEY> func) : base(ID, func, false) { }

    public KeyRelease(Action<EventBase, BasePlayer, IN_KEY> func) : base(ID, func, true) { }
}

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

public sealed partial class PlayerButtonDown : EventBase
{
    private const string ID =
#if STARFALL
            "inputPressed"
#else
            "PlayerButtonDown"
#endif
        ;

    public PlayerButtonDown(Action<BUTTON_CODE> func) : base(ID, func, false)
    {
    }

    public PlayerButtonDown(Action<EventBase, BUTTON_CODE> func) : base(ID, func, true)
    {
    }
}

public sealed partial class PlayerButtonUp : EventBase
{
    private const string ID =
#if STARFALL
            "inputReleased"
#else
            "PlayerButtonUp"
#endif
        ;

    public PlayerButtonUp(Action<BUTTON_CODE> func) : base(ID, func, false)
    {
    }

    public PlayerButtonUp(Action<EventBase, BUTTON_CODE> func) : base(ID, func, true)
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

public sealed partial class PlayerChat : EventBase
{
    private const string ID = "PlayerChat";

    public PlayerChat(Action<BasePlayer, string> func) : base(ID, func, false)
    {
    }

    public PlayerChat(Action<EventBase, BasePlayer, string> func) : base(ID, func, true)
    {
    }

    public PlayerChat(Action<BasePlayer, string, bool> func) : base(ID, func, false)
    {
    }

    public PlayerChat(Action<EventBase, BasePlayer, string, bool> func) : base(ID, func, true)
    {
    }

    public PlayerChat(Action<BasePlayer, string, bool, bool> func) : base(ID, func, false)
    {
    }

    public PlayerChat(Action<EventBase, BasePlayer, string, bool, bool> func) : base(ID, func, true)
    {
    }
}
#endif

#if SERVER
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

public sealed partial class PhysgunFreeze : EventBase
{
    private const string ID = "OnPhysgunFreeze";

    public PhysgunFreeze(Action<BaseEntity, PhysObj, BaseEntity, BasePlayer> func) : base(ID, func, false)
    {
    }

    public PhysgunFreeze(Action<EventBase, BaseEntity, PhysObj, BaseEntity, BasePlayer> func) : base(ID, func, true)
    {
    }
}

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

public abstract class Realm
{
    public virtual void Main()
    {
    }
}

public abstract partial class Clientside : Realm
{
}

public abstract partial class Serverside : Realm
{
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
    private extern DLight();

#if STARFALL
    /// @CSharpLua.Template = light.create({0}, {1}, {2}, {3})
    public extern DLight(Vector pos, double size, double brightness, Color color);

    /// @CSharpLua.Template = light.create({0}, {1}, {2}, {3})
    [Pure]
    public static extern DLight Create(Vector pos, double size, double brightness, Color color);
#else
    /// @CSharpLua.Template = _G.DynamicLight({0}, {1})
    public extern DLight(uint index, bool elight = false);

    /// @CSharpLua.Template = _G.DynamicLight({0}, {1})
    [Pure]
    public static extern DLight Create(uint index, bool elight = false);
#endif

    public double brightness;

    public uint decay;

    public double dietime;

    public Vector dir;

    public double innerangle;

    public double outerangle;

    //public double key;

    public double minlight;

    public bool noworld;

    public bool nomodel;

    public Vector pos;

    public double size;

    public byte style;

    public byte r;

    public byte g;

    public byte b;
}

/// @CSharpLua.Ignore
public sealed class CamData
{
    /// @CSharpLua.Template = _G.__CamDataCreate({0}, {1}, {2}, {3}, {4})
    public extern CamData(Vector origin, Angle angles, int fov, double znear, double zfar);

    /// @CSharpLua.Template = _G.__CamDataCreate({0}, {1}, {2}, {3}, {4}, {5})
    public extern CamData(Vector origin, Angle angles, int fov, double znear, double zfar, bool drawviewer);

    /// @CSharpLua.Template = _G.__CamDataCreate({0}, {1}, {2}, {3}, {4}, nil, {5})
    public extern CamData(Vector origin, Angle angles, int fov, double znear, double zfar, CamData_Ortho? ortho);

    /// @CSharpLua.Template = _G.__CamDataCreate({0}, {1}, {2}, {3}, {4}, {5}, {6})
    public extern CamData(Vector origin, Angle angles, int fov, double znear, double zfar, bool drawviewer, CamData_Ortho? ortho);

    /// @CSharpLua.Template = _G.__CamDataCreate({0}, {1}, {2}, {3}, {4})
    [Pure]
    public static extern CamData Create(Vector origin, Angle angles, int fov, double znear, double zfar);

    /// @CSharpLua.Template = _G.__CamDataCreate({0}, {1}, {2}, {3}, {4}, {5})
    [Pure]
    public static extern CamData Create(Vector origin, Angle angles, int fov, double znear, double zfar, bool drawviewer);

    /// @CSharpLua.Template = _G.__CamDataCreate({0}, {1}, {2}, {3}, {4}, nil, {5})
    [Pure]
    public static extern CamData Create(Vector origin, Angle angles, int fov, double znear, double zfar, CamData_Ortho? ortho);

    /// @CSharpLua.Template = _G.__CamDataCreate({0}, {1}, {2}, {3}, {4}, {5}, {6})
    [Pure]
    public static extern CamData Create(Vector origin, Angle angles, int fov, double znear, double zfar, bool drawviewer, CamData_Ortho? ortho);

    public Vector origin;

    public Angle angles;

    public int fov;

    public double znear;

    public double zfar;

    public bool drawviewer;

    public CamData_Ortho? ortho;
}

/// @CSharpLua.Ignore
public sealed class CamData_Ortho
{
    /// @CSharpLua.Template = _G.__CamData_OrthoCreate({0}, {1}, {2}, {3})
    public extern CamData_Ortho(float? left = null, float? right = null, float? bottom = null, float? top = null);

    /// @CSharpLua.Template = _G.__CamData_OrthoCreate({0}, {1}, {2}, {3})
    [Pure]
    public static extern CamData_Ortho Create(float? left = null, float? right = null, float? bottom = null, float? top = null);

    public float left, right, bottom, top;
}
#endif

/// @CSharpLua.Ignore
public sealed class Debug_GetInfo
{
    private extern Debug_GetInfo();

    public extern int? currentline { get; }

#if !STARFALL
    public extern Delegate? func { get; }
#endif

    public extern int? lastlinedefined { get; }

    public extern int? linedefined { get; }

    public extern string? name { get; }

    public extern string? namewhat { get; }

    public extern uint? nparams { get; }

    public extern uint? nups { get; }

    public extern string? short_src { get; }

    public extern string? source { get; }

    public extern string? what { get; }
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

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsValid { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isValid();
#else
    public extern bool IsValid();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsValidPhys { get; }
#else
#if SERVER
    [Pure]
#if STARFALL
    public extern bool isValidPhys();
#else
    public extern bool IsValidPhys();
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsPlayer { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isPlayer();
#else
    public extern bool IsPlayer();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsVehicle { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isVehicle();
#else
    public extern bool IsVehicle();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsWeapon { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isWeapon();
#else
    public extern bool IsWeapon();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsOnFire { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isOnFire();
#else
    public extern bool IsOnFire();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsOnGround { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isOnGround();
#else
    public extern bool IsOnGround();
#endif
#endif

#if SERVER
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsPlayerHolding { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isPlayerHolding();
#else
    public extern bool IsPlayerHolding();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern BaseEntity IsWeldedTo { get; }
#else
    [Pure]
#if STARFALL
    public extern BaseEntity isWeldedTo();
#else
    public extern BaseEntity IsWeldedTo();
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern int EntIndex { get; }
#else
    [Pure]
#if STARFALL
    public extern int entIndex();
#else
    public extern int EntIndex();
#endif
#endif

    [Pure]
#if STARFALL
    public extern BaseEntity entOwner();
#else
    public extern BaseEntity GetOwner();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern int Health
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
    public extern int MaxHealth
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
    public extern Color Color
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
    public extern Vector Pos
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
    public extern Angle Angles
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
    public extern virtual Vector EyePos { get; }
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
    public extern virtual Angle EyeAngles { get; }
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
    public extern Vector Velocity
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

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern virtual BaseEntity Parent
    {
        get;
#if SERVER
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern virtual BaseEntity getParent();
#if SERVER
    public extern virtual void setParent(BaseEntity parent);
#endif
#else
    [Pure]
    public extern virtual BaseEntity GetParent();
#if SERVER
    public extern virtual void SetParent(BaseEntity parent);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern string Material
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
    public extern Vector Forward { get; }
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
    public extern Vector Right { get; }
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
    public extern double CreationTime { get; }
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
    public extern COLLISION_GROUP CollisionGroup
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
    public extern bool Persistent
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

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsAlive { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isAlive();
#else
    public extern bool Alive();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsBot { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isBot();
#else
    public extern bool IsBot();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsNPC { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isNPC();
#else
    public extern bool IsNPC();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsConnected { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isConnected();
#else
    public extern bool IsConnected();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsAdmin { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isAdmin();
#else
    public extern bool IsAdmin();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsSuperAdmin { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isSuperAdmin();
#else
    public extern bool IsSuperAdmin();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsCrouching { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isCrouching();
#else
    public extern bool Crouching();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsSprinting { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isSprinting();
#else
    public extern bool IsSprinting();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsFrozen { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isFrozen();
#else
    public extern bool IsFrozen();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsFlashlightOn { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isFlashlightOn();
#else
    public extern bool FlashlightIsOn();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsTyping { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isTyping();
#else
    public extern bool IsTyping();
#endif
#endif

    [Pure]
#if STARFALL
    public extern bool isUserGroup(string group);
#else
    public extern bool IsUserGroup(string group);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool InVehicle { get; }
#else
    [Pure]
#if STARFALL
    public extern bool inVehicle();
#else
    public extern bool InVehicle();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool HasGodMode { get; }
#else
    [Pure]
#if STARFALL
    public extern bool hasGodMode();
#else
    public extern bool HasGodMode();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern int Armor
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
    public extern int MaxArmor
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
    public extern int Team
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
    public extern int Deaths
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
    public extern int Frags
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
    public extern Weapon ActiveWeapon
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
    public extern Vector AimVector { get; }
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
    public extern int FOV
    {
        get;
#if SERVER && !STARFALL
        set;
#endif
    }
#else
#if STARFALL
    [Pure]
    public extern int getFOV();
#else
    [Pure]
    public extern int GetFOV();
#if SERVER
    public extern void SetFOV(int fov);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern double JumpPower
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
    public extern double GetJumpPower();
#if SERVER
    public extern void SetJumpPower(double jumpPower);
#endif
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern double MaxSpeed
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
    public extern double RunSpeed
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
    public extern Vector ShootPos { get; }
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
    public extern Vehicle Vehicle { get; }
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
    public extern int Ping { get; }
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
    public extern int UserID { get; }
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
    public extern string SteamID { get; }
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
    public extern string SteamID64 { get; }
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
    public extern string Name { get; }
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
    public extern TraceResult EyeTrace { get; }
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
    public extern BaseEntity ViewEntity
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
    public extern BaseEntity ViewModel { get; }
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
    public extern Weapon[] Weapons { get; }
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
    public extern BaseEntity GroundEntity
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
    public extern int AmmoCount { get; }
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

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsMuted { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isMuted();
#else
    public extern bool IsMuted();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsSpeaking { get; }
#else
    [Pure]
#if STARFALL
    public extern bool isSpeaking();
#else
    public extern bool IsSpeaking();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern double VoiceVolume { get; }
#else
    [Pure]
#if STARFALL
    public extern double voiceVolume();
#else
    public extern double VoiceVolume();
#endif
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern string FriendStatus { get; }
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

#if STARFALL
    /// @CSharpLua.Template = find.byClass({0})
#else
    /// @CSharpLua.Template = ents.FindByClass({0})
#endif
    [Pure]
    public static extern BaseEntity[] FindByClass(string className);

#if STARFALL
    /// @CSharpLua.Template = find.inBox({0}, {1})
#else
    /// @CSharpLua.Template = ents.FindInBox({0}, {1})
#endif
    [Pure]
    public static extern BaseEntity[] FindInBox(Vector min, Vector max);

#if STARFALL
    /// @CSharpLua.Template = find.inSphere({0}, {1})
#else
    /// @CSharpLua.Template = ents.FindInSphere({0}, {1})
#endif
    [Pure]
    public static extern BaseEntity[] FindInSphere(Vector center, double radius);

#if STARFALL
    /// @CSharpLua.Template = find.inRay({0}, {1})
#else
    /// @CSharpLua.Template = ents.FindAlongRay({0}, {1})
#endif
    [Pure]
    public static extern BaseEntity[] FindAlongRay(Vector startPos, Vector endPos);

#if STARFALL
    /// @CSharpLua.Template = find.inRay({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = ents.FindAlongRay({0}, {1}, {2}, {3})
#endif
    [Pure]
    public static extern BaseEntity[] FindAlongRay(Vector startPos, Vector endPos, Vector mins, Vector maxs);

#if SERVER
#if STARFALL
    /// @CSharpLua.Template = find.inPVS({0})
#else
    /// @CSharpLua.Template = ents.FindInPVS({0})
#endif
    [Pure]
    public static extern BaseEntity[] FindInPVS(Vector pos);
#endif
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
    /// @CSharpLua.Template = strlib.bytes({0}, {1}, {2})
    [Pure]
    public static extern byte[] bytes(string str, int? startPos = 1, int? endPos = null);

    /// @CSharpLua.Template = strlib.chars({*0})
    [Pure]
    public static extern string chars(params byte[] bytes);

#if STARFALL
    /// @CSharpLua.Template = string.comma({0})
#else
    /// @CSharpLua.Template = string.Comma({0})
#endif
    [Pure]
    public static extern string comma(double number);

    /// @CSharpLua.Template = string.dump({0})
    [Pure]
    public static extern string dump<T>(T func) where T : Delegate;

#if STARFALL
    /// @CSharpLua.Template = string.endsWith({0}, {1})
#else
    /// @CSharpLua.Template = string.EndsWith({0}, {1})
#endif
    [Pure]
    public static extern string endsWith(string str, string end);

#if STARFALL
    /// @CSharpLua.Template = string.explode({0}, {1})
#else
    /// @CSharpLua.Template = string.Explode({0}, {1})
#endif
    [Pure]
    public static extern string[] explode(string separator, string str);

#if STARFALL
    /// @CSharpLua.Template = string.explode({0}, {1}, {2})
#else
    /// @CSharpLua.Template = string.Explode({0}, {1}, {2})
#endif
    [Pure]
    public static extern string[] explode(string separator, string str, bool usePatterns);

    /// @CSharpLua.Template = System.Tuple(string.find({0}, {1}, {2}, {3}))
    [Pure]
    public static extern (int?, int?, string?) find(string haystack, string needle, int startPos = 1, bool noPatterns = false);

    /// @CSharpLua.Template = string.format({0}, {*1})
    [Pure]
    public static extern string format(string format, params object[] args);

#if STARFALL
    /// @CSharpLua.Template = string.formattedTime({0})
#else
    /// @CSharpLua.Template = string.FormattedTime({0})
#endif
    [Pure]
    public static extern dynamic formattedTime(double time);

#if STARFALL
    /// @CSharpLua.Template = string.formattedTime({0}, {1})
#else
    /// @CSharpLua.Template = string.FormattedTime({0}, {1})
#endif
    [Pure]
    public static extern string formattedTime(double time, string format);

#if STARFALL
    /// @CSharpLua.Template = string.getExtensionFromFilename({0})
#else
    /// @CSharpLua.Template = string.GetExtensionFromFilename({0})
#endif
    [Pure]
    public static extern string getExtensionFromFilename(string file);

#if STARFALL
    /// @CSharpLua.Template = string.getFileFromFilename({0})
#else
    /// @CSharpLua.Template = string.GetFileFromFilename({0})
#endif
    [Pure]
    public static extern string getFileFromFilename(string pathString);

#if STARFALL
    /// @CSharpLua.Template = string.getPathFromFilename({0})
#else
    /// @CSharpLua.Template = string.GetPathFromFilename({0})
#endif
    [Pure]
    public static extern string getPathFromFilename(string inputString);

    /// @CSharpLua.Template = strlib.gmatch({0}, {1})
    public static extern string[] gmatch(string data, string pattern);

    /// @CSharpLua.Template = string.gsub({0}, {1}, {2})
    [Pure]
    public static extern (string, int) gsub(string input, string pattern, string replacement);

    /// @CSharpLua.Template = string.gsub({0}, {1}, {2})
    [Pure]
    public static extern (string, int) gsub(string input, string pattern, dynamic replacement);

    /// @CSharpLua.Template = string.gsub({0}, {1}, {2})
    [Pure]
    public static extern (string, int) gsub(string input, string pattern, Action<string[]> replacement);

#if STARFALL
    /// @CSharpLua.Template = string.javascriptSafe({0})
#else
    /// @CSharpLua.Template = string.JavascriptSafe({0})
#endif
    [Pure]
    public static extern string javascriptSafe(string str);

#if STARFALL
    /// @CSharpLua.Template = string.left({0}, {1})
#else
    /// @CSharpLua.Template = string.Left({0}, {1})
#endif
    [Pure]
    public static extern string left(string str, int amount);

    /// @CSharpLua.Template = string.len({0})
    [Pure]
    public static extern int len(string str);

    /// @CSharpLua.Template = string.lower({0})
    [Pure]
    public static extern string lower(string str);

    /// @CSharpLua.Template = strlib.match({0}, {1})
    [Pure]
    public static extern string[]? match(string str, string pattern);

    /// @CSharpLua.Template = strlib.match({0}, {1}, {2})
    [Pure]
    public static extern string[]? match(string str, string pattern, int startPos);

#if STARFALL
    /// @CSharpLua.Template = string.niceSize({0})
#else
    /// @CSharpLua.Template = string.NiceSize({0})
#endif
    [Pure]
    public static extern string niceSize(ulong bytes);

#if STARFALL
    /// @CSharpLua.Template = string.niceTime({0})
#else
    /// @CSharpLua.Template = string.NiceTime({0})
#endif
    [Pure]
    public static extern string niceTime(ulong num);

#if STARFALL
    /// @CSharpLua.Template = string.patternSafe({0})
#else
    /// @CSharpLua.Template = string.PatternSafe({0})
#endif
    [Pure]
    public static extern string patternSafe(string str);

    /// @CSharpLua.Template = string.rep({0}, {1})
    [Pure]
    public static extern string rep(string str, int repetitions);

    /// @CSharpLua.Template = string.rep({0}, {1}, {2})
    [Pure]
    public static extern string rep(string str, int repetitions, string separator);

#if STARFALL
    /// @CSharpLua.Template = string.replace({0}, {1}, {2})
#else
    /// @CSharpLua.Template = string.Replace({0}, {1}, {2})
#endif
    [Pure]
    public static extern string replace(string str, string find, string replace);

    /// @CSharpLua.Template = string.reverse({0})
    [Pure]
    public static extern string reverse(string str);

#if STARFALL
    /// @CSharpLua.Template = string.right({0}, {1})
#else
    /// @CSharpLua.Template = string.Right({0}, {1})
#endif
    [Pure]
    public static extern string right(string str, int amount);

#if STARFALL
    /// @CSharpLua.Template = string.setChar({0}, {1}, {2})
#else
    /// @CSharpLua.Template = string.SetChar({0}, {1}, {2})
#endif
    [Pure]
    public static extern string setChar(string inputString, int index, string replacementChar);

#if STARFALL
    /// @CSharpLua.Template = string.split({0}, {1})
#else
    /// @CSharpLua.Template = string.Split({0}, {1})
#endif
    [Pure]
    public static extern string[] split(string inputString, string separator);

#if STARFALL
    /// @CSharpLua.Template = string.startWith({0}, {1})
#else
    /// @CSharpLua.Template = string.StartWith({0}, {1})
#endif
    [Pure]
    public static extern bool startWith(string inputString, string start);

#if STARFALL
    /// @CSharpLua.Template = string.stripExtension({0})
#else
    /// @CSharpLua.Template = string.StripExtension({0})
#endif
    [Pure]
    public static extern string stripExtension(string inputString);

    /// @CSharpLua.Template = string.sub({0}, {1})
    [Pure]
    public static extern string sub(string str, int startPos);

    /// @CSharpLua.Template = string.sub({0}, {1}, {2})
    [Pure]
    public static extern string sub(string str, int startPos, int endPos);

#if STARFALL
    /// @CSharpLua.Template = string.toMinutesSeconds({0})
#else
    /// @CSharpLua.Template = string.ToMinutesSeconds({0})
#endif
    [Pure]
    public static extern string toMinutesSeconds(ulong time);

#if STARFALL
    /// @CSharpLua.Template = string.toMinutesSecondsMilliseconds({0})
#else
    /// @CSharpLua.Template = string.ToMinutesSecondsMilliseconds({0})
#endif
    [Pure]
    public static extern string toMinutesSecondsMilliseconds(double time);

#if STARFALL
    /// @CSharpLua.Template = string.toTable({0})
#else
    /// @CSharpLua.Template = string.ToTable({0})
#endif
    [Pure]
    public static extern byte[] toTable(string str);

#if STARFALL
    /// @CSharpLua.Template = string.trim({0})
#else
    /// @CSharpLua.Template = string.Trim({0})
#endif
    [Pure]
    public static extern string trim(string inputString);

#if STARFALL
    /// @CSharpLua.Template = string.trim({0}, {1})
#else
    /// @CSharpLua.Template = string.Trim({0}, {1})
#endif
    [Pure]
    public static extern string trim(string inputString, string toMatch = "%s");

#if STARFALL
    /// @CSharpLua.Template = string.trimLeft({0}, {1})
#else
    /// @CSharpLua.Template = string.TrimLeft({0}, {1})
#endif
    [Pure]
    public static extern string trimLeft(string str, string toRemove);

#if STARFALL
    /// @CSharpLua.Template = string.trimRight({0}, {1})
#else
    /// @CSharpLua.Template = string.TrimRight({0}, {1})
#endif
    [Pure]
    public static extern string trimRight(string str, string toRemove);

    /// @CSharpLua.Template = string.upper({0})
    [Pure]
    public static extern string upper(string str);
}

/// @CSharpLua.Ignore
public static class StringExtensions
{
    /// @CSharpLua.Template = string.lower({0})
    [Pure]
    public static extern string lower(this string @this);

    /// @CSharpLua.Template = string.upper({0})
    [Pure]
    public static extern string upper(this string @this);

    /// @CSharpLua.Template = string.sub({0}, {1})
    [Pure]
    public static extern string sub(this string @this, int startPos);

    /// @CSharpLua.Template = string.sub({0}, {1}, {2})
    [Pure]
    public static extern string sub(this string @this, int startPos, int endPos);

#if STARFALL
    /// @CSharpLua.Template = string.trim({0})
#else
    /// @CSharpLua.Template = string.Trim({0})
#endif
    [Pure]
    public static extern string trim(this string @this);
}

/// @CSharpLua.Ignore
public static partial class table
{
    /// @CSharpLua.Template = table.concat({0}, {1})
    [Pure]
    public static extern string concat(dynamic table, string concatenator);

    /// @CSharpLua.Template = table.concat({0}, {1}, {2})
    [Pure]
    public static extern string concat(dynamic table, string concatenator, long startPos);

    /// @CSharpLua.Template = table.concat({0}, {1}, {2}, {3})
    [Pure]
    public static extern string concat(dynamic table, string concatenator, long startPos, long endPos);

#if STARFALL
    /// @CSharpLua.Template = table.copy({0})
#else
    /// @CSharpLua.Template = table.Copy({0})
#endif
    [Pure]
    public static extern dynamic Copy(dynamic table);

#if STARFALL
    /// @CSharpLua.Template = table.count({0})
#else
    /// @CSharpLua.Template = table.Count({0})
#endif
    [Pure]
    public static extern int Count(dynamic table);

#if STARFALL
    /// @CSharpLua.Template = table.empty({0})
#else
    /// @CSharpLua.Template = table.Empty({0})
#endif
    public static extern void Empty(dynamic table);

#if STARFALL
    /// @CSharpLua.Template = table.getKeys({0})
#else
    /// @CSharpLua.Template = table.GetKeys({0})
#endif
    [Pure]
    public static extern dynamic GetKeys(dynamic table);

#if STARFALL
    /// @CSharpLua.Template = table.isEmpty({0})
#else
    /// @CSharpLua.Template = table.IsEmpty({0})
#endif
    [Pure]
    public static extern bool IsEmpty(dynamic table);

#if STARFALL
    /// @CSharpLua.Template = table.isSequential({0})
#else
    /// @CSharpLua.Template = table.IsSequential({0})
#endif
    [Pure]
    public static extern bool IsSequential(dynamic table);

    /// @CSharpLua.Template = table.remove({0})
    public static extern T remove<T>(dynamic table);

    /// @CSharpLua.Template = table.remove({0}, {1})
    public static extern T remove<T>(dynamic table, int key);

#if STARFALL
    /// @CSharpLua.Template = table.reverse({0})
#else
    /// @CSharpLua.Template = table.Reverse({0})
#endif
    [Pure]
    public static extern dynamic Reverse(dynamic table);

    /// @CSharpLua.Template = table.sort({0}, {1})
    public static extern void sort(dynamic table, Func<object, object, bool> sorter);
}

/// @CSharpLua.Ignore
public static partial class math
{
    /// @CSharpLua.Template = math.huge
    public static readonly double huge = double.MaxValue;

    /// @CSharpLua.Template = math.pi
    public static readonly double pi = Math.PI;

    /// @CSharpLua.Template = math.abs({0})
    [Pure]
    public static extern double abs(double number);

    /// @CSharpLua.Template = math.acos({0})
    [Pure]
    public static extern double acos(double cos);

#if STARFALL
    /// @CSharpLua.Template = math.angleDifference({0}, {1})
#else
    /// @CSharpLua.Template = math.AngleDifference({0}, {1})
#endif
    [Pure]
    public static extern double AngleDifference(double a, double b);

#if STARFALL
    /// @CSharpLua.Template = math.approach({0}, {1}, {2})
#else
    /// @CSharpLua.Template = math.Approach({0}, {1}, {2})
#endif
    [Pure]
    public static extern double Approach(double current, double target, double change);

#if STARFALL
    /// @CSharpLua.Template = math.approachAngle({0}, {1}, {2})
#else
    /// @CSharpLua.Template = math.ApproachAngle({0}, {1}, {2})
#endif
    [Pure]
    public static extern double ApproachAngle(double currentAngle, double targetAngle, double rate);

    /// @CSharpLua.Template = math.asin({0})
    [Pure]
    public static extern double asin(double num);

    /// @CSharpLua.Template = math.atan({0})
    [Pure]
    public static extern double atan(double num);

    /// @CSharpLua.Template = math.atan2({0}, {1})
    [Pure]
    public static extern double atan2(double y, double x);

#if STARFALL
    /// @CSharpLua.Template = math.binToInt({0})
#else
    /// @CSharpLua.Template = math.BinToInt({0})
#endif
    [Pure]
    public static extern T BinToInt<T>(string binaryString) where T : unmanaged;

#if STARFALL
    /// @CSharpLua.Template = math.bSplinePoint({0}, {1}, {2})
#else
    /// @CSharpLua.Template = math.BSplinePoint({0}, {1}, {2})
#endif
    [Pure]
    public static extern Vector BSplinePoint(double tDiff, Vector[] points, double tMax = 1.0);

#if STARFALL
    /// @CSharpLua.Template = math.calcBSplineN({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = math.calcBSplineN({0}, {1}, {2}, {3})
#endif
    [Pure]
    public static extern double calcBSplineN(double i, double k, double t, double tInc);

    /// @CSharpLua.Template = math.ceil({0})
    [Pure]
    public static extern double ceil(double num);

#if STARFALL
    /// @CSharpLua.Template = math.clamp({0}, {1}, {2})
#else
    /// @CSharpLua.Template = math.Clamp({0}, {1}, {2})
#endif
    [Pure]
    public static extern double Clamp(double input, double min, double max);

    /// @CSharpLua.Template = math.cos({0})
    [Pure]
    public static extern double cos(double num);

    /// @CSharpLua.Template = math.cosh({0})
    [Pure]
    public static extern double cosh(double num);

    /// @CSharpLua.Template = math.deg({0})
    [Pure]
    public static extern double deg(double radians);

#if STARFALL
    /// @CSharpLua.Template = math.distance({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = math.Distance({0}, {1}, {2}, {3})
#endif
    [Pure]
    public static extern double Distance(double x1, double y1, double x2, double y2);

#if STARFALL
    /// @CSharpLua.Template = math.easeInOut({0}, {1}, {2})
#else
    /// @CSharpLua.Template = math.EaseInOut({0}, {1}, {2})
#endif
    [Pure]
    public static extern double EaseInOut(double progress, double easeIn, double easeOut);

    /// @CSharpLua.Template = math.exp({0})
    [Pure]
    public static extern double exp(double exponent);

    /// @CSharpLua.Template = math.floor({0})
    [Pure]
    public static extern double floor(double num);

    /// @CSharpLua.Template = math.fmod({0}, {1})
    [Pure]
    public static extern double fmod(double num, double modulator);

    /// @CSharpLua.Template = System.Tuple(math.frexp({0}))
    [Pure]
    public static extern (double, double) frexp(double x);

#if STARFALL
    /// @CSharpLua.Template = math.intToBin({0})
#else
    /// @CSharpLua.Template = math.IntToBin({0})
#endif
    [Pure]
    public static extern string IntToBin<T>(T num) where T : unmanaged;

    /// @CSharpLua.Template = math.ldexp({0}, {1})
    [Pure]
    public static extern double ldexp(double normalizedFraction, double exponent);

    /// @CSharpLua.Template = math.log({0})
    [Pure]
    public static extern double log(double x);

    /// @CSharpLua.Template = math.log({0}, {1})
    [Pure]
    public static extern double log(double x, double @base);

    /// @CSharpLua.Template = math.log10({0})
    [Pure]
    public static extern double log10(double x);

    /// @CSharpLua.Template = math.max({*0})
    [Pure]
    public static extern double max(params double[] numbers);

    /// @CSharpLua.Template = math.min({*0})
    [Pure]
    public static extern double min(params double[] numbers);

    /// @CSharpLua.Template = System.Tuple(math.modf({0}))
    [Pure]
    public static extern (long, double) modf(double num);

#if STARFALL
    /// @CSharpLua.Template = math.normalizeAngle({0})
#else
    /// @CSharpLua.Template = math.NormalizeAngle({0})
#endif
    [Pure]
    public static extern double NormalizeAngle(double angle);

    /// @CSharpLua.Template = math.pow({0}, {1})
    [Pure]
    public static extern double pow(double x, double y);

    /// @CSharpLua.Template = math.rad({0})
    [Pure]
    public static extern double rad(double degrees);

#if STARFALL
    /// @CSharpLua.Template = math.rand({0}, {1})
#else
    /// @CSharpLua.Template = math.Rand({0}, {1})
#endif
    [Pure]
    public static extern double Rand(double min, double max);

    /// @CSharpLua.Template = math.random()
    [Pure]
    public static extern double random();

    /// @CSharpLua.Template = math.random({0})
    [Pure]
    public static extern int random(int max);

    /// @CSharpLua.Template = math.random({0}, {1})
    [Pure]
    public static extern int random(int min, int max);

#if !STARFALL
    /// @CSharpLua.Template = math.randomseed({0})
    public static extern void RandomSeed(double seed);
#endif

#if STARFALL
    /// @CSharpLua.Template = math.remap({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = math.Remap({0}, {1}, {2}, {3}, {4})
#endif
    [Pure]
    public static extern double Remap(double value, double inMin, double inMax, double outMin, double outMax);

#if STARFALL
    /// @CSharpLua.Template = math.round({0}, {1})
#else
    /// @CSharpLua.Template = math.Round({0}, {1})
#endif
    [Pure]
    public static extern double Round(double value, int decimals = 0);

    /// @CSharpLua.Template = math.sin({0})
    [Pure]
    public static extern double sin(double num);

    /// @CSharpLua.Template = math.sinh({0})
    [Pure]
    public static extern double sinh(double num);

    /// @CSharpLua.Template = math.sqrt({0})
    [Pure]
    public static extern double sqrt(double num);

    /// @CSharpLua.Template = math.tan({0})
    [Pure]
    public static extern double tan(double num);

    /// @CSharpLua.Template = math.tanh({0})
    [Pure]
    public static extern double tanh(double num);

#if STARFALL
    /// @CSharpLua.Template = math.timeFraction({0}, {1}, {2})
#else
    /// @CSharpLua.Template = math.TimeFraction({0}, {1}, {2})
#endif
    [Pure]
    public static extern double TimeFraction(double start, double end, double current);

    /// @CSharpLua.Template = math.Truncate({0}, {1})
    [Pure]
    public static extern double Truncate(double num, int digits = 0);

#if STARFALL
    /// @CSharpLua.Template = math.lerp({0}, {1}, {2})
#else
    /// @CSharpLua.Template = _G.Lerp({0}, {1}, {2})
#endif
    [Pure]
    public static extern double Lerp(double t, double from, double to);

#if STARFALL
    /// @CSharpLua.Template = math.lerpAngle({0}, {1}, {2})
#else
    /// @CSharpLua.Template = _G.LerpAngle({0}, {1}, {2})
#endif
    [Pure]
    public static extern Angle LerpAngle(float ratio, Angle from, Angle to);

#if STARFALL
    /// @CSharpLua.Template = math.lerpVector({0}, {1}, {2})
#else
    /// @CSharpLua.Template = _G.LerpVector({0}, {1}, {2})
#endif
    [Pure]
    public static extern Vector LerpVector(float ratio, Vector from, Vector to);
}

/// @CSharpLua.Ignore
public static partial class bit
{
    /// @CSharpLua.Template = bit.arshift({0}, {1})
    [Pure]
    public static extern int arshift(int value, int shiftCount);

    /// @CSharpLua.Template = bit.band({0}, {*1})
    [Pure]
    public static extern int band(int value, params int[] otherValues);

    /// @CSharpLua.Template = bit.bnot({0})
    [Pure]
    public static extern int bnot(int value);

    /// @CSharpLua.Template = bit.bor({0}, {*1})
    [Pure]
    public static extern int bor(int value, params int[] otherValues);

    /// @CSharpLua.Template = bit.bswap({0})
    [Pure]
    public static extern int bswap(int value);

    /// @CSharpLua.Template = bit.bxor({0}, {*1})
    [Pure]
    public static extern int bxor(int value, params int[] otherValues);

    /// @CSharpLua.Template = bit.lshift({0}, {1})
    [Pure]
    public static extern int lshift(int value, int shiftCount);

    /// @CSharpLua.Template = bit.rol({0}, {1})
    [Pure]
    public static extern int rol(int value, int shiftCount);

    /// @CSharpLua.Template = bit.ror({0}, {1})
    [Pure]
    public static extern int ror(int value, int shiftCount);

    /// @CSharpLua.Template = bit.rshift({0}, {1})
    [Pure]
    public static extern int rshift(int value, int shiftCount);

    /// @CSharpLua.Template = bit.tobit({0})
    [Pure]
    public static extern int tobit<T>(T value) where T : unmanaged;

    /// @CSharpLua.Template = bit.tohex({0}, {1})
    [Pure]
    public static extern string tohex(int value, int digits = 8);
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

#if STARFALL
    /// @CSharpLua.Template = http.get({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = http.Fetch({0}, {1}, {2}, {3})
#endif
    public static extern void Fetch(string url, Action<string, long, dynamic, int> callbackSuccess);

#if STARFALL
    /// @CSharpLua.Template = http.get({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = http.Fetch({0}, {1}, {2}, {3})
#endif
    public static extern void Fetch(string url, Action<string, long, dynamic, int> callbackSuccess, Action<string> callbackFail);

#if STARFALL
    /// @CSharpLua.Template = http.get({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = http.Fetch({0}, {1}, {2}, {3})
#endif
    public static extern void Fetch(string url, Action<string, long, dynamic, int> callbackSuccess, Action<string> callbackFail, dynamic headers);

#if STARFALL
    /// @CSharpLua.Template = http.post({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = http.Post({0}, {1}, {2}, {3}, {4})
#endif
    public static extern void Post(string url, string payload, Action<string, long, dynamic, int> callbackSuccess);

#if STARFALL
    /// @CSharpLua.Template = http.post({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = http.Post({0}, {1}, {2}, {3}, {4})
#endif
    public static extern void Post(string url, dynamic payload, Action<string, long, dynamic, int> callbackSuccess);

#if STARFALL
    /// @CSharpLua.Template = http.post({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = http.Post({0}, {1}, {2}, {3}, {4})
#endif
    public static extern void Post(string url, string payload, Action<string, long, dynamic, int> callbackSuccess, Action<string> callbackFail);

#if STARFALL
    /// @CSharpLua.Template = http.post({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = http.Post({0}, {1}, {2}, {3}, {4})
#endif
    public static extern void Post(string url, dynamic payload, Action<string, long, dynamic, int> callbackSuccess, Action<string> callbackFail);

#if STARFALL
    /// @CSharpLua.Template = http.post({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = http.Post({0}, {1}, {2}, {3}, {4})
#endif
    public static extern void Post(string url, string payload, Action<string, long, dynamic, int> callbackSuccess, Action<string> callbackFail, dynamic headers);

#if STARFALL
    /// @CSharpLua.Template = http.post({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = http.Post({0}, {1}, {2}, {3}, {4})
#endif
    public static extern void Post(string url, dynamic payload, Action<string, long, dynamic, int> callbackSuccess, Action<string> callbackFail, dynamic headers);
}

/// @CSharpLua.Ignore
public static partial class input
{
}

/// @CSharpLua.Ignore
public sealed partial class Material
{
    private extern Material();
}

#if CLIENT
/// @CSharpLua.Ignore
public static partial class render
{
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool StencilEnable { set; }
#else
#if STARFALL
    /// @CSharpLua.Template = render.setStencilEnable({0})
#else
    /// @CSharpLua.Template = render.SetStencilEnable({0})
#endif
    public static extern void SetStencilEnable(bool stencilEnable);
#endif

#if STARFALL
    /// @CSharpLua.Template = render.clearStencil()
#else
    /// @CSharpLua.Template = render.ClearStencil()
#endif
    public static extern void ClearStencil();

#if STARFALL
    /// @CSharpLua.Template = render.clearBuffersObeyStencil({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = render.ClearBuffersObeyStencil({0}, {1}, {2}, {3}, {4})
#endif
    public static extern void ClearBuffersObeyStencil(byte r, byte g, byte b, byte a, bool depth);

#if STARFALL
    /// @CSharpLua.Template = render.clearStencilBufferRectangle({0}, {1}, {2}, {3}, {4})
#else
    /// @CSharpLua.Template = render.ClearStencilBufferRectangle({0}, {1}, {2}, {3}, {4})
#endif
    public static extern void ClearStencilBufferRectangle(int originX, int originY, int endX, int endY, int stencilValue);

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern STENCIL StencilCompareFunction { set; }
#else
#if STARFALL
    /// @CSharpLua.Template = render.setStencilCompareFunction({0})
#else
    /// @CSharpLua.Template = render.SetStencilCompareFunction({0})
#endif
    public static extern void SetStencilCompareFunction(STENCIL compareFunction);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern STENCIL StencilFailOperation { set; }
#else
#if STARFALL
    /// @CSharpLua.Template = render.setStencilFailOperation({0})
#else
    /// @CSharpLua.Template = render.SetStencilFailOperation({0})
#endif
    public static extern void SetStencilFailOperation(STENCIL failOperation);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern STENCIL StencilPassOperation { set; }
#else
#if STARFALL
    /// @CSharpLua.Template = render.setStencilPassOperation({0})
#else
    /// @CSharpLua.Template = render.SetStencilPassOperation({0})
#endif
    public static extern void SetStencilPassOperation(STENCIL passOperation);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern STENCIL StencilZFailOperation { set; }
#else
#if STARFALL
    /// @CSharpLua.Template = render.setStencilZFailOperation({0})
#else
    /// @CSharpLua.Template = render.SetStencilZFailOperation({0})
#endif
    public static extern void SetStencilZFailOperation(STENCIL zFailOperation);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern uint StencilReferenceValue { set; }
#else
#if STARFALL
    /// @CSharpLua.Template = render.setStencilReferenceValue({0})
#else
    /// @CSharpLua.Template = render.SetStencilReferenceValue({0})
#endif
    public static extern void SetStencilReferenceValue(uint referenceValue);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern byte StencilTestMask { set; }
#else
#if STARFALL
    /// @CSharpLua.Template = render.setStencilTestMask({0})
#else
    /// @CSharpLua.Template = render.SetStencilTestMask({0})
#endif
    public static extern void SetStencilTestMask(byte testMask);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern byte StencilWriteMask { set; }
#else
#if STARFALL
    /// @CSharpLua.Template = render.setStencilWriteMask({0})
#else
    /// @CSharpLua.Template = render.SetStencilWriteMask({0})
#endif
    public static extern void SetStencilWriteMask(byte writeMask);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern int LightingMode { set; }
#else
#if STARFALL
	/// @CSharpLua.Template = render.setLightingMode({0})
#else
	/// @CSharpLua.Template = render.SetLightingMode({0})
#endif
	public static extern void SetLightingMode(int mode);
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern MATERIAL_CULLMODE CullMode { set; }
#else
#if STARFALL
	/// @CSharpLua.Template = render.setCullMode({0})
#else
	/// @CSharpLua.Template = render.CullMode({0})
#endif
	public static extern void CullMode(MATERIAL_CULLMODE cullMode);
#endif

#if STARFALL
    /// @CSharpLua.Template = render.clearDepth()
#else
    /// @CSharpLua.Template = render.ClearDepth()
#endif
    public static extern void ClearDepth();

#if STARFALL
    /// @CSharpLua.Template = render.capturePixels()
#else
    /// @CSharpLua.Template = render.CapturePixels()
#endif
    public static extern void CapturePixels();

#if STARFALL
    /// @CSharpLua.Template = render.enableClipping({0})
#else
    /// @CSharpLua.Template = render.EnableClipping({0})
#endif
    public static extern bool EnableClipping(bool enable);

    /// @CSharpLua.Template = render.pushCustomClipPlane({0}, {1})
    public static extern void PushCustomClipPlane(Vector normal, float distance);

    /// @CSharpLua.Template = render.popCustomClipPlane()
    public static extern void PopCustomClipPlane();

#if STARFALL
    /// @CSharpLua.Template = render.computeLighting({0}, {1})
#else
    /// @CSharpLua.Template = render.ComputeLighting({0}, {1})
#endif
    [Pure]
    public static extern Vector ComputeLighting(Vector pos, Vector normal);

#if STARFALL
    /// @CSharpLua.Template = render.computeDynamicLighting({0}, {1})
#else
    /// @CSharpLua.Template = render.ComputeDynamicLighting({0}, {1})
#endif
    [Pure]
    public static extern Vector ComputeDynamicLighting(Vector pos, Vector normal);

#if STARFALL
    /// @CSharpLua.Template = render.getLightColor({0})
#else
    /// @CSharpLua.Template = render.GetLightColor({0})
#endif
    [Pure]
    public static extern Vector GetLightColor(Vector pos);

#if STARFALL
    /// @CSharpLua.Template = render.getAmbientLightColor()
#else
    /// @CSharpLua.Template = render.GetAmbientLightColor()
#endif
    [Pure]
    public static extern Vector GetAmbientLightColor();

#if STARFALL
    /// @CSharpLua.Template = render.setFogMod({0})
#else
    /// @CSharpLua.Template = render.FogMod({0})
#endif
    public static extern void FogMod(MATERIAL_FOG fogMode);

#if STARFALL
    /// @CSharpLua.Template = render.setFogColor({0})
    public static extern void FogColor(Color color);
#else
    /// @CSharpLua.Template = render.FogColor({0}, {1}, {2})
    public static extern void FogColor(byte r, byte g, byte b);
#endif

#if STARFALL
    /// @CSharpLua.Template = render.setFogDensity({0})
#else
    /// @CSharpLua.Template = render.FogMaxDensity({0})
#endif
    public static extern void FogMaxDensity(float density);

#if STARFALL
    /// @CSharpLua.Template = render.setFogStart({0})
#else
    /// @CSharpLua.Template = render.FogStart({0})
#endif
    public static extern void FogStart(float distance);

#if STARFALL
    /// @CSharpLua.Template = render.setFogEnd({0})
#else
    /// @CSharpLua.Template = render.FogEnd({0})
#endif
    public static extern void FogEnd(float distance);

#if STARFALL
    /// @CSharpLua.Template = render.setFogHeight({0})
#else
    /// @CSharpLua.Template = render.SetFogZ({0})
#endif
    public static extern void SetFogZ(float height);

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool SupportsHDR { get; }
#else
    [Pure]
#if STARFALL
    /// @CSharpLua.Template = render.supportsHDR()
#else
    /// @CSharpLua.Template = render.SupportsHDR()
#endif
    public static extern bool SupportsHDR();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool HDREnabled { get; }
#else
    [Pure]
#if STARFALL
    /// @CSharpLua.Template = render.getHDREnabled()
#else
    /// @CSharpLua.Template = render.GetHDREnabled()
#endif
    public static extern bool GetHDREnabled();
#endif
}

/// @CSharpLua.Ignore
public static partial class surface
{
    /// @CSharpLua.Template = surface.SetDrawColor({0})
    public static extern void SetDrawColor(Color color);

    /// @CSharpLua.Template = surface.SetDrawColor({0}, {1}, {2}, {3})
    public static extern void SetDrawColor(byte r, byte g, byte b, byte a);

    /// @CSharpLua.Template = surface.SetTextColor({0})
    public static extern void SetTextColor(Color color);

    /// @CSharpLua.Template = surface.SetTextColor({0}, {1}, {2}, {3})
    public static extern void SetTextColor(byte r, byte g, byte b, byte a);
}

/// @CSharpLua.Ignore
public sealed partial class Markup
{
#if STARFALL
    /// @CSharpLua.Template = render.parseMarkup({0})
#else
    /// @CSharpLua.Template = markup.Parse({0})
#endif
    public extern Markup(string str);

#if STARFALL
    /// @CSharpLua.Template = render.parseMarkup({0}, {1})
#else
    /// @CSharpLua.Template = markup.Parse({0}, {1})
#endif
    public extern Markup(string str, int maxWidth);

#if STARFALL
    /// @CSharpLua.Template = render.parseMarkup({0})
#else
    /// @CSharpLua.Template = markup.Parse({0})
#endif
    [Pure]
    public static extern Markup Parse(string str);

#if STARFALL
    /// @CSharpLua.Template = render.parseMarkup({0}, {1})
#else
    /// @CSharpLua.Template = markup.Parse({0}, {1})
#endif
    [Pure]
    public static extern Markup Parse(string str, int maxWidth);

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern int Width { get; }
#else
    [Pure]
    public extern int GetWidth();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern int Height { get; }
#else
    [Pure]
    public extern int GetHeight();
#endif

    public extern void Draw(int x, int y, TEXT_ALIGN xAlign, TEXT_ALIGN yAlign);

    public extern void Draw(int x, int y, TEXT_ALIGN xAlign, TEXT_ALIGN yAlign, byte alpha);
}

/// @CSharpLua.Ignore
public static class MarkupExtensions
{
#if STARFALL
    /// @CSharpLua.Template = System.Tuple({0}:getSize())
#else
    /// @CSharpLua.Template = System.Tuple({0}:Size())
#endif
    [Pure]
    public static extern (int, int) GetSize(this Markup @this);
}

/// @CSharpLua.Ignore
public sealed class RenderCamData
{
    /// @CSharpLua.Template = _G.__RenderCamDataCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})
    public extern RenderCamData(int? x = null, int? y = null, int? w = null, int? h = null, string type = "3D", Vector? origin = null, Angle? angles = null, int? fov = null, double? aspect = null, double? zfar = null, double? znear = null, bool? subrect = false, bool? bloomtone = false, RenderCamData_Rect? offcenter = null, RenderCamData_Rect? ortho = null);

    /// @CSharpLua.Template = _G.__RenderCamDataCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})
    [Pure]
    public static extern RenderCamData Create(int? x = null, int? y = null, int? w = null, int? h = null, string type = "3D", Vector? origin = null, Angle? angles = null, int? fov = null, double? aspect = null, double? zfar = null, double? znear = null, bool? subrect = false, bool? bloomtone = false, RenderCamData_Rect? offcenter = null, RenderCamData_Rect? ortho = null);

    public int x;

    public int y;

    public int w;

    public int h;

    public string type;

    public Vector origin;

    public Angle angles;

    public int fov;

    public double aspect;

    public double zfar;

    public double znear;

    public bool subrect;

    public bool bloomtone;

    public RenderCamData_Rect? offcenter;

    public RenderCamData_Rect? ortho;
}

/// @CSharpLua.Ignore
public sealed class RenderCamData_Rect
{
    /// @CSharpLua.Template = _G.__RenderCamData_RectCreate({0}, {1}, {2}, {3})
    public extern RenderCamData_Rect(float? left = null, float? right = null, float? bottom = null, float? top = null);

    /// @CSharpLua.Template = _G.__RenderCamData_RectCreate({0}, {1}, {2}, {3})
    [Pure]
    public static extern RenderCamData_Rect Create(float? left = null, float? right = null, float? bottom = null, float? top = null);

    public float left, right, bottom, top;
}

/// @CSharpLua.Ignore
public sealed class ColorModify
{
    /// @CSharpLua.Template = _G.__ColorModifyCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})
    public extern ColorModify(float addr = 0f, float addg = 0f, float addb = 0f, float brightness = 0f, float colour = 1f, float contrast = 1f, float mulr = 1f, float mulg = 1f, float mulb = 1f);

    /// @CSharpLua.Template = _G.__ColorModifyCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})
    [Pure]
    public static extern ColorModify CreateColorModify(float addr = 0f, float addg = 0f, float addb = 0f, float brightness = 0f, float colour = 1f, float contrast = 1f, float mulr = 1f, float mulg = 1f, float mulb = 1f);

    public float addr, addg, addb, brightness, colour, contrast, mulr, mulg, mulb;
}

/// @CSharpLua.Ignore
public sealed partial class Vertex
{
    /// @CSharpLua.Template = _G.__VertexCreate({0}, {1})
    public extern Vertex(float x, float y);

    /// @CSharpLua.Template = _G.__VertexCreate({0}, {1}, {2}, {3})
    public extern Vertex(float x, float y, float u, float v);

    /// @CSharpLua.Template = _G.__VertexCreate({0}, {1}, {2}, {3})
    [Pure]
    public static extern Vertex Create(float x, float y, float u = 0f, float v = 0f);

    public float x, y, u, v;
}
#endif

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
public static partial class game
{
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern string Map { get; }
#else
#if STARFALL
    /// @CSharpLua.Template = game.getMap()
#else
    /// @CSharpLua.Template = game.GetMap()
#endif
    [Pure]
    public static extern string GetMap();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern string HostName { get; }
#else
#if STARFALL
    /// @CSharpLua.Template = game.getHostname()
#else
    /// @CSharpLua.Template = _G.GetHostName()
#endif
    [Pure]
    public static extern string GetMap();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool IsDedicated { get; }
#else
#if STARFALL
    /// @CSharpLua.Template = game.isDedicated()
#else
    /// @CSharpLua.Template = game.IsDedicated()
#endif
    [Pure]
    public static extern bool IsDedicated();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern int MaxPlayers { get; }
#else
#if STARFALL
    /// @CSharpLua.Template = game.maxPlayers()
#else
    /// @CSharpLua.Template = game.MaxPlayers()
#endif
    [Pure]
    public static extern int MaxPlayers();
#endif

#if STARFALL
    /// @CSharpLua.Template = game.isMounted({0})
#else
    /// @CSharpLua.Template = _G.IsMounted({0})
#endif
    [Pure]
    public static extern bool IsMounted(string gameId);
}

/// @CSharpLua.Ignore
public static partial class system
{
#if CLIENT
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool HasFocus { get; }
#else
#if STARFALL
    /// @CSharpLua.Template = game.hasFocus()
#else
    /// @CSharpLua.Template = system.HasFocus()
#endif
    [Pure]
    public static extern bool HasFocus();
#endif
#endif
}

#if CLIENT
public sealed class SunInfo
{
    private extern SunInfo();

    public extern Vector direction { get; }

    public extern float obstruction { get; }
}
#endif

/// @CSharpLua.Ignore
public static partial class util
{
#if CLIENT
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern SunInfo SunInfo { get; }
#endif

    /// @CSharpLua.Template = util.GetSunInfo()
    [Pure]
    public static extern SunInfo GetSunInfo();
#endif

    /// @CSharpLua.Template = util.TraceLine({0})
    [Pure]
#if STARFALL
    public static extern TraceResult TraceLine(Trace traceData);
#else
    public static extern TraceResult? TraceLine(Trace traceData);
#endif

    /// @CSharpLua.Template = util.TraceHull({0})
    [Pure]
#if STARFALL
    public static extern TraceResult TraceHull(HullTrace traceData);
#else
    public static extern TraceResult? TraceHull(HullTrace traceData);
#endif

#if STARFALL
    /// @CSharpLua.Template = System.Tuple(trace.intersectRayWithOBB({0}, {1}, {2}, {3}, {4}, {5}))
#else
    /// @CSharpLua.Template = System.Tuple(util.IntersectRayWithOBB({0}, {1}, {2}, {3}, {4}, {5}))
#endif
    [Pure]
    public static extern (Vector?, Vector?, double?) IntersectRayWithOBB(Vector rayStart, Vector rayDelta, Vector boxOrigin, Angle boxAngles, Vector boxMins, Vector boxMaxs);

#if STARFALL
    /// @CSharpLua.Template = trace.intersectRayWithPlane({0}, {1}, {2}, {3})
#else
    /// @CSharpLua.Template = util.IntersectRayWithPlane({0}, {1}, {2}, {3})
#endif
    [Pure]
    public static extern Vector? IntersectRayWithPlane(Vector rayOrigin, Vector rayDirection, Vector planePosition, Vector planeNormal);

#if STARFALL
    /// @CSharpLua.Template = trace.pointContents({0})
#else
    /// @CSharpLua.Template = util.PointContents({0})
#endif
    [Pure]
    public static extern CONTENTS PointContents(Vector position);

#if STARFALL
    /// @CSharpLua.Template = _G.crc({0})
#else
    /// @CSharpLua.Template = util.CRC({0})
#endif
    [Pure]
    public static extern string CRC(string data);

#if STARFALL
    /// @CSharpLua.Template = fastlz.compress({0})
#else
    /// @CSharpLua.Template = util.Compress({0})
#endif
    [Pure]
    public static extern string Compress(string data);

#if STARFALL
    /// @CSharpLua.Template = fastlz.decompress({0})
#else
    /// @CSharpLua.Template = util.Decompress({0})
#endif
    [Pure]
    public static extern string Decompress(string compressedData);

#if STARFALL
    /// @CSharpLua.Template = http.base64Decode({0})
#else
    /// @CSharpLua.Template = util.Base64Decode({0})
#endif
    [Pure]
    public static extern string Base64Decode(string encodedData);

#if STARFALL
    /// @CSharpLua.Template = http.base64Encode({0})
#else
    /// @CSharpLua.Template = util.Base64Encode({0})
#endif
    [Pure]
    public static extern string Base64Encode(string data);

#if STARFALL
    /// @CSharpLua.Template = json.encode({0})
#else
    /// @CSharpLua.Template = util.TableToJSON({0})
#endif
    [Pure]
    public static extern string TableToJSON(dynamic table);

#if STARFALL
    /// @CSharpLua.Template = json.encode({0}, {1})
#else
    /// @CSharpLua.Template = util.TableToJSON({0}, {1})
#endif
    [Pure]
    public static extern string TableToJSON(dynamic table, bool prettyPrint);

#if STARFALL
    /// @CSharpLua.Template = json.decode({0})
#else
    /// @CSharpLua.Template = util.JSONToTable({0})
#endif
    [Pure]
    public static extern dynamic JSONToTable(string json);
}

/// @CSharpLua.Ignore
public sealed class Trace
{
    private extern Trace();

#if STARFALL
    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, nil, {2}, {3}, {4})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, {2}, {3}, {4}, {5})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, BaseEntity filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, {2}, {3}, {4}, {5})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, BaseEntity[] filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, {2}, {3}, {4}, {5})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, Func<BaseEntity, bool> filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, {2}, {3}, {4}, {5})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, Action<BaseEntity> filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);
#else
    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, nil, {2}, {3}, {4}, {5})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);

    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, BaseEntity filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);

    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, BaseEntity[] filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);

    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, Func<BaseEntity, bool> filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);

    /// @CSharpLua.Template = _G.__TraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6})
    [Pure]
    public static extern Trace Create(Vector start, Vector endpos, Action<BaseEntity> filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);
#endif

    public Vector start;

    public Vector endpos;

    // BaseEntity / BaseEntity[] / Func<BaseEntity, bool> / Action<BaseEntity> / null
    public dynamic? filter;

    // MASK / CONTENTS (combination)
    public uint? mask;

    public COLLISION_GROUP? collisiongroup;

    public bool? ignoreworld;

#if !STARFALL
    public TraceResult? output;
#endif
}

/// @CSharpLua.Ignore
public sealed class HullTrace
{
    private extern HullTrace();

#if STARFALL
    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, nil, {4}, {5}, {6})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, BaseEntity filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, BaseEntity[] filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, Func<BaseEntity, bool> filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, Action<BaseEntity> filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);
#else
    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, nil, {4}, {5}, {6}, {7})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);

    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, BaseEntity filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);

    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, BaseEntity[] filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);

    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, Func<BaseEntity, bool> filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);

    /// @CSharpLua.Template = _G.__HullTraceCreate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})
    [Pure]
    public static extern HullTrace Create(Vector start, Vector endpos, Vector maxs, Vector mins, Action<BaseEntity> filter, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null, TraceResult? output = null);
#endif

    public Vector start;

    public Vector endpos;

    public Vector maxs;

    public Vector mins;

    // BaseEntity / BaseEntity[] / Func<BaseEntity, bool> / Action<BaseEntity> / null
    public dynamic? filter;

    // MASK / CONTENTS (combination)
    public uint? mask;

    public COLLISION_GROUP? collisiongroup;

    public bool? ignoreworld;

#if !STARFALL
    public TraceResult? output;
#endif
}

/// @CSharpLua.Ignore
public static class TraceExtensions
{
    /// @CSharpLua.Template = {0}.filter = {1}
    public static extern void SetFilter(this Trace @this, BaseEntity filter); // TODO: SF

    /// @CSharpLua.Template = {0}.filter = {1}
    public static extern void SetFilter(this Trace @this, BaseEntity[] filter);

    /// @CSharpLua.Template = {0}.filter = {1}
    public static extern void SetFilter(this Trace @this, Func<BaseEntity, bool> filter);

    /// @CSharpLua.Template = {0}.filter = {1}
    public static extern void SetFilter(this Trace @this, Action<BaseEntity> filter);

    /// @CSharpLua.Template = {0}.filter = nil
    public static extern void ResetFilter(this Trace @this);

    /// @CSharpLua.Template = {0}.filter = {1}
    public static extern void SetFilter(this HullTrace @this, BaseEntity filter); // TODO: SF

    /// @CSharpLua.Template = {0}.filter = {1}
    public static extern void SetFilter(this HullTrace @this, BaseEntity[] filter);

    /// @CSharpLua.Template = {0}.filter = {1}
    public static extern void SetFilter(this HullTrace @this, Func<BaseEntity, bool> filter);

    /// @CSharpLua.Template = {0}.filter = {1}
    public static extern void SetFilter(this HullTrace @this, Action<BaseEntity> filter);

    /// @CSharpLua.Template = {0}.filter = nil
    public static extern void ResetFilter(this HullTrace @this);
}

/// @CSharpLua.Ignore
public sealed class TraceResult
{
    private extern TraceResult();

    public extern BaseEntity Entity { get; }

    public extern float Fraction { get; }

    public extern float FractionLeftSolid { get; }

    public extern bool Hit { get; }

    public extern int HitBox { get; }

    public extern HITGROUP HitGroup { get; }

    public extern bool HitNoDraw { get; }

    public extern bool HitNonWorld { get; }

    public extern Vector HitNormal { get; }

    public extern Vector HitPos { get; }

    public extern bool HitSky { get; }

    public extern string HitTexture { get; }

    public extern bool HitWorld { get; }

    public extern MAT MatType { get; }

    public extern Vector Normal { get; }

    public extern int PhysicsBone { get; }

    public extern Vector StartPos { get; }

    public extern int /*byte*/ SurfaceProps { get; }

    public extern bool StartSolid { get; }

    public extern bool AllSolid { get; }

    public extern SURF SurfaceFlags { get; }

    public extern DISPSURF DispFlags { get; }

    public extern CONTENTS Contents { get; }
}

/// @CSharpLua.Ignore
public static partial class sound
{
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

#if CLIENT
    /// @CSharpLua.Template = sound.PlayFile({0}, {1}, {2})
    public static extern void PlayFile(string filePath, string flags, AudioPlayCallback1 callback);

    /// @CSharpLua.Template = sound.PlayFile({0}, {1}, {2})
    public static extern void PlayFile(string filePath, string flags, AudioPlayCallback2 callback);

    /// @CSharpLua.Template = sound.PlayFile({0}, {1}, {2})
    public static extern void PlayFile(string filePath, string flags, AudioPlayCallback3 callback);
#endif
}

#if CLIENT
/// @CSharpLua.Ignore
public static partial class bass
{
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

/// <param name="channel">The sound channel.</param>
#if STARFALL
public delegate void AudioPlayCallback1(IGModAudioChannel? channel);
#else
public delegate void AudioPlayCallback1(IGModAudioChannel channel);
#endif

/// <param name="channel">The sound channel.</param>
/// <param name="errorCode">ID of an error, if an error has occured.</param>
#if STARFALL
public delegate void AudioPlayCallback2(IGModAudioChannel? channel, BASS_ERROR? errorCode);
#else
public delegate void AudioPlayCallback2(IGModAudioChannel channel, BASS_ERROR? errorCode);
#endif

/// <param name="channel">The sound channel.</param>
/// <param name="errorCode">ID of an error, if an error has occured.</param>
/// <param name="errorName">Name of an error, if an error has occured.</param>
#if STARFALL
public delegate void AudioPlayCallback3(IGModAudioChannel? channel, BASS_ERROR? errorCode, string? errorName);
#else
public delegate void AudioPlayCallback3(IGModAudioChannel channel, BASS_ERROR? errorCode, string? errorName);
#endif

/// @CSharpLua.Ignore
public partial interface IGModAudioChannel
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
}
#endif

/// @CSharpLua.Ignore
public sealed partial class Sound
{
    private extern Sound();

    public extern bool IsPlaying();

    public extern void Play();

    public extern void SetSoundLevel(double decibelLevel);

    public extern void Stop();
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
    public static extern void Send(BasePlayer[] playersTable);
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

    /// @CSharpLua.Template = net.Broadcast()
    public static extern void Broadcast();
#endif

#if !STARFALL
    /// @CSharpLua.Template = net.BytesLeft()
    [Pure]
    public static extern (int?, int?) BytesLeft();

    /// @CSharpLua.Template = net.BytesWritten()
    [Pure]
    public static extern (int?, int?) BytesWritten();
#endif

#if STARFALL
    /// @CSharpLua.Template = net.readAngle()
#else
    /// @CSharpLua.Template = net.ReadAngle()
#endif
    [Pure]
    public static extern Angle ReadAngle();

#if STARFALL
    /// @CSharpLua.Template = net.writeAngle({0})
#else
    /// @CSharpLua.Template = net.WriteAngle({0})
#endif
    public static extern void WriteAngle(Angle angle);

#if STARFALL
    /// @CSharpLua.Template = net.readBit()
#else
    /// @CSharpLua.Template = net.ReadBit()
#endif
    [Pure]
    public static extern byte ReadBit();

#if STARFALL
    /// @CSharpLua.Template = net.writeBit({0})
    public static extern void WriteBit(byte bit);
#else
    /// @CSharpLua.Template = net.WriteBit({0})
    public static extern void WriteBit(bool bit);
#endif

#if STARFALL
    /// @CSharpLua.Template = net.readBool()
#else
    /// @CSharpLua.Template = net.ReadBool()
#endif
    [Pure]
    public static extern bool ReadBool();

#if STARFALL
    /// @CSharpLua.Template = net.writeBool({0})
#else
    /// @CSharpLua.Template = net.WriteBool({0})
#endif
    public static extern void WriteBool(bool value);

#if STARFALL
    /// @CSharpLua.Template = net.readColor()
#else
    /// @CSharpLua.Template = net.ReadColor()
#endif
    [Pure]
    public static extern Color ReadColor();

#if STARFALL
    /// @CSharpLua.Template = net.writeColor({0})
#else
    /// @CSharpLua.Template = net.WriteColor({0})
#endif
    public static extern void WriteColor(Color color);

#if STARFALL
    /// @CSharpLua.Template = net.readData({0})
#else
    /// @CSharpLua.Template = net.ReadData({0})
#endif
    [Pure]
    public static extern string ReadData(ushort length);

#if STARFALL
    /// @CSharpLua.Template = net.writeData({0}, {1})
#else
    /// @CSharpLua.Template = net.WriteData({0}, {1})
#endif
    public static extern void WriteData(string value, ushort length);

#if STARFALL
    /// @CSharpLua.Template = net.readDouble()
#else
    /// @CSharpLua.Template = net.ReadDouble()
#endif
    [Pure]
    public static extern double ReadDouble();

#if STARFALL
    /// @CSharpLua.Template = net.writeDouble({0})
#else
    /// @CSharpLua.Template = net.WriteDouble({0})
#endif
    public static extern void WriteDouble(double value);

#if STARFALL
    /// @CSharpLua.Template = net.readEntity()
#else
    /// @CSharpLua.Template = net.ReadEntity()
#endif
    [Pure]
    public static extern BaseEntity ReadEntity();

#if STARFALL
    /// @CSharpLua.Template = net.readEntity()
#else
    /// @CSharpLua.Template = net.ReadEntity()
#endif
    [Pure]
    public static extern T ReadEntity<T>() where T : BaseEntity;

#if STARFALL
    /// @CSharpLua.Template = net.writeEntity({0})
#else
    /// @CSharpLua.Template = net.WriteEntity({0})
#endif
    public static extern void WriteEntity(BaseEntity ent);

#if STARFALL
    /// @CSharpLua.Template = net.readFloat()
#else
    /// @CSharpLua.Template = net.ReadFloat()
#endif
    [Pure]
    public static extern float ReadFloat();

#if STARFALL
    /// @CSharpLua.Template = net.writeFloat({0})
#else
    /// @CSharpLua.Template = net.WriteFloat({0})
#endif
    public static extern void WriteFloat(float value);

#if !STARFALL
    /// @CSharpLua.Template = net.ReadHeader()
    [Pure]
    public static extern ushort ReadHeader();
#endif

#if STARFALL
    /// @CSharpLua.Template = net.readInt({0})
#else
    /// @CSharpLua.Template = net.ReadInt({0})
#endif
    [Pure]
    public static extern int ReadInt(int bitCount);

#if STARFALL
    /// @CSharpLua.Template = net.writeInt({0}, {1})
#else
    /// @CSharpLua.Template = net.WriteInt({0}, {1})
#endif
    public static extern void WriteInt(int value, int bitCount);

#if STARFALL
    /// @CSharpLua.Template = net.readMatrix()
#else
    /// @CSharpLua.Template = net.ReadMatrix()
#endif
    [Pure]
    public static extern VMatrix ReadMatrix();

#if STARFALL
    /// @CSharpLua.Template = net.writeMatrix({0})
#else
    /// @CSharpLua.Template = net.WriteMatrix({0})
#endif
    public static extern void WriteMatrix(VMatrix value);

#if STARFALL
    /// @CSharpLua.Template = net.readNormal()
#else
    /// @CSharpLua.Template = net.ReadNormal()
#endif
    [Pure]
    public static extern Vector ReadNormal();

#if STARFALL
    /// @CSharpLua.Template = net.writeNormal({0})
#else
    /// @CSharpLua.Template = net.WriteNormal({0})
#endif
    public static extern void WriteNormal(Vector value);

#if STARFALL
    /// @CSharpLua.Template = net.readString()
#else
    /// @CSharpLua.Template = net.ReadString()
#endif
    [Pure]
    public static extern string ReadString();

#if STARFALL
    /// @CSharpLua.Template = net.writeString({0})
#else
    /// @CSharpLua.Template = net.WriteString({0})
#endif
    public static extern void WriteString(string value);

#if STARFALL
    /// @CSharpLua.Template = net.readTable()
#else
    /// @CSharpLua.Template = net.ReadTable()
#endif
    [Pure]
    public static extern dynamic ReadTable();

#if STARFALL
    /// @CSharpLua.Template = net.writeTable({0})
#else
    /// @CSharpLua.Template = net.WriteTable({0})
#endif
    public static extern void WriteTable(dynamic value);

    // TODO: Type

#if STARFALL
    /// @CSharpLua.Template = net.readUInt({0})
#else
    /// @CSharpLua.Template = net.ReadUInt({0})
#endif
    [Pure]
    public static extern uint ReadUInt(int numberOfBits);

#if STARFALL
    /// @CSharpLua.Template = net.writeUInt({0}, {1})
#else
    /// @CSharpLua.Template = net.WriteUInt({0}, {1})
#endif
    public static extern void WriteUInt(uint value, int numberOfBits);

#if STARFALL
    /// @CSharpLua.Template = net.readVector()
#else
    /// @CSharpLua.Template = net.ReadVector()
#endif
    [Pure]
    public static extern Vector ReadVector();

#if STARFALL
    /// @CSharpLua.Template = net.writeVector({0})
#else
    /// @CSharpLua.Template = net.WriteVector({0})
#endif
    public static extern void WriteVector(Vector value);
}

/// @CSharpLua.Ignore
public static partial class coroutine
{
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

#if CLIENT
/// @CSharpLua.Ignore
public enum TEXT_ALIGN
{
    LEFT,
    CENTER,
    RIGHT,
    TOP,
    BOTTOM
}

/// @CSharpLua.Ignore
public enum TEXFILTER
{
    NONE = 0,
    POINT = 1,
    LINEAR = 2,
    ANISOTROPIC = 3
}

/// @CSharpLua.Ignore
public enum MATERIAL_CULLMODE
{
    /// <summary>Counter-clock-wise cull mode</summary>
    CCW = 0,

    /// <summary>Clock-wise cull mode</summary>
    CW = 1
}

/// @CSharpLua.Ignore
public enum MATERIAL_FOG
{
    /// <summary>No fog</summary>
    NONE = 0,

    /// <summary>Linear fog</summary>
    LINEAR = 1,

    /// <summary>For use in conjunction with `render.SetFogZ`. Does not work if start distance is bigger than end distance. Ignores density setting. Seems to be broken? Used for underwater fog by the engine.</summary>
    LINEAR_BELOW_FOG_Z = 2
}

/// @CSharpLua.Ignore
public enum STENCILCOMPARISONFUNCTION
{
    NEVER = 1, // Never passes.
    LESS = 2, // Passes where the reference value is less than the stencil value.
    EQUAL = 3, // Passes where the reference value is equal to the stencil value.
    LESSEQUAL = 4, // Passes where the reference value is less than or equal to the stencil value.
    GREATER = 5, // Passes where the reference value is greater than the stencil value.
    NOTEQUAL = 6, // Passes where the reference value is not equal to the stencil value.
    GREATEREQUAL = 7, // Passes where the reference value is greater than or equal to the stencil value.
    ALWAYS = 8 // Always passes.
}

/// @CSharpLua.Ignore
public enum STENCIL
{
    NEVER = 1, // Never passes.
    LESS = 2, // Passes where the reference value is less than the stencil value.
    EQUAL = 3, // Passes where the reference value is equal to the stencil value.
    LESSEQUAL = 4, // Passes where the reference value is less than or equal to the stencil value.
    GREATER = 5, // Passes where the reference value is greater than the stencil value.
    NOTEQUAL = 6, // Passes where the reference value is not equal to the stencil value.
    GREATEREQUAL = 7, // Passes where the reference value is greater than or equal to the stencil value.
    ALWAYS = 8, // Always passes.

    KEEP = 1, // Preserves the existing stencil buffer value.
    ZERO = 2, // Sets the value in the stencil buffer to 0.
    REPLACE = 3, // Sets the value in the stencil buffer to the reference value, set using `render.SetStencilReferenceValue`.
    INCRSAT = 4, // Increments the value in the stencil buffer by 1, clamping the result.
    DECRSAT = 5, // Decrements the value in the stencil buffer by 1, clamping the result.
    INVERT = 6, // Inverts the value in the stencil buffer.
    INCR = 7, // Increments the value in the stencil buffer by 1, wrapping around on overflow.
    DECR = 8 // Decrements the value in the stencil buffer by 1, wrapping around on overflow.
}
#endif
