
namespace Toolbox
{

    public enum DestructEffect
    {
        Destroy,
        Relenquish,
    }

    public enum DisableEffect
    {
        Disable,
        Destroy,
        Relenquish,
    }

    public enum DispatchOption
    {
        None,
        Messages,
        UnityEvents,
        Both = Messages | UnityEvents,
    }

    public enum CollisionTiming
    {
        Enter,
        Stay,
        Exit,
        None,
    }

    public enum EventTiming
    {
        Awake,
        Enable,
        Start,
        Disable,
        Destroy,
        Relenquish,
        None,
    }

    public enum StartEventTiming
    {
        Awake,
        Start,
        Enable,
        None,
    }

    public enum EventAndCollisionTiming
    {
        Awake,
        Enable,
        Start,
        Disable,
        Destroy,
        Triggered,
        Relenquished,
        None,
        TriggerExit,
    }

    public enum FullEventTiming
    {
        Awake,
        Enable,
        Start,
        Disable,
        Destroy,

        EnterPool,
        ExitPool,

        Update,
        FixedUpdate,
        LateUpdate,

        TriggerEnter,
        TriggerStay,
        TriggerExit,
        CollisionEnter,
        CollisionStay,
        CollisionExit,

        Relenquish,
        None,
    }

    public enum StateOperation
    {
        Activate,
        Relenquish,
        Deactivate,
        Destroy,
    }

    public enum UpdateTiming
    {
        Update,
        LateUpdate,
        FixedUpdate
    }

    public enum UpdateModes
    {
        Manual,
        Update,
        LateUpdate,
        FixedUpdate,
    }

    public enum UpdateTimingSmoothOnly
    {
        Update,
        LateUpdate,
    }

}