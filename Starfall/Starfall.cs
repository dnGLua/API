//#define CLIENT // TODO: Remove me
//#define SERVER // TODO: Remove me
//#define FEATURE_PROPERTIES // TODO: Remove me

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
using System.Diagnostics.Contracts;

/// @CSharpLua.Ignore
internal static class Starfall { /* Reserved */ }

/// @CSharpLua.Ignore
public static partial class _G
{
    /// @CSharpLua.NoField
    [Pure]
    public static extern BasePlayer Owner { get; }

    /// @CSharpLua.NoField
    [Pure]
    public static extern BaseEntity Chip { get; }

    /// @CSharpLua.Template = _G.owner()
    [Pure]
    public static extern BasePlayer GetOwner();

    /// @CSharpLua.Template = _G.chip()
    [Pure]
    public static extern BaseEntity GetChip();

    // TODO: requiredir, dodir, dofile & --@include directives

    /// @CSharpLua.Template = holograms.create({0}, {1}, {2})
    [Pure]
    public static extern Hologram Hologram(Vector pos, Angle ang, string model);

    /// @CSharpLua.Template = holograms.create({0}, {1}, {2}, {3})
    [Pure]
    public static extern Hologram Hologram(Vector pos, Angle ang, string model, Vector scale);

    /// @CSharpLua.Template = System.Tuple(hasPermission({0}))
    [Pure]
    public static extern (bool, string?) HasPermission(string perm);

    /// @CSharpLua.Template = System.Tuple(hasPermission({0}, {1}))
    [Pure]
    public static extern (bool, string?) HasPermission(string perm, object? obj);

#if CLIENT
    /// @CSharpLua.Template = _G.permissionRequestSatisfied()
    [Pure]
    public static extern bool PermissionRequestSatisfied();

    /// @CSharpLua.Template = _G.setupPermissionRequest({0}, {1}, {2})
    public static extern void SetupPermissionRequest(string[] perms, string desc, bool showOnUse);
#endif

    /// @CSharpLua.Template = _G.quotaUsed()
    [Pure]
    public static extern double QuotaUsed();

    /// @CSharpLua.Template = _G.quotaAverage()
    [Pure]
    public static extern double QuotaAverage();

    /// @CSharpLua.Template = _G.ramUsed()
    [Pure]
    public static extern double RamUsed();

    /// @CSharpLua.Template = _G.ramAverage()
    [Pure]
    public static extern double RamAverage();

    /// @CSharpLua.Template = _G.ramMax()
    [Pure]
    public static extern double RamMax();

    /// @CSharpLua.Template = _G.version()
    [Pure]
    public static extern string Version();

    /// @CSharpLua.Template = _G.quotaTotalUsed()
    [Pure]
    public static extern double QuotaTotalUsed();

    /// @CSharpLua.Template = _G.quotaTotalAverage()
    [Pure]
    public static extern double QuotaTotalAverage();

    /// @CSharpLua.Template = _G.quotaMax()
    [Pure]
    public static extern double QuotaMax();

    /// @CSharpLua.Template = _G.setSoftQuota({0})
    public static extern void SetSoftQuota(double quota);

    // TODO
}

public partial class BaseEntity
{
#if SERVER
    public extern void Unparent();

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public BaseEntity[] LinkedComponents { get; }
#else
    [Pure]
    public extern BaseEntity[] getLinkedComponents();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public Wirelink Wirelink { get; }
#else
    [Pure]
    public extern Wirelink getWirelink();
#endif
#endif

    /// @CSharpLua.NoField
    public BasePlayer Owner { get; }

    public extern void LinkComponent(BaseEntity? ent);
}

#region Hooks / Events

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

//public sealed partial class Remote : EventBase
//{
//    private const string ID = "remote";

//    public Remote(Action<BaseEntity, BasePlayer, object?[]?> func) : base(ID, func, false) { }

//    public Remote(Action<EventBase, BaseEntity, BasePlayer, object?[]?> func) : base(ID, func, true) { }
//}

//public sealed partial class Remote<TOut> : EventBase
//{
//    private const string ID = "remote";

//    public Remote(Func<BaseEntity, BasePlayer, object?[]?, TOut> func) : base(ID, func, false) { }

//    public Remote(Func<EventBase, BaseEntity, BasePlayer, object?[]?, TOut> func) : base(ID, func, true) { }
//}

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
#endif // CLIENT

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
#endif // SERVER

