using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.Models
{
    /// <summary>2D Object class</summary>
	[StructLayout(LayoutKind.Sequential)]
    public class Object2D
    {
        // Relative path to the file
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string FileName;

        // Position of the object
        public float PositionX, PositionY, PositionZ;

        // Rotation of the object
        public float RotationX, RotationY, RotationZ;

        // Reserved bytes
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public sbyte[] Reserved;
    }
}
