using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.Models
{
    /// <summary>Particles class</summary>
    [StructLayout(LayoutKind.Sequential)]
    public class Particle
    {
        // Relative path to the file
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string FileName;

        // Position of the particle
        public float PositionX, PositionY, PositionZ;

        // Reserved bytes
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public sbyte[] Reserved;
    }
}