#endregion Hooks

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

#if SERVER
public sealed partial class Wirelink
{
    /// @CSharpLua.Template = wire.getWirelink({0})
    public extern Wirelink(BaseEntity entity);

    public dynamic this[string name]
    {
        get
        {
            return _G.REMOVEME_Internal_Return_Hack_REMOVEME();
            /*
            [[
              return this[name]
            ]]
            */
        }
        set
        {
            /*
            [[
              this[name] = value
            ]]
            */
        }
    }

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern BaseEntity Entity
    {
        get;
    }
#else
    [Pure]
    public extern BaseEntity Entity();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern bool IsValid
    {
        get;
    }
#else
    [Pure]
    public extern bool IsValid();
#endif

    [Pure]
    public extern bool IsWired(string inputName);

    [Pure]
    public extern BaseEntity GetWiredTo(string inputName);

    [Pure]
    public extern string GetWiredToName(string inputName);

    [Pure]
    public extern string InputType(string inputName);

    [Pure]
    public extern string OutputType(string outputName);

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern dynamic Inputs
    {
        get;
    }
#else
    [Pure]
    public extern dynamic Inputs();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern dynamic Outputs
    {
        get;
    }
#else
    [Pure]
    public extern dynamic Outputs();
#endif
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

    /// @CSharpLua.Template = System.Tuple(wire.getInputs({0}))
    [Pure]
    public static extern (string[], string[]) GetInputs(BaseEntity entity);

    /// @CSharpLua.Template = System.Tuple(wire.getOutputs({0}))
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

/// @CSharpLua.Ignore
public static partial class net
{
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern int BytesLeft { get; }

    /// @CSharpLua.NoField
    public static extern int BitsLeft { get; }

    /// @CSharpLua.NoField
    public static extern double StreamProgress { get; }

    /// @CSharpLua.NoField
    public static extern bool IsStreaming { get; }
#else
    /// @CSharpLua.Template = net.getBytesLeft()
    public static extern int GetBytesLeft();

    /// @CSharpLua.Template = net.getBitsLeft()
    public static extern int GetBitsLeft();

    /// @CSharpLua.Template = net.getStreamProgress()
    public static extern double GetStreamProgress();

    /// @CSharpLua.Template = net.isStreaming()
    public static extern bool IsStreaming();
#endif

    /// @CSharpLua.Template = net.cancelStream()
    public static extern void CancelStream();

#if CLIENT
    /// @CSharpLua.Template = net.readEntity({0})
    public static extern void ReadEntity(Action<BaseEntity?> callback);
#endif

    /// @CSharpLua.Template = net.readStream({0})
    public static extern void ReadStream(Action<string?> callback);

    /// @CSharpLua.Template = net.writeStream({0}, {1})
    public static extern void WriteStream(string data, bool compress = true);
}

/// @CSharpLua.Ignore
public static partial class math
{
    /// @CSharpLua.Template = math.sign({0})
    [Pure]
    public static extern int sign(double num);
}

/// @CSharpLua.Ignore
public static partial class util
{
    /// @CSharpLua.Template = trace.trace({0}, {1}, {2}, {3}, {4}, {5})
    [Pure]
    public static extern TraceResult? TraceLine(Vector start, Vector endpos, BaseEntity? filter = null, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);

    /// @CSharpLua.Template = trace.traceHull({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})
    [Pure]
    public static extern TraceResult? TraceHull(Vector start, Vector endpos, Vector maxs, Vector mins, BaseEntity? filter = null, uint? mask = /*MASK.SOLID*/null, COLLISION_GROUP? collisiongroup = /*COLLISION_GROUP.NONE*/null, bool? ignoreworld = /*false*/null);
}

/// @CSharpLua.Ignore
public static partial class timer
{
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern int TimersLeft { get; }
#else
    /// @CSharpLua.Template = timer.getTimersLeft()
    [Pure]
    public static extern int GetTimersLeft();
#endif

    /// @CSharpLua.NoField
    public static extern bool CanCreate { get; }
}

/// @CSharpLua.Ignore
public static partial class ents
{
    /// @CSharpLua.Template = find.all({0})
    [Pure]
    public static extern BaseEntity[] GetAll(Func<BaseEntity, bool> filter);

