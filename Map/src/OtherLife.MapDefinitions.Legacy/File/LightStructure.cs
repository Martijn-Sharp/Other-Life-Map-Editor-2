using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.File
{
    /// <summary>Light class</summary>
	[StructLayout(LayoutKind.Sequential)]
    public class LightStructure
    {
        /// <summary>Position of the light</summary>
        public float PositionX, PositionY, PositionZ;
        
        /// <summary>Color of the light</summary>
        public float R, G, B;
        
        /// <summary>Quadric attenuation of the light</summary>
        public float QuadricAttenuation;
        
        /// <summary>Reserved bytes</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public sbyte[] Reserved;
    }
}
