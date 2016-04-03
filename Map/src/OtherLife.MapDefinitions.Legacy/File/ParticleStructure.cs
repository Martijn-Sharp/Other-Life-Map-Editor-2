using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.File
{
    /// <summary>Particles class</summary>
	[StructLayout(LayoutKind.Sequential)]
    public class ParticleStructure
    {
        /// <summary>Relative path to the file</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string FileName;
        
        /// <summary>Position of the particle</summary>
        public float PositionX, PositionY, PositionZ;
        
        /// <summary>Reserved bytes</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public sbyte[] Reserved;
    }
}