    /// @CSharpLua.Template = find.byClass({0}, {1})
    [Pure]
    public static extern BaseEntity[] FindByClass(string className, Func<BaseEntity, bool> filter);

    /// @CSharpLua.Template = find.inBox({0}, {1}, {2})
    [Pure]
    public static extern BaseEntity[] FindInBox(Vector min, Vector max, Func<BaseEntity, bool> filter);

    /// @CSharpLua.Template = find.inSphere({0}, {1}, {2})
    [Pure]
    public static extern BaseEntity[] FindInSphere(Vector center, double radius, Func<BaseEntity, bool> filter);

    /// @CSharpLua.Template = find.inRay({0}, {1}, nil, nil, {2})
    [Pure]
    public static extern BaseEntity[] FindAlongRay(Vector startPos, Vector endPos, Func<BaseEntity, bool> filter);

    /// @CSharpLua.Template = find.inRay({0}, {1}, {2}, {3}, {4})
    [Pure]
    public static extern BaseEntity[] FindAlongRay(Vector startPos, Vector endPos, Vector mins, Vector maxs, Func<BaseEntity, bool> filter);

#if SERVER
    /// @CSharpLua.Template = find.inPVS({0}, {1})
    [Pure]
    public static extern BaseEntity[] FindInPVS(Vector pos, Func<BaseEntity, bool> filter);
#endif
}

/// @CSharpLua.Ignore
public static partial class player
{
    /// @CSharpLua.Template = find.allPlayers({0})
    [Pure]
    public static extern BasePlayer[] GetAll(Func<BasePlayer, bool> filter);
}

/// @CSharpLua.Ignore
public static partial class bass
{
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
}

/// @CSharpLua.Ignore
public static partial class sound
{
    // SF: "sounds"

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
}

/// @CSharpLua.Ignore
public sealed partial class Sound
{
    public extern void Destroy();

    public extern void SetPitch(double volume);

    public extern void SetPitch(double volume, double fade);

    public extern void SetVolume(double volume);

    public extern void SetVolume(double volume, double fade);

    public extern void Stop(double fade);
}

/// @CSharpLua.Ignore
public partial interface IGModAudioChannel
{
    // SF: "Bass"

    void Destroy();
}

/// @CSharpLua.Ignore
public static partial class fastlz
{
    /// @CSharpLua.Template = fastlz.compress({0})
    [Pure]
    public static extern string Compress(string data);

    /// @CSharpLua.Template = fastlz.decompress({0})
    [Pure]
    public static extern string Decompress(string compressedData);
}

/// @CSharpLua.Ignore
public static partial class http
{
#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public static extern bool CanRequest { get; }
#else
    /// @CSharpLua.Template = http.canRequest()
    [Pure]
    public static extern bool CanRequest();
#endif
}

#if CLIENT
/// @CSharpLua.Ignore
public static partial class render
{
    /// @CSharpLua.Template = render.setRGBA({0})
    public static extern void SetDrawColor(Color clr);

    /// @CSharpLua.Template = render.setRGBA({0}, {1}, {2}, {3})
    public static extern void SetDrawColor(int r, int g, int b, int a);

    /// @CSharpLua.Template = render.createMaterial({0}, {1}, {2})
    [Pure]
    public static extern Material CreateMaterial(string data, Action<Material, string, int, int, Action<int, int, int, int>> cb, Action<Material, string> done);

    /// @CSharpLua.Template = render.destroyTexture({0})
    public static extern void DestroyTexture(Material material);

    /// @CSharpLua.Template = render.setMaterial({0})
    public static extern void SetMaterial(Material material);

    /// @CSharpLua.Template = render.drawBlurEffect({0}, {1}, {2})
    public static extern void DrawBlurEffect(double blurX, double blurY, int passes);

    /// @CSharpLua.Template = render.drawRectFast({0}, {1}, {2}, {3})
    public static extern void DrawRectFast(int x, int y, int w, int h);

    /// @CSharpLua.Template = render.drawRect({0}, {1}, {2}, {3})
    public static extern void DrawRect(int x, int y, int w, int h);

    /// @CSharpLua.Template = render.drawRectOutline({0}, {1}, {2}, {3}, {4})
    public static extern void DrawRectOutline(int x, int y, int w, int h, int thickness);

