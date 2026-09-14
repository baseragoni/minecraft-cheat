namespace McCheat.Core.Memory;

/// <summary>Structure offsets for Minecraft — update after each game patch.</summary>
public static class Offsets
{
    /// <summary>Module-level addresses (relative to module base).</summary>
    public static class Client
    {
        public const nint LocalPlayer        = 0x17898E0;
        public const nint EntityList         = 0x19A0A5B;
        public const nint ViewMatrix         = 0x1909962;
        public const nint GameRules          = 0x198A606;
        public const nint GlobalVars         = 0x1722C67;
        public const nint InputSystem        = 0x1A510FB;
    }

    /// <summary>Entity / pawn struct field offsets.</summary>
    public static class Entity
    {
        public const nint Health             = 0x3E0;
        public const nint TeamNum            = 0x3B8;
        public const nint Origin             = 0x125B;
        public const nint EyeAngles          = 0x167A;
        public const nint SceneNode          = 0x362;
        public const nint ModelState         = 0x1A0;
        public const nint ShotsFired         = 0x2606;
        public const nint AimPunch           = 0x1750;
        public const nint IsScoped           = 0x2367;
        public const nint CrosshairId        = 0x1842;
        public const nint Flags              = 0x1FB;
        public const nint Velocity           = 0x14F5;
        public const nint FlashDuration      = 0x14C5;
        public const nint SpottedMask        = 0x175B;
        public const nint BoneMatrix         = 0xAE5;
    }

    /// <summary>Bone indices for skeleton rendering and aim targeting.</summary>
    public static class Bones
    {
        public const int Head               = 6;
        public const int Neck               = 5;
        public const int SpineUpper         = 4;
        public const int SpineMid           = 3;
        public const int Pelvis             = 0;
        public const int LeftShoulder       = 8;
        public const int LeftElbow          = 9;
        public const int LeftHand           = 13;
        public const int RightShoulder      = 30;
        public const int RightElbow         = 31;
        public const int RightHand          = 35;
        public const int LeftKnee           = 22;
        public const int LeftFoot           = 24;
        public const int RightKnee          = 44;
        public const int RightFoot          = 46;
    }
}
