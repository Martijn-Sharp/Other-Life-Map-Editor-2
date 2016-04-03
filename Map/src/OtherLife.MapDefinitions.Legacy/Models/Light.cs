using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.Models
{
    /// <summary>Light class</summary>
	[StructLayout(LayoutKind.Sequential)]
    public class Light
    {
        // Position of the light
        public float PositionX, PositionY, PositionZ;

        // Color of the light
        public float R, G, B;

        // Quadric attenuation of the light
        public float QuadricAttenuation;

        // Reserved bytes
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public sbyte[] Reserved;
    }
}