    /// @CSharpLua.Template = render.drawLine({0}, {1}, {2}, {3})
    public static extern void DrawLine(int x1, int y1, int x2, int y2);

    /// @CSharpLua.Template = render.createFont({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})
    [Pure]
    public static extern string CreateFont(string fontName, int fontSize = 16, int weight = 400, bool antialias = true, bool additive = true, bool shadow = false, bool outline = false, bool blur = false, bool extended = true);

    /// @CSharpLua.Template = render.setFont({0})
    public static extern void SetFont(string fontName);

    /// @CSharpLua.Template = System.Tuple(render.getTextSize({0}))
    [Pure]
    public static extern (int, int) GetTextSize(string text);

    /// @CSharpLua.Template = render.drawText({0}, {1}, {2}, {3})
    public static extern void DrawText(int x, int y, string text, TEXT_ALIGN alignment);

    /// @CSharpLua.Template = render.drawSimpleText({0}, {1}, {2}, {3}, {4})
    public static extern void DrawSimpleText(int x, int y, string text, TEXT_ALIGN xAlignment, TEXT_ALIGN yAlignment);

    /// @CSharpLua.Template = System.Tuple(render.cursorPos())
    [Pure]
    public static extern (int, int) CursorPos();

    /// @CSharpLua.Template = System.Tuple(render.cursorPos({0}))
    [Pure]
    public static extern (int, int) CursorPos(BasePlayer ply);

    /// @CSharpLua.Template = System.Tuple(render.cursorPos({0}, {1}))
    [Pure]
    public static extern (int, int) CursorPos(BasePlayer ply, BaseEntity screen);

    /// @CSharpLua.Template = System.Tuple(render.getResolution())
    [Pure]
    public static extern (int, int) GetResolution();

    /// @CSharpLua.Template = System.Tuple(render.getGameResolution())
    [Pure]
    public static extern (int, int) GetGameResolution();

    /// @CSharpLua.Template = render.isHUDActive()
    [Pure]
    public static extern bool IsHUDActive();

    /// @CSharpLua.Template = render.setHUDActive()
    public static extern void SetHUDActive();
}
#endif

/// @CSharpLua.Ignore
public static partial class bit
{
    /// @CSharpLua.Template = bit.stringstream()
    [Pure]
    public static extern StringStream StringStream();

    /// @CSharpLua.Template = bit.stringstream({0})
    [Pure]
    public static extern StringStream StringStream(string initialBuffer);

    /// @CSharpLua.Template = bit.stringstream({0}, {1}, {2})
    [Pure]
    public static extern StringStream StringStream(string initialBuffer, uint position = 1, string endianess = "little");
}

/// @CSharpLua.Ignore
public sealed partial class StringStream
{
    internal dynamic buffer;
    internal uint pos;

    /// @CSharpLua.Template = bit.stringstream()
    public extern StringStream();

    /// @CSharpLua.Template = bit.stringstream({0})
    public extern StringStream(string initialBuffer);

    /// @CSharpLua.Template = bit.stringstream({0}, {1}, {2})
    public extern StringStream(string initialBuffer, uint position = 1, string endianess = "little");

    // MY NOTE: These methods must begin with lower-case letter because we're not wrapping Starfall side just to have uppercase-first char.

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern dynamic Buffer { get; }
#else
    public extern dynamic getBuffer();
#endif

#if FEATURE_PROPERTIES
    /// @CSharpLua.NoField
    public extern string String { get; }
#else
    public extern string getString();
#endif

    public extern void setEndian(string endianess);

    public extern dynamic readBytesEndian(uint start, uint stop);

    public extern void writeBytesEndian(uint start, uint stop, dynamic t);

    public extern void seek(uint position);

    public extern void skip(uint offset);

    public extern uint tell();

    public extern int size();

    public extern string read(uint amount);

    public extern byte readUInt8();

    public extern ushort readUInt16();

    public extern uint readUInt32();

    public extern sbyte readInt8();

    public extern short readInt16();

    public extern int readInt32();

    public extern float readFloat();

    public extern double readDouble();

    public extern string readUntil(byte value);

    public extern string readString();

    public extern void write(string bytes);

    public extern void writeInt8(sbyte value);

    public extern void writeInt16(short value);

    public extern void writeInt32(int value);

    public extern void writeFloat(float value);

    public extern void writeDouble(double value);

    public extern void writeString(string value);
}
